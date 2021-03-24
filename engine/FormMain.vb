Imports System.IO
Imports vblibusb

Public Class FormMain

    Public FilesDetected As List(Of Virus)
    Public EngineScan As EngineScan
    Private Options As ScanOptions

    Public path As String
    Public tScan As TypeScan

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        If FileScanner.IsBusy = True Then FileScanner.CancelAsync()
    End Sub

    Private Sub FileScanner_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FileScanner.DoWork
        On Error Resume Next
        Dim Folders As New List(Of DirectoryInfo)
        Dim Files As New List(Of String)
        Dim virus As Virus
        FilesDetected = New List(Of Virus)

        Select Case tScan
            Case TypeScan.FULL_SCAN
                For Each Driver As DriveInfo In My.Computer.FileSystem.Drives
                    'If Driver.Name = "C:\" Then Continue For
                    Folders.AddRange(GetFolders(Driver.Name))
                    If FileScanner.CancellationPending = True Then Exit For
                Next
                MysticTheme1.Text = "Analizando sistema"

            Case TypeScan.QUICK_SCAN
                For Each Directory_Info As String In SPECIALDIRECTORIESSS()
                    If Directory.Exists(Directory_Info) Then
                        Folders.AddRange(GetFolders(Directory_Info))
                    End If
                    If FileScanner.CancellationPending = True Then Exit For
                Next
                MysticTheme1.Text = "Analizando sistema (rápido)"

            Case TypeScan.DRIVE_SCAN
                Folders.AddRange(LogicUSB.GetFolders(path))
                MysticTheme1.Text = "Analizando " & path

            Case TypeScan.FILE_SCAN
                MsgBox(path)
            Case Else

        End Select

        MysticTheme1.Invalidate()

        If tScan = TypeScan.FILE_SCAN Then
            ScanFile(path)
        Else
            progressTotal.Value = 0
            progressTotal.Maximum = Folders.Count

            For Each Element_Directory As DirectoryInfo In Folders
                Files.Clear()
                Files.AddRange(Directory.GetFiles(Element_Directory.FullName, "*.*", SearchOption.TopDirectoryOnly))
                progressFile.Value = 0
                progressFile.Maximum = Files.Count

                For Each ElementFile As String In Files
                    ScanFile(ElementFile)
                    progressFile.Value += 1
                    If FileScanner.CancellationPending = True Then Exit For
                Next

                progressTotal.Value += 1
                If FileScanner.CancellationPending = True Then Exit For
            Next
        End If
        
    End Sub

    Private Sub FileScanner_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles FileScanner.RunWorkerCompleted
        Me.Hide()

        If Options.checkResultadoAna Then
            Dim handle As Integer = Messages.FindWindow(vbNullString, "USBSecurity - Main")
            If handle > 0 Then
                If FilesDetected.Count = 0 Then
                    Messages.SendMessage(handle, WM_POWER, WM_MESSAGE, WM_SCAN_NOVIRUS)
                ElseIf FilesDetected.Count = 1 Then
                    Messages.SendMessage(handle, WM_POWER, WM_MESSAGE, WM_SCAN_ONEVIRUS)
                ElseIf FilesDetected.Count > 1 Then
                    Messages.SendMessage(handle, WM_POWER, WM_MESSAGE, WM_SCAN_MANYVIRUS)
                End If
            End If
        End If

        If Options.checkReprodSounds Then
            LogicUSB.sndPlaySound("sound\sound04.wav", SND_ASYNC)
        End If

        Dim filesToQuar As New List(Of Virus)
        For Each virus As Virus In FilesDetected
            If Options.comboDetectMalware = 1 Then ' Añadir directamente a la cuarentena
                Dim f = My.Computer.FileSystem.GetFileInfo(virus.filepath)

                If AddToQuarantine(virus.filepath, virus.size, virus.malware) Then
                    filesToQuar.Add(virus)
                    LogMalware(Now.ToString & "*" & My.User.Name & "*" & f.Name & "*" & f.DirectoryName & "*" & virus.malware & "*Movido a cuarentena")
                Else
                    LogMalware(Now.ToString & "*" & My.User.Name & "*" & f.Name & "*" & f.DirectoryName & "*" & virus.malware & "*No se pudo mover a cuarentena. Reinicie la PC e inténtelo de nuevo.")
                End If
            ElseIf Options.comboDetectMalware = 0 Then ' Preguntar al usuario
                'If getValueOfFile("main", "moveAllQuar") Then ' Preguntar al usuario si no marco la casilla "Mover todos a cuarentena"
                FormDetected.detectedVirus = virus
                FormDetected.playSound = False
                FormDetected.ShowDialog()
                'If Detectado.isDes Then
                '    desinfestados = desinfestados + 1
                'End If
                'Else
                '    If AddToQuarantine(vd.filePath, vd.fileSize, vd.fileMD5, vd.fileMalware) Then
                '        desinfestados = desinfestados + 1
                '        InformeQuar.arrToQuar.Add(vd)
                '    End If
                'End If
            End If
        Next

        If Options.checkFilesMoveToQuar And filesToQuar.Count > 0 Then
            Dim fq As New FormQuarantine
            fq.arrToQuar = filesToQuar
            fq.ShowDialog()
        End If

        ' Crear proteccion autorun.inf en el dispositivo
        If tScan = TypeScan.DRIVE_SCAN Then
            SetDriveAutorunFile(path, Options)
            ' Abrir dispositivo despues de escanear
            If Options.checkOpenDevice Then Interaction.Shell("explorer " & path, AppWinStyle.NormalFocus)
        End If

        Me.Dispose()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False

        updatePosition(Me)

        MysticTheme1.Text = "Cargando archivos, por favor espere..."
        'Debug.WriteLine("test for console or debug")

        Options = New ScanOptions
        EngineScan = New EngineScan(Options)

        If FileScanner.IsBusy = False Then
            FileScanner.RunWorkerAsync()
        Else
            MsgBox("Still Running")
        End If

    End Sub

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        If FileScanner.IsBusy = True Then FileScanner.CancelAsync()
    End Sub

    Private Sub ScanFile(filepath As String)
        Dim F As FileInfo = My.Computer.FileSystem.GetFileInfo(filepath)

        labelName.Text = "Nombre: " & F.Name
        labelPath.Text = "Ubicación: " & splitPath(F.DirectoryName, 50) 'FullName 'DirectoryName
        labelSize.Text = "Tamaño: " & LogicUSB.GetBytes(F.Length)
        labelDetect.Text = "Detectados: " & FilesDetected.Count
        If FilesDetected.Count > 0 Then
            labelDetect.ForeColor = Color.FromArgb(255, 128, 128)
        End If

        Dim virus = EngineScan.scanAll(filepath)
        If virus.isMalware Then
            FilesDetected.Add(virus)
        End If
    End Sub

End Class

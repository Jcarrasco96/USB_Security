Imports System.IO
Imports System.ComponentModel
Imports vblibusb

Public Class FormMain

    Public FilesDetected As List(Of Virus)
    Public EngineScan As EngineScan
    Private Options As ScanOptions

    Public path As String
    Public tScan As TypeScan

    Private Sub FileScanner_DoWork(sender As Object, e As DoWorkEventArgs) Handles FileScanner.DoWork
        'On Error Resume Next

        SendMyMessage(WM_SCAN_START)

        Dim Files As New List(Of String)
        FilesDetected = New List(Of Virus)

        Options = New ScanOptions
        EngineScan = New EngineScan(path.Substring(0, 3), Options)

        Select Case tScan
            Case TypeScan.FULL_SCAN ' analizar todo el sistema
                MysticTheme1.Text = "Analizando sistema"
                For Each Driver As DriveInfo In My.Computer.FileSystem.Drives
                    'If Driver.Name = "C:\" Then Continue For
                    Files.AddRange(GetFiles(Driver.Name))
                    If FileScanner.CancellationPending = True Then Exit For
                Next

            Case TypeScan.QUICK_SCAN ' analizar areas criticas del sistema
                MysticTheme1.Text = "Analizando sistema (rápido)"
                For Each Directory_Info As String In SPECIALDIRECTORIESSS()
                    If Directory.Exists(Directory_Info) Then
                        Files.AddRange(GetFiles(Directory_Info))
                    End If
                    If FileScanner.CancellationPending = True Then Exit For
                Next

            Case TypeScan.DRIVE_SCAN ' analizar un hdd, ssd, usb, etc
                MysticTheme1.Text = "Analizando " & path
                Files.AddRange(GetFiles(path))

            Case TypeScan.FILE_SCAN ' analizar un archivo
                Hide()

                Dim v As Virus = EngineScan.ScanAll(path)
                If v.isMalware Then
                    If Options.checkReprodSounds Then
                        sndPlaySound("sound\sound04.wav", SND_ASYNC)
                    End If

                    FormDetected.detectedVirus = v
                    FormDetected.playSound = False
                    FormDetected.ShowDialog()
                End If
                End

            Case TypeScan.FOLDER_SCAN ' analizar una carpeta
                MysticTheme1.Text = "Analizando carpeta " & path
                Files.AddRange(GetFiles(path))

            Case Else

        End Select

        ShowAll()

        If tScan = TypeScan.FILE_SCAN Then
            ScanFile(path)
        Else
            progressTotal.Value = 0
            progressTotal.Maximum = Files.Count

            For Each file As String In Files
                ScanFile(file)
                progressTotal.Value += 1

                lblPercent.Text = Int(progressTotal.Value * 100 / Files.Count) & "%"
                If FileScanner.CancellationPending = True Then Exit For
            Next

        End If

    End Sub

    Private Sub FileScanner_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles FileScanner.RunWorkerCompleted
        Me.Hide()

        SendMyMessage(WM_SCAN_STOP)

        If Options.checkResultadoAna Then
            If FilesDetected.Count = 0 Then
                SendMyMessage(WM_SCAN_NOVIRUS)
            ElseIf FilesDetected.Count = 1 Then
                SendMyMessage(WM_SCAN_ONEVIRUS)
            ElseIf FilesDetected.Count > 1 Then
                SendMyMessage(WM_SCAN_MANYVIRUS)
            End If
        End If

        If Options.checkReprodSounds Then
            sndPlaySound("sound\sound04.wav", SND_ASYNC)
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
            Dim fq As New FormQuarantine With {
                .arrToQuar = filesToQuar
            }
            fq.ShowDialog()
        End If

        ' Crear proteccion autorun.inf en el dispositivo
        If tScan = TypeScan.DRIVE_SCAN Then
            SetDriveAutorunFile(path, Options)
            ' Abrir dispositivo despues de escanear
            If Options.checkOpenDevice Then Shell("explorer " & path, AppWinStyle.NormalFocus)
        End If

        Me.Dispose()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False

        UpdatePosition(Me)

        MysticTheme1.Text = "Cargando archivos, por favor espere..."

        LogFunc(Now.ToString & "*" & UserName & "*Búsqueda*Inicio en " & path)

        ShowAll(False)

        If FileScanner.IsBusy = False Then
            FileScanner.RunWorkerAsync()
        Else
            MsgBox("Still Running")
        End If
    End Sub

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        If FileScanner.IsBusy = True Then FileScanner.CancelAsync()
        Me.Hide()
    End Sub

    Private Sub ScanFile(filepath As String)
        Dim F As FileInfo = My.Computer.FileSystem.GetFileInfo(filepath)

        labelName.Text = "Nombre: " & F.Name
        labelPath.Text = "Ubicación: " & F.DirectoryName ' SplitPath(F.DirectoryName, 50)
        labelSize.Text = "Tamaño: " & GetBytes(F.Length)
        labelDetect.Text = "Detectados: " & FilesDetected.Count
        If FilesDetected.Count > 0 Then
            labelDetect.ForeColor = Color.FromArgb(255, 128, 128)
        End If

        Dim virus = EngineScan.ScanAll(filepath)
        If virus.isMalware Then
            FilesDetected.Add(virus)
        End If
    End Sub

    Private Sub ShowAll(Optional show As Boolean = True)
        labelName.Visible = show
        labelPath.Visible = show
        labelSize.Visible = show
        labelDetect.Visible = show
        'lblPercent.Visible = show
        'progressTotal.Visible = show
        labelLoading.Visible = Not show
    End Sub

End Class

Imports vblibusb

Public Class FormFastScan

    Private Options As ScanOptions
    Private EngineScan As EngineScan
    Private FastScan As FastScanClass
    Private FilesDetected As List(Of Virus)

    Public scanFiles As UInteger

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Dispose()
    End Sub

    Private Sub BwScanner_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwScanner.DoWork
        CheckForIllegalCrossThreadCalls = False

        lblStatus.Text = "Leyendo ajustes guardados..."
        Options = New ScanOptions

        lblStatus.Text = "Iniciando motores de búsqueda..."
        EngineScan = New EngineScan(SystemDrive, Options)
        FastScan = New FastScanClass
        FilesDetected = New List(Of Virus)

        ProcessBases()
        ProcessStart()
        ProcessServices()
        ProcessProcesses()
        ProcessRegistry()
        ProcessCriticZones()

        lblStatus.Text = "Búsqueda finalizada"
    End Sub

    Private Sub BwScanner_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwScanner.RunWorkerCompleted
        MysticButton1.Visible = False
        'Me.Dispose()
    End Sub

    Private Sub FormFastScan_Load(sender As Object, e As EventArgs) Handles Me.Load
        scanFiles = 0

        If bwScanner.IsBusy = False Then
            bwScanner.RunWorkerAsync()
        Else
            MsgBox("Still Running")
            Dispose()
        End If
    End Sub

    Private Sub ProcessBases()
        lblStatus.Text = "Buscando en bases del programa..."
        Dim fBases = My.Computer.FileSystem.GetFiles(DirDef)
        lblBases.Text = fBases.Count
        scanFiles += fBases.Count
        lblTotal.Text = "Objetos analizados" & vbCrLf & scanFiles

        lblBases.Image = My.Resources._1_2_fw
    End Sub

    Private Sub ProcessStart()
        Dim rCount As UInteger = 0
        Dim detected As New List(Of Virus)

        lblStatus.Text = "Buscando en inicio automático..."
        Dim startup As ArrayList = FastScan.RegStartup

        lblStatus.Text = "Escaneando inicio automático..."
        'Dim virus As Virus
        For Each s As String In startup
            Debug.WriteLine(s)
            'virus = EngineScan.scanAll(s)
            'If virus.isMalware Then
            '    detected.Add(virus)
            '    lblServices.Image = My.Resources._2_3_fw
            'End If

            rCount += 1
            lblStart.Text = rCount
            scanFiles += 1
            lblTotal.Text = "Objetos analizados" & vbCrLf & scanFiles
        Next

        If detected.Count = 0 Then
            lblStart.Image = My.Resources._2_2_fw
        Else
            FilesDetected.AddRange(detected)
        End If
    End Sub

    Private Sub ProcessServices()
        On Error Resume Next

        Dim sCount As UInteger = 0
        Dim detected As New List(Of Virus)

        lblStatus.Text = "Buscando servicios de Windows..."
        Dim services As ArrayList = FastScan.Services

        lblStatus.Text = "Escaneando servicios de Windows..."
        Dim virus As Virus
        For Each s As String In services
            virus = EngineScan.ScanAll(s)
            If virus.isMalware Then
                detected.Add(virus)
                lblServices.Image = My.Resources._4_3_fw
            End If

            sCount += 1
            lblServices.Text = sCount
            scanFiles += 1
            lblTotal.Text = "Objetos analizados" & vbCrLf & scanFiles
        Next

        If detected.Count = 0 Then
            lblServices.Image = My.Resources._4_2_fw
        Else
            FilesDetected.AddRange(detected)
        End If
    End Sub

    Private Sub ProcessProcesses()
        On Error Resume Next

        Dim sCount As UInteger = 0
        Dim detected As New List(Of Virus)

        lblStatus.Text = "Buscando procesos de Windows..."
        Dim proccess As ArrayList = FastScan.Proccess

        lblStatus.Text = "Escaneando procesos de Windows..."
        Dim virus As Virus
        For Each p As String In proccess
            virus = EngineScan.ScanAll(p)
            If virus.isMalware Then
                detected.Add(virus)
                lblProcess.Image = My.Resources._5_3_fw
            End If

            sCount += 1
            lblProcess.Text = sCount
            scanFiles += 1
            lblTotal.Text = "Objetos analizados" & vbCrLf & scanFiles
        Next

        If detected.Count = 0 Then
            lblProcess.Image = My.Resources._5_2_fw
        Else
            FilesDetected.AddRange(detected)
        End If
    End Sub

    Private Sub ProcessRegistry()
        lblRegistry.Image = My.Resources._6_2_fw
    End Sub

    Private Sub ProcessCriticZones()
        lblCritic.Image = My.Resources._7_2_fw
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim rKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"

        Dim valueNames As String() = My.Computer.Registry.CurrentUser.OpenSubKey(rKey).GetValueNames
        For Each value As String In valueNames
            Dim key As String = My.Computer.Registry.CurrentUser.OpenSubKey(rKey).GetValue(value)
            Debug.WriteLine(value & " --- " & key)
        Next

        valueNames = My.Computer.Registry.LocalMachine.OpenSubKey(rKey).GetValueNames
        For Each value As String In valueNames
            Dim key As String = My.Computer.Registry.LocalMachine.OpenSubKey(rKey).GetValue(value)
            Debug.WriteLine(value & " --- " & key)
        Next
    End Sub

    Private Sub MysticButton1_Click(sender As Object, e As EventArgs) Handles MysticButton1.Click
        If bwScanner.IsBusy Then bwScanner.CancelAsync()
    End Sub

End Class
Imports System.Runtime.InteropServices
Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports vblibusb.Constants
Imports vblibusb.LogicUSB
Imports vblibusb

Public Class FormMain

    Public DICT_HASHES As Dictionary(Of String, String)

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case deviceChange ' Cambian los dispositivos del sistema
                Select Case m.WParam.ToInt32
                    Case deviceArrival ' Llegada de un dispositivo. Se insertó un dispositivo en la unidad
                        Dim devType As Integer = Marshal.ReadInt32(m.LParam, 4)
                        If devType = deviceTypeVolume Then ' Si es un volumen lógico... (unidad de disco)
                            Dim vol As Device = CType(Marshal.PtrToStructure(m.LParam, GetType(Device)), Device)
                            Dim drive As String = LetraUnidad(vol.dispMask)
                            Dim drvInfo As IO.DriveInfo = My.Computer.FileSystem.GetDriveInfo(drive)
                            If drvInfo.DriveType = IO.DriveType.Fixed Or drvInfo.DriveType = IO.DriveType.Removable Then
                                ShellEngine("scan-drive " & drive)
                            End If
                        End If
                End Select
            Case WM_POWER
                Select Case m.WParam
                    'Case WM_SCAN_DRIVE
                    'hideTimerOff()
                    'Dim drive As String = Chr(m.LParam.ToInt32) & ":\"
                    'MsgBox(drive & " otro")
                    Case WM_MESSAGE
                        Select Case m.LParam
                            Case WM_SCAN_NOVIRUS
                                notificar(AppNameSpace, "No se detectaron amenazas")
                            Case WM_SCAN_ONEVIRUS
                                notificar(AppNameSpace, "Se ha detectado una amenaza", ToolTipIcon.Warning)
                            Case WM_SCAN_MANYVIRUS
                                notificar(AppNameSpace, "Se detectaron varias amenazas", ToolTipIcon.Warning)
                            Case WM_UPDATE_SAMEBASES
                                notificar("Se ha actualizado antes de este archivo", "Actualización obsoleta", ToolTipIcon.Error)
                            Case WM_UPDATE_UPDATEOK
                                notificar("La base de datos de firma de virus fue actualizada con éxito", "Actualización")
                                LogFunc(Now.ToString & "*" & UserName & "*Actualización*Antivirus actualizado")
                            Case WM_UPDATE_RECENT
                                notificar("Existe una actualización más reciente", "Actualización obsoleta", ToolTipIcon.Error)
                            Case WM_UPDATE_NOUPDATE
                                notificar("Este archivo no posee una actualización compatible con esta versión de " & AppNameSpace, "Actualización incompatible", ToolTipIcon.Error)
                            Case Else
                                MsgBox(m.LParam)
                        End Select
                        'updateStatusProtection()
                End Select
        End Select
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        MysticTheme1.Text = vblibusb.AppNameSpace & " v" & Application.ProductVersion

        Dim opts As New ScanOptions
        If opts.checkReprodSounds Then sndPlaySound("sound\startup.wav", SND_ASYNC)

        updatePosition(Me)
        notify.Text = AppNameSpace
        notify.Icon = My.Resources.icon

        DICT_HASHES = New Dictionary(Of String, String)
        LoadVirusHashes.RunWorkerAsync()

        FileSystemWatcher1.Path = Environment.SystemDirectory.Substring(0, 3)
    End Sub

    Private Sub notify_MouseClick(sender As Object, e As MouseEventArgs) Handles notify.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Show()
            'Me.WindowState = FormWindowState.Normal
            updatePosition(Me)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        updateStatusProtection()
    End Sub

    Private Sub LoadVirusHashes_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadVirusHashes.DoWork
        setState("CARGANDO COMPONENTES", StyleProtection.WARNING)
        DICT_HASHES = DecryptMalwares()
    End Sub

    Private Sub LoadVirusHashes_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadVirusHashes.RunWorkerCompleted
        FileSystemWatcher1.EnableRaisingEvents = True
        setState("EQUIPO PROTEGIDO", StyleProtection.SUCCESS)
        'notify.Text = AppNameSpace & vbCrLf & "Definiciones: " & DICT_HASHES.Count
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed, FileSystemWatcher1.Created
        FSW(e.FullPath)
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        FSW(e.FullPath)
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        UpdateBases()
    End Sub

#Region "MENU"
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        Me.Hide()
        'Me.WindowState = FormWindowState.Minimized
        FormSettings.Show()
    End Sub

    Private Sub mnuQuarantine_Click(sender As Object, e As EventArgs) Handles mnuQuarantine.Click
        Me.Hide()
        'Me.WindowState = FormWindowState.Minimized
        FormQuarantine.Show()
    End Sub

    Private Sub mnuEnableProt_Click(sender As Object, e As EventArgs) Handles mnuEnableProt.Click
        Try
            If LoadVirusHashes.IsBusy = False Then
                FileSystemWatcher1.EnableRaisingEvents = True
                LogFunc(Now.ToString & "*" & UserName & "*Antivirus*Protección permanente: Habilitada")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuDisableProt_Click(sender As Object, e As EventArgs) Handles mnuDisableProt.Click
        Try
            FileSystemWatcher1.EnableRaisingEvents = False
            LogFunc(Now.ToString & "*" & UserName & "*Antivirus*Protección permanente: Deshabilitada")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuFullScan_Click(sender As Object, e As EventArgs) Handles mnuFullScan.Click
        ScanPC(True)
    End Sub

    Private Sub mnuQuickScan_Click(sender As Object, e As EventArgs) Handles mnuQuickScan.Click
        ScanPC(False)
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        FormAbout.ShowDialog()
    End Sub
#End Region

#Region "BUTTONS"
    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Me.Hide()
        'Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MysticButton3_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Me.Hide()
        'Me.WindowState = FormWindowState.Minimized
        FormSettings.Show()
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Me.Hide()
        ScanPC(False)
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        'Dim SAPI = CreateObject("SAPI.spvoice")
        'SAPI.Speak("Bienvenido a USB Security")
        Me.Hide()
        FormLogs.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateBases()
    End Sub
#End Region

    Private Sub updateStatusProtection()
        If LoadVirusHashes.IsBusy Then
            setState("CARGANDO COMPONENTES", StyleProtection.WARNING)
        ElseIf FileSystemWatcher1.EnableRaisingEvents = False Then
            setState("NO PROTEGIDO", StyleProtection.DANGER)
        Else
            setState("EQUIPO PROTEGIDO", StyleProtection.SUCCESS)
        End If

        If LoadVirusHashes.IsBusy Then FileSystemWatcher1.EnableRaisingEvents = False

        If FileSystemWatcher1.EnableRaisingEvents = True Then
            mnuEnableProt.Visible = False
            mnuDisableProt.Visible = True
        Else
            mnuEnableProt.Visible = True
            mnuDisableProt.Visible = False
        End If
    End Sub

    Private Sub setState(text As String, style As StyleProtection)
        Select Case style
            Case StyleProtection.SUCCESS
                PictureBox1.Image = My.Resources.icon_success
                labelInfo.ForeColor = Color.FromArgb(7, 164, 253)
            Case StyleProtection.DANGER
                PictureBox1.Image = My.Resources.icon_error
                labelInfo.ForeColor = Color.FromArgb(253, 7, 7)
            Case StyleProtection.WARNING
                PictureBox1.Image = My.Resources.icon_warn
                labelInfo.ForeColor = Color.FromArgb(253, 186, 7)
        End Select
        labelInfo.Text = text
    End Sub

    Private Sub FSW(ByVal Path As String)
        Try
            'Dim F As FileInfo = My.Computer.FileSystem.GetFileInfo(Path)
            Dim Md5 As String = GetMd5(Path) ' metodo GetMD5 seria mejor ponerlo en este programa

            If DICT_HASHES.ContainsKey(Md5) Then
                MsgBox("Amenaza detectada en " & Path)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Private Sub ScanPC(isFull As Boolean)
        If isFull Then
            ShellEngine("full-scan")
        Else
            ShellEngine("quick-scan")
        End If
    End Sub

    Private Sub ShellEngine(args As String)
        If My.Computer.FileSystem.FileExists("engine.exe") Then
            Shell("engine.exe " & args, AppWinStyle.NormalFocus)
        Else
            MsgBox("No existe el ejecutable necesario para la acción. Por favor reinstale la aplicación.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub UpdateBases()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Archivo de actualización|*.sec"
        ofd.CheckFileExists = True
        ofd.Title = "Seleccione un archivo de actualización de USB Security"
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            UpdateBasesFromFile(ofd.FileName)
            LoadVirusHashes.RunWorkerAsync()
        End If
    End Sub

End Class

Enum StyleProtection
    SUCCESS
    DANGER
    WARNING
End Enum

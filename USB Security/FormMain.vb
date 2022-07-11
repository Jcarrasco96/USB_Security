Imports System.Runtime.InteropServices
Imports vblibusb.Constants
Imports vblibusb.LogicUSB
Imports vblibusb

Public Class FormMain

    Private PROTECTION_ENABLED = True
    Private HASHES = 0

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case deviceChange ' Cambian los dispositivos del sistema
                Select Case m.WParam.ToInt32
                    Case deviceArrival ' Llegada de un dispositivo. Se insertó un dispositivo en la unidad
                        Dim devType As Integer = Marshal.ReadInt32(m.LParam, 4)
                        If PROTECTION_ENABLED And devType = deviceTypeVolume Then ' Si proteccion esta habilitada y es un volumen lógico... (unidad de disco)
                            Dim vol As Device = Marshal.PtrToStructure(m.LParam, GetType(Device))
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
                                Notificar(AppNameSpace, "No se detectaron amenazas")
                            Case WM_SCAN_ONEVIRUS
                                Notificar(AppNameSpace, "Se ha detectado una amenaza", ToolTipIcon.Warning)
                            Case WM_SCAN_MANYVIRUS
                                Notificar(AppNameSpace, "Se detectaron varias amenazas", ToolTipIcon.Warning)
                            Case WM_UPDATE_SAMEBASES
                                Notificar("Se ha actualizado antes de este archivo", "Actualización obsoleta", ToolTipIcon.Error)
                            Case WM_UPDATE_UPDATEOK
                                Notificar("La base de datos de firma de virus fue actualizada con éxito", "Actualización")
                                LoadVirusHashes.RunWorkerAsync()
                                LogFunc(Now.ToString & "*" & UserName & "*Actualización*Antivirus actualizado")
                            Case WM_UPDATE_RECENT
                                Notificar("Existe una actualización más reciente", "Actualización obsoleta", ToolTipIcon.Error)
                            Case WM_UPDATE_NOUPDATE
                                Notificar("Este archivo no posee una actualización compatible con esta versión de " & AppNameSpace, "Actualización incompatible", ToolTipIcon.Error)
                            Case Else
                                MsgBox(m.LParam)
                        End Select
                        'updateStatusProtection()
                End Select
        End Select
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        MysticTheme1.Text = AppNameSpace & " " & Application.ProductVersion

        Dim opts As New ScanOptions
        If opts.checkReprodSounds Then sndPlaySound("sound\startup.wav", SND_ASYNC)

        UpdatePosition(Me)
        notify.Text = AppNameSpace
        notify.Icon = My.Resources.icon

        LoadVirusHashes.RunWorkerAsync()

        UpdateStatusProtection()
    End Sub

    Private Sub Notify_MouseClick(sender As Object, e As MouseEventArgs) Handles notify.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Show()
            UpdatePosition(Me)
        End If
    End Sub

    Private Sub LoadVirusHashes_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadVirusHashes.DoWork
        UpdateStatusProtection()
        HASHES = DecryptMalwares().Count
    End Sub

    Private Sub LoadVirusHashes_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadVirusHashes.RunWorkerCompleted
        UpdateStatusProtection()
        notify.Text = AppNameSpace & vbCrLf & "Definiciones: " & HASHES
    End Sub

#Region "MENU"
    Private Sub MnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        UpdateBases()
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dispose()
    End Sub

    Private Sub MnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
        Hide()
        FormSettings.Show()
    End Sub

    Private Sub MnuQuarantine_Click(sender As Object, e As EventArgs) Handles mnuQuarantine.Click
        Hide()
        FormQuarantine.Show()
    End Sub

    Private Sub MnuEnableProt_Click(sender As Object, e As EventArgs) Handles mnuEnableProt.Click
        Try
            If LoadVirusHashes.IsBusy = False Then
                LogFunc(Now.ToString & "*" & UserName & "*Antivirus*Protección permanente: Habilitada")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        PROTECTION_ENABLED = True
        UpdateStatusProtection()
    End Sub

    Private Sub MnuDisableProt_Click(sender As Object, e As EventArgs) Handles mnuDisableProt.Click
        Try
            LogFunc(Now.ToString & "*" & UserName & "*Antivirus*Protección permanente: Deshabilitada")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        PROTECTION_ENABLED = False
        UpdateStatusProtection()
    End Sub

    Private Sub MnuFullScan_Click(sender As Object, e As EventArgs) Handles mnuFullScan.Click
        ScanPC(True)
    End Sub

    Private Sub MnuQuickScan_Click(sender As Object, e As EventArgs) Handles mnuQuickScan.Click
        ScanPC(False)
    End Sub

    Private Sub MnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        FormAbout.ShowDialog()
    End Sub
#End Region

#Region "BUTTONS"
    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Hide()
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Hide()
        FormSettings.Show()
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Hide()
        ScanPC(False)
    End Sub

    Private Sub BtnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Hide()
        FormLogs.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateBases()
    End Sub
#End Region

    Private Sub UpdateStatusProtection()
        If LoadVirusHashes.IsBusy Then
            SetState("CARGANDO COMPONENTES", StyleProtection.WARNING)
        ElseIf PROTECTION_ENABLED = False Then
            SetState("NO PROTEGIDO", StyleProtection.DANGER)
        Else
            SetState("EQUIPO PROTEGIDO", StyleProtection.SUCCESS)
        End If

        If PROTECTION_ENABLED Then
            mnuEnableProt.Visible = False
            mnuDisableProt.Visible = True
        Else
            mnuEnableProt.Visible = True
            mnuDisableProt.Visible = False
        End If
    End Sub

    Private Sub SetState(text As String, style As StyleProtection)
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

    Private Sub ScanPC(isFull As Boolean)
        If isFull Then
            ShellEngine("full-scan")
        Else
            ShellEngine("quick-scan")
        End If
    End Sub

    Private Sub ShellEngine(args As String)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\engine.exe") Then
            Shell(Application.StartupPath & "\engine.exe " & args, AppWinStyle.NormalFocus)
        Else
            MsgBox("No existe el ejecutable necesario para la acción. Por favor reinstale la aplicación.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub UpdateBases()
        Dim ofd As New OpenFileDialog With {
            .Filter = "Actualización de USB Security|*.sec",
            .CheckFileExists = True,
            .Title = "Seleccione un archivo de actualización de USB Security"
        }
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ShellEngine("update """ & ofd.FileName & """")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        FormFastScan.Show()
    End Sub

End Class



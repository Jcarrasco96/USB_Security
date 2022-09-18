Imports System.Runtime.InteropServices
Imports vblibusb.LogicUSB
Imports vblibusb

Public Class FormMain

    Dim thread As Threading.Thread

    Private PROTECTION_ENABLED = True
    Private HASHES = 0

    Protected Overrides Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case WM_DEVICECHANGE ' Cambian los dispositivos del sistema
                Select Case m.WParam.ToInt32
                    Case DBT_DEVICEARRIVAL ' Llegada de un dispositivo. Se insertó un dispositivo en la unidad
                        Dim devType As Integer = Marshal.ReadInt32(m.LParam, 4)
                        If PROTECTION_ENABLED And devType = DBT_DEVTYP_VOLUME Then ' Si proteccion esta habilitada y es un volumen lógico... (unidad de disco)
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
                            Case WM_SCAN_START
                                thread = New Threading.Thread(AddressOf ChangeNotifyIcon)
                                thread.Start()
                            Case WM_SCAN_STOP
                                thread.Abort()
                                notify.Icon = My.Resources.icon
                            Case Else
                                MsgBox(m.LParam)
                        End Select
                        'updateStatusProtection()
                End Select
        End Select
        MyBase.WndProc(m)
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        'WindowState = FormWindowState.Minimized
        'Visible = False

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
        Try
            thread.Abort()
        Catch ex As Exception

        End Try
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

    Private Sub ChangeNotifyIcon()
        Dim count As Integer = 0

        Try
            While True
                count += 1

                If count = 14 Then count = 0 ' count 1 mas de los case

                Select Case count
                    Case 0
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_01.ico")
                    Case 1
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_02.ico")
                    Case 2
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_03.ico")
                    Case 3
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_04.ico")
                    Case 4
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_05.ico")
                    Case 5
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_06.ico")
                    Case 6
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_07.ico")
                    Case 7
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_08.ico")
                    Case 8
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_09.ico")
                    Case 9
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_10.ico")
                    Case 10
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_11.ico")
                    Case 11
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_12.ico")
                    Case 12
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_13.ico")
                    Case 13
                        notify.Icon = New Icon("C:\Users\Naty\Desktop\icos\ic_scan_14.ico")
                End Select

                Threading.Thread.Sleep(100)
            End While
        Catch ex As Exception

        End Try
    End Sub

End Class



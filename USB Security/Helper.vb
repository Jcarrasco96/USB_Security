Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports vblibusb

Module Helper

    Public Sub SevenZip(ByVal zipFile As String, ByVal outputFolder As String)
        Shell("7z.exe e """ & zipFile & """ -o""" & outputFolder & """ -r -aos", AppWinStyle.Hide, True)
    End Sub

    Public Sub UpdateBasesFromFile(ByVal fn As String)
        Dim handle As Integer = Messages.FindWindow(vbNullString, "USBSecurity - Main")

        'If My.Computer.FileSystem.FileExists(Constants.DirCache & "new.cache") Then My.Computer.FileSystem.DeleteFile(Constants.DirCache & "new.cache")

        Shell("7z.exe e """ & fn & """ -o""" & DirCache & """ config.sec -r -y", AppWinStyle.Hide, True)
        DecryptFile(DirCache & "config.sec", DirCache & "new.cache")
        DecryptFile(DirDef & "config.sec", DirCache & "config.cache")

        If My.Computer.FileSystem.FileExists(DirCache & "new.cache") Then
            Dim dateBasesNew As String = LogicUSB.ValueOfFile("update", "date", DirCache & "new.cache")
            Dim dateBases As String = LogicUSB.ValueOfFile("update", "date", DirCache & "config.cache")

            If dateBasesNew = "" Then
                Messages.SendMessage(handle, Constants.WM_POWER, Constants.WM_MESSAGE, Constants.WM_UPDATE_NOUPDATE) ' Este archivo no posee una actualización compatible con esta versión de USB Security
            ElseIf dateBasesNew.Equals(dateBases, StringComparison.OrdinalIgnoreCase) Then
                Messages.SendMessage(handle, Constants.WM_POWER, Constants.WM_MESSAGE, Constants.WM_UPDATE_SAMEBASES) ' Se ha actualizado antes de este archivo
            ElseIf LogicUSB.compareDate(dateBasesNew, dateBases) Then
                Shell("7z.exe e """ & fn & """ -o""" & DirDef & """ -r -y", AppWinStyle.Hide, True)
                'My.Computer.FileSystem.DeleteFile(Constants.DirCache & "config.upd")
                Messages.SendMessage(handle, Constants.WM_POWER, Constants.WM_MESSAGE, Constants.WM_UPDATE_UPDATEOK) ' La base de datos de firma de virus fue actualizada con éxito
            Else
                Messages.SendMessage(handle, Constants.WM_POWER, Constants.WM_MESSAGE, Constants.WM_UPDATE_RECENT) ' Existe una actualización más reciente
            End If
        Else
            Messages.SendMessage(handle, Constants.WM_POWER, Constants.WM_MESSAGE, Constants.WM_UPDATE_NOUPDATE) ' Este archivo no posee una actualización compatible con esta versión de USB Security
        End If

        If My.Computer.FileSystem.FileExists(DirCache & "config.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "config.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "config.sec") Then My.Computer.FileSystem.DeleteFile(DirCache & "config.sec")
        If My.Computer.FileSystem.FileExists(DirCache & "new.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "new.cache")

    End Sub

    ' Muestra un BallonTip
    ' Parametros: b: Texto, t: Titulo, i: Icono, d: Periodo de tiempo
    Public Sub notificar(b As String, t As String, Optional i As ToolTipIcon = ToolTipIcon.Info, Optional d As Integer = 5000)
        FormMain.notify.BalloonTipTitle = t
        FormMain.notify.BalloonTipText = b
        FormMain.notify.BalloonTipIcon = i
        FormMain.notify.ShowBalloonTip(d)
    End Sub

    ' Altura de la barra de tareas
    Function heightTaskBar() As Integer
        Dim size As Integer = Screen.PrimaryScreen.WorkingArea.Size.Height
        Dim altura As Integer = Screen.PrimaryScreen.Bounds.Height

        Return altura - size
    End Function

    ' Ancho de la barra de tareas
    Function widthTaskBar() As Integer
        Dim size As Integer = Screen.PrimaryScreen.WorkingArea.Size.Width
        Dim ancho As Integer = Screen.PrimaryScreen.Bounds.Width

        Return ancho - size
    End Function

    Sub updatePosition(form As Form)
        Dim screenWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim screenHeight As Integer = My.Computer.Screen.Bounds.Height

        Dim formW As Integer = form.Width
        Dim formH As Integer = form.Height

        form.SetDesktopLocation(screenWidth - formW - widthTaskBar() - 5, screenHeight - formH - heightTaskBar())
    End Sub

    Public Structure Device
        Public dispTamaño As Integer
        Public dispTipo As Integer
        Public dispReserv As Integer
        Public dispMask As Integer
    End Structure 'Para el USB

    Public Function LetraUnidad(ByVal unitmask As Integer) As String
        Dim units() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim i As Integer = 0
        ' Convetimos la máscara en un array primario y buscamos el índice de la primera ocurrencia (la letra de unidad)
        Dim ba As System.Collections.BitArray = New System.Collections.BitArray(System.BitConverter.GetBytes(unitmask))
        For i = 0 To ba.Length
            If ba(i) = True Then
                Exit For
            End If
        Next
        Return units(i) & ":\"
    End Function

    ' Copiar los archivos necesarios
    Sub copyFilesNeed()
        ' Verificar q existan las dll y exe necesarios
        If Not My.Computer.FileSystem.GetFileInfo("7z.dll").Exists Or
            Not My.Computer.FileSystem.GetFileInfo("7z.exe").Exists Or
            Not My.Computer.FileSystem.GetFileInfo("SecurityIcons.dll").Exists Or
            Not My.Computer.FileSystem.GetFileInfo("vblibusb.dll").Exists Then
            MsgBox("La aplicación no puede continuar porque faltan los archivos necesarios. Por favor, reinstale la aplicación.", MsgBoxStyle.Critical)
            End
        End If
        ' Copiar el archivo de configuracion, si no existe
        If Not My.Computer.FileSystem.GetFileInfo("config.ini").Exists Then My.Computer.FileSystem.WriteAllText("config.ini", My.Resources.config, False, System.Text.Encoding.Unicode)
        ' Copiar el icono de actualizacion, si no existe
        If Not My.Computer.FileSystem.GetFileInfo("ic_update.ico").Exists Then
            Dim fsUpdate As New FileStream("ic_update.ico", FileMode.Create)
            My.Resources.ic_update1.Save(fsUpdate)
            fsUpdate.Close()
        End If
        ' Crear carpetas necesarias, si no existen
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirDef).Exists Then My.Computer.FileSystem.CreateDirectory(DirDef)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirCache).Exists Then My.Computer.FileSystem.CreateDirectory(DirCache)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirError).Exists Then My.Computer.FileSystem.CreateDirectory(DirError)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirQuar).Exists Then My.Computer.FileSystem.CreateDirectory(DirQuar)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirSound).Exists Then My.Computer.FileSystem.CreateDirectory(DirSound)
        ' Copiar la base de datos, en caso de faltar algun archivo
        If Not My.Computer.FileSystem.GetFileInfo("config.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "config.sec", My.Resources.config1, False)
        If Not My.Computer.FileSystem.GetFileInfo("secur001.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur001.sec", My.Resources.secur001, False)
        If Not My.Computer.FileSystem.GetFileInfo("secur002.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur002.sec", My.Resources.secur002, False)
        If Not My.Computer.FileSystem.GetFileInfo("secur003.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur003.sec", My.Resources.secur003, False)
        If Not My.Computer.FileSystem.GetFileInfo("secur004.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur004.sec", My.Resources.secur004, False)
        If Not My.Computer.FileSystem.GetFileInfo("secur006.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur006.sec", My.Resources.secur006, False)
        If Not My.Computer.FileSystem.GetFileInfo("secur007.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur007.sec", My.Resources.secur007, False)
        If Not My.Computer.FileSystem.GetFileInfo("security00.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "security00.sec", My.Resources.security00, False)
        If Not My.Computer.FileSystem.GetFileInfo("security01.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "security01.sec", My.Resources.security01, False)

    End Sub

    Public Sub CleanQuarLimit()

    End Sub

End Module

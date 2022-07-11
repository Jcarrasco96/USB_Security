Imports System.IO
Imports System.Management
Imports vblibusb

Module Helper

    ' Muestra un BallonTip
    ' Parametros: b: Texto, t: Titulo, i: Icono, d: Periodo de tiempo
    Public Sub Notificar(b As String, t As String, Optional i As ToolTipIcon = ToolTipIcon.Info, Optional d As Integer = 5000)
        FormMain.notify.BalloonTipTitle = t
        FormMain.notify.BalloonTipText = b
        FormMain.notify.BalloonTipIcon = i
        FormMain.notify.ShowBalloonTip(d)
    End Sub

    ' Altura de la barra de tareas
    Function HeightTaskBar() As Integer
        Return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Size.Height
    End Function

    ' Ancho de la barra de tareas
    Function WidthTaskBar() As Integer
        Return Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Size.Width
    End Function

    Sub UpdatePosition(form As Form)
        form.SetDesktopLocation(My.Computer.Screen.Bounds.Width - form.Width - WidthTaskBar() - 5, My.Computer.Screen.Bounds.Height - form.Height - HeightTaskBar())
    End Sub

    Public Function LetraUnidad(unitmask As Integer) As String
        Dim units() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        ' Convetimos la máscara en un array primario y buscamos el índice de la primera ocurrencia (la letra de unidad)
        Dim ba As New BitArray(BitConverter.GetBytes(unitmask))
        For i As Integer = 0 To ba.Length
            If ba(i) = True Then
                Return units(i) & ":\"
            End If
        Next
        Return ""
    End Function

    ' Copiar los archivos necesarios
    Sub CopyFilesNeed()
        ' Verificar q existan las dll y exe necesarios
        'If Not My.Computer.FileSystem.GetFileInfo("7z.dll").Exists Or
        '    Not My.Computer.FileSystem.GetFileInfo("7z.exe").Exists Or
        '    Not My.Computer.FileSystem.GetFileInfo("SecurityIcons.dll").Exists Or
        '    Not My.Computer.FileSystem.GetFileInfo("vblibusb.dll").Exists Then
        '    MsgBox("La aplicación no puede continuar porque faltan los archivos necesarios. Por favor, reinstale la aplicación.", MsgBoxStyle.Critical)
        '    End
        'End If

        ' Crear carpetas necesarias, si no existen
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirDef).Exists Then My.Computer.FileSystem.CreateDirectory(DirDef)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirCache).Exists Then My.Computer.FileSystem.CreateDirectory(DirCache)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirError).Exists Then My.Computer.FileSystem.CreateDirectory(DirError)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirQuar).Exists Then My.Computer.FileSystem.CreateDirectory(DirQuar)
        If Not My.Computer.FileSystem.GetDirectoryInfo(DirSound).Exists Then My.Computer.FileSystem.CreateDirectory(DirSound)
        ' Copiar la base de datos, en caso de faltar algun archivo
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "config.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "config.sec", My.Resources.config1, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "secur001.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur001.sec", My.Resources.secur001, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "secur002.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur002.sec", My.Resources.secur002, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "secur003.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur003.sec", My.Resources.secur003, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "secur004.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur004.sec", My.Resources.secur004, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "secur006.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur006.sec", My.Resources.secur006, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "secur007.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "secur007.sec", My.Resources.secur007, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "security00.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "security00.sec", My.Resources.security00, False)
        If Not My.Computer.FileSystem.GetFileInfo(DirDef & "security01.sec").Exists Then My.Computer.FileSystem.WriteAllBytes(DirDef & "security01.sec", My.Resources.security01, False)

        ' Copiar el archivo de configuracion, si no existe
        If Not My.Computer.FileSystem.GetFileInfo(DirProject & "config.ini").Exists Then
            My.Computer.FileSystem.WriteAllText(DirProject & "config.ini", My.Resources.config, False, Text.Encoding.Unicode)
        End If
        ' Copiar el icono de actualizacion, si no existe
        If Not My.Computer.FileSystem.GetFileInfo(DirProject & "ic_update.ico").Exists Then
            Dim fsUpdate As New FileStream(DirProject & "ic_update.ico", FileMode.Create)
            My.Resources.ic_update1.Save(fsUpdate)
            fsUpdate.Close()
        End If

    End Sub

    Public Sub CleanQuarLimit()

    End Sub

    Public Function SID() As String
        Dim mConnOpts As New ConnectionOptions With {
            .Impersonation = ImpersonationLevel.Impersonate
        }

        Dim mManScope As New ManagementScope("\\.\root\cimv2", mConnOpts)
        mManScope.Connect()

        Dim query As New ObjectQuery("SELECT name,sid FROM Win32_UserAccount WHERE name='" & Environment.UserName & "'")
        Dim searcher As New ManagementObjectSearcher(mManScope, query)

        Dim path As String = ""

        For Each qObj As ManagementObject In searcher.Get
            If qObj("sid") <> "" Then
                path = qObj("sid").Replace("""", "")
                Exit For
            End If
        Next

        Return path
    End Function

End Module

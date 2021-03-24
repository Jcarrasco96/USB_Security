Imports System.IO
Imports Microsoft.Win32
Imports System.Text
Imports System.Security.Cryptography
Imports vblibusb

Module Helper

    ' Arreglar un poco esto
    Function splitPath(ByVal path As String, Optional ByVal length As Byte = 100) As String
        Dim ret As String = path
        Dim partes As String() = path.Split("\")
        Dim l As Integer = partes.Length
        If l > 5 And path.Length > length Then
            ret = partes(0) & "\...\" & partes(l - 2) & "\" & partes(l - 1)
        End If
        Return ret
    End Function

    ' Añadir a cuarentena
    ' Encriptar el archivo infestado
    ' En un nuevo archivo escribir "USB Security Quarantine File"
    ' Escribir datos del archivo "datetime, filepath, filesize, malwarename, size, file"
    ' string, string, string, long, string, long, byte()
    Function AddToQuarantine(ByVal filepath As String, ByVal fileSize As Long, ByVal malwareName As String) As Boolean
        Dim drive As String = filepath.Substring(0, 3)
        Dim success As Boolean = False
        Dim filenameTMP As String = DirQuar & LogicUSB.MD5Hash(Now.ToString) & ".TMP"
        Dim filenameQUA As String = DirQuar & LogicUSB.MD5Hash(Now.ToString) & ".QUA"

        If malwareName.Equals("") Or malwareName.Equals("NO_MALWARE", StringComparison.OrdinalIgnoreCase) Then malwareName = "Unknown"

        Encrypter.EncryptFile(filepath, filenameTMP)

        Dim fileBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(filenameTMP)
        Dim bw As New BinaryWriter(New FileStream(filenameQUA, FileMode.Create))
        bw.Write("USB Security Quarantine File")
        bw.Write(Now.ToString)
        bw.Write(filepath)
        bw.Write(fileSize)
        'bw.Write(fileMDS)
        bw.Write(malwareName)
        bw.Write(fileBytes.LongLength)
        bw.Write(fileBytes)
        bw.Close()

        If My.Computer.FileSystem.GetFileInfo(filepath).Exists Then SecureDeleteFile(filepath)
        If My.Computer.FileSystem.GetFileInfo(filenameTMP).Exists Then SecureDeleteFile(filenameTMP)

        Return Not My.Computer.FileSystem.GetFileInfo(filepath).Exists ' retorna True si lo elimino y movio bien a la cuarentena, False otherwise
    End Function

    ' Funcion para eliminar un archivo que esta siendo usado actualmente por el sistema operativo
    Public Function SecureDeleteFile(ByVal filename As String) As Boolean
        Dim file = My.Computer.FileSystem.GetFileInfo(filename)

        Try
            file.Delete()
        Catch ex As Exception
            LogicUSB.LogError("------Error al tratar de eliminar el archivo 01------" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
        file.Refresh()

        If file.Exists Then
            Try
                file.Attributes = IO.FileAttributes.Normal
                Dim procesos() As Process = Process.GetProcesses()
                For Each proceso As Process In procesos
                    Try
                        If proceso.MainModule.FileName.ToLower & "" = file.FullName.ToLower Then ' Busca el directorio del archivo en un proceso
                            proceso.Kill()
                            proceso.Close()
                        End If
                    Catch ex As Exception
                        LogicUSB.LogError("------Error en el proceso del sistema------" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
                    End Try
                Next
                My.Computer.FileSystem.DeleteFile(file.FullName)
                file.Refresh()
            Catch ex As Exception
                LogicUSB.LogError("------Error al tratar de eliminar el archivo 02------" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If

        file.Refresh()

        Return Not file.Exists
    End Function

    ' Altura de la barra de tareas
    Function heightTaskBar() As Integer
        Return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Size.Height
    End Function

    ' Ancho de la barra de tareas
    Function widthTaskBar() As Integer
        Return Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Size.Width
    End Function

    Sub updatePosition(form As Form)
        Dim screenWidth As Integer = My.Computer.Screen.Bounds.Width
        Dim screenHeight As Integer = My.Computer.Screen.Bounds.Height

        Dim formW As Integer = form.Width
        Dim formH As Integer = form.Height

        form.SetDesktopLocation(screenWidth - formW - widthTaskBar() - 5, screenHeight - formH - heightTaskBar())
    End Sub

    Public Function SPECIALDIRECTORIESSS() As List(Of String)
        On Error Resume Next
        Dim FoldersSpecial As New List(Of String)
        'Dim Folders As New List(Of DirectoryInfo)
        'Dim D As DirectoryInfo

        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Cookies))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favorites))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.History))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.InternetCache))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyComputer))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Programs))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Recent))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.SendTo))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Startup))
        'FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.System))
        FoldersSpecial.Add(Environment.GetFolderPath(Environment.SpecialFolder.Templates))

        'For Each Fol As String In FoldersSpecial
        '    D = New DirectoryInfo(Fol)
        '    Folders.Add(D)
        'Next
        Return FoldersSpecial
    End Function

    ' Archivos de proteccion, icono y carpeta
    Public Sub SetDriveAutorunFile(ByVal drv As String, opts As ScanOptions)
        Dim dirFolder As String = drv & "autorun.inf"
        Dim typeDrive As DriveType = My.Computer.FileSystem.GetDriveInfo(drv).DriveType

        If My.Computer.FileSystem.GetDriveInfo(drv).IsReady Then
            Select Case typeDrive
                Case DriveType.Removable ' Es un dispositivo extraible
                    If opts.checkCreateProtUSB Then
                        CreateFiles(dirFolder)
                    End If
                Case DriveType.Fixed ' Es un dispositivo interno o fijo
                    If opts.checkCreateProtHDD Then
                        CreateFiles(dirFolder)
                    End If
            End Select
        End If
    End Sub

    Public Sub CreateFiles(ByVal f As String)
        If My.Computer.FileSystem.GetFileInfo(f).Exists Then My.Computer.FileSystem.DeleteFile(f, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        If Not My.Computer.FileSystem.GetFileInfo(f).Exists Then
            My.Computer.FileSystem.CreateDirectory(f)

            If My.Computer.FileSystem.GetDirectoryInfo(f).Exists Then
                ' R: readOnly, S: system, H: hidden
                Dim rs As Integer = FileAttributes.ReadOnly + FileAttributes.System
                Dim rsh As Integer = FileAttributes.ReadOnly + FileAttributes.System + FileAttributes.Hidden

                Dim desktop As String = f & "\desktop.ini"
                Dim icon As String = f & "\usbsecurity.ico"
                Dim prot As String = f & "\" & Constants.AppNameSpace & ".txt"

                If My.Computer.FileSystem.GetFileInfo(desktop).Exists Then My.Computer.FileSystem.GetFileInfo(desktop).Attributes = FileAttributes.Normal
                If My.Computer.FileSystem.GetFileInfo(icon).Exists Then My.Computer.FileSystem.GetFileInfo(icon).Attributes = FileAttributes.Normal
                If My.Computer.FileSystem.GetDirectoryInfo(f).Exists Then My.Computer.FileSystem.GetDirectoryInfo(f).Attributes = FileAttributes.Normal

                ' Icono
                Dim fs As New FileStream(icon, FileMode.Create)
                My.Resources.icon.Save(fs)
                fs.Close()

                ' Desktop.ini
                If Not My.Computer.FileSystem.GetFileInfo(desktop).Exists Then
                    My.Computer.FileSystem.WriteAllText(desktop, "[.ShellClassInfo]" & vbCrLf, False)
                    My.Computer.FileSystem.WriteAllText(desktop, "InfoTip=Archivos de Protección Antivirus" & vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(desktop, "IconFile=usbsecurity.ico" & vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(desktop, "IconIndex=0" & vbCrLf, True)
                End If

                ' Proteccion
                My.Computer.FileSystem.WriteAllText(prot, My.Resources.proteccion, False)

                My.Computer.FileSystem.GetFileInfo(desktop).Attributes = rsh
                My.Computer.FileSystem.GetFileInfo(icon).Attributes = rsh
                My.Computer.FileSystem.GetDirectoryInfo(f).Attributes = rs
            End If
        End If
    End Sub

End Module

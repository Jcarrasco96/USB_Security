Imports System.IO
Imports vblibusb

Module Helper

    ' Arreglar un poco esto
    Function SplitPath(path As String, Optional length As Byte = 100) As String
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
    '                       string, string,   string,     long,      string, long, byte()
    Function AddToQuarantine(filepath As String, fileSize As Long, malwareName As String) As Boolean
        Dim filenameTMP As String = DirQuar & MD5Hash(Now.Ticks) & ".ENC_TMP"
        Dim filenameQUA As String = DirQuar & MD5Hash(Now.Ticks) & ".QUA"

        If malwareName.Equals("") Or malwareName.Equals("NO_MALWARE", StringComparison.OrdinalIgnoreCase) Then malwareName = "Unknown"

        EncryptFile(filepath, filenameTMP)

        Dim fileBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(filenameTMP)
        Dim bw As New BinaryWriter(New FileStream(filenameQUA, FileMode.Create))
        bw.Write("USB Security Quarantine File")
        bw.Write(Now.ToString)
        bw.Write(filepath)
        bw.Write(fileSize)
        bw.Write(malwareName)
        bw.Write(fileBytes.LongLength)
        bw.Write(fileBytes)
        bw.Close()

        If My.Computer.FileSystem.GetFileInfo(filepath).Exists Then SecureDeleteFile(filepath)
        If My.Computer.FileSystem.GetFileInfo(filenameTMP).Exists Then SecureDeleteFile(filenameTMP)

        Return Not My.Computer.FileSystem.GetFileInfo(filepath).Exists ' retorna True si lo elimino y movio bien a la cuarentena, False otherwise
    End Function

    ' Funcion para eliminar un archivo que esta siendo usado actualmente por el sistema operativo
    Public Function SecureDeleteFile(filename As String) As Boolean
        Dim file = My.Computer.FileSystem.GetFileInfo(filename)

        Try
            file.Attributes = FileAttributes.Normal
            file.Delete()
        Catch ex As Exception
            LogError("Helper::SecureDeleteFile" & vbCrLf & "------Error al tratar de eliminar el archivo 01------" & vbCrLf & filename & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
        file.Refresh()

        If file.Exists Then
            Try
                'file.Attributes = FileAttributes.Normal
                Dim procesos() As Process = Process.GetProcesses()
                For Each proceso As Process In procesos
                    Try
                        If proceso.MainModule.FileName.ToLower & "" = file.FullName.ToLower Then ' Busca el directorio del archivo en un proceso
                            proceso.Kill()
                            proceso.Close()
                        End If
                    Catch ex As Exception
                        LogError("Helper::SecureDeleteFile" & vbCrLf & "------Error en el proceso del sistema------" & vbCrLf & proceso.MainModule.FileName.ToLower & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
                    End Try
                Next
                DeleteFile(file.FullName)
                file.Refresh()
            Catch ex As Exception
                LogError("Helper::SecureDeleteFile" & vbCrLf & "------Error al tratar de eliminar el archivo 02------" & vbCrLf & filename & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End If

        file.Refresh()

        Return Not file.Exists
    End Function

    Public Function SPECIALDIRECTORIESSS() As List(Of String)
        Dim FoldersSpecial As New List(Of String) From {
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
            Environment.GetFolderPath(Environment.SpecialFolder.Favorites),
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
            Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
            Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
            Environment.GetFolderPath(Environment.SpecialFolder.Programs),
            Environment.GetFolderPath(Environment.SpecialFolder.StartMenu),
            Environment.GetFolderPath(Environment.SpecialFolder.Startup),
            Environment.GetFolderPath(Environment.SpecialFolder.Templates)
        }

        Return FoldersSpecial
    End Function

    ' Archivos de proteccion, icono y carpeta
    Public Sub SetDriveAutorunFile(drv As String, opts As ScanOptions)
        Dim dirFolder As String = drv & "autorun.inf"
        Dim typeDrive As DriveType = My.Computer.FileSystem.GetDriveInfo(drv).DriveType

        If My.Computer.FileSystem.GetDriveInfo(drv).IsReady Then
            If (typeDrive = DriveType.Removable And opts.checkCreateProtUSB) Or (typeDrive = DriveType.Fixed And opts.checkCreateProtHDD) Then
                CreateFiles(dirFolder)
            End If
        End If
    End Sub

    Public Sub CreateFiles(f As String)
        If My.Computer.FileSystem.GetFileInfo(f).Exists Then My.Computer.FileSystem.DeleteFile(f, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        If Not My.Computer.FileSystem.GetFileInfo(f).Exists Then
            My.Computer.FileSystem.CreateDirectory(f)

            If My.Computer.FileSystem.GetDirectoryInfo(f).Exists Then
                ' R: readOnly, S: system, H: hidden
                Dim rs As Integer = FileAttributes.ReadOnly + FileAttributes.System
                Dim rsh As Integer = FileAttributes.ReadOnly + FileAttributes.System + FileAttributes.Hidden

                Dim desktop As String = f & "\desktop.ini"
                Dim icon As String = f & "\usbsecurity.ico"
                Dim prot As String = f & "\" & AppNameSpace & ".txt"

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

    Public Sub UpdateBasesFromFile(fn As String)
        Dim handle As Integer = FindWindow(vbNullString, "USBSecurity - Main")

        'If My.Computer.FileSystem.FileExists(Constants.DirCache & "new.cache") Then My.Computer.FileSystem.DeleteFile(Constants.DirCache & "new.cache")

        Shell("7z.exe e """ & fn & """ -o""" & DirCache & """ config.sec -r -y", AppWinStyle.Hide, True)

        If Not My.Computer.FileSystem.FileExists(DirCache & "config.sec") Then
            SendMessage(handle, WM_POWER, WM_MESSAGE, WM_UPDATE_NOUPDATE)
            Exit Sub
        End If

        DecryptFile(DirCache & "config.sec", DirCache & "new.cache")
        DecryptFile(DirDef & "config.sec", DirCache & "config.cache")

        If My.Computer.FileSystem.FileExists(DirCache & "new.cache") Then
            Dim dateBasesNew As String = ValueOfFile("update", "date", DirCache & "new.cache")
            Dim dateBases As String = ValueOfFile("update", "date", DirCache & "config.cache")

            If dateBasesNew = "" Then
                SendMessage(handle, WM_POWER, WM_MESSAGE, WM_UPDATE_NOUPDATE) ' Este archivo no posee una actualización compatible con esta versión de USB Security
            ElseIf dateBasesNew.Equals(dateBases, StringComparison.OrdinalIgnoreCase) Then
                SendMessage(handle, WM_POWER, WM_MESSAGE, WM_UPDATE_SAMEBASES) ' Se ha actualizado antes de este archivo
            ElseIf CompareDate(dateBasesNew, dateBases) Then
                Shell("7z.exe e """ & fn & """ -o""" & DirDef & """ -r -y", AppWinStyle.Hide, True)
                'My.Computer.FileSystem.DeleteFile(Constants.DirCache & "config.upd")
                SendMessage(handle, WM_POWER, WM_MESSAGE, WM_UPDATE_UPDATEOK) ' La base de datos de firma de virus fue actualizada con éxito
            Else
                SendMessage(handle, WM_POWER, WM_MESSAGE, WM_UPDATE_RECENT) ' Existe una actualización más reciente
            End If
        Else
            SendMessage(handle, WM_POWER, WM_MESSAGE, WM_UPDATE_NOUPDATE) ' Este archivo no posee una actualización compatible con esta versión de USB Security
        End If

        If My.Computer.FileSystem.FileExists(DirCache & "config.cache") Then DeleteFile(DirCache & "config.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "config.sec") Then DeleteFile(DirCache & "config.sec")
        If My.Computer.FileSystem.FileExists(DirCache & "new.cache") Then DeleteFile(DirCache & "new.cache")
    End Sub

End Module

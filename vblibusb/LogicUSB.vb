Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports Microsoft.Win32
Imports Microsoft.VisualBasic.FileIO

Public Module LogicUSB

    Public UserName As String = My.User.Name
    Public SysDirectory As String = Environment.SystemDirectory
    Public SystemDrive As String = SysDirectory.Substring(0, 3)
    Public AppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    Public DirExecPath As String = My.Application.Info.DirectoryPath & "\"
    Public DirProject As String = AppData & "\" & AppName & "\"
    ' Rutas no tan estaticas, jaja
    Public DirDef As String = DirProject & "bases\"
    Public DirCache As String = DirProject & "cache\"
    Public DirError As String = DirProject & "error\"
    Public DirIco As String = DirProject & "images\"
    Public DirQuar As String = DirProject & "quarantine\"
    Public DirSound As String = DirExecPath & "sound\"

    Public Declare Function GetFileIconA Lib "SecurityIcons.dll" Alias "GetFileIcon" (txt As String) As String
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpDefault As String, lpReturnedString As String, nSize As Integer, lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpString As String, lpFileName As String) As Integer
    Public Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (lpszSoundName As String, uFlags As Long) As Long

    Public Function MD5Hash(t As String) As String
        Dim s As Byte() = Encoding.UTF8.GetBytes(t)
        Dim md5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = md5Hasher.ComputeHash(s)
        Dim sBuilder As New StringBuilder
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString.ToUpper
    End Function

    ' Retorna el hash MD5 de un archivo
    ' Parametro: t: Ruta hasta el archivo
    ' Retorna: getMD5FileHash: MD5, formato: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX, X={0,F}
    Public Function GetMd5(Path As String) As String
        'On Error Resume Next
        Dim Md5 As New MD5CryptoServiceProvider
        Dim sBuilder As New StringBuilder

        Dim F As New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        If F Is Nothing Then Return ""

        Md5.ComputeHash(F)

        For Each HashByte As Byte In Md5.Hash
            sBuilder.Append(String.Format("{0:X2}", HashByte))
        Next

        F.Close()
        Return sBuilder.ToString.ToLower
    End Function

    ' Retorna el hash MD5 de un archivo
    ' Parametro: t: Ruta hasta el archivo
    ' Retorna: getMD5FileHash: MD5, formato: XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX, X={0,F}
    Public Function GetSha256(Path As String) As String
        'On Error Resume Next
        Dim sha256 As New SHA256Managed
        Dim F As New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        sha256.ComputeHash(F)

        Dim sBuilder As New StringBuilder

        For Each HashByte As Byte In sha256.Hash
            sBuilder.Append(String.Format("{0:X2}", HashByte))
        Next

        F.Close()

        Return sBuilder.ToString.ToLower
    End Function

    ' Generar un serial pasando como parametro el formato (ejemplo de formato: CCCC-CCCC o NNCCL-LLNLC)
    ' C: Cualquiera (numero o letra)
    ' N: Numero
    ' L: Letra
    ' -: Simbolo de menos usado como separador
    Public Function GenerateSerial(wSerial As String) As String
        Dim ret As String = ""
        Dim alphabet As Char() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim vChars As Char() = {"N", "L"}
        Dim rnd2 As New Random()

        For i As Integer = 0 To wSerial.Length - 1
            Dim wChar As Char = wSerial.Chars(i)
            Dim iStr As Char = ""
            If wChar = "C" Then wChar = vChars(rnd2.Next(vChars.Length))

            Select Case wChar
                Case "N"
                    Dim r As Integer = Int(10 * rnd2.NextDouble)
                    iStr = CChar(CStr(r))
                Case "L"
                    Dim r As Integer = Int(alphabet.Length * rnd2.NextDouble)
                    iStr = alphabet(r)
                Case "-"
                    iStr = "-"
            End Select
            ret &= iStr
        Next

        Return ret
    End Function

    ' Verifica que un cadena te texto sea nombre de algun proceso, retorna el ID
    Public Function IsProcess(proceso As String) As Integer
        Dim processList() As Process = Process.GetProcesses

        For Each p As Process In processList
            If proceso.Equals(p.ProcessName & ".exe", StringComparison.OrdinalIgnoreCase) Then
                Return p.Id
                Exit Function
            End If
        Next

        Return -1
    End Function

    Public Sub LogFunc(text As String)
        My.Computer.FileSystem.WriteAllText(DirProject & "log_func.log", text & vbCrLf, True)
    End Sub

    Public Sub LogMalware(text As String)
        My.Computer.FileSystem.WriteAllText(DirProject & "log_malware.log", text & vbCrLf, True)
    End Sub

    Public Sub LogError(text As String)
        Dim d As Date = Now
        Dim mes As String = IIf(d.Month < 10, "0" & d.Month, d.Month)
        Dim dia As String = IIf(d.Day < 10, "0" & d.Day, d.Day)
        Dim fecha As String = d.Year & "-" & mes & "-" & dia
        My.Computer.FileSystem.WriteAllText(DirError & fecha & ".log", text & vbCrLf, True)
    End Sub

    ' Devuelve true si la fecha dat1 es mayor que la fecha dat2, false en caso contrario
    Public Function CompareDate(dat1 As String, dat2 As String) As Boolean
        Dim date1 As String() = dat1.Split("-")
        Dim date2 As String() = dat2.Split("-")

        Dim y1 As Integer = date1(0)
        Dim y2 As Integer = date2(0)
        Dim m1 As Integer = date1(1)
        Dim m2 As Integer = date2(1)
        Dim d1 As Integer = date1(2)
        Dim d2 As Integer = date2(2)

        If y1 > y2 Then
            Return True
        ElseIf y1 = y2 Then
            If m1 > m2 Then
                Return True
            ElseIf m1 = m2 Then
                If d1 > d2 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If

        Return True
    End Function

    ' Retorna la direccion original (en caso que exista) de un acceso directo
    ' Ej: "C:\calc.exe.lnk" devuelve "C:\Windows\System32\calc.exe"
    Public Function GetLnkTarget(sPath As String) As String
        Dim WSH As Object = CreateObject("WScript.Shell")
        Dim oShellLnk As Object = WSH.CreateShortcut(sPath)
        Return oShellLnk.TargetPath
    End Function

    ' Obtiene el valor (v) de un archivo .ini, formato k=v. Ej: [update] in date=2018-07-11
    ' Cuando llamamos al metodo pasandole como parametro "update", "date" y el archivo nos devuelve "2018-07-11", NO ELIMINA EL ARCHIVO AL TERMINAR
    Public Function ValueOfFile(title As String, key As String, fn As String) As String
        Dim ret As New String("", 255)

        If fn = "config.ini" Then
            fn = DirProject & fn
        End If

        Dim fi = My.Computer.FileSystem.GetFileInfo(fn)

        If fi.Exists Then
            GetPrivateProfileString(title, key, "", ret, 255, fi.FullName)
        End If

        Return ret.TrimEnd(vbNullChar)
    End Function

    Public Sub SetValueOfFile(title As String, key As String, value As String, fn As String)
        WritePrivateProfileString(title, key, value, fn)
    End Sub

    Public Function GetFileIcon(file As String) As String
        Return GetFileIconA(file)
    End Function

    Public Function SerialNumber(drive As String) As String
        If drive.Length = 1 Then
            drive &= ":"
        ElseIf drive.Length >= 3 Then
            drive = drive.Substring(0, 2)
        End If

        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim drv As Object = fso.GetDrive(drive)
        If drv.IsReady Then
            Return Integer.Parse(drv.SerialNumber).ToString("X2")
        End If

        Return "NONAME"
    End Function

    'To Get A Extension Name Sample ".txt" will become Text Document
    Public Function GetExtension(value As String) As String
        On Error GoTo Danger
        Dim RegK As RegistryKey
        Dim T1, T2 As String
        RegK = Registry.ClassesRoot.OpenSubKey(value, False)
        T1 = RegK.GetValue("")
        RegK = Registry.ClassesRoot.OpenSubKey(T1, False)
        T2 = RegK.GetValue("")
        Return T2
        GoTo Safe
Danger:
        If value = "" Then Return "Unknown" Else Return value
Safe:
    End Function

    ' To Get The Shortcut Byte Of A File Sample 5Mb 10GB
    Public Function GetBytes(value As Decimal) As String
        Dim V As Decimal = value
        Dim T1 As Integer = 0
        Dim BytesList As String() = {" B", " kB", " MB", " GB", " TB", " PB", " EB", " ZB", " YB"}
        If value >= 1024 Then
            Do While V >= 1024
                V /= 1024
                T1 += 1
            Loop
        End If

        Return Math.Round(V, 2) & BytesList(T1)
    End Function

    Public Function GetFolders(Path As String) As List(Of DirectoryInfo)
        'On Error Resume Next
        Dim L As New List(Of DirectoryInfo)
        Dim D As New DirectoryInfo(Path)
        L.Add(D)
        Try
            For Each DD As DirectoryInfo In D.GetDirectories("*.*", System.IO.SearchOption.TopDirectoryOnly)
                L.AddRange(GetFolders(DD.FullName))
            Next
        Catch ex As Exception
            Debug.WriteLine("-----E-----" & ex.Message)
        End Try

        Return L
    End Function

    Public Function DecryptMalwares() As Dictionary(Of String, String)
        Dim DICT_MALWARE As New Dictionary(Of String, String)

        DecryptFile(DirDef & "security00.sec", DirCache & "security00.cache")

        Dim file As New TextFieldParser(DirCache & "security00.cache")
        Dim fields As String()
        file.SetDelimiters("*")
        While Not file.EndOfData
            fields = file.ReadFields()
            DICT_MALWARE.Add(fields(0), fields(1))
        End While
        file.Close()

        Try
            My.Computer.FileSystem.DeleteFile(DirCache & "security00.cache")
        Catch ex As Exception
            LogError("-----ERROR-----" & vbCrLf & ex.Message & ex.StackTrace)
        End Try

        Return DICT_MALWARE
    End Function

    Public Function DecryptMalwaresSha() As Dictionary(Of String, String)
        Dim DICT_MALWARE_SHA As New Dictionary(Of String, String)

        DecryptFile(DirDef & "security01.sec", DirCache & "security01.cache")

        Dim file As New TextFieldParser(DirCache & "security01.cache")
        Dim fields As String()
        file.SetDelimiters("*")
        While Not file.EndOfData
            fields = file.ReadFields()
            DICT_MALWARE_SHA.Add(fields(0), fields(1))
        End While
        file.Close()

        Try
            My.Computer.FileSystem.DeleteFile(DirCache & "security01.cache")
        Catch ex As Exception
            LogError("-----ERROR-----" & vbCrLf & ex.Message & ex.StackTrace)
        End Try

        Return DICT_MALWARE_SHA
    End Function

End Module

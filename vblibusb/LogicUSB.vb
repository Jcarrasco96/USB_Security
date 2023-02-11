Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports Microsoft.Win32
Imports Microsoft.VisualBasic.FileIO
Imports SearchOption = System.IO.SearchOption
Imports System.Windows.Forms

Public Module LogicUSB

    Public Const AppName As String = "USBSecurity"
    Public Const AppNameSpace As String = "USB Security"
    Public Const FileSizeMin As Integer = 1 ' Tamaño minimo de archivos a escanear
    Public Const FileSizeMax As Integer = 67000000 ' Tamaño maximo de archivos a escanear ' 66168832
    Public Const DaysToUpdate As Byte = 7 ' dias hasta notificar que el AV esta desactualizado

    Function HeightTaskBar() As Integer
        Return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Size.Height
    End Function

    Function WidthTaskBar() As Integer
        Return Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Size.Width
    End Function

    Sub UpdatePosition(form As Form)
        form.SetDesktopLocation(My.Computer.Screen.Bounds.Width - form.Width - WidthTaskBar() - 5, My.Computer.Screen.Bounds.Height - form.Height - HeightTaskBar())
    End Sub

    Public UserName As String = My.User.Name
    Public SysDirectory As String = Environment.SystemDirectory
    Public SystemDrive As String = SysDirectory.Substring(0, 3)
    Public AppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    Public DirExecPath As String = My.Application.Info.DirectoryPath & "\"
    Public DirProject As String = AppData & "\" & AppName & "\"
    ' Otras rutas
    Public DirDef As String = DirProject & "bases\"
    Public DirCache As String = DirProject & "cache\"
    Public DirError As String = DirProject & "error\"
    Public DirIco As String = DirProject & "images\"
    Public DirQuar As String = DirProject & "quarantine\"
    Public DirSound As String = DirExecPath & "sound\"

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

    Public Function HashMe(path As String, hashType As HashType) As String
        Dim F As New FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        Dim sBuilder As New StringBuilder

        Dim hash

        Select Case hashType
            Case HashType.MD5
                hash = New MD5CryptoServiceProvider
            Case Else
                hash = New SHA256Managed
        End Select

        hash.ComputeHash(F)

        F.Close()

        For Each HashByte As Byte In hash.Hash
            sBuilder.Append(String.Format("{0:X2}", HashByte))
        Next

        Return sBuilder.ToString.ToLower
    End Function

    Public Enum HashType
        MD5
        SHA256
    End Enum

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

        If date1(0) > date2(0) Then
            Return True
        End If

        If date1(0) < date2(0) Then
            Return False
        End If

        If date1(1) > date2(1) Then
            Return True
        End If

        If date1(1) < date2(1) Then
            Return False
        End If

        Return date1(2) > date2(2)
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

        If fn = "config.ini" Then fn = DirProject & fn

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

    Public Function GetBytes(value As Decimal) As String
        Dim V As Decimal = value
        Dim T1 As Integer = 0
        Dim BytesList As String() = {" B", " KB", " MB", " GB", " TB", " PB", " EB", " ZB", " YB"}
        If value >= 1024 Then
            Do While V >= 1024
                V /= 1024
                T1 += 1
            Loop
        End If

        Return Math.Round(V, 2) & BytesList(T1)
    End Function

    Public Function GetFiles(path As String) As List(Of String)
        Dim F As New List(Of String)

        Try
            F.AddRange(Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly))
        Catch ex As Exception
            Debug.WriteLine("-----GetFilesRoot-----" & ex.Message)
            LogError("LogicUSB::GetFiles" & vbCrLf & "-----GetFilesRoot-----" & ex.Message & vbCrLf)
        End Try

        For Each strDir As String In Directory.GetDirectories(path, "*.*", SearchOption.TopDirectoryOnly)
            Try
                For Each strFile As String In Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                    F.Add(strFile)
                Next
            Catch ex As Exception
                Debug.WriteLine("-----GetFiles-----" & ex.Message)
                LogError("LogicUSB::GetFiles" & vbCrLf & "-----GetFiles-----" & ex.Message & vbCrLf)
            End Try
        Next

        Return F
    End Function

    Public Function DecryptMalwares(letter As String) As Dictionary(Of String, String)
        Dim DICT_MALWARE As New Dictionary(Of String, String)

        'DecryptFile(DirDef & "security" & letter & ".data", DirCache & "security00.cache")

        Dim file As New TextFieldParser(DirDef & "security" & letter & "MD5.data")
        Dim fields As String()
        file.SetDelimiters("*")
        While Not file.EndOfData
            fields = file.ReadFields()
            DICT_MALWARE.Add(fields(0).ToLower, fields(1))
        End While
        file.Close()

        Try
            'DeleteFile(DirCache & "security00.cache")
        Catch ex As Exception
            LogError("LogicUSB::DecryptMalwares" & vbCrLf & "-----ERROR-----" & vbCrLf & ex.Message & ex.StackTrace)
        End Try

        Return DICT_MALWARE
    End Function

    Public Function DecryptMalwaresSha(letter As Char) As Dictionary(Of String, String)
        Dim DICT_MALWARE_SHA As New Dictionary(Of String, String)

        'DecryptFile(DirDef & "security.sec", DirCache & "security01.cache")

        Dim file As New TextFieldParser(DirDef & "security" & letter & "SHA256.data")
        Dim fields As String()
        file.SetDelimiters("*")
        While Not file.EndOfData
            fields = file.ReadFields()
            DICT_MALWARE_SHA.Add(fields(0).ToLower, fields(1))
        End While
        file.Close()

        Try
            DeleteFile(DirCache & "security01.cache")
        Catch ex As Exception
            LogError("LogicUSB::DecryptMalwaresSha" & vbCrLf & "-----ERROR-----" & vbCrLf & ex.Message & ex.StackTrace)
        End Try

        Return DICT_MALWARE_SHA
    End Function

End Module

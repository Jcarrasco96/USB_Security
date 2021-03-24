Imports Microsoft.VisualBasic.FileIO

Public Class EngineScan

    Private arrCache As ArrayList
    'Private drvCache As String
    Private options As ScanOptions

    Public ARR_FILENAME As ArrayList
    Public ARR_FOLDERNAME As ArrayList
    Public ARR_EXTENSION As ArrayList
    Public ARR_SIZE As List(Of UInteger)
    Public ARR_SEC06 As List(Of Security06)
    Public ARR_SEC07 As List(Of Security06)
    Public DICT_MALWARE As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA As Dictionary(Of String, String)

    Public Sub LoadDef()
        ARR_FILENAME = New ArrayList
        ARR_FOLDERNAME = New ArrayList
        ARR_EXTENSION = New ArrayList
        ARR_SIZE = New List(Of UInteger)
        ARR_SEC06 = New List(Of Security06)
        ARR_SEC07 = New List(Of Security06)
        DICT_MALWARE = DecryptMalwares()
        DICT_MALWARE_SHA = DecryptMalwaresSha()

        ' Desencriptar las bases en %cache%
        Encrypter.DecryptFile(DirDef & "secur001.sec", DirCache & "secur001.cache")
        Encrypter.DecryptFile(DirDef & "secur002.sec", DirCache & "secur002.cache")
        Encrypter.DecryptFile(DirDef & "secur003.sec", DirCache & "secur003.cache")
        Encrypter.DecryptFile(DirDef & "secur004.sec", DirCache & "secur004.cache")
        Encrypter.DecryptFile(DirDef & "secur006.sec", DirCache & "secur006.cache")
        Encrypter.DecryptFile(DirDef & "secur007.sec", DirCache & "secur007.cache")

        Dim file As TextFieldParser
        Dim fields As String()

        ' ARR_FILENAME
        file = New TextFieldParser(DirCache & "secur001.cache")
        While Not file.EndOfData
            ARR_FILENAME.Add(file.ReadLine())
        End While
        file.Close()

        ' ARR_FOLDERNAME
        file = New TextFieldParser(DirCache & "secur002.cache")
        While Not file.EndOfData
            ARR_FOLDERNAME.Add(file.ReadLine())
        End While
        file.Close()

        ' ARR_EXTENSION
        file = New TextFieldParser(DirCache & "secur003.cache")
        While Not file.EndOfData
            ARR_EXTENSION.Add(file.ReadLine())
        End While
        file.Close()

        ' ARR_SIZE
        file = New TextFieldParser(DirCache & "secur004.cache")
        While Not file.EndOfData
            ARR_SIZE.Add(file.ReadLine())
        End While
        file.Close()

        ' ARR_SEC06
        file = New TextFieldParser(DirCache & "secur006.cache")
        file.SetDelimiters("*")
        While Not file.EndOfData
            fields = file.ReadFields()
            ARR_SEC06.Add(New Security06(fields(0), fields(1), fields(2)))
        End While
        file.Close()

        ' ARR_SEC07
        file = New TextFieldParser(DirCache & "secur007.cache")
        file.SetDelimiters("*")
        While Not file.EndOfData
            fields = file.ReadFields()
            ARR_SEC07.Add(New Security06(fields(0), fields(1), fields(2)))
        End While
        file.Close()

        ' Eliminar archivos almacenados en cache
        If My.Computer.FileSystem.FileExists(DirCache & "secur001.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur001.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur002.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur002.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur003.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur003.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur004.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur004.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur006.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur006.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur007.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur007.cache")
    End Sub

    Public Sub New(opts As ScanOptions)
        arrCache = New ArrayList
        options = opts
        'drvCache = DirCache & LogicUSB.MD5Hash(drive)

        LoadDef()

        'If My.Computer.FileSystem.GetFileInfo(drvCache).Exists Then
        '    Using parser As New TextFieldParser(drvCache)
        '        While Not parser.EndOfData
        '            arrCache.Add(parser.ReadLine)
        '        End While
        '    End Using
        'End If

    End Sub

    Public Function scanAll(ByVal Status As String) As Virus
        Dim drv As String = Status.Substring(0, 3)
        Dim f As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(Status)

        Dim te As String = f.FullName & "*" & f.Length
        If Not arrCache.Contains(te) Then
            If checkExtensionDB(f.Extension) Then ' Chequea que la extension del archivo este en las extensiones que se escanearan
                Dim rcvn As ReturnCheckVirusName = checkMalwareDB(f.FullName, f.Length) ' Chequea que el archivo este en la BD
                If rcvn.isMalware Then ' Chequear si el archivo es un virus conocido su md5 en la base de datos
                    Return New Virus(f.FullName, f.Length, rcvn.mds, rcvn.name, rcvn.isMalware)
                End If

                ' Virus de tipo RENAMER (Virus Win32.RENAMER.J), ejemplo: virus: 123.exe y existe original oculto g123.exe
                If f.Length = 534016 Then
                    Dim pathG As String = f.DirectoryName & "\"
                    Dim fileG As String = "g" & f.Name
                    Dim info As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(pathG & fileG)

                    If info.Exists Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Win32.RENAMER", True)
                    End If
                End If

                If Not drv.Equals(LogicUSB.SystemDrive, StringComparison.OrdinalIgnoreCase) Then
                    If options.comboDetectFilesSuspect > 0 Then ' Deteccion de archivos bajo
                        If f.Extension.Equals(".hta", StringComparison.OrdinalIgnoreCase) Or f.Extension.Equals(".jse", StringComparison.OrdinalIgnoreCase) Then ' Chequea que sea de ext hta o jse
                            Dim text As String = My.Computer.FileSystem.ReadAllText(f.FullName).ToLower()
                            If text.Contains("switch(tipodisco)") And text.Contains(".createshortcut(") Then 'Find Virus desktop.ini.hta ' Chequea que el archivo contenga ""
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Trojan.JS.Agent.caj", True)
                            ElseIf text.Contains("dm=z.length-2") And text.Contains("z.substring(dm,dm+2)") Then 'Find Virus foto escritorio .jse ' Chequea que el archivo contenga ""
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Worm.Script.Generic.jse", True)
                            End If
                        ElseIf f.Extension.Equals(".bat", StringComparison.OrdinalIgnoreCase) Then
                            Dim text As String = My.Computer.FileSystem.ReadAllText(f.FullName).ToLower()
                            If text.Contains("copy %0 ""%%~fa\%%~nxa.bat""") Then
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Worm AutoCopier", True)
                            End If
                        ElseIf f.Extension.Equals(".vbs", StringComparison.OrdinalIgnoreCase) Then
                            Dim text As String = My.Computer.FileSystem.ReadAllText(f.FullName).ToLower()
                            If text.Contains("executeglobal") And text.Contains("split") And text.Contains("ubound") And text.Contains("end function") Then
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                            ElseIf text.Contains("execute") And text.Contains("split") And text.Contains("for i = 0 to ubound") And text.Contains("chr(") Then
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                            ElseIf text.Contains("execute") And text.Contains("end function") And text.Contains("decodebase64") And text.Contains("chr(") Then
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                            ElseIf text.Contains("execute") And text.Contains(") & chr(") And text.Contains("747174645/7115949") Then
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                            End If
                        End If

                        If Not f.FullName.EndsWith("Adata_Chrome.exe", StringComparison.OrdinalIgnoreCase) Then ' Chequea que el nombre del archivo no termine en ""
                            If f.Attributes.ToString.Contains("Hidden") Then ' Chequea que el archivo tenga el atributo OCULTO (Hidden)
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Hidden" & f.Extension, True)
                            End If
                        End If ' Archivos ejecutables ocultos

                        If options.comboDetectFilesSuspect = 1 Or options.comboDetectFilesSuspect = 2 Then ' Deteccion de archivos normal y alto
                            Dim fbnas As String = checkByNameSize(f.FullName)
                            If Not fbnas.Equals("NO_MALWARE") Then ' Location ' Chequea tamaño y nombre de archivo
                                Return New Virus(f.FullName, f.Length, rcvn.mds, fbnas, True)
                            End If

                            If f.Extension.Equals(".lnk", StringComparison.OrdinalIgnoreCase) Then ' Chequea que sea un acceso directo
                                Dim target As String = LogicUSB.GetLnkTarget(f.FullName)
                                Dim fileTarget As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(target)
                                If fileTarget.Exists Then
                                    If Not fileTarget.FullName.StartsWith(LogicUSB.SysDirectory, StringComparison.OrdinalIgnoreCase) Then
                                        If checkExtensionDB(fileTarget.Extension) Then
                                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut" & fileTarget.Extension, True)
                                        End If
                                    Else
                                        Dim lowerTarget As String = fileTarget.FullName.ToLower
                                        If lowerTarget.Equals(LogicUSB.SysDirectory & "\cmd.exe", StringComparison.OrdinalIgnoreCase) Then
                                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut.Cmd", True)
                                        ElseIf lowerTarget.Equals(LogicUSB.SysDirectory & "\rundll32.exe", StringComparison.OrdinalIgnoreCase) Then
                                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.RunDll32.Cmd", True)
                                        ElseIf lowerTarget.Equals(LogicUSB.SysDirectory & "\wscript.exe", StringComparison.OrdinalIgnoreCase) Then
                                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Wscript.Cmd", True)
                                        End If
                                    End If
                                End If

                                If f.FullName.Equals(drv & "Nouveau dossier.lnk", StringComparison.OrdinalIgnoreCase) Or f.FullName.Equals(drv & "Dossier.lnk", StringComparison.OrdinalIgnoreCase) Then ' Chequea nombre de acceso directo
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Wscript.Skype.Rar", True)
                                ElseIf f.FullName.Contains("Copy of Shortcut to (") And f.FullName.Contains(").lnk") Then ' Chequea nombre de acceso directo
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Worm.Win32.Qvod.aks", True)
                                Else
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut.Lnk", True)
                                End If
                            ElseIf f.Extension.Equals(".pif", StringComparison.OrdinalIgnoreCase) Or f.Extension.Equals(".url", StringComparison.OrdinalIgnoreCase) Then ' Chequea extensiones de acceso directo
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut" & f.Extension, True)
                            ElseIf f.Extension.Equals(".exe", StringComparison.OrdinalIgnoreCase) Then ' Chequea que sea una app de windows
                                If f.Name.Split(".").Length >= 3 Then ' VIRUS DE LAS CARPETAS. Ej: C:\Jesus.exe o C:\Jesus :(
                                    Dim i As String = ""
                                    Dim virus As Boolean = False 'duplicateExe(f.FullName, i)
                                    If virus Then
                                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Duplicated.Exe", True)
                                    Else 'VIRUS PERSONAL JPG
                                        Dim s As String = i.Replace(" ", "")
                                        If s.Contains(".jpg") Then
                                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Personal.Jpg", True)
                                        End If
                                    End If
                                End If
                            End If

                            If options.comboDetectFilesSuspect = 2 Then ' Deteccion de archivos alto
                                Dim nameExt As String = f.Name & f.Extension
                                If checkFileNameDB(nameExt) Then ' Chequea que el nombre del archivo sea el mismo que en la BD
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Name." & nameExt, True)
                                ElseIf checkFolderNameDB(f.FullName) Then ' Chequea que el nombre de la carpeta sea el mismo que en la BD
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Folder&Name", True)
                                End If
                            End If
                        End If
                    End If
                End If
                'ElseIf Scan Then ' Calcular el md5 de todos los archivos para ver si estan en cuarentena, tengo q mejorar eso
                '    Dim mdsActual As String = getMD5FileHash(f.FullName)
                '    If isInQuarantine(mdsActual) Then
                '        Scan = False
                '        alertVirus(f.FullName, f.Length, mdsActual, "Suspect.File.Quarantine")
                '    End If
                My.Computer.FileSystem.WriteAllText(DirCache & "scanner.inf", te & vbCrLf, True)
            End If
        Else
            'Debug.WriteLine("no escaneo " & f.FullName & " porque no ha cambiado su path ni tamaño")
        End If

        Return New Virus("", 0, "", "")
    End Function

    Function checkExtensionDB(ByVal ext As String) As Boolean
        If Not ext.StartsWith(".") Then ext = "." & ext
        Return ARR_EXTENSION.Contains(ext)
    End Function

    Function checkMalwareDB(ByVal fileName As String, ByVal fileSize As Integer) As ReturnCheckVirusName
        Dim s As ReturnCheckVirusName
        s.name = "NO_MALWARE"
        s.mds = LogicUSB.GetMd5(fileName)
        s.sha256 = LogicUSB.GetSha256(fileName)
        s.isMalware = False

        If checkSizeDB(fileSize) Then
            If s.mds.Equals("") And s.sha256.Equals("") Then
                s.mds = "NO_MALWARE"
            Else
                s.name = getMD5DB(s.mds, s.sha256)
            End If

            If s.name.Equals("NO_MALWARE") Then
                s.name = checkMD5IconDB(fileName, fileSize) ' CHECK FIRM ICON
            End If
        End If

        s.isMalware = Not s.name.Equals("NO_MALWARE")

        Return s
    End Function

    Function checkSizeDB(ByVal size As UInteger) As Boolean
        Return ARR_SIZE.Contains(size)
    End Function

    Function getMD5DB(ByVal mds As String, ByVal sha256 As String) As String
        If DICT_MALWARE.ContainsKey(mds) Then
            Return DICT_MALWARE.Item(mds)
        ElseIf DICT_MALWARE_SHA.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA.Item(sha256)
        Else
            Return "NO_MALWARE"
        End If
    End Function

    Function checkMD5IconDB(ByVal filename As String, ByVal size As Long) As String
        Dim path2Icon As String = LogicUSB.GetFileIcon(filename)
        If path2Icon = vbNullString Or path2Icon = "" Then
            Return "NO_MALWARE"
        End If

        Dim mds As String = LogicUSB.GetMd5(path2Icon)

        ' Eliminar el archivo temporal del icono
        Try
            If My.Computer.FileSystem.GetFileInfo(path2Icon).Exists Then
                My.Computer.FileSystem.DeleteFile(path2Icon, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try

        For Each icon As Security06 In ARR_SEC06
            If icon.size = size And icon.mds.Equals(mds, StringComparison.OrdinalIgnoreCase) Then
                Return icon.malware
            End If
        Next

        Return "NO_MALWARE" ' icon secur006.upd
    End Function

    Function checkByNameSize(ByVal filename As String) As String
        Dim f = My.Computer.FileSystem.GetFileInfo(filename)

        For Each location As Security06 In ARR_SEC06
            If location.size = f.Length And location.mds.Equals(filename, StringComparison.OrdinalIgnoreCase) Then
                Return location.malware
            End If
        Next

        Return "NO_MALWARE" ' location secur007.upd
    End Function

    Function checkFileNameDB(ByVal fn As String) As Boolean
        Return ARR_FILENAME.Contains(fn)
    End Function

    Function checkFolderNameDB(ByVal fn As String) As Boolean
        Return ARR_FOLDERNAME.Contains(fn)
    End Function

End Class

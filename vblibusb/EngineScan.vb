Imports Microsoft.VisualBasic.FileIO

Public Class EngineScan

    Public Sub Free()
        arrCache = Nothing
        options = Nothing

        ARR_FILENAME = Nothing
        ARR_FOLDERNAME = Nothing
        ARR_SEC06 = Nothing
        ARR_SEC07 = Nothing

        DICT_MALWARE_0 = Nothing
        DICT_MALWARE_1 = Nothing
        DICT_MALWARE_2 = Nothing
        DICT_MALWARE_3 = Nothing
        DICT_MALWARE_4 = Nothing
        DICT_MALWARE_5 = Nothing
        DICT_MALWARE_6 = Nothing
        DICT_MALWARE_7 = Nothing
        DICT_MALWARE_8 = Nothing
        DICT_MALWARE_9 = Nothing
        DICT_MALWARE_A = Nothing
        DICT_MALWARE_B = Nothing
        DICT_MALWARE_C = Nothing
        DICT_MALWARE_D = Nothing
        DICT_MALWARE_E = Nothing
        DICT_MALWARE_F = Nothing

        DICT_MALWARE_SHA_0 = Nothing
        DICT_MALWARE_SHA_1 = Nothing
        DICT_MALWARE_SHA_2 = Nothing
        DICT_MALWARE_SHA_3 = Nothing
        DICT_MALWARE_SHA_4 = Nothing
        DICT_MALWARE_SHA_5 = Nothing
        DICT_MALWARE_SHA_6 = Nothing
        DICT_MALWARE_SHA_7 = Nothing
        DICT_MALWARE_SHA_8 = Nothing
        DICT_MALWARE_SHA_9 = Nothing
        DICT_MALWARE_SHA_A = Nothing
        DICT_MALWARE_SHA_B = Nothing
        DICT_MALWARE_SHA_C = Nothing
        DICT_MALWARE_SHA_D = Nothing
        DICT_MALWARE_SHA_E = Nothing
        DICT_MALWARE_SHA_F = Nothing
    End Sub

    Private arrCache As ArrayList
    Private options As ScanOptions

    Public ARR_FILENAME As ArrayList
    Public ARR_FOLDERNAME As ArrayList
    Public ARR_SEC06 As List(Of Security06)
    Public ARR_SEC07 As List(Of Security06)

    Public DICT_MALWARE_0 As Dictionary(Of String, String)
    Public DICT_MALWARE_1 As Dictionary(Of String, String)
    Public DICT_MALWARE_2 As Dictionary(Of String, String)
    Public DICT_MALWARE_3 As Dictionary(Of String, String)
    Public DICT_MALWARE_4 As Dictionary(Of String, String)
    Public DICT_MALWARE_5 As Dictionary(Of String, String)
    Public DICT_MALWARE_6 As Dictionary(Of String, String)
    Public DICT_MALWARE_7 As Dictionary(Of String, String)
    Public DICT_MALWARE_8 As Dictionary(Of String, String)
    Public DICT_MALWARE_9 As Dictionary(Of String, String)
    Public DICT_MALWARE_A As Dictionary(Of String, String)
    Public DICT_MALWARE_B As Dictionary(Of String, String)
    Public DICT_MALWARE_C As Dictionary(Of String, String)
    Public DICT_MALWARE_D As Dictionary(Of String, String)
    Public DICT_MALWARE_E As Dictionary(Of String, String)
    Public DICT_MALWARE_F As Dictionary(Of String, String)

    Public DICT_MALWARE_SHA_0 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_1 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_2 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_3 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_4 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_5 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_6 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_7 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_8 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_9 As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_A As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_B As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_C As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_D As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_E As Dictionary(Of String, String)
    Public DICT_MALWARE_SHA_F As Dictionary(Of String, String)

    Public Sub New(drive As String, opts As ScanOptions)
        arrCache = New ArrayList
        options = opts

        Dim drvCache = DirCache & SerialNumber(drive)

        If My.Computer.FileSystem.GetFileInfo(drvCache).Exists Then
            Using parser As New TextFieldParser(drvCache)
                While Not parser.EndOfData
                    arrCache.Add(parser.ReadLine)
                End While
                parser.Close()
            End Using
        End If

        ARR_FILENAME = New ArrayList
        ARR_FOLDERNAME = New ArrayList
        ARR_SEC06 = New List(Of Security06)
        ARR_SEC07 = New List(Of Security06)

        DICT_MALWARE_0 = DecryptMalwares("0")
        DICT_MALWARE_1 = DecryptMalwares("1")
        DICT_MALWARE_2 = DecryptMalwares("2")
        DICT_MALWARE_3 = DecryptMalwares("3")
        DICT_MALWARE_4 = DecryptMalwares("4")
        DICT_MALWARE_5 = DecryptMalwares("5")
        DICT_MALWARE_6 = DecryptMalwares("6")
        DICT_MALWARE_7 = DecryptMalwares("7")
        DICT_MALWARE_8 = DecryptMalwares("8")
        DICT_MALWARE_9 = DecryptMalwares("9")
        DICT_MALWARE_A = DecryptMalwares("A")
        DICT_MALWARE_B = DecryptMalwares("B")
        DICT_MALWARE_C = DecryptMalwares("C")
        DICT_MALWARE_D = DecryptMalwares("D")
        DICT_MALWARE_E = DecryptMalwares("E")
        DICT_MALWARE_F = DecryptMalwares("F")

        DICT_MALWARE_SHA_0 = DecryptMalwaresSha("0")
        DICT_MALWARE_SHA_1 = DecryptMalwaresSha("1")
        DICT_MALWARE_SHA_2 = DecryptMalwaresSha("2")
        DICT_MALWARE_SHA_3 = DecryptMalwaresSha("3")
        DICT_MALWARE_SHA_4 = DecryptMalwaresSha("4")
        DICT_MALWARE_SHA_5 = DecryptMalwaresSha("5")
        DICT_MALWARE_SHA_6 = DecryptMalwaresSha("6")
        DICT_MALWARE_SHA_7 = DecryptMalwaresSha("7")
        DICT_MALWARE_SHA_8 = DecryptMalwaresSha("8")
        DICT_MALWARE_SHA_9 = DecryptMalwaresSha("9")
        DICT_MALWARE_SHA_A = DecryptMalwaresSha("A")
        DICT_MALWARE_SHA_B = DecryptMalwaresSha("B")
        DICT_MALWARE_SHA_C = DecryptMalwaresSha("C")
        DICT_MALWARE_SHA_D = DecryptMalwaresSha("D")
        DICT_MALWARE_SHA_E = DecryptMalwaresSha("E")
        DICT_MALWARE_SHA_F = DecryptMalwaresSha("F")

        'Dim c = DICT_MALWARE_0.Count + DICT_MALWARE_1.Count + DICT_MALWARE_2.Count + DICT_MALWARE_3.Count + DICT_MALWARE_4.Count + DICT_MALWARE_5.Count + DICT_MALWARE_6.Count + DICT_MALWARE_7.Count + DICT_MALWARE_8.Count + DICT_MALWARE_9.Count + DICT_MALWARE_A.Count + DICT_MALWARE_B.Count + DICT_MALWARE_C.Count + DICT_MALWARE_D.Count + DICT_MALWARE_E.Count + DICT_MALWARE_F.Count
        'c += DICT_MALWARE_SHA_0.Count + DICT_MALWARE_SHA_1.Count + DICT_MALWARE_SHA_2.Count + DICT_MALWARE_SHA_3.Count + DICT_MALWARE_SHA_4.Count + DICT_MALWARE_SHA_5.Count + DICT_MALWARE_SHA_6.Count + DICT_MALWARE_SHA_7.Count + DICT_MALWARE_SHA_8.Count + DICT_MALWARE_SHA_9.Count + DICT_MALWARE_SHA_A.Count + DICT_MALWARE_SHA_B.Count + DICT_MALWARE_SHA_C.Count + DICT_MALWARE_SHA_D.Count + DICT_MALWARE_SHA_E.Count + DICT_MALWARE_SHA_F.Count
        'MsgBox(c)

        ' Desencriptar las bases en %cache%
        DecryptFile(DirDef & "secur001.sec", DirCache & "secur001.cache")
        DecryptFile(DirDef & "secur002.sec", DirCache & "secur002.cache")
        DecryptFile(DirDef & "secur006.sec", DirCache & "secur006.cache")
        DecryptFile(DirDef & "secur007.sec", DirCache & "secur007.cache")

        ' ARR_FILENAME
        Using parser As New TextFieldParser(DirCache & "secur001.cache")
            While Not parser.EndOfData
                ARR_FILENAME.Add(parser.ReadLine)
            End While
            parser.Close()
        End Using

        ' ARR_FOLDERNAME
        Using parser As New TextFieldParser(DirCache & "secur002.cache")
            While Not parser.EndOfData
                ARR_FOLDERNAME.Add(parser.ReadLine)
            End While
            parser.Close()
        End Using

        Dim fields() As String

        ' ARR_SEC06
        Using parser As New TextFieldParser(DirCache & "secur006.cache")
            parser.SetDelimiters("*")
            While Not parser.EndOfData
                fields = parser.ReadFields()
                ARR_SEC06.Add(New Security06(fields(0), fields(1), fields(2)))
            End While
            parser.Close()
        End Using

        ' ARR_SEC07
        Using parser As New TextFieldParser(DirCache & "secur007.cache")
            parser.SetDelimiters("*")
            While Not parser.EndOfData
                fields = parser.ReadFields()
                ARR_SEC07.Add(New Security06(fields(0), fields(1), fields(2)))
                'Debug.WriteLine(String.Format("{0} {1} {2}", fields(0), fields(1), fields(2)))
            End While
            parser.Close()
        End Using

        ' Eliminar archivos almacenados en cache
        If My.Computer.FileSystem.FileExists(DirCache & "secur001.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur001.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur002.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur002.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur006.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur006.cache")
        If My.Computer.FileSystem.FileExists(DirCache & "secur007.cache") Then My.Computer.FileSystem.DeleteFile(DirCache & "secur007.cache")
    End Sub

    Public Function ScanAll(Status As String) As Virus
        Dim drv As String = Status.Substring(0, 3)
        Dim f As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(Status)

        Dim te As String = f.FullName & "*" & f.Length
        If Not arrCache.Contains(te) And CheckExtension(f.Extension) Then
            Dim rcvn As ReturnCheckVirusName = CheckMalwareDB(f.FullName, f.Length) ' Chequea que el archivo este en la BD
            If rcvn.isMalware Then ' Chequear si el archivo es un virus conocido su md5 en la base de datos
                Return New Virus(f.FullName, f.Length, rcvn.mds, rcvn.name, rcvn.isMalware)
            End If

            ' Virus de tipo RENAMER (Virus Win32.RENAMER.J), ejemplo: virus: 123.exe y existe original oculto g123.exe
            If f.Length = 534016 Then
                Dim info As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(f.DirectoryName & "\" & "g" & f.Name)

                If info.Exists Then
                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Win32.RENAMER", True)
                End If
            End If

            If Not drv.ToLower.Equals(SystemDrive.ToLower) Or True Then
                If options.comboDetectFilesSuspect > 0 Then ' Deteccion de archivos bajo
                    Dim textNormal As String = My.Computer.FileSystem.ReadAllText(f.FullName, System.Text.Encoding.Default)

                    ' cekDocinF
                    If textNormal.Contains("ÐÏà¡±á") And textNormal.Contains("Word.Document.8") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Infected Document " & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' cekAlman
                    If textNormal.Contains("J6vÙ0fc›") And textNormal.Contains("16äØøcc‘") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Infected Alman.A" & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' cekVirutGen
                    If textNormal.Contains("…Àt!Pÿ•$@") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Virut.Gen." & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' cekTrojanGen
                    Dim REGrun = "C" & Chr(0) & "u" & Chr(0) & "r" & Chr(0) & "r" & Chr(0) & "e" & Chr(0) & "n" & Chr(0) & "t" & Chr(0) & "V" & Chr(0) & "e" & Chr(0) & "r" & Chr(0) & "s" & Chr(0) & "i" & Chr(0) & "o" & Chr(0) & "n" & Chr(0) & "\" & Chr(0) & "R" & Chr(0) & "u" & Chr(0) & "n"
                    Dim REGhiden = "C" & Chr(0) & "u" & Chr(0) & "r" & Chr(0) & "r" & Chr(0) & "e" & Chr(0) & "n" & Chr(0) & "t" & Chr(0) & "V" & Chr(0) & "e" & Chr(0) & "r" & Chr(0) & "s" & Chr(0) & "i" & Chr(0) & "o" & Chr(0) & "n" & Chr(0) & "\" & Chr(0) & "E" & Chr(0) & "x" & Chr(0) & "p" & Chr(0) & "l" & Chr(0) & "o" & Chr(0) & "r" & Chr(0) & "e" & Chr(0) & "r" & Chr(0) & "\" & Chr(0) & "A" & Chr(0) & "d" & Chr(0) & "v" & Chr(0) & "a" & Chr(0) & "n" & Chr(0) & "c" & Chr(0) & "e" & Chr(0) & "d"

                    If textNormal.Contains(REGrun) And textNormal.Contains(REGhiden) Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Trojan.Generic." & rcvn.mds.Substring(0, 3), True)
                    End If

                    Dim text As String = textNormal.ToLower()

                    ' cekRunouce
                    If text.Contains("mail from: imissyou@btamail.net.cn") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Virus.Runouce.B2." & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' cekCanTix
                    If text.Contains("[autorun]") And text.Contains("open=wscript.exe //") And text.Contains(":vbscript dekstop.ini auto") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Worm.Cantix.Inf." & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' cekunrealX
                    If text.Contains("system32\blacklist") And text.Contains("by unrealx33") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Worm.Unrealx33.BAT." & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' cekPirut
                    If text.Contains("‹oý¿") Then
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Win32.Sality.AT" & rcvn.mds.Substring(0, 3), True)
                    End If

                    ' CekFisiK
                    If f.Extension.ToLower.Equals(".bat") Or f.Extension.ToLower.Equals(".db") Or f.Extension.ToLower.Equals(".dls") Or f.Extension.ToLower.Equals(".eml") Or f.Extension.ToLower.Equals(".inf") Or f.Extension.ToLower.Equals(".ini") Or f.Extension.ToLower.Equals(".txt") Or f.Extension.ToLower.Equals(".vbs") Then
                        If text.Contains("createobject") And text.Contains("regwrite") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.Regwrite." & rcvn.mds.Substring(0, 3), True)
                        End If
                        If text.Contains("createobject") And text.Contains("disabletaskmgr") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.DisableTaskManager." & rcvn.mds.Substring(0, 3), True)
                        End If
                        If text.Contains("createobject") And text.Contains("strreverse") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.Encripted." & rcvn.mds.Substring(0, 3), True)
                        End If
                        If text.Contains("createobject") And text.Contains("copyfile") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.CopyFile." & rcvn.mds.Substring(0, 3), True)
                        End If
                        If text.Contains("createobject") And text.Contains("autorun") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.Autorun." & rcvn.mds.Substring(0, 3), True)
                        End If
                        If text.Contains("createobject") And text.Contains("getspecialfolder") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.SpecialDir." & rcvn.mds.Substring(0, 3), True)
                        End If
                        If text.Contains("createobject") And text.Contains("virus") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Heur:Malware.Script.Virus." & rcvn.mds.Substring(0, 3), True)
                        End If
                    End If

                    If f.Extension.ToLower.Equals(".hta") Or f.Extension.ToLower.Equals(".jse") Then ' Chequea que sea de ext hta o jse
                        If text.Contains("switch(tipodisco)") And text.Contains(".createshortcut(") Then 'Find Virus desktop.ini.hta
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Trojan.JS.Agent.caj", True)
                        End If

                        If text.Contains("dm=z.length-2") And text.Contains("z.substring(dm,dm+2)") Then 'Find Virus foto escritorio .jse
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Worm.Script.Generic.jse", True)
                        End If
                    End If

                    If f.Extension.ToLower.Equals(".bat") Then
                        If text.Contains("copy %0 ""%%~fa\%%~nxa.bat""") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Worm AutoCopier", True)
                        End If
                    End If

                    If f.Extension.ToLower.Equals(".vbs") Then
                        If text.Contains("executeglobal") And text.Contains("split") And text.Contains("ubound") And text.Contains("end function") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                        End If

                        If text.Contains("execute") And text.Contains("split") And text.Contains("for i = 0 to ubound") And text.Contains("chr(") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                        End If

                        If text.Contains("execute") And text.Contains("end function") And text.Contains("decodebase64") And text.Contains("chr(") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                        End If

                        If text.Contains("execute") And text.Contains(") & chr(") And text.Contains("747174645/7115949") Then
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect Trojan.VBS.Kriptik", True)
                        End If
                    End If

                    If rcvn.mds <> "99d7c203daf12beee499251ff0147c44" And f.Attributes.ToString.Contains("Hidden") Then ' Chequea archivo de proteccion de este AV y que el archivo tenga el atributo Hidden
                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Hidden" & f.Extension, True)
                    End If ' Archivos ejecutables ocultos

                    If options.comboDetectFilesSuspect = 1 Or options.comboDetectFilesSuspect = 2 Then ' Deteccion de archivos normal y alto
                        Dim fbnas As String = CheckByNameSize(f.FullName)
                        If Not fbnas.Equals("NO_MALWARE") Then ' Location ' Chequea tamaño y nombre de archivo
                            Return New Virus(f.FullName, f.Length, rcvn.mds, fbnas, True)
                        End If

                        If f.Extension.ToLower.Equals(".lnk") Then ' Chequea que sea un acceso directo
                            Dim target As String = GetLnkTarget(f.FullName)
                            If target <> "" Then
                                Dim fileTarget As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(target)
                                If fileTarget.Exists Then
                                    If Not fileTarget.FullName.ToLower.StartsWith(SysDirectory.ToLower) Then
                                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut" & fileTarget.Extension, True)
                                    End If

                                    If fileTarget.FullName.ToLower.Equals(SysDirectory.ToLower & "\cmd.exe") Then
                                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut.Cmd", True)
                                    End If

                                    If fileTarget.FullName.ToLower.Equals(SysDirectory.ToLower & "\rundll32.exe") Then
                                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.RunDll32.Cmd", True)
                                    End If

                                    If fileTarget.FullName.ToLower.Equals(SysDirectory & "\wscript.exe") Then
                                        Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Wscript.Cmd", True)
                                    End If
                                End If
                            End If

                            If f.FullName.ToLower.Equals(drv & "nouveau dossier.lnk") Or f.FullName.ToLower.Equals(drv & "dossier.lnk") Then ' Chequea nombre de acceso directo
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Wscript.Skype.Rar", True)
                            End If

                            If f.FullName.ToLower.Contains("copy of shortcut to (") And f.FullName.ToLower.Contains(").lnk") Then ' Chequea nombre de acceso directo
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Worm.Win32.Qvod.aks", True)
                            End If

                            If f.Length <= 4096 Then
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut.Lnk", True)
                            End If
                        End If

                        If f.Extension.ToLower.Equals(".pif") Or f.Extension.ToLower.Equals(".url") Then ' Chequea extensiones de acceso directo
                            Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Shortcut" & f.Extension, True)
                        End If

                        If f.Extension.ToLower.Equals(".exe") Then ' Chequea que sea una app de windows
                            If f.Name.Split(".").Length >= 3 Then ' VIRUS DE LAS CARPETAS. Ej: C:\Jesus.exe o C:\Jesus :(
                                Dim i As String = ""
                                Dim virus As Boolean = False 'duplicateExe(f.FullName, i)
                                If virus Then
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Duplicated.Exe", True)
                                End If

                                'VIRUS PERSONAL JPG
                                Dim s As String = i.Replace(" ", "")
                                If s.Contains(".jpg") Then
                                    Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Personal.Jpg", True)
                                End If
                            End If
                        End If

                        If options.comboDetectFilesSuspect = 2 Then ' Deteccion de archivos alto
                            Dim name As String = f.Name

                            If CheckFileNameDB(name) Then ' Chequea que el nombre del archivo sea el mismo que en la BD
                                Return New Virus(f.FullName, f.Length, rcvn.mds, "Suspect.Name." & name, True)
                            End If

                            If CheckFolderNameDB(f.FullName) Then ' Chequea que el nombre de la carpeta sea el mismo que en la BD
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
            'My.Computer.FileSystem.WriteAllText(DirCache & SerialNumber(drv), te & vbCrLf, True)
        Else
            'Debug.WriteLine("no escaneo " & f.FullName & " porque no ha cambiado su path ni tamaño")
        End If

        Return New Virus("NO_MALWARE", 0, "NO_MALWARE", "NO_MALWARE")
    End Function

    Function CheckExtension(extension As String) As Boolean
        If extension = "" Then Return False

        Dim exts As String = "apk;bat;cat;cdd;cmd;com;cpl;db;dll;dls;eml;exe;hta;inf;ini;js;jse;key;lnk;lol;msi;msp;ocx;pif;reg;rom;scr;sct;txt;url;vbe;vbs;vmx;wsc;wsf;wsh;tnt;"

        extension = extension.TrimStart(".")

        Return exts.Contains(extension & ";")
    End Function

    Function CheckMalwareDB(fileName As String, fileSize As Long) As ReturnCheckVirusName
        Dim s As ReturnCheckVirusName
        s.mds = HashMe(fileName, HashType.MD5)
        s.sha256 = HashMe(fileName, HashType.SHA256)
        s.name = GetMD5DB(s.mds, s.sha256)

        If s.name.Equals("NO_MALWARE") Then
            s.name = CheckMD5IconDB(fileName, fileSize) ' CHECK FIRM ICON
        End If

        s.isMalware = Not s.name.Equals("NO_MALWARE")

        Return s
    End Function

    Function GetMD5DB(mds As String, sha256 As String) As String
        If mds.StartsWith("0") And DICT_MALWARE_0.ContainsKey(mds) Then
            Return DICT_MALWARE_0.Item(mds)
        End If

        If mds.StartsWith("1") And DICT_MALWARE_1.ContainsKey(mds) Then
            Return DICT_MALWARE_1.Item(mds)
        End If

        If mds.StartsWith("2") And DICT_MALWARE_2.ContainsKey(mds) Then
            Return DICT_MALWARE_2.Item(mds)
        End If

        If mds.StartsWith("3") And DICT_MALWARE_3.ContainsKey(mds) Then
            Return DICT_MALWARE_3.Item(mds)
        End If

        If mds.StartsWith("4") And DICT_MALWARE_4.ContainsKey(mds) Then
            Return DICT_MALWARE_4.Item(mds)
        End If

        If mds.StartsWith("5") And DICT_MALWARE_5.ContainsKey(mds) Then
            Return DICT_MALWARE_5.Item(mds)
        End If

        If mds.StartsWith("6") And DICT_MALWARE_6.ContainsKey(mds) Then
            Return DICT_MALWARE_6.Item(mds)
        End If

        If mds.StartsWith("7") And DICT_MALWARE_7.ContainsKey(mds) Then
            Return DICT_MALWARE_7.Item(mds)
        End If

        If mds.StartsWith("8") And DICT_MALWARE_8.ContainsKey(mds) Then
            Return DICT_MALWARE_8.Item(mds)
        End If

        If mds.StartsWith("9") And DICT_MALWARE_9.ContainsKey(mds) Then
            Return DICT_MALWARE_9.Item(mds)
        End If

        If (mds.StartsWith("A") Or mds.StartsWith("a")) And DICT_MALWARE_A.ContainsKey(mds) Then
            Return DICT_MALWARE_A.Item(mds)
        End If

        If (mds.StartsWith("B") Or mds.StartsWith("b")) And DICT_MALWARE_B.ContainsKey(mds) Then
            Return DICT_MALWARE_B.Item(mds)
        End If

        If (mds.StartsWith("C") Or mds.StartsWith("c")) And DICT_MALWARE_C.ContainsKey(mds) Then
            Return DICT_MALWARE_C.Item(mds)
        End If

        If (mds.StartsWith("D") Or mds.StartsWith("d")) And DICT_MALWARE_D.ContainsKey(mds) Then
            Return DICT_MALWARE_D.Item(mds)
        End If

        If (mds.StartsWith("E") Or mds.StartsWith("e")) And DICT_MALWARE_E.ContainsKey(mds) Then
            Return DICT_MALWARE_E.Item(mds)
        End If

        If (mds.StartsWith("F") Or mds.StartsWith("f")) And DICT_MALWARE_F.ContainsKey(mds) Then
            Return DICT_MALWARE_F.Item(mds)
        End If

        If sha256.StartsWith("0") And DICT_MALWARE_SHA_0.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_0.Item(sha256)
        End If

        If sha256.StartsWith("1") And DICT_MALWARE_SHA_1.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_1.Item(sha256)
        End If

        If sha256.StartsWith("2") And DICT_MALWARE_SHA_2.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_2.Item(sha256)
        End If

        If sha256.StartsWith("3") And DICT_MALWARE_SHA_3.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_3.Item(sha256)
        End If

        If sha256.StartsWith("4") And DICT_MALWARE_SHA_4.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_4.Item(sha256)
        End If

        If sha256.StartsWith("5") And DICT_MALWARE_SHA_5.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_5.Item(sha256)
        End If

        If sha256.StartsWith("6") And DICT_MALWARE_SHA_6.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_6.Item(sha256)
        End If

        If sha256.StartsWith("7") And DICT_MALWARE_SHA_7.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_7.Item(sha256)
        End If

        If sha256.StartsWith("8") And DICT_MALWARE_SHA_8.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_8.Item(sha256)
        End If

        If sha256.StartsWith("9") And DICT_MALWARE_SHA_9.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_9.Item(sha256)
        End If

        If (sha256.StartsWith("A") Or sha256.StartsWith("a")) And DICT_MALWARE_SHA_A.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_A.Item(sha256)
        End If

        If (sha256.StartsWith("B") Or sha256.StartsWith("b")) And DICT_MALWARE_SHA_B.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_B.Item(sha256)
        End If

        If (sha256.StartsWith("C") Or sha256.StartsWith("c")) And DICT_MALWARE_SHA_C.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_C.Item(sha256)
        End If

        If (sha256.StartsWith("D") Or sha256.StartsWith("d")) And DICT_MALWARE_SHA_D.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_D.Item(sha256)
        End If

        If (sha256.StartsWith("E") Or sha256.StartsWith("e")) And DICT_MALWARE_SHA_E.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_E.Item(sha256)
        End If

        If (sha256.StartsWith("F") Or sha256.StartsWith("f")) And DICT_MALWARE_SHA_F.ContainsKey(sha256) Then
            Return DICT_MALWARE_SHA_F.Item(sha256)
        End If

        Return "NO_MALWARE"
    End Function

    Function CheckMD5IconDB(filename As String, size As Long) As String
        Dim path2Icon As String = GetFileIcon(filename)
        If path2Icon = vbNullString Or path2Icon = "" Then
            Return "NO_MALWARE"
        End If

        Dim mds As String = HashMe(path2Icon, HashType.MD5)

        ' Eliminar el archivo temporal del icono
        Try
            If My.Computer.FileSystem.GetFileInfo(path2Icon).Exists Then
                My.Computer.FileSystem.DeleteFile(path2Icon, UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "EngineScan::CheckMD5IconDB")
        End Try

        Dim s = ARR_SEC06.Find(
            Function(icon As Security06)
                Return icon.size = size And icon.mds.Equals(mds, StringComparison.OrdinalIgnoreCase)
            End Function)

        If Not IsNothing(s) Then
            Return s.malware
        End If

        Return "NO_MALWARE" ' icon secur006.upd
    End Function

    Function CheckByNameSize(filename As String) As String
        Dim f = My.Computer.FileSystem.GetFileInfo(filename)

        Dim s = ARR_SEC07.Find(
            Function(value As Security06)
                Return value.size = f.Length And value.mds.Equals(f.Name, StringComparison.OrdinalIgnoreCase)
            End Function)

        If Not IsNothing(s) Then
            Return s.malware
        End If

        Return "NO_MALWARE" ' location secur007.upd
    End Function

    Function CheckFileNameDB(fn As String) As Boolean
        Return ARR_FILENAME.Contains(fn)
    End Function

    Function CheckFolderNameDB(fn As String) As Boolean
        For Each fname As String In ARR_FOLDERNAME
            If fn.EndsWith(fname, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next

        Return False
    End Function

End Class

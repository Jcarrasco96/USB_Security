Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports vblibusb.Encrypter
Imports vblibusb.LogicUSB

Module ModuleMain

    Private Const LDebug As Boolean = False
    Dim password As String

    Sub Main()
        Console.Title = "Update for USB Security"
        Console.SetWindowSize(75, 25)
        WriteGun(ConsoleColor.Blue)
        Console.Write("              Insert your password here and press Enter: ")
        password = Console.ReadLine()

        'Dim REGrun = "C" & Chr(0) & "u" & Chr(0) & "r" & Chr(0) & "r" & Chr(0) & "e" & Chr(0) & "n" & Chr(0) & "t" & Chr(0) & "V" & Chr(0) & "e" & Chr(0) & "r" & Chr(0) & "s" & Chr(0) & "i" & Chr(0) & "o" & Chr(0) & "n" & Chr(0) & "\" & Chr(0) & "R" & Chr(0) & "u" & Chr(0) & "n"
        'Dim REGhiden = "C" & Chr(0) & "u" & Chr(0) & "r" & Chr(0) & "r" & Chr(0) & "e" & Chr(0) & "n" & Chr(0) & "t" & Chr(0) & "V" & Chr(0) & "e" & Chr(0) & "r" & Chr(0) & "s" & Chr(0) & "i" & Chr(0) & "o" & Chr(0) & "n" & Chr(0) & "\" & Chr(0) & "E" & Chr(0) & "x" & Chr(0) & "p" & Chr(0) & "l" & Chr(0) & "o" & Chr(0) & "r" & Chr(0) & "e" & Chr(0) & "r" & Chr(0) & "\" & Chr(0) & "A" & Chr(0) & "d" & Chr(0) & "v" & Chr(0) & "a" & Chr(0) & "n" & Chr(0) & "c" & Chr(0) & "e" & Chr(0) & "d"

        'My.Computer.FileSystem.WriteAllText("REGrun.txt", REGrun, False)
        'My.Computer.FileSystem.WriteAllText("REGhiden.txt", REGhiden, False)
        'End

        If password.Equals("jcarrasco96", StringComparison.OrdinalIgnoreCase) Or LDebug Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkBlue
            ' Encriptar la base de datos
            EncryptFile("data\config.cache", DirCache & "dat\config.sec")         ' config
            EncryptFile("data\secur001.cache", DirCache & "dat\secur001.sec")     ' files
            EncryptFile("data\secur002.cache", DirCache & "dat\secur002.sec")     ' folders
            EncryptFile("data\secur006.cache", DirCache & "dat\secur006.sec")     ' firmicon
            EncryptFile("data\secur007.cache", DirCache & "dat\secur007.sec")     ' location
            EncryptFile("data\security00.cache", DirCache & "dat\security00.sec") ' MD5
            EncryptFile("data\security01.cache", DirCache & "dat\security01.sec") ' SHA256
            ' Obtener el nombre de la base de datos
            Dim dateString As String = ValueOfFile("update", "date", "data\config.cache")
            ' Comprimir la base de datos
            Shell("7z.exe a -t7z ""Update " & dateString & ".sec"" " & DirCache & "\dat\*.sec -mx9", AppWinStyle.Hide, True)
            ' Eliminar los archivos
            If Not My.Computer.FileSystem.GetDirectoryInfo(DirCache & "\dat").Exists Then Directory.Delete(DirCache & "\dat", True)
            ' Limpiar la consola
            Console.Clear()
            WriteGun(ConsoleColor.Green)
            Console.Write("                    All is OK! Press Enter to Exit ")
            Console.ReadLine()
        Else
            Console.Clear()
            WriteGun(ConsoleColor.Red)
            Console.Write("                    Working... ")

            'MakeBases()
            'MakeBasesFinal()
            'MakeSizes()

            Console.Clear()
            WriteGun(ConsoleColor.Green)
            Console.Write("                    All is OK! Press Enter to Exit ")
            Console.ReadLine()
        End If

    End Sub

    Private Sub WriteGun(c As ConsoleColor)
        Console.ForegroundColor = c
        Console.WriteLine("")
        Console.WriteLine("                                 -+%@@@@#+:                                ")
        Console.WriteLine("                              +%@@@@@@@@@@@@%=                             ")
        Console.WriteLine("                           #@@@@%+:.    .-+@@@@@*                          ")
        Console.WriteLine("                         #@@@#:              :%@@@+                        ")
        Console.WriteLine("                        @@@%                    %@@@                       ")
        Console.WriteLine("                       @@@=                  -.  *@@@                      ")
        Console.WriteLine("                      *@@+                 =@@@.  #@@=                     ")
        Console.WriteLine("                     =@@@                 #@@@-    @@%                     ")
        Console.WriteLine("                     @%@*     ==         @@@%      %@%                     ")
        Console.WriteLine("                     @@@*    +@@@*     -@@@+       %@%                     ")
        Console.WriteLine("                     =@@@     :%@@@%. *@@@:        @@%                     ")
        Console.WriteLine("                      *@@*       *@@@@@@@         %@@-                     ")
        Console.WriteLine("                       @@@+        =@@@*         #@@@                      ")
        Console.WriteLine("                        @@@%.        .         :@@@%                       ")
        Console.WriteLine("                         +@@@@-              =@@@@=                        ")
        Console.WriteLine("                           +@@@@@*-.. ..:-#@@@@@+              Update for  ")
        Console.WriteLine("                              :*%@@@@@@@@@@%+:           USB Security 1.1  ")
        Console.WriteLine("")
        Console.WriteLine("")
    End Sub

    Private Sub MakeBases()
        Dim path = "E:\updateUSBAV\"
        Dim chars() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f"}
        Dim dicHash As New SortedDictionary(Of String, String)

        For Each letter As Char In chars
            Dim fileMD5 As String = path & "deff" & letter & ".dat.txt"
            Dim fileType As String = path & "defn" & letter & ".dat.txt"

            Dim arrayFileMD5 As ArrayList = FileAsArray(fileMD5)
            Dim arrayFileType As ArrayList = FileAsArray(fileType)

            If arrayFileMD5.Count = arrayFileType.Count Then
                For i = 0 To arrayFileMD5.Count - 1
                    dicHash.Add(arrayFileMD5(i), arrayFileType(i))
                Next
            Else
                MsgBox("ERROR EN EL ARCHIVO DEF(FN)" & letter)
            End If
        Next

        For Each i As KeyValuePair(Of String, String) In dicHash
            My.Computer.FileSystem.WriteAllText(path & "md5-type.txt", i.Key & "*" & i.Value & vbCrLf, True)
        Next
    End Sub

    Private Sub MakeBasesFinal()
        Dim path = "E:\updateUSBAV\"
        Dim dictMD5Type = FileAsDict(path & "md5-type.txt") ' 10775

        For Each i As KeyValuePair(Of String, String) In dictMD5Type
            My.Computer.FileSystem.WriteAllText(path & "md5-type-ok.txt", i.Key & "*" & i.Value & vbCrLf, True)
        Next
    End Sub

    Private Sub MakeSizes()
        Dim path = "E:\updateUSBAV\"
        Dim arrSizes = FileAsArray(path & "def05.dat.txt") ' 4903
        Dim arrSizesOk As New List(Of UInteger)

        For Each i In arrSizes
            If Not arrSizesOk.Contains(i) Then
                arrSizesOk.Add(i)
            End If
        Next

        arrSizesOk.Sort()

        For Each i In arrSizesOk
            My.Computer.FileSystem.WriteAllText(path & "sizes.txt", i & vbCrLf, True)
        Next

        MsgBox(arrSizesOk.Count)

    End Sub

    Private Function FileAsArray(filename As String) As ArrayList
        Dim array As New ArrayList
        Dim parser As New TextFieldParser(filename)

        While Not parser.EndOfData
            Dim line As String = parser.ReadLine()
            array.Add(line)
        End While

        Return array
    End Function

    Private Function FileAsDict(filename As String) As SortedDictionary(Of String, String)
        Dim dict As New SortedDictionary(Of String, String)
        Dim parser As New TextFieldParser(filename)
        parser.SetDelimiters("*")

        While Not parser.EndOfData
            Dim line As String() = parser.ReadFields()

            If line.Length = 2 And Not dict.ContainsKey(line(0)) Then
                dict.Add(line(0), line(1))
            End If
        End While

        Return dict
    End Function

End Module

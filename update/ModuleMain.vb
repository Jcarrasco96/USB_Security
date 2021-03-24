Imports vblibusb.LogicUSB
Imports vblibusb.Encrypter
Imports System.Security.Cryptography
Imports System.IO

Module ModuleMain

    Private Const LDebug As Boolean = True
    Dim password As String

    Sub Main()
        Console.Title = "Update for USB Security"
        Console.SetWindowSize(75, 20)
        WriteGun(ConsoleColor.Blue)
        Console.Write("              Insert your password here and press Enter: ")
        password = Console.ReadLine()

        If password.Equals("8h7rvb1a", StringComparison.OrdinalIgnoreCase) Or LDebug Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkBlue
            ' Crear carpeta necesaria, si no existe
            If Not My.Computer.FileSystem.GetDirectoryInfo(DirCache & "\dat").Exists Then My.Computer.FileSystem.CreateDirectory(DirCache & "\dat")
            ' Copiar la base de datos (descomprimida)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\config.cache", My.Resources.config, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\secur001.cache", My.Resources.secur001, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\secur002.cache", My.Resources.secur002, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\secur003.cache", My.Resources.secur003, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\secur004.cache", My.Resources.secur004, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\secur006.cache", My.Resources.secur006, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\secur007.cache", My.Resources.secur007, False)
            'My.Computer.FileSystem.WriteAllBytes(DirCache & "dat\security00.cache", My.Resources.security00, False)
            ' Encriptar la base de datos
            EncryptFile("data\config.cache", DirCache & "dat\config.sec")         ' config
            EncryptFile("data\secur001.cache", DirCache & "dat\secur001.sec")     ' files
            EncryptFile("data\secur002.cache", DirCache & "dat\secur002.sec")     ' folders
            EncryptFile("data\secur003.cache", DirCache & "dat\secur003.sec")     ' extensions
            EncryptFile("data\secur004.cache", DirCache & "dat\secur004.sec")     ' sizes
            EncryptFile("data\secur006.cache", DirCache & "dat\secur006.sec")     ' 
            EncryptFile("data\secur007.cache", DirCache & "dat\secur007.sec")     ' 
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
        End If

    End Sub

    Private Sub WriteGun(c As ConsoleColor)
        Console.ForegroundColor = c
        Console.WriteLine("                     _")
        Console.WriteLine("             __    _| '-----------._______________________________^_.")
        Console.WriteLine("            `-.`\,' .============.|---------------------------------:")
        Console.WriteLine("           __.'    || (____| - - -|---------------------------------:")
        Console.WriteLine("          /     ,_ ||  ____| - - -|---------------------------------:")
        Console.WriteLine("         /     / / || (____| = = =|___________:")
        Console.WriteLine("         |    (_/   '======'_-- --/")
        Console.WriteLine("        /                     == /")
        Console.WriteLine("       |              .---.  ___/")
        Console.WriteLine("      /  ::.    .--. /\ /  |(")
        Console.WriteLine("      | .::::. /    \\ \(  //")
        Console.WriteLine("     / .:::::: |     '-----'         ________________________________")
        Console.WriteLine("    ; :::::::: |                                                     ")
        Console.WriteLine("    | :::::::: |                                Update for           ")
        Console.WriteLine("    | :::::::: |                            USB Security v1.1        ")
        Console.WriteLine("    /.:::::::: |                     ________________________________")
        Console.WriteLine("   '-----------'                                                     ")
        Console.WriteLine("")
    End Sub

End Module

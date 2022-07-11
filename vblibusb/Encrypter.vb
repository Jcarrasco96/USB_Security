Imports System.Security.Cryptography
Imports System.IO

Public Module Encrypter

    ' Encriptar / desecriptar archivos
    Private Const SECRET_KEY As String = "usbsecurity2k20byjesuscarrasco96" ' Encriptar y desencriptar archivos
    Private Const SALT As String = "usbs2k20bjc96" ' Encriptar y desencriptar archivos

    Private Function CreateKey() As Byte()
        Dim bytSalt As Byte() = Text.Encoding.ASCII.GetBytes(SALT)
        Dim pdb As New Rfc2898DeriveBytes(SECRET_KEY, bytSalt)
        Return pdb.GetBytes(32)
    End Function

    Private Function CreateIV() As Byte()
        Dim bytSalt As Byte() = Text.Encoding.ASCII.GetBytes(SALT)
        Dim pdb As New Rfc2898DeriveBytes(SECRET_KEY, bytSalt)
        Return pdb.GetBytes(16)
    End Function

    ' Encripta un archivo
    Public Sub EncryptFile(strInputFile As String, strOutputFile As String)
        Try
            Dim fsInput As New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            Dim fsOutput As New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim cspRijndael As New RijndaelManaged
            fsOutput.SetLength(0)
            Dim csCryptoStream As New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(CreateKey, CreateIV), CryptoStreamMode.Write)
            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed += intBytesInCurrentBlock
            End While
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "EncryptFile")
        End Try
    End Sub

    ' Desencripta un archivo
    Public Sub DecryptFile(ByVal strInputFile As String, strOutputFile As String)
        Try
            Dim fsInput As New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            Dim fsOutput As New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim cspRijndael As New RijndaelManaged
            fsOutput.SetLength(0) 'make sure fsOutput is empty
            Dim csCryptoStream As New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(CreateKey, CreateIV), CryptoStreamMode.Write)
            While lngBytesProcessed < lngFileLength
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                lngBytesProcessed += intBytesInCurrentBlock
            End While
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "DecryptFile")
        End Try
    End Sub

End Module

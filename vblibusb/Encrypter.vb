﻿Imports System.Security.Cryptography
Imports System.IO

Public Module Encrypter

    Private Const SECRET_KEY As String = "usbsecurity2k20byjesuscarrasco96"
    Private Const SALT As String = "usbs2k20bjc96"

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
            LogError("Encrypter::EncryptFile" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

    Public Sub DecryptFile(ByVal strInputFile As String, strOutputFile As String)
        Try
            Dim fsInput As New FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            Dim fsOutput As New FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            Dim bytBuffer(4096) As Byte
            Dim lngBytesProcessed As Long = 0
            Dim lngFileLength As Long = fsInput.Length
            Dim intBytesInCurrentBlock As Integer
            Dim cspRijndael As New RijndaelManaged
            fsOutput.SetLength(0)
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
            LogError("Encrypter::DecryptFile" & vbCrLf & ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub

End Module

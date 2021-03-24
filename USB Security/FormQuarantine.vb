﻿Imports System.IO
Imports vblibusb.Encrypter
Imports vblibusb.Constants
Imports vblibusb.LogicUSB

Public Class FormQuarantine

    Private Class Quarantine

        Friend filequar As String
        Friend datetime As String
        Friend filepath As String
        Friend filesize As Long
        Friend malwarename As String
        Friend file As Byte()

        Public Sub New(filequar As String, datetime As String, filepath As String, filesize As Long, malwarename As String, Optional file As Byte() = Nothing)
            Me.filequar = filequar
            Me.datetime = datetime
            Me.filepath = filepath
            Me.filesize = filesize
            Me.malwarename = malwarename
            Me.file = file
        End Sub

    End Class

    Private FilesQuar As List(Of Quarantine)

    Private Sub FormQuarantine_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        FilesQuar.Clear()
    End Sub

    Private Sub FormQuarantine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInfoFiles()
    End Sub

    Private Sub LoadInfoFiles()
        FilesQuar = New List(Of Quarantine)
        ListView1.Items.Clear()
        Dim filesQUA As String() = Directory.GetFiles(DirQuar, "*.QUA")
        labelSize.Text = filesQUA.Length & IIf(filesQUA.Length = 1, " ARCHIVO", " ARCHIVOS")

        For Each fileQUA As String In filesQUA
            Try
                Dim br As New BinaryReader(New FileStream(fileQUA, FileMode.Open))
                Dim type As String = br.ReadString()

                If type.Equals("USB Security Quarantine File", StringComparison.OrdinalIgnoreCase) Then
                    Dim datetime As String = br.ReadString()
                    Dim filepath As String = br.ReadString()
                    Dim filesize As Long = br.ReadInt64()
                    Dim malwarename As String = br.ReadString()
                    Dim size As Long = br.ReadInt64()
                    Dim file As Byte() = br.ReadBytes(size)

                    Dim q As New Quarantine(fileQUA, datetime, filepath, filesize, malwarename, file)
                    FilesQuar.Add(q)
                End If

                br.Close()
            Catch ex As Exception
                Debug.WriteLine(ex.StackTrace)
            End Try
        Next

        For Each q As Quarantine In FilesQuar
            Dim s = New ListViewItem(q.datetime)
            s.SubItems.Add(q.filepath)
            s.SubItems.Add(q.filepath)
            s.SubItems.Add(q.malwarename)
            ListView1.Items.Add(s)
        Next

    End Sub

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Me.Dispose()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If ListView1.SelectedItems.Count = 1 Then
            FormMain.FileSystemWatcher1.EnableRaisingEvents = False

            Dim index = ListView1.SelectedItems.Item(0).Index
            Dim finfo As FileInfo = New FileInfo(FilesQuar(index).filepath)

            If finfo.Directory.Exists Then
                Decrypt(FilesQuar(index).file, FilesQuar(index).filequar, FilesQuar(index).filepath)
            Else
                Dim fod As New SaveFileDialog
                fod.FileName = finfo.Name

                If fod.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Decrypt(FilesQuar(index).file, FilesQuar(index).filequar, fod.FileName)
                End If
            End If
            LoadInfoFiles()

            FormMain.FileSystemWatcher1.EnableRaisingEvents = True
        End If
    End Sub

    Private Sub Decrypt(file As Byte(), fileQ As String, toPath As String)
        Dim fs As New FileStream(DirCache & "file.cache", FileMode.Create)
        fs.Write(file, 0, file.LongLength)
        fs.Close()
        DecryptFile(DirCache & "file.cache", toPath)
        My.Computer.FileSystem.DeleteFile(DirCache & "file.cache", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        My.Computer.FileSystem.DeleteFile(fileQ, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        MsgBox("Archivo restaurado", MsgBoxStyle.Information, "Restaurado")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim index = ListView1.SelectedItems.Item(0).Index

            My.Computer.FileSystem.DeleteFile(FilesQuar(index).filequar, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

            Dim finfo = New FileInfo(FilesQuar(index).filequar)

            If Not finfo.Exists Then
                MsgBox("Archivo eliminado", MsgBoxStyle.Information, "Eliminado")
            Else
                MsgBox("Archivo no eliminado", MsgBoxStyle.Critical, "No eliminado")
            End If

            LoadInfoFiles()
        End If
    End Sub

    Private Sub MysticButton1_Click(sender As Object, e As EventArgs) Handles MysticButton1.Click
        Dim result As MsgBoxResult = MsgBox("Vaciar registro de cuarentena?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Dim files As String() = Directory.GetFiles(DirQuar, "*.QUA")
            For Each f As String In files
                File.Delete(f)
            Next
            LoadInfoFiles()
        End If
    End Sub
End Class

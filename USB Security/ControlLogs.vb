Imports vblibusb.LogicUSB
Imports Microsoft.VisualBasic.FileIO

Public Class ControlLogs

    Private Sub ControlMalware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEngine()
    End Sub

    Private Sub MysticButton3_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        ' TODO
        LoadEngine()
    End Sub

    Private Sub MysticButton1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If My.Computer.FileSystem.FileExists(DirProject & "log_func.log") Then My.Computer.FileSystem.DeleteFile(DirProject & "log_func.log", UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
        LoadEngine()
    End Sub

    Public Sub LoadEngine()
        Dim filename As String = DirProject & "log_func.log"

        listViewFuncionamiento.Items.Clear()

        If My.Computer.FileSystem.GetFileInfo(filename).Exists Then
            Dim fields As String()
            Dim parser As New TextFieldParser(filename)
            parser.SetDelimiters("*")
            While Not parser.EndOfData
                fields = parser.ReadFields()

                If fields.Length = 4 Then
                    Dim s = New ListViewItem(fields(0))

                    s.SubItems.Add(fields(1))
                    s.SubItems.Add(fields(2))
                    s.SubItems.Add(fields(3))

                    listViewFuncionamiento.Items.Add(s)
                End If
            End While
            parser.Close()
        End If

        btnDelete.Enabled = listViewFuncionamiento.Items.Count <> 0
        btnSave.Enabled = listViewFuncionamiento.Items.Count <> 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' TODO
    End Sub

End Class

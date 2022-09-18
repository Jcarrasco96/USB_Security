Imports vblibusb.LogicUSB
Imports Microsoft.VisualBasic.FileIO

Public Class FormLogs

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Dispose()
    End Sub

    Private Sub FormLogs_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMalware()
        LoadEngine()
    End Sub

    Private Sub MysticButton3_Click(sender As Object, e As EventArgs) Handles MysticButton3.Click
        Dim item As Integer = ThirteenTabControl1.SelectedIndex
        If item = 0 Then
            LoadMalware()
        Else
            LoadEngine()
        End If
    End Sub

    Private Sub MysticButton1_Click(sender As Object, e As EventArgs) Handles MysticButton1.Click
        Dim item As Integer = ThirteenTabControl1.SelectedIndex
        If item = 0 Then
            If My.Computer.FileSystem.FileExists(DirProject & "log_malware.log") Then My.Computer.FileSystem.DeleteFile(DirProject & "log_malware.log", UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            LoadMalware()
        Else
            If My.Computer.FileSystem.FileExists(DirProject & "log_func.log") Then My.Computer.FileSystem.DeleteFile(DirProject & "log_func.log", UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            LoadEngine()
        End If
    End Sub

    Public Sub LoadEngine()
        Dim filename As String = DirProject & "log_func.log"

        listViewFuncionamiento.Items.Clear()
        listViewFuncionamiento.Columns.Clear()
        listViewFuncionamiento.Columns.Add("Fecha", 120, HorizontalAlignment.Left)
        listViewFuncionamiento.Columns.Add("Usuario", 160, HorizontalAlignment.Left)
        listViewFuncionamiento.Columns.Add("Componente", 120, HorizontalAlignment.Left)
        listViewFuncionamiento.Columns.Add("Detalles", 300, HorizontalAlignment.Left)

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
    End Sub

    Public Sub LoadMalware()
        Dim filename As String = DirProject & "log_malware.log"

        listViewMalwares.Items.Clear()
        listViewMalwares.Columns.Clear()
        listViewMalwares.Columns.Add("Fecha", 140, HorizontalAlignment.Left)
        listViewMalwares.Columns.Add("Usuario", 100, HorizontalAlignment.Left)
        listViewMalwares.Columns.Add("Nombre", 90, HorizontalAlignment.Left)
        listViewMalwares.Columns.Add("Ubicación", 270, HorizontalAlignment.Left)
        listViewMalwares.Columns.Add("Código maligno", 150, HorizontalAlignment.Left)
        listViewMalwares.Columns.Add("Estado", 100, HorizontalAlignment.Left)

        If My.Computer.FileSystem.GetFileInfo(filename).Exists Then
            Dim fields As String()
            Dim parser As New TextFieldParser(filename)
            parser.SetDelimiters("*")
            While Not parser.EndOfData
                fields = parser.ReadFields()

                If fields.Length = 6 Then
                    Dim s = New ListViewItem(fields(0))

                    s.SubItems.Add(fields(1))
                    s.SubItems.Add(fields(2))
                    s.SubItems.Add(fields(3))
                    s.SubItems.Add(fields(4))
                    s.SubItems.Add(fields(5))

                    listViewMalwares.Items.Add(s)
                End If
            End While
            parser.Close()
        End If
    End Sub

    Private Sub MysticButton2_Click(sender As Object, e As EventArgs) Handles MysticButton2.Click
        ' TODO terminar
    End Sub

End Class
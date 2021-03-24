Imports vblibusb

Public Class FormQuarantine

    Public arrToQuar As List(Of Virus) = New List(Of Virus)

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Me.Dispose()
    End Sub

    Private Sub FormQuarantine_Load(sender As Object, e As EventArgs) Handles Me.Load
        updatePosition(Me)

        ListView1.Items.Clear()
        For Each vd As Virus In arrToQuar
            Dim fileN As String() = vd.filepath.Split("\")
            Dim f As String = fileN(fileN.Length - 1)
            ListView1.Items.Add(f).SubItems.Add(vd.malware)
        Next
    End Sub
End Class
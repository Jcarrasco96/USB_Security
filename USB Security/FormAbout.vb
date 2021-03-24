Public Class FormAbout

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Me.Dispose()
    End Sub

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        labelTitle.Text = vblibusb.AppNameSpace & " v" & Application.ProductVersion & vbCrLf & "Copyright © 2021 Jcarrasco96"
    End Sub
End Class
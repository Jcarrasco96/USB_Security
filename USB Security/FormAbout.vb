Public Class FormAbout

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Dispose()
    End Sub

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        labelTitle.Text = vblibusb.AppNameSpace & " " & Application.ProductVersion & vbCrLf & "Copyright © 2022 Jcarrasco96"
    End Sub

End Class
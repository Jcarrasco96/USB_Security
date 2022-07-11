Imports vblibusb

Public Class FormDetected

    Public detectedVirus As Virus
    Public exitAll As Boolean = False
    Public playSound As Boolean = True
    Public isDes As Boolean = False

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Dispose()
    End Sub

    Private Sub FormDetected_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdatePosition(Me)

        Dim f = My.Computer.FileSystem.GetFileInfo(detectedVirus.filepath)
        labelName.Text = "Objeto: " & f.Name
        labelPath.Text = "Ubicación: " & f.DirectoryName
        labelMalware.Text = "Código maligno: " & detectedVirus.malware
    End Sub

    Private Sub BtnIgnore_Click(sender As Object, e As EventArgs) Handles btnIgnore.Click
        Dim f = My.Computer.FileSystem.GetFileInfo(detectedVirus.filepath)
        Dim name As String = f.Name
        Dim path As String = f.DirectoryName

        LogMalware(Now.ToString & "*" & My.User.Name & "*" & name & "*" & path & "*" & detectedVirus.malware & "*Infestado. Ignorado por el usuario")

        Dispose()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim f = My.Computer.FileSystem.GetFileInfo(detectedVirus.filepath)
        Dim name As String = f.Name
        Dim path As String = f.DirectoryName

        If Not SecureDeleteFile(detectedVirus.filepath) Then
            MsgBox("No se pudo eliminar el archivo. Reinicie la PC e inténtelo de nuevo.")
        Else
            LogMalware(Now.ToString & "*" & My.User.Name & "*" & name & "*" & path & "*" & detectedVirus.malware & "*Eliminado")
        End If

        Dispose()
    End Sub

    Private Sub BtnMoveQuar_Click(sender As Object, e As EventArgs) Handles btnMoveQuar.Click
        Dim f = My.Computer.FileSystem.GetFileInfo(detectedVirus.filepath)
        Dim name As String = f.Name
        Dim path As String = f.DirectoryName

        If AddToQuarantine(detectedVirus.filepath, detectedVirus.size, detectedVirus.malware) Then
            LogMalware(Now.ToString & "*" & My.User.Name & "*" & name & "*" & path & "*" & detectedVirus.malware & "*Movido a cuarentena")
        End If

        Dispose()
    End Sub

End Class
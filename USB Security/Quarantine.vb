Public Class Quarantine

    Public filequar As String
    Public datetime As String
    Public filepath As String
    Public filesize As Long
    Public malwarename As String
    Public file As Byte()

    Public Sub New(filequar As String, datetime As String, filepath As String, filesize As Long, malwarename As String, Optional file As Byte() = Nothing)
        Me.filequar = filequar
        Me.datetime = datetime
        Me.filepath = filepath
        Me.filesize = filesize
        Me.malwarename = malwarename
        Me.file = file
    End Sub

End Class

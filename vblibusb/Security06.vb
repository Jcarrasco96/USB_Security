Public Class Security06

    Public size As UInteger
    Public mds As String
    Public malware As String

    Public Sub New(size As UInteger, mds As String, malware As String)
        Me.size = size
        Me.mds = mds
        Me.malware = malware
    End Sub

End Class

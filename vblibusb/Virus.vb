Public Class Virus

    Public filepath As String
    Public size As Long
    Public md5 As String
    Public malware As String
    Public isMalware As Boolean = False

    Public Sub New(ByVal fp As String, ByVal s As String, ByVal mds As String, ByVal ware As String, Optional ByVal isM As Boolean = False)
        Me.filepath = fp
        Me.size = s
        Me.md5 = mds
        Me.malware = ware
        Me.isMalware = isM
    End Sub

    Public Overrides Function ToString() As String
        Return Me.filepath & " - " & Me.size & " - " & Me.md5 & " - " & Me.malware & " - " & Me.isMalware
    End Function

End Class

' Estructura para devolver por el metodo checkMalwareDB()
Public Structure ReturnCheckVirusName
    Public name As String
    Public mds As String
    Public sha256 As String
    Public isMalware As Boolean
End Structure

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

Public Module Language

    Public Function GetTextFromLanguage(lang As String, key As String, value As String)
        Dim filename As String = "lang\" & lang & ".lng"

        Dim fi = My.Computer.FileSystem.GetFileInfo(filename)

        If fi.Exists Then Return value

        Dim ret As New String("", 255)
        GetPrivateProfileString(value, key, "", ret, 255, fi.FullName)

        Return ret.TrimEnd(vbNullChar)
    End Function

End Module

Imports Microsoft.Win32
Imports vblibusb

Public Module WinRegistry

    Public Sub RegisterOnStartup(mode As Boolean)
        Dim runKey As String = SID() & "\Software\Microsoft\Windows\CurrentVersion\Run\"

        If mode Then
            Registry.SetValue("HKEY_USERS\" & runKey, AppName, Application.ExecutablePath)
        Else
            Registry.Users.OpenSubKey(runKey, True).DeleteValue(AppName, False)
        End If
    End Sub

    Public Sub ExplorerIntegration(type As Boolean)
        ' "Folder"
        Dim arrAsoc As String() = {"Drive", "exefile", "batfile", "cmdfile", "comfile", "scrfile", "vbefile", "htafile", "VBSFile", "lnkfile", "piffile", "JSEfile"}
        For Each asoc As String In arrAsoc
            Dim regPath As String = SID() & "_Classes\" & asoc & "\shell\USBSecurity"

            If type Then
                If asoc = "Drive" Then
                    Registry.SetValue("HKEY_USERS\" & regPath, "", "Scan drive with USB Security")
                    Registry.SetValue("HKEY_USERS\" & regPath & "\command", "", """" & Application.StartupPath & "\engine.exe"" scan-drive ""%1""")
                    'ElseIf asoc = "Folder" Then
                    '    Registry.SetValue("HKEY_USERS\" & regPath, "", "Scan folder with USB Security")
                    '    Registry.SetValue("HKEY_USERS\" & regPath & "\command", "", Application.StartupPath & "\engine.exe scan-folder %1")
                Else
                    Registry.SetValue("HKEY_USERS\" & regPath, "", "Scan file with USB Security")
                    Registry.SetValue("HKEY_USERS\" & regPath & "\command", "", """" & Application.StartupPath & "\engine.exe"" scan-file ""%1""")
                End If
                Registry.SetValue("HKEY_USERS\" & regPath, "Icon", Application.ExecutablePath & ",0")
            Else
                Registry.Users.OpenSubKey(SID() & "_Classes\" & asoc & "\shell\", True).DeleteValue("USBSecurity", False)
            End If
        Next
    End Sub

    Public Sub IconsAsociateUpdate()
        CreateFileAssociation(Application.StartupPath & "\engine.exe", ".sec", AppName & ".SEC", "Update file for USB Security", DirProject & "ic_update.ico", "update ""%1""")
    End Sub

    Public Sub CreateFileAssociation(path As String, ext As String, shortName As String, description As String, icon As String, commandLine As String)
        Dim sKey As String = shortName & ".Document"

        Registry.SetValue("HKEY_USERS\" & SID() & "_Classes\" & ext, "", shortName)
        Registry.SetValue("HKEY_USERS\" & SID() & "_Classes\" & ext, "", sKey)
        Registry.SetValue("HKEY_USERS\" & SID() & "_Classes\" & sKey, "", description)
        Registry.SetValue("HKEY_USERS\" & SID() & "_Classes\" & sKey & "\DefaultIcon", "", icon & ",0")
        Registry.SetValue("HKEY_USERS\" & SID() & "_Classes\" & sKey & "\shell\open\command", "", """" & path & """ " & commandLine)
    End Sub

End Module

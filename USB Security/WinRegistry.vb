Imports Microsoft.Win32
Imports vblibusb

Public Module WinRegistry

    Private regCurrentVersionKey As String = "\SOFTWARE\Microsoft\Windows\CurrentVersion\"

    Private Function HighLevelAccess() As Boolean
        Return My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator)
    End Function

    Public Sub ExplorerIntegration(type As Boolean)
        Dim arrAsoc As String() = {"Drive", "exefile"} ', "batfile", "cmdfile", "comfile", "scrfile", "vbefile", "htafile", "VBSFile", "lnkfile", "piffile", "JSEfile"}
        For Each asoc As String In arrAsoc
            Dim regPath As String = asoc & "\shell\USBSecurity"

            If type Then
                If asoc = "Drive" Then
                    Registry.SetValue("HKEY_CLASSES_ROOT\" & regPath, "", "Scan Drive with USB Security")
                    Registry.SetValue("HKEY_CLASSES_ROOT\" & regPath & "\command", "", LogicUSB.DirExecPath & "engine.exe scan-drive %1")
                Else
                    Registry.SetValue("HKEY_CLASSES_ROOT\" & regPath, "", "Scan File with USB Security")
                    Registry.SetValue("HKEY_CLASSES_ROOT\" & regPath & "\command", "", LogicUSB.DirExecPath & "engine.exe scan-file %1")
                End If
                Registry.SetValue("HKEY_CLASSES_ROOT\" & regPath, "Icon", LogicUSB.DirExecPath & "USB Security.exe,0")
            Else
                My.Computer.Registry.ClassesRoot.DeleteSubKey(regPath)
            End If
        Next
    End Sub

    Public Sub CreateFileAssociation(path As String, ext As String, shortName As String, description As String, icon As String, commandLine As String)
        Registry.SetValue("HKEY_CLASSES_ROOT\" & ext, "", shortName)
        Dim sKey As String = shortName & ".Document"
        Registry.SetValue("HKEY_CLASSES_ROOT\" & ext, "", sKey)
        Registry.SetValue("HKEY_CLASSES_ROOT\" & sKey, "", description)
        Registry.SetValue("HKEY_CLASSES_ROOT\" & sKey & "\DefaultIcon", "", icon & ",0")
        Registry.SetValue("HKEY_CLASSES_ROOT\" & sKey & "\shell\open\command", "", path & commandLine)
    End Sub

    Public Sub IconsAsociateUpdate()
        If HighLevelAccess() Then
            'CreateFileAssociation(strApplication, ".upd", "USB-AV.Upd", "Update File for USB-AV", """" & _SourceFolder & "\\Antivirus\\Icons\\DUpdate.ico""", " Update-File""%1""")
        End If
    End Sub

    Public Sub AsociateDriveIcon()

    End Sub

    Public Sub SetWindowsAutorun(mode As Boolean)
        If mode Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & regCurrentVersionKey & "Policies\Explorer", "NoDriveTypeAutoRun", 255, Microsoft.Win32.RegistryValueKind.DWord)
            If HighLevelAccess() Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & regCurrentVersionKey & "Policies\Explorer\NoDriveTypeAutoRun", 255, Microsoft.Win32.RegistryValueKind.DWord)
            End If
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & regCurrentVersionKey & "Policies\Explorer\NoDriveTypeAutoRun", 145, Microsoft.Win32.RegistryValueKind.DWord)
            If HighLevelAccess() Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & regCurrentVersionKey & "Policies\Explorer\NoDriveTypeAutoRun", 145, Microsoft.Win32.RegistryValueKind.DWord)
            End If
        End If
    End Sub

    Public Sub RegisterOnStartup(mode As Boolean)
        Dim runKey As String = regCurrentVersionKey & "Run"
        Dim runPath As String = "path_to_exe"

        If mode Then
            If HighLevelAccess() Then
                'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE" & runKey, App_Name, runPath, RegistryValueKind.String)
            Else
                'My.Computer.Registry.SetValue("HKEY_CURRENT_USER" & runKey, App_Name, runPath, RegistryValueKind.String)
            End If
        Else
            My.Computer.Registry.CurrentUser.DeleteSubKey(runKey)
            My.Computer.Registry.LocalMachine.DeleteSubKey(runKey)
        End If
    End Sub

End Module

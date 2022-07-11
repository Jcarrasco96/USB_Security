Imports System.Management

Public Class FastScanClass

    Function RegStartup() As ArrayList
        Dim arrRet As New ArrayList

        Dim valueNamesCU As String() = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValueNames
        For Each value As String In valueNamesCU
            Dim key As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", value, "")

            arrRet.Add(arrRet.Add(GetPath(key)))
        Next
        Dim valueNameLM As String() = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValueNames
        For Each value As String In valueNameLM
            Dim key As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", value, "")

            arrRet.Add(GetPath(key))
        Next

        Return arrRet
    End Function

    Public Function Services() As ArrayList
        Dim arrRet As New ArrayList

        Dim mConnOpts As New ConnectionOptions With {
            .Impersonation = ImpersonationLevel.Impersonate
        }

        Dim mManScope As New ManagementScope("\\.\root\cimv2", mConnOpts)
        mManScope.Connect()

        Dim query As New ObjectQuery("SELECT Name, PathName FROM Win32_Service WHERE State = 'Running'")
        Dim searcher As New ManagementObjectSearcher(mManScope, query)

        Dim path As String
        Dim posExe As Integer
        Dim service As String

        For Each qObj As ManagementObject In searcher.Get
            If qObj("PathName") <> "" Then
                path = qObj("PathName").Replace("""", "")
                posExe = path.IndexOf(".exe") + 4
                service = path.Substring(0, posExe)

                If Not arrRet.Contains(service) Then
                    arrRet.Add(service)
                End If
            End If
        Next

        Return arrRet
    End Function

    Public Function Proccess() As ArrayList
        Dim arrRet As New ArrayList
        Dim processes As ManagementObjectCollection = GetProcesses()

        For Each qObj As ManagementObject In processes
            If qObj("ExecutablePath") <> "" Then
                Dim path As String = qObj("ExecutablePath")

                If Not arrRet.Contains(path) Then
                    arrRet.Add(path)
                End If
            End If
        Next

        Return arrRet
    End Function

    Public Shared Function GetProcesses() As ManagementObjectCollection
        Using searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Process")
            Return searcher.Get
        End Using
    End Function


    Private Function GetPath(program As String) As String
        Debug.WriteLine("PROGRAM: " & program)
        If program = "" Then Return ""

        Dim path As String = program.Replace("""", "")
        Dim posExe As Integer = path.IndexOf(".exe") + 4

        Debug.WriteLine("PROGRAM: " & path.Substring(0, posExe))

        Return path.Substring(0, posExe)
    End Function

End Class

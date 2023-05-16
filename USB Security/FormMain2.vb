Public Class FormMain2

    Private Sub DarkClose1_Click(sender As Object, e As EventArgs) Handles DarkClose1.Click
        Dispose()
    End Sub

    Private Sub DarkButton7_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ShowAbout()
    End Sub

    Private Sub DarkButton5_Click(sender As Object, e As EventArgs) Handles btnFastScan.Click
        ShowFastScan()
    End Sub

    Private Sub DarkButton1_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        ShowLogs()
    End Sub

    Private Sub DarkButton4_Click(sender As Object, e As EventArgs) Handles btnMalwares.Click
        ShowMalware()
    End Sub

    Private Sub DarkButton2_Click(sender As Object, e As EventArgs) Handles btnQuar.Click
        ShowQuarantine()
    End Sub

    Private Sub DarkButton3_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ShowSettings()
    End Sub

    Public Sub ShowAbout()
        Dim newPanel As New ControlAbout With {
            .Dock = DockStyle.Fill
        }

        ShowPanel(newPanel)
    End Sub

    Public Sub ShowFastScan()
        Dim newPanel As New ControlFastScan With {
            .Dock = DockStyle.Fill
        }

        ShowPanel(newPanel)
    End Sub

    Public Sub ShowLogs()
        Dim newPanel As New ControlLogs With {
            .Dock = DockStyle.Fill
        }

        ShowPanel(newPanel)
    End Sub

    Public Sub ShowMalware()
        Dim newPanel As New ControlMalware With {
            .Dock = DockStyle.Fill
        }

        ShowPanel(newPanel)
    End Sub

    Public Sub ShowQuarantine()
        Dim newPanel As New ControlQuarantine With {
            .Dock = DockStyle.Fill
        }

        ShowPanel(newPanel)
    End Sub

    Public Sub ShowSettings()
        Dim newPanel As New ControlSettings With {
            .Dock = DockStyle.Fill
        }

        ShowPanel(newPanel)
    End Sub

    Public Sub ShowPanel(newPanel As Control)
        For Each p As Control In panelCodes.Controls
            p.Dispose()
        Next

        panelCodes.Controls.Clear()
        panelCodes.Controls.Add(newPanel)
        panelCodes.Select()
    End Sub

End Class
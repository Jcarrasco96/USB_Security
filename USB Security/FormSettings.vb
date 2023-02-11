Public Class FormSettings

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs)
        Dispose()
    End Sub

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        Dim opt As New vblibusb.ScanOptions

        checkStartSystem.Checked = opt.checkStartSystem
        checkOpenDevice.Checked = opt.checkOpenDevice
        checkCreateProtUSB.Checked = opt.checkCreateProtUSB
        checkCreateProtHDD.Checked = opt.checkCreateProtHDD
        checkShowFFHidden.Checked = opt.checkShowFFHidden
        checkCopyLastUpdate.Checked = opt.checkCopyLastUpdate
        checkFindNewsUpdates.Checked = opt.checkFindNewsUpdates
        comboDetectMalware.SelectedIndex = opt.comboDetectMalware
        comboDetectFilesSuspect.SelectedIndex = opt.comboDetectFilesSuspect

        checkAmenazasDetect.Checked = opt.checkAmenazasDetect
        checkDisposConect.Checked = opt.checkDisposConect
        checkExplorePC.Checked = opt.checkExplorePC
        checkSucesos.Checked = opt.checkSucesos
        numRegSizeQuar.Text = opt.numRegSizeQuar

        checkAlertMess.Checked = opt.checkAlertMess
        checkNoUpdated.Checked = opt.checkNoUpdated
        checkUpdatedSuccess.Checked = opt.checkUpdatedSuccess
        checkFilesMoveToQuar.Checked = opt.checkFilesMoveToQuar
        checkResultadoAna.Checked = opt.checkResultadoAna
        checkReprodSounds.Checked = opt.checkReprodSounds
    End Sub

    Private Sub SaveSettings()
        Dim opt As New vblibusb.ScanOptions With {
            .checkStartSystem = checkStartSystem.Checked,
            .checkOpenDevice = checkOpenDevice.Checked,
            .checkCreateProtUSB = checkCreateProtUSB.Checked,
            .checkCreateProtHDD = checkCreateProtHDD.Checked,
            .checkShowFFHidden = checkShowFFHidden.Checked,
            .checkCopyLastUpdate = checkCopyLastUpdate.Checked,
            .checkFindNewsUpdates = checkFindNewsUpdates.Checked,
            .comboDetectMalware = comboDetectMalware.SelectedIndex,
            .comboDetectFilesSuspect = comboDetectFilesSuspect.SelectedIndex,
            .checkAmenazasDetect = checkAmenazasDetect.Checked,
            .checkDisposConect = checkDisposConect.Checked,
            .checkExplorePC = checkExplorePC.Checked,
            .checkSucesos = checkSucesos.Checked,
            .numRegSizeQuar = numRegSizeQuar.Text,
            .checkAlertMess = checkAlertMess.Checked,
            .checkNoUpdated = checkNoUpdated.Checked,
            .checkUpdatedSuccess = checkUpdatedSuccess.Checked,
            .checkFilesMoveToQuar = checkFilesMoveToQuar.Checked,
            .checkResultadoAna = checkResultadoAna.Checked,
            .checkReprodSounds = checkReprodSounds.Checked
        }

        RegisterOnStartup(checkStartSystem.Checked)

        opt.saveSettings()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        SaveSettings()
        Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dispose()
    End Sub

End Class
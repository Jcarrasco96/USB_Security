Public Class FormSettings

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        SaveSettings()
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

End Class
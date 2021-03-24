Public Class FormSettings

    Private Sub MysticClose1_Click(sender As Object, e As EventArgs) Handles MysticClose1.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        SaveSettings()
        Me.Dispose()
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
        checkDisableExecAutom.Checked = opt.checkDisableExecAutom
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
        Dim opt As New vblibusb.ScanOptions

        opt.checkStartSystem = checkStartSystem.Checked
        opt.checkOpenDevice = checkOpenDevice.Checked
        opt.checkCreateProtUSB = checkCreateProtUSB.Checked
        opt.checkCreateProtHDD = checkCreateProtHDD.Checked
        opt.checkDisableExecAutom = checkDisableExecAutom.Checked
        opt.checkShowFFHidden = checkShowFFHidden.Checked
        opt.checkCopyLastUpdate = checkCopyLastUpdate.Checked
        opt.checkFindNewsUpdates = checkFindNewsUpdates.Checked
        opt.comboDetectMalware = comboDetectMalware.SelectedIndex
        opt.comboDetectFilesSuspect = comboDetectFilesSuspect.SelectedIndex

        opt.checkAmenazasDetect = checkAmenazasDetect.Checked
        opt.checkDisposConect = checkDisposConect.Checked
        opt.checkExplorePC = checkExplorePC.Checked
        opt.checkSucesos = checkSucesos.Checked
        opt.numRegSizeQuar = numRegSizeQuar.Text

        opt.checkAlertMess = checkAlertMess.Checked
        opt.checkNoUpdated = checkNoUpdated.Checked
        opt.checkUpdatedSuccess = checkUpdatedSuccess.Checked
        opt.checkFilesMoveToQuar = checkFilesMoveToQuar.Checked
        opt.checkResultadoAna = checkResultadoAna.Checked
        opt.checkReprodSounds = checkReprodSounds.Checked

        opt.saveSettings()
    End Sub

End Class
Public Class ScanOptions

    ' Gen
    Public checkStartSystem As Boolean = False
    Public checkOpenDevice As Boolean = True
    Public checkCreateProtUSB As Boolean = True
    Public checkCreateProtHDD As Boolean = False
    Public checkDisableExecAutom As Boolean = True
    Public checkShowFFHidden As Boolean = True
    Public checkCopyLastUpdate As Boolean = False
    Public checkFindNewsUpdates As Boolean = False
    Public comboDetectMalware As Integer = 1
    Public comboDetectFilesSuspect As Integer = 2
    ' Reg
    Public checkAmenazasDetect As Boolean = True
    Public checkDisposConect As Boolean = True
    Public checkExplorePC As Boolean = True
    Public checkSucesos As Boolean = True
    Public numRegSizeQuar As Integer = 100
    ' Not
    Public checkAlertMess As Boolean = True
    Public checkNoUpdated As Boolean = True
    Public checkUpdatedSuccess As Boolean = True
    Public checkFilesMoveToQuar As Boolean = True
    Public checkResultadoAna As Boolean = True
    Public checkReprodSounds As Boolean = True

    Public Sub New()
        checkStartSystem = LogicUSB.ValueOfFile("general", "checkStartSystem", "config.ini")
        checkOpenDevice = LogicUSB.ValueOfFile("general", "checkOpenDevice", "config.ini")
        checkCreateProtUSB = LogicUSB.ValueOfFile("general", "checkCreateProtUSB", "config.ini")
        checkCreateProtHDD = LogicUSB.ValueOfFile("general", "checkCreateProtHDD", "config.ini")
        checkDisableExecAutom = LogicUSB.ValueOfFile("general", "checkDisableExecAutom", "config.ini")
        checkShowFFHidden = LogicUSB.ValueOfFile("general", "checkShowFFHidden", "config.ini")
        checkCopyLastUpdate = LogicUSB.ValueOfFile("general", "checkCopyLastUpdate", "config.ini")
        checkFindNewsUpdates = LogicUSB.ValueOfFile("general", "checkFindNewsUpdates", "config.ini")
        comboDetectMalware = LogicUSB.ValueOfFile("general", "comboDetectMalware", "config.ini")
        comboDetectFilesSuspect = LogicUSB.ValueOfFile("general", "comboDetectFilesSuspect", "config.ini")

        checkAmenazasDetect = LogicUSB.ValueOfFile("registro", "checkAmenazasDetect", "config.ini")
        checkDisposConect = LogicUSB.ValueOfFile("registro", "checkDisposConect", "config.ini")
        checkExplorePC = LogicUSB.ValueOfFile("registro", "checkExplorePC", "config.ini")
        checkSucesos = LogicUSB.ValueOfFile("registro", "checkSucesos", "config.ini")
        numRegSizeQuar = LogicUSB.ValueOfFile("registro", "numRegSizeQuar", "config.ini")

        checkAlertMess = LogicUSB.ValueOfFile("notificacion", "checkAlertMess", "config.ini")
        checkNoUpdated = LogicUSB.ValueOfFile("notificacion", "checkNoUpdated", "config.ini")
        checkUpdatedSuccess = LogicUSB.ValueOfFile("notificacion", "checkUpdatedSuccess", "config.ini")
        checkFilesMoveToQuar = LogicUSB.ValueOfFile("notificacion", "checkFilesMoveToQuar", "config.ini")
        checkResultadoAna = LogicUSB.ValueOfFile("notificacion", "checkResultadoAna", "config.ini")
        checkReprodSounds = LogicUSB.ValueOfFile("notificacion", "checkReprodSounds", "config.ini")
    End Sub

    Public Sub saveSettings()
        LogicUSB.SetValueOfFile("general", "checkStartSystem", checkStartSystem, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkOpenDevice", checkOpenDevice, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkCreateProtUSB", checkCreateProtUSB, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkCreateProtHDD", checkCreateProtHDD, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkDisableExecAutom", checkDisableExecAutom, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkShowFFHidden", checkShowFFHidden, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkCopyLastUpdate", checkCopyLastUpdate, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "checkFindNewsUpdates", checkFindNewsUpdates, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "comboDetectMalware", comboDetectMalware, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("general", "comboDetectFilesSuspect", comboDetectFilesSuspect, LogicUSB.DirExecPath & "config.ini")

        LogicUSB.SetValueOfFile("registro", "checkAmenazasDetect", checkAmenazasDetect, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("registro", "checkDisposConect", checkDisposConect, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("registro", "checkExplorePC", checkExplorePC, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("registro", "checkSucesos", checkSucesos, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("registro", "numRegSizeQuar", numRegSizeQuar, LogicUSB.DirExecPath & "config.ini")

        LogicUSB.SetValueOfFile("notificacion", "checkAlertMess", checkAlertMess, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("notificacion", "checkNoUpdated", checkNoUpdated, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("notificacion", "checkUpdatedSuccess", checkUpdatedSuccess, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("notificacion", "checkFilesMoveToQuar", checkFilesMoveToQuar, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("notificacion", "checkResultadoAna", checkResultadoAna, LogicUSB.DirExecPath & "config.ini")
        LogicUSB.SetValueOfFile("notificacion", "checkReprodSounds", checkReprodSounds, LogicUSB.DirExecPath & "config.ini")
    End Sub

End Class

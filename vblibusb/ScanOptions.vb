Public Class ScanOptions

    ' Gen
    Public checkStartSystem As Boolean = False
    Public checkOpenDevice As Boolean = True
    Public checkCreateProtUSB As Boolean = True
    Public checkCreateProtHDD As Boolean = False
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
        checkStartSystem = ValueOfFile("general", "checkStartSystem", "config.ini")
        checkOpenDevice = ValueOfFile("general", "checkOpenDevice", "config.ini")
        checkCreateProtUSB = ValueOfFile("general", "checkCreateProtUSB", "config.ini")
        checkCreateProtHDD = ValueOfFile("general", "checkCreateProtHDD", "config.ini")
        checkShowFFHidden = ValueOfFile("general", "checkShowFFHidden", "config.ini")
        checkCopyLastUpdate = ValueOfFile("general", "checkCopyLastUpdate", "config.ini")
        checkFindNewsUpdates = ValueOfFile("general", "checkFindNewsUpdates", "config.ini")
        comboDetectMalware = ValueOfFile("general", "comboDetectMalware", "config.ini")
        comboDetectFilesSuspect = ValueOfFile("general", "comboDetectFilesSuspect", "config.ini")

        checkAmenazasDetect = ValueOfFile("registro", "checkAmenazasDetect", "config.ini")
        checkDisposConect = ValueOfFile("registro", "checkDisposConect", "config.ini")
        checkExplorePC = ValueOfFile("registro", "checkExplorePC", "config.ini")
        checkSucesos = ValueOfFile("registro", "checkSucesos", "config.ini")
        numRegSizeQuar = ValueOfFile("registro", "numRegSizeQuar", "config.ini")

        checkAlertMess = ValueOfFile("notificacion", "checkAlertMess", "config.ini")
        checkNoUpdated = ValueOfFile("notificacion", "checkNoUpdated", "config.ini")
        checkUpdatedSuccess = ValueOfFile("notificacion", "checkUpdatedSuccess", "config.ini")
        checkFilesMoveToQuar = ValueOfFile("notificacion", "checkFilesMoveToQuar", "config.ini")
        checkResultadoAna = ValueOfFile("notificacion", "checkResultadoAna", "config.ini")
        checkReprodSounds = ValueOfFile("notificacion", "checkReprodSounds", "config.ini")
    End Sub

    Public Sub saveSettings()
        SetValueOfFile("general", "checkStartSystem", checkStartSystem, DirProject & "config.ini")
        SetValueOfFile("general", "checkOpenDevice", checkOpenDevice, DirProject & "config.ini")
        SetValueOfFile("general", "checkCreateProtUSB", checkCreateProtUSB, DirProject & "config.ini")
        SetValueOfFile("general", "checkCreateProtHDD", checkCreateProtHDD, DirProject & "config.ini")
        SetValueOfFile("general", "checkShowFFHidden", checkShowFFHidden, DirProject & "config.ini")
        SetValueOfFile("general", "checkCopyLastUpdate", checkCopyLastUpdate, DirProject & "config.ini")
        SetValueOfFile("general", "checkFindNewsUpdates", checkFindNewsUpdates, DirProject & "config.ini")
        SetValueOfFile("general", "comboDetectMalware", comboDetectMalware, DirProject & "config.ini")
        SetValueOfFile("general", "comboDetectFilesSuspect", comboDetectFilesSuspect, DirProject & "config.ini")

        SetValueOfFile("registro", "checkAmenazasDetect", checkAmenazasDetect, DirProject & "config.ini")
        SetValueOfFile("registro", "checkDisposConect", checkDisposConect, DirProject & "config.ini")
        SetValueOfFile("registro", "checkExplorePC", checkExplorePC, DirProject & "config.ini")
        SetValueOfFile("registro", "checkSucesos", checkSucesos, DirProject & "config.ini")
        SetValueOfFile("registro", "numRegSizeQuar", numRegSizeQuar, DirProject & "config.ini")

        SetValueOfFile("notificacion", "checkAlertMess", checkAlertMess, DirProject & "config.ini")
        SetValueOfFile("notificacion", "checkNoUpdated", checkNoUpdated, DirProject & "config.ini")
        SetValueOfFile("notificacion", "checkUpdatedSuccess", checkUpdatedSuccess, DirProject & "config.ini")
        SetValueOfFile("notificacion", "checkFilesMoveToQuar", checkFilesMoveToQuar, DirProject & "config.ini")
        SetValueOfFile("notificacion", "checkResultadoAna", checkResultadoAna, DirProject & "config.ini")
        SetValueOfFile("notificacion", "checkReprodSounds", checkReprodSounds, DirProject & "config.ini")
    End Sub

End Class

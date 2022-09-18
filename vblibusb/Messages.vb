Public Module Messages

    '
    ' Para el sonido
    '
    Public Const SND_ALIAS = &H10000     '  name is a WIN.INI [sounds] entry
    Public Const SND_ALIAS_ID = &H110000    '  name is a WIN.INI [sounds] entry identifier
    Public Const SND_ALIAS_START = 0  '  must be > 4096 to keep strings in same section of resource file
    Public Const SND_APPLICATION = &H80         '  look for application specific association
    Public Const SND_ASYNC = &H1         '  play asynchronously
    Public Const SND_FILENAME = &H20000     '  name is a file name
    Public Const SND_LOOP = &H8         '  loop the sound until next sndPlaySound
    Public Const SND_NODEFAULT = &H2         '  silence not default, if sound not found
    Public Const SND_MEMORY = &H4         '  lpszSoundName points to a memory file
    Public Const SND_NOSTOP = &H10        '  don't stop any currently playing sound
    Public Const SND_NOWAIT = &H2000      '  don't wait if the driver is busy
    Public Const SND_PURGE = &H40               '  purge non-static events for task
    Public Const SND_RESERVED = &HFF000000  '  In particular these flags are reserved
    Public Const SND_RESOURCE = &H40004     '  name is a resource name or atom
    Public Const SND_SYNC = &H0         '  play synchronously (default)
    Public Const SND_TYPE_MASK = &H170007
    Public Const SND_VALID = &H1F        '  valid flags          / ;Internal /
    Public Const SND_VALIDFLAGS = &H17201F    '  Set of valid flag bits.  Anything outside

    Public Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (lpszSoundName As String, uFlags As Long) As Long

    '
    ' Para enviar mensajes
    '
    Public Const WM_POWER = &H48
    Public Const WM_DEVICECHANGE As Integer = &H219             ' Se ha producido un cambio en los dispositivos
    ' Envio de mensajes definidos por el usuario
    Public Const WM_USER = &H400
    Public Const WM_SCAN_DRIVE = &H401
    Public Const WM_NEW_SCANNER = &H402
    Public Const WM_MESSAGE = &H403
    ' Mensajes relativos al analisis &H1X
    Public Const WM_SCAN_NOVIRUS = &H11                         ' No se detectaron amenazas
    Public Const WM_SCAN_ONEVIRUS = &H12                        ' Se detecta una amenaza
    Public Const WM_SCAN_MANYVIRUS = &H13                       ' Se detectan varias amenazas
    Public Const WM_SCAN_START = &H14                           ' Iniciar analisis
    Public Const WM_SCAN_STOP = &H15                            ' Detener analisis
    ' Mensajes relativos a la actualizacion &H2X
    Public Const WM_UPDATE_SAMEBASES = &H21                     ' Se ha actualizado antes de este archivo
    Public Const WM_UPDATE_UPDATEOK = &H22                      ' La base de datos de firma de virus fue actualizada con éxito
    Public Const WM_UPDATE_RECENT = &H23                        ' Existe una actualización más reciente
    Public Const WM_UPDATE_NOUPDATE = &H24                      ' Este archivo no posee una actualización compatible con esta versión de USB Security
    ' Mensajes relativos a dispositivos (USB, HDD, etc)
    Public Const DBT_DEVICEARRIVAL As Integer = &H8000          ' El sistema detecta un nuevo dispositivo
    Public Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004   ' Extraccion de un dispositivo
    Public Const DBT_DEVTYP_VOLUME As Integer = &H2             ' Volumen lógico (Se ha insertado un disco)

    Public Declare Function ShowWindow Lib "user32" Alias "ShowWindow" (ByVal hwnd As Long, ByVal nCmdShow As Long) As Integer
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As Integer) As Integer
    Public Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function GetActiveWindowA Lib "user32" Alias "GetActiveWindow" () As Integer

    Public Function IsWinFocus(ByVal handle As Integer) As Boolean
        Return GetActiveWindowA() = handle
    End Function

    Public Sub SendMyMessage(lParam As Integer)
        Dim handle As Integer = FindWindow(vbNullString, AppName & " - Main")
        If handle > 0 Then SendMessage(handle, WM_POWER, WM_MESSAGE, lParam)
    End Sub

    '
    ' Otros
    '
    Public Declare Function GetFileIconA Lib "SecurityIcons.dll" Alias "GetFileIcon" (txt As String) As String
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpDefault As String, lpReturnedString As String, nSize As Integer, lpFileName As String) As Integer
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (lpApplicationName As String, lpKeyName As String, lpString As String, lpFileName As String) As Integer

    Public Declare Function DeleteFile Lib "kernel32" Alias "DeleteFileA" (ByVal lpFileName As String) As Boolean
    'Public Declare Function CopyFile Lib "kernel32" Alias "CopyFileA" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal bFailIfExists As Boolean) As Boolean

End Module

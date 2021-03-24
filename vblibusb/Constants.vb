Public Module Constants

    Public Const AppName As String = "USBSecurity"
    Public Const AppNameSpace As String = "USB Security"
    Public Const FileSizeMin As Integer = 1 ' Tamaño minimo de archivos a escanear
    Public Const FileSizeMax As Integer = 67000000 ' Tamaño maximo de archivos a escanear ' 66168832
    Public Const DaysToUpdate As Byte = 7 ' dias hasta notificar que el AV esta desactualizado

    ' Para el sonido
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

    ' Para enviar mensajes
    Public Const WM_POWER = &H48
    Public Const deviceChange As Integer = &H219                ' Se ha producido un cambio en los dispositivos
    ' Envio de mensajes definidos por el usuario
    Public Const WM_USER = &H400
    Public Const WM_SCAN_DRIVE = &H401
    Public Const WM_NEW_SCANNER = &H402
    Public Const WM_MESSAGE = &H403
    ' Mensajes relativos al analisis &H1X
    Public Const WM_SCAN_NOVIRUS = &H11                         ' No se detectaron amenazas
    Public Const WM_SCAN_ONEVIRUS = &H12                        ' Se detecta una amenaza
    Public Const WM_SCAN_MANYVIRUS = &H13                       ' Se detectan varias amenazas
    ' Mensajes relativos a la actualizacion &H2X
    Public Const WM_UPDATE_SAMEBASES = &H21                     ' Se ha actualizado antes de este archivo
    Public Const WM_UPDATE_UPDATEOK = &H22                      ' La base de datos de firma de virus fue actualizada con éxito
    Public Const WM_UPDATE_RECENT = &H23                        ' Existe una actualización más reciente
    Public Const WM_UPDATE_NOUPDATE = &H24                      ' Este archivo no posee una actualización compatible con esta versión de USB Security
    ' Mensajes relativos a dispositivos (USB, HDD, etc)
    Public Const deviceArrival As Integer = &H8000              ' El sistema detecta un nuevo dispositivo
    Public Const deviceTypeVolume As Integer = &H2              ' Volumen lógico (Se ha insertado un disco)

End Module

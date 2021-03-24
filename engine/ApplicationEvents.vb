Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

        Protected Overrides Function OnStartup(eventArgs As ApplicationServices.StartupEventArgs) As Boolean
            ' Linea de comandos: engine.exe [drive]
            ' drive              Unidad de disco a analizar, ej: engine.exe E:\
            'For Each arg As String In eventArgs.CommandLine
            '    MsgBox(arg)
            'Next

            If eventArgs.CommandLine.Count = 1 Then
                'Dim letters As String() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
                If eventArgs.CommandLine(0).Equals("full-scan", StringComparison.OrdinalIgnoreCase) Then
                    FormMain.tScan = TypeScan.FULL_SCAN
                    FormMain.picDrive.Image = My.Resources.system
                ElseIf eventArgs.CommandLine(0).Equals("quick-scan", StringComparison.OrdinalIgnoreCase) Then
                    FormMain.tScan = TypeScan.QUICK_SCAN
                    FormMain.picDrive.Image = My.Resources.system
                End If
            ElseIf eventArgs.CommandLine.Count = 2 Then
                Dim typeScan As String = eventArgs.CommandLine(0)
                Dim path As String = eventArgs.CommandLine(1)

                If typeScan.Equals("scan-drive", StringComparison.OrdinalIgnoreCase) Then
                    Dim drvInfo = My.Computer.FileSystem.GetDriveInfo(path)
                    If drvInfo.IsReady Then
                        FormMain.tScan = engine.TypeScan.DRIVE_SCAN
                        FormMain.path = path
                        If drvInfo.DriveType = IO.DriveType.Removable Then
                            FormMain.picDrive.Image = My.Resources.usb
                        Else
                            FormMain.picDrive.Image = My.Resources.hdd
                        End If
                    Else
                        End
                    End If
                ElseIf typeScan.Equals("scan-file", StringComparison.OrdinalIgnoreCase) Then
                    FormMain.tScan = engine.TypeScan.FILE_SCAN
                    FormMain.path = path
                    FormMain.picDrive.Image = My.Resources.system
                End If
            Else
                'MsgBox("Línea de comandos" & vbCrLf & vbCrLf & _
                '    "engine [drive]" & vbCrLf & _
                '    "engine [full-scan|quick-scan]" & vbCrLf & vbCrLf & _
                '    "drive" & vbTab & "Letra de dispositivo" & vbCrLf & vbCrLf & _
                '    "engine D" & vbCrLf & _
                '    "engine full-scan" & vbCrLf & _
                '    "engine quick-scan", MsgBoxStyle.Information)

                End
            End If

            Return MyBase.OnStartup(eventArgs)
        End Function

    End Class

End Namespace


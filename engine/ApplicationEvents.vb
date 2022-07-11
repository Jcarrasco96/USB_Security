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
            If eventArgs.CommandLine.Count = 1 Then
                FormMain.picDrive.Image = Resources.system

                Select Case eventArgs.CommandLine(0)
                    Case "full-scan"
                        FormMain.tScan = TypeScan.FULL_SCAN
                    Case "quick-scan"
                        FormMain.tScan = TypeScan.QUICK_SCAN
                    Case "help"
                        MsgBox("Command line" & vbCrLf & vbCrLf & _
                            "engine scan-drive [drive:\]" & vbCrLf & _
                            "engine scan-file [path2file]" & vbCrLf & _
                            "engine scan-path [path2folder]" & vbCrLf & _
                            "engine full-scan" & vbCrLf & _
                            "engine quick-scan", MsgBoxStyle.Information)
                        End
                    Case Else
                        End
                End Select
            ElseIf eventArgs.CommandLine.Count = 2 Then
                Dim path As String = eventArgs.CommandLine(1)

                Select Case eventArgs.CommandLine(0)
                    Case "scan-drive"
                        Dim drv = path.Substring(0, 1) & ":\"
                        Dim drvInfo = Computer.FileSystem.GetDriveInfo(drv)
                        If drvInfo.IsReady Then
                            FormMain.tScan = TypeScan.DRIVE_SCAN
                            FormMain.path = drv
                            If drvInfo.DriveType = IO.DriveType.Removable Then
                                FormMain.picDrive.Image = Resources.usb
                            Else
                                FormMain.picDrive.Image = Resources.hdd
                            End If
                        Else
                            End
                        End If
                    Case "scan-file"
                        FormMain.tScan = TypeScan.FILE_SCAN
                        FormMain.path = path
                        FormMain.picDrive.Image = Resources.system
                    Case "scan-folder"
                        FormMain.tScan = TypeScan.FOLDER_SCAN
                        FormMain.path = path
                        FormMain.picDrive.Image = Resources.folder
                    Case "update"
                        UpdateBasesFromFile(path)
                        End
                    Case Else
                        End
                End Select
            Else
                End
            End If

            Return MyBase.OnStartup(eventArgs)
        End Function

    End Class

End Namespace


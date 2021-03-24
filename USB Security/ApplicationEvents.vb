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
            copyFilesNeed()

            Try
                Dim opts As New vblibusb.ScanOptions()

                'RegisterOnStartup(True);
                'ExplorerIntegration(True)
                'IconsAsociateUpdate()
                'AsociateDriveIcon()
                SetWindowsAutorun(opts.checkDisableExecAutom)
            Catch ex As Exception

            End Try

            'CleanReportLimit()
            'CleanQuarLimit()

            vblibusb.LogFunc(Now.ToString & "*" & vblibusb.UserName & "*Antivirus*Iniciado")

            Return MyBase.OnStartup(eventArgs)
        End Function

    End Class

End Namespace


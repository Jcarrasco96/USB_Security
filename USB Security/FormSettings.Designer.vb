Imports Theme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabNotify = New System.Windows.Forms.TabPage()
        Me.tabRegistry = New System.Windows.Forms.TabPage()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.checkStartSystem = New System.Windows.Forms.CheckBox()
        Me.checkOpenDevice = New System.Windows.Forms.CheckBox()
        Me.checkCreateProtUSB = New System.Windows.Forms.CheckBox()
        Me.checkCreateProtHDD = New System.Windows.Forms.CheckBox()
        Me.checkShowFFHidden = New System.Windows.Forms.CheckBox()
        Me.checkFindNewsUpdates = New System.Windows.Forms.CheckBox()
        Me.checkCopyLastUpdate = New System.Windows.Forms.CheckBox()
        Me.comboDetectMalware = New System.Windows.Forms.ComboBox()
        Me.comboDetectFilesSuspect = New System.Windows.Forms.ComboBox()
        Me.checkAmenazasDetect = New System.Windows.Forms.CheckBox()
        Me.checkDisposConect = New System.Windows.Forms.CheckBox()
        Me.checkExplorePC = New System.Windows.Forms.CheckBox()
        Me.checkSucesos = New System.Windows.Forms.CheckBox()
        Me.checkAlertMess = New System.Windows.Forms.CheckBox()
        Me.checkNoUpdated = New System.Windows.Forms.CheckBox()
        Me.checkUpdatedSuccess = New System.Windows.Forms.CheckBox()
        Me.checkFilesMoveToQuar = New System.Windows.Forms.CheckBox()
        Me.checkResultadoAna = New System.Windows.Forms.CheckBox()
        Me.checkReprodSounds = New System.Windows.Forms.CheckBox()
        Me.numRegSizeQuar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabNotify.SuspendLayout()
        Me.tabRegistry.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabNotify
        '
        Me.tabNotify.BackColor = System.Drawing.Color.White
        Me.tabNotify.Controls.Add(Me.checkReprodSounds)
        Me.tabNotify.Controls.Add(Me.checkResultadoAna)
        Me.tabNotify.Controls.Add(Me.checkFilesMoveToQuar)
        Me.tabNotify.Controls.Add(Me.checkUpdatedSuccess)
        Me.tabNotify.Controls.Add(Me.checkNoUpdated)
        Me.tabNotify.Controls.Add(Me.checkAlertMess)
        Me.tabNotify.Location = New System.Drawing.Point(4, 22)
        Me.tabNotify.Name = "tabNotify"
        Me.tabNotify.Padding = New System.Windows.Forms.Padding(10)
        Me.tabNotify.Size = New System.Drawing.Size(453, 282)
        Me.tabNotify.TabIndex = 4
        Me.tabNotify.Text = "Notificación"
        '
        'tabRegistry
        '
        Me.tabRegistry.BackColor = System.Drawing.Color.White
        Me.tabRegistry.Controls.Add(Me.checkSucesos)
        Me.tabRegistry.Controls.Add(Me.checkExplorePC)
        Me.tabRegistry.Controls.Add(Me.checkDisposConect)
        Me.tabRegistry.Controls.Add(Me.checkAmenazasDetect)
        Me.tabRegistry.Location = New System.Drawing.Point(4, 22)
        Me.tabRegistry.Name = "tabRegistry"
        Me.tabRegistry.Padding = New System.Windows.Forms.Padding(10)
        Me.tabRegistry.Size = New System.Drawing.Size(453, 282)
        Me.tabRegistry.TabIndex = 3
        Me.tabRegistry.Text = "Registro"
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.White
        Me.tabGeneral.Controls.Add(Me.numRegSizeQuar)
        Me.tabGeneral.Controls.Add(Me.Label7)
        Me.tabGeneral.Controls.Add(Me.Label3)
        Me.tabGeneral.Controls.Add(Me.Label1)
        Me.tabGeneral.Controls.Add(Me.comboDetectFilesSuspect)
        Me.tabGeneral.Controls.Add(Me.comboDetectMalware)
        Me.tabGeneral.Controls.Add(Me.checkCopyLastUpdate)
        Me.tabGeneral.Controls.Add(Me.checkFindNewsUpdates)
        Me.tabGeneral.Controls.Add(Me.checkShowFFHidden)
        Me.tabGeneral.Controls.Add(Me.checkCreateProtHDD)
        Me.tabGeneral.Controls.Add(Me.checkCreateProtUSB)
        Me.tabGeneral.Controls.Add(Me.checkOpenDevice)
        Me.tabGeneral.Controls.Add(Me.checkStartSystem)
        Me.tabGeneral.Controls.Add(Me.Label6)
        Me.tabGeneral.Controls.Add(Me.Label5)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(10)
        Me.tabGeneral.Size = New System.Drawing.Size(453, 282)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Al detectar una amenaza"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Detección de archivos sospechosos"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabRegistry)
        Me.TabControl1.Controls.Add(Me.tabNotify)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(461, 308)
        Me.TabControl1.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(394, 326)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.Location = New System.Drawing.Point(313, 326)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.Text = "Aceptar"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'checkStartSystem
        '
        Me.checkStartSystem.AutoSize = True
        Me.checkStartSystem.Location = New System.Drawing.Point(13, 13)
        Me.checkStartSystem.Name = "checkStartSystem"
        Me.checkStartSystem.Size = New System.Drawing.Size(124, 17)
        Me.checkStartSystem.TabIndex = 22
        Me.checkStartSystem.Text = "Iniciar con el sistema"
        Me.checkStartSystem.UseVisualStyleBackColor = True
        '
        'checkOpenDevice
        '
        Me.checkOpenDevice.AutoSize = True
        Me.checkOpenDevice.Location = New System.Drawing.Point(13, 36)
        Me.checkOpenDevice.Name = "checkOpenDevice"
        Me.checkOpenDevice.Size = New System.Drawing.Size(200, 17)
        Me.checkOpenDevice.TabIndex = 23
        Me.checkOpenDevice.Text = "Abrir dispositivos luego de analizarlos"
        Me.checkOpenDevice.UseVisualStyleBackColor = True
        '
        'checkCreateProtUSB
        '
        Me.checkCreateProtUSB.AutoSize = True
        Me.checkCreateProtUSB.Location = New System.Drawing.Point(13, 59)
        Me.checkCreateProtUSB.Name = "checkCreateProtUSB"
        Me.checkCreateProtUSB.Size = New System.Drawing.Size(190, 17)
        Me.checkCreateProtUSB.TabIndex = 24
        Me.checkCreateProtUSB.Text = "Crear protección en unidades USB"
        Me.checkCreateProtUSB.UseVisualStyleBackColor = True
        '
        'checkCreateProtHDD
        '
        Me.checkCreateProtHDD.AutoSize = True
        Me.checkCreateProtHDD.Location = New System.Drawing.Point(13, 82)
        Me.checkCreateProtHDD.Name = "checkCreateProtHDD"
        Me.checkCreateProtHDD.Size = New System.Drawing.Size(192, 17)
        Me.checkCreateProtHDD.TabIndex = 25
        Me.checkCreateProtHDD.Text = "Crear protección en unidades HDD"
        Me.checkCreateProtHDD.UseVisualStyleBackColor = True
        '
        'checkShowFFHidden
        '
        Me.checkShowFFHidden.AutoSize = True
        Me.checkShowFFHidden.Location = New System.Drawing.Point(13, 105)
        Me.checkShowFFHidden.Name = "checkShowFFHidden"
        Me.checkShowFFHidden.Size = New System.Drawing.Size(281, 17)
        Me.checkShowFFHidden.TabIndex = 26
        Me.checkShowFFHidden.Text = "Mostrar archivos y carpetas ocultas en los dispositivos"
        Me.checkShowFFHidden.UseVisualStyleBackColor = True
        '
        'checkFindNewsUpdates
        '
        Me.checkFindNewsUpdates.AutoSize = True
        Me.checkFindNewsUpdates.Location = New System.Drawing.Point(13, 151)
        Me.checkFindNewsUpdates.Name = "checkFindNewsUpdates"
        Me.checkFindNewsUpdates.Size = New System.Drawing.Size(261, 17)
        Me.checkFindNewsUpdates.TabIndex = 27
        Me.checkFindNewsUpdates.Text = "Buscar nuevas actualizaciones en los dispositivos"
        Me.checkFindNewsUpdates.UseVisualStyleBackColor = True
        '
        'checkCopyLastUpdate
        '
        Me.checkCopyLastUpdate.AutoSize = True
        Me.checkCopyLastUpdate.Location = New System.Drawing.Point(13, 128)
        Me.checkCopyLastUpdate.Name = "checkCopyLastUpdate"
        Me.checkCopyLastUpdate.Size = New System.Drawing.Size(419, 17)
        Me.checkCopyLastUpdate.TabIndex = 28
        Me.checkCopyLastUpdate.Text = "Copiar la última actualización a los dispositivos externos que se conecten a este" & _
    " PC"
        Me.checkCopyLastUpdate.UseVisualStyleBackColor = True
        '
        'comboDetectMalware
        '
        Me.comboDetectMalware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDetectMalware.FormattingEnabled = True
        Me.comboDetectMalware.Items.AddRange(New Object() {"Preguntar al usuario", "Mover a cuarentena"})
        Me.comboDetectMalware.Location = New System.Drawing.Point(285, 174)
        Me.comboDetectMalware.Name = "comboDetectMalware"
        Me.comboDetectMalware.Size = New System.Drawing.Size(121, 21)
        Me.comboDetectMalware.TabIndex = 29
        '
        'comboDetectFilesSuspect
        '
        Me.comboDetectFilesSuspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDetectFilesSuspect.FormattingEnabled = True
        Me.comboDetectFilesSuspect.Items.AddRange(New Object() {"Bajo", "Normal", "Alto"})
        Me.comboDetectFilesSuspect.Location = New System.Drawing.Point(285, 201)
        Me.comboDetectFilesSuspect.Name = "comboDetectFilesSuspect"
        Me.comboDetectFilesSuspect.Size = New System.Drawing.Size(121, 21)
        Me.comboDetectFilesSuspect.TabIndex = 30
        '
        'checkAmenazasDetect
        '
        Me.checkAmenazasDetect.AutoSize = True
        Me.checkAmenazasDetect.Location = New System.Drawing.Point(13, 13)
        Me.checkAmenazasDetect.Name = "checkAmenazasDetect"
        Me.checkAmenazasDetect.Size = New System.Drawing.Size(131, 17)
        Me.checkAmenazasDetect.TabIndex = 23
        Me.checkAmenazasDetect.Text = "Amenazas detectadas"
        Me.checkAmenazasDetect.UseVisualStyleBackColor = True
        '
        'checkDisposConect
        '
        Me.checkDisposConect.AutoSize = True
        Me.checkDisposConect.Location = New System.Drawing.Point(13, 36)
        Me.checkDisposConect.Name = "checkDisposConect"
        Me.checkDisposConect.Size = New System.Drawing.Size(141, 17)
        Me.checkDisposConect.TabIndex = 24
        Me.checkDisposConect.Text = "Dispositivos conectados"
        Me.checkDisposConect.UseVisualStyleBackColor = True
        '
        'checkExplorePC
        '
        Me.checkExplorePC.AutoSize = True
        Me.checkExplorePC.Location = New System.Drawing.Point(13, 59)
        Me.checkExplorePC.Name = "checkExplorePC"
        Me.checkExplorePC.Size = New System.Drawing.Size(133, 17)
        Me.checkExplorePC.TabIndex = 25
        Me.checkExplorePC.Text = "Exploración del equipo"
        Me.checkExplorePC.UseVisualStyleBackColor = True
        '
        'checkSucesos
        '
        Me.checkSucesos.AutoSize = True
        Me.checkSucesos.Location = New System.Drawing.Point(13, 82)
        Me.checkSucesos.Name = "checkSucesos"
        Me.checkSucesos.Size = New System.Drawing.Size(67, 17)
        Me.checkSucesos.TabIndex = 26
        Me.checkSucesos.Text = "Sucesos"
        Me.checkSucesos.UseVisualStyleBackColor = True
        '
        'checkAlertMess
        '
        Me.checkAlertMess.AutoSize = True
        Me.checkAlertMess.Location = New System.Drawing.Point(13, 13)
        Me.checkAlertMess.Name = "checkAlertMess"
        Me.checkAlertMess.Size = New System.Drawing.Size(170, 17)
        Me.checkAlertMess.TabIndex = 23
        Me.checkAlertMess.Text = "Alertas y mensajes importantes"
        Me.checkAlertMess.UseVisualStyleBackColor = True
        '
        'checkNoUpdated
        '
        Me.checkNoUpdated.AutoSize = True
        Me.checkNoUpdated.Location = New System.Drawing.Point(13, 36)
        Me.checkNoUpdated.Name = "checkNoUpdated"
        Me.checkNoUpdated.Size = New System.Drawing.Size(140, 17)
        Me.checkNoUpdated.TabIndex = 24
        Me.checkNoUpdated.Text = "Antivirus desactualizado"
        Me.checkNoUpdated.UseVisualStyleBackColor = True
        '
        'checkUpdatedSuccess
        '
        Me.checkUpdatedSuccess.AutoSize = True
        Me.checkUpdatedSuccess.Location = New System.Drawing.Point(13, 59)
        Me.checkUpdatedSuccess.Name = "checkUpdatedSuccess"
        Me.checkUpdatedSuccess.Size = New System.Drawing.Size(169, 17)
        Me.checkUpdatedSuccess.TabIndex = 25
        Me.checkUpdatedSuccess.Text = "Antivirus actualizado con exito"
        Me.checkUpdatedSuccess.UseVisualStyleBackColor = True
        '
        'checkFilesMoveToQuar
        '
        Me.checkFilesMoveToQuar.AutoSize = True
        Me.checkFilesMoveToQuar.Location = New System.Drawing.Point(13, 82)
        Me.checkFilesMoveToQuar.Name = "checkFilesMoveToQuar"
        Me.checkFilesMoveToQuar.Size = New System.Drawing.Size(175, 17)
        Me.checkFilesMoveToQuar.TabIndex = 26
        Me.checkFilesMoveToQuar.Text = "Archivos movidos a cuarentena"
        Me.checkFilesMoveToQuar.UseVisualStyleBackColor = True
        '
        'checkResultadoAna
        '
        Me.checkResultadoAna.AutoSize = True
        Me.checkResultadoAna.Location = New System.Drawing.Point(13, 105)
        Me.checkResultadoAna.Name = "checkResultadoAna"
        Me.checkResultadoAna.Size = New System.Drawing.Size(126, 17)
        Me.checkResultadoAna.TabIndex = 27
        Me.checkResultadoAna.Text = "Resultado de análisis"
        Me.checkResultadoAna.UseVisualStyleBackColor = True
        '
        'checkReprodSounds
        '
        Me.checkReprodSounds.AutoSize = True
        Me.checkReprodSounds.Location = New System.Drawing.Point(13, 128)
        Me.checkReprodSounds.Name = "checkReprodSounds"
        Me.checkReprodSounds.Size = New System.Drawing.Size(152, 17)
        Me.checkReprodSounds.TabIndex = 28
        Me.checkReprodSounds.Text = "Reproducir alertas sonoras"
        Me.checkReprodSounds.UseVisualStyleBackColor = True
        '
        'numRegSizeQuar
        '
        Me.numRegSizeQuar.Location = New System.Drawing.Point(285, 228)
        Me.numRegSizeQuar.Name = "numRegSizeQuar"
        Me.numRegSizeQuar.Size = New System.Drawing.Size(121, 20)
        Me.numRegSizeQuar.TabIndex = 34
        Me.numRegSizeQuar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(282, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "0 - no borrar nunca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mb"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Eliminar archivos de la cuarentena cuando sobrepasen"
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.tabNotify.ResumeLayout(False)
        Me.tabNotify.PerformLayout()
        Me.tabRegistry.ResumeLayout(False)
        Me.tabRegistry.PerformLayout()
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabNotify As System.Windows.Forms.TabPage
    Friend WithEvents tabRegistry As System.Windows.Forms.TabPage
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents checkOpenDevice As System.Windows.Forms.CheckBox
    Friend WithEvents checkStartSystem As System.Windows.Forms.CheckBox
    Friend WithEvents checkShowFFHidden As System.Windows.Forms.CheckBox
    Friend WithEvents checkCreateProtHDD As System.Windows.Forms.CheckBox
    Friend WithEvents checkCreateProtUSB As System.Windows.Forms.CheckBox
    Friend WithEvents comboDetectFilesSuspect As System.Windows.Forms.ComboBox
    Friend WithEvents comboDetectMalware As System.Windows.Forms.ComboBox
    Friend WithEvents checkCopyLastUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents checkFindNewsUpdates As System.Windows.Forms.CheckBox
    Friend WithEvents checkReprodSounds As System.Windows.Forms.CheckBox
    Friend WithEvents checkResultadoAna As System.Windows.Forms.CheckBox
    Friend WithEvents checkFilesMoveToQuar As System.Windows.Forms.CheckBox
    Friend WithEvents checkUpdatedSuccess As System.Windows.Forms.CheckBox
    Friend WithEvents checkNoUpdated As System.Windows.Forms.CheckBox
    Friend WithEvents checkAlertMess As System.Windows.Forms.CheckBox
    Friend WithEvents checkSucesos As System.Windows.Forms.CheckBox
    Friend WithEvents checkExplorePC As System.Windows.Forms.CheckBox
    Friend WithEvents checkDisposConect As System.Windows.Forms.CheckBox
    Friend WithEvents checkAmenazasDetect As System.Windows.Forms.CheckBox
    Friend WithEvents numRegSizeQuar As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

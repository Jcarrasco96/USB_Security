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
        Me.MysticTheme1 = New DarkTheme()
        Me.btnAceptar = New DarkButton()
        Me.btnCancelar = New DarkButton()
        Me.MysticClose1 = New DarkClose()
        Me.ThirteenTabControl1 = New DarkTabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.checkFindNewsUpdates = New DarkCheckBox()
        Me.checkCopyLastUpdate = New DarkCheckBox()
        Me.checkShowFFHidden = New DarkCheckBox()
        Me.checkCreateProtHDD = New DarkCheckBox()
        Me.comboDetectMalware = New DarkComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.checkCreateProtUSB = New DarkCheckBox()
        Me.checkOpenDevice = New DarkCheckBox()
        Me.comboDetectFilesSuspect = New DarkComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkStartSystem = New DarkCheckBox()
        Me.tabRegistry = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numRegSizeQuar = New DarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkSucesos = New DarkCheckBox()
        Me.checkExplorePC = New DarkCheckBox()
        Me.checkDisposConect = New DarkCheckBox()
        Me.checkAmenazasDetect = New DarkCheckBox()
        Me.tabNotify = New System.Windows.Forms.TabPage()
        Me.checkReprodSounds = New DarkCheckBox()
        Me.checkResultadoAna = New DarkCheckBox()
        Me.checkFilesMoveToQuar = New DarkCheckBox()
        Me.checkUpdatedSuccess = New DarkCheckBox()
        Me.checkNoUpdated = New DarkCheckBox()
        Me.checkAlertMess = New DarkCheckBox()
        Me.MysticTheme1.SuspendLayout()
        Me.ThirteenTabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabRegistry.SuspendLayout()
        Me.tabNotify.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.btnAceptar)
        Me.MysticTheme1.Controls.Add(Me.btnCancelar)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Controls.Add(Me.ThirteenTabControl1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = True
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(615, 415)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Ajustes"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(427, 373)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 30)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(518, 373)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 30)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        '
        'MysticClose1
        '
        Me.MysticClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MysticClose1.Location = New System.Drawing.Point(585, 6)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(24, 24)
        Me.MysticClose1.TabIndex = 1
        Me.MysticClose1.Text = "MysticClose1"
        '
        'ThirteenTabControl1
        '
        Me.ThirteenTabControl1.Controls.Add(Me.tabGeneral)
        Me.ThirteenTabControl1.Controls.Add(Me.tabRegistry)
        Me.ThirteenTabControl1.Controls.Add(Me.tabNotify)
        Me.ThirteenTabControl1.ForeColor = System.Drawing.Color.White
        Me.ThirteenTabControl1.Location = New System.Drawing.Point(12, 46)
        Me.ThirteenTabControl1.Name = "ThirteenTabControl1"
        Me.ThirteenTabControl1.SelectedIndex = 0
        Me.ThirteenTabControl1.Size = New System.Drawing.Size(591, 315)
        Me.ThirteenTabControl1.TabIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabGeneral.Controls.Add(Me.checkFindNewsUpdates)
        Me.tabGeneral.Controls.Add(Me.checkCopyLastUpdate)
        Me.tabGeneral.Controls.Add(Me.checkShowFFHidden)
        Me.tabGeneral.Controls.Add(Me.checkCreateProtHDD)
        Me.tabGeneral.Controls.Add(Me.comboDetectMalware)
        Me.tabGeneral.Controls.Add(Me.Label6)
        Me.tabGeneral.Controls.Add(Me.checkCreateProtUSB)
        Me.tabGeneral.Controls.Add(Me.checkOpenDevice)
        Me.tabGeneral.Controls.Add(Me.comboDetectFilesSuspect)
        Me.tabGeneral.Controls.Add(Me.Label5)
        Me.tabGeneral.Controls.Add(Me.checkStartSystem)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(583, 286)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'checkFindNewsUpdates
        '
        Me.checkFindNewsUpdates.Checked = False
        Me.checkFindNewsUpdates.Location = New System.Drawing.Point(15, 147)
        Me.checkFindNewsUpdates.Name = "checkFindNewsUpdates"
        Me.checkFindNewsUpdates.Size = New System.Drawing.Size(548, 16)
        Me.checkFindNewsUpdates.TabIndex = 21
        Me.checkFindNewsUpdates.Text = "Buscar nuevas actualizaciones en los dispositivos"
        '
        'checkCopyLastUpdate
        '
        Me.checkCopyLastUpdate.Checked = False
        Me.checkCopyLastUpdate.Location = New System.Drawing.Point(15, 125)
        Me.checkCopyLastUpdate.Name = "checkCopyLastUpdate"
        Me.checkCopyLastUpdate.Size = New System.Drawing.Size(548, 16)
        Me.checkCopyLastUpdate.TabIndex = 20
        Me.checkCopyLastUpdate.Text = "Copiar la última actualización a todos los dispositivos externos que se conecten " &
    "a esta PC"
        '
        'checkShowFFHidden
        '
        Me.checkShowFFHidden.Checked = False
        Me.checkShowFFHidden.Location = New System.Drawing.Point(15, 103)
        Me.checkShowFFHidden.Name = "checkShowFFHidden"
        Me.checkShowFFHidden.Size = New System.Drawing.Size(548, 16)
        Me.checkShowFFHidden.TabIndex = 17
        Me.checkShowFFHidden.Text = "Mostrar archivos y carpetas ocultas en los dispositivos"
        '
        'checkCreateProtHDD
        '
        Me.checkCreateProtHDD.Checked = False
        Me.checkCreateProtHDD.Location = New System.Drawing.Point(15, 81)
        Me.checkCreateProtHDD.Name = "checkCreateProtHDD"
        Me.checkCreateProtHDD.Size = New System.Drawing.Size(548, 16)
        Me.checkCreateProtHDD.TabIndex = 15
        Me.checkCreateProtHDD.Text = "Crear protección en unidades HDD"
        '
        'comboDetectMalware
        '
        Me.comboDetectMalware.AccentColor = System.Drawing.Color.DodgerBlue
        Me.comboDetectMalware.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboDetectMalware.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboDetectMalware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDetectMalware.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.comboDetectMalware.ForeColor = System.Drawing.Color.White
        Me.comboDetectMalware.FormattingEnabled = True
        Me.comboDetectMalware.Items.AddRange(New Object() {"Preguntar al usuario", "Mover a cuarentena"})
        Me.comboDetectMalware.Location = New System.Drawing.Point(314, 191)
        Me.comboDetectMalware.Name = "comboDetectMalware"
        Me.comboDetectMalware.Size = New System.Drawing.Size(249, 26)
        Me.comboDetectMalware.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Al detectar una amenaza"
        '
        'checkCreateProtUSB
        '
        Me.checkCreateProtUSB.Checked = False
        Me.checkCreateProtUSB.Location = New System.Drawing.Point(15, 59)
        Me.checkCreateProtUSB.Name = "checkCreateProtUSB"
        Me.checkCreateProtUSB.Size = New System.Drawing.Size(548, 16)
        Me.checkCreateProtUSB.TabIndex = 12
        Me.checkCreateProtUSB.Text = "Crear protección en unidades USB"
        '
        'checkOpenDevice
        '
        Me.checkOpenDevice.Checked = False
        Me.checkOpenDevice.Location = New System.Drawing.Point(15, 37)
        Me.checkOpenDevice.Name = "checkOpenDevice"
        Me.checkOpenDevice.Size = New System.Drawing.Size(548, 16)
        Me.checkOpenDevice.TabIndex = 11
        Me.checkOpenDevice.Text = "Abrir dispositivos luego de analizarlos"
        '
        'comboDetectFilesSuspect
        '
        Me.comboDetectFilesSuspect.AccentColor = System.Drawing.Color.DodgerBlue
        Me.comboDetectFilesSuspect.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.comboDetectFilesSuspect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboDetectFilesSuspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDetectFilesSuspect.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.comboDetectFilesSuspect.ForeColor = System.Drawing.Color.White
        Me.comboDetectFilesSuspect.FormattingEnabled = True
        Me.comboDetectFilesSuspect.Items.AddRange(New Object() {"Bajo", "Normal", "Alto"})
        Me.comboDetectFilesSuspect.Location = New System.Drawing.Point(314, 223)
        Me.comboDetectFilesSuspect.Name = "comboDetectFilesSuspect"
        Me.comboDetectFilesSuspect.Size = New System.Drawing.Size(249, 26)
        Me.comboDetectFilesSuspect.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Detección de archivos sospechosos"
        '
        'checkStartSystem
        '
        Me.checkStartSystem.Checked = False
        Me.checkStartSystem.Location = New System.Drawing.Point(15, 15)
        Me.checkStartSystem.Name = "checkStartSystem"
        Me.checkStartSystem.Size = New System.Drawing.Size(548, 16)
        Me.checkStartSystem.TabIndex = 1
        Me.checkStartSystem.Text = "Iniciar con el sistema"
        '
        'tabRegistry
        '
        Me.tabRegistry.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabRegistry.Controls.Add(Me.Label7)
        Me.tabRegistry.Controls.Add(Me.Label3)
        Me.tabRegistry.Controls.Add(Me.numRegSizeQuar)
        Me.tabRegistry.Controls.Add(Me.Label1)
        Me.tabRegistry.Controls.Add(Me.checkSucesos)
        Me.tabRegistry.Controls.Add(Me.checkExplorePC)
        Me.tabRegistry.Controls.Add(Me.checkDisposConect)
        Me.tabRegistry.Controls.Add(Me.checkAmenazasDetect)
        Me.tabRegistry.Location = New System.Drawing.Point(4, 25)
        Me.tabRegistry.Name = "tabRegistry"
        Me.tabRegistry.Size = New System.Drawing.Size(583, 286)
        Me.tabRegistry.TabIndex = 3
        Me.tabRegistry.Text = "Registro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(283, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "0 - no borrar nunca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Mb"
        '
        'numRegSizeQuar
        '
        Me.numRegSizeQuar.BackColor = System.Drawing.Color.Transparent
        Me.numRegSizeQuar.Location = New System.Drawing.Point(286, 103)
        Me.numRegSizeQuar.MaxLength = 32767
        Me.numRegSizeQuar.Multiline = False
        Me.numRegSizeQuar.Name = "numRegSizeQuar"
        Me.numRegSizeQuar.ReadOnly = False
        Me.numRegSizeQuar.Size = New System.Drawing.Size(75, 27)
        Me.numRegSizeQuar.TabIndex = 19
        Me.numRegSizeQuar.Text = "100"
        Me.numRegSizeQuar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numRegSizeQuar.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Eliminar archivos de la cuarentena cuando sobrepasen"
        '
        'checkSucesos
        '
        Me.checkSucesos.Checked = False
        Me.checkSucesos.Location = New System.Drawing.Point(15, 81)
        Me.checkSucesos.Name = "checkSucesos"
        Me.checkSucesos.Size = New System.Drawing.Size(548, 16)
        Me.checkSucesos.TabIndex = 17
        Me.checkSucesos.Text = "Sucesos"
        '
        'checkExplorePC
        '
        Me.checkExplorePC.Checked = False
        Me.checkExplorePC.Location = New System.Drawing.Point(15, 59)
        Me.checkExplorePC.Name = "checkExplorePC"
        Me.checkExplorePC.Size = New System.Drawing.Size(548, 16)
        Me.checkExplorePC.TabIndex = 16
        Me.checkExplorePC.Text = "Exploración del equipo"
        '
        'checkDisposConect
        '
        Me.checkDisposConect.Checked = False
        Me.checkDisposConect.Location = New System.Drawing.Point(15, 37)
        Me.checkDisposConect.Name = "checkDisposConect"
        Me.checkDisposConect.Size = New System.Drawing.Size(548, 16)
        Me.checkDisposConect.TabIndex = 15
        Me.checkDisposConect.Text = "Dispositivos conectados"
        '
        'checkAmenazasDetect
        '
        Me.checkAmenazasDetect.Checked = False
        Me.checkAmenazasDetect.Location = New System.Drawing.Point(15, 15)
        Me.checkAmenazasDetect.Name = "checkAmenazasDetect"
        Me.checkAmenazasDetect.Size = New System.Drawing.Size(548, 16)
        Me.checkAmenazasDetect.TabIndex = 14
        Me.checkAmenazasDetect.Text = "Amenazas detectadas"
        '
        'tabNotify
        '
        Me.tabNotify.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabNotify.Controls.Add(Me.checkReprodSounds)
        Me.tabNotify.Controls.Add(Me.checkResultadoAna)
        Me.tabNotify.Controls.Add(Me.checkFilesMoveToQuar)
        Me.tabNotify.Controls.Add(Me.checkUpdatedSuccess)
        Me.tabNotify.Controls.Add(Me.checkNoUpdated)
        Me.tabNotify.Controls.Add(Me.checkAlertMess)
        Me.tabNotify.Location = New System.Drawing.Point(4, 25)
        Me.tabNotify.Name = "tabNotify"
        Me.tabNotify.Size = New System.Drawing.Size(583, 286)
        Me.tabNotify.TabIndex = 4
        Me.tabNotify.Text = "Notificación"
        '
        'checkReprodSounds
        '
        Me.checkReprodSounds.Checked = False
        Me.checkReprodSounds.Location = New System.Drawing.Point(15, 125)
        Me.checkReprodSounds.Name = "checkReprodSounds"
        Me.checkReprodSounds.Size = New System.Drawing.Size(548, 16)
        Me.checkReprodSounds.TabIndex = 22
        Me.checkReprodSounds.Text = "Reproducir alertas sonoras"
        '
        'checkResultadoAna
        '
        Me.checkResultadoAna.Checked = False
        Me.checkResultadoAna.Location = New System.Drawing.Point(15, 103)
        Me.checkResultadoAna.Name = "checkResultadoAna"
        Me.checkResultadoAna.Size = New System.Drawing.Size(548, 16)
        Me.checkResultadoAna.TabIndex = 21
        Me.checkResultadoAna.Text = "Resultado de análisis"
        '
        'checkFilesMoveToQuar
        '
        Me.checkFilesMoveToQuar.Checked = False
        Me.checkFilesMoveToQuar.Location = New System.Drawing.Point(15, 81)
        Me.checkFilesMoveToQuar.Name = "checkFilesMoveToQuar"
        Me.checkFilesMoveToQuar.Size = New System.Drawing.Size(548, 16)
        Me.checkFilesMoveToQuar.TabIndex = 20
        Me.checkFilesMoveToQuar.Text = "Archivos movidos a cuarentena"
        '
        'checkUpdatedSuccess
        '
        Me.checkUpdatedSuccess.Checked = False
        Me.checkUpdatedSuccess.Location = New System.Drawing.Point(15, 59)
        Me.checkUpdatedSuccess.Name = "checkUpdatedSuccess"
        Me.checkUpdatedSuccess.Size = New System.Drawing.Size(548, 16)
        Me.checkUpdatedSuccess.TabIndex = 19
        Me.checkUpdatedSuccess.Text = "Antivirus actualizado con exito"
        '
        'checkNoUpdated
        '
        Me.checkNoUpdated.Checked = False
        Me.checkNoUpdated.Location = New System.Drawing.Point(15, 37)
        Me.checkNoUpdated.Name = "checkNoUpdated"
        Me.checkNoUpdated.Size = New System.Drawing.Size(548, 16)
        Me.checkNoUpdated.TabIndex = 18
        Me.checkNoUpdated.Text = "Antivirus desactualizado"
        '
        'checkAlertMess
        '
        Me.checkAlertMess.Checked = False
        Me.checkAlertMess.Location = New System.Drawing.Point(15, 15)
        Me.checkAlertMess.Name = "checkAlertMess"
        Me.checkAlertMess.Size = New System.Drawing.Size(548, 16)
        Me.checkAlertMess.TabIndex = 17
        Me.checkAlertMess.Text = "Alertas y mensajes importantes"
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 415)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSettings"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.ThirteenTabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabRegistry.ResumeLayout(False)
        Me.tabRegistry.PerformLayout()
        Me.tabNotify.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticTheme1 As DarkTheme
    Friend WithEvents MysticClose1 As DarkClose
    Friend WithEvents btnCancelar As DarkButton
    Friend WithEvents btnAceptar As DarkButton
    Friend WithEvents ThirteenTabControl1 As DarkTabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents checkStartSystem As DarkCheckBox
    Friend WithEvents tabRegistry As System.Windows.Forms.TabPage
    Friend WithEvents tabNotify As System.Windows.Forms.TabPage
    Friend WithEvents comboDetectFilesSuspect As DarkComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents checkCreateProtUSB As DarkCheckBox
    Friend WithEvents checkOpenDevice As DarkCheckBox
    Friend WithEvents comboDetectMalware As DarkComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents checkShowFFHidden As DarkCheckBox
    Friend WithEvents checkCreateProtHDD As DarkCheckBox
    Friend WithEvents checkFindNewsUpdates As DarkCheckBox
    Friend WithEvents checkCopyLastUpdate As DarkCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numRegSizeQuar As DarkTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents checkSucesos As DarkCheckBox
    Friend WithEvents checkExplorePC As DarkCheckBox
    Friend WithEvents checkDisposConect As DarkCheckBox
    Friend WithEvents checkAmenazasDetect As DarkCheckBox
    Friend WithEvents checkReprodSounds As DarkCheckBox
    Friend WithEvents checkResultadoAna As DarkCheckBox
    Friend WithEvents checkFilesMoveToQuar As DarkCheckBox
    Friend WithEvents checkUpdatedSuccess As DarkCheckBox
    Friend WithEvents checkNoUpdated As DarkCheckBox
    Friend WithEvents checkAlertMess As DarkCheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

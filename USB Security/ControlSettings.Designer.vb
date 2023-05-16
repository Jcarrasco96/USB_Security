Imports Theme

<CompilerServices.DesignerGenerated()>
Partial Class ControlSettings
    Inherits UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DarkTabControl1 = New Theme.DarkTabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.numRegSizeQuar = New Theme.DarkTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboDetectFilesSuspect = New Theme.DarkComboBox()
        Me.comboDetectMalware = New Theme.DarkComboBox()
        Me.checkCopyLastUpdate = New Theme.DarkCheckBox()
        Me.checkFindNewsUpdates = New Theme.DarkCheckBox()
        Me.checkShowFFHidden = New Theme.DarkCheckBox()
        Me.checkCreateProtHDD = New Theme.DarkCheckBox()
        Me.checkCreateProtUSB = New Theme.DarkCheckBox()
        Me.checkOpenDevice = New Theme.DarkCheckBox()
        Me.checkStartSystem = New Theme.DarkCheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabRegistry = New System.Windows.Forms.TabPage()
        Me.checkSucesos = New Theme.DarkCheckBox()
        Me.checkExplorePC = New Theme.DarkCheckBox()
        Me.checkDisposConect = New Theme.DarkCheckBox()
        Me.checkAmenazasDetect = New Theme.DarkCheckBox()
        Me.tabNotify = New System.Windows.Forms.TabPage()
        Me.checkReprodSounds = New Theme.DarkCheckBox()
        Me.checkResultadoAna = New Theme.DarkCheckBox()
        Me.checkFilesMoveToQuar = New Theme.DarkCheckBox()
        Me.checkUpdatedSuccess = New Theme.DarkCheckBox()
        Me.checkNoUpdated = New Theme.DarkCheckBox()
        Me.checkAlertMess = New Theme.DarkCheckBox()
        Me.btnAccept = New Theme.DarkButton()
        Me.btnCancel = New Theme.DarkButton()
        Me.DarkTabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabRegistry.SuspendLayout()
        Me.tabNotify.SuspendLayout()
        Me.SuspendLayout()
        '
        'DarkTabControl1
        '
        Me.DarkTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DarkTabControl1.Controls.Add(Me.tabGeneral)
        Me.DarkTabControl1.Controls.Add(Me.tabRegistry)
        Me.DarkTabControl1.Controls.Add(Me.tabNotify)
        Me.DarkTabControl1.ForeColor = System.Drawing.Color.Black
        Me.DarkTabControl1.Location = New System.Drawing.Point(6, 3)
        Me.DarkTabControl1.Name = "DarkTabControl1"
        Me.DarkTabControl1.SelectedIndex = 0
        Me.DarkTabControl1.Size = New System.Drawing.Size(591, 358)
        Me.DarkTabControl1.TabIndex = 10
        Me.DarkTabControl1.TabTextColor = System.Drawing.SystemColors.Control
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
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
        Me.tabGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(10)
        Me.tabGeneral.Size = New System.Drawing.Size(583, 329)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "General"
        '
        'numRegSizeQuar
        '
        Me.numRegSizeQuar.BackColor = System.Drawing.Color.Transparent
        Me.numRegSizeQuar.Location = New System.Drawing.Point(285, 238)
        Me.numRegSizeQuar.MaxLength = 32767
        Me.numRegSizeQuar.Multiline = False
        Me.numRegSizeQuar.Name = "numRegSizeQuar"
        Me.numRegSizeQuar.ReadOnly = False
        Me.numRegSizeQuar.Size = New System.Drawing.Size(94, 27)
        Me.numRegSizeQuar.TabIndex = 34
        Me.numRegSizeQuar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numRegSizeQuar.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(282, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "0 - no borrar nunca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(385, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mb"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(13, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Eliminar archivos de la cuarentena cuando sobrepasen"
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
        Me.comboDetectFilesSuspect.Location = New System.Drawing.Point(285, 206)
        Me.comboDetectFilesSuspect.Name = "comboDetectFilesSuspect"
        Me.comboDetectFilesSuspect.Size = New System.Drawing.Size(211, 26)
        Me.comboDetectFilesSuspect.TabIndex = 30
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
        Me.comboDetectMalware.Location = New System.Drawing.Point(285, 174)
        Me.comboDetectMalware.Name = "comboDetectMalware"
        Me.comboDetectMalware.Size = New System.Drawing.Size(211, 26)
        Me.comboDetectMalware.TabIndex = 29
        '
        'checkCopyLastUpdate
        '
        Me.checkCopyLastUpdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkCopyLastUpdate.Checked = False
        Me.checkCopyLastUpdate.Location = New System.Drawing.Point(13, 128)
        Me.checkCopyLastUpdate.Name = "checkCopyLastUpdate"
        Me.checkCopyLastUpdate.Size = New System.Drawing.Size(557, 16)
        Me.checkCopyLastUpdate.TabIndex = 28
        Me.checkCopyLastUpdate.Text = "Copiar la última actualización a los dispositivos externos que se conecten a este" &
    " PC"
        '
        'checkFindNewsUpdates
        '
        Me.checkFindNewsUpdates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkFindNewsUpdates.Checked = False
        Me.checkFindNewsUpdates.Location = New System.Drawing.Point(13, 151)
        Me.checkFindNewsUpdates.Name = "checkFindNewsUpdates"
        Me.checkFindNewsUpdates.Size = New System.Drawing.Size(557, 16)
        Me.checkFindNewsUpdates.TabIndex = 27
        Me.checkFindNewsUpdates.Text = "Buscar nuevas actualizaciones en los dispositivos"
        '
        'checkShowFFHidden
        '
        Me.checkShowFFHidden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkShowFFHidden.Checked = False
        Me.checkShowFFHidden.Location = New System.Drawing.Point(13, 105)
        Me.checkShowFFHidden.Name = "checkShowFFHidden"
        Me.checkShowFFHidden.Size = New System.Drawing.Size(557, 16)
        Me.checkShowFFHidden.TabIndex = 26
        Me.checkShowFFHidden.Text = "Mostrar archivos y carpetas ocultas en los dispositivos"
        '
        'checkCreateProtHDD
        '
        Me.checkCreateProtHDD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkCreateProtHDD.Checked = False
        Me.checkCreateProtHDD.Location = New System.Drawing.Point(13, 82)
        Me.checkCreateProtHDD.Name = "checkCreateProtHDD"
        Me.checkCreateProtHDD.Size = New System.Drawing.Size(557, 16)
        Me.checkCreateProtHDD.TabIndex = 25
        Me.checkCreateProtHDD.Text = "Crear protección en unidades HDD"
        '
        'checkCreateProtUSB
        '
        Me.checkCreateProtUSB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkCreateProtUSB.Checked = False
        Me.checkCreateProtUSB.Location = New System.Drawing.Point(13, 59)
        Me.checkCreateProtUSB.Name = "checkCreateProtUSB"
        Me.checkCreateProtUSB.Size = New System.Drawing.Size(557, 16)
        Me.checkCreateProtUSB.TabIndex = 24
        Me.checkCreateProtUSB.Text = "Crear protección en unidades USB"
        '
        'checkOpenDevice
        '
        Me.checkOpenDevice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkOpenDevice.Checked = False
        Me.checkOpenDevice.Location = New System.Drawing.Point(13, 36)
        Me.checkOpenDevice.Name = "checkOpenDevice"
        Me.checkOpenDevice.Size = New System.Drawing.Size(557, 16)
        Me.checkOpenDevice.TabIndex = 23
        Me.checkOpenDevice.Text = "Abrir dispositivos luego de analizarlos"
        '
        'checkStartSystem
        '
        Me.checkStartSystem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkStartSystem.Checked = False
        Me.checkStartSystem.Location = New System.Drawing.Point(13, 13)
        Me.checkStartSystem.Name = "checkStartSystem"
        Me.checkStartSystem.Size = New System.Drawing.Size(557, 16)
        Me.checkStartSystem.TabIndex = 22
        Me.checkStartSystem.Text = "Iniciar con el sistema"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
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
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(13, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Detección de archivos sospechosos"
        '
        'tabRegistry
        '
        Me.tabRegistry.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabRegistry.Controls.Add(Me.checkSucesos)
        Me.tabRegistry.Controls.Add(Me.checkExplorePC)
        Me.tabRegistry.Controls.Add(Me.checkDisposConect)
        Me.tabRegistry.Controls.Add(Me.checkAmenazasDetect)
        Me.tabRegistry.Location = New System.Drawing.Point(4, 25)
        Me.tabRegistry.Name = "tabRegistry"
        Me.tabRegistry.Padding = New System.Windows.Forms.Padding(10)
        Me.tabRegistry.Size = New System.Drawing.Size(583, 329)
        Me.tabRegistry.TabIndex = 3
        Me.tabRegistry.Text = "Registro"
        '
        'checkSucesos
        '
        Me.checkSucesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkSucesos.Checked = False
        Me.checkSucesos.Location = New System.Drawing.Point(13, 82)
        Me.checkSucesos.Name = "checkSucesos"
        Me.checkSucesos.Size = New System.Drawing.Size(557, 16)
        Me.checkSucesos.TabIndex = 26
        Me.checkSucesos.Text = "Sucesos"
        '
        'checkExplorePC
        '
        Me.checkExplorePC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkExplorePC.Checked = False
        Me.checkExplorePC.Location = New System.Drawing.Point(13, 59)
        Me.checkExplorePC.Name = "checkExplorePC"
        Me.checkExplorePC.Size = New System.Drawing.Size(557, 16)
        Me.checkExplorePC.TabIndex = 25
        Me.checkExplorePC.Text = "Exploración del equipo"
        '
        'checkDisposConect
        '
        Me.checkDisposConect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkDisposConect.Checked = False
        Me.checkDisposConect.Location = New System.Drawing.Point(13, 36)
        Me.checkDisposConect.Name = "checkDisposConect"
        Me.checkDisposConect.Size = New System.Drawing.Size(557, 16)
        Me.checkDisposConect.TabIndex = 24
        Me.checkDisposConect.Text = "Dispositivos conectados"
        '
        'checkAmenazasDetect
        '
        Me.checkAmenazasDetect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkAmenazasDetect.Checked = False
        Me.checkAmenazasDetect.Location = New System.Drawing.Point(13, 13)
        Me.checkAmenazasDetect.Name = "checkAmenazasDetect"
        Me.checkAmenazasDetect.Size = New System.Drawing.Size(557, 16)
        Me.checkAmenazasDetect.TabIndex = 23
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
        Me.tabNotify.Padding = New System.Windows.Forms.Padding(10)
        Me.tabNotify.Size = New System.Drawing.Size(583, 329)
        Me.tabNotify.TabIndex = 4
        Me.tabNotify.Text = "Notificación"
        '
        'checkReprodSounds
        '
        Me.checkReprodSounds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkReprodSounds.Checked = False
        Me.checkReprodSounds.Location = New System.Drawing.Point(13, 128)
        Me.checkReprodSounds.Name = "checkReprodSounds"
        Me.checkReprodSounds.Size = New System.Drawing.Size(557, 16)
        Me.checkReprodSounds.TabIndex = 28
        Me.checkReprodSounds.Text = "Reproducir alertas sonoras"
        '
        'checkResultadoAna
        '
        Me.checkResultadoAna.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkResultadoAna.Checked = False
        Me.checkResultadoAna.Location = New System.Drawing.Point(13, 105)
        Me.checkResultadoAna.Name = "checkResultadoAna"
        Me.checkResultadoAna.Size = New System.Drawing.Size(557, 16)
        Me.checkResultadoAna.TabIndex = 27
        Me.checkResultadoAna.Text = "Resultado de análisis"
        '
        'checkFilesMoveToQuar
        '
        Me.checkFilesMoveToQuar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkFilesMoveToQuar.Checked = False
        Me.checkFilesMoveToQuar.Location = New System.Drawing.Point(13, 82)
        Me.checkFilesMoveToQuar.Name = "checkFilesMoveToQuar"
        Me.checkFilesMoveToQuar.Size = New System.Drawing.Size(557, 16)
        Me.checkFilesMoveToQuar.TabIndex = 26
        Me.checkFilesMoveToQuar.Text = "Archivos movidos a cuarentena"
        '
        'checkUpdatedSuccess
        '
        Me.checkUpdatedSuccess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkUpdatedSuccess.Checked = False
        Me.checkUpdatedSuccess.Location = New System.Drawing.Point(13, 59)
        Me.checkUpdatedSuccess.Name = "checkUpdatedSuccess"
        Me.checkUpdatedSuccess.Size = New System.Drawing.Size(557, 16)
        Me.checkUpdatedSuccess.TabIndex = 25
        Me.checkUpdatedSuccess.Text = "Antivirus actualizado con exito"
        '
        'checkNoUpdated
        '
        Me.checkNoUpdated.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkNoUpdated.Checked = False
        Me.checkNoUpdated.Location = New System.Drawing.Point(13, 36)
        Me.checkNoUpdated.Name = "checkNoUpdated"
        Me.checkNoUpdated.Size = New System.Drawing.Size(557, 16)
        Me.checkNoUpdated.TabIndex = 24
        Me.checkNoUpdated.Text = "Antivirus desactualizado"
        '
        'checkAlertMess
        '
        Me.checkAlertMess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkAlertMess.Checked = False
        Me.checkAlertMess.Location = New System.Drawing.Point(13, 13)
        Me.checkAlertMess.Name = "checkAlertMess"
        Me.checkAlertMess.Size = New System.Drawing.Size(557, 16)
        Me.checkAlertMess.TabIndex = 23
        Me.checkAlertMess.Text = "Alertas y mensajes importantes"
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.Location = New System.Drawing.Point(421, 367)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(85, 30)
        Me.btnAccept.TabIndex = 9
        Me.btnAccept.Text = "Aceptar"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(512, 367)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 30)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancelar"
        '
        'ControlSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.DarkTabControl1)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "ControlSettings"
        Me.Size = New System.Drawing.Size(600, 400)
        Me.DarkTabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        Me.tabRegistry.ResumeLayout(False)
        Me.tabNotify.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabRegistry As TabPage
    Friend WithEvents checkSucesos As DarkCheckBox
    Friend WithEvents checkExplorePC As DarkCheckBox
    Friend WithEvents checkDisposConect As DarkCheckBox
    Friend WithEvents checkAmenazasDetect As DarkCheckBox
    Friend WithEvents tabNotify As TabPage
    Friend WithEvents checkReprodSounds As DarkCheckBox
    Friend WithEvents checkResultadoAna As DarkCheckBox
    Friend WithEvents checkFilesMoveToQuar As DarkCheckBox
    Friend WithEvents checkUpdatedSuccess As DarkCheckBox
    Friend WithEvents checkNoUpdated As DarkCheckBox
    Friend WithEvents checkAlertMess As DarkCheckBox
    Friend WithEvents btnCancel As DarkButton
    Friend WithEvents btnAccept As DarkButton
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents numRegSizeQuar As DarkTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboDetectFilesSuspect As Theme.DarkComboBox
    Friend WithEvents comboDetectMalware As Theme.DarkComboBox
    Friend WithEvents checkCopyLastUpdate As DarkCheckBox
    Friend WithEvents checkFindNewsUpdates As DarkCheckBox
    Friend WithEvents checkShowFFHidden As DarkCheckBox
    Friend WithEvents checkCreateProtHDD As DarkCheckBox
    Friend WithEvents checkCreateProtUSB As DarkCheckBox
    Friend WithEvents checkOpenDevice As DarkCheckBox
    Friend WithEvents checkStartSystem As DarkCheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DarkTabControl1 As Theme.DarkTabControl
End Class

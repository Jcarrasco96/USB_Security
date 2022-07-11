<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFastScan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFastScan))
        Me.bwScanner = New System.ComponentModel.BackgroundWorker()
        Me.tipLabels = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCritic = New System.Windows.Forms.Label()
        Me.lblRegistry = New System.Windows.Forms.Label()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblBases = New System.Windows.Forms.Label()
        Me.MysticTheme1 = New USB_Security.MysticTheme()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMalwares = New System.Windows.Forms.Label()
        Me.MysticButton1 = New USB_Security.MysticButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.MysticClose1 = New USB_Security.MysticClose()
        Me.MysticTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bwScanner
        '
        '
        'lblCritic
        '
        Me.lblCritic.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblCritic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritic.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCritic.Image = Global.USB_Security.My.Resources.Resources._7_1_fw
        Me.lblCritic.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCritic.Location = New System.Drawing.Point(514, 180)
        Me.lblCritic.Name = "lblCritic"
        Me.lblCritic.Size = New System.Drawing.Size(94, 74)
        Me.lblCritic.TabIndex = 10
        Me.lblCritic.Text = "0"
        Me.lblCritic.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tipLabels.SetToolTip(Me.lblCritic, "Zonas críticas")
        '
        'lblRegistry
        '
        Me.lblRegistry.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblRegistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistry.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRegistry.Image = Global.USB_Security.My.Resources.Resources._6_1_fw
        Me.lblRegistry.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblRegistry.Location = New System.Drawing.Point(414, 180)
        Me.lblRegistry.Name = "lblRegistry"
        Me.lblRegistry.Size = New System.Drawing.Size(94, 74)
        Me.lblRegistry.TabIndex = 9
        Me.lblRegistry.Text = "0"
        Me.lblRegistry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tipLabels.SetToolTip(Me.lblRegistry, "Registro de Windows")
        '
        'lblProcess
        '
        Me.lblProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcess.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProcess.Image = Global.USB_Security.My.Resources.Resources._5_1_fw
        Me.lblProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblProcess.Location = New System.Drawing.Point(314, 180)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(94, 74)
        Me.lblProcess.TabIndex = 8
        Me.lblProcess.Text = "0"
        Me.lblProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tipLabels.SetToolTip(Me.lblProcess, "Procesos del sistema")
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStart.Image = Global.USB_Security.My.Resources.Resources._2_1_fw
        Me.lblStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblStart.Location = New System.Drawing.Point(113, 180)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(94, 74)
        Me.lblStart.TabIndex = 7
        Me.lblStart.Text = "0"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tipLabels.SetToolTip(Me.lblStart, "Objetos de inicio")
        '
        'lblServices
        '
        Me.lblServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.ForeColor = System.Drawing.SystemColors.Control
        Me.lblServices.Image = Global.USB_Security.My.Resources.Resources._4_1_fw
        Me.lblServices.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblServices.Location = New System.Drawing.Point(213, 180)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(94, 74)
        Me.lblServices.TabIndex = 6
        Me.lblServices.Text = "0"
        Me.lblServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tipLabels.SetToolTip(Me.lblServices, "Servicios del sistema")
        '
        'lblBases
        '
        Me.lblBases.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblBases.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBases.ForeColor = System.Drawing.SystemColors.Control
        Me.lblBases.Image = Global.USB_Security.My.Resources.Resources._1_1_fw
        Me.lblBases.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBases.Location = New System.Drawing.Point(13, 180)
        Me.lblBases.Name = "lblBases"
        Me.lblBases.Size = New System.Drawing.Size(94, 74)
        Me.lblBases.TabIndex = 5
        Me.lblBases.Text = "0"
        Me.lblBases.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tipLabels.SetToolTip(Me.lblBases, "Bases del programa")
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.lblTotal)
        Me.MysticTheme1.Controls.Add(Me.lblCritic)
        Me.MysticTheme1.Controls.Add(Me.lblRegistry)
        Me.MysticTheme1.Controls.Add(Me.lblProcess)
        Me.MysticTheme1.Controls.Add(Me.lblStart)
        Me.MysticTheme1.Controls.Add(Me.lblServices)
        Me.MysticTheme1.Controls.Add(Me.lblBases)
        Me.MysticTheme1.Controls.Add(Me.lblMalwares)
        Me.MysticTheme1.Controls.Add(Me.MysticButton1)
        Me.MysticTheme1.Controls.Add(Me.lblStatus)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = True
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(620, 400)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Análisis rápido"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(17, 254)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(591, 101)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Objetos analizados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMalwares
        '
        Me.lblMalwares.BackColor = System.Drawing.Color.Transparent
        Me.lblMalwares.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMalwares.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMalwares.Location = New System.Drawing.Point(12, 101)
        Me.lblMalwares.Name = "lblMalwares"
        Me.lblMalwares.Size = New System.Drawing.Size(596, 55)
        Me.lblMalwares.TabIndex = 4
        Me.lblMalwares.Text = "Amenazs detectadas: 0"
        Me.lblMalwares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MysticButton1
        '
        Me.MysticButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MysticButton1.Location = New System.Drawing.Point(250, 358)
        Me.MysticButton1.Name = "MysticButton1"
        Me.MysticButton1.Size = New System.Drawing.Size(120, 30)
        Me.MysticButton1.TabIndex = 3
        Me.MysticButton1.Text = "Cancelar"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(12, 46)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(596, 55)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Cargando componentes, por favor espere..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MysticClose1
        '
        Me.MysticClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MysticClose1.Location = New System.Drawing.Point(590, 6)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(24, 24)
        Me.MysticClose1.TabIndex = 1
        Me.MysticClose1.Text = "MysticClose1"
        '
        'FormFastScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 400)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFastScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis rapido"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticTheme1 As USB_Security.MysticTheme
    Friend WithEvents MysticClose1 As USB_Security.MysticClose
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents bwScanner As System.ComponentModel.BackgroundWorker
    Friend WithEvents MysticButton1 As USB_Security.MysticButton
    Friend WithEvents lblMalwares As System.Windows.Forms.Label
    Friend WithEvents lblBases As System.Windows.Forms.Label
    Friend WithEvents lblCritic As System.Windows.Forms.Label
    Friend WithEvents lblRegistry As System.Windows.Forms.Label
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblServices As System.Windows.Forms.Label
    Friend WithEvents tipLabels As System.Windows.Forms.ToolTip
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class

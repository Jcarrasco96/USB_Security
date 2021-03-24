<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuQuickScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFullScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuarantine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEnableProt = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisableProt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LoadVirusHashes = New System.ComponentModel.BackgroundWorker()
        Me.ttipButtons = New System.Windows.Forms.ToolTip(Me.components)
        Me.MysticTheme1 = New USB_Security.MysticTheme()
        Me.btnLogs = New USB_Security.MysticButton()
        Me.btnSettings = New USB_Security.MysticButton()
        Me.btnUpdate = New USB_Security.MysticButton()
        Me.btnScan = New USB_Security.MysticButton()
        Me.labelInfo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MysticClose1 = New USB_Security.MysticClose()
        Me.mnuNotify.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MysticTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'notify
        '
        Me.notify.ContextMenuStrip = Me.mnuNotify
        Me.notify.Visible = True
        '
        'mnuNotify
        '
        Me.mnuNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuQuickScan, Me.mnuFullScan, Me.ToolStripSeparator2, Me.mnuUpdate, Me.mnuQuarantine, Me.mnuSettings, Me.ToolStripSeparator1, Me.mnuEnableProt, Me.mnuDisableProt, Me.ToolStripSeparator3, Me.mnuAbout, Me.mnuExit})
        Me.mnuNotify.Name = "mnuNotify"
        Me.mnuNotify.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mnuNotify.Size = New System.Drawing.Size(264, 220)
        '
        'mnuQuickScan
        '
        Me.mnuQuickScan.Name = "mnuQuickScan"
        Me.mnuQuickScan.Size = New System.Drawing.Size(263, 22)
        Me.mnuQuickScan.Text = "Analizar equipo (rápido)"
        '
        'mnuFullScan
        '
        Me.mnuFullScan.Name = "mnuFullScan"
        Me.mnuFullScan.Size = New System.Drawing.Size(263, 22)
        Me.mnuFullScan.Text = "Analizar equipo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(260, 6)
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(263, 22)
        Me.mnuUpdate.Text = "Actualizar"
        '
        'mnuQuarantine
        '
        Me.mnuQuarantine.Name = "mnuQuarantine"
        Me.mnuQuarantine.Size = New System.Drawing.Size(263, 22)
        Me.mnuQuarantine.Text = "Cuarentena"
        '
        'mnuSettings
        '
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(263, 22)
        Me.mnuSettings.Text = "Ajustes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(260, 6)
        '
        'mnuEnableProt
        '
        Me.mnuEnableProt.Name = "mnuEnableProt"
        Me.mnuEnableProt.Size = New System.Drawing.Size(263, 22)
        Me.mnuEnableProt.Text = "Habilitar protección permanente"
        '
        'mnuDisableProt
        '
        Me.mnuDisableProt.Name = "mnuDisableProt"
        Me.mnuDisableProt.Size = New System.Drawing.Size(263, 22)
        Me.mnuDisableProt.Text = "Deshabilitar protección permanente"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(260, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(263, 22)
        Me.mnuAbout.Text = "Acerca de..."
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(263, 22)
        Me.mnuExit.Text = "Salir"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.IncludeSubdirectories = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LoadVirusHashes
        '
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.btnLogs)
        Me.MysticTheme1.Controls.Add(Me.btnSettings)
        Me.MysticTheme1.Controls.Add(Me.btnUpdate)
        Me.MysticTheme1.Controls.Add(Me.btnScan)
        Me.MysticTheme1.Controls.Add(Me.labelInfo)
        Me.MysticTheme1.Controls.Add(Me.PictureBox1)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = False
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(250, 400)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "USB Security"
        '
        'btnLogs
        '
        Me.btnLogs.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_logs
        Me.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogs.Location = New System.Drawing.Point(131, 340)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(48, 48)
        Me.btnLogs.TabIndex = 10
        Me.ttipButtons.SetToolTip(Me.btnLogs, "Informes")
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_settings
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Location = New System.Drawing.Point(190, 340)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(48, 48)
        Me.btnSettings.TabIndex = 9
        Me.ttipButtons.SetToolTip(Me.btnSettings, "Ajustes")
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_update
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Location = New System.Drawing.Point(71, 340)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(48, 48)
        Me.btnUpdate.TabIndex = 8
        Me.ttipButtons.SetToolTip(Me.btnUpdate, "Actualizar")
        '
        'btnScan
        '
        Me.btnScan.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_scan
        Me.btnScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScan.Location = New System.Drawing.Point(12, 340)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(48, 48)
        Me.btnScan.TabIndex = 7
        Me.ttipButtons.SetToolTip(Me.btnScan, "Analizar equipo (rápido)")
        '
        'labelInfo
        '
        Me.labelInfo.BackColor = System.Drawing.Color.Transparent
        Me.labelInfo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelInfo.Location = New System.Drawing.Point(12, 271)
        Me.labelInfo.Margin = New System.Windows.Forms.Padding(3)
        Me.labelInfo.Name = "labelInfo"
        Me.labelInfo.Size = New System.Drawing.Size(226, 52)
        Me.labelInfo.TabIndex = 6
        Me.labelInfo.Text = "Cargando..."
        Me.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MysticClose1
        '
        Me.MysticClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MysticClose1.Location = New System.Drawing.Point(226, 12)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(12, 12)
        Me.MysticClose1.TabIndex = 0
        Me.MysticClose1.Text = "MysticClose1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 400)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Opacity = 0.98R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "USBSecurity - Main"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.mnuNotify.ResumeLayout(False)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MysticTheme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticTheme1 As USB_Security.MysticTheme
    Friend WithEvents MysticClose1 As USB_Security.MysticClose
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents notify As System.Windows.Forms.NotifyIcon
    Friend WithEvents mnuNotify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents labelInfo As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LoadVirusHashes As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnLogs As USB_Security.MysticButton
    Friend WithEvents btnSettings As USB_Security.MysticButton
    Friend WithEvents btnUpdate As USB_Security.MysticButton
    Friend WithEvents btnScan As USB_Security.MysticButton
    Friend WithEvents mnuEnableProt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDisableProt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuarantine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuickScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFullScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttipButtons As System.Windows.Forms.ToolTip

End Class

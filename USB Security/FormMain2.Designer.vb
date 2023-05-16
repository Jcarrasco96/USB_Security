<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain2
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
        Me.DarkTheme1 = New Theme.DarkTheme()
        Me.panelCodes = New System.Windows.Forms.Panel()
        Me.DarkClose1 = New Theme.DarkClose()
        Me.ToolTipFormLogs = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelRounded1 = New USB_Security.PanelRounded()
        Me.btnFastScan = New Theme.DarkButton()
        Me.btnMalwares = New Theme.DarkButton()
        Me.btnSettings = New Theme.DarkButton()
        Me.btnAbout = New Theme.DarkButton()
        Me.btnQuar = New Theme.DarkButton()
        Me.btnLogs = New Theme.DarkButton()
        Me.DarkTheme1.SuspendLayout()
        Me.PanelRounded1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DarkTheme1
        '
        Me.DarkTheme1.Controls.Add(Me.panelCodes)
        Me.DarkTheme1.Controls.Add(Me.DarkClose1)
        Me.DarkTheme1.Controls.Add(Me.PanelRounded1)
        Me.DarkTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DarkTheme1.Image = Nothing
        Me.DarkTheme1.Location = New System.Drawing.Point(0, 0)
        Me.DarkTheme1.Movible = True
        Me.DarkTheme1.Name = "DarkTheme1"
        Me.DarkTheme1.Size = New System.Drawing.Size(884, 561)
        Me.DarkTheme1.TabIndex = 0
        Me.DarkTheme1.Text = "USB Security"
        '
        'panelCodes
        '
        Me.panelCodes.BackColor = System.Drawing.Color.Transparent
        Me.panelCodes.Location = New System.Drawing.Point(88, 46)
        Me.panelCodes.Name = "panelCodes"
        Me.panelCodes.Size = New System.Drawing.Size(784, 503)
        Me.panelCodes.TabIndex = 2
        '
        'DarkClose1
        '
        Me.DarkClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DarkClose1.BackColor = System.Drawing.Color.Transparent
        Me.DarkClose1.Location = New System.Drawing.Point(854, 6)
        Me.DarkClose1.Name = "DarkClose1"
        Me.DarkClose1.Size = New System.Drawing.Size(24, 24)
        Me.DarkClose1.TabIndex = 1
        Me.DarkClose1.Text = "DarkClose1"
        '
        'PanelRounded1
        '
        Me.PanelRounded1.BackColor = System.Drawing.SystemColors.Control
        Me.PanelRounded1.Controls.Add(Me.btnFastScan)
        Me.PanelRounded1.Controls.Add(Me.btnMalwares)
        Me.PanelRounded1.Controls.Add(Me.btnSettings)
        Me.PanelRounded1.Controls.Add(Me.btnAbout)
        Me.PanelRounded1.Controls.Add(Me.btnQuar)
        Me.PanelRounded1.Controls.Add(Me.btnLogs)
        Me.PanelRounded1.Diameter = 25
        Me.PanelRounded1.Location = New System.Drawing.Point(12, 46)
        Me.PanelRounded1.Name = "PanelRounded1"
        Me.PanelRounded1.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelRounded1.Size = New System.Drawing.Size(70, 503)
        Me.PanelRounded1.TabIndex = 0
        '
        'btnFastScan
        '
        Me.btnFastScan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFastScan.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_scan
        Me.btnFastScan.Location = New System.Drawing.Point(13, 13)
        Me.btnFastScan.Name = "btnFastScan"
        Me.btnFastScan.Size = New System.Drawing.Size(44, 44)
        Me.btnFastScan.TabIndex = 6
        Me.ToolTipFormLogs.SetToolTip(Me.btnFastScan, "Amenazas detectadas")
        '
        'btnMalwares
        '
        Me.btnMalwares.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMalwares.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_malware
        Me.btnMalwares.Location = New System.Drawing.Point(13, 163)
        Me.btnMalwares.Name = "btnMalwares"
        Me.btnMalwares.Size = New System.Drawing.Size(44, 44)
        Me.btnMalwares.TabIndex = 5
        Me.ToolTipFormLogs.SetToolTip(Me.btnMalwares, "Amenazas detectadas")
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_settings
        Me.btnSettings.Location = New System.Drawing.Point(13, 396)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(44, 44)
        Me.btnSettings.TabIndex = 4
        Me.ToolTipFormLogs.SetToolTip(Me.btnSettings, "Ajustes")
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_about
        Me.btnAbout.Location = New System.Drawing.Point(13, 446)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(44, 44)
        Me.btnAbout.TabIndex = 3
        Me.ToolTipFormLogs.SetToolTip(Me.btnAbout, "Acerca de...")
        '
        'btnQuar
        '
        Me.btnQuar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuar.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_quar
        Me.btnQuar.Location = New System.Drawing.Point(13, 113)
        Me.btnQuar.Name = "btnQuar"
        Me.btnQuar.Size = New System.Drawing.Size(44, 44)
        Me.btnQuar.TabIndex = 1
        Me.ToolTipFormLogs.SetToolTip(Me.btnQuar, "Cuarentena")
        '
        'btnLogs
        '
        Me.btnLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogs.BackgroundImage = Global.USB_Security.My.Resources.Resources.ic_logs
        Me.btnLogs.Location = New System.Drawing.Point(13, 63)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(44, 44)
        Me.btnLogs.TabIndex = 0
        Me.ToolTipFormLogs.SetToolTip(Me.btnLogs, "Informes")
        '
        'FormMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.DarkTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMain2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain2"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.DarkTheme1.ResumeLayout(False)
        Me.PanelRounded1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DarkTheme1 As Theme.DarkTheme
    Friend WithEvents PanelRounded1 As PanelRounded
    Friend WithEvents btnLogs As Theme.DarkButton
    Friend WithEvents btnQuar As Theme.DarkButton
    Friend WithEvents DarkClose1 As Theme.DarkClose
    Friend WithEvents btnAbout As Theme.DarkButton
    Friend WithEvents panelCodes As Panel
    Friend WithEvents btnSettings As Theme.DarkButton
    Friend WithEvents ToolTipFormLogs As ToolTip
    Friend WithEvents btnMalwares As Theme.DarkButton
    Friend WithEvents btnFastScan As Theme.DarkButton
End Class

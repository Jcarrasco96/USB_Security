<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Me.Theme1 = New Theme.DarkTheme()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ThemeClose1 = New Theme.DarkClose()
        Me.Theme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Theme1
        '
        Me.Theme1.Controls.Add(Me.labelTitle)
        Me.Theme1.Controls.Add(Me.PictureBox1)
        Me.Theme1.Controls.Add(Me.ThemeClose1)
        Me.Theme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Theme1.Location = New System.Drawing.Point(0, 0)
        Me.Theme1.Movible = True
        Me.Theme1.Name = "Theme1"
        Me.Theme1.Size = New System.Drawing.Size(450, 160)
        Me.Theme1.TabIndex = 0
        Me.Theme1.Text = "Acerca de..."
        '
        'labelTitle
        '
        Me.labelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.labelTitle.Location = New System.Drawing.Point(118, 46)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(320, 100)
        Me.labelTitle.TabIndex = 2
        Me.labelTitle.Text = "USB Security 1.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copyright (c) 2022 Jcarrasco96"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.USB_Security.My.Resources.Resources.icon_success
        Me.PictureBox1.Location = New System.Drawing.Point(12, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ThemeClose1
        '
        Me.ThemeClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThemeClose1.BackColor = System.Drawing.Color.Transparent
        Me.ThemeClose1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ThemeClose1.Location = New System.Drawing.Point(420, 6)
        Me.ThemeClose1.Name = "ThemeClose1"
        Me.ThemeClose1.Size = New System.Drawing.Size(24, 24)
        Me.ThemeClose1.TabIndex = 0
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 160)
        Me.Controls.Add(Me.Theme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAbout"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Theme1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Theme1 As Theme.DarkTheme
    Friend WithEvents ThemeClose1 As Theme.DarkClose
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents labelTitle As System.Windows.Forms.Label
End Class

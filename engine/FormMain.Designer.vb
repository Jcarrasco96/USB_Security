Imports Theme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.FileScanner = New System.ComponentModel.BackgroundWorker()
        Me.MysticTheme1 = New DarkTheme()
        Me.labelLoading = New System.Windows.Forms.Label()
        Me.labelDetect = New System.Windows.Forms.Label()
        Me.MysticClose1 = New DarkClose()
        Me.progressTotal = New DarkProgressBar()
        Me.picDrive = New System.Windows.Forms.PictureBox()
        Me.labelSize = New System.Windows.Forms.Label()
        Me.labelPath = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.MysticTheme1.SuspendLayout()
        CType(Me.picDrive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileScanner
        '
        Me.FileScanner.WorkerReportsProgress = True
        Me.FileScanner.WorkerSupportsCancellation = True
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.labelLoading)
        Me.MysticTheme1.Controls.Add(Me.labelDetect)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Controls.Add(Me.progressTotal)
        Me.MysticTheme1.Controls.Add(Me.picDrive)
        Me.MysticTheme1.Controls.Add(Me.labelSize)
        Me.MysticTheme1.Controls.Add(Me.labelPath)
        Me.MysticTheme1.Controls.Add(Me.labelName)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = True
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(375, 135)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Analizando"
        '
        'labelLoading
        '
        Me.labelLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelLoading.BackColor = System.Drawing.Color.Transparent
        Me.labelLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelLoading.Location = New System.Drawing.Point(66, 66)
        Me.labelLoading.Name = "labelLoading"
        Me.labelLoading.Size = New System.Drawing.Size(297, 13)
        Me.labelLoading.TabIndex = 13
        Me.labelLoading.Text = "Cargando, espere hasta que finalice el proceso..."
        Me.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.labelLoading.Visible = False
        '
        'labelDetect
        '
        Me.labelDetect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelDetect.BackColor = System.Drawing.Color.Transparent
        Me.labelDetect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelDetect.Location = New System.Drawing.Point(227, 88)
        Me.labelDetect.Name = "labelDetect"
        Me.labelDetect.Size = New System.Drawing.Size(135, 13)
        Me.labelDetect.TabIndex = 12
        Me.labelDetect.Text = "Detectados: 0"
        Me.labelDetect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MysticClose1
        '
        Me.MysticClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MysticClose1.Location = New System.Drawing.Point(345, 6)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(24, 24)
        Me.MysticClose1.TabIndex = 11
        Me.MysticClose1.Text = "MysticClose1"
        '
        'progressTotal
        '
        Me.progressTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressTotal.Location = New System.Drawing.Point(12, 113)
        Me.progressTotal.Name = "progressTotal"
        Me.progressTotal.Size = New System.Drawing.Size(350, 10)
        Me.progressTotal.TabIndex = 10
        '
        'picDrive
        '
        Me.picDrive.BackColor = System.Drawing.Color.Transparent
        Me.picDrive.Location = New System.Drawing.Point(12, 44)
        Me.picDrive.Name = "picDrive"
        Me.picDrive.Size = New System.Drawing.Size(48, 57)
        Me.picDrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDrive.TabIndex = 8
        Me.picDrive.TabStop = False
        '
        'labelSize
        '
        Me.labelSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelSize.BackColor = System.Drawing.Color.Transparent
        Me.labelSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelSize.Location = New System.Drawing.Point(66, 88)
        Me.labelSize.Name = "labelSize"
        Me.labelSize.Size = New System.Drawing.Size(155, 13)
        Me.labelSize.TabIndex = 5
        Me.labelSize.Text = "Tamaño: 0 B"
        '
        'labelPath
        '
        Me.labelPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPath.AutoEllipsis = True
        Me.labelPath.BackColor = System.Drawing.Color.Transparent
        Me.labelPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelPath.Location = New System.Drawing.Point(66, 66)
        Me.labelPath.Name = "labelPath"
        Me.labelPath.Size = New System.Drawing.Size(297, 13)
        Me.labelPath.TabIndex = 4
        Me.labelPath.Text = "Ubicación:"
        '
        'labelName
        '
        Me.labelName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelName.AutoEllipsis = True
        Me.labelName.BackColor = System.Drawing.Color.Transparent
        Me.labelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelName.Location = New System.Drawing.Point(66, 44)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(297, 13)
        Me.labelName.TabIndex = 1
        Me.labelName.Text = "Nombre:"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 135)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.ShowInTaskbar = False
        Me.Text = "Analizando..."
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        CType(Me.picDrive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticTheme1 As DarkTheme
    Friend WithEvents labelName As System.Windows.Forms.Label
    Friend WithEvents labelSize As System.Windows.Forms.Label
    Friend WithEvents labelPath As System.Windows.Forms.Label
    Friend WithEvents FileScanner As System.ComponentModel.BackgroundWorker
    Friend WithEvents picDrive As System.Windows.Forms.PictureBox
    Friend WithEvents progressTotal As DarkProgressBar
    Friend WithEvents MysticClose1 As DarkClose
    Friend WithEvents labelDetect As System.Windows.Forms.Label
    Friend WithEvents labelLoading As Label
End Class

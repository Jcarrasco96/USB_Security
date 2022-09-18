Imports Theme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetected
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetected))
        Me.MysticTheme1 = New DarkTheme
        Me.labelMalware = New System.Windows.Forms.Label()
        Me.labelPath = New System.Windows.Forms.Label()
        Me.labelName = New System.Windows.Forms.Label()
        Me.btnMoveQuar = New DarkButton()
        Me.btnDelete = New DarkButton()
        Me.btnIgnore = New DarkButton()
        Me.MysticClose1 = New DarkClose()
        Me.MysticTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.labelMalware)
        Me.MysticTheme1.Controls.Add(Me.labelPath)
        Me.MysticTheme1.Controls.Add(Me.labelName)
        Me.MysticTheme1.Controls.Add(Me.btnMoveQuar)
        Me.MysticTheme1.Controls.Add(Me.btnDelete)
        Me.MysticTheme1.Controls.Add(Me.btnIgnore)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = True
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(484, 160)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Amenaza detectada"
        '
        'labelMalware
        '
        Me.labelMalware.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelMalware.AutoEllipsis = True
        Me.labelMalware.BackColor = System.Drawing.Color.Transparent
        Me.labelMalware.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.labelMalware.Location = New System.Drawing.Point(12, 88)
        Me.labelMalware.Name = "labelMalware"
        Me.labelMalware.Size = New System.Drawing.Size(460, 13)
        Me.labelMalware.TabIndex = 7
        Me.labelMalware.Text = "Código maligno:"
        '
        'labelPath
        '
        Me.labelPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPath.AutoEllipsis = True
        Me.labelPath.BackColor = System.Drawing.Color.Transparent
        Me.labelPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelPath.Location = New System.Drawing.Point(12, 66)
        Me.labelPath.Name = "labelPath"
        Me.labelPath.Size = New System.Drawing.Size(460, 13)
        Me.labelPath.TabIndex = 6
        Me.labelPath.Text = "Ubicación:"
        '
        'labelName
        '
        Me.labelName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelName.BackColor = System.Drawing.Color.Transparent
        Me.labelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelName.Location = New System.Drawing.Point(12, 44)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(460, 13)
        Me.labelName.TabIndex = 5
        Me.labelName.Text = "Nombre:"
        '
        'btnMoveQuar
        '
        Me.btnMoveQuar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveQuar.Location = New System.Drawing.Point(170, 118)
        Me.btnMoveQuar.Name = "btnMoveQuar"
        Me.btnMoveQuar.Size = New System.Drawing.Size(140, 30)
        Me.btnMoveQuar.TabIndex = 3
        Me.btnMoveQuar.Text = "Mover a cuarentena"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(316, 118)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Eliminar"
        '
        'btnIgnore
        '
        Me.btnIgnore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIgnore.Location = New System.Drawing.Point(397, 118)
        Me.btnIgnore.Name = "btnIgnore"
        Me.btnIgnore.Size = New System.Drawing.Size(75, 30)
        Me.btnIgnore.TabIndex = 1
        Me.btnIgnore.Text = "Ignorar"
        '
        'MysticClose1
        '
        Me.MysticClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MysticClose1.Location = New System.Drawing.Point(454, 6)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(24, 24)
        Me.MysticClose1.TabIndex = 0
        Me.MysticClose1.Text = "MysticClose1"
        '
        'FormDetected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 160)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDetected"
        Me.ShowInTaskbar = False
        Me.Text = "Amenaza detectada"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticTheme1 As DarkTheme
    Friend WithEvents MysticClose1 As DarkClose
    Friend WithEvents btnIgnore As DarkButton
    Friend WithEvents btnMoveQuar As DarkButton
    Friend WithEvents btnDelete As DarkButton
    Friend WithEvents labelPath As System.Windows.Forms.Label
    Friend WithEvents labelName As System.Windows.Forms.Label
    Friend WithEvents labelMalware As System.Windows.Forms.Label
End Class

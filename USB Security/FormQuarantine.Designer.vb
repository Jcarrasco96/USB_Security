Imports Theme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQuarantine
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
        Me.MysticTheme1 = New Theme.DarkTheme()
        Me.labelSize = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMalware = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRestore = New Theme.DarkButton()
        Me.btnDelete = New Theme.DarkButton()
        Me.btnClear = New Theme.DarkButton()
        Me.MysticClose1 = New Theme.DarkClose()
        Me.MysticTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.labelSize)
        Me.MysticTheme1.Controls.Add(Me.ListView1)
        Me.MysticTheme1.Controls.Add(Me.btnRestore)
        Me.MysticTheme1.Controls.Add(Me.btnDelete)
        Me.MysticTheme1.Controls.Add(Me.btnClear)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = True
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(784, 561)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Cuarentena"
        '
        'labelSize
        '
        Me.labelSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelSize.AutoSize = True
        Me.labelSize.BackColor = System.Drawing.Color.Transparent
        Me.labelSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelSize.Location = New System.Drawing.Point(12, 533)
        Me.labelSize.Name = "labelSize"
        Me.labelSize.Size = New System.Drawing.Size(127, 16)
        Me.labelSize.TabIndex = 5
        Me.labelSize.Text = "0 ARCHIVOS / 0 MB"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDateTime, Me.colName, Me.colPath, Me.colMalware})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 47)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(760, 461)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colDateTime
        '
        Me.colDateTime.Text = "Fecha"
        Me.colDateTime.Width = 140
        '
        'colName
        '
        Me.colName.Text = "Nombre"
        Me.colName.Width = 150
        '
        'colPath
        '
        Me.colPath.Text = "Ubicación"
        Me.colPath.Width = 250
        '
        'colMalware
        '
        Me.colMalware.Text = "Código maligno"
        Me.colMalware.Width = 200
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.Location = New System.Drawing.Point(470, 519)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(85, 30)
        Me.btnRestore.TabIndex = 3
        Me.btnRestore.Text = "Restaurar"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(561, 519)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Eliminar"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(652, 519)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Vaciar registro"
        '
        'MysticClose1
        '
        Me.MysticClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MysticClose1.BackColor = System.Drawing.Color.Transparent
        Me.MysticClose1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MysticClose1.Location = New System.Drawing.Point(754, 6)
        Me.MysticClose1.Name = "MysticClose1"
        Me.MysticClose1.Size = New System.Drawing.Size(24, 24)
        Me.MysticClose1.TabIndex = 0
        Me.MysticClose1.Text = "MysticClose1"
        '
        'FormQuarantine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormQuarantine"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuarentena"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.MysticTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticTheme1 As DarkTheme
    Friend WithEvents MysticClose1 As DarkClose
    Friend WithEvents btnClear As DarkButton
    Friend WithEvents btnRestore As DarkButton
    Friend WithEvents btnDelete As DarkButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents labelSize As System.Windows.Forms.Label
    Friend WithEvents colDateTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMalware As System.Windows.Forms.ColumnHeader
End Class

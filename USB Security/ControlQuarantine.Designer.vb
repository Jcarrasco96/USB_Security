<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlQuarantine
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.labelSize = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colDateTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMalware = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRestore = New Theme.DarkButton()
        Me.btnDelete = New Theme.DarkButton()
        Me.btnClear = New Theme.DarkButton()
        Me.SuspendLayout()
        '
        'labelSize
        '
        Me.labelSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelSize.AutoSize = True
        Me.labelSize.BackColor = System.Drawing.Color.Transparent
        Me.labelSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.labelSize.Location = New System.Drawing.Point(3, 381)
        Me.labelSize.Name = "labelSize"
        Me.labelSize.Size = New System.Drawing.Size(127, 16)
        Me.labelSize.TabIndex = 10
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
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(594, 358)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colDateTime
        '
        Me.colDateTime.Text = "Fecha"
        Me.colDateTime.Width = 130
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
        Me.btnRestore.Location = New System.Drawing.Point(295, 367)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(85, 30)
        Me.btnRestore.TabIndex = 8
        Me.btnRestore.Text = "Restaurar"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(386, 367)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 30)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Eliminar"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(477, 367)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Vaciar registro"
        '
        'ControlQuarantine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.labelSize)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "ControlQuarantine"
        Me.Size = New System.Drawing.Size(600, 400)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelSize As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colDateTime As ColumnHeader
    Friend WithEvents colName As ColumnHeader
    Friend WithEvents colPath As ColumnHeader
    Friend WithEvents colMalware As ColumnHeader
    Friend WithEvents btnRestore As Theme.DarkButton
    Friend WithEvents btnDelete As Theme.DarkButton
    Friend WithEvents btnClear As Theme.DarkButton
End Class

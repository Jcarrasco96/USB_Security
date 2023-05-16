<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlLogs
    Inherits System.Windows.Forms.UserControl

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.listViewFuncionamiento = New System.Windows.Forms.ListView()
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colComponent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDetails = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRestore = New Theme.DarkButton()
        Me.btnSave = New Theme.DarkButton()
        Me.btnDelete = New Theme.DarkButton()
        Me.SuspendLayout()
        '
        'listViewFuncionamiento
        '
        Me.listViewFuncionamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listViewFuncionamiento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDate, Me.colUser, Me.colComponent, Me.colDetails})
        Me.listViewFuncionamiento.FullRowSelect = True
        Me.listViewFuncionamiento.GridLines = True
        Me.listViewFuncionamiento.HideSelection = False
        Me.listViewFuncionamiento.Location = New System.Drawing.Point(3, 3)
        Me.listViewFuncionamiento.Name = "listViewFuncionamiento"
        Me.listViewFuncionamiento.Size = New System.Drawing.Size(594, 358)
        Me.listViewFuncionamiento.TabIndex = 1
        Me.listViewFuncionamiento.UseCompatibleStateImageBehavior = False
        Me.listViewFuncionamiento.View = System.Windows.Forms.View.Details
        '
        'colDate
        '
        Me.colDate.Text = "Fecha"
        Me.colDate.Width = 130
        '
        'colUser
        '
        Me.colUser.Text = "Usuario"
        Me.colUser.Width = 160
        '
        'colComponent
        '
        Me.colComponent.Text = "Componente"
        Me.colComponent.Width = 120
        '
        'colDetails
        '
        Me.colDetails.Text = "Detalles"
        Me.colDetails.Width = 300
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.Location = New System.Drawing.Point(330, 367)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(85, 30)
        Me.btnRestore.TabIndex = 7
        Me.btnRestore.Text = "Refrescar"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(421, 367)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Guardar"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(512, 367)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 30)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Eliminar"
        '
        'ControlLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.listViewFuncionamiento)
        Me.Name = "ControlLogs"
        Me.Size = New System.Drawing.Size(600, 400)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewFuncionamiento As ListView
    Friend WithEvents btnRestore As Theme.DarkButton
    Friend WithEvents btnSave As Theme.DarkButton
    Friend WithEvents btnDelete As Theme.DarkButton
    Friend WithEvents colDate As ColumnHeader
    Friend WithEvents colUser As ColumnHeader
    Friend WithEvents colComponent As ColumnHeader
    Friend WithEvents colDetails As ColumnHeader
End Class

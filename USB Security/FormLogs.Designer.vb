Imports Theme

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogs
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
        Me.MysticButton3 = New Theme.DarkButton()
        Me.MysticButton2 = New Theme.DarkButton()
        Me.MysticButton1 = New Theme.DarkButton()
        Me.ThirteenTabControl1 = New Theme.DarkTabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.listViewMalwares = New System.Windows.Forms.ListView()
        Me.tabRegistry = New System.Windows.Forms.TabPage()
        Me.listViewFuncionamiento = New System.Windows.Forms.ListView()
        Me.MysticClose1 = New Theme.DarkClose()
        Me.MysticTheme1.SuspendLayout()
        Me.ThirteenTabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        Me.tabRegistry.SuspendLayout()
        Me.SuspendLayout()
        '
        'MysticTheme1
        '
        Me.MysticTheme1.Controls.Add(Me.MysticButton3)
        Me.MysticTheme1.Controls.Add(Me.MysticButton2)
        Me.MysticTheme1.Controls.Add(Me.MysticButton1)
        Me.MysticTheme1.Controls.Add(Me.ThirteenTabControl1)
        Me.MysticTheme1.Controls.Add(Me.MysticClose1)
        Me.MysticTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MysticTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MysticTheme1.Movible = True
        Me.MysticTheme1.Name = "MysticTheme1"
        Me.MysticTheme1.Size = New System.Drawing.Size(784, 561)
        Me.MysticTheme1.TabIndex = 0
        Me.MysticTheme1.Text = "Estadísticas"
        '
        'MysticButton3
        '
        Me.MysticButton3.Location = New System.Drawing.Point(505, 519)
        Me.MysticButton3.Name = "MysticButton3"
        Me.MysticButton3.Size = New System.Drawing.Size(85, 30)
        Me.MysticButton3.TabIndex = 4
        Me.MysticButton3.Text = "Refrescar"
        '
        'MysticButton2
        '
        Me.MysticButton2.Location = New System.Drawing.Point(596, 519)
        Me.MysticButton2.Name = "MysticButton2"
        Me.MysticButton2.Size = New System.Drawing.Size(85, 30)
        Me.MysticButton2.TabIndex = 3
        Me.MysticButton2.Text = "Guardar"
        '
        'MysticButton1
        '
        Me.MysticButton1.Location = New System.Drawing.Point(687, 519)
        Me.MysticButton1.Name = "MysticButton1"
        Me.MysticButton1.Size = New System.Drawing.Size(85, 30)
        Me.MysticButton1.TabIndex = 2
        Me.MysticButton1.Text = "Eliminar"
        '
        'ThirteenTabControl1
        '
        Me.ThirteenTabControl1.Controls.Add(Me.tabGeneral)
        Me.ThirteenTabControl1.Controls.Add(Me.tabRegistry)
        Me.ThirteenTabControl1.ForeColor = System.Drawing.Color.White
        Me.ThirteenTabControl1.Location = New System.Drawing.Point(12, 46)
        Me.ThirteenTabControl1.Name = "ThirteenTabControl1"
        Me.ThirteenTabControl1.SelectedIndex = 0
        Me.ThirteenTabControl1.Size = New System.Drawing.Size(760, 462)
        Me.ThirteenTabControl1.TabIndex = 1
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabGeneral.Controls.Add(Me.listViewMalwares)
        Me.tabGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(752, 433)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "Códigos malignos"
        '
        'listViewMalwares
        '
        Me.listViewMalwares.FullRowSelect = True
        Me.listViewMalwares.GridLines = True
        Me.listViewMalwares.HideSelection = False
        Me.listViewMalwares.Location = New System.Drawing.Point(6, 6)
        Me.listViewMalwares.Name = "listViewMalwares"
        Me.listViewMalwares.Size = New System.Drawing.Size(740, 421)
        Me.listViewMalwares.TabIndex = 0
        Me.listViewMalwares.UseCompatibleStateImageBehavior = False
        Me.listViewMalwares.View = System.Windows.Forms.View.Details
        '
        'tabRegistry
        '
        Me.tabRegistry.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabRegistry.Controls.Add(Me.listViewFuncionamiento)
        Me.tabRegistry.Location = New System.Drawing.Point(4, 25)
        Me.tabRegistry.Name = "tabRegistry"
        Me.tabRegistry.Size = New System.Drawing.Size(752, 433)
        Me.tabRegistry.TabIndex = 3
        Me.tabRegistry.Text = "Funcionamiento"
        '
        'listViewFuncionamiento
        '
        Me.listViewFuncionamiento.FullRowSelect = True
        Me.listViewFuncionamiento.GridLines = True
        Me.listViewFuncionamiento.HideSelection = False
        Me.listViewFuncionamiento.Location = New System.Drawing.Point(6, 6)
        Me.listViewFuncionamiento.Name = "listViewFuncionamiento"
        Me.listViewFuncionamiento.Size = New System.Drawing.Size(740, 421)
        Me.listViewFuncionamiento.TabIndex = 1
        Me.listViewFuncionamiento.UseCompatibleStateImageBehavior = False
        Me.listViewFuncionamiento.View = System.Windows.Forms.View.Details
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
        'FormLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MysticTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogs"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MysticTheme1.ResumeLayout(False)
        Me.ThirteenTabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabRegistry.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MysticClose1 As DarkClose
    Friend WithEvents MysticTheme1 As DarkTheme
    Friend WithEvents ThirteenTabControl1 As DarkTabControl
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabRegistry As System.Windows.Forms.TabPage
    Friend WithEvents MysticButton3 As DarkButton
    Friend WithEvents MysticButton2 As DarkButton
    Friend WithEvents MysticButton1 As DarkButton
    Friend WithEvents listViewMalwares As System.Windows.Forms.ListView
    Friend WithEvents listViewFuncionamiento As System.Windows.Forms.ListView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlFastScan
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCritic = New System.Windows.Forms.Label()
        Me.lblRegistry = New System.Windows.Forms.Label()
        Me.lblProcess = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.lblBases = New System.Windows.Forms.Label()
        Me.lblMalwares = New System.Windows.Forms.Label()
        Me.btnCancelScan = New Theme.DarkButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.bwScanner = New System.ComponentModel.BackgroundWorker()
        Me.brnStartScan = New Theme.DarkButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(13, 406)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(632, 62)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.Text = "Objetos analizados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCritic
        '
        Me.lblCritic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCritic.BackColor = System.Drawing.Color.Transparent
        Me.lblCritic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritic.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCritic.Image = Global.USB_Security.My.Resources.Resources._7_1_fw
        Me.lblCritic.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCritic.Location = New System.Drawing.Point(523, 0)
        Me.lblCritic.Name = "lblCritic"
        Me.lblCritic.Size = New System.Drawing.Size(101, 80)
        Me.lblCritic.TabIndex = 20
        Me.lblCritic.Text = "0"
        Me.lblCritic.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblRegistry
        '
        Me.lblRegistry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRegistry.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistry.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistry.ForeColor = System.Drawing.SystemColors.Control
        Me.lblRegistry.Image = Global.USB_Security.My.Resources.Resources._6_1_fw
        Me.lblRegistry.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblRegistry.Location = New System.Drawing.Point(419, 0)
        Me.lblRegistry.Name = "lblRegistry"
        Me.lblRegistry.Size = New System.Drawing.Size(98, 80)
        Me.lblRegistry.TabIndex = 19
        Me.lblRegistry.Text = "0"
        Me.lblRegistry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblProcess
        '
        Me.lblProcess.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProcess.BackColor = System.Drawing.Color.Transparent
        Me.lblProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcess.ForeColor = System.Drawing.SystemColors.Control
        Me.lblProcess.Image = Global.USB_Security.My.Resources.Resources._5_1_fw
        Me.lblProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblProcess.Location = New System.Drawing.Point(315, 0)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(98, 80)
        Me.lblProcess.TabIndex = 18
        Me.lblProcess.Text = "0"
        Me.lblProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblStart
        '
        Me.lblStart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStart.BackColor = System.Drawing.Color.Transparent
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStart.Image = Global.USB_Security.My.Resources.Resources._2_1_fw
        Me.lblStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblStart.Location = New System.Drawing.Point(107, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(98, 80)
        Me.lblStart.TabIndex = 17
        Me.lblStart.Text = "0"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblServices
        '
        Me.lblServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServices.BackColor = System.Drawing.Color.Transparent
        Me.lblServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.ForeColor = System.Drawing.SystemColors.Control
        Me.lblServices.Image = Global.USB_Security.My.Resources.Resources._4_1_fw
        Me.lblServices.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblServices.Location = New System.Drawing.Point(211, 0)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(98, 80)
        Me.lblServices.TabIndex = 16
        Me.lblServices.Text = "0"
        Me.lblServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblBases
        '
        Me.lblBases.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBases.BackColor = System.Drawing.Color.Transparent
        Me.lblBases.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBases.ForeColor = System.Drawing.SystemColors.Control
        Me.lblBases.Image = Global.USB_Security.My.Resources.Resources._1_1_fw
        Me.lblBases.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBases.Location = New System.Drawing.Point(3, 0)
        Me.lblBases.Name = "lblBases"
        Me.lblBases.Size = New System.Drawing.Size(98, 80)
        Me.lblBases.TabIndex = 15
        Me.lblBases.Text = "0"
        Me.lblBases.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblMalwares
        '
        Me.lblMalwares.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMalwares.BackColor = System.Drawing.Color.Transparent
        Me.lblMalwares.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMalwares.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMalwares.Location = New System.Drawing.Point(13, 65)
        Me.lblMalwares.Name = "lblMalwares"
        Me.lblMalwares.Size = New System.Drawing.Size(632, 55)
        Me.lblMalwares.TabIndex = 14
        Me.lblMalwares.Text = "Amenazs detectadas: 0"
        Me.lblMalwares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelScan
        '
        Me.btnCancelScan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelScan.Location = New System.Drawing.Point(525, 471)
        Me.btnCancelScan.Name = "btnCancelScan"
        Me.btnCancelScan.Size = New System.Drawing.Size(120, 30)
        Me.btnCancelScan.TabIndex = 13
        Me.btnCancelScan.Text = "Cancelar"
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Location = New System.Drawing.Point(13, 10)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(632, 55)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Análisis rápido del equipo"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66389!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblBases, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStart, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCritic, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblServices, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblRegistry, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProcess, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 123)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(627, 80)
        Me.TableLayoutPanel1.TabIndex = 22
        '
        'bwScanner
        '
        Me.bwScanner.WorkerSupportsCancellation = True
        '
        'brnStartScan
        '
        Me.brnStartScan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brnStartScan.Location = New System.Drawing.Point(399, 471)
        Me.brnStartScan.Name = "brnStartScan"
        Me.brnStartScan.Size = New System.Drawing.Size(120, 30)
        Me.brnStartScan.TabIndex = 23
        Me.brnStartScan.Text = "Iniciar análisis"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.IntegralHeight = False
        Me.ListBox1.Location = New System.Drawing.Point(13, 209)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(632, 194)
        Me.ListBox1.TabIndex = 24
        '
        'ControlFastScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.brnStartScan)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMalwares)
        Me.Controls.Add(Me.btnCancelScan)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "ControlFastScan"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(658, 514)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCritic As Label
    Friend WithEvents lblRegistry As Label
    Friend WithEvents lblProcess As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblServices As Label
    Friend WithEvents lblBases As Label
    Friend WithEvents lblMalwares As Label
    Friend WithEvents btnCancelScan As Theme.DarkButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents bwScanner As System.ComponentModel.BackgroundWorker
    Friend WithEvents brnStartScan As Theme.DarkButton
    Friend WithEvents ListBox1 As ListBox
End Class

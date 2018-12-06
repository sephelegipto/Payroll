<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainRemittance
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnPrintPreview1 = New DevComponents.DotNetBar.ButtonX()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnRemoveEmp = New DevComponents.DotNetBar.ButtonX()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.panNewPayrollRecord = New DevComponents.DotNetBar.PanelEx()
        Me.panDeletePayrollRecord = New DevComponents.DotNetBar.PanelEx()
        Me.dgvhidden = New System.Windows.Forms.DataGridView()
        Me.txtMonthNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCLose = New DevComponents.DotNetBar.ButtonX()
        Me.panPPeriods = New DevComponents.DotNetBar.PanelEx()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panPPeriods.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrintPreview1
        '
        Me.btnPrintPreview1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrintPreview1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrintPreview1.Location = New System.Drawing.Point(508, 3)
        Me.btnPrintPreview1.Name = "btnPrintPreview1"
        Me.btnPrintPreview1.Size = New System.Drawing.Size(125, 23)
        Me.btnPrintPreview1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrintPreview1.TabIndex = 48
        Me.btnPrintPreview1.Text = "Print Preview"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.DarkGray
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 30
        Me.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(722, 334)
        Me.dgv.TabIndex = 49
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(70, 79)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(45, 34)
        Me.dgv1.TabIndex = 44
        '
        'btnRemoveEmp
        '
        Me.btnRemoveEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRemoveEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRemoveEmp.Location = New System.Drawing.Point(333, 49)
        Me.btnRemoveEmp.Name = "btnRemoveEmp"
        Me.btnRemoveEmp.Size = New System.Drawing.Size(124, 22)
        Me.btnRemoveEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRemoveEmp.TabIndex = 39
        Me.btnRemoveEmp.Text = "&Remove Employee"
        '
        'dgv3
        '
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(172, 79)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.Size = New System.Drawing.Size(45, 34)
        Me.dgv3.TabIndex = 46
        '
        'panNewPayrollRecord
        '
        Me.panNewPayrollRecord.CanvasColor = System.Drawing.SystemColors.Control
        Me.panNewPayrollRecord.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panNewPayrollRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panNewPayrollRecord.DisabledBackColor = System.Drawing.Color.Empty
        Me.panNewPayrollRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panNewPayrollRecord.Location = New System.Drawing.Point(439, 89)
        Me.panNewPayrollRecord.Name = "panNewPayrollRecord"
        Me.panNewPayrollRecord.Size = New System.Drawing.Size(164, 24)
        Me.panNewPayrollRecord.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panNewPayrollRecord.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panNewPayrollRecord.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.panNewPayrollRecord.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.panNewPayrollRecord.Style.BorderColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panNewPayrollRecord.Style.CornerDiameter = 0
        Me.panNewPayrollRecord.Style.ForeColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panNewPayrollRecord.Style.GradientAngle = 90
        Me.panNewPayrollRecord.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panNewPayrollRecord.StyleMouseDown.BackColor1.Color = System.Drawing.Color.SkyBlue
        Me.panNewPayrollRecord.StyleMouseDown.BackColor2.Color = System.Drawing.Color.SkyBlue
        Me.panNewPayrollRecord.StyleMouseDown.BorderColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panNewPayrollRecord.StyleMouseDown.ForeColor.Color = System.Drawing.Color.White
        Me.panNewPayrollRecord.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panNewPayrollRecord.StyleMouseOver.BackColor1.Color = System.Drawing.Color.DeepSkyBlue
        Me.panNewPayrollRecord.StyleMouseOver.BackColor2.Color = System.Drawing.Color.DeepSkyBlue
        Me.panNewPayrollRecord.StyleMouseOver.BorderColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panNewPayrollRecord.StyleMouseOver.ForeColor.Color = System.Drawing.Color.White
        Me.panNewPayrollRecord.TabIndex = 47
        Me.panNewPayrollRecord.Text = "&NEW PAYROLL RECORD"
        '
        'panDeletePayrollRecord
        '
        Me.panDeletePayrollRecord.CanvasColor = System.Drawing.SystemColors.Control
        Me.panDeletePayrollRecord.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panDeletePayrollRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panDeletePayrollRecord.DisabledBackColor = System.Drawing.Color.Empty
        Me.panDeletePayrollRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panDeletePayrollRecord.Location = New System.Drawing.Point(489, 79)
        Me.panDeletePayrollRecord.Name = "panDeletePayrollRecord"
        Me.panDeletePayrollRecord.Size = New System.Drawing.Size(164, 24)
        Me.panDeletePayrollRecord.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panDeletePayrollRecord.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panDeletePayrollRecord.Style.BackColor2.Color = System.Drawing.Color.Transparent
        Me.panDeletePayrollRecord.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.panDeletePayrollRecord.Style.BorderColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panDeletePayrollRecord.Style.CornerDiameter = 0
        Me.panDeletePayrollRecord.Style.ForeColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panDeletePayrollRecord.Style.GradientAngle = 90
        Me.panDeletePayrollRecord.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panDeletePayrollRecord.StyleMouseDown.BackColor1.Color = System.Drawing.Color.SkyBlue
        Me.panDeletePayrollRecord.StyleMouseDown.BackColor2.Color = System.Drawing.Color.SkyBlue
        Me.panDeletePayrollRecord.StyleMouseDown.BorderColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panDeletePayrollRecord.StyleMouseDown.ForeColor.Color = System.Drawing.Color.White
        Me.panDeletePayrollRecord.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panDeletePayrollRecord.StyleMouseOver.BackColor1.Color = System.Drawing.Color.DeepSkyBlue
        Me.panDeletePayrollRecord.StyleMouseOver.BackColor2.Color = System.Drawing.Color.DeepSkyBlue
        Me.panDeletePayrollRecord.StyleMouseOver.BorderColor.Color = System.Drawing.Color.DeepSkyBlue
        Me.panDeletePayrollRecord.StyleMouseOver.ForeColor.Color = System.Drawing.Color.White
        Me.panDeletePayrollRecord.TabIndex = 48
        Me.panDeletePayrollRecord.Text = "&DELTE PAYROLL RECORD"
        '
        'dgvhidden
        '
        Me.dgvhidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhidden.Location = New System.Drawing.Point(547, 286)
        Me.dgvhidden.Name = "dgvhidden"
        Me.dgvhidden.Size = New System.Drawing.Size(10, 14)
        Me.dgvhidden.TabIndex = 113
        '
        'txtMonthNumber
        '
        Me.txtMonthNumber.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtMonthNumber.Border.Class = "TextBoxBorder"
        Me.txtMonthNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonthNumber.FocusHighlightEnabled = True
        Me.txtMonthNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMonthNumber.Location = New System.Drawing.Point(139, 241)
        Me.txtMonthNumber.Name = "txtMonthNumber"
        Me.txtMonthNumber.ReadOnly = True
        Me.txtMonthNumber.Size = New System.Drawing.Size(95, 20)
        Me.txtMonthNumber.TabIndex = 31
        Me.txtMonthNumber.Visible = False
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(121, 79)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(45, 34)
        Me.dgv2.TabIndex = 45
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCLose)
        Me.Panel1.Controls.Add(Me.btnPrintPreview1)
        Me.Panel1.Location = New System.Drawing.Point(12, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 36)
        Me.Panel1.TabIndex = 59
        '
        'btnCLose
        '
        Me.btnCLose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCLose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCLose.Location = New System.Drawing.Point(639, 3)
        Me.btnCLose.Name = "btnCLose"
        Me.btnCLose.Size = New System.Drawing.Size(86, 23)
        Me.btnCLose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCLose.TabIndex = 47
        Me.btnCLose.Text = "&Close"
        '
        'panPPeriods
        '
        Me.panPPeriods.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPPeriods.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPPeriods.Controls.Add(Me.dgv)
        Me.panPPeriods.Controls.Add(Me.dgvhidden)
        Me.panPPeriods.Controls.Add(Me.txtMonthNumber)
        Me.panPPeriods.Controls.Add(Me.dgv2)
        Me.panPPeriods.Controls.Add(Me.dgv1)
        Me.panPPeriods.Controls.Add(Me.btnRemoveEmp)
        Me.panPPeriods.Controls.Add(Me.dgv3)
        Me.panPPeriods.Controls.Add(Me.panNewPayrollRecord)
        Me.panPPeriods.Controls.Add(Me.panDeletePayrollRecord)
        Me.panPPeriods.DisabledBackColor = System.Drawing.Color.Empty
        Me.panPPeriods.Location = New System.Drawing.Point(12, 12)
        Me.panPPeriods.Name = "panPPeriods"
        Me.panPPeriods.Size = New System.Drawing.Size(732, 347)
        Me.panPPeriods.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPPeriods.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panPPeriods.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panPPeriods.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPPeriods.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panPPeriods.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPPeriods.Style.GradientAngle = 90
        Me.panPPeriods.TabIndex = 57
        '
        'frmMainRemittance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panPPeriods)
        Me.DoubleBuffered = True
        Me.Name = "frmMainRemittance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panPPeriods.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPrintPreview1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents btnRemoveEmp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv3 As DataGridView
    Friend WithEvents panNewPayrollRecord As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panDeletePayrollRecord As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dgvhidden As DataGridView
    Friend WithEvents txtMonthNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCLose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panPPeriods As DevComponents.DotNetBar.PanelEx
End Class

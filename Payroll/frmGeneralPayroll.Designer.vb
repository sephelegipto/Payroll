﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralPayroll
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.txtmonth = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem12 = New DevComponents.Editors.ComboItem()
        Me.ComboItem13 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem16 = New DevComponents.Editors.ComboItem()
        Me.lbl9 = New DevComponents.DotNetBar.LabelX()
        Me.txtDescription = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl5 = New DevComponents.DotNetBar.LabelX()
        Me.lbl4 = New DevComponents.DotNetBar.LabelX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl10 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCLose = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrintPreview2 = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrintPreview1 = New DevComponents.DotNetBar.ButtonX()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnRemoveEmp = New DevComponents.DotNetBar.ButtonX()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.panNewPayrollRecord = New DevComponents.DotNetBar.PanelEx()
        Me.panDeletePayrollRecord = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCollegeDept = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.txtWorkDays = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl8 = New DevComponents.DotNetBar.LabelX()
        Me.txtTo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFrom = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl7 = New DevComponents.DotNetBar.LabelX()
        Me.lbl6 = New DevComponents.DotNetBar.LabelX()
        Me.txtyear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.txtMonthNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panPPeriods = New DevComponents.DotNetBar.PanelEx()
        Me.dgvhidden = New System.Windows.Forms.DataGridView()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.panPPeriods.SuspendLayout()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "2020"
        '
        'txtmonth
        '
        Me.txtmonth.DisplayMember = "Text"
        Me.txtmonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtmonth.Enabled = False
        Me.txtmonth.FocusHighlightEnabled = True
        Me.txtmonth.FormattingEnabled = True
        Me.txtmonth.ItemHeight = 14
        Me.txtmonth.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12, Me.ComboItem13, Me.ComboItem14, Me.ComboItem15, Me.ComboItem16})
        Me.txtmonth.Location = New System.Drawing.Point(87, 74)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(95, 20)
        Me.txtmonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtmonth.TabIndex = 21
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "JANUARY"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "FEBRUARY"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "MARCH"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "APRIL"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "MAY"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "JUNE"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "JULY"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "AUGUST"
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "SEPTEMBER"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "OCTOBER"
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "NOVEMBER"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "DECEMBER"
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        '
        '
        '
        Me.lbl9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl9.Location = New System.Drawing.Point(23, 76)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(33, 15)
        Me.lbl9.TabIndex = 22
        Me.lbl9.Text = "Month"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtDescription.Border.Class = "TextBoxBorder"
        Me.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDescription.Enabled = False
        Me.txtDescription.FocusHighlightEnabled = True
        Me.txtDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescription.Location = New System.Drawing.Point(90, 43)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(211, 20)
        Me.txtDescription.TabIndex = 10
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        '
        '
        '
        Me.lbl5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl5.Location = New System.Drawing.Point(20, 44)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(58, 15)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Description"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        '
        '
        '
        Me.lbl4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl4.Location = New System.Drawing.Point(20, 18)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(29, 15)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCode.Enabled = False
        Me.txtCode.FocusHighlightEnabled = True
        Me.txtCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCode.Location = New System.Drawing.Point(90, 17)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(95, 20)
        Me.txtCode.TabIndex = 0
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        '
        '
        '
        Me.lbl10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl10.Location = New System.Drawing.Point(23, 102)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(26, 15)
        Me.lbl10.TabIndex = 24
        Me.lbl10.Text = "Year"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCLose)
        Me.Panel1.Location = New System.Drawing.Point(15, 574)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 36)
        Me.Panel1.TabIndex = 53
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
        'btnPrintPreview2
        '
        Me.btnPrintPreview2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrintPreview2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrintPreview2.Location = New System.Drawing.Point(588, 92)
        Me.btnPrintPreview2.Name = "btnPrintPreview2"
        Me.btnPrintPreview2.Size = New System.Drawing.Size(125, 23)
        Me.btnPrintPreview2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrintPreview2.TabIndex = 49
        Me.btnPrintPreview2.Text = "Print Preview Page &2"
        '
        'btnPrintPreview1
        '
        Me.btnPrintPreview1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrintPreview1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPrintPreview1.Location = New System.Drawing.Point(432, 92)
        Me.btnPrintPreview1.Name = "btnPrintPreview1"
        Me.btnPrintPreview1.Size = New System.Drawing.Size(125, 23)
        Me.btnPrintPreview1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnPrintPreview1.TabIndex = 48
        Me.btnPrintPreview1.Text = "Print Preview Page &1"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "2019"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
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
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(121, 79)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(45, 34)
        Me.dgv2.TabIndex = 45
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
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.ButtonX1)
        Me.PanelEx1.Controls.Add(Me.btnPrintPreview2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.btnPrintPreview1)
        Me.PanelEx1.Controls.Add(Me.cmbCollegeDept)
        Me.PanelEx1.Controls.Add(Me.cmbType)
        Me.PanelEx1.Controls.Add(Me.txtWorkDays)
        Me.PanelEx1.Controls.Add(Me.lbl8)
        Me.PanelEx1.Controls.Add(Me.txtTo)
        Me.PanelEx1.Controls.Add(Me.txtFrom)
        Me.PanelEx1.Controls.Add(Me.lbl7)
        Me.PanelEx1.Controls.Add(Me.lbl6)
        Me.PanelEx1.Controls.Add(Me.txtyear)
        Me.PanelEx1.Controls.Add(Me.lbl10)
        Me.PanelEx1.Controls.Add(Me.txtmonth)
        Me.PanelEx1.Controls.Add(Me.lbl9)
        Me.PanelEx1.Controls.Add(Me.txtDescription)
        Me.PanelEx1.Controls.Add(Me.lbl5)
        Me.PanelEx1.Controls.Add(Me.lbl4)
        Me.PanelEx1.Controls.Add(Me.txtCode)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(12, 359)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(732, 209)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(501, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "College/Department"
        '
        'cmbCollegeDept
        '
        Me.cmbCollegeDept.DisplayMember = "Text"
        Me.cmbCollegeDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCollegeDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCollegeDept.FocusHighlightEnabled = True
        Me.cmbCollegeDept.FormattingEnabled = True
        Me.cmbCollegeDept.ItemHeight = 14
        Me.cmbCollegeDept.Location = New System.Drawing.Point(432, 66)
        Me.cmbCollegeDept.Name = "cmbCollegeDept"
        Me.cmbCollegeDept.Size = New System.Drawing.Size(281, 20)
        Me.cmbCollegeDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCollegeDept.TabIndex = 110
        '
        'cmbType
        '
        Me.cmbType.DisplayMember = "Text"
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FocusHighlightEnabled = True
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 14
        Me.cmbType.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cmbType.Location = New System.Drawing.Point(433, 40)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(280, 20)
        Me.cmbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbType.TabIndex = 111
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Colleges"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Departments"
        '
        'txtWorkDays
        '
        Me.txtWorkDays.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtWorkDays.Border.Class = "TextBoxBorder"
        Me.txtWorkDays.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtWorkDays.Enabled = False
        Me.txtWorkDays.FocusHighlightEnabled = True
        Me.txtWorkDays.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtWorkDays.Location = New System.Drawing.Point(87, 124)
        Me.txtWorkDays.Name = "txtWorkDays"
        Me.txtWorkDays.Size = New System.Drawing.Size(45, 20)
        Me.txtWorkDays.TabIndex = 30
        Me.txtWorkDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        '
        '
        '
        Me.lbl8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl8.Location = New System.Drawing.Point(25, 125)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(56, 15)
        Me.lbl8.TabIndex = 29
        Me.lbl8.Text = "Work Days"
        '
        'txtTo
        '
        Me.txtTo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTo.Border.Class = "TextBoxBorder"
        Me.txtTo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTo.Enabled = False
        Me.txtTo.FocusHighlightEnabled = True
        Me.txtTo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTo.Location = New System.Drawing.Point(261, 101)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(43, 20)
        Me.txtTo.TabIndex = 28
        Me.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFrom
        '
        Me.txtFrom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFrom.Border.Class = "TextBoxBorder"
        Me.txtFrom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFrom.Enabled = False
        Me.txtFrom.FocusHighlightEnabled = True
        Me.txtFrom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFrom.Location = New System.Drawing.Point(261, 75)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.ReadOnly = True
        Me.txtFrom.Size = New System.Drawing.Size(43, 20)
        Me.txtFrom.TabIndex = 27
        Me.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        '
        '
        '
        Me.lbl7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl7.Location = New System.Drawing.Point(193, 102)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(49, 15)
        Me.lbl7.TabIndex = 26
        Me.lbl7.Text = "To (Date)"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        '
        '
        '
        Me.lbl6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl6.Location = New System.Drawing.Point(193, 76)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(62, 15)
        Me.lbl6.TabIndex = 25
        Me.lbl6.Text = "From (Date)"
        '
        'txtyear
        '
        Me.txtyear.DisplayMember = "Text"
        Me.txtyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtyear.Enabled = False
        Me.txtyear.FocusHighlightEnabled = True
        Me.txtyear.FormattingEnabled = True
        Me.txtyear.ItemHeight = 14
        Me.txtyear.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4, Me.ComboItem17, Me.ComboItem18, Me.ComboItem19, Me.ComboItem20})
        Me.txtyear.Location = New System.Drawing.Point(87, 100)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(95, 20)
        Me.txtyear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtyear.TabIndex = 23
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "2015"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "2016"
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "2017"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "2018"
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
        Me.panPPeriods.Location = New System.Drawing.Point(12, 6)
        Me.panPPeriods.Name = "panPPeriods"
        Me.panPPeriods.Size = New System.Drawing.Size(732, 347)
        Me.panPPeriods.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPPeriods.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panPPeriods.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panPPeriods.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPPeriods.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panPPeriods.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPPeriods.Style.GradientAngle = 90
        Me.panPPeriods.TabIndex = 51
        '
        'dgvhidden
        '
        Me.dgvhidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhidden.Location = New System.Drawing.Point(547, 286)
        Me.dgvhidden.Name = "dgvhidden"
        Me.dgvhidden.Size = New System.Drawing.Size(10, 14)
        Me.dgvhidden.TabIndex = 113
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(432, 121)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(125, 54)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 113
        Me.ButtonX1.Text = "Print Preview Page &1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with Exception"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(588, 121)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(125, 54)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 114
        Me.ButtonX2.Text = "Print Preview Page &2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Without Exception"
        '
        'frmGeneralPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 622)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panPPeriods)
        Me.DoubleBuffered = True
        Me.Name = "frmGeneralPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "General Payroll"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.panPPeriods.ResumeLayout(False)
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents txtmonth As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents lbl9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDescription As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrintPreview2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrintPreview1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCLose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents btnRemoveEmp As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgv3 As DataGridView
    Friend WithEvents panNewPayrollRecord As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panDeletePayrollRecord As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtWorkDays As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFrom As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtyear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents txtMonthNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panPPeriods As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCollegeDept As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents dgvhidden As DataGridView
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class

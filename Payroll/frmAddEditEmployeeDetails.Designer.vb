<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditEmployeeDetails
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgvhidden = New System.Windows.Forms.DataGridView()
        Me.EmployeeID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panelPerDay = New System.Windows.Forms.Panel()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panelPerHour = New System.Windows.Forms.Panel()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.tDeanDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panelPermanent = New System.Windows.Forms.Panel()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.txtTitle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbSalaryGrade = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cmbStep = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tGradRate = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGender = New DevComponents.DotNetBar.LabelX()
        Me.cmbDesignation = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblCivilStatus = New DevComponents.DotNetBar.LabelX()
        Me.cmbCollege = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cmbPosition = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lbl8 = New DevComponents.DotNetBar.LabelX()
        Me.lblTo = New DevComponents.DotNetBar.LabelX()
        Me.lblEmpStatus = New DevComponents.DotNetBar.LabelX()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.cmbEmploymentStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnNew = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPerDay.SuspendLayout()
        Me.panelPerHour.SuspendLayout()
        Me.panelPermanent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnClose.Location = New System.Drawing.Point(1026, 425)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(46, 44)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 93
        Me.btnClose.Text = "Close"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.dgv)
        Me.PanelEx1.Controls.Add(Me.dgvhidden)
        Me.PanelEx1.Controls.Add(Me.EmployeeID)
        Me.PanelEx1.Controls.Add(Me.panelPerDay)
        Me.PanelEx1.Controls.Add(Me.panelPerHour)
        Me.PanelEx1.Controls.Add(Me.panelPermanent)
        Me.PanelEx1.Controls.Add(Me.Panel1)
        Me.PanelEx1.Controls.Add(Me.LabelX5)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(0, 4)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1072, 415)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 94
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
        Me.dgv.Location = New System.Drawing.Point(12, 41)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 30
        Me.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1057, 201)
        Me.dgv.TabIndex = 1
        '
        'dgvhidden
        '
        Me.dgvhidden.AllowUserToAddRows = False
        Me.dgvhidden.AllowUserToDeleteRows = False
        Me.dgvhidden.AllowUserToOrderColumns = True
        Me.dgvhidden.AllowUserToResizeColumns = False
        Me.dgvhidden.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvhidden.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvhidden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvhidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvhidden.EnableHeadersVisualStyles = False
        Me.dgvhidden.GridColor = System.Drawing.Color.DarkGray
        Me.dgvhidden.Location = New System.Drawing.Point(856, 95)
        Me.dgvhidden.MultiSelect = False
        Me.dgvhidden.Name = "dgvhidden"
        Me.dgvhidden.ReadOnly = True
        Me.dgvhidden.RowHeadersWidth = 30
        Me.dgvhidden.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvhidden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvhidden.Size = New System.Drawing.Size(113, 74)
        Me.dgvhidden.TabIndex = 1000
        '
        'EmployeeID
        '
        '
        '
        '
        Me.EmployeeID.Border.Class = "TextBoxBorder"
        Me.EmployeeID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeID.Enabled = False
        Me.EmployeeID.FocusHighlightEnabled = True
        Me.EmployeeID.Location = New System.Drawing.Point(407, 222)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(97, 20)
        Me.EmployeeID.TabIndex = 104
        Me.EmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.EmployeeID.Visible = False
        '
        'panelPerDay
        '
        Me.panelPerDay.Controls.Add(Me.LabelX6)
        Me.panelPerDay.Controls.Add(Me.TextBoxX1)
        Me.panelPerDay.Location = New System.Drawing.Point(383, 70)
        Me.panelPerDay.Name = "panelPerDay"
        Me.panelPerDay.Size = New System.Drawing.Size(351, 148)
        Me.panelPerDay.TabIndex = 108
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(24, 12)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(68, 15)
        Me.LabelX6.TabIndex = 99
        Me.LabelX6.Text = "Rate Per Day"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Enabled = False
        Me.TextBoxX1.FocusHighlightEnabled = True
        Me.TextBoxX1.Location = New System.Drawing.Point(103, 10)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxX1.TabIndex = 103
        Me.TextBoxX1.Text = "0.00"
        Me.TextBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panelPerHour
        '
        Me.panelPerHour.Controls.Add(Me.LabelX8)
        Me.panelPerHour.Controls.Add(Me.tDeanDesc)
        Me.panelPerHour.Controls.Add(Me.ButtonX1)
        Me.panelPerHour.Controls.Add(Me.LabelX7)
        Me.panelPerHour.Controls.Add(Me.TextBoxX2)
        Me.panelPerHour.Location = New System.Drawing.Point(12, 70)
        Me.panelPerHour.Name = "panelPerHour"
        Me.panelPerHour.Size = New System.Drawing.Size(365, 148)
        Me.panelPerHour.TabIndex = 109
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(21, 12)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(116, 15)
        Me.LabelX8.TabIndex = 106
        Me.LabelX8.Text = "Educational Attainment"
        '
        'tDeanDesc
        '
        Me.tDeanDesc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tDeanDesc.Border.Class = "TextBoxBorder"
        Me.tDeanDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tDeanDesc.Enabled = False
        Me.tDeanDesc.FocusHighlightEnabled = True
        Me.tDeanDesc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tDeanDesc.Location = New System.Drawing.Point(143, 11)
        Me.tDeanDesc.Name = "tDeanDesc"
        Me.tDeanDesc.Size = New System.Drawing.Size(97, 20)
        Me.tDeanDesc.TabIndex = 105
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(246, 11)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(30, 20)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 104
        Me.ButtonX1.Text = "..."
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(21, 37)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(73, 15)
        Me.LabelX7.TabIndex = 99
        Me.LabelX7.Text = "Rate Per Hour"
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Enabled = False
        Me.TextBoxX2.FocusHighlightEnabled = True
        Me.TextBoxX2.Location = New System.Drawing.Point(143, 37)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxX2.TabIndex = 103
        Me.TextBoxX2.Text = "0.00"
        Me.TextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panelPermanent
        '
        Me.panelPermanent.Controls.Add(Me.LabelX9)
        Me.panelPermanent.Controls.Add(Me.txtTitle)
        Me.panelPermanent.Controls.Add(Me.cmbSalaryGrade)
        Me.panelPermanent.Controls.Add(Me.LabelX2)
        Me.panelPermanent.Controls.Add(Me.LabelX3)
        Me.panelPermanent.Controls.Add(Me.cmbStep)
        Me.panelPermanent.Controls.Add(Me.LabelX4)
        Me.panelPermanent.Controls.Add(Me.tGradRate)
        Me.panelPermanent.Location = New System.Drawing.Point(537, 248)
        Me.panelPermanent.Name = "panelPermanent"
        Me.panelPermanent.Size = New System.Drawing.Size(351, 148)
        Me.panelPermanent.TabIndex = 999
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Location = New System.Drawing.Point(27, 10)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(23, 15)
        Me.LabelX9.TabIndex = 106
        Me.LabelX9.Text = "Title"
        '
        'txtTitle
        '
        '
        '
        '
        Me.txtTitle.Border.Class = "TextBoxBorder"
        Me.txtTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTitle.Enabled = False
        Me.txtTitle.FocusHighlightEnabled = True
        Me.txtTitle.Location = New System.Drawing.Point(100, 8)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(231, 20)
        Me.txtTitle.TabIndex = 105
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbSalaryGrade
        '
        Me.cmbSalaryGrade.DisplayMember = "Text"
        Me.cmbSalaryGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSalaryGrade.FocusHighlightEnabled = True
        Me.cmbSalaryGrade.FormattingEnabled = True
        Me.cmbSalaryGrade.ItemHeight = 14
        Me.cmbSalaryGrade.Location = New System.Drawing.Point(100, 32)
        Me.cmbSalaryGrade.Name = "cmbSalaryGrade"
        Me.cmbSalaryGrade.Size = New System.Drawing.Size(231, 20)
        Me.cmbSalaryGrade.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbSalaryGrade.TabIndex = 104
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(27, 40)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(67, 15)
        Me.LabelX2.TabIndex = 99
        Me.LabelX2.Text = "Salary Grade"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(27, 62)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(25, 15)
        Me.LabelX3.TabIndex = 100
        Me.LabelX3.Text = "Step"
        '
        'cmbStep
        '
        Me.cmbStep.DisplayMember = "Text"
        Me.cmbStep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStep.FocusHighlightEnabled = True
        Me.cmbStep.FormattingEnabled = True
        Me.cmbStep.ItemHeight = 14
        Me.cmbStep.Location = New System.Drawing.Point(100, 58)
        Me.cmbStep.Name = "cmbStep"
        Me.cmbStep.Size = New System.Drawing.Size(231, 20)
        Me.cmbStep.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbStep.TabIndex = 102
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(27, 85)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(40, 15)
        Me.LabelX4.TabIndex = 104
        Me.LabelX4.Text = "Amount"
        '
        'tGradRate
        '
        '
        '
        '
        Me.tGradRate.Border.Class = "TextBoxBorder"
        Me.tGradRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tGradRate.Enabled = False
        Me.tGradRate.FocusHighlightEnabled = True
        Me.tGradRate.Location = New System.Drawing.Point(100, 83)
        Me.tGradRate.Name = "tGradRate"
        Me.tGradRate.Size = New System.Drawing.Size(97, 20)
        Me.tGradRate.TabIndex = 103
        Me.tGradRate.Text = "0.00"
        Me.tGradRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.cmbDesignation)
        Me.Panel1.Controls.Add(Me.lblCivilStatus)
        Me.Panel1.Controls.Add(Me.cmbCollege)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.cmbPosition)
        Me.Panel1.Controls.Add(Me.lbl8)
        Me.Panel1.Controls.Add(Me.lblTo)
        Me.Panel1.Controls.Add(Me.lblEmpStatus)
        Me.Panel1.Controls.Add(Me.dateTo)
        Me.Panel1.Controls.Add(Me.cmbEmploymentStatus)
        Me.Panel1.Controls.Add(Me.dateFrom)
        Me.Panel1.Location = New System.Drawing.Point(166, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 148)
        Me.Panel1.TabIndex = 106
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        '
        '
        '
        Me.lblGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGender.Location = New System.Drawing.Point(17, 14)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(61, 15)
        Me.lblGender.TabIndex = 24
        Me.lblGender.Text = "Designation"
        '
        'cmbDesignation
        '
        Me.cmbDesignation.DisplayMember = "Text"
        Me.cmbDesignation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDesignation.Enabled = False
        Me.cmbDesignation.FocusHighlightEnabled = True
        Me.cmbDesignation.FormattingEnabled = True
        Me.cmbDesignation.ItemHeight = 14
        Me.cmbDesignation.Location = New System.Drawing.Point(116, 12)
        Me.cmbDesignation.Name = "cmbDesignation"
        Me.cmbDesignation.Size = New System.Drawing.Size(231, 20)
        Me.cmbDesignation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbDesignation.TabIndex = 11
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        '
        '
        '
        Me.lblCivilStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCivilStatus.Location = New System.Drawing.Point(18, 37)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(40, 15)
        Me.lblCivilStatus.TabIndex = 26
        Me.lblCivilStatus.Text = "College"
        '
        'cmbCollege
        '
        Me.cmbCollege.DisplayMember = "Text"
        Me.cmbCollege.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCollege.Enabled = False
        Me.cmbCollege.FocusHighlightEnabled = True
        Me.cmbCollege.FormattingEnabled = True
        Me.cmbCollege.ItemHeight = 14
        Me.cmbCollege.Location = New System.Drawing.Point(116, 35)
        Me.cmbCollege.Name = "cmbCollege"
        Me.cmbCollege.Size = New System.Drawing.Size(231, 20)
        Me.cmbCollege.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCollege.TabIndex = 14
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(18, 59)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(42, 15)
        Me.LabelX1.TabIndex = 28
        Me.LabelX1.Text = "Position"
        '
        'cmbPosition
        '
        Me.cmbPosition.DisplayMember = "Text"
        Me.cmbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPosition.Enabled = False
        Me.cmbPosition.FocusHighlightEnabled = True
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.ItemHeight = 14
        Me.cmbPosition.Location = New System.Drawing.Point(116, 58)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(231, 20)
        Me.cmbPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbPosition.TabIndex = 27
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        '
        '
        '
        Me.lbl8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl8.Location = New System.Drawing.Point(17, 109)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(28, 15)
        Me.lbl8.TabIndex = 34
        Me.lbl8.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        '
        '
        '
        Me.lblTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTo.Location = New System.Drawing.Point(220, 109)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(15, 15)
        Me.lblTo.TabIndex = 35
        Me.lblTo.Text = "To"
        Me.lblTo.Visible = False
        '
        'lblEmpStatus
        '
        Me.lblEmpStatus.AutoSize = True
        '
        '
        '
        Me.lblEmpStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEmpStatus.Location = New System.Drawing.Point(16, 83)
        Me.lblEmpStatus.Name = "lblEmpStatus"
        Me.lblEmpStatus.Size = New System.Drawing.Size(98, 15)
        Me.lblEmpStatus.TabIndex = 95
        Me.lblEmpStatus.Text = "Employment Status"
        '
        'dateTo
        '
        Me.dateTo.Enabled = False
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTo.Location = New System.Drawing.Point(243, 107)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(104, 20)
        Me.dateTo.TabIndex = 98
        Me.dateTo.Visible = False
        '
        'cmbEmploymentStatus
        '
        Me.cmbEmploymentStatus.DisplayMember = "Text"
        Me.cmbEmploymentStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEmploymentStatus.Enabled = False
        Me.cmbEmploymentStatus.FocusHighlightEnabled = True
        Me.cmbEmploymentStatus.FormattingEnabled = True
        Me.cmbEmploymentStatus.ItemHeight = 14
        Me.cmbEmploymentStatus.Location = New System.Drawing.Point(116, 81)
        Me.cmbEmploymentStatus.Name = "cmbEmploymentStatus"
        Me.cmbEmploymentStatus.Size = New System.Drawing.Size(231, 20)
        Me.cmbEmploymentStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbEmploymentStatus.TabIndex = 96
        '
        'dateFrom
        '
        Me.dateFrom.Enabled = False
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFrom.Location = New System.Drawing.Point(51, 107)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(104, 20)
        Me.dateFrom.TabIndex = 97
        Me.dateFrom.Value = New Date(2018, 10, 21, 13, 58, 0, 0)
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(12, 10)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(63, 27)
        Me.LabelX5.TabIndex = 105
        Me.LabelX5.Text = "History"
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEdit.Location = New System.Drawing.Point(823, 425)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 44)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 96
        Me.btnEdit.Text = "Edit"
        '
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnNew.Location = New System.Drawing.Point(771, 425)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(46, 44)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 95
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSave.Location = New System.Drawing.Point(875, 425)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 44)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 97
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCancel.Location = New System.Drawing.Point(927, 425)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(46, 44)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 98
        Me.btnCancel.Text = "Cancel"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX2.Location = New System.Drawing.Point(974, 425)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(46, 44)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 99
        Me.ButtonX2.Text = "Remove"
        '
        'frmAddEditEmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 475)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmAddEditEmployeeDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Title/Designation"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPerDay.ResumeLayout(False)
        Me.panelPerDay.PerformLayout()
        Me.panelPerHour.ResumeLayout(False)
        Me.panelPerHour.PerformLayout()
        Me.panelPermanent.ResumeLayout(False)
        Me.panelPermanent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cmbCollege As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblCivilStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbDesignation As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblGender As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbPosition As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbEmploymentStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblEmpStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tGradRate As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbStep As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents panelPerHour As Panel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panelPerDay As Panel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panelPermanent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbSalaryGrade As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tDeanDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents EmployeeID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dgvhidden As DataGridView
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTitle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class

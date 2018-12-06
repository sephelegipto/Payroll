<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditEmployee))
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.picEmpPhoto = New System.Windows.Forms.PictureBox()
        Me.lblGender = New DevComponents.DotNetBar.LabelX()
        Me.lbl7 = New DevComponents.DotNetBar.LabelX()
        Me.tEmployeeIDNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.lblCivilStatus = New DevComponents.DotNetBar.LabelX()
        Me.cmbGender = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem23 = New DevComponents.Editors.ComboItem()
        Me.ComboItem24 = New DevComponents.Editors.ComboItem()
        Me.btnGetPhoto = New DevComponents.DotNetBar.ButtonX()
        Me.lbl1 = New DevComponents.DotNetBar.LabelX()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tDob = New System.Windows.Forms.DateTimePicker()
        Me.cmbCivilStatus = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.panGeneral2 = New DevComponents.DotNetBar.PanelEx()
        Me.tEmpID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tLastName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl4 = New DevComponents.DotNetBar.LabelX()
        Me.tMiddleName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl3 = New DevComponents.DotNetBar.LabelX()
        Me.tFirstName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl2 = New DevComponents.DotNetBar.LabelX()
        Me.tContactNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl6 = New DevComponents.DotNetBar.LabelX()
        Me.lbl5 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tinNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tAdress = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.picEmpPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panGeneral2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'picEmpPhoto
        '
        Me.picEmpPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEmpPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmpPhoto.ErrorImage = CType(resources.GetObject("picEmpPhoto.ErrorImage"), System.Drawing.Image)
        Me.picEmpPhoto.Image = CType(resources.GetObject("picEmpPhoto.Image"), System.Drawing.Image)
        Me.picEmpPhoto.InitialImage = CType(resources.GetObject("picEmpPhoto.InitialImage"), System.Drawing.Image)
        Me.picEmpPhoto.Location = New System.Drawing.Point(326, 8)
        Me.picEmpPhoto.Name = "picEmpPhoto"
        Me.picEmpPhoto.Size = New System.Drawing.Size(133, 108)
        Me.picEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmpPhoto.TabIndex = 85
        Me.picEmpPhoto.TabStop = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        '
        '
        '
        Me.lblGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGender.Location = New System.Drawing.Point(256, 66)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(39, 15)
        Me.lblGender.TabIndex = 24
        Me.lblGender.Text = "Gender"
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        '
        '
        '
        Me.lbl7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl7.Location = New System.Drawing.Point(9, 89)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(60, 15)
        Me.lbl7.TabIndex = 11
        Me.lbl7.Text = "Contact No."
        '
        'tEmployeeIDNo
        '
        '
        '
        '
        Me.tEmployeeIDNo.Border.Class = "TextBoxBorder"
        Me.tEmployeeIDNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tEmployeeIDNo.FocusHighlightEnabled = True
        Me.tEmployeeIDNo.Location = New System.Drawing.Point(133, 3)
        Me.tEmployeeIDNo.Name = "tEmployeeIDNo"
        Me.tEmployeeIDNo.Size = New System.Drawing.Size(103, 20)
        Me.tEmployeeIDNo.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSave.Location = New System.Drawing.Point(366, 304)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 42)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 86
        '
        'lblCivilStatus
        '
        Me.lblCivilStatus.AutoSize = True
        '
        '
        '
        Me.lblCivilStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCivilStatus.Location = New System.Drawing.Point(255, 87)
        Me.lblCivilStatus.Name = "lblCivilStatus"
        Me.lblCivilStatus.Size = New System.Drawing.Size(58, 15)
        Me.lblCivilStatus.TabIndex = 26
        Me.lblCivilStatus.Text = "Civil Status"
        '
        'cmbGender
        '
        Me.cmbGender.DisplayMember = "Text"
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.FocusHighlightEnabled = True
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 14
        Me.cmbGender.Items.AddRange(New Object() {Me.ComboItem23, Me.ComboItem24})
        Me.cmbGender.Location = New System.Drawing.Point(350, 66)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(104, 20)
        Me.cmbGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbGender.TabIndex = 11
        '
        'ComboItem23
        '
        Me.ComboItem23.Text = "FEMALE"
        '
        'ComboItem24
        '
        Me.ComboItem24.Text = "MALE"
        '
        'btnGetPhoto
        '
        Me.btnGetPhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGetPhoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGetPhoto.Location = New System.Drawing.Point(326, 118)
        Me.btnGetPhoto.Name = "btnGetPhoto"
        Me.btnGetPhoto.Size = New System.Drawing.Size(133, 20)
        Me.btnGetPhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGetPhoto.TabIndex = 77
        Me.btnGetPhoto.Text = "Get Photo"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        '
        '
        '
        Me.lbl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl1.Location = New System.Drawing.Point(38, 29)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(82, 15)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "Employee ID No"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(244, 527)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(88, 50)
        Me.dgv.TabIndex = 89
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(82, 19)
        Me.ToolStripStatusLabel8.Text = "Shortcut Keys:"
        '
        'tDob
        '
        Me.tDob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tDob.Location = New System.Drawing.Point(106, 67)
        Me.tDob.Name = "tDob"
        Me.tDob.Size = New System.Drawing.Size(104, 20)
        Me.tDob.TabIndex = 40
        '
        'cmbCivilStatus
        '
        Me.cmbCivilStatus.DisplayMember = "Text"
        Me.cmbCivilStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCivilStatus.FocusHighlightEnabled = True
        Me.cmbCivilStatus.FormattingEnabled = True
        Me.cmbCivilStatus.ItemHeight = 14
        Me.cmbCivilStatus.Items.AddRange(New Object() {Me.ComboItem17, Me.ComboItem18, Me.ComboItem19, Me.ComboItem20})
        Me.cmbCivilStatus.Location = New System.Drawing.Point(350, 88)
        Me.cmbCivilStatus.Name = "cmbCivilStatus"
        Me.cmbCivilStatus.Size = New System.Drawing.Size(104, 20)
        Me.cmbCivilStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCivilStatus.TabIndex = 14
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "SINGLE"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "MARRIED"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "WIDOWED"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "SEPARATED"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(56, 19)
        Me.ToolStripStatusLabel2.Text = "F2 : Save"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(69, 19)
        Me.ToolStripStatusLabel4.Text = "ESC : Close"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 363)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(474, 24)
        Me.StatusStrip1.TabIndex = 88
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(338, 527)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(88, 50)
        Me.dgv1.TabIndex = 90
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCancel.Location = New System.Drawing.Point(415, 304)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(46, 42)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 87
        '
        'panGeneral2
        '
        Me.panGeneral2.CanvasColor = System.Drawing.SystemColors.Control
        Me.panGeneral2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panGeneral2.Controls.Add(Me.tEmpID)
        Me.panGeneral2.Controls.Add(Me.tLastName)
        Me.panGeneral2.Controls.Add(Me.btnGetPhoto)
        Me.panGeneral2.Controls.Add(Me.lbl4)
        Me.panGeneral2.Controls.Add(Me.picEmpPhoto)
        Me.panGeneral2.Controls.Add(Me.tMiddleName)
        Me.panGeneral2.Controls.Add(Me.lbl3)
        Me.panGeneral2.Controls.Add(Me.tFirstName)
        Me.panGeneral2.Controls.Add(Me.lbl2)
        Me.panGeneral2.Controls.Add(Me.lbl1)
        Me.panGeneral2.Controls.Add(Me.tEmployeeIDNo)
        Me.panGeneral2.DisabledBackColor = System.Drawing.Color.Empty
        Me.panGeneral2.Location = New System.Drawing.Point(-5, 2)
        Me.panGeneral2.Name = "panGeneral2"
        Me.panGeneral2.Size = New System.Drawing.Size(467, 143)
        Me.panGeneral2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panGeneral2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panGeneral2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panGeneral2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panGeneral2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panGeneral2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panGeneral2.Style.GradientAngle = 90
        Me.panGeneral2.TabIndex = 85
        '
        'tEmpID
        '
        '
        '
        '
        Me.tEmpID.Border.Class = "TextBoxBorder"
        Me.tEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tEmpID.FocusHighlightEnabled = True
        Me.tEmpID.Location = New System.Drawing.Point(133, 26)
        Me.tEmpID.Name = "tEmpID"
        Me.tEmpID.Size = New System.Drawing.Size(103, 20)
        Me.tEmpID.TabIndex = 1
        '
        'tLastName
        '
        '
        '
        '
        Me.tLastName.Border.Class = "TextBoxBorder"
        Me.tLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tLastName.FocusHighlightEnabled = True
        Me.tLastName.Location = New System.Drawing.Point(133, 50)
        Me.tLastName.Name = "tLastName"
        Me.tLastName.Size = New System.Drawing.Size(159, 20)
        Me.tLastName.TabIndex = 1
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        '
        '
        '
        Me.lbl4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl4.Location = New System.Drawing.Point(38, 95)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(67, 15)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "Middle Name"
        '
        'tMiddleName
        '
        '
        '
        '
        Me.tMiddleName.Border.Class = "TextBoxBorder"
        Me.tMiddleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tMiddleName.FocusHighlightEnabled = True
        Me.tMiddleName.Location = New System.Drawing.Point(133, 96)
        Me.tMiddleName.Name = "tMiddleName"
        Me.tMiddleName.Size = New System.Drawing.Size(159, 20)
        Me.tMiddleName.TabIndex = 3
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        '
        '
        '
        Me.lbl3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl3.Location = New System.Drawing.Point(38, 73)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(56, 15)
        Me.lbl3.TabIndex = 11
        Me.lbl3.Text = "First Name"
        '
        'tFirstName
        '
        '
        '
        '
        Me.tFirstName.Border.Class = "TextBoxBorder"
        Me.tFirstName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tFirstName.FocusHighlightEnabled = True
        Me.tFirstName.Location = New System.Drawing.Point(133, 73)
        Me.tFirstName.Name = "tFirstName"
        Me.tFirstName.Size = New System.Drawing.Size(159, 20)
        Me.tFirstName.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        '
        '
        '
        Me.lbl2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl2.Location = New System.Drawing.Point(38, 51)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(56, 15)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "Last Name"
        '
        'tContactNo
        '
        '
        '
        '
        Me.tContactNo.Border.Class = "TextBoxBorder"
        Me.tContactNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tContactNo.FocusHighlightEnabled = True
        Me.tContactNo.Location = New System.Drawing.Point(106, 88)
        Me.tContactNo.Name = "tContactNo"
        Me.tContactNo.Size = New System.Drawing.Size(104, 20)
        Me.tContactNo.TabIndex = 10
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        '
        '
        '
        Me.lbl6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl6.Location = New System.Drawing.Point(9, 67)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(47, 15)
        Me.lbl6.TabIndex = 9
        Me.lbl6.Text = "Birthdate"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        '
        '
        '
        Me.lbl5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl5.Location = New System.Drawing.Point(11, 10)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(43, 15)
        Me.lbl5.TabIndex = 7
        Me.lbl5.Text = "Address"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.LabelX1)
        Me.PanelEx1.Controls.Add(Me.tinNumber)
        Me.PanelEx1.Controls.Add(Me.tDob)
        Me.PanelEx1.Controls.Add(Me.cmbCivilStatus)
        Me.PanelEx1.Controls.Add(Me.lblCivilStatus)
        Me.PanelEx1.Controls.Add(Me.cmbGender)
        Me.PanelEx1.Controls.Add(Me.lblGender)
        Me.PanelEx1.Controls.Add(Me.lbl7)
        Me.PanelEx1.Controls.Add(Me.tContactNo)
        Me.PanelEx1.Controls.Add(Me.lbl6)
        Me.PanelEx1.Controls.Add(Me.lbl5)
        Me.PanelEx1.Controls.Add(Me.tAdress)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Location = New System.Drawing.Point(-5, 145)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(467, 153)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 91
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(9, 115)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(40, 15)
        Me.LabelX1.TabIndex = 42
        Me.LabelX1.Text = "TIN No."
        '
        'tinNumber
        '
        '
        '
        '
        Me.tinNumber.Border.Class = "TextBoxBorder"
        Me.tinNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tinNumber.FocusHighlightEnabled = True
        Me.tinNumber.Location = New System.Drawing.Point(106, 114)
        Me.tinNumber.Name = "tinNumber"
        Me.tinNumber.Size = New System.Drawing.Size(104, 20)
        Me.tinNumber.TabIndex = 41
        '
        'tAdress
        '
        '
        '
        '
        Me.tAdress.Border.Class = "TextBoxBorder"
        Me.tAdress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tAdress.FocusHighlightEnabled = True
        Me.tAdress.Location = New System.Drawing.Point(106, 9)
        Me.tAdress.Multiline = True
        Me.tAdress.Name = "tAdress"
        Me.tAdress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAdress.Size = New System.Drawing.Size(354, 51)
        Me.tAdress.TabIndex = 8
        '
        'frmAddEditEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 387)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.panGeneral2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Name = "frmAddEditEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddEditEmployee"
        CType(Me.picEmpPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panGeneral2.ResumeLayout(False)
        Me.panGeneral2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents picEmpPhoto As PictureBox
    Friend WithEvents lblGender As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tEmployeeIDNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblCivilStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbGender As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem23 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem24 As DevComponents.Editors.ComboItem
    Friend WithEvents btnGetPhoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lbl1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgv As DataGridView
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents tDob As DateTimePicker
    Friend WithEvents cmbCivilStatus As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panGeneral2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents tEmpID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tLastName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tMiddleName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tFirstName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tContactNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbl5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents tAdress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tinNumber As DevComponents.DotNetBar.Controls.TextBoxX
End Class

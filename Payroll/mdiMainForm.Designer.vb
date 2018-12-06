<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiMainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMainForm))
        Me.bmExit = New DevComponents.DotNetBar.ButtonItem()
        Me.staDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bmAddUser = New DevComponents.DotNetBar.ButtonItem()
        Me.bmDelUsers = New DevComponents.DotNetBar.ButtonItem()
        Me.bmIncome = New DevComponents.DotNetBar.ButtonItem()
        Me.bmDeductions = New DevComponents.DotNetBar.ButtonItem()
        Me.bmPositions = New DevComponents.DotNetBar.ButtonItem()
        Me.bmDepartments = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel4 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonBar12 = New DevComponents.DotNetBar.RibbonBar()
        Me.btnPreferences = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonPanel5 = New DevComponents.DotNetBar.RibbonPanel()
        Me.ribSetUp = New DevComponents.DotNetBar.RibbonTabItem()
        Me.rbSetUp = New DevComponents.DotNetBar.RibbonPanel()
        Me.ribSetUp6 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmLogOut = New DevComponents.DotNetBar.ButtonItem()
        Me.ribSetUp5 = New DevComponents.DotNetBar.RibbonBar()
        Me.ribSetUp2 = New DevComponents.DotNetBar.RibbonBar()
        Me.ribSetUp1 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmColleges = New DevComponents.DotNetBar.ButtonItem()
        Me.bmTranch = New DevComponents.DotNetBar.ButtonItem()
        Me.bmRanks = New DevComponents.DotNetBar.ButtonItem()
        Me.bmRates = New DevComponents.DotNetBar.ButtonItem()
        Me.ribTransactions = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.ribTran4 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmPayPrep = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPayrollPrefer = New DevComponents.DotNetBar.ButtonItem()
        Me.ribTran2 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmRegInc = New DevComponents.DotNetBar.ButtonItem()
        Me.bmRegDed = New DevComponents.DotNetBar.ButtonItem()
        Me.ribTran1 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmEmployees = New DevComponents.DotNetBar.ButtonItem()
        Me.ribReports = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.ribSetUp3 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmPhilHealth = New DevComponents.DotNetBar.ButtonItem()
        Me.bmGSIS = New DevComponents.DotNetBar.ButtonItem()
        Me.bmPagibig = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar2 = New DevComponents.DotNetBar.RibbonBar()
        Me.biNetTakeHomePay = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.biRemittances = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar13 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmPaySlip = New DevComponents.DotNetBar.ButtonItem()
        Me.RibbonBar11 = New DevComponents.DotNetBar.RibbonBar()
        Me.bmGenPay = New DevComponents.DotNetBar.ButtonItem()
        Me.ribTools = New DevComponents.DotNetBar.RibbonTabItem()
        Me.RibbonTabItem6 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.staLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RibbonPanel4.SuspendLayout()
        Me.rbSetUp.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.RibbonPanel3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ribbonControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bmExit
        '
        Me.bmExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmExit.Image = CType(resources.GetObject("bmExit.Image"), System.Drawing.Image)
        Me.bmExit.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmExit.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmExit.Name = "bmExit"
        Me.bmExit.Text = "E&xit"
        '
        'staDate
        '
        Me.staDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.staDate.Name = "staDate"
        Me.staDate.Size = New System.Drawing.Size(573, 19)
        Me.staDate.Spring = True
        Me.staDate.Text = "Date/Time:"
        '
        'bmAddUser
        '
        Me.bmAddUser.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmAddUser.Image = CType(resources.GetObject("bmAddUser.Image"), System.Drawing.Image)
        Me.bmAddUser.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmAddUser.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmAddUser.Name = "bmAddUser"
        Me.bmAddUser.Text = "Add"
        '
        'bmDelUsers
        '
        Me.bmDelUsers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmDelUsers.Image = CType(resources.GetObject("bmDelUsers.Image"), System.Drawing.Image)
        Me.bmDelUsers.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmDelUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmDelUsers.Name = "bmDelUsers"
        Me.bmDelUsers.Text = "Delete"
        '
        'bmIncome
        '
        Me.bmIncome.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmIncome.Image = CType(resources.GetObject("bmIncome.Image"), System.Drawing.Image)
        Me.bmIncome.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmIncome.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmIncome.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmIncome.Name = "bmIncome"
        Me.bmIncome.Text = "Income"
        '
        'bmDeductions
        '
        Me.bmDeductions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmDeductions.Image = CType(resources.GetObject("bmDeductions.Image"), System.Drawing.Image)
        Me.bmDeductions.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmDeductions.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmDeductions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmDeductions.Name = "bmDeductions"
        Me.bmDeductions.Text = "Deductions"
        '
        'bmPositions
        '
        Me.bmPositions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmPositions.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.bmPositions.Image = CType(resources.GetObject("bmPositions.Image"), System.Drawing.Image)
        Me.bmPositions.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmPositions.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmPositions.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmPositions.Name = "bmPositions"
        Me.bmPositions.Stretch = True
        Me.bmPositions.Text = "&Positions"
        '
        'bmDepartments
        '
        Me.bmDepartments.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmDepartments.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.bmDepartments.Image = CType(resources.GetObject("bmDepartments.Image"), System.Drawing.Image)
        Me.bmDepartments.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmDepartments.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmDepartments.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmDepartments.Name = "bmDepartments"
        Me.bmDepartments.Stretch = True
        Me.bmDepartments.Text = "Departments"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel4.Controls.Add(Me.RibbonBar12)
        Me.RibbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel4.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel4.Size = New System.Drawing.Size(1162, 102)
        '
        '
        '
        Me.RibbonPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel4.TabIndex = 4
        Me.RibbonPanel4.Visible = False
        '
        'RibbonBar12
        '
        Me.RibbonBar12.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar12.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar12.ContainerControlProcessDialogKey = True
        Me.RibbonBar12.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar12.DragDropSupport = True
        Me.RibbonBar12.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnPreferences})
        Me.RibbonBar12.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar12.Name = "RibbonBar12"
        Me.RibbonBar12.Size = New System.Drawing.Size(74, 99)
        Me.RibbonBar12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar12.TabIndex = 1
        '
        '
        '
        Me.RibbonBar12.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar12.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btnPreferences
        '
        Me.btnPreferences.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnPreferences.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnPreferences.Image = CType(resources.GetObject("btnPreferences.Image"), System.Drawing.Image)
        Me.btnPreferences.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btnPreferences.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.btnPreferences.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPreferences.Name = "btnPreferences"
        Me.btnPreferences.Stretch = True
        Me.btnPreferences.Text = "&Preferences"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel5.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel5.Size = New System.Drawing.Size(1162, 102)
        '
        '
        '
        Me.RibbonPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel5.TabIndex = 5
        Me.RibbonPanel5.Visible = False
        '
        'ribSetUp
        '
        Me.ribSetUp.Checked = True
        Me.ribSetUp.Name = "ribSetUp"
        Me.ribSetUp.Panel = Me.rbSetUp
        Me.ribSetUp.Text = "&SET-UP"
        '
        'rbSetUp
        '
        Me.rbSetUp.AutoScroll = True
        Me.rbSetUp.AutoSize = True
        Me.rbSetUp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbSetUp.Controls.Add(Me.ribSetUp6)
        Me.rbSetUp.Controls.Add(Me.ribSetUp5)
        Me.rbSetUp.Controls.Add(Me.ribSetUp2)
        Me.rbSetUp.Controls.Add(Me.ribSetUp1)
        Me.rbSetUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbSetUp.Location = New System.Drawing.Point(0, 26)
        Me.rbSetUp.Name = "rbSetUp"
        Me.rbSetUp.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.rbSetUp.Size = New System.Drawing.Size(1162, 102)
        '
        '
        '
        Me.rbSetUp.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbSetUp.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rbSetUp.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbSetUp.TabIndex = 1
        '
        'ribSetUp6
        '
        Me.ribSetUp6.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribSetUp6.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribSetUp6.ContainerControlProcessDialogKey = True
        Me.ribSetUp6.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribSetUp6.DragDropSupport = True
        Me.ribSetUp6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmLogOut, Me.bmExit})
        Me.ribSetUp6.Location = New System.Drawing.Point(525, 0)
        Me.ribSetUp6.Name = "ribSetUp6"
        Me.ribSetUp6.Size = New System.Drawing.Size(114, 99)
        Me.ribSetUp6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribSetUp6.TabIndex = 23
        '
        '
        '
        Me.ribSetUp6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp6.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmLogOut
        '
        Me.bmLogOut.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmLogOut.Image = CType(resources.GetObject("bmLogOut.Image"), System.Drawing.Image)
        Me.bmLogOut.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmLogOut.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmLogOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmLogOut.Name = "bmLogOut"
        Me.bmLogOut.Text = "L&og-Out"
        '
        'ribSetUp5
        '
        Me.ribSetUp5.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribSetUp5.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribSetUp5.ContainerControlProcessDialogKey = True
        Me.ribSetUp5.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribSetUp5.DragDropSupport = True
        Me.ribSetUp5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmAddUser, Me.bmDelUsers})
        Me.ribSetUp5.Location = New System.Drawing.Point(420, 0)
        Me.ribSetUp5.Name = "ribSetUp5"
        Me.ribSetUp5.Size = New System.Drawing.Size(105, 99)
        Me.ribSetUp5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribSetUp5.TabIndex = 22
        Me.ribSetUp5.Text = "USERS"
        '
        '
        '
        Me.ribSetUp5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp5.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ribSetUp2
        '
        Me.ribSetUp2.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribSetUp2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribSetUp2.ContainerControlProcessDialogKey = True
        Me.ribSetUp2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribSetUp2.DragDropSupport = True
        Me.ribSetUp2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmIncome, Me.bmDeductions})
        Me.ribSetUp2.Location = New System.Drawing.Point(297, 0)
        Me.ribSetUp2.Name = "ribSetUp2"
        Me.ribSetUp2.Size = New System.Drawing.Size(123, 99)
        Me.ribSetUp2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribSetUp2.TabIndex = 18
        '
        '
        '
        Me.ribSetUp2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ribSetUp1
        '
        Me.ribSetUp1.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribSetUp1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribSetUp1.ContainerControlProcessDialogKey = True
        Me.ribSetUp1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribSetUp1.DragDropSupport = True
        Me.ribSetUp1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmPositions, Me.bmDepartments, Me.bmColleges, Me.bmTranch, Me.bmRates})
        Me.ribSetUp1.Location = New System.Drawing.Point(0, 0)
        Me.ribSetUp1.Name = "ribSetUp1"
        Me.ribSetUp1.Size = New System.Drawing.Size(297, 99)
        Me.ribSetUp1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribSetUp1.TabIndex = 0
        Me.ribSetUp1.Text = "LIST"
        '
        '
        '
        Me.ribSetUp1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmColleges
        '
        Me.bmColleges.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmColleges.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.bmColleges.Image = CType(resources.GetObject("bmColleges.Image"), System.Drawing.Image)
        Me.bmColleges.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmColleges.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmColleges.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmColleges.Name = "bmColleges"
        Me.bmColleges.Stretch = True
        Me.bmColleges.Text = "Colleges"
        '
        'bmTranch
        '
        Me.bmTranch.Image = CType(resources.GetObject("bmTranch.Image"), System.Drawing.Image)
        Me.bmTranch.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmTranch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmTranch.Name = "bmTranch"
        Me.bmTranch.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmRanks})
        Me.bmTranch.Text = "Tranch"
        '
        'bmRanks
        '
        Me.bmRanks.Name = "bmRanks"
        Me.bmRanks.Text = "Salary Grades"
        '
        'bmRates
        '
        Me.bmRates.Image = CType(resources.GetObject("bmRates.Image"), System.Drawing.Image)
        Me.bmRates.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmRates.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmRates.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmRates.Name = "bmRates"
        Me.bmRates.SubItemsExpandWidth = 14
        Me.bmRates.Text = "Rates"
        '
        'ribTransactions
        '
        Me.ribTransactions.Name = "ribTransactions"
        Me.ribTransactions.Panel = Me.RibbonPanel2
        Me.ribTransactions.Text = "&TRANSACTIONS"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.AutoSize = True
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.ribTran4)
        Me.RibbonPanel2.Controls.Add(Me.ribTran2)
        Me.RibbonPanel2.Controls.Add(Me.ribTran1)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(1162, 128)
        '
        '
        '
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'ribTran4
        '
        Me.ribTran4.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribTran4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribTran4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribTran4.ContainerControlProcessDialogKey = True
        Me.ribTran4.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribTran4.DragDropSupport = True
        Me.ribTran4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmPayPrep, Me.btnPayrollPrefer})
        Me.ribTran4.Location = New System.Drawing.Point(200, 0)
        Me.ribTran4.Name = "ribTran4"
        Me.ribTran4.Size = New System.Drawing.Size(116, 125)
        Me.ribTran4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribTran4.TabIndex = 21
        Me.ribTran4.Text = "PAYROLL"
        '
        '
        '
        Me.ribTran4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribTran4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmPayPrep
        '
        Me.bmPayPrep.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmPayPrep.Image = CType(resources.GetObject("bmPayPrep.Image"), System.Drawing.Image)
        Me.bmPayPrep.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmPayPrep.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmPayPrep.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmPayPrep.Name = "bmPayPrep"
        Me.bmPayPrep.Text = "Payroll"
        '
        'btnPayrollPrefer
        '
        Me.btnPayrollPrefer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnPayrollPrefer.Image = CType(resources.GetObject("btnPayrollPrefer.Image"), System.Drawing.Image)
        Me.btnPayrollPrefer.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnPayrollPrefer.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.btnPayrollPrefer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPayrollPrefer.Name = "btnPayrollPrefer"
        Me.btnPayrollPrefer.Text = "Payroll" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Preference"
        '
        'ribTran2
        '
        Me.ribTran2.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribTran2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribTran2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribTran2.ContainerControlProcessDialogKey = True
        Me.ribTran2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribTran2.DragDropSupport = True
        Me.ribTran2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmRegInc, Me.bmRegDed})
        Me.ribTran2.Location = New System.Drawing.Point(77, 0)
        Me.ribTran2.Name = "ribTran2"
        Me.ribTran2.Size = New System.Drawing.Size(123, 125)
        Me.ribTran2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribTran2.TabIndex = 19
        Me.ribTran2.Text = "REGULAR"
        '
        '
        '
        Me.ribTran2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribTran2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmRegInc
        '
        Me.bmRegInc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmRegInc.Image = CType(resources.GetObject("bmRegInc.Image"), System.Drawing.Image)
        Me.bmRegInc.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmRegInc.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmRegInc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmRegInc.Name = "bmRegInc"
        Me.bmRegInc.Text = "Income"
        '
        'bmRegDed
        '
        Me.bmRegDed.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmRegDed.Image = CType(resources.GetObject("bmRegDed.Image"), System.Drawing.Image)
        Me.bmRegDed.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmRegDed.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmRegDed.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmRegDed.Name = "bmRegDed"
        Me.bmRegDed.Text = "Deductions"
        '
        'ribTran1
        '
        Me.ribTran1.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribTran1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribTran1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribTran1.ContainerControlProcessDialogKey = True
        Me.ribTran1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribTran1.DragDropSupport = True
        Me.ribTran1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmEmployees})
        Me.ribTran1.Location = New System.Drawing.Point(3, 0)
        Me.ribTran1.Name = "ribTran1"
        Me.ribTran1.Size = New System.Drawing.Size(74, 125)
        Me.ribTran1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribTran1.TabIndex = 7
        '
        '
        '
        Me.ribTran1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribTran1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmEmployees
        '
        Me.bmEmployees.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmEmployees.Image = CType(resources.GetObject("bmEmployees.Image"), System.Drawing.Image)
        Me.bmEmployees.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmEmployees.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmEmployees.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmEmployees.Name = "bmEmployees"
        Me.bmEmployees.Text = "Employees"
        '
        'ribReports
        '
        Me.ribReports.Name = "ribReports"
        Me.ribReports.Panel = Me.RibbonPanel3
        Me.ribReports.Text = "&REPORTS"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Controls.Add(Me.ribSetUp3)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar2)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar1)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar13)
        Me.RibbonPanel3.Controls.Add(Me.RibbonBar11)
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 26)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(1162, 102)
        '
        '
        '
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        Me.RibbonPanel3.Visible = False
        '
        'ribSetUp3
        '
        Me.ribSetUp3.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribSetUp3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribSetUp3.ContainerControlProcessDialogKey = True
        Me.ribSetUp3.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribSetUp3.DragDropSupport = True
        Me.ribSetUp3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmPhilHealth, Me.bmGSIS, Me.bmPagibig})
        Me.ribSetUp3.Location = New System.Drawing.Point(315, 0)
        Me.ribSetUp3.Name = "ribSetUp3"
        Me.ribSetUp3.Size = New System.Drawing.Size(168, 99)
        Me.ribSetUp3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribSetUp3.TabIndex = 21
        '
        '
        '
        Me.ribSetUp3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribSetUp3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmPhilHealth
        '
        Me.bmPhilHealth.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmPhilHealth.Image = CType(resources.GetObject("bmPhilHealth.Image"), System.Drawing.Image)
        Me.bmPhilHealth.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmPhilHealth.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmPhilHealth.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmPhilHealth.Name = "bmPhilHealth"
        Me.bmPhilHealth.Text = "PhilHealth"
        '
        'bmGSIS
        '
        Me.bmGSIS.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmGSIS.Image = CType(resources.GetObject("bmGSIS.Image"), System.Drawing.Image)
        Me.bmGSIS.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmGSIS.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmGSIS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmGSIS.Name = "bmGSIS"
        Me.bmGSIS.Text = "GSIS"
        '
        'bmPagibig
        '
        Me.bmPagibig.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmPagibig.Image = CType(resources.GetObject("bmPagibig.Image"), System.Drawing.Image)
        Me.bmPagibig.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmPagibig.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmPagibig.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmPagibig.Name = "bmPagibig"
        Me.bmPagibig.Text = "Pagibig"
        '
        'RibbonBar2
        '
        Me.RibbonBar2.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar2.ContainerControlProcessDialogKey = True
        Me.RibbonBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar2.DragDropSupport = True
        Me.RibbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biNetTakeHomePay})
        Me.RibbonBar2.Location = New System.Drawing.Point(199, 0)
        Me.RibbonBar2.Name = "RibbonBar2"
        Me.RibbonBar2.Size = New System.Drawing.Size(116, 99)
        Me.RibbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar2.TabIndex = 12
        '
        '
        '
        Me.RibbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'biNetTakeHomePay
        '
        Me.biNetTakeHomePay.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biNetTakeHomePay.Image = CType(resources.GetObject("biNetTakeHomePay.Image"), System.Drawing.Image)
        Me.biNetTakeHomePay.ImageFixedSize = New System.Drawing.Size(100, 40)
        Me.biNetTakeHomePay.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.biNetTakeHomePay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biNetTakeHomePay.Name = "biNetTakeHomePay"
        Me.biNetTakeHomePay.Text = "Net Take Home Pay"
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar1.ContainerControlProcessDialogKey = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.DragDropSupport = True
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.biRemittances})
        Me.RibbonBar1.Location = New System.Drawing.Point(130, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(69, 99)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar1.TabIndex = 11
        '
        '
        '
        Me.RibbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'biRemittances
        '
        Me.biRemittances.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.biRemittances.Image = CType(resources.GetObject("biRemittances.Image"), System.Drawing.Image)
        Me.biRemittances.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.biRemittances.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.biRemittances.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.biRemittances.Name = "biRemittances"
        Me.biRemittances.Text = "Remittances"
        '
        'RibbonBar13
        '
        Me.RibbonBar13.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar13.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar13.ContainerControlProcessDialogKey = True
        Me.RibbonBar13.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar13.DragDropSupport = True
        Me.RibbonBar13.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmPaySlip})
        Me.RibbonBar13.Location = New System.Drawing.Point(61, 0)
        Me.RibbonBar13.Name = "RibbonBar13"
        Me.RibbonBar13.Size = New System.Drawing.Size(69, 99)
        Me.RibbonBar13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar13.TabIndex = 9
        '
        '
        '
        Me.RibbonBar13.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar13.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmPaySlip
        '
        Me.bmPaySlip.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmPaySlip.Image = CType(resources.GetObject("bmPaySlip.Image"), System.Drawing.Image)
        Me.bmPaySlip.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.bmPaySlip.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmPaySlip.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmPaySlip.Name = "bmPaySlip"
        Me.bmPaySlip.Text = "Pay Slip"
        '
        'RibbonBar11
        '
        Me.RibbonBar11.AutoOverflowEnabled = True
        '
        '
        '
        Me.RibbonBar11.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonBar11.ContainerControlProcessDialogKey = True
        Me.RibbonBar11.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar11.DragDropSupport = True
        Me.RibbonBar11.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bmGenPay})
        Me.RibbonBar11.Location = New System.Drawing.Point(3, 0)
        Me.RibbonBar11.Name = "RibbonBar11"
        Me.RibbonBar11.Size = New System.Drawing.Size(58, 99)
        Me.RibbonBar11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonBar11.TabIndex = 8
        '
        '
        '
        Me.RibbonBar11.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonBar11.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'bmGenPay
        '
        Me.bmGenPay.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bmGenPay.Image = CType(resources.GetObject("bmGenPay.Image"), System.Drawing.Image)
        Me.bmGenPay.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.bmGenPay.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Medium
        Me.bmGenPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bmGenPay.Name = "bmGenPay"
        Me.bmGenPay.Text = "General Payroll"
        '
        'ribTools
        '
        Me.ribTools.Name = "ribTools"
        Me.ribTools.Panel = Me.RibbonPanel4
        Me.ribTools.Text = "T&OOLS"
        '
        'RibbonTabItem6
        '
        Me.RibbonTabItem6.Name = "RibbonTabItem6"
        Me.RibbonTabItem6.Panel = Me.RibbonPanel5
        Me.RibbonTabItem6.Text = "&HELP"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.staLabel, Me.staDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1162, 24)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'staLabel
        '
        Me.staLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.staLabel.Name = "staLabel"
        Me.staLabel.Size = New System.Drawing.Size(573, 19)
        Me.staLabel.Spring = True
        Me.staLabel.Text = "User:"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(428, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(16, 17)
        Me.dgv.TabIndex = 23
        '
        'ribbonControl1
        '
        Me.ribbonControl1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonControl1.Controls.Add(Me.rbSetUp)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel4)
        Me.ribbonControl1.Controls.Add(Me.RibbonPanel5)
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.ForeColor = System.Drawing.Color.Black
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribSetUp, Me.ribTransactions, Me.ribReports, Me.ribTools, Me.RibbonTabItem6})
        Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.ribbonControl1.Size = New System.Drawing.Size(1162, 131)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabIndex = 21
        Me.ribbonControl1.Text = "ribbonControl1"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'mdiMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 449)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Controls.Add(Me.dgv)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "mdiMainForm"
        Me.Text = "CAGAYAN STATE UNIVERSITY - Payroll System v1.0.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonPanel4.ResumeLayout(False)
        Me.rbSetUp.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.RibbonPanel3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ribbonControl1.ResumeLayout(False)
        Me.ribbonControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bmExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents staDate As ToolStripStatusLabel
    Friend WithEvents bmAddUser As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmDelUsers As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmIncome As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmDeductions As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmPositions As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmDepartments As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel4 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar12 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnPreferences As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel5 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribSetUp As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents rbSetUp As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribSetUp6 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmLogOut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribSetUp5 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ribSetUp2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ribSetUp1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents ribTransactions As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribTran4 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmPayPrep As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribTran2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmRegInc As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmRegDed As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribTran1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmEmployees As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribReports As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonBar2 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents biNetTakeHomePay As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents biRemittances As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar13 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmPaySlip As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar11 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmGenPay As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribTools As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents RibbonTabItem6 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents staLabel As ToolStripStatusLabel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents bmTranch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmRanks As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmRates As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPayrollPrefer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmColleges As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribSetUp3 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents bmPhilHealth As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmGSIS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bmPagibig As DevComponents.DotNetBar.ButtonItem
End Class

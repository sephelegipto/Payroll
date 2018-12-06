<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreferences))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabItem7 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.panPreferences = New DevComponents.DotNetBar.PanelEx()
        Me.t15 = New System.Windows.Forms.TextBox()
        Me.t14 = New System.Windows.Forms.TextBox()
        Me.t13 = New System.Windows.Forms.TextBox()
        Me.t12 = New System.Windows.Forms.TextBox()
        Me.t11 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t10 = New System.Windows.Forms.TextBox()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t9 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.t6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.t5 = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.t3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.TextBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t8 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panPreferences.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(50, 1000)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(45, 29)
        Me.dgv.TabIndex = 38
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(50, 1000)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(45, 29)
        Me.dgv1.TabIndex = 39
        '
        'TabItem1
        '
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "COMPANY INFO"
        '
        'TabItem7
        '
        Me.TabItem7.Name = "TabItem7"
        Me.TabItem7.Text = "PENALTY"
        '
        'panPreferences
        '
        Me.panPreferences.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPreferences.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPreferences.Controls.Add(Me.t15)
        Me.panPreferences.Controls.Add(Me.t14)
        Me.panPreferences.Controls.Add(Me.t13)
        Me.panPreferences.Controls.Add(Me.t12)
        Me.panPreferences.Controls.Add(Me.t11)
        Me.panPreferences.Controls.Add(Me.Label7)
        Me.panPreferences.Controls.Add(Me.t10)
        Me.panPreferences.Controls.Add(Me.LabelX5)
        Me.panPreferences.Controls.Add(Me.Label5)
        Me.panPreferences.Controls.Add(Me.t9)
        Me.panPreferences.Controls.Add(Me.Label6)
        Me.panPreferences.Controls.Add(Me.LabelX4)
        Me.panPreferences.Controls.Add(Me.t6)
        Me.panPreferences.Controls.Add(Me.Label10)
        Me.panPreferences.Controls.Add(Me.t5)
        Me.panPreferences.Controls.Add(Me.LabelX3)
        Me.panPreferences.Controls.Add(Me.Label9)
        Me.panPreferences.Controls.Add(Me.t4)
        Me.panPreferences.Controls.Add(Me.Label8)
        Me.panPreferences.Controls.Add(Me.LabelX2)
        Me.panPreferences.Controls.Add(Me.t3)
        Me.panPreferences.Controls.Add(Me.Label4)
        Me.panPreferences.Controls.Add(Me.t2)
        Me.panPreferences.Controls.Add(Me.LabelX1)
        Me.panPreferences.Controls.Add(Me.Label3)
        Me.panPreferences.Controls.Add(Me.t8)
        Me.panPreferences.Controls.Add(Me.Label1)
        Me.panPreferences.Controls.Add(Me.t7)
        Me.panPreferences.Controls.Add(Me.Label2)
        Me.panPreferences.Controls.Add(Me.t1)
        Me.panPreferences.DisabledBackColor = System.Drawing.Color.Empty
        Me.panPreferences.Enabled = False
        Me.panPreferences.Location = New System.Drawing.Point(12, 12)
        Me.panPreferences.Name = "panPreferences"
        Me.panPreferences.Size = New System.Drawing.Size(446, 432)
        Me.panPreferences.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPreferences.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panPreferences.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panPreferences.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPreferences.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panPreferences.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPreferences.Style.GradientAngle = 90
        Me.panPreferences.TabIndex = 42
        '
        't15
        '
        Me.t15.Location = New System.Drawing.Point(158, 400)
        Me.t15.Name = "t15"
        Me.t15.Size = New System.Drawing.Size(273, 20)
        Me.t15.TabIndex = 76
        '
        't14
        '
        Me.t14.Location = New System.Drawing.Point(158, 374)
        Me.t14.Name = "t14"
        Me.t14.Size = New System.Drawing.Size(273, 20)
        Me.t14.TabIndex = 75
        '
        't13
        '
        Me.t13.Location = New System.Drawing.Point(158, 348)
        Me.t13.Name = "t13"
        Me.t13.Size = New System.Drawing.Size(273, 20)
        Me.t13.TabIndex = 74
        '
        't12
        '
        Me.t12.Location = New System.Drawing.Point(158, 322)
        Me.t12.Name = "t12"
        Me.t12.Size = New System.Drawing.Size(273, 20)
        Me.t12.TabIndex = 73
        '
        't11
        '
        Me.t11.Location = New System.Drawing.Point(158, 296)
        Me.t11.Name = "t11"
        Me.t11.Size = New System.Drawing.Size(273, 20)
        Me.t11.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Cashier"
        '
        't10
        '
        Me.t10.Location = New System.Drawing.Point(158, 270)
        Me.t10.Name = "t10"
        Me.t10.Size = New System.Drawing.Size(273, 20)
        Me.t10.TabIndex = 9
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(15, 403)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(100, 15)
        Me.LabelX5.TabIndex = 71
        Me.LabelX5.Text = "Witnessed Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Accountant"
        '
        't9
        '
        Me.t9.Location = New System.Drawing.Point(158, 244)
        Me.t9.Name = "t9"
        Me.t9.Size = New System.Drawing.Size(273, 20)
        Me.t9.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Fax #"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(15, 377)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(90, 15)
        Me.LabelX4.TabIndex = 68
        Me.LabelX4.Text = "Certified Payment"
        '
        't6
        '
        Me.t6.Location = New System.Drawing.Point(158, 166)
        Me.t6.Name = "t6"
        Me.t6.Size = New System.Drawing.Size(124, 20)
        Me.t6.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Cellphone #"
        '
        't5
        '
        Me.t5.Location = New System.Drawing.Point(158, 140)
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(124, 20)
        Me.t5.TabIndex = 4
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(15, 351)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(134, 15)
        Me.LabelX3.TabIndex = 65
        Me.LabelX3.Text = "Approved for Appropriation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Telephone #"
        '
        't4
        '
        Me.t4.Location = New System.Drawing.Point(158, 114)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(124, 20)
        Me.t4.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Campus"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(15, 325)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 15)
        Me.LabelX2.TabIndex = 62
        Me.LabelX2.Text = "Certified Correct"
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(158, 88)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(273, 20)
        Me.t3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Address"
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(158, 34)
        Me.t2.Multiline = True
        Me.t2.Name = "t2"
        Me.t2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.t2.Size = New System.Drawing.Size(273, 48)
        Me.t2.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(15, 299)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(125, 15)
        Me.LabelX1.TabIndex = 59
        Me.LabelX1.Text = "Certified Funds Available"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CEO"
        '
        't8
        '
        Me.t8.Location = New System.Drawing.Point(158, 218)
        Me.t8.Name = "t8"
        Me.t8.Size = New System.Drawing.Size(273, 20)
        Me.t8.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Email"
        '
        't7
        '
        Me.t7.Location = New System.Drawing.Point(158, 192)
        Me.t7.Name = "t7"
        Me.t7.Size = New System.Drawing.Size(273, 20)
        Me.t7.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "School Name"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(158, 8)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(273, 20)
        Me.t1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCancel.Location = New System.Drawing.Point(412, 451)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(46, 42)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSave.Location = New System.Drawing.Point(363, 451)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 42)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 40
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEdit.Location = New System.Drawing.Point(363, 451)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 42)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 43
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.panPreferences)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panPreferences.ResumeLayout(False)
        Me.panPreferences.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabItem7 As DevComponents.DotNetBar.TabItem
    Friend WithEvents panPreferences As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents t6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents t5 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents t4 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents t8 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents t7 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents t10 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents t9 As System.Windows.Forms.TextBox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents t15 As System.Windows.Forms.TextBox
    Friend WithEvents t14 As System.Windows.Forms.TextBox
    Friend WithEvents t13 As System.Windows.Forms.TextBox
    Friend WithEvents t12 As System.Windows.Forms.TextBox
    Friend WithEvents t11 As System.Windows.Forms.TextBox
End Class

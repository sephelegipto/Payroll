<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditEmployeeDeduction
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
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        Me.txtyear = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem18 = New DevComponents.Editors.ComboItem()
        Me.ComboItem19 = New DevComponents.Editors.ComboItem()
        Me.ComboItem20 = New DevComponents.Editors.ComboItem()
        Me.lbl10 = New DevComponents.DotNetBar.LabelX()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtYearsToPay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtMonthsToPay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lbl7 = New DevComponents.DotNetBar.LabelX()
        Me.txtAmount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtMonthNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.EmployeeID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.DeductionID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSave.Location = New System.Drawing.Point(167, 179)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 44)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = "Save"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnClose.Location = New System.Drawing.Point(219, 179)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(46, 44)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnClose.TabIndex = 98
        Me.btnClose.Text = "Close"
        '
        'txtyear
        '
        Me.txtyear.DisplayMember = "Text"
        Me.txtyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtyear.FocusHighlightEnabled = True
        Me.txtyear.FormattingEnabled = True
        Me.txtyear.ItemHeight = 14
        Me.txtyear.Items.AddRange(New Object() {Me.ComboItem18, Me.ComboItem19, Me.ComboItem20})
        Me.txtyear.Location = New System.Drawing.Point(106, 46)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(95, 20)
        Me.txtyear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtyear.TabIndex = 102
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "2018"
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "2019"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "2020"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        '
        '
        '
        Me.lbl10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl10.Location = New System.Drawing.Point(18, 51)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(26, 15)
        Me.lbl10.TabIndex = 103
        Me.lbl10.Text = "Year"
        '
        'txtmonth
        '
        Me.txtmonth.DisplayMember = "Text"
        Me.txtmonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtmonth.FocusHighlightEnabled = True
        Me.txtmonth.FormattingEnabled = True
        Me.txtmonth.ItemHeight = 14
        Me.txtmonth.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem9, Me.ComboItem10, Me.ComboItem11, Me.ComboItem12, Me.ComboItem13, Me.ComboItem14, Me.ComboItem15, Me.ComboItem16})
        Me.txtmonth.Location = New System.Drawing.Point(106, 24)
        Me.txtmonth.Name = "txtmonth"
        Me.txtmonth.Size = New System.Drawing.Size(95, 20)
        Me.txtmonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtmonth.TabIndex = 100
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
        Me.lbl9.Location = New System.Drawing.Point(18, 29)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(33, 15)
        Me.lbl9.TabIndex = 101
        Me.lbl9.Text = "Month"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelX6)
        Me.GroupBox2.Controls.Add(Me.txtYearsToPay)
        Me.GroupBox2.Controls.Add(Me.LabelX5)
        Me.GroupBox2.Controls.Add(Me.txtMonthsToPay)
        Me.GroupBox2.Controls.Add(Me.lbl7)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.LabelX3)
        Me.GroupBox2.Controls.Add(Me.lbl9)
        Me.GroupBox2.Controls.Add(Me.txtmonth)
        Me.GroupBox2.Controls.Add(Me.lbl10)
        Me.GroupBox2.Controls.Add(Me.txtyear)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 154)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(18, 116)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(31, 15)
        Me.LabelX6.TabIndex = 120
        Me.LabelX6.Text = "Years"
        '
        'txtYearsToPay
        '
        '
        '
        '
        Me.txtYearsToPay.Border.Class = "TextBoxBorder"
        Me.txtYearsToPay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtYearsToPay.FocusHighlightEnabled = True
        Me.txtYearsToPay.Location = New System.Drawing.Point(106, 112)
        Me.txtYearsToPay.Name = "txtYearsToPay"
        Me.txtYearsToPay.Size = New System.Drawing.Size(95, 20)
        Me.txtYearsToPay.TabIndex = 119
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(18, 94)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(73, 15)
        Me.LabelX5.TabIndex = 118
        Me.LabelX5.Text = "Months to Pay"
        '
        'txtMonthsToPay
        '
        '
        '
        '
        Me.txtMonthsToPay.Border.Class = "TextBoxBorder"
        Me.txtMonthsToPay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonthsToPay.FocusHighlightEnabled = True
        Me.txtMonthsToPay.Location = New System.Drawing.Point(106, 90)
        Me.txtMonthsToPay.Name = "txtMonthsToPay"
        Me.txtMonthsToPay.Size = New System.Drawing.Size(95, 20)
        Me.txtMonthsToPay.TabIndex = 117
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        '
        '
        '
        Me.lbl7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl7.Location = New System.Drawing.Point(18, 73)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(40, 15)
        Me.lbl7.TabIndex = 116
        Me.lbl7.Text = "Amount"
        '
        'txtAmount
        '
        '
        '
        '
        Me.txtAmount.Border.Class = "TextBoxBorder"
        Me.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAmount.FocusHighlightEnabled = True
        Me.txtAmount.Location = New System.Drawing.Point(106, 69)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(95, 20)
        Me.txtAmount.TabIndex = 115
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(353, 17)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(0, 0)
        Me.LabelX3.TabIndex = 62
        '
        'txtMonthNumber
        '
        '
        '
        '
        Me.txtMonthNumber.Border.Class = "TextBoxBorder"
        Me.txtMonthNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMonthNumber.FocusHighlightEnabled = True
        Me.txtMonthNumber.Location = New System.Drawing.Point(325, 133)
        Me.txtMonthNumber.Name = "txtMonthNumber"
        Me.txtMonthNumber.Size = New System.Drawing.Size(95, 20)
        Me.txtMonthNumber.TabIndex = 119
        '
        'EmployeeID
        '
        '
        '
        '
        Me.EmployeeID.Border.Class = "TextBoxBorder"
        Me.EmployeeID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.EmployeeID.FocusHighlightEnabled = True
        Me.EmployeeID.Location = New System.Drawing.Point(325, 102)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(95, 20)
        Me.EmployeeID.TabIndex = 120
        '
        'DeductionID
        '
        '
        '
        '
        Me.DeductionID.Border.Class = "TextBoxBorder"
        Me.DeductionID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DeductionID.FocusHighlightEnabled = True
        Me.DeductionID.Location = New System.Drawing.Point(431, 102)
        Me.DeductionID.Name = "DeductionID"
        Me.DeductionID.Size = New System.Drawing.Size(95, 20)
        Me.DeductionID.TabIndex = 121
        '
        'frmAddEditEmployeeDeduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.DeductionID)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtMonthNumber)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.DoubleBuffered = True
        Me.Name = "frmAddEditEmployeeDeduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduction"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtyear As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents lbl10 As DevComponents.DotNetBar.LabelX
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtYearsToPay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMonthsToPay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbl7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAmount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMonthNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents EmployeeID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DeductionID As DevComponents.DotNetBar.Controls.TextBoxX
End Class

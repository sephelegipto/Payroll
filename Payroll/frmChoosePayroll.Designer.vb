<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoosePayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoosePayroll))
        Me.panMonthlyTaxHeads = New DevComponents.DotNetBar.PanelEx()
        Me.cmbCollegeDept = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cmbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.dgvhidden = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPayroll = New DevComponents.DotNetBar.LabelX()
        Me.txtCode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panMonthlyTaxHeads.SuspendLayout()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panMonthlyTaxHeads
        '
        Me.panMonthlyTaxHeads.CanvasColor = System.Drawing.SystemColors.Control
        Me.panMonthlyTaxHeads.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panMonthlyTaxHeads.Controls.Add(Me.cmbCollegeDept)
        Me.panMonthlyTaxHeads.Controls.Add(Me.LabelX1)
        Me.panMonthlyTaxHeads.Controls.Add(Me.cmbType)
        Me.panMonthlyTaxHeads.DisabledBackColor = System.Drawing.Color.Empty
        Me.panMonthlyTaxHeads.Location = New System.Drawing.Point(29, 39)
        Me.panMonthlyTaxHeads.Name = "panMonthlyTaxHeads"
        Me.panMonthlyTaxHeads.Size = New System.Drawing.Size(487, 88)
        Me.panMonthlyTaxHeads.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panMonthlyTaxHeads.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panMonthlyTaxHeads.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panMonthlyTaxHeads.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panMonthlyTaxHeads.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panMonthlyTaxHeads.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panMonthlyTaxHeads.Style.GradientAngle = 90
        Me.panMonthlyTaxHeads.TabIndex = 39
        '
        'cmbCollegeDept
        '
        Me.cmbCollegeDept.DisplayMember = "Text"
        Me.cmbCollegeDept.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCollegeDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCollegeDept.FocusHighlightEnabled = True
        Me.cmbCollegeDept.FormattingEnabled = True
        Me.cmbCollegeDept.ItemHeight = 14
        Me.cmbCollegeDept.Location = New System.Drawing.Point(75, 52)
        Me.cmbCollegeDept.Name = "cmbCollegeDept"
        Me.cmbCollegeDept.Size = New System.Drawing.Size(360, 20)
        Me.cmbCollegeDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbCollegeDept.TabIndex = 61
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(192, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 15)
        Me.LabelX1.TabIndex = 64
        Me.LabelX1.Text = "College/Department"
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
        Me.cmbType.Location = New System.Drawing.Point(75, 26)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(360, 20)
        Me.cmbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmbType.TabIndex = 63
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Colleges"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Departments"
        '
        'dgvhidden
        '
        Me.dgvhidden.AllowUserToAddRows = False
        Me.dgvhidden.AllowUserToDeleteRows = False
        Me.dgvhidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhidden.Location = New System.Drawing.Point(29, 191)
        Me.dgvhidden.Name = "dgvhidden"
        Me.dgvhidden.ReadOnly = True
        Me.dgvhidden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvhidden.Size = New System.Drawing.Size(487, 127)
        Me.dgvhidden.TabIndex = 66
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(428, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 49)
        Me.btnSave.TabIndex = 40
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(472, 133)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(45, 49)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblPayroll
        '
        Me.lblPayroll.AutoSize = True
        '
        '
        '
        Me.lblPayroll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayroll.Location = New System.Drawing.Point(29, 11)
        Me.lblPayroll.Name = "lblPayroll"
        Me.lblPayroll.Size = New System.Drawing.Size(304, 21)
        Me.lblPayroll.TabIndex = 65
        Me.lblPayroll.Text = "Payroll January/1/2018-January-31-2018"
        '
        'txtCode
        '
        '
        '
        '
        Me.txtCode.Border.Class = "TextBoxBorder"
        Me.txtCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCode.Enabled = False
        Me.txtCode.FocusHighlightEnabled = True
        Me.txtCode.Location = New System.Drawing.Point(42, 133)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(97, 20)
        Me.txtCode.TabIndex = 104
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCode.Visible = False
        '
        'frmChoosePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 186)
        Me.Controls.Add(Me.panMonthlyTaxHeads)
        Me.Controls.Add(Me.dgvhidden)
        Me.Controls.Add(Me.lblPayroll)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.DoubleBuffered = True
        Me.Name = "frmChoosePayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Payroll"
        Me.panMonthlyTaxHeads.ResumeLayout(False)
        Me.panMonthlyTaxHeads.PerformLayout()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panMonthlyTaxHeads As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cmbCollegeDept As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblPayroll As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dgvhidden As DataGridView
    Friend WithEvents txtCode As DevComponents.DotNetBar.Controls.TextBoxX
End Class

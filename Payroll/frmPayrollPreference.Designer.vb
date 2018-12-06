<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollPreference
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayrollPreference))
        Me.lbl21 = New DevComponents.DotNetBar.LabelX()
        Me.tpera = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tcfa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tapa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.tufa = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnEdit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.dgvhidden = New System.Windows.Forms.DataGridView()
        Me.panPreferences = New DevComponents.DotNetBar.PanelEx()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panPreferences.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl21
        '
        Me.lbl21.AutoSize = True
        '
        '
        '
        Me.lbl21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbl21.Location = New System.Drawing.Point(24, 16)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(26, 15)
        Me.lbl21.TabIndex = 9
        Me.lbl21.Text = "Pera"
        '
        'tpera
        '
        Me.tpera.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tpera.Border.Class = "TextBoxBorder"
        Me.tpera.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tpera.Enabled = False
        Me.tpera.FocusHighlightEnabled = True
        Me.tpera.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tpera.Location = New System.Drawing.Point(80, 15)
        Me.tpera.Name = "tpera"
        Me.tpera.Size = New System.Drawing.Size(103, 20)
        Me.tpera.TabIndex = 8
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(24, 37)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(24, 15)
        Me.LabelX1.TabIndex = 53
        Me.LabelX1.Text = "CFA"
        '
        'tcfa
        '
        Me.tcfa.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tcfa.Border.Class = "TextBoxBorder"
        Me.tcfa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tcfa.Enabled = False
        Me.tcfa.FocusHighlightEnabled = True
        Me.tcfa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tcfa.Location = New System.Drawing.Point(80, 36)
        Me.tcfa.Name = "tcfa"
        Me.tcfa.Size = New System.Drawing.Size(103, 20)
        Me.tcfa.TabIndex = 52
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(24, 58)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(25, 15)
        Me.LabelX2.TabIndex = 55
        Me.LabelX2.Text = "APA"
        '
        'tapa
        '
        Me.tapa.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tapa.Border.Class = "TextBoxBorder"
        Me.tapa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tapa.Enabled = False
        Me.tapa.FocusHighlightEnabled = True
        Me.tapa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tapa.Location = New System.Drawing.Point(80, 57)
        Me.tapa.Name = "tapa"
        Me.tapa.Size = New System.Drawing.Size(103, 20)
        Me.tapa.TabIndex = 54
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(24, 79)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(24, 15)
        Me.LabelX3.TabIndex = 57
        Me.LabelX3.Text = "UFA"
        '
        'tufa
        '
        Me.tufa.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tufa.Border.Class = "TextBoxBorder"
        Me.tufa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tufa.Enabled = False
        Me.tufa.FocusHighlightEnabled = True
        Me.tufa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tufa.Location = New System.Drawing.Point(80, 79)
        Me.tufa.Name = "tufa"
        Me.tufa.Size = New System.Drawing.Size(103, 20)
        Me.tufa.TabIndex = 56
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCancel.Location = New System.Drawing.Point(202, 140)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(46, 42)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 59
        '
        'btnEdit
        '
        Me.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEdit.Location = New System.Drawing.Point(153, 140)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(46, 42)
        Me.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEdit.TabIndex = 60
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSave.Location = New System.Drawing.Point(153, 140)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(46, 42)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 58
        '
        'dgvhidden
        '
        Me.dgvhidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhidden.Location = New System.Drawing.Point(45, 235)
        Me.dgvhidden.Name = "dgvhidden"
        Me.dgvhidden.Size = New System.Drawing.Size(47, 36)
        Me.dgvhidden.TabIndex = 62
        '
        'panPreferences
        '
        Me.panPreferences.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPreferences.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPreferences.Controls.Add(Me.tpera)
        Me.panPreferences.Controls.Add(Me.lbl21)
        Me.panPreferences.Controls.Add(Me.LabelX2)
        Me.panPreferences.Controls.Add(Me.tcfa)
        Me.panPreferences.Controls.Add(Me.tufa)
        Me.panPreferences.Controls.Add(Me.LabelX1)
        Me.panPreferences.Controls.Add(Me.tapa)
        Me.panPreferences.Controls.Add(Me.LabelX3)
        Me.panPreferences.DisabledBackColor = System.Drawing.Color.Empty
        Me.panPreferences.Enabled = False
        Me.panPreferences.Location = New System.Drawing.Point(12, 12)
        Me.panPreferences.Name = "panPreferences"
        Me.panPreferences.Size = New System.Drawing.Size(234, 122)
        Me.panPreferences.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPreferences.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panPreferences.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panPreferences.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPreferences.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panPreferences.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPreferences.Style.GradientAngle = 90
        Me.panPreferences.TabIndex = 63
        '
        'frmPayrollPreference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 199)
        Me.Controls.Add(Me.panPreferences)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvhidden)
        Me.DoubleBuffered = True
        Me.Name = "frmPayrollPreference"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Preference"
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panPreferences.ResumeLayout(False)
        Me.panPreferences.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tpera As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tcfa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tapa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tufa As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEdit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvhidden As DataGridView
    Friend WithEvents panPreferences As DevComponents.DotNetBar.PanelEx
End Class

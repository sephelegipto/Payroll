<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinting
    Inherits System.Windows.Forms.Form

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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dgvhidden = New System.Windows.Forms.DataGridView()
        Me.txtCode = New System.Windows.Forms.TextBox()
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(956, 678)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'dgvhidden
        '
        Me.dgvhidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhidden.Location = New System.Drawing.Point(134, 220)
        Me.dgvhidden.Name = "dgvhidden"
        Me.dgvhidden.Size = New System.Drawing.Size(240, 150)
        Me.dgvhidden.TabIndex = 1
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(463, 282)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 2
        '
        'frmPrinting
        '
        Me.ClientSize = New System.Drawing.Size(956, 678)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.dgvhidden)
        Me.Controls.Add(Me.txtCode)
        Me.Name = "frmPrinting"
        CType(Me.dgvhidden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dgvhidden As DataGridView
    Friend WithEvents txtCode As TextBox
End Class

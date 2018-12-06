<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txt = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'txt
        '
        '
        '
        '
        Me.txt.Border.Class = "TextBoxBorder"
        Me.txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Highlighter1.SetHighlightColor(Me.txt, DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
        Me.Highlighter1.SetHighlightOnFocus(Me.txt, True)
        Me.txt.Location = New System.Drawing.Point(12, 12)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(362, 20)
        Me.txt.TabIndex = 8
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 38)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(362, 23)
        Me.LabelX1.TabIndex = 9
        Me.LabelX1.Text = "Enter search text and press ENTER key to search and ESC to close."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 71)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.txt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmFind"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmFind"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt As DevComponents.DotNetBar.Controls.TextBoxX
End Class

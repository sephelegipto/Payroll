Public Class frmFind
    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txt.TextChanged
        ' mdiMainForm.txtSearch.Text = txt.Text

    End Sub
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt.KeyPress
        e.KeyChar = ChrW(Asc(UCase(Chr(AscW(e.KeyChar)))))
    End Sub

    Private Sub frmFind_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Search = txt.Text
                Me.Dispose()
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub

    Private Sub frmFind_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
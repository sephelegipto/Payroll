Imports System.ComponentModel
Imports Dapper
Public Class frmPayrollPreference
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        mdiMainForm.btnPayrollPrefer.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub frmPayrollPreference_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mdiMainForm.btnPayrollPrefer.Enabled = True
    End Sub

    Private Sub frmPayrollPreference_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExecuteSQLStatement("SELECT * FROM tpayrollpreference", dgvhidden)



        tpera.Text = IIf(IsDBNull(dgvhidden.CurrentRow.Cells(1).Value), "", dgvhidden.CurrentRow.Cells(1).Value)
        tcfa.Text = IIf(IsDBNull(dgvhidden.CurrentRow.Cells(2).Value), "", dgvhidden.CurrentRow.Cells(2).Value)
        tapa.Text = IIf(IsDBNull(dgvhidden.CurrentRow.Cells(3).Value), "", dgvhidden.CurrentRow.Cells(3).Value)
        tufa.Text = IIf(IsDBNull(dgvhidden.CurrentRow.Cells(4).Value), "", dgvhidden.CurrentRow.Cells(4).Value)


        btnSave.Visible = False
        btnEdit.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        panPreferences.Enabled = True
        btnEdit.Visible = False
        btnSave.Visible = True
        tpera.Enabled = True
        tcfa.Enabled = True
        tufa.Enabled = True
        tapa.Enabled = True
        tpera.SelectAll()
        tpera.Focus()
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        mdiMainForm.btnPayrollPrefer.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnEdit.Visible = True
        btnSave.Visible = False

        ExecuteSQLStatement("UPDATE tpayrollpreference SET " &
                                "PERA='" & Trim(tpera.Text) & "'," &
                                "CFA='" & Trim(tcfa.Text) & "'," &
                                "APA='" & Trim(tapa.Text) & "'," &
                                "UFA='" & Trim(tufa.Text) & "'", dgvhidden)
        mdiMainForm.btnPayrollPrefer.Enabled = True
        Me.Dispose()
    End Sub
End Class
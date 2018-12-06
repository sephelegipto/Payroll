Imports System.ComponentModel
Imports Dapper

Public Class frmRemittance
    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        mdiMainForm.biRemittances.Enabled = False
        Me.Dispose()
    End Sub

    Private Sub frmRemittance_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mdiMainForm.biRemittances.Enabled = False
    End Sub

    Private Sub frmRemittance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim param As DynamicParameters = New DynamicParameters
        param.Add("LibraryToLoad", "Payroll Prep")
        param.Add("SearchText", "")
        Dim list As List(Of PayrollPrep) = MySqlConn.Query(Of PayrollPrep)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
        dgv.DataSource = list
        dgv.Columns(0).Visible = False

        ExecuteSQLStatement("SELECT * FROM tdeductions ORDER BY DeductionDescription", dgvhidden)
        Dim comboSource1 As New Dictionary(Of String, String)()
        Dim count1 As Integer = 0
        comboSource1.Add("0", "")
        For j As Integer = 0 To dgvhidden.RowCount - 2
            comboSource1.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
            count1 += 1
        Next
        cmbDeduction.DataSource = New BindingSource(comboSource1, Nothing)
        cmbDeduction.DisplayMember = "Value"
        cmbDeduction.ValueMember = "Key"
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Try
            AESwitch = If(dgv.CurrentRow.Cells(0).Value = Nothing, 0, dgv.CurrentRow.Cells(0).Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbDeduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeduction.SelectedIndexChanged

    End Sub

    Private Sub btnPrintPreview1_Click(sender As Object, e As EventArgs) Handles btnPrintPreview1.Click
        frmPrinting.CallingForm = "Remittance"

        frmPrinting.CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & ""
        LookUpContent = DirectCast(cmbDeduction.SelectedItem, KeyValuePair(Of String, String)).Key

        frmPrinting.ShowDialog()
    End Sub
End Class
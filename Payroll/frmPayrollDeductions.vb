Imports System.ComponentModel
Imports Dapper
Public Class frmPayrollDeductions
    Private Sub btnSelEmployee_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text = "Colleges" Then

            ExecuteSQLStatement("SELECT * FROM tcolleges ORDER BY CollegeDescription", dgvhidden)
            Dim comboSource1 As New Dictionary(Of String, String)()
            Dim count1 As Integer = 0
            comboSource1.Add("0", "")
            For j As Integer = 0 To dgvhidden.RowCount - 2
                comboSource1.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
                count1 += 1
            Next
            cmbCollegeDept.DataSource = New BindingSource(comboSource1, Nothing)
            cmbCollegeDept.DisplayMember = "Value"
            cmbCollegeDept.ValueMember = "Key"
        Else
            ExecuteSQLStatement("SELECT * FROM tdepartments ORDER BY DepartmentDescription", dgvhidden)
            Dim comboSource1 As New Dictionary(Of String, String)()
            Dim count1 As Integer = 0
            comboSource1.Add("0", "")
            For j As Integer = 0 To dgvhidden.RowCount - 2
                comboSource1.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
                count1 += 1
            Next
            cmbCollegeDept.DataSource = New BindingSource(comboSource1, Nothing)
            cmbCollegeDept.DisplayMember = "Value"
            cmbCollegeDept.ValueMember = "Key"
        End If



    End Sub

    Private Sub frmPayrollDeductions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mdiMainForm.bmRegDed.Enabled = False
    End Sub

    Private Sub frmPayrollDeductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gbIncDed_Enter(sender As Object, e As EventArgs) Handles gbIncDed.Enter

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        mdiMainForm.bmRegDed.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub cmbCollegeDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollegeDept.SelectedIndexChanged
        If cmbType.Text = "Colleges" Then
            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Payroll Employee Colleges")
            param.Add("SearchText", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
            Dim list As List(Of ppayrollemployee) = MySqlConn.Query(Of ppayrollemployee)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgv.DataSource = list

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Visible = False
            dgv.Columns(3).Width = 270
        Else
            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Payroll Employee Departments")
            param.Add("SearchText", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
            Dim list As List(Of ppayrollemployee) = MySqlConn.Query(Of ppayrollemployee)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgv.DataSource = list

            dgv.Columns(0).Visible = False
            dgv.Columns(1).Visible = False
            dgv.Columns(3).Width = 270
        End If
        Try

            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Payroll Employee Deductions")
            param.Add("SearchText", dgv.CurrentRow.Cells(1).Value)
            Dim list As List(Of ppayrolldeduction) = MySqlConn.Query(Of ppayrolldeduction)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgvdeductions.DataSource = list
            dgvdeductions.Columns(0).Visible = False
            dgvdeductions.Columns(1).Visible = False
            dgvdeductions.Columns(2).Width = 250

            dgvdeductions.Columns(5).Visible = False
            dgvdeductions.Columns(6).Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgv.SelectedCells.Count > 0 And dgvdeductions.SelectedCells.Count > 0 Then

            Try

                Dim frm As New frmAddEditEmployeeDeduction
                frm.txtmonth.Text = If(dgvdeductions.CurrentRow.Cells(5).Value = Nothing, "", dgvdeductions.CurrentRow.Cells(5).Value)
                frm.txtyear.Text = If(dgvdeductions.CurrentRow.Cells(6).Value = Nothing, "", dgvdeductions.CurrentRow.Cells(6).Value)
                frm.txtYearsToPay.Text = If(dgvdeductions.CurrentRow.Cells(8).Value = Nothing, "", dgvdeductions.CurrentRow.Cells(8).Value)
                frm.txtMonthsToPay.Text = If(dgvdeductions.CurrentRow.Cells(7).Value = Nothing, "", dgvdeductions.CurrentRow.Cells(7).Value)
                frm.txtAmount.Text = If(dgvdeductions.CurrentRow.Cells(9).Value = Nothing, "", dgvdeductions.CurrentRow.Cells(9).Value)
                frm.Text = dgvdeductions.CurrentRow.Cells(2).Value & " - " & dgv.CurrentRow.Cells(3).Value
                frm.EmployeeID.Text = dgv.CurrentRow.Cells(1).Value
                frm.DeductionID.Text = dgvdeductions.CurrentRow.Cells(0).Value
                btnEdit.Enabled = True
                frm.ShowDialog()
                Try

                    Dim param As DynamicParameters = New DynamicParameters
                    param.Add("LibraryToLoad", "Payroll Employee Deductions")
                    param.Add("SearchText", dgv.CurrentRow.Cells(1).Value)
                    Dim list As List(Of ppayrolldeduction) = MySqlConn.Query(Of ppayrolldeduction)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgvdeductions.DataSource = list
                    dgvdeductions.Columns(0).Visible = False
                    dgvdeductions.Columns(1).Visible = False
                    dgvdeductions.Columns(2).Width = 250

                    dgvdeductions.Columns(5).Visible = False
                    dgvdeductions.Columns(6).Visible = False
                Catch ex As Exception

                End Try
            Catch ex As Exception
                MsgBox("Please choose deduction")
            End Try

        Else
            MsgBox("Please choose deduction")
        End If


    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick






        Try

            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Payroll Employee Deductions")
            param.Add("SearchText", dgv.CurrentRow.Cells(1).Value)
            Dim list As List(Of ppayrolldeduction) = MySqlConn.Query(Of ppayrolldeduction)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgvdeductions.DataSource = list
            dgvdeductions.Columns(0).Visible = False
            dgvdeductions.Columns(1).Visible = False
            dgvdeductions.Columns(2).Width = 250
            dgvdeductions.Columns(4).Visible = False
            dgvdeductions.Columns(5).Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvdeductions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdeductions.CellContentClick

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Payroll Employee Deductions")
            param.Add("SearchText", dgv.CurrentRow.Cells(1).Value)
            Dim list As List(Of ppayrolldeduction) = MySqlConn.Query(Of ppayrolldeduction)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgvdeductions.DataSource = list
            dgvdeductions.Columns(0).Visible = False
            dgvdeductions.Columns(1).Visible = False
            dgvdeductions.Columns(2).Width = 250
            dgvdeductions.Columns(4).Visible = False
            dgvdeductions.Columns(5).Visible = False
        Catch ex As Exception

        End Try

        ExecuteSQLStatement("DELETE FROM tpayrollemployeedeductions WHERE ID = '" & dgvdeductions.CurrentRow.Cells(10).Value & "'", dgvhidden)

    End Sub
End Class
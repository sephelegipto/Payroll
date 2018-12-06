Imports Dapper
Public Class frmChoosePayroll

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        'If cmbType.SelectedIndex = 0 Then
        '    LoadRecordsInAComboBox("Select * from tcolleges order by CollegeDescription", cmbCollegeDept, "CollegeDescription")
        'Else
        '    LoadRecordsInAComboBox("Select * from tdepartments order by DepartmentDescription", cmbCollegeDept, "DepartmentDescription")
        'End If
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

    Private Sub frmChoosePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmPayrollCompute.lblPayroll.Text = Me.lblPayroll.Text & " " & DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Value

        If cmbType.Text = "Colleges" Then
            ExecuteSQLStatement("SELECT * FROM  ppayrollemployee WHERE Status = 1 and CollegeID = " & PrimaryKey & "", dgvhidden)
        Else
            ExecuteSQLStatement("SELECT * FROM  ppayrollemployee WHERE Status = 1 and DesignationID = " & PrimaryKey & "", dgvhidden)
        End If
        If dgvhidden.RowCount > 0 Then
            If cmbType.Text = "Colleges" Then
                For i = 0 To dgvhidden.RowCount - 1
                    Dim param As DynamicParameters = New DynamicParameters
                    param.Add("LibraryToLoad", "Add Payroll Employee")
                    param.Add("PayrollPreparationID", txtCode.Text)
                    param.Add("CollegeID", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
                    param.Add("DesignationID", Nothing)
                    param.Add("EmpID", If(dgvhidden.Rows(i).Cells(1).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(1).Value.ToString))
                    param.Add("PositionID", If(dgvhidden.Rows(i).Cells(9).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(9).Value.ToString))
                    param.Add("OldRate", If(dgvhidden.Rows(i).Cells(5).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(5).Value.ToString)))
                    param.Add("AdjustedRate", If(dgvhidden.Rows(i).Cells(6).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(6).Value.ToString)))
                    param.Add("WorkDays", If(frmPayrollPrep.dgv.CurrentRow.Cells(9).Value.ToString = "", Nothing, frmPayrollPrep.dgv.CurrentRow.Cells(9).Value.ToString))
                    MySqlConn.Execute("PayrollAddEditPayrollEmployee", param, commandType:=CommandType.StoredProcedure)

                Next
            Else
                For i = 0 To dgvhidden.RowCount - 1
                    Dim param As DynamicParameters = New DynamicParameters
                    param.Add("LibraryToLoad", "Add Payroll Employee")
                    param.Add("PayrollPreparationID", txtCode.Text)
                    param.Add("CollegeID", Nothing)
                    param.Add("DesignationID", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
                    param.Add("EmpID", If(dgvhidden.Rows(i).Cells(1).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(1).Value.ToString))
                    param.Add("PositionID", If(dgvhidden.Rows(i).Cells(9).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(9).Value.ToString))
                    param.Add("OldRate", If(dgvhidden.Rows(i).Cells(5).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(5).Value.ToString)))
                    param.Add("AdjustedRate", If(dgvhidden.Rows(i).Cells(6).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(6).Value.ToString)))
                    param.Add("WorkDays", If(frmPayrollPrep.dgv.CurrentRow.Cells(9).Value.ToString = "", Nothing, frmPayrollPrep.dgv.CurrentRow.Cells(9).Value.ToString))
                    MySqlConn.Execute("PayrollAddEditPayrollEmployee", param, commandType:=CommandType.StoredProcedure)
                Next
            End If
        End If






    End Sub

    Private Sub cmbCollegeDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollegeDept.SelectedIndexChanged
        Try
            PrimaryKey = DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key
        Catch ex As Exception

        End Try


    End Sub
End Class
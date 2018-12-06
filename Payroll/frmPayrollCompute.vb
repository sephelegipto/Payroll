Imports Dapper
Public Class frmPayrollCompute

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Dispose()
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

    Private Sub cmbCollegeDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollegeDept.SelectedIndexChanged
        Try
            PrimaryKey = DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key
        Catch ex As Exception

        End Try
        If cmbType.Text = "Colleges" Then
            ExecuteSQLStatement("SELECT * FROM  ppayrollemployee WHERE Status = 1 and CollegeID = " & PrimaryKey & "", dgvhidden)
        Else
            ExecuteSQLStatement("SELECT * FROM  ppayrollemployee WHERE Status = 1 and DesignationID = " & PrimaryKey & "", dgvhidden)
        End If
        If dgvhidden.RowCount > 0 Then
            Try
                If cmbType.Text = "Colleges" Then
                    For i = 0 To dgvhidden.RowCount - 1

                        Dim param As DynamicParameters = New DynamicParameters
                        param.Add("LibraryToLoad", "Add Payroll Employee")
                        param.Add("PrepID", txtCode.Text)
                        param.Add("CollegeID", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
                        param.Add("DesignationID", Nothing)
                        param.Add("EmpID", If(dgvhidden.Rows(i).Cells(1).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(1).Value.ToString))
                        param.Add("PositionID", If(dgvhidden.Rows(i).Cells(9).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(9).Value.ToString))
                        param.Add("OldRate", If(dgvhidden.Rows(i).Cells(5).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(5).Value.ToString)))
                        param.Add("AdjustedRate", If(dgvhidden.Rows(i).Cells(6).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(6).Value.ToString)))
                        param.Add("WorkDays", WorkDays.Text)
                        MySqlConn.Execute("PayrollAddEditPayrollEmployee", param, commandType:=CommandType.StoredProcedure)

                    Next
                Else
                    For i = 0 To dgvhidden.RowCount - 1
                        Dim param As DynamicParameters = New DynamicParameters
                        param.Add("LibraryToLoad", "Add Payroll Employee")
                        param.Add("PrepID", txtCode.Text)
                        param.Add("CollegeID", Nothing)
                        param.Add("DesignationID", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
                        param.Add("EmpID", If(dgvhidden.Rows(i).Cells(1).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(1).Value.ToString))
                        param.Add("PositionID", If(dgvhidden.Rows(i).Cells(9).Value.ToString = "", Nothing, dgvhidden.Rows(i).Cells(9).Value.ToString))
                        param.Add("OldRate", If(dgvhidden.Rows(i).Cells(5).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(5).Value.ToString)))
                        param.Add("AdjustedRate", If(dgvhidden.Rows(i).Cells(6).Value.ToString = "", Nothing, RemoveComma(dgvhidden.Rows(i).Cells(6).Value.ToString)))
                        param.Add("WorkDays", WorkDays.Text)
                        MySqlConn.Execute("PayrollAddEditPayrollEmployee", param, commandType:=CommandType.StoredProcedure)
                    Next
                End If


            Catch ex As Exception

            End Try
            Reload()
        End If
    End Sub
    Sub Reload()
        Try
            If cmbType.Text = "Colleges" Then
                Dim param As DynamicParameters = New DynamicParameters
                param.Add("LibraryToLoad", "Payroll Details Colleges")
                param.Add("SearchText", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
                param.Add("PrepID", txtCode.Text)
                Dim list As List(Of payrollcompute) = MySqlConn.Query(Of payrollcompute)("PayrollViewPayroll", param, commandType:=CommandType.StoredProcedure).ToList()
                dgv.DataSource = list
            Else
                Dim param As DynamicParameters = New DynamicParameters
                param.Add("LibraryToLoad", "Payroll Details Department")
                param.Add("SearchText", DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key)
                param.Add("PrepID", txtCode.Text)
                Dim list As List(Of payrollcompute) = MySqlConn.Query(Of payrollcompute)("PayrollViewPayroll", param, commandType:=CommandType.StoredProcedure).ToList()
                dgv.DataSource = list
            End If
            Dim param2 As DynamicParameters = New DynamicParameters
            param2.Add("LibraryToLoad", "Payroll Sum")
            param2.Add("SearchText", txtCode.Text)
            Dim list2 As List(Of payrollsum) = MySqlConn.Query(Of payrollsum)("PayrollView", param2, commandType:=CommandType.StoredProcedure).ToList()
            dgvsum.DataSource = list2
            dgv.Columns(0).Width = 25
            dgv.Columns(1).Visible = False
            dgv.Columns(2).Visible = False
            dgv.Columns(3).Visible = False
            dgv.Columns(5).Frozen = True
            dgv.Columns(6).Frozen = True
            dgv.Columns(7).Width = 200
            dgv.Columns(48).Visible = False
            dgv.Columns(49).Visible = False
            dgv.Columns(50).Visible = False
            dgv.Columns(51).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For i = 0 To dgv.RowCount - 1
            dgv.Rows(i).Cells(0).Value = If(1 = dgv.Rows(i).Cells(53).Value, True, False)
        Next


    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit

        Dim param As DynamicParameters = New DynamicParameters
        param.Add("pID", dgv.CurrentRow.Cells(2).Value)
        param.Add("asalaryadjustment", dgv.CurrentRow.Cells(10).Value)

        param.Add("atax", dgv.CurrentRow.Cells(15).Value)
        param.Add("OptIns", dgv.CurrentRow.Cells(17).Value)
        param.Add("EducLoan", dgv.CurrentRow.Cells(18).Value)
        param.Add("CFA", dgv.CurrentRow.Cells(19).Value)
        param.Add("ConsolLoan", dgv.CurrentRow.Cells(20).Value)
        param.Add("PolicyLoan", dgv.CurrentRow.Cells(21).Value)
        param.Add("OptionLoan", dgv.CurrentRow.Cells(22).Value)
        param.Add("RealEstateLoan", dgv.CurrentRow.Cells(23).Value)
        param.Add("Eplus", dgv.CurrentRow.Cells(24).Value)
        param.Add("eml", dgv.CurrentRow.Cells(25).Value)
        param.Add("PremiumContri", dgv.CurrentRow.Cells(26).Value)
        param.Add("p2", dgv.CurrentRow.Cells(27).Value)
        param.Add("mpl", dgv.CurrentRow.Cells(28).Value)
        param.Add("calamityloan", dgv.CurrentRow.Cells(29).Value)
        param.Add("housing", dgv.CurrentRow.Cells(30).Value)
        param.Add("MedicareContri", dgv.CurrentRow.Cells(31).Value)
        param.Add("sss", dgv.CurrentRow.Cells(32).Value)
        param.Add("ppsta", dgv.CurrentRow.Cells(33).Value)
        param.Add("salaryloancocolife", dgv.CurrentRow.Cells(34).Value)
        param.Add("salaryloanPB", dgv.CurrentRow.Cells(35).Value)
        param.Add("educloanPB", dgv.CurrentRow.Cells(36).Value)
        param.Add("cvcat", dgv.CurrentRow.Cells(37).Value)
        param.Add("igp", dgv.CurrentRow.Cells(38).Value)
        param.Add("disallowance", dgv.CurrentRow.Cells(39).Value)
        param.Add("ACAPA", dgv.CurrentRow.Cells(40).Value)
        param.Add("APA", dgv.CurrentRow.Cells(41).Value)
        param.Add("UFA", dgv.CurrentRow.Cells(42).Value)
        param.Add("excesschasadvance", dgv.CurrentRow.Cells(43).Value)
        param.Add("dbploan", dgv.CurrentRow.Cells(44).Value)
        param.Add("chinabank", dgv.CurrentRow.Cells(45).Value)
        param.Add("cenadco", dgv.CurrentRow.Cells(46).Value)
        MySqlConn.Execute("PayrollEdit", param, commandType:=CommandType.StoredProcedure)

        ExecuteSQLStatement("SELECT * FROM ppayroll WHERE ID = '" & dgv.CurrentRow.Cells(2).Value & "'", dgvhidden)

        dgv.CurrentRow.Cells(46).Value = dgvhidden.Rows(0).Cells(47).Value
        dgv.CurrentRow.Cells(47).Value = dgvhidden.Rows(0).Cells(48).Value

        Dim param2 As DynamicParameters = New DynamicParameters
        param2.Add("LibraryToLoad", "Payroll Sum")
        param2.Add("SearchText", txtCode.Text)
        Dim list2 As List(Of payrollsum) = MySqlConn.Query(Of payrollsum)("PayrollView", param2, commandType:=CommandType.StoredProcedure).ToList()
        dgvsum.DataSource = list2

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

    End Sub

    Private Sub dgv_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs) Handles dgv.CellErrorTextNeeded

    End Sub

    Private Sub dgv_DataMemberChanged(sender As Object, e As EventArgs) Handles dgv.DataMemberChanged

    End Sub

    Private Sub LabelX1_Click(sender As Object, e As EventArgs) Handles LabelX1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To dgv.RowCount - 1
            Dim param As DynamicParameters = New DynamicParameters
            MsgBox(dgv.Rows(i).Cells(2).Value)
            param.Add("pID", dgv.Rows(i).Cells(2).Value)
            param.Add("Include", dgv.Rows(i).Cells(0).Value)

            MySqlConn.Execute("payrolleditinclude", param, commandType:=CommandType.StoredProcedure)
        Next
    End Sub
End Class
Imports Dapper
Public Class frmPayslip
    Private Sub frmPayslip_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mdiMainForm.bmPaySlip.Enabled = True
    End Sub

    Private Sub frmPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    End Sub



    Private Sub dgvdeductions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub btnPrintPreview1_Click(sender As Object, e As EventArgs) Handles btnPrintPreview1.Click
        frmPrinting.CallingForm = "Payslip"

        frmPrinting.CommandExecution = "SELECT * FROM csusisdb.ppayroll where empid = '" & dgv.CurrentRow.Cells(1).Value & "' ORDER BY payrollpreparationID DESC LIMIT 1"
        LookUpContent = DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Value
        frmPrinting.ShowDialog()
    End Sub
End Class
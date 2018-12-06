Imports Dapper
Public Class frmGeneralPayroll
    Private Sub frmGeneralPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Sub Reload()
        Dim param As DynamicParameters = New DynamicParameters
        param.Add("LibraryToLoad", "Payroll Prep")
        param.Add("SearchText", "")
        Dim list As List(Of PayrollPrep) = MySqlConn.Query(Of PayrollPrep)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
        dgv.DataSource = list
        dgv.Columns(0).Visible = False
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick

    End Sub

    Private Sub frmGeneralPayroll_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mdiMainForm.bmGenPay.Enabled = True
    End Sub

    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        mdiMainForm.bmGenPay.Enabled = True
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

    Private Sub btnPrintPreview1_Click(sender As Object, e As EventArgs) Handles btnPrintPreview1.Click
        If cmbType.Text = "" Then
            MsgBox("Please choose College or Department")
        Else
            frmPrinting.txtCode.Text = txtDescription.Text
            If cmbType.Text = "Colleges" Then
                frmPrinting.CallingForm = "General Payroll Page 1"
                frmPrinting.ShowDialog()
            Else
                frmPrinting.CallingForm = "General Payroll Page 1"
                frmPrinting.CommandExecution = "SELECT  * FROM ppayroll WHERE PayrollPreparationID = '" & AESwitch & "' and DesignationID = '" & PrimaryKey & "' "
                frmPrinting.ShowDialog()
            End If


        End If
    End Sub

    Private Sub btnPrintPreview2_Click(sender As Object, e As EventArgs) Handles btnPrintPreview2.Click
        If cmbType.Text = "" Then
            MsgBox("Please choose College or Department")
        Else
            If cmbType.Text = "Colleges" Then
                frmPrinting.CallingForm = "General Payroll Page 2"
                frmPrinting.ShowDialog()
            Else
                frmPrinting.CallingForm = "General Payroll Page 2"
                frmPrinting.CommandExecution = "SELECT  * FROM ppayroll WHERE PayrollPreparationID = '" & AESwitch & "' and DesignationID = '" & PrimaryKey & "' "
                frmPrinting.ShowDialog()
            End If


        End If
    End Sub

    Private Sub cmbCollegeDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollegeDept.SelectedIndexChanged
        Try
            PrimaryKey = DirectCast(cmbCollegeDept.SelectedItem, KeyValuePair(Of String, String)).Key
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Try
            AESwitch = If(dgv.CurrentRow.Cells(0).Value = Nothing, 0, dgv.CurrentRow.Cells(0).Value)
            txtCode.Text = If(dgv.CurrentRow.Cells(1).Value = Nothing, 0, dgv.CurrentRow.Cells(1).Value)
            txtDescription.Text = If(dgv.CurrentRow.Cells(2).Value = Nothing, 0, dgv.CurrentRow.Cells(2).Value)
            txtmonth.Text = If(dgv.CurrentRow.Cells(6).Value = Nothing, 0, dgv.CurrentRow.Cells(6).Value)
            txtyear.Text = If(dgv.CurrentRow.Cells(7).Value = Nothing, 0, dgv.CurrentRow.Cells(7).Value)
            txtFrom.Text = If(dgv.CurrentRow.Cells(8).Value = Nothing, 0, dgv.CurrentRow.Cells(8).Value)
            txtTo.Text = If(dgv.CurrentRow.Cells(9).Value = Nothing, 0, dgv.CurrentRow.Cells(9).Value)
            txtWorkDays.Text = If(dgv.CurrentRow.Cells(5).Value = Nothing, 0, dgv.CurrentRow.Cells(5).Value)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If cmbType.Text = "" Then
            MsgBox("Please choose College or Department")
        Else
            frmPrinting.txtCode.Text = txtDescription.Text
            If cmbType.Text = "Colleges" Then
                frmPrinting.CallingForm = "General Payroll Page 1"
                frmPrinting.ShowDialog()
            Else
                frmPrinting.CallingForm = "General Payroll Page 1"
                frmPrinting.CommandExecution = "SELECT  * FROM ppayroll WHERE PayrollPreparationID = '" & AESwitch & "' and DesignationID = '" & PrimaryKey & "' and Include ='1'"
                frmPrinting.ShowDialog()
            End If


        End If
    End Sub
End Class
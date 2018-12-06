
Imports Dapper
Public Class frmAddEditEmployeeDetails
    Dim param As DynamicParameters = New DynamicParameters
    Private Sub frmAddEditEmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
        dgv.Columns(3).Visible = False
        dgv.Columns(4).Visible = False
        Dim comboSource3 As New Dictionary(Of String, String)()
        Dim count3 As Integer = 0
        comboSource3.Add("0", "")
        comboSource3.Add("4", "Step1")
        comboSource3.Add("5", "Step2")
        comboSource3.Add("6", "Step3")
        comboSource3.Add("7", "Step4")
        comboSource3.Add("8", "Step5")
        comboSource3.Add("9", "Step6")
        comboSource3.Add("10", "Step7")
        comboSource3.Add("11", "Step8")
        cmbStep.DataSource = New BindingSource(comboSource3, Nothing)
        cmbStep.DisplayMember = "Value"
        cmbStep.ValueMember = "Key"
        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Sub Reload()
        OpenConnetion()
        Dim param As DynamicParameters = New DynamicParameters
        param.Add("LibraryToLoad", "Employee Designation")
        param.Add("SearchText", EmployeeID.Text)

        Dim list As List(Of EmployeeDesignation) = MySqlConn.Query(Of EmployeeDesignation)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
        dgv.DataSource = list
        dgv.Columns(0).Visible = False
        dgv.Columns(1).Width = 350
        dgv.Columns(2).Visible = False


        For i = 12 To 15
            dgv.Columns(i).Visible = False
        Next
        dgv.ClearSelection()

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmAddEditEmployeeDetails_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave

    End Sub

    Private Sub frmAddEditEmployeeDetails_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub cmbEmploymentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmploymentStatus.SelectedIndexChanged
        Try


            If DirectCast(cmbEmploymentStatus.SelectedItem, KeyValuePair(Of String, String)).Key = "3" Then
                lblTo.Visible = True
                dateTo.Visible = True
                panelPerHour.Visible = True
                panelPerHour.Location = New Point(618, 248)
                panelPermanent.Visible = False
                panelPerDay.Visible = False
            ElseIf DirectCast(cmbEmploymentStatus.SelectedItem, KeyValuePair(Of String, String)).Key = 4 Then

                lblTo.Visible = False
                dateTo.Visible = False
                panelPermanent.Visible = True
                panelPermanent.Location = New Point(618, 248)
                panelPerDay.Visible = False
                panelPerHour.Visible = False
            ElseIf DirectCast(cmbEmploymentStatus.SelectedItem, KeyValuePair(Of String, String)).Key = 5 Then
                lblTo.Visible = True
                dateTo.Visible = True
                panelPermanent.Visible = False
                panelPerDay.Visible = False
                panelPerHour.Visible = False
            Else
                lblTo.Visible = True
                dateTo.Visible = True
                panelPermanent.Visible = False
                panelPerDay.Visible = True
                panelPerHour.Visible = False
                panelPerDay.Location = New Point(618, 248)
            End If
        Catch ex As Exception

        End Try
        TextBoxX2.Text = ""
        TextBoxX1.Text = ""
        tGradRate.Text = ""
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Try
            Dim f As New frmSelectionList
            f.CallingForm = "Educ Attain"
            f.ShowDialog()
            tDeanDesc.Text = LookUpContent
            TextBoxX2.Text = LookUpContentID.ToString("n2")

            LookUpContent = ""
            LookUpContentID = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableAddEdit()
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnEdit.Enabled = False
        AESwitch = 0

        Me.cmbCollege.SelectedValue = 0
        Me.cmbPosition.SelectedValue = 0
        Me.cmbDesignation.SelectedValue = 0
        Me.cmbEmploymentStatus.SelectedValue = 0
        Me.cmbSalaryGrade.SelectedValue = 0
        Me.cmbStep.SelectedValue = 0

    End Sub


    Sub EnableAddEdit()
        cmbCollege.Enabled = True
        cmbDesignation.Enabled = True
        cmbEmploymentStatus.Enabled = True
        cmbPosition.Enabled = True
        dateFrom.Enabled = True
        dateTo.Enabled = True
        tDeanDesc.Enabled = True
        TextBoxX2.Enabled = True
        ButtonX1.Enabled = True
        TextBoxX1.Enabled = True
        cmbSalaryGrade.Enabled = True
        cmbStep.Enabled = True
    End Sub

    Sub DisableAddEdit()
        cmbCollege.Enabled = False
        cmbDesignation.Enabled = False
        cmbEmploymentStatus.Enabled = False
        cmbPosition.Enabled = False
        dateFrom.Enabled = False
        dateTo.Enabled = False
        tDeanDesc.Enabled = False
        TextBoxX2.Enabled = False
        ButtonX1.Enabled = False
        TextBoxX1.Enabled = False
        cmbSalaryGrade.Enabled = False
        cmbStep.Enabled = False
        Me.cmbCollege.SelectedValue = 0
        Me.cmbPosition.SelectedValue = 0
        Me.cmbDesignation.SelectedValue = 0
        Me.cmbEmploymentStatus.SelectedValue = 0
        Me.cmbSalaryGrade.SelectedValue = 0
        Me.cmbStep.SelectedValue = 0
        tDeanDesc.Text = ""
        TextBoxX2.Text = ""
        TextBoxX1.Text = ""
        tGradRate.Text = ""
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnEdit.Enabled = True
        DisableAddEdit()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click


        Try
            AESwitch = dgv.CurrentRow.Cells(0).Value

            Me.cmbCollege.SelectedValue = If(dgv.CurrentRow.Cells(14).Value = Nothing, 0, dgv.CurrentRow.Cells(14).Value)
            Me.cmbPosition.SelectedValue = If(dgv.CurrentRow.Cells(13).Value = Nothing, 0, dgv.CurrentRow.Cells(13).Value)
            Me.cmbDesignation.SelectedValue = If(dgv.CurrentRow.Cells(12).Value = Nothing, 0, dgv.CurrentRow.Cells(12).Value)
            Me.cmbEmploymentStatus.SelectedValue = If(dgv.CurrentRow.Cells(15).Value = Nothing, 0, dgv.CurrentRow.Cells(15).Value)
            TextBoxX1.Text = If(dgv.CurrentRow.Cells(8).Value = Nothing, "", dgv.CurrentRow.Cells(8).Value)
            TextBoxX2.Text = If(dgv.CurrentRow.Cells(7).Value = Nothing, "", dgv.CurrentRow.Cells(7).Value)
            cmbSalaryGrade.Text = If(dgv.CurrentRow.Cells(10).Value = Nothing, "", dgv.CurrentRow.Cells(10).Value)
            cmbStep.Text = If(dgv.CurrentRow.Cells(9).Value = Nothing, "", dgv.CurrentRow.Cells(9).Value)
            tGradRate.Text = If(dgv.CurrentRow.Cells(11).Value = Nothing, "", dgv.CurrentRow.Cells(11).Value)
            dateFrom.Text = If(dgv.CurrentRow.Cells(5).Value = Nothing, "", dgv.CurrentRow.Cells(5).Value)
            dateTo.Text = If(dgv.CurrentRow.Cells(6).Value = Nothing, "", dgv.CurrentRow.Cells(6).Value)

            btnNew.Enabled = False
            btnSave.Enabled = True
            btnCancel.Enabled = True
            btnEdit.Enabled = False
            EnableAddEdit()
        Catch ex As Exception
            MsgBox("Please Select Record")
        End Try


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbEmploymentStatus.Text = "Permanent/Regular" Then
            TextBoxX2.Text = ""
            TextBoxX1.Text = ""
            dateTo.Text = ""
        ElseIf cmbEmploymentStatus.Text = "Part Time" Then
            TextBoxX1.Text = ""
            tGradRate.Text = Nothing
            Me.cmbSalaryGrade.SelectedValue = 0
            Me.cmbStep.SelectedValue = 0
        Else
            TextBoxX2.Text = ""
            tGradRate.Text = Nothing
            Me.cmbSalaryGrade.SelectedValue = 0
            Me.cmbStep.SelectedValue = 0
        End If

        If AESwitch = 0 Then
            With param
                .Add("AESwitch", PrimaryKey)
                .Add("LibraryToAddEdit", "Add Employee Designation")
                .Add("EmployeeID", EmployeeID.Text.Trim)
                Try
                    .Add("DesignationID", DirectCast(cmbDesignation.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("DesignationID", "")
                End Try
                Try
                    .Add("PositionID", DirectCast(cmbPosition.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("PositionID", "")
                End Try
                Try
                    .Add("SalaryGradeID", DirectCast(cmbSalaryGrade.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("SalaryGradeID", "")
                End Try
                Try
                    .Add("EmploymenyStatusID", DirectCast(cmbEmploymentStatus.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("EmploymenyStatusID", "")
                End Try

                Try
                    .Add("CollegeID", DirectCast(cmbCollege.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("CollegeID", "")
                End Try

                .Add("DateFrom", dateFrom.Value.ToString("yyyy-MM-dd"))
                If cmbEmploymentStatus.Text <> "Permanent/Regular" Then
                    .Add("DateTo", dateTo.Value.ToString("yyyy-MM-dd"))
                Else
                    .Add("DateTo", "")
                End If
                .Add("Status", 1)
                .Add("RatePerHour", TextBoxX2.Text)
                .Add("RatePerDay", TextBoxX1.Text)
                .Add("SalarayStep", cmbStep.Text)
                .Add("SalarayGrade", cmbSalaryGrade.Text)
                .Add("SalaryGradeAmount", tGradRate.Text)
            End With
            MySqlConn.Execute("PayrollAddEditEmployeeDesignation", param, commandType:=CommandType.StoredProcedure)
            DisableAddEdit()
        Else
            With param
                .Add("AESwitch", AESwitch)
                .Add("LibraryToAddEdit", "Edit Employee Designation")
                .Add("EmployeeID", EmployeeID.Text.Trim)
                Try
                    .Add("DesignationID", DirectCast(cmbDesignation.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("DesignationID", "")
                End Try
                Try
                    .Add("PositionID", DirectCast(cmbPosition.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("PositionID", "")
                End Try
                Try
                    .Add("EmploymenyStatusID", DirectCast(cmbEmploymentStatus.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("EmploymenyStatusID", "")
                End Try
                Try
                    .Add("SalaryGradeID", DirectCast(cmbSalaryGrade.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("SalaryGradeID", "")
                End Try
                Try
                    .Add("CollegeID", DirectCast(cmbCollege.SelectedItem, KeyValuePair(Of String, String)).Key)
                Catch ex As Exception
                    .Add("CollegeID", "")
                End Try

                .Add("DateFrom", dateFrom.Value.ToString("yyyy-MM-dd"))
                If cmbEmploymentStatus.Text <> "Permanent/Regular" Then
                    .Add("DateTo", dateTo.Value.ToString("yyyy-MM-dd"))
                Else

                    .Add("DateTo", "")
                End If


                .Add("RatePerHour", TextBoxX2.Text)
                .Add("RatePerDay", TextBoxX1.Text)
                .Add("SalarayStep", cmbStep.Text)
                .Add("SalarayGrade", cmbSalaryGrade.Text)
                .Add("SalaryGradeAmount", tGradRate.Text)
            End With
            MySqlConn.Execute("PayrollAddEditEmployeeDesignation", param, commandType:=CommandType.StoredProcedure)
            DisableAddEdit()
        End If
        Reload()
        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnEdit.Enabled = True
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        PrimaryKey = dgv.CurrentRow.Cells(0).Value
        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnEdit.Enabled = True
        TextBoxX2.Text = ""
        TextBoxX1.Text = ""
        tGradRate.Text = ""
        DisableAddEdit()
    End Sub

    Private Sub tGradRate_TextChanged(sender As Object, e As EventArgs) Handles tGradRate.TextChanged

    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged

    End Sub

    Private Sub TextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX2.TextChanged

    End Sub

    Private Sub cmbSalaryGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSalaryGrade.SelectedIndexChanged

        If cmbStep.Text <> "" Then

            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Employee Add Salary Grades")
            param.Add("SearchText", cmbSalaryGrade.Text)
            Dim list As List(Of SalaryGrade) = MySqlConn.Query(Of SalaryGrade)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgvhidden.DataSource = list
            Try
                tGradRate.Text = dgvhidden.CurrentRow.Cells(Convert.ToInt32(DirectCast(cmbStep.SelectedItem, KeyValuePair(Of String, String)).Key)).Value + ".00"

            Catch ex As Exception

            End Try
        Else
            tGradRate.Text = Nothing
        End If
    End Sub

    Private Sub cmbStep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStep.SelectedIndexChanged
        If cmbSalaryGrade.Text <> "" Then
            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", "Employee Add Salary Grades")
            param.Add("SearchText", cmbSalaryGrade.Text)
            Dim list As List(Of SalaryGrade) = MySqlConn.Query(Of SalaryGrade)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
            dgvhidden.DataSource = list
            Try
                tGradRate.Text = dgvhidden.CurrentRow.Cells(Convert.ToInt32(DirectCast(cmbStep.SelectedItem, KeyValuePair(Of String, String)).Key)).Value + ".00"
            Catch ex As Exception


            End Try
        Else
            tGradRate.Text = Nothing
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If MessageBox.Show(Me, "Do you really want To delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim param As DynamicParameters = New DynamicParameters
            param.Add("IDToDelete", dgv.CurrentRow.Cells(0).Value)
            param.Add("LibraryToDelete", "TitleDesignation")
            MySqlConn.Execute("PayrollDelete", param, commandType:=CommandType.StoredProcedure)
        End If
        Reload()
        MsgBox("Record Successfully Delete")
    End Sub

    Private Sub dateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dateFrom.ValueChanged

    End Sub
End Class
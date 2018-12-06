
Imports Dapper
Public Class frmAddEdit1
    Private iPrimaryKey As Integer = 0
    Private sFormOpeMode As String
    Private sCallingForm As String
    Dim param As DynamicParameters = New DynamicParameters
    Public Property CallingForm() As String
        Get
            Return sCallingForm
        End Get
        Set(ByVal Value As String)
            sCallingForm = Value
        End Set
    End Property
    Public Property FormOpeMode() As String
        Get
            Return sFormOpeMode
        End Get
        Set(ByVal Value As String)
            sFormOpeMode = Value
        End Set
    End Property
    Public Property PrimaryKey() As Integer
        Get
            Return iPrimaryKey
        End Get
        Set(ByVal Value As Integer)
            iPrimaryKey = Value
        End Set
    End Property
    Private Sub frmAddEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                SaveRecord()
            Case Keys.Escape
                Me.Dispose()
        End Select
    End Sub

    Private Sub frmAddEdit1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRecord()

    End Sub

    Sub SaveRecord()

        '################################ CHECK TEXTBOXES ################################
        '#################################################################################

        Select Case Me.CallingForm

            Case "Positions"
                If Len(Trim(positionCode.Text)) = 0 Or Len(Trim(positionDesc.Text)) = 0 Then
                    If Len(Trim(positionCode.Text)) = 0 And Len(Trim(positionDesc.Text)) <> 0 Then
                        MsgBox("The " & Trim(lblPositionCode.Text) & " should not be left blank!", vbOKOnly + vbInformation, "Error!")
                        positionCode.Focus()
                    ElseIf Len(Trim(positionCode.Text)) <> 0 And Len(Trim(positionDesc.Text)) = 0 Then
                        MsgBox("The " & Trim(lblPositionDescription.Text) & " should not be left blank!", vbOKOnly + vbInformation, "Error!")
                        positionDesc.Focus()
                    Else
                        MsgBox("The " & Trim(lblPositionCode.Text) & " and " & Trim(lblPositionDescription.Text) & " should not be left blank!", vbOKOnly + vbInformation, "Error!")
                        positionCode.Focus()
                    End If

                    Exit Sub
                End If
        End Select

        If Trim(Me.FormOpeMode) = "Add" Then
            '################################ SAVE RECORD ####################################
            '#################################################################################
            Select Case Me.CallingForm
                Case "Positions"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Position")
                        .Add("ParamCode", positionCode.Text.Trim)
                        .Add("ParamDescription", positionDesc.Text.Trim)
                    End With
                    MySqlConn.Execute("spLibraryAddOREdit", param, commandType:=CommandType.StoredProcedure)
                Case "Departments"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Department")
                        .Add("ParamCode", tDeptCode.Text.Trim)
                        .Add("ParamDescription", tDeptDesc.Text.Trim)
                        .Add("ParamHead", Val(DeanID.Text.Trim))
                    End With
                    MySqlConn.Execute("spDepartmentsCollegesAddOREdit", param, commandType:=CommandType.StoredProcedure)
                Case "Colleges"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add College")
                        .Add("ParamCode", tDeptCode.Text.Trim)
                        .Add("ParamDescription", tDeptDesc.Text.Trim)
                        .Add("ParamHead", Val(DeanID.Text.Trim))
                    End With
                    MySqlConn.Execute("spDepartmentsCollegesAddOREdit", param, commandType:=CommandType.StoredProcedure)
                Case "Departments"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Department")
                        .Add("ParamCode", tDeptCode.Text.Trim)
                        .Add("ParamDescription", tDeptDesc.Text.Trim)
                        .Add("ParamHead", Val(DeanID.Text.Trim))
                    End With
                    MySqlConn.Execute("spDepartmentsCollegesAddOREdit", param, commandType:=CommandType.StoredProcedure)
                Case "Salary Grades"

                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Salary Grade")
                        .Add("TranchID", TranchID.Text.Trim)
                        .Add("SalaryGradeID", SalaryGradeID.Text.Trim)
                        .Add("Step1", s1.Text.Trim)
                        .Add("Step2", s2.Text.Trim)
                        .Add("Step3", s3.Text.Trim)
                        .Add("Step4", s4.Text.Trim)
                        .Add("Step5", s5.Text.Trim)
                        .Add("Step6", s6.Text.Trim)
                        .Add("Step7", s7.Text.Trim)
                        .Add("Step8", s8.Text.Trim)
                    End With
                    MySqlConn.Execute("PayrollAddEditSalaryGrade", param, commandType:=CommandType.StoredProcedure)
                Case "Tranch"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Tranch")
                        .Add("FirstParam", txt.Text)
                        .Add("SecondParam", 1)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Rates"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Rate")
                        .Add("FirstParam", txt11.Text)
                        .Add("SecondParam", cmbLevel.Text)
                        .Add("ThirdParam", txt12.Text)
                        .Add("FourthParam", txt13.Text)
                    End With
                    MySqlConn.Execute("Payroll4Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Incomes"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Income")
                        .Add("FirstParam", txt1.Text)
                        .Add("SecondParam", txt2.Text)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Deductions"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Deduction")
                        .Add("FirstParam", txt1.Text)
                        .Add("SecondParam", txt2.Text)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Deductions"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Add Designation")
                        .Add("FirstParam", txt1.Text)
                        .Add("SecondParam", txt2.Text)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
            End Select

        ElseIf Trim(Me.FormOpeMode) = "Edit" Then

            '############################## UPDATE RECORD ####################################
            '#################################################################################
            Select Case Me.CallingForm
                Case "Positions"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Position")
                        .Add("ParamCode", positionCode.Text.Trim)
                        .Add("ParamDescription", positionDesc.Text.Trim)
                    End With
                    MySqlConn.Execute("spLibraryAddOREdit", param, commandType:=CommandType.StoredProcedure)
                Case "Departments"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Department")
                        .Add("ParamCode", tDeptCode.Text.Trim)
                        .Add("ParamDescription", tDeptDesc.Text.Trim)
                        .Add("ParamHead", Val(DeanID.Text.Trim))
                    End With
                    MySqlConn.Execute("spDepartmentsCollegesAddOREdit", param, commandType:=CommandType.StoredProcedure)
                Case "Colleges"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit College")
                        .Add("ParamCode", tDeptCode.Text.Trim)
                        .Add("ParamDescription", tDeptDesc.Text.Trim)
                        .Add("ParamHead", Val(DeanID.Text.Trim))
                    End With
                    MySqlConn.Execute("spDepartmentsCollegesAddOREdit", param, commandType:=CommandType.StoredProcedure)

                Case "Salary Grades"

                    With param

                        .Add("AESwitch", PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Salary Grade")
                        .Add("TranchID", TranchID.Text.Trim)
                        .Add("SalaryGradeID", SalaryGradeID.Text.Trim)
                        .Add("Step1", s1.Text.Trim)
                        .Add("Step2", s2.Text.Trim)
                        .Add("Step3", s3.Text.Trim)
                        .Add("Step4", s4.Text.Trim)
                        .Add("Step5", s5.Text.Trim)
                        .Add("Step6", s6.Text.Trim)
                        .Add("Step7", s7.Text.Trim)
                        .Add("Step8", s8.Text.Trim)

                    End With
                    MySqlConn.Execute("PayrollAddEditSalaryGrade", param, commandType:=CommandType.StoredProcedure)
                Case "Tranch"
                    Dim key As String = DirectCast(cmbList.SelectedItem, KeyValuePair(Of String, String)).Key
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Tranch")
                        .Add("FirstParam", TextBoxX2.Text.Trim)
                        .Add("SecondParam", key)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Rates"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Rate")
                        .Add("FirstParam", txt11.Text)
                        .Add("SecondParam", cmbLevel.Text)
                        .Add("ThirdParam", txt12.Text)
                        .Add("FourthParam", txt13.Text)
                    End With
                    MySqlConn.Execute("Payroll4Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Incomes"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Income")
                        .Add("FirstParam", txt1.Text)
                        .Add("SecondParam", txt2.Text)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Deductions"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Deduction")
                        .Add("FirstParam", txt1.Text)
                        .Add("SecondParam", txt2.Text)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)
                Case "Designations"
                    With param
                        .Add("AESwitch", Me.PrimaryKey)
                        .Add("LibraryToAddEdit", "Edit Designation")
                        .Add("FirstParam", txt1.Text)
                        .Add("SecondParam", txt2.Text)
                    End With
                    MySqlConn.Execute("Payroll2Fields", param, commandType:=CommandType.StoredProcedure)

            End Select
        End If
        Me.Dispose()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        Try
            Dim f As New frmSelectionList
            f.CallingForm = "Dean Lookup"
            f.ShowDialog()
            tDeanDesc.Text = LookUpContent
            DeanID.Text = LookUpContentID
            LookUpContent = ""
            LookUpContentID = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub btnSelDeductions_Click(sender As Object, e As EventArgs) Handles btnSelDeductions.Click

    End Sub

    Private Sub btnSelIncomeOI_Click(sender As Object, e As EventArgs) Handles btnSelIncomeOI.Click

    End Sub

    Private Sub btnSelDedOD_Click(sender As Object, e As EventArgs) Handles btnSelDedOD.Click

    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged

    End Sub

    Private Sub btnSelIncome_Click(sender As Object, e As EventArgs) Handles btnSelIncome.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        frmSelectionList.CallingForm = "Tranch"
        frmSelectionList.Text = "Tranch Lookup"
        frmSelectionList.ShowDialog()
        TranchDescription.Text = LookUpContent
        TranchID.Text = LookUpContentID
        LookUpContent = ""
        LookUpContentID = 0
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        frmSelectionList.CallingForm = "Salary Grade"
        frmSelectionList.Text = "Salary Grade Lookup"
        frmSelectionList.ShowDialog()
        SalaryGrade.Text = LookUpContent
        SalaryGradeID.Text = LookUpContentID
        LookUpContent = ""
        LookUpContentID = 0
    End Sub
End Class
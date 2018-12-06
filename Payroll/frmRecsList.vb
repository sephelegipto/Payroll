Imports System.ComponentModel
Imports Dapper
Public Class frmRecsList
    Private sLoadTable As String
    Dim sFormText As String
    Private sFindTitle As String
    Public Property FindTitle() As String
        Get
            Return sFindTitle
        End Get
        Set(ByVal Value As String)
            sFindTitle = Value
        End Set
    End Property
    Public Property LoadTable() As String
        Get
            Return sLoadTable
        End Get
        Set(ByVal Value As String)
            sLoadTable = Value
        End Set
    End Property



    Private Sub frmRecsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConnetion()
        sFormText = Trim(Me.Text)
        reload()
    End Sub


    Sub reload()

        Try
            OpenConnetion()
            Dim param As DynamicParameters = New DynamicParameters
            param.Add("LibraryToLoad", LoadTable)
            param.Add("SearchText", Me.txtSearch.Text)

            Select Case Trim(Me.Text)
                Case "Positions"
                    Dim list As List(Of Positions) = MySqlConn.Query(Of Positions)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Salary Grades"
                    Dim list As List(Of Ranks) = MySqlConn.Query(Of Ranks)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Departments"
                    Dim list As List(Of Departments) = MySqlConn.Query(Of Departments)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Incomes"
                    Dim list As List(Of Incomes) = MySqlConn.Query(Of Incomes)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Deductions"
                    Dim list As List(Of Deductions) = MySqlConn.Query(Of Deductions)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Tranch"
                    Dim list As List(Of Tranch) = MySqlConn.Query(Of Tranch)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Pay-Periods"

                Case "Rates"
                    Dim list As List(Of Rates) = MySqlConn.Query(Of Rates)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "Colleges"
                    Dim list As List(Of Colleges) = MySqlConn.Query(Of Colleges)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list
                Case "PhilHealth Contribution Schedule", "GSIS Contribution Schedule"

                Case "Monthly Witholding Tax"

                Case "Yearly Income Tax"

                Case "Employee List"
                    Dim list As List(Of Employees) = MySqlConn.Query(Of Employees)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                    dgv.DataSource = list

            End Select



            lblRecCount.Text = dgv.RowCount & " Record(s) found."
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        FormatDataGridView()
    End Sub
    Sub FormatDataGridView()
        'TOTAL  : 675
        Select Case Trim(Me.Text)
            Case "Positions"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 575
                dgv.Columns(3).Visible = False
            Case "Salary Grades"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 175
                dgv.Columns(12).Visible = False
                dgv.Columns(13).Visible = False
                dgv.Width = 1200
            Case "Incomes", "Deductions", "Designations"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 175
                dgv.Columns(2).Width = 500
            Case "Departments", "Colleges"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 100
                dgv.Columns(2).Width = 325
                dgv.Columns(3).Visible = False
                dgv.Columns(4).Width = 250
            Case "Tranch"
                dgv.Columns(0).Visible = 100
                dgv.Columns(1).Width = 325
                dgv.Columns(2).Width = 250
                dgv.Columns(3).Visible = False
            Case "Pay-Periods"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 105
                dgv.Columns(2).Width = 220
                dgv.Columns(3).Width = 70
                dgv.Columns(4).Width = 70
                dgv.Columns(5).Width = 70
                dgv.Columns(6).Width = 70
                dgv.Columns(7).Width = 70
                dgv.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case "Rates"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 300
                dgv.Columns(2).Width = 175
                dgv.Columns(3).Width = 100
                dgv.Columns(4).Width = 100
                dgv.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgv.Columns.Item(3).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(4).DefaultCellStyle.Format = "N2"
            Case "PhilHealth Contribution Schedule", "GSIS Contribution Schedule"
                dgv.Columns(0).Width = 115
                dgv.Columns(1).Width = 90
                dgv.Columns(2).Width = 90
                dgv.Columns(3).Width = 120
                dgv.Columns(4).Width = 150
                dgv.Columns(5).Width = 110

                dgv.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgv.Columns.Item(1).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(2).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(3).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(4).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(5).DefaultCellStyle.Format = "N2"
            Case "Monthly Witholding Tax"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 135
                dgv.Columns(2).Width = 440
                dgv.Columns(3).Width = 100
                dgv.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(3).DefaultCellStyle.Format = "N2"
            Case "Yearly Income Tax"
                dgv.Columns(0).Width = 125
                dgv.Columns(1).Width = 135
                dgv.Columns(2).Width = 135
                dgv.Columns(3).Width = 135
                dgv.Columns(4).Width = 135

                dgv.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgv.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgv.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgv.Columns.Item(1).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(2).DefaultCellStyle.Format = "N2"
                dgv.Columns.Item(3).DefaultCellStyle.Format = "N2"
            Case "Employee List"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 150
                dgv.Columns(2).Width = 290
                dgv.Columns(12).Width = 130
                For i = 3 To 7
                    dgv.Columns(i).Visible = False
                Next
                For i = 9 To 11
                    dgv.Columns(i).Visible = False
                Next
                For i = 13 To 30
                    dgv.Columns(i).Visible = False
                Next
        End Select


    End Sub
    Sub CloseMe()
        Select Case Trim(Me.Text)
            Case "Positions"
                mdiMainForm.bmPositions.Enabled = True
            Case "Departments"
                mdiMainForm.bmDepartments.Enabled = True
            Case "Colleges"
                mdiMainForm.bmColleges.Enabled = True
            Case "Salary Grades"
                mdiMainForm.bmRanks.Enabled = True
            Case "Pay-Periods"

            Case "Rates"
                mdiMainForm.bmRates.Enabled = True
            Case "Tranch"
                mdiMainForm.bmTranch.Enabled = True
            Case "Incomes"
                mdiMainForm.bmIncome.Enabled = True
            Case "Deductions"
                mdiMainForm.bmDeductions.Enabled = True
            Case "Employee List"
                mdiMainForm.bmEmployees.Enabled = True

        End Select
        Me.Dispose()
    End Sub

    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseMe()
    End Sub

    Private Sub frmRecsList_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CloseMe()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        FindRecord()
    End Sub
    Sub FindRecord()
        frmFind.Text = "Find " & FindTitle
        frmFind.ShowDialog()
        txtSearch.Text = Search
    End Sub

    Private Sub frmRecsList_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        reload()
    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        reload()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        EditRecord()
    End Sub
    Sub EditRecord()

       FormatAddEditForm()
        If dgv.Rows.Count > 0 Then
            Select Case sFormText
                Case "Positions", "Departments", "Salary Grades", "Pay-Periods", "Rates", "Incomes", "Deductions",
                     "PhilHealth Contribution Schedule", "GSIS Contribution Schedule", "Monthly Witholding Tax",
                     "Yearly Income Tax", "Tranch", "Colleges"
                    frmAddEdit1.FormOpeMode = "Edit"
                    frmAddEdit1.PrimaryKey = dgv.CurrentRow.Cells(0).Value
                    frmAddEdit1.CallingForm = sFormText

                    Select Case sFormText
                        Case "Positions"
                            frmAddEdit1.Text = "Edit " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText) - 1)
                            frmAddEdit1.positionCode.Text = dgv.CurrentRow.Cells(1).Value
                            frmAddEdit1.positionDesc.Text = dgv.CurrentRow.Cells(2).Value
                        Case "Departments"
                            frmAddEdit1.Text = "Edit Department"
                            frmAddEdit1.tDeptCode.Text = dgv.CurrentRow.Cells(1).Value

                            frmAddEdit1.tDeptDesc.Text = dgv.CurrentRow.Cells(2).Value
                            frmAddEdit1.tDeanDesc.Text = dgv.CurrentRow.Cells(3).Value
                            'frmAddEdit1.ForeignKey = dgv.CurrentRow.Cells(4).Value
                            frmAddEdit1.txt1.Enabled = False

                        Case "Colleges"
                            frmAddEdit1.Text = "Edit Colleges"
                            frmAddEdit1.tDeptCode.Text = dgv.CurrentRow.Cells(1).Value

                            frmAddEdit1.tDeptDesc.Text = dgv.CurrentRow.Cells(2).Value
                            frmAddEdit1.tDeanDesc.Text = dgv.CurrentRow.Cells(3).Value
                            'frmAddEdit1.ForeignKey = dgv.CurrentRow.Cells(4).Value
                            frmAddEdit1.txt1.Enabled = False
                        Case "Incomes", "Deductions"
                            frmAddEdit1.Text = "Edit " & sFormText
                            frmAddEdit1.lbl1.Text = "Code"
                            frmAddEdit1.lbl2.Text = "Description"
                            frmAddEdit1.txt1.Text = dgv.CurrentRow.Cells(1).Value
                            frmAddEdit1.txt2.Text = dgv.CurrentRow.Cells(2).Value
                        Case "Rates"

                            frmAddEdit1.panRates.Visible = True
                            frmAddEdit1.panRates.Left = 7
                            frmAddEdit1.panRates.Top = 7
                            frmAddEdit1.Width = 450
                            frmAddEdit1.Height = 230
                            frmAddEdit1.btnSave.Top = 134
                            frmAddEdit1.btnCancel.Top = 134
                            frmAddEdit1.Text = "Edit Rate"
                            frmAddEdit1.txt11.Text = dgv.CurrentRow.Cells(1).Value
                            frmAddEdit1.cmbLevel.Text = dgv.CurrentRow.Cells(2).Value
                            frmAddEdit1.txt12.Text = dgv.CurrentRow.Cells(3).Value
                            frmAddEdit1.txt13.Text = dgv.CurrentRow.Cells(4).Value
                        Case "Tranch"
                            frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText))
                            frmAddEdit1.PanelEx2.Visible = True
                            frmAddEdit1.PanelEx2.Left = 7
                            frmAddEdit1.PanelEx2.Top = 7
                            frmAddEdit1.Width = 450
                            frmAddEdit1.Height = 170
                            frmAddEdit1.btnSave.Top = 70
                            frmAddEdit1.btnCancel.Top = 70
                            frmAddEdit1.lbl.Text = "Tranch"
                            frmAddEdit1.LabelX9.Text = "Tranch"
                            frmAddEdit1.LabelX8.Text = "Status"
                            frmAddEdit1.TextBoxX2.Text = dgv.CurrentRow.Cells(1).Value
                            Dim comboSource As New Dictionary(Of String, String)()
                            comboSource.Add("0", "Inactive")
                            comboSource.Add("1", "Active")
                            frmAddEdit1.cmbList.DataSource = New BindingSource(comboSource, Nothing)
                            frmAddEdit1.cmbList.DisplayMember = "Value"
                            frmAddEdit1.cmbList.ValueMember = "Key"
                            frmAddEdit1.cmbList.SelectedValue = dgv.CurrentRow.Cells(3).Value
                        Case "Salary Grades"
                            frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText))
                            frmAddEdit1.PanelEx3.Visible = True
                            frmAddEdit1.PanelEx3.Left = 7
                            frmAddEdit1.PanelEx3.Top = 7
                            frmAddEdit1.sCode.Text = dgv.CurrentRow.Cells(1).Value
                            frmAddEdit1.sDescription.Text = dgv.CurrentRow.Cells(2).Value
                            ExecuteSQLStatement("SELECT * FROM vtranch", dgvhidden)
                            Dim comboSource As New Dictionary(Of String, String)()
                            Dim count As Integer = 0
                            For j As Integer = 0 To dgvhidden.RowCount - 2
                                comboSource.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(1).Value.ToString)
                                count += 1
                            Next
                            frmAddEdit1.cmbSTranch.DataSource = New BindingSource(comboSource, Nothing)
                            frmAddEdit1.cmbSTranch.DisplayMember = "Value"
                            frmAddEdit1.cmbSTranch.ValueMember = "Key"
                            frmAddEdit1.cmbSTranch.SelectedValue = dgv.CurrentRow.Cells(12).Value
                            frmAddEdit1.s1.Text = dgv.CurrentRow.Cells(4).Value
                            frmAddEdit1.s2.Text = dgv.CurrentRow.Cells(5).Value
                            frmAddEdit1.s3.Text = dgv.CurrentRow.Cells(6).Value
                            frmAddEdit1.s4.Text = dgv.CurrentRow.Cells(7).Value
                            frmAddEdit1.s5.Text = dgv.CurrentRow.Cells(8).Value
                            frmAddEdit1.s6.Text = dgv.CurrentRow.Cells(9).Value
                            frmAddEdit1.s7.Text = dgv.CurrentRow.Cells(10).Value
                            frmAddEdit1.s8.Text = dgv.CurrentRow.Cells(11).Value
                            frmAddEdit1.Width = 450
                            frmAddEdit1.Height = 400
                            frmAddEdit1.btnSave.Top = 300
                            frmAddEdit1.btnCancel.Top = 300
                            frmAddEdit1.lbl.Text = "Salary Grades"
                    End Select
                    frmAddEdit1.ShowDialog()
                Case "Employee List"

                    frmAddEditEmployee.Text = "Edit Employee"
                    frmAddEditEmployee.FormOpeMode = "Edit"
                    frmAddEditEmployee.tEmployeeIDNo.Enabled = False

                    frmAddEditEmployee.PrimaryKey = dgv.CurrentRow.Cells(0).Value

                    frmAddEditEmployee.tEmployeeIDNo.Text = dgv.CurrentRow.Cells(0).Value
                    frmAddEditEmployee.tEmpID.Text = dgv.CurrentRow.Cells(1).Value
                    frmAddEditEmployee.tLastName.Text = dgv.CurrentRow.Cells(4).Value
                    frmAddEditEmployee.tFirstName.Text = dgv.CurrentRow.Cells(5).Value
                    frmAddEditEmployee.tMiddleName.Text = dgv.CurrentRow.Cells(6).Value
                    frmAddEditEmployee.cmbGender.Text = dgv.CurrentRow.Cells(13).Value
                    frmAddEditEmployee.tAdress.Text = dgv.CurrentRow.Cells(25).Value
                    frmAddEditEmployee.cmbCivilStatus.Text = dgv.CurrentRow.Cells(31).Value
                    frmAddEditEmployee.tContactNo.Text = dgv.CurrentRow.Cells(32).Value
                    frmAddEditEmployee.tinNumber.Text = dgv.CurrentRow.Cells(33).Value
                    frmAddEditEmployee.tDob.Text = dgv.CurrentRow.Cells(34).Value
                    frmAddEditEmployee.ShowDialog()
            End Select
        Else
            MsgBox("No record to be edited.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Edit")
        End If

        reload()
    End Sub
    Sub FormatAddEditForm()

        Select Case sFormText

            Case "Positions"
                frmAddEdit1.panGeneral3.Visible = True
                frmAddEdit1.panGeneral3.Left = 7
                frmAddEdit1.panGeneral3.Top = 7
                frmAddEdit1.Width = 450
                frmAddEdit1.Height = 230
                frmAddEdit1.btnSave.Top = 134
                frmAddEdit1.btnCancel.Top = 134
            Case "Departments", "Colleges"
                frmAddEdit1.panDepartment.Visible = True
                frmAddEdit1.panDepartment.Left = 7
                frmAddEdit1.panDepartment.Top = 7
                frmAddEdit1.Width = 450
                frmAddEdit1.Height = 202
                frmAddEdit1.btnSave.Top = 105
                frmAddEdit1.btnCancel.Top = 105
            Case "Salary Grades"
                frmAddEdit1.panGeneral2.Visible = True
                frmAddEdit1.panGeneral2.Left = 6
                frmAddEdit1.panGeneral2.Top = 6
                frmAddEdit1.Width = 450
                frmAddEdit1.Height = 185
                frmAddEdit1.btnSave.Top = 85
                frmAddEdit1.btnCancel.Top = 85
            Case "Incomes", "Deductions", "Designations"
                frmAddEdit1.panGeneral2.Visible = True
                frmAddEdit1.panGeneral2.Left = 6
                frmAddEdit1.panGeneral2.Top = 6
                frmAddEdit1.Width = 450
                frmAddEdit1.Height = 185
                frmAddEdit1.btnSave.Top = 85
                frmAddEdit1.btnCancel.Top = 85
            Case "Employee List"

        End Select
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        txtSearch.Text = ""
        reload()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditRecord()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        NewRecord()
    End Sub

    Sub NewRecord()
        FormatAddEditForm()

        If dgv.Rows.Count > 0 Then
            Select Case sFormText
                Case "Positions", "Departments", "Salary Grades", "Pay-Periods", "Rates", "Incomes", "Deductions",
                     "PhilHealth Contribution Schedule", "GSIS Contribution Schedule", "Monthly Witholding Tax",
                     "Yearly Income Tax", "Tranch", "Colleges"
                    frmAddEdit1.FormOpeMode = "Add"
                    frmAddEdit1.CallingForm = sFormText
                    Select Case sFormText
                        Case "Positions"
                            frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText) - 1)
                        Case "Departments", "Incomes", "Deductions", "Colleges"
                            Select Case sFormText
                                Case "Incomes"
                                    frmAddEdit1.Text = "Add " & sFormText
                                Case Else
                                    frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText) - 1)
                            End Select
                            frmAddEdit1.lbl1.Text = "Code"
                            frmAddEdit1.lbl2.Text = "Description"
                        Case "Tranch"
                            frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText))
                            frmAddEdit1.panGeneral.Visible = True
                            frmAddEdit1.panGeneral.Left = 7
                            frmAddEdit1.panGeneral.Top = 7
                            frmAddEdit1.Width = 450
                            frmAddEdit1.Height = 170
                            frmAddEdit1.btnSave.Top = 70
                            frmAddEdit1.btnCancel.Top = 70
                            frmAddEdit1.lbl.Text = "Tranch"
                        Case "Rates"
                            frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText))
                            frmAddEdit1.panRates.Visible = True
                            frmAddEdit1.panRates.Left = 7
                            frmAddEdit1.panRates.Top = 7
                            frmAddEdit1.Width = 450
                            frmAddEdit1.Height = 230
                            frmAddEdit1.btnSave.Top = 134
                            frmAddEdit1.btnCancel.Top = 134
                        Case "Salary Grades"
                            frmAddEdit1.Text = "Add " & Microsoft.VisualBasic.Left(sFormText, Len(sFormText))
                            frmAddEdit1.PanelEx3.Visible = True
                            frmAddEdit1.PanelEx3.Left = 7
                            frmAddEdit1.PanelEx3.Top = 7
                            frmAddEdit1.Width = 450
                            frmAddEdit1.Height = 400
                            frmAddEdit1.btnSave.Top = 300
                            frmAddEdit1.btnCancel.Top = 300
                            frmAddEdit1.lbl.Text = "Salary Grades"
                            ExecuteSQLStatement("SELECT * FROM vtranch", dgvhidden)
                            Dim comboSource As New Dictionary(Of String, String)()
                            Dim count As Integer = 0
                            For j As Integer = 0 To dgvhidden.RowCount - 2
                                comboSource.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(1).Value.ToString)
                                count += 1
                            Next
                            frmAddEdit1.cmbSTranch.DataSource = New BindingSource(comboSource, Nothing)
                            frmAddEdit1.cmbSTranch.DisplayMember = "Value"
                            frmAddEdit1.cmbSTranch.ValueMember = "Key"

                    End Select
                    frmAddEdit1.ShowDialog()
                Case "Employee List"

                    frmAddEditEmployee.Text = "Add Employee"
                    frmAddEditEmployee.FormOpeMode = "Add"
                    frmAddEditEmployee.tEmployeeIDNo.Enabled = False
                    frmAddEditEmployee.PrimaryKey = dgv.CurrentRow.Cells(0).Value
                    frmAddEditEmployee.tEmployeeIDNo.Text = dgv.CurrentRow.Cells(1).Value
                    frmAddEditEmployee.ShowDialog()
            End Select
        Else
            MsgBox("No record to be edited.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Edit")
        End If

        reload()
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        EditRecord()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        PrimaryKey = dgv.CurrentRow.Cells(0).Value
        frmAddEditEmployeeDetails.EmployeeID.Text = dgv.CurrentRow.Cells(0).Value
        ExecuteSQLStatement("SELECT * FROM tdepartments ORDER BY DepartmentDescription", dgvhidden)
        Dim comboSource As New Dictionary(Of String, String)()
        Dim count As Integer = 0
        comboSource.Add("0", "")
        For j As Integer = 0 To dgvhidden.RowCount - 2
            comboSource.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
            count += 1
        Next
        frmAddEditEmployeeDetails.cmbDesignation.DataSource = New BindingSource(comboSource, Nothing)
        frmAddEditEmployeeDetails.cmbDesignation.DisplayMember = "Value"
        frmAddEditEmployeeDetails.cmbDesignation.ValueMember = "Key"
        frmAddEditEmployeeDetails.cmbDesignation.SelectedValue = 0


        ExecuteSQLStatement("SELECT * FROM tcolleges ORDER BY CollegeDescription", dgvhidden)
        Dim comboSource1 As New Dictionary(Of String, String)()
        Dim count1 As Integer = 0
        comboSource1.Add("0", "")
        For j As Integer = 0 To dgvhidden.RowCount - 2
            comboSource1.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
            count1 += 1
        Next
        frmAddEditEmployeeDetails.cmbCollege.DataSource = New BindingSource(comboSource1, Nothing)
        frmAddEditEmployeeDetails.cmbCollege.DisplayMember = "Value"
        frmAddEditEmployeeDetails.cmbCollege.ValueMember = "Key"
        frmAddEditEmployeeDetails.cmbCollege.SelectedValue = 0


        ExecuteSQLStatement("SELECT * FROM tpositions ORDER BY PositionDescription", dgvhidden)
        Dim comboSource2 As New Dictionary(Of String, String)()
        Dim count2 As Integer = 0
        comboSource2.Add("0", "")
        For j As Integer = 0 To dgvhidden.RowCount - 2
            comboSource2.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
            count2 += 1
        Next
        frmAddEditEmployeeDetails.cmbPosition.DataSource = New BindingSource(comboSource2, Nothing)
        frmAddEditEmployeeDetails.cmbPosition.DisplayMember = "Value"
        frmAddEditEmployeeDetails.cmbPosition.ValueMember = "Key"
        frmAddEditEmployeeDetails.cmbPosition.SelectedValue = 0


        Dim comboSource3 As New Dictionary(Of String, String)()
        Dim count3 As Integer = 0
        comboSource3.Add("0", "")
        comboSource3.Add("1", "Contractual")
        comboSource3.Add("2", "Job Order")
        comboSource3.Add("3", "Part Time")
        comboSource3.Add("4", "Permanent/Regular")
        comboSource3.Add("5", "Inactive")


        frmAddEditEmployeeDetails.cmbEmploymentStatus.DataSource = New BindingSource(comboSource3, Nothing)
        frmAddEditEmployeeDetails.cmbEmploymentStatus.DisplayMember = "Value"
        frmAddEditEmployeeDetails.cmbEmploymentStatus.ValueMember = "Key"
        frmAddEditEmployeeDetails.cmbCollege.SelectedValue = 0
        frmAddEditEmployeeDetails.cmbPosition.SelectedValue = 0
        frmAddEditEmployeeDetails.cmbDesignation.SelectedValue = 0
        frmAddEditEmployeeDetails.cmbEmploymentStatus.SelectedValue = 0
        frmAddEditEmployeeDetails.cmbSalaryGrade.SelectedValue = 0
        frmAddEditEmployeeDetails.cmbStep.SelectedValue = 0


        ExecuteSQLStatement("SELECT * FROM psalarygrade WHERE STATUS = 1", dgvhidden)
        Dim comboSource4 As New Dictionary(Of String, String)()
        Dim count4 As Integer = 0
        comboSource4.Add("0", "")
        For j As Integer = 0 To dgvhidden.RowCount - 2
            comboSource4.Add(dgvhidden.Rows(j).Cells(0).Value.ToString, dgvhidden.Rows(j).Cells(2).Value.ToString)
            count += 1
        Next
        frmAddEditEmployeeDetails.cmbSalaryGrade.DataSource = New BindingSource(comboSource4, Nothing)
        frmAddEditEmployeeDetails.cmbSalaryGrade.DisplayMember = "Value"
        frmAddEditEmployeeDetails.cmbSalaryGrade.ValueMember = "Key"
        frmAddEditEmployeeDetails.cmbSalaryGrade.SelectedValue = 0

        frmAddEditEmployeeDetails.ShowDialog()
    End Sub
End Class
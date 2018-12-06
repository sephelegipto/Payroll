Imports System.ComponentModel
Imports Dapper
Public Class frmPayrollPrep
    Dim param As DynamicParameters = New DynamicParameters
    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmonth.SelectedIndexChanged
        txtCode.Text = Microsoft.VisualBasic.Left(Trim(txtmonth.Text), 3) & Trim(txtFrom.Text) & Trim(txtTo.Text) & Trim(txtyear.Text)
        txtDescription.Text = Trim(txtmonth.Text) & " " & Trim(txtFrom.Text) & "-" & Trim(txtTo.Text) & ", " & Trim(txtyear.Text)
        txtFrom.Text = "1"
        Select Case Trim(txtmonth.Text)
            Case "JANUARY"
                txtTo.Text = "31"
                txtWorkDays.Text = "20"
            Case "FEBRUARY"
                If Date.IsLeapYear(Now.Year) Then
                    txtTo.Text = "29"
                Else
                    txtTo.Text = "28"
                End If
                txtWorkDays.Text = "19"
            Case "MARCH"
                txtTo.Text = "31"
                txtWorkDays.Text = "22"
            Case "APRIL"
                txtTo.Text = "30"
                txtWorkDays.Text = "19"
            Case "MAY"
                txtTo.Text = "31"
                txtWorkDays.Text = "20"
            Case "JUNE"
                txtTo.Text = "30"
                txtWorkDays.Text = "21"
            Case "JULY"
                txtTo.Text = "31"
                txtWorkDays.Text = "22"
            Case "AUGUST"
                txtTo.Text = "31"
                txtWorkDays.Text = "18"
            Case "SEPTEMBER"
                txtTo.Text = "30"
                txtWorkDays.Text = "22"
            Case "OCTOBER"
                txtTo.Text = "31"
                txtWorkDays.Text = "22"
            Case "NOVEMBER"
                txtTo.Text = "30"
                txtWorkDays.Text = "20"
            Case "DECEMBER"
                txtTo.Text = "31"
                txtWorkDays.Text = "19"
        End Select
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtyear.SelectedIndexChanged
        txtCode.Text = Microsoft.VisualBasic.Left(Trim(txtmonth.Text), 3) & Trim(txtFrom.Text) & Trim(txtTo.Text) & Trim(txtyear.Text)
        txtDescription.Text = Trim(txtmonth.Text) & " " & Trim(txtFrom.Text) & "-" & Trim(txtTo.Text) & ", " & Trim(txtyear.Text)
        txtFrom.Text = "1"
        Select Case Trim(txtmonth.Text)
            Case "JANUARY"
                txtTo.Text = "31"
                txtWorkDays.Text = "20"
                txtMonthNumber.Text = "01"
            Case "FEBRUARY"
                If Date.IsLeapYear(Now.Year) Then
                    txtTo.Text = "29"
                Else
                    txtTo.Text = "28"
                End If

                txtWorkDays.Text = "19"
                txtMonthNumber.Text = "02"
            Case "MARCH"
                txtTo.Text = "31"
                txtWorkDays.Text = "22"
                txtMonthNumber.Text = "03"
            Case "APRIL"
                txtTo.Text = "30"
                txtWorkDays.Text = "19"
                txtMonthNumber.Text = "04"
            Case "MAY"
                txtTo.Text = "31"
                txtWorkDays.Text = "20"
                txtMonthNumber.Text = "05"
            Case "JUNE"
                txtTo.Text = "30"
                txtWorkDays.Text = "21"
                txtMonthNumber.Text = "06"
            Case "JULY"
                txtTo.Text = "31"
                txtWorkDays.Text = "22"
                txtMonthNumber.Text = "07"
            Case "AUGUST"
                txtTo.Text = "31"
                txtWorkDays.Text = "18"
                txtMonthNumber.Text = "08"
            Case "SEPTEMBER"
                txtTo.Text = "30"
                txtWorkDays.Text = "22"
                txtMonthNumber.Text = "09"
            Case "OCTOBER"
                txtTo.Text = "31"
                txtWorkDays.Text = "22"
                txtMonthNumber.Text = "10"
            Case "NOVEMBER"
                txtTo.Text = "30"
                txtWorkDays.Text = "20"
                txtMonthNumber.Text = "11"
            Case "DECEMBER"
                txtTo.Text = "31"
                txtWorkDays.Text = "19"
                txtMonthNumber.Text = "12"
        End Select
    End Sub



    Private Sub frmPayrollPrep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(766, 459)
        Panel1.Location = New Point(14, 363)
        Reload()
        DisableSave()
        'ExecuteSQLStatement("Select * from ppayroll", dgv)
        'dgv.Columns(7).DefaultCellStyle.Format = "C2"
    End Sub

    Sub Reload()
        Dim param As DynamicParameters = New DynamicParameters
        param.Add("LibraryToLoad", "Payroll Prep")
        param.Add("SearchText", "")
        Dim list As List(Of PayrollPrep) = MySqlConn.Query(Of PayrollPrep)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
        dgv.DataSource = list
    End Sub


    Private Sub btnHistory_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub




    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        Panel1.Location = New Point(14, 497)
        Me.Size = New Point(766, 595)
        EnableSave()
        PrimaryKey = 0
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Panel1.Location = New Point(14, 497)
        Me.Size = New Point(766, 595)
        EnableSave()
        AESwitch = If(dgv.CurrentRow.Cells(0).Value = Nothing, 0, dgv.CurrentRow.Cells(0).Value)
        txtCode.Text = If(dgv.CurrentRow.Cells(1).Value = Nothing, 0, dgv.CurrentRow.Cells(1).Value)
        txtDescription.Text = If(dgv.CurrentRow.Cells(2).Value = Nothing, 0, dgv.CurrentRow.Cells(2).Value)
        txtmonth.Text = If(dgv.CurrentRow.Cells(6).Value = Nothing, 0, dgv.CurrentRow.Cells(6).Value)
        txtyear.Text = If(dgv.CurrentRow.Cells(7).Value = Nothing, 0, dgv.CurrentRow.Cells(7).Value)
        txtFrom.Text = If(dgv.CurrentRow.Cells(8).Value = Nothing, 0, dgv.CurrentRow.Cells(8).Value)
        txtTo.Text = If(dgv.CurrentRow.Cells(9).Value = Nothing, 0, dgv.CurrentRow.Cells(9).Value)
        txtWorkDays.Text = If(dgv.CurrentRow.Cells(5).Value = Nothing, 0, dgv.CurrentRow.Cells(5).Value)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If AESwitch = 0 Then
            With param
                .Add("AESwitch", AESwitch)
                .Add("LibraryToAddEdit", "Add PayrollPrep")
                .Add("Code", txtCode.Text.Trim)
                .Add("Description", txtDescription.Text.Trim)
                .Add("DateFrom", txtMonthNumber.Text + "/" + txtFrom.Text + "/" + txtyear.Text)
                .Add("DateTo", txtMonthNumber.Text + "/" + txtTo.Text + "/" + txtyear.Text)
                .Add("WorkDays", txtWorkDays.Text.Trim)
                .Add("Month", txtmonth.Text.Trim)
                .Add("Year", txtyear.Text.Trim)
                .Add("DayFrom", txtFrom.Text.Trim)
                .Add("DayTo", txtTo.Text.Trim)
            End With
            MySqlConn.Execute("PayrollAddEditPayrollPreperation", param, commandType:=CommandType.StoredProcedure)
        Else
            With param
                .Add("AESwitch", AESwitch)
                .Add("LibraryToAddEdit", "Edit PayrollPrep")
                .Add("Code", txtCode.Text.Trim)
                .Add("Description", txtDescription.Text.Trim)
                .Add("DateFrom", txtMonthNumber.Text + "/" + txtFrom.Text + "/" + txtyear.Text)
                .Add("DateTo", txtMonthNumber.Text + "/" + txtTo.Text + "/" + txtyear.Text)
                .Add("WorkDays", txtWorkDays.Text.Trim)
                .Add("Month", txtmonth.Text.Trim)
                .Add("Year", txtyear.Text.Trim)
                .Add("DayFrom", txtFrom.Text.Trim)
                .Add("DayTo", txtTo.Text.Trim)
            End With
            MySqlConn.Execute("PayrollAddEditPayrollPreperation", param, commandType:=CommandType.StoredProcedure)
        End If
        AESwitch = 0
        Reload()
        DisableSave()
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Size = New Point(766, 459)
        Panel1.Location = New Point(14, 363)
        DisableSave()
    End Sub

    Sub EnableSave()
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtmonth.Enabled = True
        txtyear.Enabled = True
        txtFrom.Enabled = True
        txtTo.Enabled = True
        txtWorkDays.Enabled = True
    End Sub

    Sub DisableSave()
        btnNew.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        txtmonth.Enabled = False
        txtyear.Enabled = False
        txtFrom.Enabled = False
        txtTo.Enabled = False
        txtWorkDays.Enabled = False
        txtCode.Text = ""
        txtDescription.Text = ""
        txtmonth.Text = ""
        txtyear.Text = ""
        txtFrom.Text = ""
        txtTo.Text = ""
        txtWorkDays.Text = ""
    End Sub

    Private Sub btnCLose_Click_1(sender As Object, e As EventArgs) Handles btnCLose.Click
        mdiMainForm.bmPayPrep.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim frm As New frmPayrollCompute

        frm.MdiParent = mdiMainForm
        frm.lblPayroll.Text = "PAYROLL " & If(dgv.CurrentRow.Cells(2).Value = Nothing, 0, dgv.CurrentRow.Cells(2).Value)
        frm.txtCode.Text = If(dgv.CurrentRow.Cells(0).Value = Nothing, 0, dgv.CurrentRow.Cells(0).Value)
        frm.WorkDays.Text = If(dgv.CurrentRow.Cells(5).Value = Nothing, 0, dgv.CurrentRow.Cells(5).Value)
        frm.Show()

    End Sub

    Private Sub frmPayrollPrep_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mdiMainForm.bmPayPrep.Enabled = True
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Me.Size = New Point(766, 459)
        Panel1.Location = New Point(14, 363)
        DisableSave()
    End Sub
End Class
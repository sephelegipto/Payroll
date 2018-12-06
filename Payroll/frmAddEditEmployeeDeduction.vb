Imports System.ComponentModel
Imports Dapper
Public Class frmAddEditEmployeeDeduction
    Dim param As DynamicParameters = New DynamicParameters
    Private Sub frmAddEditEmployeeDeduction_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frmAddEditEmployeeDeduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtyear.SelectedIndexChanged
        Select Case Trim(txtmonth.Text)
            Case "JANUARY"
                txtMonthNumber.Text = "01"
            Case "FEBRUARY"
                txtMonthNumber.Text = "02"
            Case "MARCH"
                txtMonthNumber.Text = "03"
            Case "APRIL"
                txtMonthNumber.Text = "04"
            Case "MAY"
                txtMonthNumber.Text = "05"
            Case "JUNE"
                txtMonthNumber.Text = "06"
            Case "JULY"
                txtMonthNumber.Text = "07"
            Case "AUGUST"
                txtMonthNumber.Text = "08"
            Case "SEPTEMBER"
                txtMonthNumber.Text = "09"
            Case "OCTOBER"
                txtMonthNumber.Text = "10"
            Case "NOVEMBER"
                txtMonthNumber.Text = "11"
            Case "DECEMBER"
                txtMonthNumber.Text = "12"
        End Select
    End Sub

    Private Sub txtMonthsToPay_TextChanged(sender As Object, e As EventArgs) Handles txtMonthsToPay.TextChanged

    End Sub

    Private Sub txtYearsToPay_TextChanged(sender As Object, e As EventArgs) Handles txtYearsToPay.TextChanged

    End Sub

    Private Sub txtMonthsToPay_Leave(sender As Object, e As EventArgs) Handles txtMonthsToPay.Leave
        txtYearsToPay.Text = Math.Round(Val(txtMonthsToPay.Text) / 12, 1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With param
            .Add("EmpID", EmployeeID.Text)
            .Add("DedID", DeductionID.Text)
            .Add("DateFrom", txtyear.Text & "-" & txtMonthNumber.Text & "-1")
            .Add("Month", txtmonth.Text)
            .Add("Year", txtyear.Text)
            .Add("MonthsToPay", txtMonthsToPay.Text)
            .Add("YearsToPay", txtYearsToPay.Text)
            .Add("Amount", txtAmount.Text)
        End With
        MySqlConn.Execute("PayrollAddEditEmployeeDeduction", param, commandType:=CommandType.StoredProcedure)
        Me.Dispose()
    End Sub

    Private Sub txtYearsToPay_Leave(sender As Object, e As EventArgs) Handles txtYearsToPay.Leave
        txtMonthsToPay.Text = Val(txtYearsToPay.Text) * 12
    End Sub

    Private Sub txtmonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmonth.SelectedIndexChanged
        If txtyear.Text <> "" Then

            Select Case Trim(txtmonth.Text)
                Case "JANUARY"
                    txtMonthNumber.Text = "01"
                Case "FEBRUARY"
                    txtMonthNumber.Text = "02"
                Case "MARCH"
                    txtMonthNumber.Text = "03"
                Case "APRIL"
                    txtMonthNumber.Text = "04"
                Case "MAY"
                    txtMonthNumber.Text = "05"
                Case "JUNE"
                    txtMonthNumber.Text = "06"
                Case "JULY"
                    txtMonthNumber.Text = "07"
                Case "AUGUST"
                    txtMonthNumber.Text = "08"
                Case "SEPTEMBER"
                    txtMonthNumber.Text = "09"
                Case "OCTOBER"
                    txtMonthNumber.Text = "10"
                Case "NOVEMBER"
                    txtMonthNumber.Text = "11"
                Case "DECEMBER"
                    txtMonthNumber.Text = "12"
            End Select
        End If
    End Sub
End Class
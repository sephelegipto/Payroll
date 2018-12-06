Imports System.ComponentModel
Imports Dapper
Public Class frmMainRemittance
    Private Sub frmMainRemittance_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mdiMainForm.bmPhilHealth.Enabled = True
        mdiMainForm.bmGSIS.Enabled = True
        mdiMainForm.bmPagibig.Enabled = True

    End Sub

    Private Sub frmMainRemittance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim param As DynamicParameters = New DynamicParameters
        param.Add("LibraryToLoad", "Payroll Prep")
        param.Add("SearchText", "")
        Dim list As List(Of PayrollPrep) = MySqlConn.Query(Of PayrollPrep)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
        dgv.DataSource = list
        dgv.Columns(0).Visible = False
    End Sub

    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        mdiMainForm.bmPhilHealth.Enabled = True
        mdiMainForm.bmGSIS.Enabled = True
        mdiMainForm.bmPagibig.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub btnPrintPreview1_Click(sender As Object, e As EventArgs) Handles btnPrintPreview1.Click
        Select Case Me.Text
            Case "Pagibig"
                frmPrinting.CallingForm = "Pagibig"
                frmPrinting.CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & ""
            Case "GSIS"
                frmPrinting.CallingForm = "GSIS"
                frmPrinting.CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & ""

            Case "Philhealth"
                frmPrinting.CallingForm = "Philhealth"
                frmPrinting.CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & ""

        End Select
        frmPrinting.ShowDialog()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Try
            AESwitch = If(dgv.CurrentRow.Cells(0).Value = Nothing, 0, dgv.CurrentRow.Cells(0).Value)

        Catch ex As Exception

        End Try
    End Sub
End Class
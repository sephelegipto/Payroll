
Imports System.ComponentModel
Imports Dapper
Public Class frmSelectionList
    Private sCallingForm As String
    Public Property CallingForm() As String
        Get
            Return sCallingForm
        End Get
        Set(ByVal Value As String)
            sCallingForm = Value
        End Set
    End Property

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        LoadtoForm()
        Me.Dispose()
    End Sub
    Sub LoadtoForm()
        Try
            Select Case Trim(Me.CallingForm)
                Case "Dean Lookup"
                    LookUpContent = dgv.CurrentRow.Cells(2).Value
                    LookUpContentID = Val(dgv.CurrentRow.Cells(0).Value)
                Case "Educ Attain"
                    LookUpContent = dgv.CurrentRow.Cells(1).Value
                    LookUpContentID = Val(dgv.CurrentRow.Cells(3).Value)
                Case "Tranch"
                    LookUpContent = dgv.CurrentRow.Cells(1).Value
                    LookUpContentID = Val(dgv.CurrentRow.Cells(0).Value)
                Case "Salary Grade"
                    LookUpContent = dgv.CurrentRow.Cells(2).Value
                    LookUpContentID = Val(dgv.CurrentRow.Cells(0).Value)
            End Select
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub FormatDataGridView()
        Select Case Trim(Me.CallingForm)
            Case "Dean Lookup"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 80
                dgv.Columns(2).Width = 300
                For i = 3 To 30
                    dgv.Columns(i).Visible = False
                Next
            Case "Tax Code Lookup"
                dgv.Columns(0).Width = 80
                dgv.Columns(1).Width = 300
            Case "Employee Lookup"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 75
                dgv.Columns(2).Width = 100
                dgv.Columns(3).Width = 100
                dgv.Columns(4).Width = 100
                dgv.Columns(5).Visible = False
                dgv.Columns(6).Visible = False
                dgv.Columns(7).Visible = False
                dgv.Columns(8).Visible = False
                dgv.Columns(9).Visible = False
            Case "Income Lookup", "Deduction Lookup", "Pay-Period Lookup"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 80
                dgv.Columns(2).Width = 295
            Case "Payroll Record Lookup"
                dgv.Columns(0).Visible = False
                dgv.Columns(1).Width = 105
                dgv.Columns(2).Width = 100
                dgv.Columns(3).Width = 65
                dgv.Columns(4).Width = 40
                dgv.Columns(5).Width = 40
                dgv.Columns(6).Width = 30
                dgv.Columns(7).Visible = False
        End Select
    End Sub


    Private Sub frmSelectionList_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Sub PopulateList()
        Select Case Trim(Me.CallingForm)
            Case "Dean Lookup"
                Dim param As DynamicParameters = New DynamicParameters
                param.Add("LibraryToLoad", "Employees")
                param.Add("SearchText", Me.txtSearch.Text)
                Dim list As List(Of Employees) = MySqlConn.Query(Of Employees)("spLibraryViewAllORSearch", param, commandType:=CommandType.StoredProcedure).ToList()
                dgv.DataSource = list
            Case "Educ Attain"
                Dim param As DynamicParameters = New DynamicParameters
                param.Add("LibraryToLoad", "Educ Attain")
                param.Add("SearchText", Me.txtSearch.Text)
                Dim list As List(Of Rates) = MySqlConn.Query(Of Rates)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
                dgv.DataSource = list
            Case "Tranch"
                Dim param As DynamicParameters = New DynamicParameters
                param.Add("LibraryToLoad", "Tranch")
                param.Add("SearchText", "First Tranche")
                Dim list As List(Of Tranch) = MySqlConn.Query(Of Tranch)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
                dgv.DataSource = list
            Case "Salary Grade"
                Dim param As DynamicParameters = New DynamicParameters
                param.Add("LibraryToLoad", "tsalarygrades")
                param.Add("SearchText", Me.txtSearch.Text)
                Dim list As List(Of tSalaryGrade) = MySqlConn.Query(Of tSalaryGrade)("PayrollView", param, commandType:=CommandType.StoredProcedure).ToList()
                dgv.DataSource = list


        End Select
        FormatDataGridView()
    End Sub

    Private Sub frmSelectionList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateList()
        txtSearch.Focus()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        PopulateList()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub



    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        LoadtoForm()
        Me.Dispose()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub
End Class
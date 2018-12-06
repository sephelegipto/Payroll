

Imports Dapper
Public Class frmAddEditEmployee
    Private iPrimaryKey As Integer = 0
    Private sFormOpeMode As String
    Private sCallingForm As String
    Dim param As DynamicParameters = New DynamicParameters

    Public Property PrimaryKey() As Integer
        Get
            Return iPrimaryKey
        End Get
        Set(ByVal Value As Integer)
            iPrimaryKey = Value
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

    Public Property CallingForm() As String
        Get
            Return sCallingForm
        End Get
        Set(ByVal Value As String)
            sCallingForm = Value
        End Set
    End Property



    Private Sub frmAddEditEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmAddEditEmp_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tEmployeeIDNo.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRecord()
    End Sub
    Sub SaveRecord()


        If Trim(Me.FormOpeMode) = "Add" Then
            '################################ SAVE RECORD ####################################
            '#################################################################################

            ExecuteSQLStatement("INSERT INTO temployees (EmployeeID, LastName, FirstName, MiddleName, CivilStatus,ContactNumber,Address,TinNumber, Dob, Gender) VALUES ('" &
                                Trim(tEmpID.Text) & "','" &
                                Trim(tLastName.Text) & "', '" &
                                Trim(tFirstName.Text) & "', '" &
                                Trim(tMiddleName.Text) & "', '" &
                                Trim(cmbCivilStatus.Text) & "', '" &
                                Trim(tContactNo.Text) & "', '" &
                                Trim(tAdress.Text) & "', '" &
                                Trim(tinNumber.Text) & "', '" &
                                    Trim(tDob.Value) & "', '" &
                                Trim(cmbGender.Text) & "')", dgv)

        ElseIf Trim(Me.FormOpeMode) = "Edit" Then

            '############################## UPDATE RECORD ####################################
            '#################################################################################
            ExecuteSQLStatement("UPDATE  temployees
             SET 
             EmployeeID =  '" & Trim(tEmpID.Text) & "', 
             LastName =  '" & Trim(tLastName.Text) & "' ,
             FirstName=    '" & Trim(tFirstName.Text) & "',
             MiddleName =  '" & Trim(tMiddleName.Text) & "', 
             CivilStatus =  '" & Trim(cmbCivilStatus.Text) & "',
             ContactNumber = '" & Trim(tContactNo.Text) & "',
             Address =  '" & Trim(tAdress.Text) & "', 
             TinNumber =  '" & Trim(tinNumber.Text) & "', 
              Dob =  '" & Trim(tDob.Value) & "', 
             Gender =   '" & Trim(cmbGender.Text) & "' WHERE ID =  '" & Trim(tEmployeeIDNo.Text) & "'", dgv)
        End If
        Me.Dispose()
    End Sub

    Private Sub cmbEmploymentStatus_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class

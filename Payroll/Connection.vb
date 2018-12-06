Imports MySql.Data.MySqlClient
Module Connection
    Public ConnectionString As String = "SERVER=192.168.1.175;Port=3306;user id=root; password=toor; database=csusisdb;Connection Reset=true;SslMode=none;"
    Public MySqlConn As MySqlConnection = New MySqlConnection(ConnectionString)
    Public AESwitch = 0
    Public Search As String
    Public ErrorCatcher As Boolean
    Public FromForm As Form
    Public LookUpContent As String
    Public LookUpContent2 As String
    Public LookUpContent3 As String
    Private iPrimaryKey As Integer
    Public LookUpContentID As Integer

    Public Property PrimaryKey() As Integer
        Get
            Return iPrimaryKey
        End Get
        Set(ByVal Value As Integer)
            iPrimaryKey = Value
        End Set
    End Property

    Public Function ConnectMySql()
        Try
            MySqlConn.Open()
            MsgBox("Connection retrieved successfully.")
            MySqlConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
        Return True
    End Function

    Public Function OpenConnetion()
        If MySqlConn.State = ConnectionState.Closed Then
            MySqlConn.Open()
        End If
        Return True
    End Function
    Public Function ExecuteSQLStatement(ByVal SQLStatement As String,
                                        ByVal myDataGridView As DataGridView)

        Dim SQLConn As New MySqlConnection(ConnectionString)
        Dim SQLDataAdapter As New MySqlDataAdapter
        Dim myDataSet As New DataSet
        Try
            SQLConn.Open()

            SQLDataAdapter.SelectCommand = New MySqlCommand(SQLStatement, SQLConn)
            SQLDataAdapter.Fill(myDataSet)
            myDataGridView.DataSource = myDataSet.Tables(0)
        Catch ex As Exception

            If ex.Message = "Cannot find table 0." Then
            Else
                MsgBox(ex.Message)
            End If
        End Try
        SQLConn.Close()
        SQLDataAdapter.Dispose()
        myDataSet.Dispose()
        Return True
    End Function

    Public Function LoadRecordsInAComboBox(ByVal SQLStatement As String,
                                      ByVal myComboBox As ComboBox, ByVal myDisplayMember As String)
        Dim SQLConn As New MySqlConnection(ConnectionString)
        Dim SQLDataAdapter As New MySqlDataAdapter
        Dim myDataSet As New DataSet
        SQLConn.Open()
        Try
            SQLDataAdapter.SelectCommand = New MySqlCommand(SQLStatement, SQLConn)
            SQLDataAdapter.Fill(myDataSet)
            myComboBox.DataSource = myDataSet.Tables(0)
            myComboBox.DisplayMember = myDisplayMember
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SQLConn.Close()
        SQLDataAdapter.Dispose()
        myDataSet.Dispose()
        Return True
    End Function

    Function RemoveComma(ByVal text As Object)
        Dim length As Integer = text.ToString.Length
        Dim Character As String = ""
        For i = 0 To length - 1
            If (text(i) <> ",") Then
                Character += text(i)
            End If
        Next
        Return Character
    End Function
End Module

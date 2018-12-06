Public Class frmPrinting
    Private sCallingForm As String
    Dim sqlConn As New MySql.Data.MySqlClient.MySqlConnection(ConnectionString)
    Dim sqlDataAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim myDataSet As New DataSet()
    Dim sqlDataAdapter1 As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim myDataSet1 As New DataSet()
    Public CommandExecution As String = ""
    Public Property CallingForm() As String
        Get
            Return sCallingForm
        End Get
        Set(ByVal Value As String)
            sCallingForm = Value
        End Set
    End Property


    Private Sub frmPrint_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Trim(Me.CallingForm)
            Case "General Payroll Page 1"
                CommandExecution = "SELECT  * FROM ppayroll WHERE PayrollPreparationID = '" & AESwitch & "' and CollegeID = '" & PrimaryKey & "' "
                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")

                Dim cr As New GeneralPayrollPage1
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM vcolleges where ID = '" & PrimaryKey & "'", dgvhidden)
                cr.SetParameterValue("Dean", dgvhidden.Rows(0).Cells(4).Value)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("Accountant", dgvhidden.Rows(0).Cells(9).Value)
                cr.SetParameterValue("Campus1", dgvhidden.Rows(0).Cells(3).Value)
                cr.SetParameterValue("Code", txtCode.Text)
                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "General Payroll Page 2"
                CommandExecution = "SELECT  * FROM ppayroll WHERE PayrollPreparationID = '" & AESwitch & "' and CollegeID = '" & PrimaryKey & "' "
                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")

                Dim cr As New GeneralPayrollPage2
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("CEO", dgvhidden.Rows(0).Cells(8).Value)
                cr.SetParameterValue("CASHIER", dgvhidden.Rows(0).Cells(10).Value)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "Payslip"
                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")

                Dim cr As New Payslip
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("College", LookUpContent)
                LookUpContent = ""
                cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)

                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "NetTakeHomePay"
                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")
                Dim cr As New NetTakeHomePay
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("College", LookUpContent)
                cr.SetParameterValue("FormalName", LookUpContent2)
                cr.SetParameterValue("Accountant", dgvhidden.Rows(0).Cells(9).Value)
                LookUpContent = ""
                cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                cr.SetParameterValue("Rank", LookUpContent3)
                LookUpContent3 = ""
                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "Pagibig"

                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")
                Dim cr As New Pagibig
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)

                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "GSIS"
                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")
                Dim cr As New GSISmain
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "Philhealth"
                sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                myDataSet = New DataSet
                sqlDataAdapter.Fill(myDataSet, "ppayroll")
                Dim cr As New Philhealth
                cr.SetDataSource(myDataSet)
                ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                CrystalReportViewer1.ReportSource = cr
                CrystalReportViewer1.Refresh()
            Case "Remittance"
                Select Case LookUpContent
                    Case 1
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and OptIns is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New OptionalInsurance
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 2
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and EducLoan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New EducationalLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 3
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and ConsolLoan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New ConsolLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 4
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and PolicyLoan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New PolicyLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 5
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and OptionLoan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New OptionalLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 6
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and RealEstateLoan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New RealStateLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 7
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and Eplus is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New EPLUS
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 8
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and eml is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New EML
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 9
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and PremiumContri is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New PagibigPremiumContri
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 10
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and p2 is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New Pagibigp2
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 11
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and mpl is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New pagibigmpl
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 12
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and calamityloan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New PagibigCalamityLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 13
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and housing is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New Pagibighousingloan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()


                    Case 16
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and ppsta is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New PPSTA
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 17
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and salaryloancocolife is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New Cocolife
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 18
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and salaryloanPB is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New PostalBankSalaryLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 19
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and educloanPB is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New PBEducloan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 20
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and cvcat is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New CVCAT
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 21
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and igp is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New IGP
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 22
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and disallowance is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New Disallowance
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 23
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and acapa is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New ACAPA
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 24
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and excesschasadvance is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New ECA
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 25
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and dbploan is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New DBPLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 26
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and chinabank is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New ChinabankLoan
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 27
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and cenadco is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New Cenadco
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 28
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and LifeRet is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New LifeRet
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 29
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and CFA is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New CFA
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 30
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and Pera is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New Pera
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 31
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and UFA is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New UFA
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()
                    Case 32
                        CommandExecution = "SELECT * FROM csusisdb.ppayroll where PayrollPreparationID = " & AESwitch & " and APA is not null"
                        sqlDataAdapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand(CommandExecution, sqlConn)
                        myDataSet = New DataSet
                        sqlDataAdapter.Fill(myDataSet, "ppayroll")
                        Dim cr As New APA
                        cr.SetDataSource(myDataSet)
                        ExecuteSQLStatement("SELECT * FROM tpayrollpref", dgvhidden)
                        cr.SetParameterValue("Campus", dgvhidden.Rows(0).Cells(3).Value)
                        CrystalReportViewer1.ReportSource = cr
                        CrystalReportViewer1.Refresh()

                End Select
        End Select

    End Sub



    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
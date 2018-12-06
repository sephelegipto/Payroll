Imports System.Windows.Forms

Public Class mdiMainForm

    Private Sub mdiMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bmEmployees_Click(sender As Object, e As EventArgs) Handles bmEmployees.Click
        Dim frm As New frmRecsList
        frm.Text = "Employee List"
        frm.LoadTable = "Employees"
        frm.FindTitle = "Employee"
        frm.MdiParent = Me
        frm.btnDetails.Visible = True
        frm.btnHistory.Visible = True
        frm.RibbonBar5.Visible = True
        bmEmployees.Enabled = False
        frm.Show()
    End Sub

    Private Sub RibbonPanel2_Click(sender As Object, e As EventArgs) Handles RibbonPanel2.Click

    End Sub

    Private Sub bmPositions_Click(sender As Object, e As EventArgs) Handles bmPositions.Click
        Dim frm As New frmRecsList
        frm.Text = "Positions"
        frm.LoadTable = "Positions"
        frm.FindTitle = "Position"
        frm.MdiParent = Me
        bmPositions.Enabled = False
        frm.Show()
    End Sub

    Private Sub bmDepartments_Click(sender As Object, e As EventArgs) Handles bmDepartments.Click
        Dim frm As New frmRecsList
        frm.Text = "Departments"
        frm.LoadTable = "Departments"
        frm.FindTitle = "Department"
        frm.MdiParent = Me
        bmDepartments.Enabled = False
        frm.Show()


    End Sub

    Private Sub bmRanks_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bmIncome_Click(sender As Object, e As EventArgs) Handles bmIncome.Click
        Dim frm As New frmRecsList
        frm.Text = "Incomes"
        frm.LoadTable = "Incomes"
        frm.FindTitle = "Income"
        frm.MdiParent = Me
        bmIncome.Enabled = False
        frm.Show()
    End Sub

    Private Sub bmDeductions_Click(sender As Object, e As EventArgs) Handles bmDeductions.Click
        Dim frm As New frmRecsList
        frm.Text = "Deductions"
        frm.LoadTable = "Deductions"
        frm.FindTitle = "Deduction"
        frm.MdiParent = Me
        bmDeductions.Enabled = False
        frm.Show()

    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub ribSetUp_Click(sender As Object, e As EventArgs) Handles ribSetUp.Click

    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles bmTranch.Click
        Dim frm As New frmRecsList
        frm.Text = "Tranch"
        frm.LoadTable = "Tranch"
        frm.FindTitle = "Tranch"
        frm.MdiParent = Me
        bmTranch.Enabled = False
        frm.Show()
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles bmRanks.Click
        Dim frm As New frmRecsList
        frm.Text = "Salary Grades"
        frm.LoadTable = "Salary Grades"
        frm.FindTitle = "Salary Grade"
        frm.MdiParent = Me
        frm.Size = New System.Drawing.Size(1200, 456)
        frm.PanelEx1.Size = New System.Drawing.Size(1185, 56)
        frm.RibbonBar4.Location = New Point(1126, 3)
        frm.RibbonBar3.Location = New Point(1066, 3)
        frm.RibbonBar2.Location = New Point(958, 3)
        frm.RibbonBar1.Location = New Point(798, 3)
        frm.RibbonBar5.Location = New Point(687, 4)
        bmRanks.Enabled = False
        frm.Show()
    End Sub

    Private Sub bmRates_Click(sender As Object, e As EventArgs) Handles bmRates.Click
        Dim frm As New frmRecsList
        frm.Text = "Rates"
        frm.LoadTable = "Rates"
        frm.FindTitle = "Rates"
        frm.MdiParent = Me
        bmRates.Enabled = False
        frm.Show()
    End Sub

    Private Sub bmPayPrep_Click(sender As Object, e As EventArgs) Handles bmPayPrep.Click

        Dim frm As New frmPayrollPrep

        frm.MdiParent = Me
        bmPayPrep.Enabled = False
        frm.Show()
    End Sub

    Private Sub ButtonItem1_Click_1(sender As Object, e As EventArgs) Handles btnPayrollPrefer.Click
        Dim frm As New frmPayrollPreference

        frm.MdiParent = Me
        btnPayrollPrefer.Enabled = False
        frm.Show()

    End Sub

    Private Sub bmRegDed_Click(sender As Object, e As EventArgs) Handles bmRegDed.Click

        Dim frm As New frmPayrollDeductions

        frm.MdiParent = Me
        bmRegDed.Enabled = False
        frm.Show()
    End Sub

    Private Sub bmGenPay_Click(sender As Object, e As EventArgs) Handles bmGenPay.Click
        Dim frm As New frmGeneralPayroll

        frm.MdiParent = Me
        bmGenPay.Enabled = False
        frm.Show()
    End Sub

    Private Sub bmColleges_Click(sender As Object, e As EventArgs) Handles bmColleges.Click
        Dim frm As New frmRecsList
        frm.Text = "Colleges"
        frm.LoadTable = "Colleges"
        frm.FindTitle = "Colleges"
        frm.MdiParent = Me
        bmColleges.Enabled = False
        frm.Show()
    End Sub

    Private Sub btnPreferences_Click(sender As Object, e As EventArgs) Handles btnPreferences.Click
        btnPreferences.Enabled = False
        frmPreferences.ShowDialog()
    End Sub

    Private Sub bmPaySlip_Click(sender As Object, e As EventArgs) Handles bmPaySlip.Click
        Dim frm As New frmPayslip

        frm.MdiParent = Me
        bmPaySlip.Enabled = False
        frm.Show()
    End Sub

    Private Sub biNetTakeHomePay_Click(sender As Object, e As EventArgs) Handles biNetTakeHomePay.Click
        biNetTakeHomePay.Enabled = False
        frmNetTakeHomePay.Show()
    End Sub

    Private Sub biRemittances_Click(sender As Object, e As EventArgs) Handles biRemittances.Click
        biRemittances.Enabled = False
        frmRemittance.Show()
    End Sub

    Private Sub bmPhilHealth_Click(sender As Object, e As EventArgs) Handles bmPhilHealth.Click
        frmMainRemittance.Text = "Philhealth"
        bmPhilHealth.Enabled = False
        frmMainRemittance.Show()
    End Sub

    Private Sub bmGSIS_Click(sender As Object, e As EventArgs) Handles bmGSIS.Click
        frmMainRemittance.Text = "GSIS"
        bmGSIS.Enabled = False
        frmMainRemittance.Show()
    End Sub

    Private Sub bmPagibig_Click(sender As Object, e As EventArgs) Handles bmPagibig.Click
        frmMainRemittance.Text = "Pagibig"
        bmPagibig.Enabled = False
        frmMainRemittance.Show()
    End Sub

    Private Sub bmRegInc_Click(sender As Object, e As EventArgs) Handles bmRegInc.Click

    End Sub
End Class

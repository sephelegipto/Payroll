Public Class Employees
    Public Property ID As Integer '0
    Public Property EmployeeID As String '1
    Public Property Name As String  '2
    Public Property Salutation As String '3
    Public Property LastName As String '4
    Public Property FirstName As String '5
    Public Property MiddleName As String '6

    Public Property DepartmentID As String '7
    Public Property DepartmentCode As String '8
    Public Property DepartmentDescription As String '9

    Public Property PositionID As String '10
    Public Property PositionCode As String  '11
    Public Property PositionDescription As String '12
    Public Property Gender As String '13
    Public Property ProfilePic As Byte '14
    Public Property Status As String '15
    Public Property RankID As String '16
    Public Property RankCode As String '17
    Public Property RankDescription As String '18
    Public Property GradeID As String '19
    Public Property GradeCode As String '20
    Public Property GradeDescription As String '21
    Public Property CollegeID As String '22
    Public Property CollegeCode As String '23
    Public Property CollegeDescription As String '24
    Public Property Address As String '25
    Public Property DesignationID As Integer '26
    Public Property DesignationCode As String '27
    Public Property DesignationDescription As String '28
    Public Property EmployeeTypeID As Integer '29
    Public Property EmployeeTypeDescription As String '30
    Public Property CivilStatus As String '31
    Public Property ContactNumber As String '32
    Public Property TinNumber As String '33
    Public Property Dob As String '34
End Class

Public Class Positions
    Public Property ID As Integer '0
    Public Property PositionCode As String '1
    Public Property PositionDescription As String  '2
    Public Property DefaultRate As String  '3

End Class

Public Class Departments
    Public Property ID As Integer '0
    Public Property DepartmentCode As String '1
    Public Property DepartmentDescription As String  '2
    Public Property HeadID As String  '3
    Public Property DepartmentHead As String  '4
End Class
Public Class Ranks
    Public Property ID As Integer '0
    Public Property TranchDescription As String '2
    Public Property GradeDescription As String '3

    Public Property Step1 As String  '4
    Public Property Step2 As String  '5
    Public Property Step3 As String  '6
    Public Property Step4 As String  '7
    Public Property Step5 As String  '8
    Public Property Step6 As String  '9
    Public Property Step7 As String  '10
    Public Property Step8 As String  '11
    Public Property TranchID As String  '12
    Public Property SalaryGradeID As String  '13

End Class

Public Class Incomes
    Public Property ID As Integer '0
    Public Property IncomeCode As String '1
    Public Property IncomeDescription As String  '2

End Class

Public Class Deductions
    Public Property ID As Integer '0
    Public Property DeductionCode As String '1
    Public Property DeductionDescription As String  '2

End Class

Public Class Tranch
    Public Property ID As Integer '0
    Public Property TranchDescription As String '1
    Public Property StatusName As String '2

End Class

Public Class Rates
    Public Property ID As Integer '0
    Public Property EducationAttainment As String '1
    Public Property Level As String '2
    Public Property PartTime As String '3
    Public Property ExtraLoad As String '4

End Class

Public Class EmployeeDesignation
    Public Property ID As String '0
    Public Property DepartmentDescription As String '1
    Public Property PositionDescription As String '2
    Public Property CollegeDescription As String '3
    Public Property Name As String '4
    Public Property DateFrom As String '5
    Public Property DateTo As String '6
    Public Property RatePerHour As String '7
    Public Property RatePerDay As String '8
    Public Property SalaryStep As String '9
    Public Property SalarayGrade As String '10
    Public Property SalaryGradeAmount As String '11

    Public Property DesignationID As String '12
    Public Property PositionID As String '13
    Public Property CollegeID As String '14
    Public Property EmploymenyStatusID As String '15
    Public Property Status As String '15



End Class

Public Class tSalaryGrade

    Public Property ID As String '1
    Public Property GradeCode As String '2
    Public Property GradeDescription As String '3

End Class

Public Class SalaryGrade

    Public Property ID As String '1
    Public Property GradeCode As String '2
    Public Property GradeDescription As String '3
    Public Property TranchID As String '4
    Public Property Step1 As String '5
    Public Property Step2 As String '6
    Public Property Step3 As String '7
    Public Property Step4 As String '8
    Public Property Step5 As String '9
    Public Property Step6 As String '10
    Public Property Step7 As String '11
    Public Property Step8 As String '12
    Public Property DateCreated As String '13
End Class

Public Class PayrollPrep
    Public Property ID As String '0
    Public Property Code As String '1
    Public Property Description As String '2
    Public Property DateFrom As String '3
    Public Property DateTo As String '4
    Public Property WorkDays As String '5
    Public Property Month As String '6
    Public Property Year As String '7
    Public Property DayFrom As String '8
    Public Property DayTo As String '9


End Class

Public Class ppayrollemployee
    Public Property ID As String '0
    Public Property EmpID As String '1
    Public Property EmployeeID As String '2
    Public Property FullName As String '3
    Public Property PositionDescription As String '4
    Public Property FormalName As String '5

End Class
Public Class ppayrolldeduction
    Public Property DeductionID As String '0
    Public Property EmployeeID As String '1
    Public Property DeductionDescription As String '2
    Public Property DateFrom As String '3
    Public Property DateTo As String '4
    Public Property Month As String '5
    Public Property Year As String '6
    Public Property MonthsToPay As String '7
    Public Property YearsToPay As String '8

    Public Property Amount As String '9
    Public Property ID As String '10
End Class
Public Class payroll
    Public Property DeductionID As String '0
    Public Property EmployeeID As String '1
    Public Property DeductionDescription As String '2
    Public Property DateFrom As String '3
    Public Property DateTo As String '4
    Public Property Month As String '5
    Public Property Year As String '6
    Public Property MonthsToPay As String '7
    Public Property YearsToPay As String '8

    Public Property Amount As String '8
End Class

Public Class payrollcompute
    Public Property Num As String '0
    Public Property ID As String '1
    Public Property PayrollPreparationID As String '2
    Public Property EmpID As String '3
    Public Property EmployeeID As String '4
    Public Property fullname As String '5
    Public Property Position As String '6
    Public Property OldRate As String '7
    Public Property AdjustedRate As String '8
    Public Property SalaryAdjustment As String
    Public Property ProportionalPay As String '09
    Public Property Earned As String '10
    Public Property Pera As String '11
    Public Property Earned2 As String '12
    Public Property Tax As String '13   
    Public Property LifeRet As String '14
    Public Property OptIns As String '15
    Public Property EducLoan As String '16
    Public Property CFA As String '17

    Public Property ConsolLoan As String '18
    Public Property PolicyLoan As String '19
    Public Property OptionLoan As String '20
    Public Property RealEstateLoan As String '21
    Public Property Eplus As String '22
    Public Property eml As String '23
    Public Property PremiumContri As String '24
    Public Property p2 As String '25
    Public Property mpl As String '26
    Public Property calamityloan As String '27

    Public Property housing As String '28
    Public Property MedicareContri As String '29
    Public Property sss As String '30
    Public Property ppsta As String '31
    Public Property salaryloancocolife As String '32
    Public Property salaryloanPB As String '33
    Public Property educloanPB As String '34
    Public Property cvcat As String '35
    Public Property igp As String '36
    Public Property disallowance As String '37
    Public Property ACAPA As String '38#############################################
    Public Property APA As String '39
    Public Property UFA As String '40
    Public Property excesschasadvance As String '41
    Public Property dbploan As String '42
    Public Property chinabank As String '43
    Public Property cenadco As String '44
    Public Property TotalDeduction As String '45
    Public Property NetAmountDue As String '46
    Public Property EmployementStatus As String '47
    Public Property CollegeID As String '48
    Public Property DesignationID As String '49

    Public Property WorkDays As String '50
    Public Property Include As String '51

End Class

Public Class payrollsum
    Public Property OldRate As String
    Public Property AdjustedRate As String
    Public Property SalaryAdjustment As String

    Public Property ProportionalPay As String
    Public Property Earned As String
    Public Property Pera As String
    Public Property Earned2 As String
    Public Property Tax As String
    Public Property LifeRet As String
    Public Property OptIns As String
    Public Property EducLoan As String
    Public Property CFA As String
    Public Property ConsolLoan As String
    Public Property PolicyLoan As String
    Public Property OptionLoan As String
    Public Property RealEstateLoan As String
    Public Property Eplus As String
    Public Property eml As String
    Public Property PremiumContri As String
    Public Property p2 As String
    Public Property mpl As String
    Public Property calamityloan As String
    Public Property housing As String
    Public Property MedicareContri As String
    Public Property sss As String
    Public Property ppsta As String
    Public Property salaryloancocolife As String
    Public Property salaryloanPB As String
    Public Property educloanPB As String
    Public Property cvcat As String
    Public Property igp As String
    Public Property disallowance As String
    Public Property ACAPA As String
    Public Property APA As String
    Public Property UFA As String
    Public Property excesschasadvance As String
    Public Property dbploan As String
    Public Property chinabank As String
    Public Property cenadco As String
    Public Property TotalDeduction As String
    Public Property NetAmountDue As String
End Class
Public Class Colleges
    Public Property ID As String
    Public Property CollegeCode As String
    Public Property CollegeDescription As String
    Public Property HeadID As String
    Public Property CollegeHead As String

End Class
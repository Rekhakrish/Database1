Imports System

Module Program

    Sub Main(args As String())
        'Declare the variables
        'Declare the id for employee
        Dim employeeId As Integer

        Dim employeeName As String

        Dim numberOfDaysPresent As Integer

        Dim basicPay As Decimal

        Dim HRA As Decimal

        Dim otherAllowances As Decimal

        Dim tax As Decimal


        'Accept the input from User
        Console.WriteLine("Enter the employeeId :")
        employeeId = Console.ReadLine()

        Console.WriteLine("Enter the employeeName :")
        employeeName = Console.ReadLine()

        Console.WriteLine("Enter the NumberOfDaysPresent :")
        numberOfDaysPresent = Console.ReadLine()

        Console.WriteLine("Enter the BasicPay :")
        basicPay = Console.ReadLine()

        Console.WriteLine("HRA  :")
        HRA = Console.ReadLine()

        Console.WriteLine("Enter the OtherAllowances :")
        otherAllowances = Console.ReadLine()

        'validate the number of days Present
        If numberOfDaysPresent > 25 Then
            Console.WriteLine("Number of Days present cannot be greater tha 25")
        Else

            'Calculate the gross salary

            Dim salary As New SalaryHelper
            Dim gross_salary As Integer
            gross_salary = salary.CalculateGrossSalary(basicPay, HRA, otherAllowances)
            Console.WriteLine(gross_salary)

            'Calculate the Tax
            'tax = SalaryHelper.CalculateTax(grossSalary)
            ' Dim sal As New SalaryHelper
            Dim Emptax As Integer
            Emptax = salary.CalculateTax(gross_salary)
            Console.WriteLine(Emptax)

            'Calculate the NetSalary
            'netSalary = SalaryHelper.CalculateNetSalary(grossSalary, tax)
            Dim net_Salary As Integer
            net_Salary = salary.CalculateNetSalary(gross_salary, tax)
            Console.WriteLine(net_Salary)
            'Display thr Results

            Console.WriteLine("GrossSalary :" & gross_salary)
            Console.WriteLine("Tax :" & Emptax)
            Console.WriteLine("NetSalary :" & net_Salary)
        End If





    End Sub
End Module
Public Class Employee
    'Declare the properties
    Public Property EmployeeId As Integer
    Public Property EmployeeName As String
    Public Property NumberOfDaysPresent As Integer
    Public Property BasicPay As Decimal
    Public Property HRA As Decimal
    Public Property OtherAllowances As Decimal

End Class
Public Class SalaryHelper
    'Calculate the gross salary
    Public Function CalculateGrossSalary(basicPay As Decimal, HRA As Decimal, otherAllowances As Decimal) As Decimal
        Dim grossSalary As Decimal
        grossSalary = basicPay + HRA + otherAllowances
        Return grossSalary

    End Function
    'Calculate the Tax
    Public Function CalculateTax(grossSalary As Decimal) As Decimal
        Dim tax As Decimal
        Dim Empgross As Decimal
        Empgross = (grossSalary * 12)
        If Empgross < 500000 Then
            tax = 0
        ElseIf Empgross > 500000 And grossSalary <= 1000000 Then
            tax = grossSalary - 500000 * 2
        ElseIf Empgross > 100000 Then
            tax = grossSalary - 500000 * 0.3
        End If
        Return tax
    End Function

    'Calculate the NetSalary
    Public Function CalculateNetSalary(grossSalary As Decimal, tax As Decimal) As Decimal
        Dim netSalary As Decimal
        netSalary = grossSalary - tax - 1800
        Return netSalary
    End Function
End Class
Imports System

Module Module1

    Class Employee
        Dim id As Integer
        Dim FirstName As String
        Dim LastName As String
        Public Sub Employee(ByVal i As Integer, ByVal fn As String, ByVal ln As String)
            id = i
            FirstName = fn
            LastName = ln

        End Sub
        Public Sub PrintEmployee()
            Console.WriteLine("Id       :{0}", id)
            Console.WriteLine("FirstName       :{0}", FirstName)
            Console.WriteLine("LastName       :{0}", LastName)

        End Sub
    End Class
    Class EmployeeInfo
        Inherits Employee

        Dim jobRole As String
        Dim salary As Decimal

        Public Sub EmployeeInfo(ByVal i As Integer, ByVal fn As String, ByVal ln As String, ByVal j As String, ByVal s As Decimal)
            Employee(i, fn, ln)
            jobRole = j
            salary = s
        End Sub
        Public Sub PrintEmployeeInfo()
            PrintEmployee()
            Console.WriteLine("JobRole     :{0}", jobRole)
            Console.WriteLine("Salary     :{0}", salary)
        End Sub
    End Class

    Sub Main()
        Dim employeeDetail As EmployeeInfo()

        employeeDetail.EmployeeInfo(101, "Rekha", "Krish", "Programmer Analyst", 40000.54)
        employeeDetail.PrintEmployeeInfo()
    End Sub
End Module

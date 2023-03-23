Public Class Employee
    Public employeeId As Integer
    Public employeeName As String
    Public age As Integer
    Public dob As Date
    Public basicHRA As Integer


    Public Sub EmployeeDetails()
        Console.WriteLine("Enter Your EmployeeId")
        employeeId = Console.ReadLine()
        Console.WriteLine("Enter Your Name")
        employeeName = Console.ReadLine()
        Console.WriteLine("Enter Your Age")
        age = Console.ReadLine()
        Console.WriteLine("Enter Your Dob")
        dob = Console.ReadLine()
        Console.WriteLine("Enter Your BasicHRA")
        basicHRA = Console.ReadLine()


    End Sub
    Public Sub DisplayDetails()

        Console.WriteLine("Your EmployeeID : {0} ", employeeId)
        Console.WriteLine("Your EmployeeName: {0} ", employeeName)
        Console.WriteLine("Your Age: {0}", age)
        Console.WriteLine("Your Dob: {0}", dob)
        Console.WriteLine("Your BAsicHra: {0}", basicHRA)
    End Sub
End Class

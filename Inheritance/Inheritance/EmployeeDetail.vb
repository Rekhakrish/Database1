Imports System
Imports System.Security.Cryptography.X509Certificates

Module Module2

    Class Employee


        Dim stFirstName As String
        Dim stLastName As String

        Public Property FirstName As String
            Set(value As String)
                stFirstName = value

            End Set
            Get
                Return stFirstName = "Rekha"
            End Get
        End Property
        Public Property LastName As String
            Set(value As String)
                stLastName = value

            End Set
            Get
                Return stLastName = "Krish"

            End Get
        End Property

        Public Sub savedetails()
            Console.WriteLine("I am " & stFirstName & stLastName)

        End Sub


    End Class
    Class EmployeeInfo
        Inherits Employee
        Dim dsalary As Decimal

        Public Property Salary As String
            Set(value As String)
                dsalary = value

            End Set
            Get
                Return dsalary

            End Get
        End Property

        Public Sub saveddetails()
            Console.WriteLine("I am Employee")

        End Sub
    End Class
    Sub Main(args As String())

        Dim employeeInfo As New EmployeeInfo
           
            Console.WriteLine("Hello ")
        employeeInfo.savedetails()

        Console.Read()

        End Sub
    


End Module

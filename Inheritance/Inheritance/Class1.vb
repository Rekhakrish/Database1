Imports System
Public Class Employee
    Dim stFirstName As String
    Dim stLastName As String
    Dim dtDateOfBirth As Date

    Public Property FirstName As String
        Set(value As String)
            stFirstName = value

        End Set
        Get
            Return stFirstName
        End Get
    End Property

    Public Property LastName As String
        Set(value As String)
            stLastName = value

        End Set
        Get
            Return stLastName

        End Get
    End Property
    Public Property DateOfBirth As Date
        Set(value As Date)
            If (Year(Now) - Year(value)) < 18 Then
                MsgBox(Me.FirstName & " " & Me.LastName & " " & "must be 18 or older,change the date of birth")
                Exit Property
            Else
                dtDateOfBirth = value

            End If

        End Set
        Get
            Return dtDateOfBirth


        End Get
    End Property

    Public Sub Savedetails()
        Console.WriteLine("I am " & " " & stFirstName & " " & stLastName & " " & dtDateOfBirth)
        Console.WriteLine("I am the Employee for this Reputed Organisation")
    End Sub
End Class

Public Class EmployeeInfo

    Inherits Employee
    Dim stJobRole As String

    Public Property JobRole As String
        Set(value As String)
            stJobRole = value

        End Set
        Get
            Return JobRole

        End Get
    End Property
    Public Sub savedetails()
        Console.WriteLine("I am Employee")
    End Sub
End Class

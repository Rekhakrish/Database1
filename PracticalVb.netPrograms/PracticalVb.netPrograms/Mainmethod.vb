Imports System

Module Mainmethod
    Sub Main(args As String())
        'Dim Number1 As Integer
        'Dim Number2 As Integer
        'Dim Result As Integer
        ''Dim Unary As Integer

        'Console.WriteLine("Enter the Number1: ")
        'Number1 = Console.ReadLine()
        'Console.WriteLine("Enter the Number2: ")
        'Number2 = Console.ReadLine()

        ''Arithmetic Opearator
        'Result = Number1 + Number2
        'Console.WriteLine("Result : " & Result)

        'If Result = 10 Then
        '    Console.WriteLine("Get the Numberb")
        'ElseIf (Result > 10) Then
        '    Console.WriteLine("Greater than Number")
        'Else
        '    Console.WriteLine("Below the Number")
        'End If

        Dim Empdet As Employee = New Employee()
        Empdet.EmployeeDetails()
        Empdet.DisplayDetails()
        ' Dim arr As Array = New Array()
        ' arr.DisplayArray()

    End Sub
End Module

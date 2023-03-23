Imports System

Module Marks
    Dim studentname As String
    Dim studentage As Integer
    'Dim english As String
    Dim subject1 As String
    Dim subject2 As String
    Dim subject1mark As Integer
    Dim subject2mark As Integer
    Dim totalmark As Integer
    Dim stucount As Integer



    Sub Main(args As String())
        'Console.WriteLine("Please Enter How many Student Grade marks you want")
        'Console.WriteLine("Maximum by 3 members")
        'stucount = Console.ReadLine()

        ' While (stucount < 3)
        Console.WriteLine("Enter Your Name :")
            studentname = Console.ReadLine()

            Console.WriteLine("Enter Your Age :")
            studentage = Console.ReadLine()

            Console.WriteLine("Enter Your First Subject Name :")
            subject1 = Console.ReadLine()

            Console.WriteLine("Enter Your Second Subject Name :")
            subject2 = Console.ReadLine()

            Console.WriteLine("Enter Your First Subject Marks :")
            subject1mark = Console.ReadLine()

            Console.WriteLine("Enter Your Second Subject Marks :")
            subject2mark = Console.ReadLine()


            totalmark = subject1mark + subject2mark
            Console.WriteLine("Your Total Mark : " & totalmark)

        If totalmark >= 90 Then
            Console.WriteLine("Your Grade is A")
        ElseIf totalmark < 90 And totalmark >= 80 Then
            Console.WriteLine("Your Grade is B")
            ElseIf totalmark < 80 And totalmark >= 70 Then
                Console.WriteLine("Your Grade is C")
            ElseIf totalmark < 70 And totalmark >= 60 Then
                Console.WriteLine("Your Grade is D")
            Else
                Console.WriteLine("Your Grade is E")
            End If
        '    stucount = 0
        'End While
    End Sub
End Module

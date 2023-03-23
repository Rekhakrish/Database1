Imports System

Module Program

    Sub Main(args As String())
        Dim studentName As String
        Dim timesToEnter As Integer = 0
        While timesToEnter < 4


            Console.WriteLine("Enter the Studentname")
            studentName = Console.ReadLine()
            Dim validation As Studentnamevalidation = New Studentnamevalidation()

            Dim assigningName As Integer = validation.isValidStudentName(studentName)
            Select Case assigningName
                Case 0
                    Console.WriteLine("Submitted")
                Case 1
                    Console.WriteLine("Value should be string format")
                Case 2
                    Console.WriteLine("Value should be below 50 characters and above 1 character")
                Case 3
                    Console.WriteLine("Value should not be empty or null")
            End Select
            timesToEnter += 1
        End While



    End Sub
End Module

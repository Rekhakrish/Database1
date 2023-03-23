Imports System

Module Program
    Sub Main(args As String())
        Console.BackgroundColor = ConsoleColor.Cyan
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.DarkMagenta

        'Dim number1 As Integer
        'Dim number2 As Integer
        'Dim Total As Integer

        'Console.WriteLine("Enter the number1")
        'number1 = Console.ReadLine()
        'Console.WriteLine("Enter the number2")
        'number2 = Console.ReadLine()
        'Total = number1 + number2
        ''Console.WriteLine("The Total number is {0}", number1 + number2)
        'Console.WriteLine("{0} + {1} = {2}", number1, number2, Total)

        'Console.ReadKey()
        ' String1()
        'String2()
        ' IfEx1()
        'Selectcase()
        Forloop()
    End Sub

    Public Sub String1()
        Dim sentence As String = "Program is written in String"
        Dim name As String = "Rekha"

        'Getting the lenght of the string
        Console.WriteLine(sentence.Length)
        'Getting Part of a String
        Console.WriteLine(sentence.Substring(2, 5))
        Console.ReadKey()
    End Sub

    Public Sub String2()
        Dim sentence2 As String = " Program is written in vb.net by @Rekha"
        Dim sentence3 As String = "Hello, this is one of my first programs in VB.Net"



        '1.Display the length of the String
        Console.WriteLine("The Length is {0}", sentence2.Length)

        '2.Display the word 'program' using substring
        Console.WriteLine(sentence2.Substring(1, 8))

        '3.Display 'this is one' using substring
        Console.WriteLine(sentence3.Substring(7, 12))

        '4.Create a new variable called Intro and assign it the value of the first 5 characters in the string 'sentence'
        Dim Intro As String
        Intro = (sentence3.Substring(0, 5))
        Console.WriteLine(Intro)

        '5.Display the length of the variable Intro
        Console.WriteLine(Intro.Length)

        '6.Create a New variable called myName and Store your name in it
        Dim myName As String = "Rekha"

        '7.Insert the contents of myName into the string sentence after 'Hello' and before the comma. **HARD**
        sentence3 = sentence3.Substring(0, 5) & " " & myName & sentence3.Substring(5)
        Console.WriteLine(sentence3)

    End Sub
    Public Sub IfEx1()
        'Guess the number Exercise!
        'Write a Program that will ask the user to guess a number  - they only one chance to guess! 
        'Create a variable and assign it a number between 1 and 5
        'Ask the user  the enter a number between 1 and 5 as their guess
        'check if the user's guess  is equal to the variable
        'If it a display a success message
        'If not  display a failure message


        Dim numberguess As Integer = 3
        Dim userguess As Integer

        'Game Introduction
        Console.WriteLine("Guess the Number")
        Console.WriteLine("*****************************")
        Console.WriteLine()

        'Get user's guess
        Console.WriteLine("Enter the number between 1 to 5")
        userguess = Console.ReadLine()

        'Check if the guess is correct
        If userguess = numberguess Then
            Console.WriteLine("Well Done")
        ElseIf userguess > numberguess Then
            Console.WriteLine("Bad Luck, Too High!")
        Else
            Console.WriteLine("Bad luck, Too Low!")
        End If


    End Sub
    Public Sub Selectcase()
        'create a program that displays a menu
        '1. Play game
        '2. view high scores
        '3. Reset high scores
        '4. Exit

        'The Program then asks for  the user's choice
        'If the user chose 1 display 'Play the game.....'
        'If the user chose 2 display 'High scores...'
        'If the user chose 3 display 'High scores reset...'
        'If the user chose 4 display 'Good bye...'
        Dim userchoice As Integer

        Console.WriteLine("Enter the Choice between 1 to 4:")
        userchoice = Console.ReadLine()
        Select Case userchoice
            Case Is = 1
                Console.WriteLine("Play the game")
            Case Is = 2
                Console.WriteLine("High Scores")
            Case Is = 3
                Console.WriteLine("Reset High Scores")
            Case Else
                Console.WriteLine("Good Bye")

        End Select


    End Sub
    Public Sub Forloop()
        Console.WriteLine("Question 1")
        For counter = 1 To 5
            Console.WriteLine("Do Something")
        Next
        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("Question 2")
        For counter = 5 To 7
            Console.WriteLine("Do Something")
        Next
        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("Question 3")
        For counter = 5 To 5
            Console.WriteLine("Do Something")
        Next
        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("Question 4")
        For counter = 0 To 20 Step 2
            Console.WriteLine("Do Something")
        Next
        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("Question 5")
        For counter = 0 To 20 Step 10
            Console.WriteLine("Do Something")
        Next
        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("Question 6")
        For counter = 5 To 0 Step -1
            Console.WriteLine("Do Something")
        Next
        Console.ReadKey()
        Console.Clear()
    End Sub
End Module

Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates

Module Module1
    ' Public Sub ProductOfOddIntegers()
    'Dim I As Integer
    'Dim Res As Integer = 1
    'For I = 1 To 15 Step 2
    '       Res = Res * I
    '
    'Next
    '
    '   Console.WriteLine("Product of Odd Integers from 1 To 15 {0}", Res)



    'End Sub
    'End Module
    Public Sub Factorial()
        Dim N As Integer
        Dim I As Integer
        Dim Fact As Integer = 1

        Console.Write("Enter the value of N : ")
        N = Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine("N        Factorial")


        For I = 1 To N

            Fact = Fact * I

            Console.WriteLine("{0,-6}      {1,7 }", I, Fact)

        Next
    End Sub
End Module

Module Program4
    Public Sub Histogram()
        Dim S As String
        Console.WriteLine("Enter the value Separated by String")
        S = Console.ReadLine()

        Dim Nums() As String = S.Split()
        Dim N As Integer
        For Each N In Nums
            Console.WriteLine("{0,2}    {1}", N, New String("*", N))





        Next






    End Sub
End Module
Module SMALLESTINTEGER
    Public Sub SmallInt()
        Dim N, I As Integer
        Dim CurrentNumber As Integer
        Dim Smallest As Integer

        Console.Write("How many numbers?  ")
        N = Console.ReadLine
        Console.WriteLine("Enter the numbers one by one  ")
        For I = 1 To N
            CurrentNumber = Console.ReadLine()
            If I = 1 Then
                Smallest = CurrentNumber
            Else
                If Smallest > CurrentNumber Then
                    Smallest = CurrentNumber
                End If
            End If

        Next
        Console.WriteLine("Smallest :    {0}", Smallest)




    End Sub

End Module
Public Class ArithmethicException
    Dim num1 As Integer
    Dim num2 As Integer
    Dim result As Integer
    Dim array(4) As String

    Public Sub Calculate()
        Console.WriteLine("Enter te First number")
        Try
            num1 = Console.ReadLine()

        Catch ex As InvalidCastException
            Console.WriteLine("Please only type Numbers")
        End Try
        Console.WriteLine("Enter the second number")
        Try
            num2 = Console.ReadLine()

        Catch ex As InvalidCastException
            Console.WriteLine("Please only type Numbers")
            Console.WriteLine("Number two must be greater than zero")
        End Try

        Try
            result = num1 / num2

        Catch ex As ArithmeticException
            Console.WriteLine("Integer is not divided by Zero")
        End Try
        Console.WriteLine(result)

    End Sub

End Class

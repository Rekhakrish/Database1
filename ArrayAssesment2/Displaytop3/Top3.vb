Imports System

Module Top3
    Sub Main(args As String())
        Dim numbers As List(Of Integer) = New List(Of Integer) From {15, 17, 13, 24, 60, 29, 98, 7}

        Console.WriteLine("The members of List Are : 15,17,13,24,60,29,98,7")
        Console.WriteLine("How Many Records you want to display ?")

        Dim userinput As Integer = Integer.Parse(Console.ReadLine())
        'numbers.Sort()
        'numbers.Reverse()
        Dim topnumbers As List(Of Integer) = numbers.OrderByDescending(Function(n) n).Take(userinput).ToList()
        Console.WriteLine($"The Top {userinput} records from the list are : {String.Join(",", topnumbers)}")

        Console.ReadKey(0)
    End Sub
End Module

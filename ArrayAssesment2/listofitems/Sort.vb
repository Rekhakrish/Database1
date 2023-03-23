Imports System

Module Sort
    Sub Main(args As String())
        Dim name As New List(Of String)
        name.Add("Rekha")
        name.Add("Ram")
        name.Add("ManiRamya")
        name.Add("Srinivasravi")
        name.Sort()


        For Each s As String In name


            Console.WriteLine($"Sorted Names Are :{s}")
        Next
    End Sub
End Module

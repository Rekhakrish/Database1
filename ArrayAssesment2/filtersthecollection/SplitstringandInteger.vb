Imports System

Module SplitstringandInteger
    Sub Main(args As String())
        Dim list As New ArrayList()
        list.Add(1)
        list.Add("Ramya")
        list.Add(3)
        list.Add("Rekha")
        list.Add(5)


        Dim filteredlist As New ArrayList()
        Dim stringResult = From s In list.OfType(Of String)()
        For Each i As String In stringResult
            Console.WriteLine(i)
        Next
        Dim integerResult = From s In list.OfType(Of Integer)()
        For Each x As String In integerResult
            Console.WriteLine(x)
        Next

    End Sub
End Module

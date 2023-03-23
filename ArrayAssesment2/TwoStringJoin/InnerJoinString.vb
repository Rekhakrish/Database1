Imports System

Module InnerJoinString
    Sub Main(args As String())

        Dim array1() As String = {"Rekha", "Ram", "Srinivas"}
        Dim name As New List(Of String)
        Dim array2() As String = {"Rekha", "Ramya", "Srinvas"}

        Dim list As List(Of String) = New List(Of String)(array1.Intersect(array2).ToArray())

        For Each s As String In list


            Console.WriteLine(s)
        Next

        Dim list1 As List(Of String) = New List(Of String)
        list1.Add("Rekha")
        list1.Add("Ram")
        list1.Add("Srinivas")

        Dim list2 As List(Of String) = New List(Of String)
        list2.Add("Rekha")
        list2.Add("Ramya")
        list2.Add("Srinivas")

        Dim list3 As New List(Of String)

        For Each x As String In list1
            For Each y As String In list2
                If x = y Then
                    list3.Add(x)
                End If
            Next
        Next
        For Each z As String In list3
            Console.WriteLine(z)
        Next
    End Sub
End Module

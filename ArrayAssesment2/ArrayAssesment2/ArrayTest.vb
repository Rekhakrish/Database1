Imports System

Module ArrayTest
    Sub Main(args As String())
        Dim numbers_list(5) As Integer
        Dim index As Integer
        Dim count As Integer
        Dim num As Integer
        Dim flag As Boolean

        Console.WriteLine("Enter the Number :")
        For index = 0 To 5
            numbers_list(index) = Console.ReadLine()


        Next

        Dim emptylist = (numbers_list.GroupBy(Function(s) s))

        For Each n As IGrouping(Of Integer, Integer) In emptylist
            Console.WriteLine(n)
        Next
        'For index = 0 To 5
        '    count = 0
        '    num = numbers_list(index)
        '    flag = False

        '    For i = 0 To index
        '        If numbers_list(i) = num Then
        '            flag = True

        '            count = count + 1
        '        End If
        '    Next
        '    If flag = True Then
        '        For i = 0 To 5
        '            If numbers_list(i) = num Then

        '            End If
        '        Next

        '        Console.WriteLine("Number : " & num & " " & "Occurs :" & count & " " & "times")
        '    End If
        'Next
        Console.ReadKey()
    End Sub
End Module

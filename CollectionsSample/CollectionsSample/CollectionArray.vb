Public Class CollectionArray

    Public Sub Array()

        Dim itemList As ArrayList = New ArrayList()
        Dim item As Integer

        'itemList.Add("item 4")
        'itemList.Add("item 3")
        'itemList.Add("item 1")
        'itemList.Add("item 2")

        'For item = 0 To itemList.Count - 1
        '    Console.WriteLine(item)
        'Next

        For item = 0 To 3
            Console.WriteLine("Enter the value of Array")
            itemList.Add(Console.ReadLine())
        Next

        Console.WriteLine("Sorted Elements")
        itemList.Sort()
        For itemvalue = 0 To 6
            Console.WriteLine(item)
        Next
    End Sub


End Class

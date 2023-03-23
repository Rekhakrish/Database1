Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates


Module Program
    Sub Main(args As String())
        separatebox()

        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" Press Any Key ......")
    End Sub
End Module
Module Array1
    Public Sub separatebox()
        Dim IData(4) As Integer

        IData(0) = 1
        IData(1) = 2
        IData(2) = 3
        IData(3) = 4
        IData(4) = 5

        Dim i As Integer
        For i = 0 To 4
            MsgBox(IData(i))
        Next



    End Sub
End Module
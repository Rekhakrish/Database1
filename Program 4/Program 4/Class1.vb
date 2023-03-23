Module Main
    Public Sub Main()
        'HeatAnalysis()
        'ColorAnalysis()

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Press any key ....")
        Console.ReadKey()

    End Sub
End Module

Module Program3
        Public Sub HeatAnalysis()
            Dim flag As Integer

            Console.WriteLine("Enter the flaG (1-3): ")
            flag = Console.ReadLine()

            Select Case flag
                Case 1
                    Console.WriteLine("Hot")
                Case 2
                    Console.WriteLine("Luke worm")
                Case 3
                    Console.WriteLine("Cold")
                Case Else
                    Console.WriteLine("Out of range!")




            End Select


        End Sub
    End Module
Module Colouranalysis
    Public Sub ColorAnalysis()
        Dim C As Char
        Console.WriteLine("Enter the Color Code: ")
        C = Console.ReadLine()

        Select Case C
            Case "r", "R"
                Console.WriteLine("Red")
            Case "g", "G"
                Console.WriteLine("Green")
            Case "b", "B"
                Console.WriteLine("Blue")
            Case Else
                Console.WriteLine("Black")



        End Select

    End Sub
End Module
Module Cat
    Public Sub SayHello()
        Dim Name As String
        Dim Breed As String

        Name = "Fluffy"
        Breed = "Moggy"

        MsgBox(Name & " " & Breed)
    End Sub
End Module
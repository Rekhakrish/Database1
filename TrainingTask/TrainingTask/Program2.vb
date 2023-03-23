Module programm2
    Public Sub TextAnalysis()
        Dim S As String
        Console.WriteLine("Enter The String ")
        S = Console.ReadLine

        Dim Ccount, Dcount, Scount, Ocount As Integer
        Ccount = 0 : Dcount = 0 : Scount = 0 : Ocount = 0

        Dim c As Char
        For Each c In S
            Select Case c
                Case "A" To "Z", "a" To "z"
                    Ccount += 1
                Case "0" To "9"
                    Dcount += 1
                Case " ", vbTab, vbCr, vbLf
                    Scount += 1
                Case Else
                    Ocount += 1


            End Select

        Next

        Console.WriteLine(vbCrLf)
        Console.WriteLine("Alphabets : {0},", Ccount)
        Console.WriteLine("Digits : {0},", Dcount)
        Console.WriteLine("Spaces : {0},", Scount)
        Console.WriteLine("Others : {0},", Ocount)




    End Sub
End Module
Module VOWELS
    Public Sub Vowelscount()
        Dim S As String
        Console.WriteLine("Enetr the String")
        S = Console.ReadLine()

        Dim c As Char
        Dim Vcount, Ccount As Integer
        Vcount = 0 : Ccount = 0

        For Each c In S
            Select Case c
                Case "A" To "Z", "a" To "z"
                    Select Case c
                        Case "A", "E", "I", "O", "U", "a", "e", "i", "o", "u"
                            Vcount += 1

                        Case Else
                            Ccount += 1
                    End Select
            End Select



        Next
        Console.WriteLine(vbCrLf)
        Console.WriteLine("Vowels : {0}", Vcount)
        Console.WriteLine("Constants : {0}", Ccount)



    End Sub
End Module
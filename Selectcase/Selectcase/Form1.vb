Public Class Form1
    Private Sub Btntemp_Click(sender As Object, e As EventArgs) Handles Btntemp.Click
        Dim Temprature As Integer
        Temprature = TextBox1.Text

        Select Case Temprature
            Case 30 To 70
                MsgBox("Cold")
            Case 70 To 90

                MsgBox("Normal")
            Case Else
                MsgBox("Hot")


        End Select
        MsgBox("Everything is Fine")

    End Sub

    Private Sub Btniteration_Click(sender As Object, e As EventArgs) Handles Btniteration.Click
        Dim icount As Integer
        Dim scout As String

        '  For icount = 0 To 50 Step 5
        ' MsgBox(icount)
        ' Next
        'For icount = 1 To 5
        'Beep() 'For Beep Sound
        'Threading.Thread.Sleep(3000) 'Beep sound will beeping for 5 times(in loop count) in 3 seconds
        'Next
        'For displaying all loop output in one time
        For icount = 1 To 10
            scout = scout & icount & vbNewLine

        Next
        MsgBox(scout)

    End Sub

    Private Sub BtnOddOrEven_Click(sender As Object, e As EventArgs) Handles BtnOddOrEven.Click
        Dim iMax As Integer
        Dim stOddorEven As String
        Dim X As Integer



        iMax = InputBox("What number do you want to count up to")
        stOddorEven = InputBox("Do you want odd number or even number")

        If stOddorEven = "even" Then
            For X = 2 To iMax Step 2
                MsgBox(X)
            Next
        ElseIf stOddorEven = "Odd" Then
            For X = 1 To iMax Step 2
                MsgBox(X)

            Next


        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btndowhile.Click

        'Covert String into Integer
        Dim iAge As Integer
        Dim SAge As String

        Do While IsNumeric(SAge) = False
            SAge = InputBox("Enter Your age in years")
        Loop
        iAge = CInt(SAge)

        MsgBox("Hello you are " & iAge)


    End Sub
End Class

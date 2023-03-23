Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim stcountry As String
        stcountry = txtcountry.Text




        If stcountry = "Australia" Then
            MsgBox("Hi Guys")
        ElseIf stcountry = "America" Then
            MsgBox("Good Morning America")
        ElseIf stcountry = "Japan" Then
            MsgBox("Hey Japan")
        Else
            MsgBox("Hey country!!")




        End If
        MsgBox(" You are entered" & " " & stcountry)

    End Sub

    Private Sub BtnGrade_Click(sender As Object, e As EventArgs) Handles BtnGrade.Click
        Dim iscore As Integer
        iscore = Txtscore.Text



        If iscore < 0 Or iscore > 100 Then
            MsgBox("invalid number.Enter the value between 0 to 100")
        ElseIf iscore <= 20 Then
            MsgBox("Grade E")
        ElseIf iscore > 20 And iscore <= 30 Then
            MsgBox("Grade D")
        ElseIf iscore > 30 And iscore <= 40 Then
            MsgBox("Grade C")
        ElseIf iscore > 40 And iscore <= 80 Then
            MsgBox("Grade B")
        Else
            MsgBox("Grade A")
        End If

        MsgBox("Grade is Updated")
    End Sub
End Class

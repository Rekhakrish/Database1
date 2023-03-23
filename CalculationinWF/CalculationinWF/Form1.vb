Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtnum1.TextChanged

    End Sub

    Private Sub butRes_Click(sender As Object, e As EventArgs) Handles butRes.Click
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim Result As Integer

        Number1 = Txtnum2.Text
        Number2 = Txtnum2.Text
        Result = Number1 + Number2

        MsgBox("Result is  " & Result)


    End Sub
End Class

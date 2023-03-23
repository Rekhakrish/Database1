Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, Sum As Integer
        Dim avg As Double

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)
        Sum = num1 + num2 + num3

        avg = Sum / 3

        TextBox4.Text = Sum
        TextBox5.Text = avg




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class

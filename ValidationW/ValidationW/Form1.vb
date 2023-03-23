Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxstudentname.KeyPress, TextBoxstudentname.KeyPress
      

    Private Sub Buttonsummit_Click(sender As Object, e As EventArgs) Handles Buttonsummit.Click, Buttonsummit.Click
        Dim studentname As String = TextBoxstudentname.Text

        If Char.IsLetter(studentname) And studentname = "" Then


            If studentname.Length <= 50 And studentname.Length >= 1 Then
                If Regex.IsMatch(studentname, "^[a-z]+$", RegexOptions.IgnoreCase) Then
                    MessageBox.Show(studentname)

                Else
                    MessageBox.Show("Character count should be 50")
                End If


            End If


        End If

        MessageBox.Show("Character should not be empty or integer")

    End Sub
End Class

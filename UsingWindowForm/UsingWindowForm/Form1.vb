Public Class Form1
    Private Sub BtntoGo_Click(sender As Object, e As EventArgs) Handles BtntoGo.Click
        Dim stFirstName As String
        Dim stLastnmae As String
        Dim Gender As String
        Dim Occupation As String

        stFirstName = txtFirstname.Text
        stLastnmae = txtlastname.Text
        Gender = txtgender.Text
        Occupation = lstOccupation.SelectedItem




        MsgBox("Hello" & " " & stFirstName & " " & stLastnmae & " " & "you are a " & Gender & " " & Occupation)








    End Sub
End Class

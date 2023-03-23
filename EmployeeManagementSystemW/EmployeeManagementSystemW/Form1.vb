Public Class FormofEmp
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LblEmpID.Click

    End Sub

    Private Sub Btncreate_Click(sender As Object, e As EventArgs) Handles Btncreate.Click
        Dim empid As String = empIdtxt.Text
        Dim empname As String = txtempname.Text
        Dim basicpay As Integer = Txtbasic.Text
        Dim salary As Integer = Txtsalary.Text
        Dim hra As Integer = TxtHra.Text


    End Sub
End Class

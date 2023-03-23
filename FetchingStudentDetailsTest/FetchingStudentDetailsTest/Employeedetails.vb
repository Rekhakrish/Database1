Imports System.Data.SqlClient

Public Class Employeedetails

    Dim connection As SqlConnection = New SqlConnection("server =NLTI155\SQLEXPRESS; database = GetEmployeedata;integrated Security = true")


    Private Sub ButtonSalary_Click_1(sender As Object, e As EventArgs) Handles ButtonSalary.Click


        Dim command As SqlCommand = New SqlCommand("select s.Studentname,s.Gender,e.CompanyName,e.Jobrole,e.salary From getstudent s,getemployee e ORDER BY e.salary DESC", connection)
        Dim dataadapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        dataadapter.Fill(datatable)
        DataGridView1.DataSource = datatable
    End Sub

    Private Sub ButtonGroupBy_Click_1(sender As Object, e As EventArgs) Handles ButtonGroupBy.Click
        Dim command As SqlCommand = New SqlCommand("select s.StudentId, s.Studentname,s.Gender,s.collegeName,s.PassedOutYear,e.CompanyName,e.Jobrole,e.salary From getstudent s  Join getemployee e On s.StudentId=e.EmployeeId Group By e.Jobrole,s.StudentId, s.Studentname,s.Gender,s.collegeName,s.PassedOutYear,e.CompanyName,e.salary ", connection)
        Dim dataadapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        dataadapter.Fill(datatable)
        DataGridView1.DataSource = datatable
    End Sub
End Class
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Studentdetails

    Dim connection As SqlConnection = New SqlConnection("server =NLTI155\SQLEXPRESS; database = GetEmployeedata;integrated Security = true")
    Private Sub ButtonGetData_Click(sender As Object, e As EventArgs)
        Dim studentid As Integer = ComboBoxstudentid.Text


        Dim command As SqlCommand = New SqlCommand("select s.StudentId, s.Studentname,s.Gender,s.collegeName,s.PassedOutYear,e.CompanyName,e.Jobrole,e.salary From getstudent s  Join getemployee e On s.StudentId=e.EmployeeId where StudentId='" & studentid & "'", connection)
        Dim dataadapter As New SqlDataAdapter(command)
        Dim datatable As New DataTable
        dataadapter.Fill(datatable)
        DataGridView1.DataSource = datatable


    End Sub

    Private Sub ComboBoxstudentid_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        Employeedetails.Show()
        Me.Hide()
    End Sub
End Class

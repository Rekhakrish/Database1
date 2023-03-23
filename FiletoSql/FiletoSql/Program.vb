Imports System
Imports System.Data.SqlClient
Imports System.Data

Module Program
    Sub Main(args As String())
        Dim connString As String = "Data Source=nlti155\sqlexpress;Initial Catalog=Customer;Integrated Security=True;"
        Dim conn As New SqlConnection(connString)
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
    End Sub
End Module

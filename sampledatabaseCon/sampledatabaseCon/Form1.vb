Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection("Data Source=NLTI155\SQLEXPRESS;Initial Catalog=ProgrammingDB;Integrated Security=True")
    Private Sub Btnsummit_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        'Declaring the variables
        Dim pid As Integer = TxtProductId.Text
        Dim iname As String = TxtProductName.Text
        Dim design As String = TxtDesign.Text
        Dim color As String = ComColor.Text
        Dim indate As DateTime = InsertDate.Text
        Dim wtype As String = ""
        If RadioAllowed.Checked = True Then
            wtype = "Allowed"
        Else
            wtype = "NotAllowed"
        End If


        con.Open()
        Dim command As New SqlCommand("Insert into Product_Setup_Tab values('" & pid & "','" & iname & "','" & design & "','" & color & "','" & indate & "','" & wtype & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")
        LoadDataInGrid()
    End Sub
    'Adding method to load existing data in datagridview
    Private Sub LoadDataInGrid()
        'Put SQLConnection out of event and initialize the connection in any event of the page 
        Dim command As New SqlCommand("select * from Product_Setup_Tab", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim pid As Integer = TxtProductId.Text
        Dim iname As String = TxtProductName.Text
        Dim design As String = TxtDesign.Text
        Dim color As String = ComColor.Text
        Dim indate As DateTime = InsertDate.Text
        Dim wtype As String = ""
        If RadioAllowed.Checked = True Then
            wtype = "Allowed"
        Else
            wtype = "NotAllowed"
        End If


        con.Open()
        Dim command As New SqlCommand("update Product_Setup_Tab set ItemName ='" & iname & "',Design ='" & design & "',Color ='" & color & "',ItemDate ='" & indate & "',WarrantyType ='" & wtype & "'Where Product_Id='" & pid & "'", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated")
        LoadDataInGrid()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure want to delete", "Deleted Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim pid As Integer = TxtProductId.Text
            con.Open()
            Dim command As New SqlCommand("delete Product_Setup_Tab where Product_Id='" & pid & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            con.Close()
            LoadDataInGrid()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim pid As Integer = TxtProductId.Text
        Dim command As New SqlCommand("select * from Product_Setup_Tab where Product_Id='" & pid & "'", con)


        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
End Class

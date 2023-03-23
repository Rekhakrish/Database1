Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1
    Dim con As New SqlConnection("Data Source=nlti155\sqlexpress;Initial Catalog=EmployeeInfo;Integrated Security=True")


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Declare the variable
        Dim empid As Integer = TxtEmpId.Text
        Dim empname As String = TxtEmpName.Text
        Dim presentdays As Integer = TxtNofPresent.Text
        Dim basicpay As Integer = TxtBasicpay.Text
        Dim hra As Integer = TxtHra.Text
        Dim otherallowance As Integer = TxtOtherAll.Text
        Dim Totalgrosspay As Integer = TextBox1.Text
        Dim netsalary As Integer = TextBox3.Text
        Dim tax As Integer = TextBox2.Text


        con.Open()

        Dim command As New SqlCommand("Insert into Employee_Details values('" & empid & "','" & empname & "','" & presentdays & "','" & basicpay & "','" & hra & "','" & otherallowance & "','" & Totalgrosspay & "','" & netsalary & "','" & tax & "')", con)
        command.ExecuteNonQuery()

        con.Close()
        MessageBox.Show("Successfully Inserted")
        Button1_Click(sender, New System.EventArgs)
        'BtnTax_Click(sender, New System.EventArgs)
        LoadDataInGrid()
    End Sub

    Private Sub LoadDataInGrid()
        'Put SQLConnection out of event and initialize the connection in any event of the page 
        Dim command As New SqlCommand("select * from Employee_Details", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btngross.Click

        Dim basicpay As Integer = TxtBasicpay.Text
        Dim hra As Integer = TxtHra.Text
        Dim otherallowance As Integer = TxtOtherAll.Text

        Dim grosssalary As Integer

        grosssalary = basicpay + hra + otherallowance


        TextBox1.Text = grosssalary.ToString()


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim empid As Integer = TxtEmpId.Text
        Dim empname As String = TxtEmpName.Text
        Dim presentdays As Integer = TxtNofPresent.Text
        Dim basicpay As Integer = TxtBasicpay.Text
        Dim hra As Integer = TxtHra.Text
        Dim otherallowance As Integer = TxtOtherAll.Text
        'Dim Totalgrosspay As Integer = TextBox1.Text

        con.Open()
        Dim command As New SqlCommand("update Employee_Details set EmployeeName ='" & empname & "',NumberOfDaysPresent ='" & presentdays & "',BasicPay ='" & basicpay & "',HRA ='" & hra & "',OtherAllowance ='" & otherallowance & "'Where EmployeeId='" & empid & "'", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated")
        LoadDataInGrid()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure want to delete", "Deleted Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim empid As Integer = TxtEmpId.Text
            con.Open()
            Dim command As New SqlCommand("delete Employee_Details where EmployeeId='" & empid & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            con.Close()
            LoadDataInGrid()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim empid As Integer = TxtEmpId.Text
        Dim command As New SqlCommand("select * from Employee_Details where EmployeeId='" & empid & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub



    Private Sub BtnTax_Click(sender As Object, e As EventArgs) Handles BtnTax.Click
        Dim grosssalary As Integer = TextBox1.Text
        Dim tax As Integer
        Dim calculateTax As Integer
        calculateTax = grosssalary * 12
        If calculateTax < 500000 Then
            tax = 0
        ElseIf (calculateTax > 500000 And calculateTax < 1000000) Then
            tax = (calculateTax - 500000) * 0.2
        ElseIf (calculateTax >= 1000000) Then

            tax = (calculateTax - 500000) * 0.3

        End If
        TextBox2.Text = tax.ToString()
    End Sub

    Private Sub BtnNetSalary_Click(sender As Object, e As EventArgs) Handles BtnNetSalary.Click
        Dim grosssalary As Integer = TextBox1.Text
        Dim tax As Integer = TextBox2.Text
        Dim netsalary As Integer
        netsalary = grosssalary - tax - 1800
        TextBox3.Text = netsalary.ToString()
    End Sub

    Private Sub TxtBasicpay_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBasicpay.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtHra_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHra.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtOtherAll_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOtherAll.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtNofPresent_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNofPresent.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtEmpName_TextChanged(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
            Else
                MessageBox.Show("Invalid Input! Characters Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub


End Class
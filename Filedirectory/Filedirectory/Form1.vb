Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim con As New SqlConnection("Data Source=nlti155\sqlexpress;Initial Catalog=School;Integrated Security=True")
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Dim directory = "C:\Files"
        ' Dim filePath As String = "c:\Files.txt"
        ' Dim files() As System.IO.FileInfo
        ' Dim dirInfo As New System.IO.DirectoryInfo(directory)
        '  files = dirInfo.GetFiles("*", IO.SearchOption.AllDirectories)
        ' For Each file In files
        'ListBox1.Items.Add(file)
        'Next
        'If System.IO.File.Exists(filePath) Then
        'The file exists
        'Else
        'The file does not exist
        'End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim directory = "C:\Files"
        'Dim filePath As String = "c:\Files.txt"
        ' Dim files() As System.IO.FileInfo
        ' Dim dirInfo As New System.IO.DirectoryInfo(directory)
        ' files = dirInfo.GetFiles("*", IO.SearchOption.AllDirectories)
        ' For Each file In files
        'ListBox1.Items.Add(file)
        ' Next
        'If System.IO.File.Exists(filePath) Then
        'The file exists
        '   Else
        'The file does not exist
        ' End If
        '

        Dim oReader As StreamReader


        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            oReader = New StreamReader(OpenFileDialog1.FileName, True)
            RichTextBox1.Text = oReader.ReadToEnd
            '   Dim text As String = File.ReadAllText("C:\Files\rekha.txt")
            '  Dim str As String = "1,Rekha,31.01.1998,Phone Number,Email Id,Temporary Address,Pincode,Permanent Address,Pincode,Adhar Number"

            ' Dim arr As String() = str.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)

        End If
    End Sub



    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles BtnCheck.Click
        Dim path As String
        path = TextBox1.Text
        Dim files() As String
        Dim folders() As String
        If Directory.Exists(path) Then
            files = Directory.GetFiles(path)
            folders = Directory.GetDirectories(path)

            Label1.Text = files.Length & "File And " & folders.Length & "Folder"
        End If
    End Sub

    Private Sub BtnchckFile_Click(sender As Object, e As EventArgs) Handles BtnchckFile.Click
        Dim filePath As String
        filePath = TextBox2.Text

        If File.Exists(filePath) Then
            MessageBox.Show("File Exist")
        Else
            MessageBox.Show("File does not Exist")
        End If
    End Sub

    Private Sub BtnFolder_Click(sender As Object, e As EventArgs) Handles BtnFolder.Click
        Dim folderPath As String
        folderPath = TextBox3.Text

        If Directory.Exists(folderPath) Then
            MessageBox.Show("Folder Exist")
        Else
            MessageBox.Show("Folder does not Exist")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btntextfile.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged




        ' RichTextBox1.Text = array2(2).ToString
        'RichTextBox1.Text = array3.ToString
        'Dim str As String '= "1,Rekha,31.01.1998,Phone Number,Email Id,Temporary Address,Pincode,Permanent Address,Pincode,Adhar Number"

        ' Dim substring As String
        'Dim sp() As String
        'str = RichTextBox1.Text
        'sp = str.Split(","c)
        'RichTextBox1.Text = sp(0)
        'RichTextBox1.Text = sp(1)
        'RichTextBox1.Text = sp(2)

        ' RichTextBox1.Text = (sp(str))
        ' = str.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
        ' Dim arr1 As String() = str.Split(","c)

        'For Each item As String In arr
        'Console.WriteLine(item)
        'Next
        ' MessageBox.Show(arr(0))
        '  RichTextBox1.Text = arr(0).ToString()
        ' RichTextBox1.Text = arr(1).ToString()
        ' RichTextBox1.Text = arr(2).ToString()
        'RichTextBox1.Text = arr(3).ToString()
        ' RichTextBox1.Text = arr(4).ToString()
        '  RichTextBox1.Text = arr(5).ToString()
        ' RichTextBox1.Text = arr(6).ToString()
        ' RichTextBox1.Text = arr(7).ToString()
        ' RichTextBox1.Text = arr(8).ToString()
        ' RichTextBox1.Text = arr(9).ToString()

    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click


        Dim stuId As Integer = TxtId.Text
        Dim stuName As String = TxtName.Text
        ' Dim stuDate As Date = DateTimePicker1.Text
        Dim stuEmail As String = Txtemail.Text
        Dim tempAdd As String = Txttemaddress.Text
        Dim pcode As String = Txtpcode.Text
        Dim perAdd As String = TxtPerAddress.Text
        Dim pode2 As String = TxtPcode2.Text
        Dim pNum As String = TxtPhnNum.Text
        Dim aNum As String = TxtaNum.Text


        con.Open()
        Dim command As New SqlCommand("Insert into Student1_Info values('" & stuId & "','" & stuName & "','" & stuEmail & "','" & tempAdd & "','" & pcode & "','" & perAdd & "','" & pode2 & "','" & pNum & "','" & aNum & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")
        LoadDataInGrid()
    End Sub

    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Student1_Info", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView2.DataSource = dt
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim dataArray() As String = RichTextBox1.Text.Split(",")
        TxtId.Text = dataArray(0)
        TxtName.Text = dataArray(1)
        'DateTimePicker1.Text = dataArray(2)
        TxtPhnNum.Text = dataArray(2)
        Txtemail.Text = dataArray(3)
        Txttemaddress.Text = dataArray(4)
        Txtpcode.Text = dataArray(5)
        TxtPerAddress.Text = dataArray(6)
        TxtPcode2.Text = dataArray(7)
        TxtaNum.Text = dataArray(8)

        If CheckBox1.Checked = False Then
            TxtId.Text = ""
            TxtName.Text = ""
            'DateTimePicker1.Text = ""
            TxtPhnNum.Text = ""
            Txtemail.Text = ""
            Txttemaddress.Text = ""
            Txtpcode.Text = ""
            TxtPerAddress.Text = ""
            TxtPcode2.Text = ""
            TxtaNum.Text = ""
        End If

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure want to delete", "Deleted Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim stuId As Integer = TxtId.Text
            con.Open()
            Dim command As New SqlCommand("delete Student1_Info where StudId='" & stuId & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            con.Close()
            LoadDataInGrid()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim stuId As Integer = TxtId.Text
        Dim stuName As String = TxtName.Text
        Dim stuEmail As String = Txtemail.Text
        Dim tempAdd As String = Txttemaddress.Text
        Dim pcode As String = Txtpcode.Text
        Dim perAdd As String = TxtPerAddress.Text
        Dim pode2 As String = TxtPcode2.Text
        Dim pNum As String = TxtPhnNum.Text
        Dim aNum As String = TxtaNum.Text

        con.Open()
        Dim command As New SqlCommand("update Student1_Info set stuName ='" & stuName & "',TempAdd ='" & tempAdd & "',AdharNum ='" & aNum & "',Email ='" & stuEmail & "',Pcode2 ='" & pode2 & "',PNum ='" & pNum & "',PerAdd='" & perAdd & "',Pcode='" & pcode & "'Where studId='" & stuId & "'", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated")
        LoadDataInGrid()
    End Sub
End Class

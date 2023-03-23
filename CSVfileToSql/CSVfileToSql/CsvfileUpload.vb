

Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Reflection.Emit
Imports Microsoft.SqlServer
Imports File = System.IO.File

Module CSVfileToSQL

    '    Public Property FileUpload1 As Object
    '   Public Server As Object


    ' Using conn As New SqlConnection(connString)
    'con.Open()
    'Dim cmd As New SqlCommand()
    Sub Main()
        ' Dim File1 As String = file.ReadAllText("C:\Files\rekha.txt")
        'Console.WriteLine(File1)
        'Console.Read()
        ' Dim csvPath As String = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName)
        ' FileUpload1.SaveAs(csvPath)
        'Dim dt As New DataTable()
        'dt.Columns.AddRange(New DataColumn(2) {New DataColumn("SerialNumber", GetType(Integer)), New DataColumn("Name", GetType(String)), New DataColumn("Country", GetType(String))})
        '' Dim csvData As String = File.ReadAllText(File1)
        'For Each row As String In File1.Split(ControlChars.Lf)
        '    If Not String.IsNullOrEmpty(row) Then
        '        dt.Rows.Add()
        '        Dim i As Integer = 0
        '        For Each cell As String In row.Split(","c)
        '            ' dt.Rows(dt.Rows.Count-1)(i) = cell
        '            'i += 1
        '        Next
        '    End If
        'Next
        ''Dim File1 As String = File.ReadAllText("C:\Files\Sample.csv")
        'Console.WriteLine(File1)
        'Console.Read()
        '--------------------------------------------------------------------
        Dim rows As String() = File.ReadAllText("C:\Files\Sample.csv").Split(New Char() {","c})

        'Dim consString As String = "Data Source=nlti155\sqlexpress;Initial Catalog=Customer;Integrated Security=True;"

        '    Dim conn As New SqlConnection(consString)
        'conn.Open()


        'Dim cmd As New SqlCommand()
        'cmd.Connection = conn
        'cmd.CommandType = CommandType.Text

        'cmd.CommandText = "BULK INSERT Customer_Info FROM 'C:\Files\rekha.txt' WITH(FIELDTERMINATOR=',',ROWTERMINATOR='0x0a')"
        'cmd.ExecuteNonQuery()
        'conn.Close()
        '------------------------------------------------------------------
        'Dim consString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        'Dim con As New SqlConnection(consString)
        'Dim sqlBulkCopy As New SqlBulkCopy(con)
        ''Set the database table name.
        'sqlBulkCopy.DestinationTableName = "dbo.Customer_Info"
        'con.Open()
        'sqlBulkCopy.WriteToServer(dt)
        'con.Close()
        '----------------------------------------------------------------------------------
        'Dim filePath As String = "C:\Files\Sample.csv"
        'Dim fileReader As New System.IO.StreamReader(filePath)
        'Dim line As String

        'While Not fileReader.EndOfStream
        '    line = fileReader.ReadLine()
        '    Dim values() As String = line.Split(","c)
        'End While
        'fileReader.Close()

        'Dim connection As New SqlConnection("Data Source=nlti155\sqlexpress;Initial Catalog=Customer;Integrated Security=True")
        'connection.Open()
        'Dim command As New SqlCommand("INSERT INTO Customer_Info(Name,Country)VALUES(JohnHammond,UnitedStates)", connection)
        'command.ExecuteNonQuery()
        'connection.Close()
        '-------------------------------------------------------------------------------------
        'Dim csvFile As String = File.ReadAllText("C:\Files\Customer.csv")

        'Dim lines() As String = csvFile.Split(Environment.NewLine)
        'Console.WriteLine(csvFile)

        'For Each line As String In lines
        '    Dim fields() As String = line.Split(",")
        '    Dim field1 As String = fields(0)
        '    Dim field2 As String = fields(1)
        '    Dim field3 As String = fields(2)
        'Next
        '----------------------------------------------------------------------

    End Sub


End Module

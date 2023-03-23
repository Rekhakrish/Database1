Imports Microsoft.VisualBasic.FileIO
Imports System.Data.SqlClient
Imports System.IO

Public Class Class1
    Dim id As String

    Dim name As String
    Dim street As String
    Dim city As String
    Dim state As String
    Dim zipcode As String

    Dim dateofbirth As String

    Dim dateofjoining As String
    ' Date.TryParse(values(7), dateofbirth)
    Dim project As String
    Public Sub caluc()
        Dim connection As New SqlConnection("Data Source=NLTI155\SQLEXPRESS;Initial Catalog=FileManagement;Integrated Security=True")
        Dim read As New TextFieldParser("D:\Project\FileMergeService\TestFile.csv")
        Dim filestream As New FileStream("D:\Project\DataFileImport\ReadedFile.txt", FileMode.Append, FileAccess.Write)
        Dim streamWriter As New StreamWriter(filestream)
        read.Delimiters = New String() {","}
        read.TextFieldType = FieldType.Delimited

        read.ReadLine()
        While read.EndOfData() = False
            Dim fields = read.ReadFields()
            id = fields(0)
            name = fields(1)
            street = fields(2)
            city = fields(3)
            state = fields(4)
            zipcode = fields(5)
            dateofbirth = fields(6)
            dateofjoining = fields(7)
            project = fields(8)


            streamWriter.WriteLine(id & "|" & name & "|" & street & "|" & city & "|" & state & "|" & zipcode & "|" & dateofbirth & "|" & dateofjoining & "|" & project)
            Dim readtxt As New TextFieldParser("D:\Project\DataFileImport\ReadedFile.txt")
            readtxt.Delimiters = New String() {"|"}
            readtxt.TextFieldType = FieldType.Delimited
            connection.Open()
            Dim command As New SqlCommand($"Insert into Filedata(Id,EmpName,Street,City,EmpState,ZipCode,DateofBirth,DateofJoining,Project)values({id},'{name}','{street}','{city}','{state}',{zipcode},'{dateofbirth}','{dateofjoining}','{project}')", connection)
            command.ExecuteNonQuery()
            connection.Close()

        End While

        streamWriter.Flush()
        streamWriter.Close()
        filestream.Close()

        File.Move("D:\Project\FileMergeService\TestFile.csv", "D:\Project\FileMergeService\Archieve\TestFile.csv")
    End Sub

End Class

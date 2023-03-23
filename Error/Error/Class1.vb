Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports NLog

#Region "ManagingCsv"
''' <summary>
''' ManagingCsv Class is used for managing the csvfile only .
''' Read the csv File one by one and insert into database if it new student or existing student it will update and override.
''' Also contains the ReadFile method to run the several logic operation 
''' </summary>
Public Class ManagingCsv
#Region "Non-Public Declarations"
    Dim connection As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("FileConnectionToDatabase").ConnectionString)

    'Path for three folder in D drive
    'Path for unprocessed folder
    Dim unProcessedPath As String = ConfigurationManager.AppSettings("Unprocessed")
    'Path for processed folder
    Dim processedPath As String = ConfigurationManager.AppSettings("Processed")
    'Path for error folder
    Dim errorPath As String = ConfigurationManager.AppSettings("Error")
    'Path for logfile folder
    Dim logFilePath As String = ConfigurationManager.AppSettings("logfile")
    'You need logging you need to inject ilogger 
    Public logger As ILogger = LogManager.GetCurrentClassLogger()
#End Region
#Region "Public Methods"
    ''' <summary>
    ''' Check the logfile created or not if not created will be create.Check the unprocessed folder only process the csvfile other format file will go to error folder append with datetime.
    ''' The logic need to verify if columns matching as per requirement, if columns not matching, move that csv file to Error folder
    ''' If any file placed in Unprocessed folder which is not csv, the file should be moved to Error folder and continue with next files.
    ''' If a csv contains same Student Id and marks for same subject, consider this latest marks and over write DB marks.
    ''' If csv contains same Student Id and marks for same subject in one file, consider latest marks
    ''' </summary>
    Public Sub ReadFile()
        'Declaring filepath for logfile
        Dim filePath As String = logFilePath
        'Checking file is exist or not
        If Not File.Exists(filePath) Then
            'If it is not there need to create logfile
            File.Create(filePath).Dispose()
        End If
        'Create Array for read the csv file one by one
        Dim csvFiles() As String = Directory.GetFiles(unProcessedPath)
        Dim Check As Integer = 0

        Try
            'Read the csv file in the array
            For Each csvFile As String In csvFiles
                'Getting Filename from folder
                Dim withoutExtensionFileName As String = System.IO.Path.GetFileNameWithoutExtension(csvFile)
                'Getting Extension for File
                Dim getFileNameWithExtension As String = Path.GetExtension(csvFile)
                'Checking extension if it is the csv file
                If getFileNameWithExtension = ".csv" Then
                    Dim file_count As Integer = File.ReadAllLines(csvFile).Length
                    'Using stream reader read the csv file
                    Using reader As New StreamReader(csvFile)
                        'Declaring variable name
                        Dim studentName As String
                        Dim studentRollNumber As String
                        Dim subjectMark As String
                        Dim subjectName As String
                        'Creating a emptylist for storing column name in database 
                        Dim databaseColumnList As New List(Of String)
                        'Creating a emptylist For storing column name in Csv 
                        Dim csvColumnList As New List(Of String)
                        Try
                            'Read and Split the header column
                            Dim headers As String() = reader.ReadLine().Split(","c)
                            'Remove the Space between two strin in csvheadercolumn
                            For Each columnInCsv As String In headers
                                Dim headerInCsv As String = columnInCsv.Replace(" ", "")
                                'Adding the without space csv header column in csvcolumn emptylist 
                                csvColumnList.Add(headerInCsv)
                            Next
                            connection.Open()
                            'Query For maintaining column name
                            Dim maintainingColumn As New SqlCommand("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('Studentdetails')", connection)
                            Dim columnReader As SqlDataReader = maintainingColumn.ExecuteReader()
                            While (columnReader.Read())
                                databaseColumnList.Add(columnReader("name").ToString())
                            End While
                            connection.Close()
                            'Check whether the header in csv and column in database
                            If csvColumnList.Count() = databaseColumnList.Count() Then
                                'Check whether the same column name exist or not
                                If csvColumnList(0) = databaseColumnList(0) AndAlso csvColumnList(1) = csvColumnList(1) AndAlso csvColumnList(2) = databaseColumnList(2) AndAlso csvColumnList(3) = databaseColumnList(3) Then
                                    'Read until the end of data in csv
                                    While Not reader.EndOfStream
                                        Try
                                            'Read the data after header column 
                                            Dim valuesInRow As String() = reader.ReadLine().Split(","c)
                                            'Checking whether any field is empty 
                                            If valuesInRow(0) <> "" AndAlso valuesInRow(1) <> "" AndAlso valuesInRow(2) <> "" AndAlso valuesInRow(3) <> "" Then
                                                'assigning the values 
                                                studentName = valuesInRow(0)
                                                studentRollNumber = valuesInRow(1)
                                                subjectMark = valuesInRow(2)
                                                subjectName = valuesInRow(3)
                                                Check += 1
                                            Else
                                                'Stream reader is close
                                                reader.Close()
                                                'If any error file will be moved to errorpath
                                                File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                                'Write an information in logger file that is any field is empty or not if it empty move to error folder 
                                                logger.Info($"In {csvFile} - There is an field with empty value so moved from unprocessed to Error Folder : {withoutExtensionFileName} {getFileNameWithExtension}")
                                                'Goto endofcode to read the next file
                                                GoTo endofcode
                                            End If
                                        Catch ex As Exception
                                            logger.Error(ex, $"Error Processing file : {csvFile}")
                                        End Try
                                        Try
                                            Dim mark As Integer
                                            'Get the value only in integer mark
                                            Integer.TryParse(subjectMark, mark)
                                            If mark <> 0 Then
                                                'If subjectmark is lessthan or equal to 100 then enter into the sql
                                                If subjectMark <= 100 Then
                                                    'Sqlconnection open for command and connecting database
                                                    connection.Open()
                                                    'Checking the student that is present in database while reading the database
                                                    Dim checkingStudentdata As New SqlCommand($"select * from Studentdetails where studentname = '{studentName}' and subjectname = '{subjectName}'", connection)
                                                    'Reading the Table
                                                    Dim readingFromTable As SqlDataReader = checkingStudentdata.ExecuteReader()
                                                    'Declaring asignReadingTable variable to Reader in sql
                                                    Dim asignReadingTable As Integer = readingFromTable.Read()
                                                    'Sqlreader is close
                                                    readingFromTable.Close()
                                                    'Database connection close
                                                    connection.Close()
                                                    If asignReadingTable = -1 Then
                                                        connection.Open()
                                                        'Checking the studentdata that is present in database .Compare csv data and database data
                                                        Dim checkingExistingStudent As New SqlCommand($"(select '{studentName}','{studentRollNumber}',{subjectMark},'{subjectName}' where not exists (Select * from Studentdetails where StudentName = '{studentName}' and StudentRollNumber = '{studentRollNumber}' and SubjectMarks = {subjectMark} and SubjectName = '{subjectName}'))", connection)
                                                        Dim ReadTable As SqlDataReader = checkingExistingStudent.ExecuteReader()
                                                        Dim assignTable As Integer = ReadTable.Read()
                                                        ReadTable.Close()
                                                        connection.Close()
                                                        If assignTable = -1 Then
                                                            connection.Open()
                                                            'If existing studentdata update the student data
                                                            Dim updateStudentData As New SqlCommand($"update Studentdetails set SubjectMarks = {subjectMark} where StudentName = '{studentName}' and StudentRollNumber = '{studentRollNumber}' and SubjectName = '{subjectName}'", connection)
                                                            'For execute Query using executenonquery 
                                                            updateStudentData.ExecuteNonQuery()
                                                            connection.Close()
                                                        Else
                                                            'In logfile data the student already present in database there is no any updation so we take it as a duplicate entry then enter into logfile
                                                            logger.Info($"There is an Duplicate entry in : {withoutExtensionFileName} {getFileNameWithExtension}")
                                                        End If
                                                    Else
                                                        connection.Open()
                                                        'If not existing studentdata insert into database
                                                        Dim insertStudentData As New SqlCommand($"insert into Studentdetails(StudentName,StudentRollNumber,SubjectMarks,SubjectName)values('{studentName}','{studentRollNumber}',{subjectMark},'{subjectName}')", connection)
                                                        'For execute Query using executenonquery 
                                                        insertStudentData.ExecuteNonQuery()
                                                        connection.Close()
                                                    End If
                                                Else
                                                    logger.Info($"Marks should be lesser than or equal to 100  so moved to Error Folder in : {withoutExtensionFileName} {getFileNameWithExtension}")
                                                    reader.Close()
                                                    'File move to Unprocessed to Errorpath
                                                    File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                                    GoTo endofcode
                                                End If
                                                connection.Close()
                                            Else
                                                reader.Close()
                                                'File move from Unprocessed to Errorpath
                                                File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                                logger.Info($"Marks Should Be Only In Integer : {subjectMark} is in String Format so moved from Unprocessed to Error Folder : {withoutExtensionFileName} {getFileNameWithExtension} ")
                                                GoTo endofcode
                                            End If
                                        Catch ex As Exception
                                            logger.Error(ex.Message, "Syntax Error")
                                        End Try
                                    End While
                                    'Closing the streamreader
                                    reader.Close()
                                    If (Check + 1) = file_count Then
                                        'Move the file from Unprocessed to to Processed Folder
                                        File.Move(csvFile, processedPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                        logger.Info($"Successfully Inserted And Updated so moved From Unprocessed {csvFile} to Processed Folder:  {withoutExtensionFileName} {getFileNameWithExtension}")
                                    Else
                                        'File Moved from Unprocessed to Error Folder
                                        File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                        logger.Info($"{csvFile} - File is moved to Error Folder because mistake in column name : {withoutExtensionFileName} {getFileNameWithExtension} ")
                                    End If
                                Else
                                    reader.Close()
                                    'File Moved from Unprocessed to Error Folder
                                    File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                    logger.Info($"{csvFile} - File is moved to Error Folder because mistake in column name : {withoutExtensionFileName} {getFileNameWithExtension} ")
                                End If
                            Else
                                'Streamreader is close
                                reader.Close()
                                'File is Moved from unprocessed to Error Folder
                                File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                                logger.Info($"{csvFile} - File is moved to Error Path because there will be missing column or empty file : {withoutExtensionFileName} {getFileNameWithExtension} ")
                            End If
                        Catch ex As Exception
                            logger.Error(ex.Message, $"Error Processing file : {csvFile}")
                        End Try
                    End Using
endofcode:
                Else
                    logger.Info($"{withoutExtensionFileName} {getFileNameWithExtension} - File is not in csv Format so moved to Error Folder ")
                    'File move from Unprocessed to Error folder 
                    File.Move(csvFile, errorPath + withoutExtensionFileName + DateTime.Now.ToString("_yyyy/MM/dd hh/mm/ss ") + getFileNameWithExtension)
                End If
            Next
        Catch ex As Exception
            logger.Error(ex.Message, $"Error Processing file : {csvFiles}")
        End Try
    End Sub
#End Region
End Class
#End Region

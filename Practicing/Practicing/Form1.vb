Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filename As String = "D:\StudentData\Unprocesssed\StudentMarks.csv"

        Dim student As New Dictionary(Of String, List(Of Object))
        Dim emptylist As New List(Of String)
        Using parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(filename)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(",")

            While Not parser.EndOfData
                Dim fields As String() = parser.ReadFields()
                If fields.Length = 4 Then
                    Dim studentrollno As String = fields(1)
                    Dim studentname As String = fields(0)
                    Dim studentmarks As String = fields(2)
                    Dim subject As String = fields(3)
                    student.Add(studentrollno, New List(Of Object) From {studentname, studentmarks, subject})

                End If
            End While

            'Dim rollnumber As String = "A101"
            'If student.ContainsKey(rollnumber) Then
            '    Dim studentdata = student(rollnumber)
            '    MessageBox.Show("studentname: " & studentdata.studentname)
            '    MessageBox.Show("studentmarks: " & studentdata.studentmarks)
            '    MessageBox.Show("subject: " & studentdata.subject)

            'End If

        End Using
    End Sub
End Class

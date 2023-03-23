Imports System.Text.RegularExpressions

Public Class Studentnamevalidation
    Public studentName As String

    Public Function isValidStudentName(studentname As String) As Integer


        If Not (String.IsNullOrEmpty(studentname)) Then
            If Regex.IsMatch(studentname, "^[a-z]+$", RegexOptions.IgnoreCase) Then

                If studentname.Length <= 50 And studentname.Length >= 1 Then
                    Return 0

                Else
                    Return 2

                End If
                Else
                Return 1

            End If
            Else
                Return 3
        End If

    End Function

End Class

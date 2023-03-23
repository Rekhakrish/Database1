Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub BtnArray_Click(sender As Object, e As EventArgs) Handles BtnArray.Click
        'Program to get output in separate box
        Dim iData(4) As String

        iData(0) = "2"
        iData(1) = "5"
        iData(2) = "6"
        iData(3) = "7"
        iData(4) = "8"

        'Program to get out in single box
        Dim i As Integer
        'Dim Stout As String

        'Program To add all
        Dim iTotal As Integer


        For i = 0 To 4
            'Stout = Stout & iData(i) & vbNewLine
            iTotal = iTotal + iData(i)
        Next
        MsgBox("The Total is : " & iTotal)


    End Sub
End Class

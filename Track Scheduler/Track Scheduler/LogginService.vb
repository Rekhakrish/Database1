Imports System
Imports System.IO

Module LogginService
    Sub Main(args As String())
        Dim fstream As FileStream
        Dim swriter As StreamWriter
        fstream = New FileStream("C:\Files\checking\loggingservice.txt", FileMode.Append, FileAccess.Write)
        swriter = New StreamWriter(fstream)
        Dim entrytime As DateTime = DateTime.Now
        Dim str As String = $"Loggin Time" & entrytime
        swriter.WriteLine(str)
        swriter.Close()
        fstream.Close()
    End Sub
End Module

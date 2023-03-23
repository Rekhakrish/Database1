Imports System.IO

Public Class WindowService
    Private WithEvents mytimer As System.Timers.Timer
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.

        Dim content() As String = {DateTime.Now.ToString() + " : Service started"}
        File.WriteAllLines("c:\\Windowservice.log", content)


    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Dim content() As String = {DateTime.Now.ToString() + " : Service stopped"}
        File.WriteAllLines("c:\\Windowservice.log", content)
    End Sub

End Class

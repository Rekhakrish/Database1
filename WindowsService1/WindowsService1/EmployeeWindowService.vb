Imports System.Configuration
Imports System.IO
Imports System.Threading
Imports System.Timers
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports Timer = System.Timers.Timer

Public Class EmployeeWindowService

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.SystemEventLogVB = New System.Diagnostics.EventLog
        If Not EventLog.SourceExists("EmployeeCopyServiceVB") Then
            EventLog.CreateEventSource("EmployeeCopyServoceVB", "")
        End If
        SystemEventLogVB.Source = "EmployeeCopyServiceVB"
        SystemEventLogVB.Log = "C:\\EventAlert.log"
    End Sub

    Private _timer As Timer
    Public Property SystemEventLogVB As Object

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        SystemEventLogVB.WriteEntry("Employee Copy ServiceVB - Started")
        _timer = New Timers.Timer()
        _timer.Interval = 10000  ' 10seconds
        AddHandler _timer.Elapsed, AddressOf Me.CopyFiles_Tick
        _timer.Start()
    End Sub

    Private Sub CopyFiles_Tick(sender As Object, e As ElapsedEventArgs)
        Dim filesCopiedCount As Integer = 0
        Dim targetfile As String = "C:\EventAlert.log"
        Dim sourceFilePath As String = ConfigurationManager.AppSettings("C:\Users\rkkumar\source\repos\WindowsServiceSample\WindowsServiceSample\bin\Debug\WindowsService1")
        For Each fileinfo As String In Directory.GetFiles(sourceFilePath)
            targetfile = ConfigurationManager.AppSettings("C:\EventAlert.log") + fileinfo.Substring(fileinfo.LastIndexOf("\") + 1, fileinfo.Length - (fileinfo.LastIndexOf("\") + 1))
            SystemEventLogVB.WriteEntry("Copying from file - " + fileinfo + "To File - " + targetfile)
            If File.Exists(targetfile) Then
                File.Delete(targetfile)
            End If
            File.Copy(fileinfo, targetfile)
            File.Delete(fileinfo)
            filesCopiedCount += 1

        Next
        SystemEventLogVB.WriteEntry("VBService - Number of File(s) copied " + filesCopiedCount.ToString)
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        _timer.Stop()
        SystemEventLogVB.WriteEntry("Employee Copy ServiceVB - Completed")
    End Sub

End Class

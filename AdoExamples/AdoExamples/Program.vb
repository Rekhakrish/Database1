Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

Module Program
    Sub Main(args As String())
        Dim conn As SqlConnection
        conn = New SqlConnection("server=NLTI155\SQLEXPRESS;database=Sports;integrated security=true")
        'Dim cmd As SqlCommand = New SqlCommand("Select * from Football")
        '' Dim cmd As SqlCommand = New SqlCommand("Insert into Football(PlayerName1,PlayerAge1,Matches1)values('Rekha',23,5)")

        ''Dim cmd1 As SqlCommand = New SqlCommand("Set identity_insert Football ON")
        'cmd.Connection = conn
        'conn.Open()
        'Dim rd As SqlDataReader = cmd.ExecuteReader()
        'Console.WriteLine("id,name,age,match")
        'Console.WriteLine("*************************")
        'While (rd.Read())
        '    Console.WriteLine(rd("playerid1").ToString() + ",")
        '    Console.WriteLine(rd("playername1").ToString() + ",")
        '    Console.WriteLine(rd("playerage1").ToString() + ",")
        '    Console.WriteLine(rd("playerid").ToString() + ",")
        '    Console.WriteLine(rd("matches1").ToString() + ",")
        'End While
        'rd.Close()
        '' cmd.ExecuteNonQuery()
        '' cmd1.ExecuteNonQuery()
        'conn.Close()


        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from Cricket", conn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        Dim dataview As DataView = New DataView(dt)
        ' dataview.Sort = "PlayerName asc"
        Dim row As DataRow
        'For i As Integer = 0 To dataview.Count - 1
        '    Console.WriteLine(dataview(i)("playerid").ToString + " " + dataview(i)("playername").ToString + " " + dataview(i)("playerage").ToString + " " + dataview(i)("matches").ToString)

        'Next

        'For Each datarowview As DataRowView In dataview
        '    row = datarowview.Row
        '    Console.WriteLine((datarowview("playerid").ToString + " " + datarowview("playername").ToString + " " + datarowview("playerage").ToString + " " + datarowview("matches").ToString))
        'Next
        'dataview.AllowNew = True
        'Dim dr As DataRowView = dataview.AddNew()

        'dr("playerid") = 6
        'dr("playername") = "Jagan"
        'dr("playerage") = 20
        'dr("matches") = 10

        'dr("playerid") = 7
        'dr("playername") = "Nithish"
        'dr("playerage") = 21
        'dr("matches") = 10
        'dataview.RowFilter = "playerid = 2"
        'For Each datarowview As DataRowView In dataview
        '    row = datarowview.Row
        '    Console.WriteLine((datarowview("playerid").ToString + " " + datarowview("playername").ToString + " " + datarowview("playerage").ToString + " " + datarowview("matches").ToString))
        'Next
        'dataview.AllowEdit = True
        'For Each datarowview As DataRowView In dataview
        '    If datarowview("matches") = 5 Then
        '        datarowview("playerage") = 22
        '    End If
        'Next
        'For Each datarowview As DataRowView In dataview
        '    row = datarowview.Row
        '    Console.WriteLine((datarowview("playerid").ToString + " " + datarowview("playername").ToString + " " + datarowview("playerage").ToString + " " + datarowview("matches").ToString))
        'Next
        dataview.AllowDelete = True
        For Each datarowview As DataRowView In dataview
            If datarowview("playerid") = 2 Then
                datarowview.Delete()
            End If
        Next
        For Each datarowview As DataRowView In dataview
            row = datarowview.Row
            Console.WriteLine((datarowview("playerid").ToString + " " + datarowview("playername").ToString + " " + datarowview("playerage").ToString + " " + datarowview("matches").ToString))
        Next

        ''For Each dr As DataRow In dt.Rows
        ''    Console.WriteLine(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString)

        ''Next
        ''Console.ReadKey()

        'Dim ds As DataSet = New DataSet()
        'da.Fill(ds, "Cricket")
        'For Each dr As DataRow In ds.Tables("Cricket").Rows
        '    Console.WriteLine(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString)
        '    Console.ReadKey()

        'Next
        'da.Fill(ds, "Football")
        'For Each dr As DataRow In ds.Tables("Football").Rows
        '    Console.WriteLine(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString)
        Console.ReadKey()

        'Next
    End Sub
End Module

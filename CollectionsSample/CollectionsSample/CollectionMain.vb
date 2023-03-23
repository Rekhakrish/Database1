Imports System

Module CollectionMain
    Sub Main(args As String())
        Dim generiesString As Generies(Of String) = New Generies(Of String)()
        generiesString.Print("VB.Net")

        Dim generieInteger As Generies(Of Integer) = New Generies(Of Integer)()
        generiesString.Print(150)

        'Dim collec As CollectionArray = New CollectionArray
        'collec.Array()


    End Sub
End Module

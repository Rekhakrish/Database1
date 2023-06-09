Imports System
'Exception Handling Program
'Module Program
'    Sub Main(args As String())
'        division(25, 0)
'        Console.ReadKey()
'    End Sub
'    Public Sub division(ByVal num1 As Integer, ByVal num2 As Integer)
'        Dim result As Double
'        ' Dim num1 As Integer
'        ' Dim num2 As Integer
'        Try
'            result = num1 \ num2
'        Catch e As DivideByZeroException
'            Console.WriteLine("Exception caught: {0}", e)
'        Finally
'            Console.WriteLine("Result: {0}", result)
'        End Try
'    End Sub
'End Module
'--------------------------------------------------------------------------
'User Defined Exceptions
'Module exceptionProg
'    Public Class TempIsZeroException : Inherits ApplicationException
'        Public Sub New(ByVal message As String)
'            MyBase.New(message)
'        End Sub
'    End Class
'    Public Class Temperature
'        Dim temperature As Integer = 0
'        Sub showTemp()
'            If (temperature = 0) Then
'                Throw (New TempIsZeroException("Zero Temperature found"))
'            Else
'                Console.WriteLine("Temperature: {0}", temperature)
'            End If
'        End Sub
'    End Class
'    Sub Main()
'        Dim temp As Temperature = New Temperature()
'        Try
'            temp.showTemp()
'        Catch e As TempIsZeroException
'            Console.WriteLine("TempIsZeroException: {0}", e.Message)
'        End Try
'        Console.ReadKey()
'    End Sub
'End Module
'---------------------------------------------------------------------------------

'Throwing Objects
Module exceptionProg
    Sub Main()
        Try
            Throw New ApplicationException("A custom exception _ is being thrown here...")
        Catch e As Exception
            Console.WriteLine(e.Message)
        Finally
            Console.WriteLine("Now inside the Finally Block")
        End Try
        Console.ReadKey()
    End Sub
End Module
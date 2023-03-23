'Program with inheritance with constructor
Module Module1
    Class Constructor
        Sub New()
            Console.WriteLine("Constructor 1 called")
        End Sub
        Sub Fun1()
            Console.WriteLine("Fun1 Called")
        End Sub
    End Class
    Class Constructor2
        Inherits Constructor

        Sub New()
            Console.WriteLine("Constructor 2 called")
        End Sub
        Sub Fun2()
            Console.WriteLine("Fun2 Called")
        End Sub
    End Class
    Sub Main()
        Dim cons As New Constructor2()
        cons.Fun1()
        cons.Fun2()
    End Sub
End Module

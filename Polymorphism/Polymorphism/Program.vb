Imports System

Module Polymorphism
    Public Class Shape
        Public Overridable Function CalculateArea() As Double
            Return 0
        End Function
    End Class
    Public Class Circle
        Inherits Shape

        Public Property Radius As Double
        Public Sub New(ByVal rad As Double)
            Radius = rad
        End Sub
        Public Overrides Function CalculateArea() As Double
            Return (3.14) * Math.Pow(Radius, 2)
        End Function
    End Class
    Public Class Rectangle
        Inherits Shape
        Public Property Height As Double
        Public Property Width As Double

        Public Sub New(ByVal h As Double, ByVal w As Double)
            Height = h
            Width = w
        End Sub
        Public Overrides Function CalculateArea() As Double
            Return Height * Width
        End Function
    End Class

    Public Sub MethodOverridingExample()
        Dim shape As Shape = New Shape()
        Dim circle As Shape = New Circle(3.0)
        Dim rectangle As Shape = New Rectangle(3.0, 4.0)

        Console.WriteLine("The area of the shape is " & shape.CalculateArea())
        Console.WriteLine("The area of the circle is " & circle.CalculateArea())
        Console.WriteLine("The area of the rectangle is " & rectangle.CalculateArea())
    End Sub

End Module


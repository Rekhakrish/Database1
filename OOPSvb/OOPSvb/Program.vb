'Import the System namespace
Imports System
'Animals is a namespace
Namespace Animals

    'Dog is a class in the namespace Animals.
    Class Dog

        'Bark is a now a Public, shared function in this class
        Public Shared Function Bark()
            Console.WriteLine("Dog is Barking")
        End Function

        'Walk is a Public function in this class. It is not shared.
        Public Function Walk()
            Console.WriteLine("Dog is Walking")
        End Function
    End Class
End Namespace

'Our Module
Public Module Program

    'Execution will start from the Main() subroutine.
    Sub Main(args As String())

        'We can call the Bark() function directly,
        'with out creating an object of type Dog -
        'because it is shared.
        Animals.Dog.Bark()
        'We can call the Walk() function only
        'after creating an object, because
        'it is not shared.
        Dim jimmy As Animals.Dog
        jimmy = New Animals.Dog()
        jimmy.Walk()

    End Sub
End Module

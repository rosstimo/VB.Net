

Module OOPExample

    Sub Main()

        'Constructor
        Dim scruffy As New Dog
        Dim Todo As New Dog
        Dim polly As New Parrot

        Console.WriteLine(scruffy.Move)
        Console.WriteLine(scruffy.Speak)

        Todo.movement = "bite you When you Get too close"
        Todo.voice = "yap! yap! yap!  yipe!!"

        Console.WriteLine(Todo.Move)
        Console.WriteLine(Todo.Speak)


        Console.WriteLine(polly.Move)
        Console.WriteLine(polly.Speak)

        Console.Read()
    End Sub

    Class Animal

        Private _skinType As String
        Public Overridable Property skinType As String
            Get
                Return _skinType
            End Get
            Set(ByVal value As String)
                _skinType = value
            End Set
        End Property

        'fields
        Public voice As String = "Animals move... Well Not sponges..."
        Public movement As String = ""

        Public Function Move() As String
            Return movement
        End Function

        Public Function Speak() As String
            Return voice
        End Function

    End Class

    Class Mammal
        Inherits Animal

        'Properties
        Public Overrides Property skinType As String = "Fur"
        Public Property bodyfeature As String = "warm blooded"

    End Class

    Class Bird
        Inherits Animal
        'Properties
        Public Overrides Property skinType As String = "Feathers"

        Public Shadows Function Move() As String
            Return "Soaring through the sky..."
        End Function

    End Class

    Class Dog
        Inherits Mammal
        'Properties

        Public movement As String = "Leaping through the tall grass In the back yard.."

        'Fields

        Public voice As String = "Woof"

        'Methods
        Sub New()
        End Sub

        Public Shadows Function Move() As String
            Return movement
        End Function

        Public Shadows Function Speak() As String
            Return voice
        End Function

    End Class

    Class SmallDog
        Inherits Mammal
        'Properties

        'Fields

        'Methods
        Sub New()


        End Sub

        Public Shadows Function Move() As String
            Return "poops On the rug..."
        End Function

        Public Shadows Function Speak() As String
            Return "yip! yip!"
        End Function

    End Class

    Class Cat
        Inherits Mammal
    End Class

    Class Parrot
        Inherits Bird
        Public Shadows Function Move() As String
            Return "Ok, who left the window open?"
        End Function

        Public Shadows Function Speak() As String
            Return "Stick 'em up!"
        End Function

    End Class

    Class Lion
        Inherits Mammal
    End Class

    Class Duck
        Inherits Bird
    End Class

End Module

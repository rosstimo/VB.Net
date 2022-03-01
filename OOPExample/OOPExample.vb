


Module OOPExample

    Sub Main()

        'Constructor instantiates or creates an instance of a class/object
        Dim jim As New Animal
        Dim bob As New Bird
        Dim Todo As New Dog
        Dim scruffy As New Dog
        Dim polly As New Parrot
        Dim pepe As New Chihuahua
        Dim sly As New Fox

        Console.WriteLine(jim.Move)
        Console.WriteLine(jim.Speak)
        Console.WriteLine()

        Console.WriteLine(bob.Move)
        Console.WriteLine(bob.Speak)
        Console.WriteLine()

        Console.WriteLine(scruffy.Move)
        Console.WriteLine(scruffy.Speak)
        Console.WriteLine()

        Todo.movement = "bite you When you Get too close"
        Todo.voice = "yap! yap! yap!  yipe!!"
        Console.WriteLine(Todo.Move)
        Console.WriteLine(Todo.Speak)
        Console.WriteLine()

        Console.WriteLine(pepe.Move)
        pepe.skinType = "A hairless little rat!"
        Console.WriteLine(pepe.skinType)
        Console.WriteLine(pepe.Speak)
        Console.WriteLine()

        Console.WriteLine(polly.Move)
        Console.WriteLine(polly.speak)
        Console.WriteLine()

        Console.WriteLine("What does the fox say?")
        Console.WriteLine(sly.Speak)
        Console.WriteLine()

        Console.Read()
    End Sub

    Class Animal
        'fields
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

        Public voice As String = "Glub.. Glub.. sponges are a kind of animal..."
        Public movement As String = "Animals move... Well Not sponges..."
        Private luckyNumber As Integer = 7

        'Methods
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

        'Methods
        Public Shadows Function Move() As String
            Return "Walking on all fours"
        End Function

    End Class

    Class Bird
        Inherits Animal
        'Properties
        Public Overrides Property skinType As String = "Feathers"

        'Methods
        Public Shadows Function Move() As String
            Return "Soaring through the sky..."
        End Function

    End Class

    Class Dog
        Inherits Mammal

        'Properties
        'Public movement As String

        'Fields
        'Public voice As String

        'Methods
        'stuff to do when a new instance of dog is created
        Sub New()
            Me.movement = "Leaping through the tall grass In the back yard.."
            Me.voice = "Woof"
            Me.skinType = "shiny coat"
        End Sub

        'the following methods are inherited from the parent or super class Animal.Mammal so to have them here is redundant
        'the me keyword references this instance of the class rather than the parent class

        'Public Shadows Function Move() As String
        '    Return Me.movement
        'End Function

        'Public Shadows Function Speak() As String
        '    Return Me.voice
        'End Function

    End Class

    Class Cat
        Inherits Mammal
        Sub New()
            Me.movement = "clawing at the back of the couch"
            Me.voice = "Meow.."
        End Sub
    End Class

    Class Lion
        Inherits Cat
        Sub New()
            Me.movement = "chasing a zebra"
            Me.voice = "Roar!!..."
        End Sub
    End Class

    Class Parrot
        Inherits Bird

        'A common mistake is to accidentally access the parent class values
        'If you leave out the New() method this will happen
        Public Shadows Function Move() As String
            Return Me.movement '"Ok, who left the window open?"
        End Function

        Public Shadows Function speak() As String
            Return "Pretty Bird...."
        End Function

    End Class

    Class Duck
        Inherits Bird
        Sub New()
            Me.movement = "It walks like a duck..."
            Me.voice = "It quacks like a duck..."
        End Sub
    End Class

    Class Fox
        Inherits Dog
        Sub New()
            Me.voice = "Ring-ding-ding-ding-dingeringeding!" & vbNewLine _
                       & "Gering-ding - ding - ding - dingeringeding!" & vbNewLine _
                       & "Gering-ding - ding - ding - dingeringeding!"
        End Sub
    End Class

    Class Chihuahua
        Inherits Dog
        Sub New()
            Me.voice = "yip! yip! yip! yip! yip! yip! yip!"
            Me.movement = "shiver"
            Me.skinType = "fur-less"
        End Sub
    End Class


End Module

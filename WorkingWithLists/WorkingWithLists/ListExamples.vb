Imports System
''' <summary>
''' see: https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/concepts/collections
''' </summary>
Module ListExamples
    Sub Main(args As String())
        ' ListSalmon()
        'PopulateOnCreation()
        IterateThroughList()
    End Sub


    Sub ListSalmon()
        ' Create a list of strings.
        Dim salmons As New List(Of String)
        salmons.Add("chinook")
        salmons.Add("coho")
        salmons.Add("pink")
        salmons.Add("sockeye")

        Console.WriteLine(salmons.ElementAt(2))
        Console.WriteLine(salmons.IndexOf("coho"))

        ' Iterate through the list.
        For Each salmon As String In salmons
            Console.Write(salmon & " ")
        Next
        'Output: chinook coho pink sockeye
    End Sub

    Sub PopulateOnCreation()
        ' Create a list of strings by using a
        ' collection initializer.
        Dim salmons As New List(Of String) From {"chinook", "coho", "pink", "sockeye"}


        For index = 0 To salmons.Count '- 1
            Console.Write(salmons(index) & " ")
        Next
        'Output: chinook coho pink sockeye
    End Sub

    Private Sub IterateThroughList()
        Dim theGalaxies As New List(Of Galaxy) From
            {
                New Galaxy With {.Name = "Tadpole", .MegaLightYears = 400},
                New Galaxy With {.Name = "Pinwheel", .MegaLightYears = 25},
                New Galaxy With {.Name = "Milky Way", .MegaLightYears = 0},
                New Galaxy With {.Name = "Andromeda", .MegaLightYears = 3}
            }


        Dim fictional As New Galaxy

        fictional.Name = "bob"
        fictional.MegaLightYears = 37

        theGalaxies.Add(fictional)
        Console.WriteLine(fictional.Name)


        For Each theGalaxy In theGalaxies
            With theGalaxy
                Console.WriteLine(.Name & "  " & .MegaLightYears)
            End With
        Next

        ' Output:
        '  Tadpole  400
        '  Pinwheel  25
        '  Milky Way  0
        '  Andromeda  3
    End Sub

    Public Class Galaxy
        Public Property Name As String
        Public Property MegaLightYears As Integer
    End Class

End Module

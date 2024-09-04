Module WorkingWithArrays

    Sub Main()

        Dim names(5) As String

        names(0) = "jimmy"
        names(3) = "Bob"

        'crashes program
        'Console.WriteLine(names(6))

        For i = 0 To 10
            Console.WriteLine(names(i))
        Next

        Console.Read()

    End Sub

End Module

Option Strict On
Option Explicit On

Module WorkingWithArrays

    Sub Main()

        'TODO test randomness with array
        For i = 1 To 100

            Console.WriteLine(GetRandomNumberBetween(0, 10))
        Next

        Console.Read()

    End Sub

    Sub SimpleArray()
        Dim names(5) As String

        names(0) = "jimmy"
        names(3) = "Bob"

        'crashes program
        'Console.WriteLine(names(6))

        For i = 0 To 10
            Console.WriteLine(names(i))
        Next
    End Sub

    Sub LessSimpleArrays()
        Dim names(5, 1) As String
        Dim numbers = New Integer(,) {{1, 2, 3}, {3, 4, 5}, {7, 8, 9}}
        Dim fruits = New String() {"apple", "banana", "grape"}

        names(0, 0) = "Jimmy"
        names(0, 1) = "Buffet"

        names(1, 0) = "Jane"
        names(1, 1) = "Dover"

        'For i = LBound(names) To UBound(names)
        '    Console.WriteLine($"The name is: {names(i, 0)}")

        'Next

        'For Each name In names
        '    Console.WriteLine($"The name is: {name}")

        'Next

        For i = names.GetLowerBound(0) To names.GetUpperBound(0)
            Console.WriteLine($"The element ({i},0) has: {names(i, 0)} The element ({i},1) has: {names(i, 1)}")
        Next
    End Sub


    Function GetRandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim value As Integer 'Single

        Randomize()

        value = CInt(Rnd() * max)

        Return value
    End Function

End Module

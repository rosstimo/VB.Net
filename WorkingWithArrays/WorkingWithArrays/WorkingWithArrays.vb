Option Strict On
Option Explicit On
Option Compare Text

Module WorkingWithArrays

    Sub Main()

        Dim randomNumbers(10) As Integer
        Dim formated As String
        Dim userInput As String

        Do
            'TODO test randomness with array
            For i = 1 To 10000

                'Console.WriteLine(GetRandomNumberBetween(0, 10))

                randomNumbers(GetRandomNumberBetween(5, 10)) += 1

            Next


            For i = LBound(randomNumbers) To UBound(randomNumbers)
                formated = CStr(randomNumbers(i)) & " |"
                formated = formated.PadLeft(7)
                Console.Write(formated)
            Next

            userInput = Console.ReadLine()
        Loop Until userInput = "q"


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

        'int returns only the integer portion of the number. throwing away the decimal portion
        'Cint converts to integer. if we only convert the max and min numbers will only hit half the frequency of the middle due to rounding.
        value = CInt(Int(Rnd() * (max + 1)))



        Return value
    End Function

End Module

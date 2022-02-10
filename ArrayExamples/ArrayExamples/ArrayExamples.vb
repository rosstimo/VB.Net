Module ArrayExamples

    Sub Main()



        Console.ReadLine()

    End Sub

    Sub SimpleArray()
        'Declare an array of strings with 0 to 5 elements
        Dim names(5) As String

        'add data to the array
        names(0) = "Jim"
        names(1) = "Pual"
        names(2) = "Mary"
        names(4) = "Sally"

        'exception
        'names(6) = "xxx"

        'access an element
        Console.WriteLine(names(2))

    End Sub

    Sub TwoDimensionArrayLoop()
        Dim numbers(9, 9) As Integer
        Dim temp As String

        For row = 0 To 9
            For column = 0 To 9
                numbers(row, column) = row + column
            Next
        Next

        For row = 0 To 9
            For column = 0 To 9
                temp = CStr(numbers(row, column)) & " |"
                Console.Write(temp.PadLeft(6))
            Next
            Console.WriteLine()
        Next
    End Sub

End Module

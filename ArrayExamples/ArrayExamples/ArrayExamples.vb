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

    Sub ArrayBoundries()
        Dim fruits(5) As String

        fruits(0) = "apple"
        fruits(1) = "pear"
        fruits(2) = "orange"
        fruits(3) = "plum"
        fruits(4) = "grape"
        fruits(5) = "tomato"

        For i = LBound(fruits) To UBound(fruits)
            Console.WriteLine(fruits(i))
        Next

        For i = 0 To 5
            Console.WriteLine(fruits(i))
        Next

    End Sub

End Module

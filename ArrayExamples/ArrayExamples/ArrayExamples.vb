Module ArrayExamples

    Sub Main()

        'Dim test As Array()
        'SimpleArray()
        'TwoDimensionArrayLoop()
        'ArrayBoundries()
        'DeclareWithData()

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
        Dim fruits As String() = {"apple", "pear", "orange", "plum", "grape", "tomato", "banana", "kiwi"}

        For i = LBound(fruits) To UBound(fruits)
            Console.WriteLine(fruits(i))
        Next

        For i = 0 To 5
            Console.WriteLine(fruits(i))
        Next

    End Sub

    Sub DeclareWithData()
        Dim tracker(9) As Boolean
        tracker(3) = True

        Dim values = New Integer() {5, 6, 7, 2, 9, 0, 4, 7}

        Dim grid(4, 4) As Boolean
        grid(2, 4) = True

        Dim square = New Integer(,) {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}

        'ReDim Preserve square(2, 4)
        Console.Read()
    End Sub
End Module

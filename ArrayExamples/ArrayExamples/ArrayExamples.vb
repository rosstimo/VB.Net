'see https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/arrays/#iterating-through-an-array

Module ArrayExamples

    Sub Main()
        'SimpleArray()
        'TwoDimensionArrayLoop()
        ArrayBoundries()
        Console.ReadLine()

    End Sub

    Sub SimpleArray()
        'Declare an array of strings with 0 to 5 elements
        Dim names(5) As String
        ' Declare a single-dimension array and set its 4 values.
        Dim numbers = New Integer() {1, 2, 4, 8}

        'add data to the array
        names(0) = "Jim"
        names(1) = "Pual"
        names(2) = "Mary"
        names(4) = "Sally"

        'exception
        'names(6) = "xxx"

        'access an element
        Console.WriteLine(names(2))

        ' Change the size of an existing array to 16 elements and retain the current values.
        ReDim Preserve numbers(15)

        ' Redefine the size of an existing array and ***reset the values***.
        ReDim numbers(15)

    End Sub

    Sub TwoDimensionArrayLoop()
        Dim numbers(9, 9) As Integer
        Dim temp As String

        ' Declare a 4 x 3 multidimensional array and set array element values.
        Dim matrix = New Integer(,) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}

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
        Dim numbers(9, 9) As Integer

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

        'iterate through numbers(n, 1) only
        For i = numbers.GetLowerBound(1) To numbers.GetUpperBound(1)
            Console.WriteLine(numbers(i, 1))
        Next

        'iterate through numbers(n, 0) only
        For i = LBound(numbers) To UBound(numbers)
            Console.WriteLine(numbers(i, 0))
        Next

        'iterate through entire array
        For Each number In numbers
            Console.WriteLine(number)
        Next
    End Sub

End Module

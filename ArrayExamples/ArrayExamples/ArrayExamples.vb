Option Strict On
Option Explicit On
'header

Imports System.Globalization

Module ArrayExamples

    Sub Main()

        MultiDimentionalArrays()

    End Sub

    Sub SimpleArrays()
        'arrays are cools
        Dim fruits(5) As String
        Dim names() As String = {"john", "paul", "ringo", "jeff"}
        Dim BeanCounts = New Integer() {12342, 343, 1234, 4646}



        fruits(0) = "banana"

        fruits(3) = "grape"

        'fruits(6) = "apple"

        'For i = 0 To 10
        '    Console.WriteLine(names(i))

        'Next

        For i = LBound(names) To UBound(names)
            Console.WriteLine(names(i))
        Next
    End Sub

    Sub MultiDimentionalArrays()

        Dim students(14, 2) As Single
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somthingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim threeDimensionArray(,,) As Integer = {{{1}, {2}, {3}}, {{4}, {5}, {6}}, {{7}, {8}, {9}}}

        students(3, 0) = 75.43
        students(3, 1) = 85.66
        students(3, 2) = 94.74



        Console.WriteLine()

    End Sub


End Module

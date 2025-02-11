Option Strict On
Option Explicit On
'header

Imports System.Globalization

Module ArrayExamples

    Sub Main()

        'MultiDimentionalArrays()
        TestRandomness()
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


    Sub TestRandomness()
        Dim beanCounter(20) As Integer

        For i = 1 To 10000
            beanCounter(RandomNumberBetween(3, 10)) += 1

        Next

        For i = LBound(beanCounter) To UBound(beanCounter)
            Console.WriteLine($"{CStr(i).PadLeft(4)} hit {CStr(beanCounter(i)).PadLeft(4)} times!")
        Next
    End Sub


    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function


End Module

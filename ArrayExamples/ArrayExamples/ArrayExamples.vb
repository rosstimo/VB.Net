Option Strict On
Option Explicit On
'header

Imports System.Globalization

Module ArrayExamples

    Sub Main()

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

End Module

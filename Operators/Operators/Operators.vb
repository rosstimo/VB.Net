Option Explicit Off
Option Strict Off

Imports System.Globalization

Module Operators

    Sub Main()
        ''example of '+' operator
        'Console.Write("5 + 5 = ")
        'Console.WriteLine(5 + 5)
        'Console.WriteLine() 'add a blank line
        ''example of '*' operator
        'Console.Write("5 * 5 = ")
        'Console.WriteLine(5 * 5)
        'Console.WriteLine() 'add a blank line
        ''example of '^' operator
        'Console.Write("5 ^ 2 = ")
        'Console.WriteLine(5 ^ 2)
        'Console.WriteLine() 'add a blank line
        ''example of '/' operator. floating point division
        'Console.Write("5 / 2 = ")
        'Console.WriteLine(5 / 2)
        'Console.WriteLine() 'add a blank line
        ''example of '\' operator. integer division
        'Console.Write("5 \ 2 = ")
        'Console.WriteLine(5 \ 2)
        'Console.WriteLine() 'add a blank line
        ''example of 'Mod' operator.
        ''remainder from integer division
        'Console.Write("5 Mod 2 = ")
        'Console.WriteLine(5 Mod 2)
        'Console.WriteLine() 'add a blank line

        'string concatination
        'Console.WriteLine("apple" & " " & "banana")

        'Comparison Operators
        'Console.WriteLine(5 > 6)
        'Console.WriteLine(5 < 6)
        'Console.WriteLine(5 = 6)
        'Console.WriteLine(5 <> 6)

        'Assignment Operators
        Dim num As Integer
        'Dim fruit As String

        num = 5 + 6

        fruit = "banana"

        Console.WriteLine("You have" & Str(num) & " " & fruit & "(s)")
        Console.WriteLine($"You have {num} {fruit}(s)")

        Console.WriteLine("Please enter a fruit name!")
        fruit = Console.ReadLine()
        Console.WriteLine($"You have {num} {fruit}(s)")

        Console.Read() 'wait for user response here


    End Sub

End Module

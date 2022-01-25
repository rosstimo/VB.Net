Option Explicit On
Option Strict On
Module ConsoleExamples

    Sub Main()
        Dim userResponse As String
        Dim firstNumber As Integer = 4
        Dim secondNumber As Integer
        Dim result As Integer

        'Console.WriteLine("Please type something and press enter...")
        'userResponse = Console.ReadLine()
        'Console.WriteLine("You entered: " & userResponse)

        Console.WriteLine("Please enter a number")
        userResponse = Console.ReadLine()

        If userResponse = "3" Then
            Console.WriteLine("Three is my favorite number! yippee!!!!")
        ElseIf userResponse = "6" Then
            Console.WriteLine("I hate six...")
            Exit Sub
        Else
            Console.WriteLine("You pick boring numbers")
        End If

        secondNumber = CInt(userResponse)
        result = firstNumber + secondNumber

        '4 + 5 = 9
        '4 * 5 = 20
        'Console.WriteLine(CStr(firstNumber) & "+" & CStr(secondNumber) & "=" & CStr(firstNumber + secondNumber))
        'Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)
        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}")

        Console.ReadLine()
    End Sub

End Module

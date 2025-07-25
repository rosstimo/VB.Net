Option Explicit On
Option Strict On
Module ConsoleExamples

    Sub Main()
        Dim userResponse As String
        Dim firstNumber As Integer = 4
        Dim secondNumber As Integer
        Dim result As Integer
        Dim menu As String

        'Console.WriteLine("Please type something and press enter...")
        'userResponse = Console.ReadLine()
        'Console.WriteLine("You entered: " & userResponse)

        Console.WriteLine("Please enter a number or Type " & Chr(34) & "Q" & Chr(34) & " to quit")
        Console.WriteLine("Please enter a number or Type ""Q"" to quit")

        menu = "1. Add" & vbNewLine _
             & "2. Subtract" & vbNewLine _
             & "3. Multiply"

        'menu = $"1. Add{vbNewLine}2. Subtract{vbNewLine}3. Multiply"
        '        menu = $"
        '1. Add
        '2. Subtract
        '3. Multiply"
        Console.WriteLine(menu)

        userResponse = Console.ReadLine()

        Select Case userResponse
            Case "1"
                Console.WriteLine("2 + 2 = 4")
            Case "2"
                Console.WriteLine("5 - 3 = 2")
            Case "3"
                Console.WriteLine("3 x 5 = 15")
            Case Else
                Console.WriteLine("oops, invalid option")
        End Select


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

'Tim Rossiter
'RCET0265
'Variable and Constant Examples

Option Explicit On 'force variable declaration
Option Strict On   'force explicit conversion. (on purpose)

Module Variable

    Sub Main()
        'declare some variables
        Dim firstNumber As Integer
        Dim secondNumber As Decimal = 1.5343673647864877D
        Dim result As Decimal
        Dim testResult As Boolean = True
        Dim userInput As String = "grape"

        Const TAXRATE As Decimal = 0.06D

        'this will only work with option explicit off
        'x = 4

        'implicit conversions only work with option strict off
        'firstNumber = secondNumber
        'firstNumber = userInput

        firstNumber = CInt(secondNumber)
        'Console.WriteLine(secondNumber)
        'Console.WriteLine(firstNumber)

        'Constant values can not change
        'TAXRATE = 123D
        firstNumber = 1
        result = firstNumber * TAXRATE

        'Console.WriteLine("Subtotal" & ": " & firstNumber.ToString("C"))
        'Console.WriteLine("Sales Tax" & ": " & result.ToString("C"))
        'result += firstNumber
        ''result = result + firstNumber
        'Console.WriteLine("Total" & ": " & result.ToString("C"))

        ''calculate important thing
        'firstNumber = 5
        'secondNumber = 38.27D
        'result = firstNumber + secondNumber

        ''display important thing to user
        'Console.WriteLine(result)
        userInput = Console.ReadLine()

        ''show the user what thy just typed
        'Console.WriteLine(userInput)

        'testResult = (5 < 5)

        'look at boolean
        'Console.WriteLine(testResult)

        'talk with user about fruit
        Console.WriteLine("Please Type A Fruit Name")
        userInput = Console.ReadLine()
        Console.WriteLine("mmmmm... I love " & userInput & "s..")

        'wait for user
        Console.ReadLine()
    End Sub

End Module

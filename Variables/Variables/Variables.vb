'Tim Rossiter
'Fall 2022 
'RCET0265
'Variable Example
'www.github.com/rosstimo/VB.net.git

Option Explicit On 'make sure all variables are declared
Option Strict On 'no data type conversions other than what I specify

Module Variable

    Sub Main()
        'declare some variables
        Dim firstNumber As Integer = 3

        firstNumber = 5
        'firstNumber = 5.5      'implied conversion 
        'firstNumber = "apple"  'implied conversion 


        Dim secondNumber As Decimal
        Dim result As Decimal
        Dim testResult As Boolean = True
        Dim userInput As String

        Const TAXRATE As Decimal = 0.05@ ' type character "@" Decimal
        Const DISCOUNT As Decimal = 0.1D ' type character "D" Decimal

        ''calculate important thing
        'firstNumber = 5
        'secondNumber = 38.27@
        'result = firstNumber + secondNumber

        ''display important thing to user
        'Console.WriteLine(result)
        'userInput = Console.ReadLine()

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

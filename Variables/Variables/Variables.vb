Option Explicit On

Module Variable

    Sub Main()
        'declare some variables
        Dim firstNumber As Integer
        Dim secondNumber As Decimal
        Dim result As Decimal
        Dim testResult As Boolean = True
        Dim userInput As String

        Const TAXRATE As Decimal = 0.05D

        ''calculate important thing
        'firstNumber = 5
        'secondNumber = 38.27D
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

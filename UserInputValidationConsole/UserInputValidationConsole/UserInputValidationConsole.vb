Module UserInputValidationConsole

    Sub Main()
        'TODO
        'Prompt the user for a number from 1 to 10 inclusive or "q" to quit
        'Reflect the user input back to the user
        'Validate the user input
        'Check if the input is a number
        'If the user entered "q" or "Q" then quit the program
        'If not, display an error message and prompt the user again
        'Continue until the user enters a valid number or enter "q"
        'Check if the number is within the range
        'If yes congratulate the user and start over
        Dim userInput As String
        Dim userNumber As Integer

        Console.WriteLine("Please enter a number from 1 to 10")
        Console.WriteLine("Enter 'q' to quit")

        'get user input
        userInput = Console.ReadLine()
        'reflect the user input back to the user
        Console.WriteLine($"You entered: {userInput}")

        'attempt to convert the user input to an integer
        userNumber = CInt(userInput)

        'pause here so the user can read the console before exit
        Console.Read()

    End Sub

End Module

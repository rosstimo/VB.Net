Option Strict On
Option Explicit On
Option Compare Text

Module UserInputValidationConsole

    Sub Main()
        'TODO
        '[ ] Prompt the user for a number from 1 to 10 inclusive or "q" to quit
        '[*] Reflect the user input back to the user
        '[ ] Validate the user input
        '[*] Check if the input is a number
        '[*] If the user entered "q" or "Q" then quit the program
        '[*] If not, display an error message and prompt the user again
        '[ ] Continue until the user enters a valid number or enter "q"
        '[ ] Check if the number is within the range
        '[ ] If yes congratulate the user and start over
        Dim userInput As String
        Dim userNumber As Integer
        Dim exitFlag As Boolean = False

        Do
            Console.WriteLine("Please enter a number from 1 to 10")
            Console.WriteLine("Enter 'q' to quit")

            'get user input
            userInput = Console.ReadLine()
            'reflect the user input back to the user
            Console.WriteLine($"You entered: {userInput}")

            'attempt to convert the user input to an integer
            Try
                userNumber = CInt(userInput)
            Catch ex As Exception
                If userInput = "q" Then 'Option Compare Text is set so we don't have to worry about case
                    exitFlag = True
                Else
                    Console.WriteLine($"I'm sorry {userInput} is not a number")
                End If
            End Try
        Loop Until exitFlag = True
        Console.WriteLine("Have a nice day!")
        'pause here so the user can read the console before exit
        Console.Read()
    End Sub

End Module

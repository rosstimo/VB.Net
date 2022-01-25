Option Strict On
Option Explicit On
Option Compare Text


Module ProgramFlowExamples

    Sub Main()

        SelectCaseExample()


        'Dim userResponse As String
        'Dim userNumber As Integer
        'Dim keepPlaying As Boolean = False

        'keepPlaying = True

        'Do 'While keepPlaying = True

        '    'prompt user for a number
        '    Console.WriteLine("Please enter a whole number")
        '    userResponse = Console.ReadLine()

        '    If userResponse = "Q" Then
        '        Console.WriteLine("Have a nice day...")
        '        keepPlaying = False
        '    Else
        '        'validate the user response
        '        Try
        '            userNumber = CInt(userResponse)
        '        Catch ex As Exception
        '            Console.WriteLine("oops I need a whole number")
        '        End Try
        '    End If

        'Loop Until keepPlaying = False

        Console.Read()
    End Sub

    Sub ForNextExample()
        'TODO
    End Sub

    Sub DoWhileExample()

    End Sub

    Sub DoUntilExample()

    End Sub

    Sub IfExample()

    End Sub

    Sub SelectCaseExample()
        Dim userResponse As String = "X"
        Dim userNumber As Integer
        Dim message As String

        'examine or test a single variable
        Select Case userResponse
            Case "Q"
                Console.WriteLine("Are you sure you want to quit?")
            Case "X"
                Console.WriteLine("I found X!")
            Case Else
                Console.WriteLine($"You typed: {userResponse}...")
        End Select


        Do While userResponse <> "Q"
            Console.WriteLine("Please enter your age")
            userResponse = Console.ReadLine()
            Try
                userNumber = CInt(userResponse)
            Catch ex As Exception
                message = $"{userResponse} is not a number"
            End Try

            Select Case userNumber
                Case < 0
                    message = "must be a negative number"
                Case 0 To 3
                    message = "welcome to the toddler free range!"
                Case 4 To 10
                    message = "you must be at least this tall to ride"
                Case 11 To 50
                    message = "If you need to spew, spew in this..."
                Case > 65
                    message = "please sign this release of liability"
                Case Else
                    MsgBox($"uh not sure what to do with {userResponse}")
            End Select
            Console.WriteLine(message)
        Loop

    End Sub

    Sub TryCatchExample()

    End Sub

End Module

Option Strict On
Option Explicit On
Option Compare Text


Module ProgramFlowExamples

    Sub Main()
        Dim userResponse As String
        Dim userNumber As Integer
        Dim keepPlaying As Boolean = False

        keepPlaying = True

        Do 'While keepPlaying = True

            'prompt user for a number
            Console.WriteLine("Please enter a whole number")
            userResponse = Console.ReadLine()

            If userResponse = "Q" Then
                Console.WriteLine("Have a nice day...")
                keepPlaying = False
            Else
                'validate the user response
                Try
                    userNumber = CInt(userResponse)
                Catch ex As Exception
                    Console.WriteLine("oops I need a whole number")
                End Try
            End If

        Loop Until keepPlaying = False

        Console.Read()
    End Sub

End Module

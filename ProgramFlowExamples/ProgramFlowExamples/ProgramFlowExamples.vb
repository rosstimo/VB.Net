Option Strict On
Option Explicit On
Option Compare Binary

Module ProgramFlowExamples

    Sub Main()

        'SelectCaseExample()
        'DoUntilExample()
        'DoWhileExample()
        'IfExample()
        ForNextExample()



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
        For i = 10 To -10 Step -1
            Console.WriteLine(i)
        Next
    End Sub

    Sub DoWhileExample()
        Dim runAgain As Boolean = True
        Dim userResponse As String
        'evaluate expression prior to loop content
        Do While runAgain = True
            Console.WriteLine("the thing happened")
            userResponse = Console.ReadLine()
            Select Case userResponse
                Case "Y"
                    runAgain = True
                Case "N"
                    runAgain = False
                Case Else
                    Console.WriteLine("I'll take that as a no...")
                    runAgain = False
            End Select
        Loop
    End Sub

    Sub DoUntilExample()
        Dim runAgain As Boolean = False
        Dim userResponse As String
        'evaluate expression after to loop content
        Do
            Console.WriteLine("the thing happened")
            userResponse = Console.ReadLine()
            Select Case userResponse
                Case "Y"
                    runAgain = True
                Case "N"
                    runAgain = False
                Case Else
                    Console.WriteLine("I'll take that as a no...")
                    runAgain = False
            End Select
        Loop Until runAgain = False
    End Sub

    Sub IfExample()

        If 5 > 6 Then 'evaluates to False, code skipped
            Console.WriteLine("in the first condition")
        ElseIf 5 < 6 Then 'evaluates to true, code runs
            Console.WriteLine("in the second condition")
        ElseIf 5 = 5 Then 'not evaluated, previous condition was True
            Console.WriteLine("in the third condition")
        Else 'skipped, previous condition was True
            Console.WriteLine("in the Else")
        End If



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
                        'MsgBox($"uh not sure what to do with {userResponse}")
                        message = $"uh not sure what to do with {userResponse}"
                End Select
            Catch ex As Exception
                message = $"{userResponse} is not a number"
            End Try
            Console.WriteLine(message)
        Loop


    End Sub

    Sub TryCatchExample()

    End Sub

End Module

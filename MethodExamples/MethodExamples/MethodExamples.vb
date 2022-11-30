Option Explicit On
Option Strict On

Module MethodExamples

    Sub Main()

        For i = 0 To 5
            'Console.WriteLine(Timer)
            Console.WriteLine(RandomNumberExample())
        Next


        Console.Read()
    End Sub

    Function RandomNumberExample() As Integer
        ' Initialize the random-number generator.

        Randomize(DateAndTime.Now.Millisecond)
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))

        Return value

    End Function


    Sub TestChangeANumber()
        Dim someNumber As Integer
        someNumber = 5
        Console.WriteLine($"in main before call: {someNumber}")
        ChangeANumber(someNumber)
        Console.WriteLine($"in main after call: {someNumber}")
    End Sub
    Sub ChangeANumber(ByRef firstNumber As Integer)
        firstNumber = 7
        Console.WriteLine($"in ChangeANumber: {firstNumber}")
    End Sub

    Sub TestRunningTotal()
        Dim userInput As String
        Dim userNumber As Integer

        Do
            Console.WriteLine("enter a number:")
            userInput = Console.ReadLine()
            Try
                userNumber = CInt(userInput)
            Catch ex As Exception
                Select Case userInput
                    Case "Q"

                    Case "C"
                        RunningTotal(0, True)
                    Case "S"
                        Console.WriteLine(RunningTotal(0, False))
                    Case Else
                        Console.WriteLine("oops")
                End Select
                userNumber = 0
            End Try
            RunningTotal(userNumber, False)
        Loop While userInput <> "Q"
        Console.WriteLine($"The Total is: {RunningTotal(0, False)}")
    End Sub

    Sub AddTwoNumbers()
        Dim result As Integer
        result = 2 + 2
        Console.WriteLine("In Sub")
        Console.WriteLine(result)
    End Sub

    Sub SumOf(firstNumber As Integer, secondNumber As Integer)
        Console.WriteLine(firstNumber + secondNumber)
    End Sub

    Function SumResult(ByVal firstNumber As Integer, ByVal secondNumber As Integer) As Integer
        Dim result As Integer
        result = firstNumber + secondNumber
        Return result
    End Function

    Sub SayAMessage()
        Console.WriteLine("Hello....")
    End Sub

    Sub RandomInteger()
        Dim theRandomNumber As Integer
        Randomize(DateTime.Now.Millisecond)
        theRandomNumber = CInt(Rnd() * 10)
        Console.WriteLine(theRandomNumber)
    End Sub

    Function RandomNumber() As Integer
        Randomize()
        Return CInt(Rnd() * 15)
    End Function

    Function RunningTotal(value As Integer, clear As Boolean) As Integer
        Static total As Integer
        If clear = False Then
            total += value
        Else
            total = 0
        End If
        Return total
    End Function

    Function Count(Optional clear As Boolean = False) As Integer
        Static runningCount As Integer
        If clear Then
            runningCount = 0
        Else
            runningCount += 1
        End If
        Return runningCount
    End Function

End Module

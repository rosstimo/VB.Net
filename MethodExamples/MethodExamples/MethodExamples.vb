Option Explicit On
Option Strict On

Module MethodExamples

    Sub Main()
        Dim userMessage As String = "Hello"
        'SayHello()
        'SumOf(5, 7)

        'Console.WriteLine($"In Main: {userMessage}")
        'SendMessage(userMessage)
        'Console.WriteLine($"In Main: {userMessage}")

        'Console.WriteLine(MyLuckyNumber())

        'TestRunningTotal()

        'testing random
        'Randomize()
        'For i = 0 To 100
        '    ' Console.WriteLine((CInt(Rnd() * 10) + 10))
        '    Console.WriteLine(CInt(Math.Floor((20 - 10 + 1) * Rnd())) + 10)
        'Next


        Console.Read()

    End Sub

    'basic example
    'good for reusable code
    Sub SayHello()
        Console.WriteLine("hello")
    End Sub

    'example with parameters or arguments
    Sub SumOf(firstNumber As Integer, secondNumber As Integer)
        Console.WriteLine(firstNumber + secondNumber)
    End Sub

    'example with parameters or arguments
    'includes ByVal keyword
    'indicating that the parameter data is a copy of the original
    'safe, will not change original value
    Sub ProductOf(ByVal firstNumber As Integer, ByVal secondNumber As Integer)
        Console.WriteLine(firstNumber * secondNumber)
    End Sub


    'example with parameters or arguments
    'includes ByRef keyword
    'indicating that the parameter data is a pointer to the original
    'unsafe, will change original value
    'may be faster

    'try running this ByRef and ByVal
    'notice the difference
    ' Sub SendMessage(ByVal message As String)
    Sub SendMessage(ByRef message As String)
        Console.WriteLine($"In SendMessage: {message}")
        message = "Goodbye"
        Console.WriteLine($"In SendMessage: {message}")
    End Sub

    'function example
    Function MyLuckyNumber() As Integer
        Return 7
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

    Function RunningTotal(value As Integer, clear As Boolean) As Integer
        Dim total As Integer
        'Static total As Integer
        If clear = False Then
            total += value
        Else
            total = 0
        End If
        Return total
    End Function

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

    Function RandomIntegerBetween() As Integer
        Dim result As Integer
        Randomize()
        'TODO
        Return result
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

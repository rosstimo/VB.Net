Option Explicit On
Option Strict On

Module MethodExamples

    Sub Main()
        Dim value As Integer
        ''Call Sub
        'AddTwoNumbers()
        'Console.WriteLine("In main")
        'Console.WriteLine(result)

        'SumOf(4, 6)
        'value = SumResult(7, 7)
        'value = value + 6
        'Console.WriteLine(value)

        ''SayAMessage()

        'For i = 0 To 10
        '    RandomInteger()
        'Next

        'Console.WriteLine(RandomInteger())

        'For i = 0 To 10
        '    Console.WriteLine(RandomNumber())
        'Next

        For i = 0 To 10
            Console.WriteLine(RunningTotal(5))
        Next

        Console.Read()
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

    Function RunningTotal(value As Integer) As Integer
        Static total As Integer
        total += value
        Return total
    End Function

End Module

Option Explicit On

Module MethodExamples

    Sub Main()
        Dim result As Integer
        'Call Sub
        AddTwoNumbers()
        Console.WriteLine("In main")
        Console.WriteLine(result)

        SumOf(4, 6)


        'SayAMessage()

        Console.Read()
    End Sub

    Sub AddTwoNumbers()
        Dim result As Integer
        result = 2 + 2
        Console.WriteLine("In Sub")
        Console.WriteLine(result)
    End Sub

    Sub SumOf(firstNumber As Integer, secondNumber As Integer)

    End Sub

    Sub SayAMessage()
        Console.WriteLine("Hello....")
    End Sub



End Module

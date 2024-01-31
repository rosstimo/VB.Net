Module MainModule

    Sub Main()
        'SayHello()
        'SayGoodBye()
        'SecondModule.test = "the test"
        'SecondModule.testRandom()
        'SecondModule.RandomNumberBetween(50, 100)

        For i = 1 To 10

            'Console.WriteLine($"Sub Total: {SecondModule.RunningTotal(i)}")
            Console.WriteLine($"{i} + {SecondModule.RunningTotal()} = {SecondModule.RunningTotal(i)}")

        Next

        Console.WriteLine($"Total: {SecondModule.RunningTotal()}")
        'clear the total
        SecondModule.RunningTotal(, True)
        'see it
        Console.WriteLine($"Total After Clear: {SecondModule.RunningTotal()}")
        'add 5
        SecondModule.RunningTotal(5)
        'see it again
        Console.WriteLine($"Total After Adding 5: {SecondModule.RunningTotal()}")

        Console.Read()
    End Sub


    Sub SayHello()
        Console.WriteLine("Hello!")
    End Sub

End Module

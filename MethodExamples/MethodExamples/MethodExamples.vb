Option Explicit On
Option Strict On

Module MethodExamples
    Sub Main()
        Dim myLuckyNumber As Integer = 7

        Console.WriteLine("Hello from Sub Main!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()
        ' MyOtherSub()
        Sandwich(myLuckyNumber)

        Console.WriteLine("Hello from Sub Main!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()

    End Sub

    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()

    End Sub


    Sub Sandwich(ByVal myLuckyNumber As Integer)
        Console.WriteLine("Hello from Sandwich!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()
    End Sub


End Module

Option Explicit On
Option Strict On

Module MethodExamples
    Sub Main()
        Dim myLuckyNumber As Integer = 7

        Console.WriteLine("Hello from Sub Main!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        MyOtherSub()
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")

    End Sub


    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")


    End Sub


End Module

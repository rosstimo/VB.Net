Option Explicit On
Option Strict On

Module MethodExamples
    Sub Main()
        Dim myLuckyNumber As Integer = 7

        'Console.WriteLine("Hello from Sub Main!!")
        'Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        'Console.WriteLine()

        ''MyOtherSub()
        ''Sandwich(myLuckyNumber)
        ''Marine(myLuckyNumber)

        'Console.WriteLine("Hello from Sub Main!!")
        'Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        'Console.WriteLine()

        'Console.WriteLine(MyActualLuckyNumber())

        'Console.WriteLine(SumOf(5, 7))

        'Randomize()
        'For i = 1 To 10
        '    Console.WriteLine(Rnd())
        'Next

        For i = 1 To 100
            Console.WriteLine(RandomNumber())
        Next


    End Sub

    'Sub Examples *************************************************************
    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 5
        Console.WriteLine("Hello from MyOtherSub!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()

    End Sub

    Sub Sandwich(ByVal myLuckyNumber As Integer)
        myLuckyNumber += 5
        Console.WriteLine("Hello from Sub Sandwich!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()
    End Sub

    Sub Marine(ByRef myLuckyNumber As Integer)
        myLuckyNumber += 7
        Console.WriteLine("Hello from Sub Marine!!")
        Console.WriteLine($"My lucky number is {myLuckyNumber}!")
        Console.WriteLine()

    End Sub

    'Function Examples ********************************************************

    Function MyActualLuckyNumber() As Integer
        Return 77
    End Function

    Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer
        result = firstNumber + secondNumber
        Return result
    End Function

    Function RandomNumber() As Integer
        Dim myRandomNumber As Single
        Randomize()

        myRandomNumber = Rnd() * 10
        myRandomNumber = Int(myRandomNumber) + 1

        Return CInt(myRandomNumber)
    End Function

End Module

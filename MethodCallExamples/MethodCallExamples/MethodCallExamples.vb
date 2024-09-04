Option Compare Text

Module MethodCallExamples

    Sub Main()
        Dim firstNumber As Integer = 7
        Dim secondNumber As Integer = 5
        Console.WriteLine("start of main")

        'For i = 1 To 5
        '    ExampleSub()
        'Next


        'Console.WriteLine(firstNumber)
        'DoMath(3)
        'DoMath(firstNumber)
        'Console.WriteLine(firstNumber)


        'For i = 1 To 100
        '    Console.WriteLine(GetRandomNumber())
        'Next

        'Console.WriteLine(SumOf(3, 5))

        'Console.WriteLine(firstNumber)
        'Console.WriteLine(secondNumber)

        'PlayWithScope(firstNumber, secondNumber)

        'Console.WriteLine(firstNumber)
        'Console.WriteLine(secondNumber)

        'For i = 1 To 10
        '    'Console.WriteLine(RunningTotal(5, False))
        '    RunningTotal(5, False)
        'Next

        ''get total no clear
        'Console.WriteLine(RunningTotal(0, False))
        'Console.WriteLine(RunningTotal(5))

        ''clear total
        'RunningTotal(0, True)
        'RunningTotal(, True)

        'For i = 1 To 10
        '    Console.WriteLine(RunningTotal(5))
        'Next

        ExponentSeries(5)

        ExponentSeries(8, 2)

        Console.WriteLine("end of main")
        Console.ReadLine()
    End Sub


    ''' <summary>
    ''' Example of a simple Sub Routine
    ''' </summary>
    Sub ExampleSub()
        Console.WriteLine("Hello from the Sub")
    End Sub

    ''' <summary>
    ''' takes a value then adds 5 and prints the equation
    ''' </summary>
    ''' <param name="secondNumber"></param>
    Sub DoMath(secondNumber As Integer)
        Dim firstNumber As Integer = 5
        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
    End Sub

    Function GetRandomNumber() As Integer
        Randomize()
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value
    End Function

    ''' <summary>
    ''' Calculates the sum of two whole numbers
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns>Integer</returns>
    Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer
        result = firstNumber + secondNumber
        Return result
    End Function

    Sub PlayWithScope(ByVal firstNumber As Integer, ByRef secondNumber As Integer)
        Console.WriteLine("Start PlayWithScope Sub")
        firstNumber = 25
        secondNumber = 42
        Console.WriteLine("End PlayWithScope Sub")
    End Sub

    Function RunningTotal(Optional currentNumber As Integer = 0, Optional clear As Boolean = False) As Integer
        Static total As Integer

        If clear Then
            total = 0
        Else
            total += currentNumber
        End If

        Return total
    End Function

    Sub ExponentSeries(iterations As Integer, Optional base As Integer = 10)

        For i = 0 To iterations
            Console.WriteLine(base ^ i)
        Next

    End Sub

End Module

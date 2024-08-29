Module MethodCallExamples

    Sub Main()
        Dim firstNumber As Integer = 7
        Console.WriteLine("start of main")

        'For i = 1 To 5
        '    ExampleSub()
        'Next


        Console.WriteLine(firstNumber)
        DoMath(3)
        DoMath(firstNumber)
        Console.WriteLine(firstNumber)

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

End Module

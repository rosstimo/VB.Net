Option Explicit On
Option Strict On

Module MethodExamples
    Sub Main()

        Console.WriteLine("Hello from Sub Main!!")
        For i = 1 To 10
            MyOtherSub()
        Next

    End Sub


    Sub MyOtherSub()
        Console.WriteLine("Hello from MyOtherSub!!")
    End Sub


End Module

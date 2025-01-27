Option Strict On
Option Explicit On

Module ForLoopExamples

    Sub Main()
        'X = 5
        'Console.WriteLine(X)


        'For i = 0 To 10 'Step 0.5
        '    Console.WriteLine(i)
        'Next

        For row = 0 To 9
            For column = 0 To 9
                Console.Write(row & column & " ")
            Next
            Console.WriteLine()
        Next


        Console.ReadLine()
    End Sub

End Module


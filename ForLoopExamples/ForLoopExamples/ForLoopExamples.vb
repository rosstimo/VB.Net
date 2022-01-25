
Option Explicit On
Option Strict On

Module ForLoopExamples

    Sub Main()
        Dim runningTotal As Integer
        Dim prettyString As String = ""

        'introduction - verbose example
        For index As Integer = 1 To 10 Step 1
            Console.WriteLine("something" & " " & CStr(index))
        Next

        'streamlined version
        For i = 1 To 10
            runningTotal = runningTotal + 5 'verbose complex assignment
            runningTotal += 5 'streamlined complex assignment. works exactly the same as above.
            Console.WriteLine("The running total is:" & " " & CStr(runningTotal))
        Next

        'complex assignment of strings
        For i = 1 To 10
            prettyString &= "*"
            Console.WriteLine(prettyString)
        Next

        Console.ReadLine()
    End Sub

End Module

Module DoLoopExamples

    Sub Main()
        Dim theCondition As Boolean = True
        Dim startTime As Integer = DateTime.Now.Second

        ''No evaluation, infinite loop. Will never exit
        'Do
        '    Console.WriteLine("All work and no play makes Jack a dull boy...")
        'Loop

        'loops while theCondotion is true
        'will not run if theCondition is initially false
        'may never run
        Do While theCondition = True
            Console.WriteLine("Do While: theCondition is True")
            theCondition = False 'setting this false here will cause the loop to stop
        Loop

        'loops until theCondotion is true
        'will not run if theCondition is initially true
        'may never run
        Do Until theCondition = True
            Console.WriteLine("Do Until: theCondition is True")
            theCondition = True 'setting this true here will cause the loop to stop
        Loop

        'will always run once
        'evaluates at the end of the loop
        'will continue to run if theCondition is true
        Do
            Console.WriteLine("Loop Until: theCondition is False")
            theCondition = False
        Loop Until theCondition = False

        'will always run once
        'evaluates at the end of the loop
        'will continue to run if theCondition is true
        Do
            Console.WriteLine("Loop While: theCondition is True")
        Loop While theCondition = True

        theCondition = False
        startTime = DateTime.Now.Second
        Do
            Select Case Date.Now.Second
                Case > startTime + 5 '5 seconds
                    theCondition = True
                    Console.WriteLine("time is up! have a nice day!")
                Case 50 To 59
                    Exit Do
                Case Else
                    Console.WriteLine(Date.Now.Second - startTime)
            End Select
        Loop Until theCondition = True

        Console.Read()
    End Sub

End Module

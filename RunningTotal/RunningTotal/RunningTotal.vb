'header stuff

Option Strict On
Option Explicit On

'TODO
'[x] keep track of transactions in a Function called RunningTotal()
'[x] get the current total as needed
'[ ] provide a way to clear/zero the total
'[ ] display transactions and running total formatted as currency
'[ ] super bonus: create a method to include sales tax to the transaction amount


Module RunningTotal
    Dim myGlobalNumberThing As Decimal

    Sub Main()
        Dim userInput As String
        Dim transactionAmount As Decimal
        Dim quit As Boolean = False

        Do
            Console.WriteLine("Enter a transaction amount or press Q to quit")
            userInput = Console.ReadLine()
            Try
                transactionAmount = CDec(userInput)
                RunningTotal(transactionAmount)
            Catch ex As Exception
                If userInput = "q" Then
                    quit = True
                Else
                    Console.WriteLine($"You entered: {userInput}")
                End If
            End Try


        Loop Until quit

        Console.Clear()
        Console.WriteLine($"The total is: {RunningTotal(0)}")
        Console.WriteLine("Have a nice day!")
    End Sub

    Function RunningTotal(currentNumber As Decimal) As Decimal
        Static _runningTotal As Decimal = 0
        _runningTotal += currentNumber
        Return _runningTotal
    End Function

    Sub SomeOtherGuysBadSub()
        myGlobalNumberThing = 0
    End Sub



End Module

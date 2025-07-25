'header stuff

Option Strict On
Option Explicit On

'TODO
'[x] keep track of transactions in a Function called RunningTotal()
'[x] get the current total as needed
'[x] provide a way to clear/zero the total
'[x] display transactions and running total formatted as currency
'[x] use optional arguments for coolness
'[x] super bonus: create a method to include sales tax to the transaction amount
'[ ] format to currency in a function


Module RunningTotal
    Dim myGlobalNumberThing As Decimal

    Sub Main()
        Dim userInput As String
        Dim transactionAmount As Decimal
        Dim quit As Boolean = False

        Do
            Console.WriteLine("Enter a transaction amount")
            Console.WriteLine("Enter Q to quit")
            Console.WriteLine("Enter T to show total")
            Console.WriteLine("Enter C to clear the total")
            userInput = Console.ReadLine()
            Console.Clear()

            Try
                transactionAmount = CDec(userInput)
                RunningTotal(transactionAmount)
                Console.WriteLine($"The sales tax on {transactionAmount.ToString("c")} is {CalculateSalesTax(transactionAmount).ToString("c")} ")
            Catch ex As Exception

                Select Case userInput
                    Case "q"
                        quit = True
                    Case "t"
                        Console.WriteLine($"The current total is {RunningTotal().ToString("c")}")
                    Case "c"
                        RunningTotal(, True)
                    Case Else
                        Console.WriteLine($"You entered: {userInput}")
                End Select

            End Try
        Loop Until quit

        Console.Clear()
        Console.WriteLine($"The total is: {RunningTotal().ToString("c")}")
        Console.WriteLine("Have a nice day!")
    End Sub

    Function RunningTotal(Optional currentNumber As Decimal = 0, Optional clear As Boolean = False) As Decimal
        Static _runningTotal As Decimal = 0

        If clear Then
            _runningTotal = 0
        Else
            _runningTotal += currentNumber
        End If

        Return _runningTotal
    End Function

    Function CalculateSalesTax(amount As Decimal) As Decimal
        Const TAXRATE = 0.06@
        Return amount * TAXRATE
    End Function

    Sub SomeOtherGuysBadSub()
        myGlobalNumberThing = 0
    End Sub



End Module

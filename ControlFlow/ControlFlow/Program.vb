Option Explicit On
Option Strict On
Option Compare Text
Imports System

Module Program
    Sub Main()
        Dim firstNumber As Integer
        Dim secondnumber As Integer
        Dim userInput As String
        Dim retry As Boolean ' = True

        'firstNumber = 6

        'run at least once
        'evaluate at the end to decide if it should retry
        Do
            userInput = Console.ReadLine()
            Try
                firstNumber = CInt(userInput)
                retry = False
            Catch ex As Exception
                If userInput = "Q" Then
                    Exit Sub
                End If
                Console.WriteLine("oops, that's not a number...")
                retry = True
            End Try
        Loop While retry = True


        'well written IF,ELSEIF ELSE
        If firstNumber > 5 Then
            Console.WriteLine("bigger than 5")
        ElseIf firstNumber < 5 Then
            Console.WriteLine("smaller than 5")
        ElseIf firstNumber = 5 Then
            Console.WriteLine("is 5")
        Else
            Console.WriteLine("it got weird")
        End If

        ''Poorly written IF,ELSEIF ELSE
        'If firstNumber > 5 Then
        '    Console.WriteLine("bigger than 5")
        'End If

        'If firstNumber < 5 Then
        '    Console.WriteLine("smaller than 5")
        'End If

        'If firstNumber = 5 Then
        '    Console.WriteLine("is 5")
        'End If

        For i = 0 To 10 Step 0.5
            Console.WriteLine(i)
        Next

        Console.WriteLine("Please make a selection:")
        Console.WriteLine("1. Kittens")
        Console.WriteLine("2. Puppies")
        Console.WriteLine("3. Snakes")
        userInput = Console.ReadLine()

        Select Case userInput
            Case "1"
                Console.WriteLine("i love kittens!")
            Case "2"
                Console.WriteLine("oohhh... puppies")
            Case "3"
                Console.WriteLine("sssssssssssssssss...")
            Case Else
                Console.WriteLine("sorry, I don't understand")
                Console.WriteLine("please try again later")
        End Select




    End Sub
End Module

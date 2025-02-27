Option Strict On
Option Explicit On
'Bingo Game Program
'Client: Shady Acres 
'Spring 2025

Imports System.Net.NetworkInformation



'TODO
'[x] Display Bingo Board
'[x] Draw a random ball that has not already been drawn
'[x] update display to show all drawn balls
'[ ] update display to show actual ball number
'[ ] refresh tracking with "C" or when all balls have been drawn

Module BingoGame

    Sub Main()
        Dim userInput As String

        Do
            Console.Clear()
            DisplayBoard()
            Console.WriteLine()
            'prompt
            userInput = Console.ReadLine()
            Select Case userInput
                Case "d"
                    DrawBall()
                Case "c"
                    BingoTracker(0, 0,, True)
                    DrawBall(True)
                Case Else
                    'pass
            End Select

        Loop Until userInput = "q"

        Console.Clear()
        Console.WriteLine("Have a nice day!")

    End Sub

    Sub DrawBall(Optional clearCount As Boolean = False)
        Dim temp(,) As Boolean = BingoTracker(0, 0) 'create a local copy of ball tracker array
        Dim currentBallNumber As Integer
        Dim currentBallLetter As Integer
        Static ballCounter As Integer

        If clearCount Then
            ballCounter = 0
        Else
            'loop until the current random ball has not already been marked as drawn
            Do
                currentBallNumber = RandomNumberBetween(0, 14) 'get the row
                currentBallLetter = RandomNumberBetween(0, 4) ' get the column
            Loop Until temp(currentBallNumber, currentBallLetter) = False Or ballCounter >= 75
            'mark current ball as being drawn, updates the display
            BingoTracker(currentBallNumber, currentBallLetter, True)
            ballCounter += 1

            'for debug write valid ball draws to console
            Console.WriteLine($"the current row is {currentBallNumber} and column is {currentBallLetter}")

        End If

    End Sub

    ''' <summary>
    ''' Contains a persistent array that tracks all possible bingo balls
    ''' and whether they have been drawn during the current game.
    ''' </summary>
    ''' <param name="ballNumber"></param>
    ''' <param name="ballLetter"></param>
    ''' <param name="clear"></param>
    ''' <returns>Current Tracking Array</returns>
    Function BingoTracker(ballNumber As Integer,
                          ballLetter As Integer,
                          Optional update As Boolean = False,
                          Optional clear As Boolean = False) As Boolean(,)

        Static _bingoTracker(14, 4) As Boolean

        If update Then
            _bingoTracker(ballNumber, ballLetter) = True
        End If

        If clear Then
            ReDim _bingoTracker(14, 4) 'clears the array. could also loop through array and set ell elements to false
        End If

        Return _bingoTracker
    End Function

    ''' <summary>
    ''' Iterates through the tracker array and displays bingo board to the console.
    ''' </summary>
    Sub DisplayBoard()
        Dim temp As String = " |"
        Dim heading() As String = {"B", "I", "N", "G", "O"}
        Dim tracker(,) As Boolean = BingoTracker(0, 0)
        For Each letter In heading
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(20, "_"))
        For currentNumber = 0 To 14
            For currentLetter = 0 To 4

                If tracker(currentNumber, currentLetter) Then
                    temp = $"{FormatBallNumber(currentNumber, currentLetter)} |" 'display for drawn balls
                Else
                    temp = " |" 'display for not drawn balls
                End If

                temp = temp.PadLeft(4)
                Console.Write(temp)

            Next

            Console.WriteLine()
        Next

    End Sub

    Function FormatBallNumber(ballNumber As Integer, ballLetter As Integer) As String
        Dim _ballNumber As String
        _ballNumber = CStr((ballNumber + 1) + (ballLetter * 15))
        Return _ballNumber
    End Function
    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        'establish range
        temp *= (max + 1) - min 'makes range bigger by 1 to fix inclusivity max/min
        temp += min ' - 1 'shifts range down so math.ceiling works
        Return CInt(Math.Floor(temp)) 'randomness ok but max is not included
    End Function
End Module

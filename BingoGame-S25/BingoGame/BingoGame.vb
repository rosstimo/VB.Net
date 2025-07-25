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
        Dim _lastBall(1) As Integer

        Do
            Console.Clear()
            DisplayBoard()
            Console.WriteLine()
            'prompt
            Console.WriteLine("Enter D to draw a ball, c for new game, or q to quit.")
            _lastBall = LastBall()
            Console.WriteLine($"The last ball was {FormatBallLetter(_lastBall(1))} {FormatBallNumber(_lastBall(0), _lastBall(1))}")
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
            LastBall(currentBallNumber, currentBallLetter)

            'for debug write valid ball draws to console
            'Console.WriteLine($"the current row Is {currentBallNumber} And column Is {currentBallLetter}")

        End If

    End Sub

    Function LastBall(Optional ballNumber As Integer = -1, Optional ballLetter As Integer = -1) As Integer()
        Static _lastBall(1) As Integer

        If ballNumber <> -1 Then
            _lastBall(0) = ballNumber
            _lastBall(1) = ballLetter
        End If

        Return _lastBall
    End Function

    ''' <summary> ent array that tracks all possible bingo balls
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
        Dim displayString As String = "|"
        Dim heading() As String = {"B", "I", "N", "G", "O"}
        Dim tracker(,) As Boolean = BingoTracker(0, 0)
        Dim columnWidth As Integer = 5
        For Each letter In heading
            'Console.Write(letter.PadLeft((columnWidth \ 2) + 1).PadRight(columnWidth))
            Console.Write(letter.PadLeft(CInt(Math.Ceiling(columnWidth / 2))).PadRight(columnWidth))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(columnWidth * 5, "_"))
        For currentNumber = 0 To 14
            For currentLetter = 0 To 4

                If tracker(currentNumber, currentLetter) Then
                    displayString = $"{FormatBallNumber(currentNumber, currentLetter)} |" 'display for drawn balls
            Else
                    displayString = "|" 'display for not drawn balls
                End If

                displayString = displayString.PadLeft(columnWidth)
                Console.Write(displayString)

            Next

            Console.WriteLine()
        Next

    End Sub

    Function FormatBallNumber(ballNumber As Integer, ballLetter As Integer) As String
        Dim _ballNumber As String
        _ballNumber = CStr((ballNumber + 1) + (ballLetter * 15))
        Return _ballNumber
    End Function

    Function FormatBallLetter(ballLetter As Integer) As String
        Dim _ballLetter As String
        Select Case ballLetter
            Case 0
                _ballLetter = "B"
            Case 1
                _ballLetter = "I"
            Case 2
                _ballLetter = "N"
            Case 3
                _ballLetter = "G"
            Case 4
                _ballLetter = "O"
        End Select
        Return _ballLetter
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

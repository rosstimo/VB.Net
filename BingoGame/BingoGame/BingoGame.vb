Option Strict On
Option Explicit On
Option Compare Text
'Bingo Game
'Spring 2024

Imports System.Runtime.Remoting.Channels




'TODO
'[ ] Start New Game
'[x] Draw One Ball
'[x] Track drawn balls
'[x] Display drawn balls on the console



Module BingoGame


    Sub Main()
        Dim userInput As String
        Dim tracker(14, 4) As Boolean ' each letter has 15 unique numbers
        Dim ballsDrawn As Integer = 0
        Dim message As String = "Welcome To Bingo!!"

        NewGame(tracker)
        Do
            Display(tracker)
            Console.WriteLine(message)
            userInput = Console.ReadLine()
            If userInput = "n" Then
                NewGame(tracker)
            Else
                If ballsDrawn >= 75 Then
                    message = "All balls have been drawn..."
                Else
                    DrawBall(tracker)
                    ballsDrawn += 1
                    message = "Press Enter to draw, N for new game, or Q to quit."
                End If
            End If



        Loop Until userInput = "q"
    End Sub

    Sub NewGame(ByRef tracker(,) As Boolean)
        ReDim tracker(14, 4)
    End Sub

    Sub DrawBall(ByRef tracker(,) As Boolean)
        Dim currentLetter As Integer
        Dim currentNumber As Integer

        'loop until we get a ball that has not yet been drawn
        'then mark the new ball as drawn
        Do
            'potential endless loope here
            currentNumber = RandomNumberZeroTo(14)
            currentLetter = RandomNumberZeroTo(4)
        Loop While tracker(currentNumber, currentLetter)

        tracker(currentNumber, currentLetter) = True

    End Sub

    Private Function RandomNumberZeroTo(max As Integer) As Integer
        Dim _randomNumber As Integer
        Randomize()
        _randomNumber = CInt(Math.Floor((Rnd() * (max + 1))))
        Return _randomNumber
    End Function

    Sub UpdateTracker()
        ' not needed??
    End Sub

    Sub Display(tracker(,) As Boolean)

        Dim temp(14, 4) As Boolean

        temp = tracker

        Dim header() = {"B", "I", "N", "G", "O"}
        Console.Clear()

        For Each letter In header
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()


        For row = 0 To 14
            For column = 0 To 4
                If temp(row, column) Then
                    Console.Write($" {(column * 15) + (row + 1)} |")
                Else
                    Console.Write("   |")
                End If
            Next
            Console.WriteLine()
        Next

    End Sub


End Module

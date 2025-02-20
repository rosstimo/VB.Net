'Bingo Game Program
'Client: Shady Acres 
'Spring 2025

Option Strict On
Option Explicit On

'TODO
'[ ] Display Bingo Board
'[ ] Draw a random ball that has not already been drawn
'[ ] update display to show all drawn balls
'[ ] refresh tracking with "C" or when all balls have been drawn

Module BingoGame

    Sub Main()
        DisplayBoard()
    End Sub

    Function BingoTracker(ballNumber As Integer, ballLetter As Integer, Optional clear As Boolean = False) As Boolean(,)
        Static _bingoTracker(14, 4) As Boolean
        'actual code here
        Return _bingoTracker
    End Function

    Sub DisplayBoard()
        Dim temp As String = "X |"
        Dim heading() As String = {"B", "I", "N", "G", "O"}
        For Each letter In heading
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(20, "_"))
        For i = 1 To 15
            For j = 1 To 5
                temp = temp.PadLeft(4)
                Console.Write(temp)
            Next
            Console.WriteLine()
        Next

    End Sub

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

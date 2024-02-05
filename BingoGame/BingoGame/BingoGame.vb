'Bingo Game
'Spring 2024

Option Strict On
Option Explicit On


'TODO
'[ ] Start New Game
'[ ] Draw One Ball
'[ ] Track drawn balls
'[ ] Display drawn balls on the console



Module BingoGame


    Sub Main()
        Display()
        Console.Read()
    End Sub

    Sub NewGame()

    End Sub

    Sub DrawBall()

    End Sub

    Sub Display()

        Dim temp(14, 4) As Boolean

        temp(7, 3) = True
        temp(3, 4) = True

        For row = 0 To 14
            For column = 0 To 4
                If temp(row, column) Then
                    Console.Write($" X |")
                Else
                    Console.Write("   |")
                End If
            Next
            Console.WriteLine()
        Next

    End Sub


End Module

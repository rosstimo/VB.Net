'Bingo Game
'Spring 2024

Option Strict On
Option Explicit On
Option Compare Text


'TODO
'[ ] Start New Game
'[ ] Draw One Ball
'[ ] Track drawn balls
'[ ] Display drawn balls on the console



Module BingoGame


    Sub Main()
        Dim userInput As String
        Dim tracker(14, 4) As Boolean ' each letter has 15 unique numbers

        Do
            NewGame()
            Display()
            Console.WriteLine("prompt")
            userInput = Console.ReadLine()


        Loop Until userInput = "q"
    End Sub

    Sub NewGame()

    End Sub

    Sub DrawBall()

    End Sub

    Sub UpdateTracker()

    End Sub

    Sub Display()

        Dim temp(14, 4) As Boolean

        Dim header() = {"B", "I", "N", "G", "O"}
        Console.Clear()

        For Each letter In header
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()

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

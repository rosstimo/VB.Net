'Bingo Game
'Fall 2023
'In class examples and practice
'


'TODO
'[*] Create an array to track the numbers called
'[ ] Create a function to display the balls already called
'[ ] Create a way to draw a ball, check if it has been called, and track it in the array
'[ ] Create a way to restart. should happen automatically if all balls are called
'[ ] new game, play again or quit functionality
'Later generate player cards and make playable 
'[ ] Create a way to display the bingo card

Option Explicit On
Option Strict On

Module BingoGame

    Sub Main()
        '75 ball bingo
        'letters B I N G O as 0-4
        'numbers 1-15, 16-30, 31-45, 46-60, 61-75
        'ball number = (letter index * 15) + number index + 1
        Dim bingoCage(4, 14) As Boolean
        'bingoCage(2, 5) = True
        'bingoCage(4, 7) = True
        'bingoCage(4, 13) = True
        DisplayDraws(bingoCage)

        Console.Read()
    End Sub

    Sub DisplayDraws(ballCage(,) As Boolean)
        Dim currentBall As String
        Dim columnWidth As Integer = 5
        Dim header = New String() {"B |", "I |", "N |", "G |", "O |"}

        'display column headers
        For i = LBound(header) To UBound(header)
            Console.Write(header(i).PadLeft(columnWidth))
        Next
        Console.WriteLine()
        'header separation
        Console.WriteLine(StrDup(25, "-"))
        For number = ballCage.GetLowerBound(1) To ballCage.GetUpperBound(1)
            For letter = ballCage.GetLowerBound(0) To ballCage.GetUpperBound(0)
                'Console.Write((letter * 15) + number + 1)

                If ballCage(letter, number) Then
                    currentBall = CStr((letter * 15) + number + 1) & " |"
                Else
                    currentBall = " |"
                End If

                Console.Write(currentBall.PadLeft(5))
            Next
            Console.WriteLine()
        Next


    End Sub

End Module

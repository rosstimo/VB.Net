'Bingo Game
'Fall 2023
'In class examples and practice
'


'TODO
'[*] Create an array to track the numbers called
'[*] Create a function to display the balls already called
'[*] Create a way to draw a ball, check if it has been called, and track it in the array
'[*] Create a way to restart. should happen automatically if all balls are called
'[*] new game, play again or quit functionality - use accumulate messages function
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
        Dim userInput As String
        SetDefaultPrompt()
        Do Until userInput = "q"
            DisplayDraws(bingoCage)
            userInput = Console.ReadLine()
            Select Case userInput
                Case "q"
                    Exit Do
                Case "n"
                    ReDim bingoCage(4, 14)
                Case Else
                    Draw(bingoCage)
            End Select
        Loop

        ' Console.Read()
    End Sub

    Sub DisplayDraws(ByRef ballCage(,) As Boolean)
        Dim currentBall As String
        Dim columnWidth As Integer = 5
        Dim header = New String() {"B |", "I |", "N |", "G |", "O |"}
        Console.Clear()
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
        Console.WriteLine(UserMessage())

    End Sub

    Sub Draw(ByRef bingoCage(,) As Boolean)
        Dim letter As Integer
        Dim number As Integer
        'Dim countOfTries As Integer
        Do
            letter = RandomNumber(4)
            number = RandomNumber(14)
        Loop Until bingoCage(letter, number) = False

        bingoCage(letter, number) = True

    End Sub

    Function RandomNumber(max As Integer) As Integer
        Randomize(DateTime.Now.Millisecond * DateTime.Now.Second)
        Return CInt(Rnd() * max)
    End Function

    Function UserMessage(Optional message As String = "", Optional clear As Boolean = False) As String
        Static messages As String
        If clear Then
            messages = ""
        ElseIf message <> "" Then
            messages &= message & vbNewLine
        End If
        Return messages
    End Function

    Sub SetDefaultPrompt()
        UserMessage(, True)
        UserMessage("Press Enter to draw a ball")
        UserMessage("Enter 'n' to restart game")
        UserMessage("Enter 'q' to quit")
    End Sub

End Module

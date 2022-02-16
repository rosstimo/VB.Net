Module BingoGame
    'TODO how many balls for each letter
    'TODO draw a random ball Letter - B - I - N - G - O - with number
    'TODO track what balls have come up in an array
    'TODO don't draw duplicates
    'TODO clear tracking history on new game
    'B  1 - 15
    'I 16 - 30
    'N 31 - 45
    'G 46 - 60
    'O 61 - 75

    Sub Main()
        Dim bingoCage(4, 14) As Boolean
        DisplayBingoCage(bingoCage)
        Console.Read()
    End Sub

    Sub DisplayBingoCage(ByRef bingoCage(,) As Boolean)
        Dim header() As String = {"B", "I", "N", "G", "O"}
        Dim columnWidth As Integer = 3
        Dim columnData As String

        For row = bingoCage.GetLength(1) To 0 Step -1

            For column = 1 To bingoCage.GetLength(0)
                Select Case row
                    Case 0
                        columnData = header(column - 1).PadLeft(columnWidth)
                    Case Else
                        If bingoCage(column - 1, row - 1) Then
                            columnData = "X"
                        Else
                            columnData = CStr((column * bingoCage.GetLength(1)) - row + 1)
                        End If
                End Select
                Console.Write(columnData.PadLeft(columnWidth))
            Next
            Console.WriteLine()
        Next

    End Sub


End Module

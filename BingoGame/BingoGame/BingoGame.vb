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
        bingoCage(0, 0) = True
        bingoCage(4, 4) = True
        bingoCage(4, 14) = True
        DisplayBingoCage(bingoCage)
        Console.Read()
    End Sub

    Sub DisplayBingoCage(ByRef bingoCage(,) As Boolean)
        Dim header() As String = {"B", "I", "N", "G", "O"}
        Dim columnWidth As Integer = 3
        Dim columnData As String

        For row = 0 To bingoCage.GetLength(1)
            For column = 0 To bingoCage.GetLength(0) - 1
                Select Case row
                    Case 0 'first row is column headers
                        columnData = header(column).PadLeft(columnWidth)
                    Case Else
                        If Not bingoCage(column, row - 1) Then 'mark if ball has been drawn
                            columnData = "  "
                        Else 'show number if ball hasn't been drawn
                            columnData = CStr(((column) * bingoCage.GetLength(1)) + row)
                        End If
                End Select
                Console.Write(columnData.PadLeft(columnWidth) & " |")
            Next
            Console.WriteLine()
            Console.WriteLine(StrDup(25, "-"))
        Next

    End Sub

    ''' <summary>
    ''' The default range is 0 - 10.
    ''' The maximum number must be greater than minimum number.
    ''' </summary>
    ''' <param name="max%"></param>
    ''' <param name="min%"></param>
    ''' <returns>Returns a random integer within a range defined by the max and min arguments.</returns>
    ''' <exception cref="System.ArgumentException">Thrown when <c>max > min</c></exception>
    Function RandomNumberInRange(Optional max% = 10%, Optional min% = 0%) As Integer
        Dim _max% = max - min
        If _max < 0 Then
            Throw New System.ArgumentException("Maximum number must be greater than minimum number")
        End If
        Randomize(DateTime.Now.Millisecond)
        Return CInt(System.Math.Floor(Rnd() * (_max + 1))) + min
    End Function
End Module


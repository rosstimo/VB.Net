Module LetsPlayBingo

    Sub Main()
        Dim BallCage(14, 4) As Boolean
        Dim prettyNumber As String
        Dim header() As String = {"B", "I", "N", "G", "O"}
        Dim pad As Integer = 3
        BallCage(0, 0) = True
        BallCage(1, 4) = True
        BallCage(3, 2) = True
        BallCage(7, 3) = True
        Console.Write("| ")
        For i = 0 To 4
            Console.Write(header(i).PadLeft(pad) & " |")
        Next
        Console.WriteLine()
        Console.WriteLine($"|{StrDup((pad + 2) * 5, "-")}|")

        For number = 0 To 14
            Console.Write("| ")
            For letter = 0 To 4
                ' Console.Write(BallCage(number, letter)) 'TODO write pretty number if drawn blank if not
                Select Case BallCage(number, letter)
                    Case True
                        prettyNumber = CStr((15 * (letter)) + 1 + number)
                    Case False
                        prettyNumber = ""
                End Select
                Console.Write(prettyNumber.PadLeft(pad) & " |")
            Next
            Console.WriteLine()
        Next

        Console.Read()
    End Sub

    'TODO display sub

    ''' <summary>
    ''' get a random integer within the specified range. Inclusive
    ''' </summary>
    ''' <param name="max%"></param>
    ''' <param name="min%"></param>
    ''' <returns></returns>
    Function GetRandomNumberInRange(max%, min%) As Integer
        Dim randomNumber%
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Math.Floor(Rnd() * (max - min + 1))) + min

        Return randomNumber
    End Function

End Module

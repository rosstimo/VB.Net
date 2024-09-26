Option Strict On
Option Explicit On
Option Compare Text

Module LetsPlayBingo

    Sub Main()
        Dim ballCage(14, 4) As Boolean
        Dim done As Boolean = False
        Dim userInput As String

        Do
            Display(ballCage)
            DrawBall(ballCage)
            userInput = Console.ReadLine()
            If userInput = "q" Then done = True
            Console.Clear()
        Loop Until done

        Console.WriteLine("Have a Nice Day!!!")

        Console.Read()
    End Sub

    Sub DrawBall(ByRef ballCage(,) As Boolean)
        Dim _number As Integer
        Dim _letter As Integer

        Do
            _number = GetRandomNumberInRange(14, 0)
            _letter = GetRandomNumberInRange(4, 0)
        Loop Until Not ballCage(_number, _letter)

        ballCage(_number, _letter) = True

    End Sub

    ''' <summary>
    ''' Display the formatted game status on the console
    ''' </summary>
    ''' <param name="ballCage"></param>
    Sub Display(ByRef ballCage(,) As Boolean)
        Dim prettyNumber As String
        Dim header() As String = {"B", "I", "N", "G", "O"}
        Dim pad As Integer = 3
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
                Select Case ballCage(number, letter)
                    Case True
                        prettyNumber = CStr((15 * (letter)) + 1 + number)
                    Case False
                        prettyNumber = ""
                End Select

                Console.Write(prettyNumber.PadLeft(pad) & " |")
            Next
            Console.WriteLine()
        Next

    End Sub

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

Option Strict On
Option Explicit On

Module SecondModule

    Public test As String
    Private secret As String

    Public Sub SayGoodBye()
        Console.WriteLine("Later dudes...")
    End Sub

    Private Sub TellMeASectret()
        Console.WriteLine("Shhhhh.....")
    End Sub

    ''' <summary>
    ''' Returns a random integer between max and min
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Public Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim randomNumber As Integer
        'determine the absolute range or difference from min to max 
        Dim range As Integer = max - min
        Randomize()
        'determine the random number within the range
        'randomNumber = CInt(Rnd() * range) ' test shows not random at max and min
        range += 1 'floor causes max to no longer be inclusive
        randomNumber = CInt(Math.Floor(CDbl(Rnd() * range)))

        'add to min to assure it is between min and max
        randomNumber += min
        Return randomNumber
    End Function

    Sub testRandom()

        'test random numbers from 5 to 10

        Dim counts(16) As Integer

        For i = 1 To 1000000

            counts(RandomNumberBetween(5, 10)) += 1

        Next

        Console.WriteLine("ding")

    End Sub


    Function RunningTotal(Optional newValue As Integer = 0, Optional clear As Boolean = False) As Integer
        Static _runningTotal As Integer

        If clear Then
            _runningTotal = 0
        Else
            _runningTotal += newValue
        End If

        Return _runningTotal
    End Function

    Sub MakeATable(dimensions As Integer)
        Dim temp$ = "X |"

        Console.Clear()

        For row = 1 To dimensions
            For column = 1 To dimensions
                temp = CStr(row + column) & " |"
                Console.Write(temp.PadLeft(5))
            Next
            Console.WriteLine()
        Next
        'Console.Beep()

    End Sub

    Sub PlayTune()

        Console.Beep(392, 500) 'G4'
        Console.Beep(440, 500) 'A4'
        Console.Beep(349, 750) 'F4'
        Console.Beep(196, 750) 'G3'
        Console.Beep(262, 900) 'C4'

    End Sub
End Module

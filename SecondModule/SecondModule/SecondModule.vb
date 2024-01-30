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

End Module

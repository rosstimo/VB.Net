Option Strict On
Option Explicit On

Module RandomNumbers

    Sub Main()
        Dim randomNumbers(7) As Integer
        Dim temp As String
        Dim seperator As String = " |"
        Dim PadLength As Integer = 6
        Dim lineSeperator As String = "-"



        'count random numbers
        For i = 1 To 1000
            randomNumbers(GetRandomInteger()) += 1
        Next

        'display random number count(s)
        'headers
        For i = 0 To 7
            temp = CStr(i) & seperator
            temp = temp.PadLeft(PadLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(48, lineSeperator))

        'display contents of randomNumbers() array
        For i = 0 To 7
            temp = CStr(randomNumbers(i)) & seperator
            temp = temp.PadLeft(PadLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(48, lineSeperator))


        Console.Read()
    End Sub

    Function GetRandomInteger() As Integer
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value
    End Function

End Module

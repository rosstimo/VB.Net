Option Strict On
Option Explicit On

Module RandomNumbers

    Sub Main()
        Dim randomNumbers(7) As Integer
        Dim temp As String
        Dim seperator As String = " |"
        Dim columnLength As Integer = 6
        Dim lineSeperator As String = "-"
        Dim lineLength As Integer = columnLength * (UBound(randomNumbers) + 1)

        'count random numbers
        For i = 1 To 10000
            'randomNumbers(GetRandomInteger()) += 1
            randomNumbers(RandomNumberInRange(6, 2)) += 1
            'Console.WriteLine(RandomNumberInRange(7, 3))

        Next

        'display random number count(s)
        'headers
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(i) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        'display contents of randomNumbers() array
        For i = LBound(randomNumbers) To UBound(randomNumbers)
            temp = CStr(randomNumbers(i)) & seperator
            temp = temp.PadLeft(columnLength)
            Console.Write(temp)
        Next
        Console.WriteLine()

        'separator
        Console.WriteLine(StrDup(lineLength, lineSeperator))

        Console.Read()
    End Sub

    Function GetRandomInteger() As Integer
        Dim value As Integer
        Dim temp As Single

        ' Initialize the random-number generator.
        Randomize() 'TODO add better seed arg
        temp = (Rnd() * 7) + 1
        value = CInt(System.Math.Floor(CDbl(temp)))

        'Console.WriteLine(temp)
        'Console.WriteLine(value)
        ' Generate random value between 1 and 6.
        'Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Return value
    End Function

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

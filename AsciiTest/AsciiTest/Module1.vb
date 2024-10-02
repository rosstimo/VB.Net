Module Module1

    Sub Main()
        'Console.WriteLine("Hello World!")
        ' change the console font to courier new
        'Console.OutputEncoding = System.Text.Encoding.ASCII

        Console.Write($"hearts: {ChrW(&H2665)}, ")
        Console.Write($"spades: {ChrW(&H2660)}, ")
        Console.Write($"diamonds: {ChrW(&H2666)}, ")
        Console.Write($"clubs: {ChrW(&H2663)}")
        'For i = 0 To 255
        '    Try
        '        Console.WriteLine($"{i}: {Chr(i)}")
        '    Catch ex As Exception

        '    End Try
        'Next
        Console.Read()
    End Sub

End Module

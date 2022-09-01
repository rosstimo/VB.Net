'see:
'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.strings?view=netframework-4.8#methods
'https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

Option Strict On
Option Explicit On
Option Compare Binary


Module PlayinWithStrings

    Sub Main()
        Dim testString As String = "Hello, World!!"
        'Dim money As Decimal = 1426.876273897289@
        'Dim length As Integer
        'Dim temp() As String

        Console.WriteLine(Strings.UCase(testString))
        Console.WriteLine(LCase(testString))
        Console.WriteLine(Replace(testString, "W", "X"))
        Console.WriteLine(StrReverse(testString))


        'Console.WriteLine(testString)
        'Console.WriteLine(Left(testString, 7))
        'Console.WriteLine(Right(testString, 2))
        'Console.WriteLine(Mid(testString, 5))
        'Console.WriteLine(Left(testString, 4))

        'https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        'Console.WriteLine(money.ToString("C"))

        'Console.WriteLine(Len(testString))
        'For i = Len(testString) - 1 To 0 Step -1
        '    Console.Write(testString(i))
        'Next
        'Console.WriteLine()
        'Console.WriteLine(testString(14))

        'temp = Split(testString, ", ")
        'Console.WriteLine(temp(1))



        Console.Read()
    End Sub




End Module

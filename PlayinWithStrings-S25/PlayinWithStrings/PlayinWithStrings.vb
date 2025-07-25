'see:
'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.strings?view=netframework-4.8#methods

Option Strict On
Option Explicit On
Option Compare Binary


Module PlayinWithStrings

    Sub Main()
        Dim testString As String = "Hello, World!!"
        Dim money As Decimal = 1426.876273897289@
        Dim length As Integer
        Dim temp() As String


        temp = Split(testString, ", ")
        Console.WriteLine(temp(1))

        'testString = Left(testString, 7)
        'testString = Right(testString, 2)
        'testString = Mid(testString, 5)
        'testString = Left(testString, 4)


        'For i = Len(testString) - 1 To 0 Step -1
        '    Console.Write(testString(i))
        'Next
        'Console.WriteLine()

        'Console.WriteLine(StrReverse(testString))
        'Console.WriteLine(UCase(testString))
        'Console.WriteLine(LCase(testString))
        'testString = Replace(testString, "W", "X")


        'Console.WriteLine(testString)
        'Console.WriteLine(money.ToString("C"))

        Console.Read()
    End Sub




End Module

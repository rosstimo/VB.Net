Public Class ExampleClass


    ''' <summary>
    ''' takes two integer arguments and returns the sum
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns>integer</returns>
    Shared Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Return firstNumber + secondNumber
    End Function

    Public Sub DoSomthing()
        MsgBox("hello")
    End Sub

End Class

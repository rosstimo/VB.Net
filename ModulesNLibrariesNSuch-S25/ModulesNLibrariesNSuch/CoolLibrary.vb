Module CoolLibrary

    ''' <summary>
    ''' A full featured function to say hello...
    ''' </summary>
    ''' <returns>A string "Hello, World!"</returns>
    Public Function SayHello() As String
        Return "Hello, World!"
    End Function

    ''' <summary>
    ''' Displays the contents of argument displayMessage then returns the user's response. 
    ''' </summary>
    ''' <param name="displayMessage"></param>
    ''' <returns>String: user response</returns>
    Public Function Prompt(ByVal Optional displayMessage As String = "") As String
        Console.WriteLine(displayMessage)
        Return Console.ReadLine
    End Function

    Public Function RandomWithInRange(max As Integer, min As Integer) As Integer
        max = max - min
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Rnd() * max) + min
    End Function

End Module

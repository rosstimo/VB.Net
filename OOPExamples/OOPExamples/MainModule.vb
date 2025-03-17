Module MainModule

    Sub Main()
        'DoSomthingInMainModule()
        'DoSomthingInSecondModule()
        'MsgBox(ExampleClass.SumOf(4, 3))

        Dim jimmy As New Animal
        Dim bob As New Animal

        jimmy.Move()
        bob.Move()






    End Sub

    ''' <summary>
    ''' show a message box from within the main module
    ''' </summary>
    Sub DoSomthingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module

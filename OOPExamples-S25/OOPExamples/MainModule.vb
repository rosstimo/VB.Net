Module MainModule

    Sub Main()
        'DoSomthingInMainModule()
        'DoSomthingInSecondModule()
        'MsgBox(ExampleClass.SumOf(4, 3))

        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog
        Dim nemo As New Fish



        'jimmy.Move()
        'Console.WriteLine(jimmy.skinType)
        'bob.Move()
        'Console.WriteLine(bob.skinType)


        pepe.movement = "shiver"
        pepe.skinType = "hairless rat"
        pepe.vocalization = "yip yip yip"
        pepe.Speak()
        pepe.Move()

        lucky.Speak()
        lucky.Move()

        nemo.Speak()



    End Sub

    ''' <summary>
    ''' show a message box from within the main module
    ''' </summary>
    Sub DoSomthingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module




Module ClassRoomExamples

    Sub Main()

        Console.ReadLine()
    End Sub


    Sub ConsoleColors()
        'change entire background
        Console.BackgroundColor() = ConsoleColor.Red
        Console.Clear()

        'change text color
        Console.ForegroundColor() = ConsoleColor.Blue

        'write some text
        Console.WriteLine("is this red???")
        Console.WriteLine("the pen is BLUE!!!!!!")

        'reset colors to default
        'Console.ResetColor()


    End Sub

    Sub ConsoleSounds()
        'play sounds
        Console.Beep()
        Console.Beep(200, 1000)
    End Sub

    Sub MakeLunch()
        Console.WriteLine("yum...")
    End Sub

End Module

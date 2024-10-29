Option Strict On
Option Explicit On
Imports System.Threading.Thread

'TODO
'[ ] frame/play area setup - Build animation frame array, populate with graphic characters
'[ ] basic animation
' - [ ] enemy movement
' - [ ] player movement
' - [ ] projectile
'[ ] collision detection
'[ ] score keeping
'[ ] lives tracking
'[ ] start screen
'[ ] end screen
'
Module GalacticIntruders

    Sub Main()

        UpdateFrame(Enemy(), 0, 0)


        Console.Read()

    End Sub

    Function UpdateFrame(sprite() As String, x As Integer, y As Integer) As String(,)
        Dim frame(120, 30) As String

        For s = 0 To 1
            For i = 0 To sprite(s).Length - 1
                frame(i + x, 2) = sprite(s)(i)
            Next

        Next


        For row = 0 To 15
            For column = 0 To 120

                Console.Write(frame(column, row))
            Next
            Console.WriteLine()
        Next

    End Function

    Function Enemy() As String()
        Dim _enemy(3) As String

        'basic pose 1
        _enemy(0) = "-/8\-"
        _enemy(1) = " o o "
        'basic pose 2
        _enemy(2) = "-\8/-"
        _enemy(3) = "  V  "

        Return _enemy
    End Function

    Sub TestEnemyDraw()
        Do
            For i = 1 To 6
                Console.Write(Enemy(0).PadRight(7))
            Next
            Console.WriteLine()
            For i = 1 To 6
                Console.Write(Enemy(1).PadRight(7))
            Next
            Console.WriteLine()
            Sleep(500)
            Console.Clear()

            For i = 1 To 6
                Console.Write(Enemy(2).PadRight(7))
            Next
            Console.WriteLine()
            For i = 1 To 6
                Console.Write(Enemy(3).PadRight(7))
            Next
            Console.WriteLine()
            Sleep(500)
            Console.Clear()
        Loop
    End Sub
    Sub ConsoleTests()
        'Do
        'Console.WriteLine($"H:{Console.WindowHeight} W:{Console.WindowWidth}")
        'Console.SetWindowSize()
        'Loop
        'Console.WriteLine(Enemy)
    End Sub

End Module

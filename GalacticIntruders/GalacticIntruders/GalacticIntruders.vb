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
        'Console.WriteLine($"H:{Console.WindowHeight} W:{Console.WindowWidth}")
        Console.Title = "Galactic Intruders!!!"

        UpdateFrame(Enemy(), 1, 1)


        Console.Read()

    End Sub

    Function EmptyFrame() As String(,)
        Dim Height% = Console.WindowHeight - 2, Width% = Console.WindowWidth - 2
        Dim frame(Width, Height) As String

        'preload frame
        For row = 0 To Height
            For column = 0 To Width
                If column = 0 Or column = Width Then
                    frame(column, row) = "|"
                ElseIf row = 0 Or row = Height Then
                    frame(column, row) = "_"
                Else
                    frame(column, row) = "." 'replace "." with space after debug
                End If
            Next
        Next
        Return frame

    End Function

    Function UpdateFrame(sprite() As String, x As Integer, y As Integer) As String(,)
        'Dim frame(120, 30) As String
        Dim frame(,) As String = EmptyFrame()

        For s = 0 To 1
            For i = 0 To sprite(s).Length - 1
                frame(i + x, 2) = sprite(s)(i)
            Next

        Next


        For row = 0 To frame.GetUpperBound(1)
            For column = 0 To frame.GetUpperBound(0)

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

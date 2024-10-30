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
        Dim frame(,) As String
        'Console.WriteLine($"H:{Console.WindowHeight} W:{Console.WindowWidth}")
        Console.Title = "Galactic Intruders!!!"

        frame = UpdateFrame(Enemy1(), 1, 1)
        DrawFrame(frame)


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

        'draw sprite relative within frame
        'x,y is where the top left corner of the sprite
        For s = 0 To 1
            For i = 0 To sprite(s).Length - 1
                frame(i + x, s + y) = sprite(s)(i)
            Next

        Next

        Return frame

    End Function

    Sub DrawFrame(frame(,) As String)

        For row = 0 To frame.GetUpperBound(1)
            For column = 0 To frame.GetUpperBound(0)

                Console.Write(frame(column, row))
            Next
            Console.WriteLine()
        Next

    End Sub

    Function Enemy1(Optional pose% = 1) As String()
        Dim _enemy(1) As String

        'basic pose 1
        _enemy(0) = "-/8\-"
        _enemy(1) = " o o "
        Select Case pose
            Case 1
                'pass
            Case 2
                'basic pose 2
                _enemy(0) = "-\8/-"
                _enemy(1) = "  V  "
            Case Else
                'pass
        End Select

        Return _enemy
    End Function

    Function Enemy2(Optional pose% = 1) As String()
        Dim _enemy(1) As String

        'basic pose 1
        _enemy(0) = "/o-O\"
        _enemy(1) = " l L "
        Select Case pose
            Case 1
                'pass
            Case 2
                'basic pose 2
                _enemy(0) = "/O-o\"
                _enemy(1) = " J l "
            Case Else
                'pass
        End Select

        Return _enemy
    End Function

    Sub TestEnemyDraw()
        Do
            For i = 1 To 6
                Console.Write(Enemy1(0)(0).PadRight(7))
            Next
            Console.WriteLine()
            For i = 1 To 6
                Console.Write(Enemy1(1)(1).PadRight(7))
            Next
            Console.WriteLine()
            Sleep(500)
            Console.Clear()

            For i = 1 To 6
                Console.Write(Enemy1(0)(0).PadRight(7))
            Next
            Console.WriteLine()
            For i = 1 To 6
                Console.Write(Enemy1(1)(1).PadRight(7))
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

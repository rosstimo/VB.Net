Option Strict On
Option Explicit On
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Runtime.Versioning
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
        Dim frame(,) As String = EmptyFrame()
        Dim frameDelay As Integer = 300
        Dim pose As Integer = 1
        'Console.WriteLine($"H:{Console.WindowHeight} W:{Console.WindowWidth}")
        Console.Title = "Galactic Intruders!!!"
        Sleep(500)
        'Console.Beep()
        'For x = 1 To 10
        'frame = UpdateFrame(Enemy1(pose), x, 1)

        'frame = DrawEnemies(frame, pose, 2, 2)
        Dim x%, y%
        'x = 2
        ''y = 2
        'frame = UpdateFrame(Enemy1(1), x, y, EmptyFrame())
        'x += 7
        ''y += 7
        'frame = UpdateFrame(Enemy1(1), x, y, frame)
        'x += 7
        ''y += 7
        'frame = UpdateFrame(Enemy1(1), x, y, frame)
        'x += 7
        ''y += 7
        'frame = UpdateFrame(Enemy1(1), x, y, frame)

        frame = DrawEnemies(frame, 1, 2, 2)

        DrawFrame(frame)
        'Sleep(frameDelay)
        'If pose = 1 Then
        '    pose = 2
        'Else
        '    pose = 1
        'End If
        'Next


        Console.Read()

    End Sub

    Function EmptyFrame() As String(,)
        Dim Height% = Console.WindowHeight - 2, Width% = Console.WindowWidth - 2
        Dim frame(Width, Height) As String

        'preload frame
        For row = 0 To Height
            For column = 0 To Width
                If column = 0 Or column = Width Then
                    frame(column, row) = " " '"|"
                ElseIf row = 0 Or row = Height Then
                    frame(column, row) = " " '"_"
                Else
                    frame(column, row) = " " 'replace "." with space after debug
                End If
            Next
        Next
        Return frame

    End Function

    Function UpdateFrame(sprite() As String, x As Integer, y As Integer, Optional frame(,) As String = Nothing) As String(,)
        'Dim frame(120, 30) As String
        ' Dim frame(,) As String = EmptyFrame()
        If frame Is Nothing Then
            frame = EmptyFrame()
        End If

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
        Console.Clear()
        Dim currentRow As String

        For row = 0 To frame.GetUpperBound(1)
            currentRow = ""
            For column = 0 To frame.GetUpperBound(0)

                'Console.Write(frame(column, row))
                currentRow &= frame(column, row)
            Next
            Console.WriteLine(currentRow)
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

    Function Enemy3(Optional pose% = 1) As String()
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

    Function Enemy4(Optional pose% = 1) As String()
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

    'this could probably be kept  in main
    Function EnemyStatus(Optional enemyTracker(,) As Boolean = Nothing, Optional clear As Boolean = False) As Boolean(,)
        Static _enemyTracker(3, 5) As Boolean
        If clear Then
            ReDim _enemyTracker(3, 5)
        ElseIf enemyTracker IsNot Nothing Then
            _enemyTracker = enemyTracker
        Else
            'pass
        End If

        Return _enemyTracker

    End Function


    Function DrawEnemies(frame(,) As String, pose%, x%, y%) As String(,)
        Dim _enemyStatus(,) As Boolean = EnemyStatus()
        Dim numberOfEnemiesPerRow% = _enemyStatus.GetUpperBound(1)
        Dim numberOfRows% = _enemyStatus.GetUpperBound(0)
        Dim killed As Boolean = True 'TODO - implement collision detection
        Dim _enemy() As String = Enemy1(pose)
        Dim enemyType% = 0
        Dim enemyLength% = Len(_enemy(0)), enemyHeight% = _enemy.Length
        Dim enemyPadding = 2

        For j = y To (numberOfRows * (enemyHeight + (enemyPadding \ 2))) + y Step enemyHeight + (enemyPadding \ 2)
            'next enemy type
            enemyType += 1
            Select Case enemyType
                Case 1
                    _enemy = Enemy1(pose)
                Case 2
                    _enemy = Enemy2(pose)
                Case 3
                    _enemy = Enemy3(pose)
                Case 4
                    _enemy = Enemy4(pose)
                Case Else
                    'reset enemy type
                    enemyType = 1
                    _enemy = Enemy1(pose)
            End Select
            'get enemy dimensions
            enemyLength = Len(_enemy(0))
            enemyHeight = _enemy.Length
            'add enemies to their place relative within the frame
            For i = x To (numberOfEnemiesPerRow * (enemyLength + enemyPadding)) + x Step enemyLength + enemyPadding
                frame = UpdateFrame(_enemy, i, j, frame)
            Next

        Next

        Return frame
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


Imports System.Math

Public Class GraphicsForm

    Dim currentColor As Color
    Dim currentPenSize As Integer

    Sub Sketch(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = DrawPictureBox.CreateGraphics
        Dim pen As New Pen(Me.currentColor)
        pen.Width = currentPenSize
        g.DrawLine(pen, startX, startY, endX, endY)
        g.Dispose()
        pen.Dispose()
    End Sub

    Sub Clear()
        DrawPictureBox.Refresh()

    End Sub

    Sub Shake()
        Dim offset As Integer = 50
        ShakeSound()
        For i = 1 To 12
            System.Threading.Thread.Sleep(200) 'wait 200ms
            Me.Left += offset
            Me.Top += offset
            offset *= -1 'invert offset
        Next
    End Sub

    Private Sub ShakeSound()
        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Sub PickPenColor()
        ColorDialog1.ShowDialog()
        Me.currentColor = ColorDialog1.Color
        UpdateSTatusBar()
    End Sub

    Sub DrawSinWave()
        Dim x, y, ymax, oldY, oldX As Integer
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.LightGreen
        ymax = 100
        x = 45
        oldY = ymax
        For x = 0 To 360 Step 1

            'use system.math
            'degrees must be converted to radians deg * (PI/180)

            'Draw sin
            y = CInt(ymax * Sin(x * (PI / 180)) * -1) + ymax
            'y = CInt(Round(ymax * Sin(x * (PI / 180))) * -1) + ymax
            'y = CInt(Ceiling(ymax * Sin(x * (PI / 180))) * -1) + ymax
            'y = CInt(Floor(ymax * Sin(x * (PI / 180))) * -1) + ymax

            Sketch(oldX, oldY, x, y)
            'Console.WriteLine($"({x},{y})")
            oldX = x
            oldY = y

        Next
        Me.currentColor = oldColor

    End Sub

    Sub DrawCosWave()
        Dim x, y, ymax, oldY, oldX As Integer
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.LightBlue
        ymax = 100
        x = 45
        oldY = ymax
        For x = 0 To 360 Step 1

            'use system.math
            'degrees must be converted to radians deg * (PI/180)

            'Draw cos
            y = CInt(ymax * Cos(x * (PI / 180)) * -1) + ymax

            Sketch(oldX, oldY, x, y)
            'Console.WriteLine($"({x},{y})")
            oldX = x
            oldY = y

        Next
        Me.currentColor = oldColor

    End Sub

    Sub DrawTanWave()
        Dim x, y, ymax, oldY, oldX As Integer
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.Red
        ymax = 100
        x = 45
        oldY = ymax

        For x = 0 To 360 Step 1
            'use system.math
            'degrees must be converted to radians deg * (PI/180)

            'Draw tan
            Try
                'don't crash on +- infinite
                y = CInt(ymax * Tan(x * (PI / 180)) * -1) + ymax
                Sketch(oldX, oldY, x, y)
                oldY = y
                oldX = x
            Catch ex As Exception
                Console.WriteLine($"oops infinite is too hard to handle!")
                Console.WriteLine(ex.Message)
            End Try

        Next
        Me.currentColor = oldColor

    End Sub

    Sub DrawDivisions()
        Dim verticalDivisions As Integer = 10
        Dim horizontalDivisions As Integer = 8
        Dim oldColor As Color = Me.currentColor

        Me.currentColor = Color.Gray

        'Draw division lines top to bottom
        For v = 0 To 360 Step DrawPictureBox.Width \ verticalDivisions
            Sketch(v, 0, v, DrawPictureBox.Height)
        Next

        'Draw division lines left to right
        For h = 0 To 200 Step DrawPictureBox.Height \ horizontalDivisions
            Sketch(0, h, DrawPictureBox.Width, h)
        Next

        Me.currentColor = oldColor
    End Sub

    Sub UpdateSTatusBar(Optional x As Integer = 0, Optional y As Integer = 0)

        PositionStatusLabel.Text = currentColor.Name & "   " &
        CStr(currentPenSize) & " px   " & _ 'TODO update pixels,cm,inch etc.
        $"({x},{y})".PadLeft(15)
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) _
        Handles DrawPictureBox.MouseMove, DrawPictureBox.MouseDown

        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y}) Button:{e.Button.ToString()}"

        Select Case e.Button.ToString
            Case "Left"
                Sketch(oldX, oldY, e.X, e.Y)
            Case "Middle"
                PickPenColor()
        End Select

        oldX = e.X
        oldY = e.Y
        UpdateSTatusBar(e.X, e.Y)
    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
        currentPenSize = 1
        UpdateSTatusBar()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        PickPenColor()
    End Sub

    Private Sub SizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip.Opened, ContextMenuStrip.Closed, SizeToolStripMenuItem.LostFocus
        SizeToolStripMenuItem.Text = CStr(currentPenSize)
        Try
            currentPenSize = CInt(SizeToolStripMenuItem.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DrawWavesButton_Click(sender As Object, e As EventArgs) Handles DrawWavesButton.Click
        Clear()
        DrawDivisions()
        DrawSinWave()
        DrawCosWave()
        DrawTanWave()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Shake()
        Clear()
    End Sub
End Class



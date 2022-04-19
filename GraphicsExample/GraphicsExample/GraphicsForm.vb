
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

    Sub PickPenColor()
        ColorDialog1.ShowDialog()
        Me.currentColor = ColorDialog1.Color

    End Sub

    Sub DrawSinWave()
        Dim x, y, ymax, oldY, oldX As Integer
        ymax = 100
        x = 45

        'use system.math
        'degrees must be converted to radians deg * (PI/180)
        '
        Console.WriteLine(ymax * Sin(x * (PI / 180)))
        Console.WriteLine(Ceiling((ymax * Sin(x * (PI / 180)))))
        Console.WriteLine(Floor((ymax * Sin(x * (PI / 180)))))


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

    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
        currentPenSize = 1
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
        DrawSinWave()
    End Sub
End Class



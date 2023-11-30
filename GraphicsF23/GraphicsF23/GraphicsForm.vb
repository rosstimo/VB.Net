
Option Strict On
Option Explicit On

Imports System.Math

Public Class GraphicsForm
    Dim backgroundColor As Color
    Dim foregroundColor As Color

    Sub SetDefaults()
        Me.foregroundColor = Color.Black
        Me.Backgroundcolor = Color.LightBlue

        DrawingPictureBox.BackColor = Me.backgroundColor

        'clear picture box
        DrawingPictureBox.Refresh()


    End Sub

    Sub drawLine(x1%, y1%, x2%, y2%)
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Me.foregroundColor)

        g.DrawLine(pen, x1, y1, x2, y2)

        pen.Dispose()
        g.Dispose()
    End Sub

    ''' <summary>
    ''' Change the foreground color by default. 
    ''' Change th background color by setting second parameter to False.
    ''' </summary>
    ''' <param name="newColor">newColor as Color</param>
    ''' <param name="foreground">True = foreground, False = background</param>
    Sub ChangeColor(newColor As Color, Optional foreground As Boolean = True)
        If foreground Then
            Me.foregroundColor = newColor
        Else
            Me.backgroundColor = newColor
            DrawingPictureBox.BackColor = Me.backgroundColor
        End If
    End Sub

    Sub DrawWave()
        Dim oldX%, oldY%, newX%, newY%
        Dim ymax% = DrawingPictureBox.Height \ 2

        For i# = 0 To DrawingPictureBox.Width Step DrawingPictureBox.Width / 360
            newX = CInt((DrawingPictureBox.Width / 360) * i)
            newY = CInt(ymax * Sin(((i * PI) / 180) + PI) + ymax)
            drawLine(oldX, oldY, newX, newY)
            oldX = newX
            oldY = newY
        Next

    End Sub

    ' Event handlers below
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'SetDefaults()
        DrawWave()
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown

        Static oldx%, oldy%
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString}"

        Select Case True
            Case e.Button = MouseButtons.Left
                drawLine(oldx, oldy, e.X, e.Y)
        End Select

        oldx = e.X
        oldy = e.Y

    End Sub

    Private Sub ForegroundContextMenuItem_Click(sender As Object, e As EventArgs) Handles ForegroundContextMenuItem.Click
        ColorDialog.ShowDialog()
        ChangeColor(ColorDialog.Color)
    End Sub

    Private Sub BackgroundContextMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundContextMenuItem.Click
        ColorDialog.ShowDialog()
        ChangeColor(ColorDialog.Color, False)
    End Sub
End Class

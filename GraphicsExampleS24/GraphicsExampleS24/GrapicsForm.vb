
Option Strict On
Option Explicit On


Public Class GrapicsForm

    Sub SetDefaults()
        ForegroundColor(Color.Black, True)
    End Sub

    Function ForegroundColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color

        If update Then
            currentColor = newColor
        End If

        Return currentColor

    End Function

    Sub DrawLine()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics

        'Dim pen As New Pen(Color.Black)
        Dim pen As New Pen(ForegroundColor())

        Static oldX As Integer, oldY As Integer

        If draw Then
            g.DrawLine(pen, oldX, oldY, newX, newY)
        End If

        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawEllipse()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)

        g.DrawEllipse(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)

        g.DrawRectangle(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawString()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        'Dim pen As New Pen(Color.Green)
        'Dim brush As Brush
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat '???

        g.DrawString("Hello", drawFont, drawBrush, 100, 100, drawFormat)


        drawFont.Dispose()
        drawBrush.Dispose()
        'pen.Dispose()
        g.Dispose()
    End Sub

    ' Event Handlers Below Here

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button}"

        If e.Button = MouseButtons.Left Then
            MouseDraw(e.X, e.Y, True)
        Else
            MouseDraw(e.X, e.Y, False)
        End If

    End Sub

    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button}"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DrawingPictureBox.Refresh()
        SetDefaults()
    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        DrawLine()
        DrawEllipse()
        DrawRectangle()
        DrawString()
    End Sub

    Private Sub ForegroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForegroundToolStripMenuItem.Click

        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ForegroundColor(ColorDialog.Color, True)
        End If

    End Sub

    Private Sub GrapicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub
End Class

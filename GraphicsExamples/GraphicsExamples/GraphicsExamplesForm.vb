'Graphics Examples
'Spring 2025

Option Strict On
Option Explicit On

Public Class GraphicsExamplesForm

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        'pen.Color = Color.Lime

        g.DrawLine(pen, 50, 50, 100, 100)

        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red, 3)

        g.DrawRectangle(pen, 150, 150, 300, 250)

        g.Dispose()
    End Sub

    Sub DrawEllipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.RoyalBlue, 5)

        g.DrawEllipse(pen, 160, 160, 280, 230)

        g.Dispose()
    End Sub

    Sub DrawString()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red, 3)
        ' Create font and brush.
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Crimson)


        g.DrawString("Graphics!", drawFont, drawBrush, 200, 200)

        g.Dispose()
    End Sub

    ' Event Handlers ----------------------------------------------------------
    Private Sub GraphicsExamplesForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawEllipse()
        DrawString()
    End Sub

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class

'Graphics Examples
'Spring 2025

Option Strict On
Option Explicit On

Public Class GraphicsExamplesForm

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        'pen.Color = Color.Black

        g.DrawLine(pen, 50, 50, 100, 100)

        g.Dispose()
    End Sub

    ' Event Handlers ----------------------------------------------------------
    Private Sub GraphicsExamplesForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
    End Sub

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y})"
    End Sub
End Class

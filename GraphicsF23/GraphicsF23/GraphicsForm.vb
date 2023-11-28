
Option Strict On
Option Explicit On


Public Class GraphicsForm
    Dim backgroundColor As Color
    Dim foregroundColor As Color

    Sub SetDefaults()
        Me.foregroundColor = Color.Black
        Me.Backgroundcolor = Color.LightBlue

        DrawingPictureBox.BackColor = Me.backgroundColor
    End Sub

    Sub drawLine(x1%, y1%, x2%, y2%)
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Me.foregroundColor)

        g.DrawLine(pen, x1, y1, x2, y2)

        pen.Dispose()
        g.Dispose()
    End Sub

    ' Event handlers below
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
        drawLine(0, 0, 100, 100)
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

End Class

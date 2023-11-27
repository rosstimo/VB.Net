Public Class GraphicsForm


    Sub SetDefaults()
        DrawingPictureBox.BackColor = Color.LightBlue
    End Sub

    Sub drawLine()
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 10, 10, DrawingPictureBox.Width - 10, DrawingPictureBox.Height - 10)

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
        drawLine()
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString}"
    End Sub
End Class

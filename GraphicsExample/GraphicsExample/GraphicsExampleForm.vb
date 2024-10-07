Public Class GraphicsExampleForm

    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawRectangle()
        DrawCircle()
        DrawText()
        DrawImage()
    End Sub

    Sub DrawLine()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawLine(pen, 100, 100, 300, 300)

        g.Dispose()

    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawRectangle(pen, 100, 100, 300, 300)

        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawEllipse(pen, 100, 100, 300, 300)

        g.Dispose()
    End Sub

    Sub DrawText()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Blue)
        Dim brush As New SolidBrush(Color.Red)


        g.DrawString("Hello", Me.Font, brush, 50, 50)
        g.Dispose()
    End Sub

    Sub DrawImage()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim image As Image = Image.FromFile("c:\Users\tim\Downloads\kitten.jpg")
        Dim newImage As New Bitmap(image, 500, 500)

        g.DrawImage(newImage, 150, 0)

        g.Dispose()
    End Sub

    Sub MouseDraw(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
    End Sub

    ' Event Handlers below here --------------------------------------------------------

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown, DrawingPictureBox.MouseMove
        Me.Text = $"({e.X.ToString},{e.Y.ToString}) Button: {e.Button}"
        Static oldX%, oldY%
        If e.Button = MouseButtons.Left Then
            MouseDraw(oldX, oldY, e.X, e.Y)
        End If

        oldX = e.X
        oldY = e.Y

    End Sub
End Class

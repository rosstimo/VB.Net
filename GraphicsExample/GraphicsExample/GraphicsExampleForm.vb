Public Class GraphicsExampleForm

    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'DrawRectangle()
        'DrawCircle()
        'DrawText()
        DrawImage()
    End Sub

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawLine(pen, 100, 100, 300, 300)

        g.Dispose()

    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawRectangle(pen, 100, 100, 300, 300)

        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = Me.CreateGraphics()
        Dim pen As New Pen(Color.Blue)

        g.DrawEllipse(pen, 100, 100, 300, 300)

        g.Dispose()
    End Sub

    Sub DrawText()
        Dim g As Graphics = Me.CreateGraphics()
        Dim pen As New Pen(Color.Blue)
        Dim brush As New SolidBrush(Color.Red)


        g.DrawString("Hello", Me.Font, brush, 50, 50)
        g.Dispose()
    End Sub

    Sub DrawImage()
        Dim g As Graphics = Me.CreateGraphics()
        Dim image As Image = Image.FromFile("c:\Users\tim\Downloads\kitten.jpg")
        Dim newImage As New Bitmap(image, 500, 500)

        g.DrawImage(newImage, 150, 0)

        g.Dispose()
    End Sub
End Class

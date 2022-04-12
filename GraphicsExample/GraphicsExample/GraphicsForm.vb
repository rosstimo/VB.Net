Public Class GraphicsForm

    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'DrawLine()
        DrawRectangle()
        DrawElipse()
        ColorDialog1.ShowDialog()
    End Sub

    Sub DrawLine()
        'instantiate new graphics object and tell it what to draw on 
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 100, 100, 200, 200)
        'g.DrawLine(pen, 0, 0, Me.Width, Me.Height)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red)

        pen.Width = 20

        g.DrawRectangle(pen, 100, 100, 200, 300)

        pen.Dispose()
        g.Dispose()

    End Sub

    Sub DrawElipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Green)


        g.DrawEllipse(pen, 100, 100, 200, 200)

        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X},{e.Y}) Button:{e.Button.ToString()}"
    End Sub

    Private Sub GraphicsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Text = $"You Clicked Mouse Button:   {e.Button.ToString()}"
    End Sub
End Class

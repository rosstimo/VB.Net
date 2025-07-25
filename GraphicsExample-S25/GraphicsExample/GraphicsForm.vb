Public Class GraphicsForm

    Dim currentColor As Color


    Sub Sketch(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Me.currentColor)
        'Static oldX, oldY As Integer
        g.DrawLine(pen, startX, startY, endX, endY)
        'oldX = currentX
        'oldY = currentY
        g.Dispose()
        pen.Dispose()
    End Sub

    Sub Clear()

        'Me.BackColor = Control.DefaultBackColor
        Me.Refresh()
    End Sub


    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        'DrawRectangle()
        'DrawElipse()
        'ColorDialog1.ShowDialog()
    End Sub

    Sub DrawLine()
        'instantiate new graphics object and tell it what to draw on 
        'Dim g As Graphics = Me.CreateGraphics
        Dim g As Graphics = PictureBox1.CreateGraphics
        Dim pen As New Pen(Color.Black)

        'g.DrawLine(pen, 100, 100, 200, 200)
        'g.DrawLine(pen, 0, 0, Me.Width, Me.Height)
        g.DrawLine(pen, 0, 0, PictureBox1.Width, PictureBox1.Height)

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

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseDown
        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y}) Button:{e.Button.ToString()}"

        Select Case e.Button.ToString
            Case "Left"
                Sketch(oldX, oldY, e.X, e.Y)
            Case "Middle"
                'ColorDialog1.ShowDialog()
                'Me.currentColor = ColorDialog1.Color
                Clear()
        End Select

        oldX = e.X
        oldY = e.Y

    End Sub

    'Private Sub GraphicsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
    '    Me.Text = $"You Clicked Mouse Button:   {e.Button.ToString()}"
    'End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Cursor = Cursors.Cross
    End Sub
End Class


Option Strict On
Option Explicit On


Public Class GrapicsForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub DrawLine()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub
    Sub MouseDraw(newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 0, 0, newX, newY)

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

    Private Sub GrapicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawEllipse()
        DrawRectangle()
        DrawString()

    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button}"
        MouseDraw(e.X, e.Y)

    End Sub

    Private Sub DrawingPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button}"
    End Sub
End Class

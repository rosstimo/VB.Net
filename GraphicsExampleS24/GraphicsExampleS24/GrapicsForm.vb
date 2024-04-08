
Option Strict On
Option Explicit On


Public Class GrapicsForm
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        g.DrawLine(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub


    Sub DrawEllipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Green)

        g.DrawEllipse(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red)

        g.DrawRectangle(pen, 0, 0, 100, 100)

        pen.Dispose()
        g.Dispose()
    End Sub


    Sub DrawString()
        Dim g As Graphics = Me.CreateGraphics
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
End Class

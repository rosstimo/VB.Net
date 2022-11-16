Public Class GraphicsForm

    Dim currentColor As Color
    'Dim currentX%, currentY% '% means As Integer

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
        'DrawLine()
        'DrawLineExample()
        'DrawRectangle()
        'DrawElipse()
        'ColorDialog1.ShowDialog()
    End Sub

    Sub DrawLineExample(lastX As Integer, lastY As Integer, currentX As Integer, currentY As Integer)
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Me.currentColor)

        g.DrawLine(pen, lastX, lastY, currentX, currentY)

        g.Dispose()
        pen.Dispose()
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


    'Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, Me.MouseDown
    '    Static oldX, oldY As Integer
    '    Me.Text = $"({e.X},{e.Y}) Button:{e.Button.ToString()}"

    '    Select Case e.Button.ToString
    '        Case "Left"
    '            Sketch(oldX, oldY, e.X, e.Y)
    '        Case "Middle"
    '            'ColorDialog1.ShowDialog()
    '            'Me.currentColor = ColorDialog1.Color
    '            Clear()
    '    End Select

    '    oldX = e.X
    '    oldY = e.Y

    'End Sub

    ''Private Sub GraphicsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
    ''    Me.Text = $"You Clicked Mouse Button:   {e.Button.ToString()}"
    ''End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
        ColorStatusLabel.Text = Me.currentColor.ToString
    End Sub

    Private Sub GraphicsForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        PositionStatusLabel.Text = CStr($"({e.X},{e.Y})")
        'Me.currentX = e.X
        'Me.currentY = e.Y
        Static lastX%, lastY%

        If e.Button.ToString = "Left" Then
            DrawLineExample(lastX, lastY, e.X, e.Y)
        End If
        'update on every mouse move so it will not draw from end of previous line
        lastX = e.X
        lastY = e.Y
    End Sub

    Private Sub GraphicsForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        MouseButtonStatusLabel.Text = e.Button.ToString
        If e.Button.ToString = "Left" Then
            'DrawLineExample(e.X, e.Y)
        ElseIf e.Button.ToString = "Middle" Then
            ColorDialog1.ShowDialog()
            Me.currentColor = ColorDialog1.Color
            ColorStatusLabel.Text = ColorDialog1.Color.ToString
        End If


    End Sub

    Private Sub GraphicsForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        MouseButtonStatusLabel.Text = "None"
    End Sub
End Class

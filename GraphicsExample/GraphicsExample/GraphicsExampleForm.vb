Imports System.Net.NetworkInformation

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

    Function PenColor(Optional newColor As Color = Nothing) As Color
        Static _color As Color

        If newColor <> Nothing Then
            _color = newColor
        End If

        Return _color
    End Function

    Sub MouseDraw(startX As Integer, startY As Integer, endX As Integer, endY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim pen As New Pen(PenColor())

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
    End Sub

    Sub DrawDivisions()
        Dim xSpace As Integer = DrawingPictureBox.Width \ 10
        Dim ySpace As Integer = DrawingPictureBox.Height \ 8
        DrawingPictureBox.BackColor = Color.Black
        PenColor(Color.LightGray)

        For i = 0 To xSpace * 10 Step xSpace
            MouseDraw(i, 0, i, ySpace * 8)
        Next

        For i = 0 To ySpace * 8 Step ySpace
            MouseDraw(0, i, xSpace * 10, i)
        Next

    End Sub

    Sub DrawSinWave()
        Dim degrees As Double = Math.PI / 180
        Dim oneDegree As Integer = DrawingPictureBox.Width \ 360
        Dim peak As Integer = DrawingPictureBox.Height \ 2
        Dim currentY As Integer
        Dim lastY As Integer
        Dim lastX As Integer

        PenColor(Color.Lime)
        For i = 0 To 360 * oneDegree Step oneDegree
            currentY = CInt(peak * Math.Sin(i * degrees)) + peak
            MouseDraw(lastX, lastY, i, currentY)
            lastX = i
            lastY = currentY
        Next


    End Sub

    ' Event Handlers below here --------------------------------------------------------

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseDown, DrawingPictureBox.MouseMove
        Me.Text = $"({e.X.ToString},{e.Y.ToString}) Button: {e.Button} Color: {PenColor().Name}"
        Static oldX%, oldY%
        If e.Button = MouseButtons.Left Then
            MouseDraw(oldX, oldY, e.X, e.Y)
        End If

        oldX = e.X
        oldY = e.Y

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click

        ColorDialog.ShowDialog()
        PenColor(ColorDialog.Color)

    End Sub

    Private Sub GraphicsExampleForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        PenColor(Color.Black)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DrawingPictureBox.Image = Nothing
    End Sub

    Private Sub BackGroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackGroundColorToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        DrawingPictureBox.BackColor = ColorDialog.Color
    End Sub

    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        DrawDivisions()
        DrawSinWave()
    End Sub
End Class

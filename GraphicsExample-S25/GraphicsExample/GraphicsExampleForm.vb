Imports System.Net.NetworkInformation
Imports System.Windows.Forms.AxHost

Public Class GraphicsExampleForm

    Function StoreBMP(Optional image As Image = Nothing) As Image
        Static bmp As Bitmap
        If image Is Nothing Then
            Return bmp
        Else
            bmp = New Bitmap(image)
            Return bmp
        End If

    End Function

    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'DrawRectangle()
        ' DrawCircle()
        'DrawText()
        'DrawImage()
    End Sub

    Sub DrawLine()
        Dim bmp As New Bitmap(DrawingPictureBox.Image)

        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim pen As New Pen(Color.Blue)

        g.DrawLine(pen, 100, 100, 300, 300)

        g.Dispose()
        DrawingPictureBox.Image = bmp

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

    Sub DrawImage(imagePath As String)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        Dim image As Image = Image.FromFile(imagePath)
        Dim newImage As New Bitmap(image, DrawingPictureBox.Width, DrawingPictureBox.Height)

        g.DrawImage(newImage, 0, 0)

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
        'Dim bmp As New Bitmap(DrawingPictureBox.Image)

        Dim g As Graphics = Graphics.FromImage(StoreBMP)
        Dim pen As New Pen(PenColor())

        g.DrawLine(pen, startX, startY, endX, endY)

        g.Dispose()
        DrawingPictureBox.Image = StoreBMP()
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
        Dim currentX As Integer
        Dim lastY As Integer
        Dim lastX As Integer

        PenColor(Color.Lime)
        For i = 0 To 360

            currentY = CInt(peak * Math.Sin(i * degrees)) + peak
            currentX = lastX + oneDegree
            MouseDraw(lastX, lastY, currentX, currentY)
            lastX = currentX
            lastY = currentY
        Next


    End Sub

    Function CreateBitmap() As Image
        Dim bmp As New Bitmap(DrawingPictureBox.Width, DrawingPictureBox.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.Clear(DrawingPictureBox.BackColor)

        g.Dispose()

        Return bmp
    End Function

    Function getBitMap() As Bitmap
        Dim bmp As New Bitmap(DrawingPictureBox.Width, DrawingPictureBox.Height)
        'get the current image from drawingpicturebox
        Dim g As Graphics = Graphics.FromImage(bmp)
        DrawingPictureBox.DrawToBitmap(bmp, DrawingPictureBox.ClientRectangle)


        Return bmp
    End Function

    Sub ClearPictureBox()
        DrawingPictureBox.Image = StoreBMP(CreateBitmap)
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
        ClearPictureBox()
    End Sub

    Private Sub BackGroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackGroundColorToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        DrawingPictureBox.BackColor = ColorDialog.Color
    End Sub

    Private Sub WaveButton_Click(sender As Object, e As EventArgs) Handles WaveButton.Click
        DrawDivisions()
        DrawSinWave()
        'CreateBitmap()
        'DrawLine()
    End Sub

    Private Sub OpenTopMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTopMenuItem.Click
        Dim newImage As Image
        OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        OpenFileDialog.FileName = ""
        OpenFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"

        OpenFileDialog.ShowDialog()

        DrawImage(OpenFileDialog.FileName)


    End Sub

    Private Sub SaveTopMenuItem_Click(sender As Object, e As EventArgs) Handles SaveTopMenuItem.Click

        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        SaveFileDialog.FileName = $"Untitled-{DateTime.Today.Now.ToString("yyMMddhhmmss")}.bmp"
        SaveFileDialog.ShowDialog()

        'save the current graphics to a file
        DrawingPictureBox.Image.Save(SaveFileDialog.FileName, Imaging.ImageFormat.Bmp)



    End Sub

    Private Sub GraphicsExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'StoreBMP(CreateBitmap)
        ClearPictureBox()
    End Sub

    Private Sub DrawingPictureBox_Resize(sender As Object, e As EventArgs) Handles DrawingPictureBox.Resize
        'Dim oldBMP As New Bitmap(DrawingPictureBox.Image)
        If Me.Visible Then

            Dim newImage As New Bitmap(StoreBMP(), DrawingPictureBox.Width, DrawingPictureBox.Height)
            DrawingPictureBox.Image = StoreBMP(newImage)
        End If

    End Sub
End Class

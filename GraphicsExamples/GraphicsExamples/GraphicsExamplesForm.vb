Option Strict On
Option Explicit On
'Graphics Examples
'Spring 2025

Imports System.Media
Imports System.Runtime.CompilerServices

'TODO 
' [ ] add functionality for all context menu items
'   [x] background color
'   [ ] pen width as drop down or text input with max width defined
'   [ ] font
' [ ] match functionality between context menu and top menu
' [x] add tool tip on picture box
' [x] plot sin wave
' [ ] add erase mode
' [ ] draw shape(s) tool
' [x] add about form
' [x] add splash screen
' 
Public Class GraphicsExamplesForm

    Function ForegroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If

        Return _foreColor
    End Function
    Function BackgroundColor(Optional newColor As Color = Nothing) As Color
        Static _backColor As Color = Color.White

        If newColor <> Nothing Then
            _backColor = newColor
        End If

        Return _backColor
    End Function

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1
        'define valid range. Note widths > 1 look weird, maybe draw rectangles?
        If newWidth > 100 Then
            _penWidth = 100
        ElseIf newWidth > 0 Then
            _penWidth = newWidth
        End If

        Return _penWidth
    End Function

    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForegroundColor, PenWidth())

        g.DrawLine(pen, oldX, oldY, newX, newY)

        g.Dispose()
    End Sub

    Sub DrawSinWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Lime)
        Dim ymax As Integer
        Dim oldX, oldY, newY As Integer
        Dim yOffset As Integer = DrawingPictureBox.Height \ 2
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width

        ymax = yOffset
        oldY = yOffset
        ymax *= -1
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degreesPerPoint))) + yOffset
            g.DrawLine(pen, oldX, oldY, x, newY)
            oldX = x
            oldY = newY

        Next

        g.Dispose()
    End Sub

    ' Event Handlers ----------------------------------------------------------

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY, lastVerticalLineX As Integer
        Dim lastColor As Color
        Dim lastWidth As Integer

        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForegroundColor.ToString}"
        'Only draw when button is held down
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'ignore and use context menu
            Case "Middle"
                'manually draw a line from top to bottom in the middle
                'DrawWithMouse(DrawingPictureBox.Width \ 2, 0, DrawingPictureBox.Width \ 2, DrawingPictureBox.Height)
                'draw a line top to bottom on the current  mouse x location
                lastColor = ForegroundColor() 'save user color
                lastWidth = PenWidth() 'save user pen width
                PenWidth(3) ' set wider pen width to eliminate ghosting
                ForegroundColor(BackgroundColor()) 'set foreground color to background color
                DrawWithMouse(lastVerticalLineX, 0, lastVerticalLineX, DrawingPictureBox.Height) 'erase last line

                PenWidth(1) 'set with to 1 pixel
                ForegroundColor(lastColor) 'revert foreground color to user defined
                DrawWithMouse(e.X, 0, e.X, DrawingPictureBox.Height) 'draw vertical line
                lastVerticalLineX = e.X 'store x position of last line
                PenWidth(lastWidth) ' revert pen width to user defined
        End Select

        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub ChangeforegroundColor(sender As Object, e As EventArgs) Handles ForegroundColorTopMenuItem.Click, ForegroundColorContextMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            ForegroundColor(ColorDialog.Color)
        End If
    End Sub

    Private Sub BackgroundColorContextMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorTopMenuItem.Click, BackgroundColorContextMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            BackgroundColor(ColorDialog.Color)
            'This erases everything
            'DrawingPictureBox.BackColor = BackgroundColor()
        End If
    End Sub

    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        'https://freesound.org/
        Try
            My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
        Catch ex As Exception
        End Try

        DrawingPictureBox.Refresh() '.BackColor = BackgroundColor()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    Private Sub GraphicsExamplesForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Static isStartUp As Boolean = True
        If isStartUp Then
            SplashForm.Show()
            isStartUp = False
        End If
    End Sub

    Private Sub DrawWaveButton_Click(sender As Object, e As EventArgs) Handles DrawWaveButton.Click
        DrawingPictureBox.Refresh()
        DrawSinWave()
    End Sub
End Class

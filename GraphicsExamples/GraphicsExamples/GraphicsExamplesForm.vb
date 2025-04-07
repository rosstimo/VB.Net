Option Strict On
Option Explicit On
'Graphics Examples
'Spring 2025

Imports System.Runtime.CompilerServices

'TODO 
' [ ] add functionality for all context menu items
'   [x] background color
'   [ ] pen width as drop down or text input with max width defined
'   [ ] font
' [ ] match functionality between context menu and top menu
' [x] add tool tip on picture box
' [ ] plot sin wave
' [ ] add erase mode
' [ ] draw shape(s) tool
' [ ] add about form
' [ ] add splash screen
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

    ' Event Handlers ----------------------------------------------------------

    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForegroundColor.ToString}"
        'Only draw when button is held down
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'ignore and use context menu
            Case "Middle"
                'TODO
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
        DrawingPictureBox.BackColor = BackgroundColor()
    End Sub

    Private Sub DrawingPictureBox_Click(sender As Object, e As EventArgs) Handles DrawingPictureBox.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class

Public Class WinFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DefaultSetup()
        RadioButton1.Checked = True
        RadioButton4.Checked = True
        RadioButton6.Checked = True
        GoButton.Enabled = False
        GoToolStripMenuItem.Enabled = False
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DefaultSetup()
    End Sub

    Private Sub ValidateFields()
        Dim allFieldsValid As Boolean = True
        Dim age As Integer
        Dim message As String

        If NameTextBox.Text = "" Then
            allFieldsValid = False
            message &= "Name is required" & vbNewLine
        End If

        If AgeTextBox.Text = "" Then
            allFieldsValid = False
            message &= "Age is required" & vbNewLine
        ElseIf allFieldsValid Then

            Try
                age = CInt(AgeTextBox.Text)
                Select Case age
                    Case <= 0
                        allFieldsValid = False
                        message &= "Lost infant can be collected at the baggage claim" & vbNewLine
                    Case 1 To 5
                        allFieldsValid = False
                        message &= "You must be at least this tall to ride" & vbNewLine
                    Case 6 To 18
                        allFieldsValid = False
                        message &= "Why don't you try the kiddy ride!" & vbNewLine
                    Case 19 To 55
                        allFieldsValid = True
                        message &= "Enjoy the ride" & vbNewLine
                    Case > 55
                        allFieldsValid = False
                        message &= "Patrons with heart conditions should avoid the thrill rides" & vbNewLine
                    Case Else
                        allFieldsValid = False
                        message &= "I really don't know what to say..." & vbNewLine
                End Select
            Catch ex As Exception
                allFieldsValid = False
                message &= "Age must be a number" & vbNewLine
            End Try
        End If

        If allFieldsValid Then
            GoButton.Enabled = True
            GoToolStripMenuItem.Enabled = True
        Else
            GoButton.Enabled = False
            GoToolStripMenuItem.Enabled = False
            MsgBox(message)

        End If
    End Sub
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click, GoToolStripMenuItem.Click
        MsgBox("You clicked go!")
    End Sub

    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        DefaultSetup()
    End Sub

    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave, AgeTextBox.Leave, CityTextBox.Leave, StateTextBox.Leave
        ValidateFields()
    End Sub
End Class
' Header    

Option Explicit On
Option Strict On

Public Class WinFormExampleForm
    Sub Clear()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeTextBox.Text = ""
    End Sub

    'Event Handlers ***********************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "Forms Are Cool"
        'Me.Text = StrReverse(Me.Text)
        Me.Text = FirstTextBox.Text & " " & LastTextBox.Text
        Clear()
    End Sub
End Class

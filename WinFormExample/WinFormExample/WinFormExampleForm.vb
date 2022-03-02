Public Class WinFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        'Me.Text = "You have clicked the button"
        Me.Text = NameTextBox.Text
    End Sub

    Private Sub GoButton_KeyDown(sender As Object, e As KeyEventArgs) Handles GoButton.KeyDown
        Me.Text = e.KeyCode.ToString
    End Sub
End Class
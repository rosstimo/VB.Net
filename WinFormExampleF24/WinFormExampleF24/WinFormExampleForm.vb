Public Class WinFormExampleForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click
        Me.Text = ExampleTextBox.Text
    End Sub

    Private Sub WinFormExampleForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RadioButton1.Checked = True
        RadioButton6.Checked = True
        RadioButton9.Checked = True
    End Sub
End Class

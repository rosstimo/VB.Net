'header stuff

Option Strict On
Option Explicit On


Public Class ExampleForm


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        UserInputTextBox.Text = StrReverse(UserInputTextBox.Text)
    End Sub

End Class

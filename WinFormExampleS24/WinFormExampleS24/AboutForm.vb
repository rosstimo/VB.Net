Public Class AboutForm
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Hide()
        ExampleForm.Show()
    End Sub
End Class
Public Class AboutForm
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ExampleForm.Show()
        Me.Close()
    End Sub
End Class
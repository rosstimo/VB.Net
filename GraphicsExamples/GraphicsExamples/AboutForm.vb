Public Class AboutForm
    Private Sub AboutOKButton_Click(sender As Object, e As EventArgs) Handles AboutOKButton.Click
        GraphicsExamplesForm.Show()
        Me.Close()
    End Sub
End Class
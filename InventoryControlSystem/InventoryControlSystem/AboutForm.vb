Public Class AboutForm
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        InventoryControlForm.Show()
        Me.Close()
    End Sub
End Class
Public Class InventoryControlForm
    Sub SetDefaults()
        RadioButton4.Checked = True
    End Sub

    ' Event Handlers Below
    Private Sub InventoryControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

    End Sub
End Class

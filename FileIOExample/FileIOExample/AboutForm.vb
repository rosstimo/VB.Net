Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AboutLabel.Text = "File IO App" & vbCrLf &
                          vbCrLf &
                          "by Tim Rossiter" & vbCrLf &
                          vbCrLf &
                          "Apps -R- Us LLC." & vbCrLf &
                          "123 Wabbit Woad" & vbCrLf &
                          "Beverly Hills, CA 90210"
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.Close()
    End Sub
End Class
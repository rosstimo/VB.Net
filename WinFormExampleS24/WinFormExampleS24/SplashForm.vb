Public Class SplashForm
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        ExampleForm.Show()
        SplashTimer.Enabled = False
        Me.Close()
    End Sub
End Class
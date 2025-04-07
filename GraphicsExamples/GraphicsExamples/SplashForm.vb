Public Class SplashForm

    Private Sub SplashForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        GraphicsExamplesForm.Hide()
        SplashTimer.Enabled() = True
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashTimer.Enabled = False
        GraphicsExamplesForm.Show()
        Me.Close()
    End Sub

End Class
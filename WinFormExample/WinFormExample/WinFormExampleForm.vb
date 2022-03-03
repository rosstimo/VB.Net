Public Class WinFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        'Me.Text = "You have clicked the button"
        Me.Text = NameTextBox.Text
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "I'm loaded!!"
        RadioButton1.Checked = True

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        Select Case True
            Case RadioButton1.Checked
                GoButton.Enabled = False
            Case RadioButton2.Checked
                GoButton.Enabled = True
            Case Else
                MsgBox("something weird happened")
        End Select

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Select Case True
            Case RadioButton4.Checked
                PictureBox1.BackgroundImage = My.Resources.img_BLOG___Found_Kittens_C_19__4_
            Case RadioButton3.Checked
                PictureBox1.BackgroundImage = My.Resources.istockphoto_1208790371_612x612
            Case Else
                MsgBox("something weird happened")
        End Select
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class
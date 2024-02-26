'header stuff

Option Strict On
Option Explicit On


Public Class ExampleForm

    Sub SetDefaults()
        UserInputTextBox.Text = ""
        RadioButton1.Checked = True
        RadioButton6.Checked = True
        RadioButton9.Checked = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        UserInputTextBox.Focus()
    End Sub

    'Event Handlers Below Here

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        UserInputTextBox.Text = StrReverse(UserInputTextBox.Text)

    End Sub

    Private Sub ExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
End Class

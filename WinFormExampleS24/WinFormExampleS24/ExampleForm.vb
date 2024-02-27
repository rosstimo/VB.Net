'header stuff

Option Strict On
Option Explicit On


Public Class ExampleForm

    Sub SetDefaults()
        UserInputTextBox.Text = ""

        NoChangeRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        RemoveSpacesCheckBox.Checked = False
        LengthCheckBox.Checked = False

        UserInputTextBox.Focus()
    End Sub

    Sub ChangeString()

        Select Case True
            Case LowerCaseRadioButton.Checked
                UserInputTextBox.Text = LCase(UserInputTextBox.Text)
            Case UpperCaseRadioButton.Checked
                UserInputTextBox.Text = UCase(UserInputTextBox.Text)
        End Select

        If ReverseCheckBox.Checked Then
            UserInputTextBox.Text = StrReverse(UserInputTextBox.Text)
        End If

        If RemoveSpacesCheckBox.Checked Then
            UserInputTextBox.Text = UserInputTextBox.Text.Replace(" ", "")
        End If

        If LengthCheckBox.Checked Then
            MsgBox($"{UserInputTextBox.Text} has {Len(UserInputTextBox.Text)} characters!")
        End If

    End Sub

    Sub ValidateUserFields()
        'TODO
        '[ ] first can not be blank
        '[ ] last can not be blank
        '[ ] age can not be blank
        '[ ] age must be a posative whole number
        '[ ] age must be within range. valid range TBD
        '[ ] email optional. if given check if valid email


    End Sub

    'Event Handlers Below Here

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ChangeString()

    End Sub

    Private Sub ExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
End Class

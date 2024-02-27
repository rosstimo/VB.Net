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
        Dim age As Integer
        Dim message As String
        'TODO
        '[ ] first can not be blank
        '[ ] last can not be blank
        '[ ] age can not be blank
        '[ ] age must be a posative whole number
        '[ ] age must be within range. valid range TBD
        '[ ] email optional. if given check if valid email

        'validate names
        If FirstNameTextBox.Text = "" Then
            'MsgBox("First name is required!", MsgBoxStyle.Critical, "User Error, Bad User!!!")
            message &= "First name is required!" & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            'MsgBox("Last name is required!", MsgBoxStyle.Critical, "User Error, Bad User!!!")
            message &= "Last name is required!" & vbNewLine
        End If

        Try
            age = CInt(AgeTextBox.Text)
        Catch ex As Exception
            'MsgBox("Age must be a whole number!", MsgBoxStyle.Critical, "User Error, Bad User!!!")
            message &= "Age must be a whole number!" & vbNewLine
        End Try


        'Don't alert if no problem
        If message <> "" Then
            MsgBox(message, MsgBoxStyle.Critical, "User Error, Bad User!!!")
        End If

    End Sub

    'Event Handlers Below Here

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ChangeString()
        ValidateUserFields()
    End Sub

    Private Sub ExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub
End Class

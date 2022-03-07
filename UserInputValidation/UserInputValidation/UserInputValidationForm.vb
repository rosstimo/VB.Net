Public Class UserInputValidationForm

    Sub ValidateInput()
        Dim userAge As Integer

        'If AgeTextBox.Text = "" Then
        '    AccumulateMessages("Age is required")
        '    AgeTextBox.Focus()
        'End If

        Try
            userAge = CInt(AgeTextBox.Text)
        Catch ex As Exception
            AccumulateMessages("Age must be a number")
            AgeTextBox.Focus()
        End Try

        If LastNameTextBox.Text = "" Then
            AccumulateMessages("Last name is required")
            LastNameTextBox.Focus()
        End If

        If FirstNameTextBox.Text = "" Then
            AccumulateMessages("First name is required")
            FirstNameTextBox.Focus()
        End If

        If AccumulateMessages() <> "" Then
            MsgBox(AccumulateMessages())
            AccumulateMessages(, True)
        End If
    End Sub

    Private Function AccumulateMessages(Optional newMessage As String = "", Optional clear As Boolean = False) As String
        Static _message As String

        Select Case clear
            Case False
                If newMessage <> "" Then
                    _message &= newMessage & vbCrLf
                End If
            Case Else
                _message = ""
        End Select

        Return _message
    End Function

    Private Sub Reset()

        'reset all form controls to default
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        AgeTextBox.Text = ""
        ResultLabel.Text = ""
        'Clear any stored messages
        AccumulateMessages(, True)

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ValidateInput()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Reset()
    End Sub
End Class

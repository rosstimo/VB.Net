Public Class UserInputValidationForm

    Function ValidInput() As Boolean
        Dim userAge As Integer
        Dim valid As Boolean = True

        'If AgeTextBox.Text = "" Then
        '    AccumulateMessages("Age is required")
        '    AgeTextBox.Focus()
        'End If

        Try
            userAge = CInt(AgeTextBox.Text)
        Catch ex As Exception
            AccumulateMessages("Age must be a number")
            AgeTextBox.Focus()
            valid = False
        End Try

        If LastNameTextBox.Text = "" Then
            AccumulateMessages("Last name is required")
            LastNameTextBox.Focus()
            valid = False
        End If

        If FirstNameTextBox.Text = "" Then
            AccumulateMessages("First name is required")
            FirstNameTextBox.Focus()
            valid = False
        End If

        If AccumulateMessages() <> "" Then
            MsgBox(AccumulateMessages())
            AccumulateMessages(, True)
            valid = False
        End If

        Return valid
    End Function

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

    Private Function Summary(Optional addRecord As Boolean = True) As String
        Static _summary As String
        'Name: Elmer Fudd
        'Age: 42
        'email: Elmer.Fudd@Acme.com
        '--------------------------
        If addRecord Then
            _summary &= $"Name: {FirstNameTextBox.Text} {LastNameTextBox.Text}" & vbNewLine
            _summary &= $"Age: {AgeTextBox.Text}" & vbNewLine
            _summary &= $"email: {FirstNameTextBox.Text}.{LastNameTextBox.Text}@Acme.com" & vbNewLine
            _summary &= StrDup(50, "-") & vbNewLine
        End If

        Return _summary
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
        If ValidInput() Then
            'ResultLabel.Text = Summary()
            Summary()
            SummaryButton.Enabled = True
            Reset()
        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Reset()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        ResultLabel.Text = Summary(False)
    End Sub
End Class

'header stuff

Option Strict On
Option Explicit On


Public Class ExampleForm

    Sub ListExample()
        Dim names As New List(Of String)

        names.Add("Bob")
        names.Add("Mary")
        names.Add("Jim")
        names.Add("Billy")
        names.Add("Jane")
        names.Add("Jim")
        names.Add("Frank")
        names.Add("Sue")
        names.Add("Emily")

        Console.WriteLine(names.Count)

        names.Sort()
        names.Reverse()

        For Each _name In names
            Console.WriteLine(_name)

        Next

    End Sub

    Sub SetDefaults()
        'TODO
        '[ ] select 1st item in listbox
        '[ ] select the first item in combobox, or insert "Select" item
        UserInputTextBox.Text = ""
        NoChangeRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        RemoveSpacesCheckBox.Checked = False
        LengthCheckBox.Checked = False

        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        AgeTextBox.Text = ""
        EmailTextBox.Text = ""

        DisplayListBox.SelectedIndex = -1

        FirstNameTextBox.Focus()
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

    Function ValidateUserFields() As Boolean
        Dim age As UShort
        Dim message As String

        'TODO
        '[x] first can not be blank
        '[x] last can not be blank
        '[x] age can not be blank
        '[x] age must be a positive whole number
        '[x] age must be within range. valid range TBD
        '[ ] email optional. if given check if valid email
        '[ ] check for duplicate records

        'validate names
        If FirstNameTextBox.Text = "" Then
            message &= "First name is required!" & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            message &= "Last name is required!" & vbNewLine
        End If

        'validate age
        Try
            age = CUShort(AgeTextBox.Text)

            Select Case age
                Case 0 To 5
                    message &= "Did someone lose a kid?" & vbNewLine
                Case 6 To 17
                    message &= "Where are your parents?" & vbNewLine
                Case 18 To 65

                Case 66 To 100
                    message &= "Please check with you doctor before continuing" & vbNewLine
                Case >= 101
                    message &= "Wow! You old!!" & vbNewLine
            End Select

        Catch ex As Exception
            message &= "Age must be a whole number!" & vbNewLine
        End Try

        'Don't alert if no problem
        If message <> "" Then
            MsgBox(message, MsgBoxStyle.Critical, "User Error, Bad User!!!")
            Return False
        Else
            Return True
        End If

    End Function

    Sub AddToList()

        If ValidateUserFields() Then
            If DisplayListBox.Items.Contains(FirstNameTextBox.Text) Then 'TODO check for duplicate records in ValidateUserFields()

            Else
                DisplayListBox.Items.Add(FirstNameTextBox.Text)
                RecordsComboBox.Items.Add(FirstNameTextBox.Text)
            End If

        End If
    End Sub

    'Event Handlers Below Here

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ChangeString()
        'ValidateUserFields()
        AddToList()
        SetDefaults()
    End Sub

    Private Sub ExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
        'ListExample()
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        RecordsComboBox.SelectedIndex = DisplayListBox.SelectedIndex
    End Sub

    Private Sub RecordsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RecordsComboBox.SelectedIndexChanged
        DisplayListBox.SelectedIndex = RecordsComboBox.SelectedIndex
    End Sub
End Class

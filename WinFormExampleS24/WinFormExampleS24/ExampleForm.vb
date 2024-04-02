Option Strict On
Option Explicit On
'header stuff

Imports System.CodeDom.Compiler



'TODO
'[x]Add text boxes to match record data
'[ ]display records in nice columns within list box
'[ ]add filter options
'[ ]populate combo box based on filter selection
'[ ]update list box when combo box changes
'[ ]backup database file
'[ ]update database file
'[ ]add error.log file with debug switch


Public Class ExampleForm

    Dim customerData As New List(Of String)


    Sub SetDefaults()

        'SubmitButton.Enabled = False
        RecordsComboBox.Items.Add("~ Select All ~")
        UserInputTextBox.Text = ""
        NoChangeRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        RemoveSpacesCheckBox.Checked = False
        LengthCheckBox.Checked = False

        IDTextBox.Text = ""
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetTextBox.Text = ""
        CityTextBox.Text = ""
        ZipTextBox.Text = ""
        StateTextBox.Text = ""
        PhoneTextBox.Text = ""
        EmailTextBox.Text = ""

        DisplayListBox.SelectedIndex = -1

        FirstNameTextBox.Focus()
    End Sub

    Sub ChangeString()

        Select Case True
            Case LowerCaseRadioButton.Checked
                UserInputTextBox.Text = LCase(UserInputTextBox.Text)
            Case CityRadioButton.Checked
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
        '[x] check for valid phone
        '[ ] email optional. if given check if valid email
        '[ ] check for duplicate records, ID, phone, last name

        'validate names
        If FirstNameTextBox.Text = "" Then
            message &= "First name is required!" & vbNewLine
            FirstNameTextBox.BackColor = Color.LightYellow
        Else
            FirstNameTextBox.BackColor = Color.White
        End If

        If LastNameTextBox.Text = "" Then
            message &= "Last name is required!" & vbNewLine
            LastNameTextBox.BackColor = Color.LightYellow
        Else
            LastNameTextBox.BackColor = Color.White
        End If


        'Don't alert if no problem
        If message <> "" Then
            'MsgBox(message, MsgBoxStyle.Critical, "User Error, Bad User!!!")
            SubmitButton.Enabled = False
            Return False
        Else
            SubmitButton.Enabled = True
            Return True
        End If

    End Function

    Sub AddToList()
        Dim currentRecord As String
        currentRecord = $"{FirstNameTextBox.Text},{LastNameTextBox.Text},{StreetTextBox.Text},{CityTextBox.Text},{StateTextBox.Text},{ZipTextBox.Text},{EmailTextBox.Text},{PhoneTextBox.Text},{IDTextBox.Text},"

        If ValidateUserFields() Then
            Me.customerData.Add(currentRecord)
            'Display()
        End If

    End Sub

    Sub Display()
        'TODO
        '[ ] make pretty columns
        '[ ] add based on filter selection
        Dim temp() As String

        If RecordsComboBox.SelectedItem Is Nothing Then
            MsgBox("oops!!")
        Else
            Try
                DisplayListBox.Items.Clear()
                'RecordsComboBox.Items.Clear()
                For Each record In Me.customerData
                    temp = Split(record, ",")
                    If temp(3) = RecordsComboBox.SelectedItem.ToString Then
                        DisplayListBox.Items.Add(record)

                    End If
                    'RecordsComboBox.Items.Add(temp(1))
                Next
            Catch ex As Exception
                'log
            End Try

        End If


    End Sub

    Sub DisplayRecord(recordIndex As Integer)
        Dim temp() As String
        Try
            temp = Split(customerData(recordIndex), ",")
            IDTextBox.Text = temp(8)
            FirstNameTextBox.Text = temp(0)
            LastNameTextBox.Text = temp(1)
            StreetTextBox.Text = temp(2)
            CityTextBox.Text = temp(3)
            StateTextBox.Text = temp(4)
            ZipTextBox.Text = temp(5)
            EmailTextBox.Text = temp(6)
            PhoneTextBox.Text = temp(7)


        Catch ex As Exception
            'TODO write debug info to log file
        End Try

    End Sub

    Sub ReadCustomerDataBase()
        'TODO
        '[X] read data file into list
        '[ ] fix file path
        Dim currentRecord As String
        Dim temp As String
        Try
            FileOpen(1, "C:\Users\rosstimo\Documents\repos\VB.Net\ListsAndListBoxExample\ListsAndListBoxExample\QuickStopDB.txt", OpenMode.Input)

            Do Until EOF(1)
                For i = 1 To 10
                    Input(1, currentRecord)
                    temp &= currentRecord & ","

                Next
                'DisplayListBox.Items.Add(temp)
                Me.customerData.Add(temp)
                temp = ""
            Loop

            FileClose(1)
        Catch ex As Exception
            MsgBox(ex.StackTrace.ToString)
        End Try
    End Sub


    'Event Handlers Below Here
    Private Sub ExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadCustomerDataBase()
        SetDefaults()

    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click, SubmitTopMenuItem.Click, SubmitContextMenuItem.Click

        ChangeString()
        'ValidateUserFields()
        AddToList()
        Display()
        SetDefaults()
    End Sub


    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearTopMenuItem.Click, ClearContextMenuItem.Click
        SetDefaults()
        'ListExample()

        'OpenFileDialog.Filter = "image files|*.png;*.bmp;*.jpg;*.gif|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'OpenFileDialog.ShowDialog()

        'Me.Text = OpenFileDialog.FileName

        'Try
        '    FileOpen(1, OpenFileDialog.FileName, OpenMode.Input)

        '    Do Until EOF(1)
        '        Input(1, currentRecord)
        '        DisplayListBox.Items.Add(currentRecord)
        '    Loop

        '    FileClose(1)
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        'RecordsComboBox.SelectedIndex = DisplayListBox.SelectedIndex
        DisplayRecord(DisplayListBox.SelectedIndex)
    End Sub

    Private Sub RecordsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RecordsComboBox.SelectedIndexChanged
        'DisplayListBox.SelectedIndex = RecordsComboBox.SelectedIndex
        Display()
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles IDTextBox.Leave,
                                                                        FirstNameTextBox.Leave,
                                                                        LastNameTextBox.Leave, PhoneTextBox.Leave,
                                                                        StreetTextBox.Leave,
                                                                        CityTextBox.Leave,
                                                                        StateTextBox.Leave,
                                                                        ZipTextBox.Leave,
                                                                        EmailTextBox.Leave
        ValidateUserFields()
    End Sub

    Private Sub CityRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CityRadioButton.CheckedChanged
        Dim temp() As String
        If CityRadioButton.Checked Then
            For Each customerRecord In Me.customerData
                temp = Split(customerRecord, ",")
                If Not (RecordsComboBox.Items.Contains(temp(3))) Then
                    RecordsComboBox.Items.Add(temp(3))
                End If
            Next
            RecordsComboBox.Sorted = True
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class

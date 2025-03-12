' Header    

Option Explicit On
Option Strict On

Public Class WinFormExampleForm
    Sub SetDefaults()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeTextBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        WhiteSpaceCheckBox.Checked = False
        RandomCheckBox.Checked = False
        FirstTextBox.Focus()
        RemoveButton.Enabled = False
    End Sub

    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            FirstTextBox.Text = UCase(FirstTextBox.Text)
            LastTextBox.Text = UCase(LastTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            FirstTextBox.Text = LCase(FirstTextBox.Text)
            LastTextBox.Text = LCase(LastTextBox.Text)
        Else
            MsgBox($"Oh No! No Case Selected!")
        End If
    End Sub
    Sub SetFormat()
        If FirstLastRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " " & LastTextBox.Text
        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = $"{LastTextBox.Text},{FirstTextBox.Text}"
        Else
            MsgBox($"Oh No! No Format Selected!")
        End If
    End Sub

    Sub ReverseString()
        If ReverseCheckBox.Checked Then
            Me.Text = StrReverse(Me.Text)
        End If
    End Sub

    Sub RemoveWhiteSpace()
        If WhiteSpaceCheckBox.Checked Then
            Me.Text = Replace(Me.Text, " ", "")
        End If
    End Sub

    Function UserInputIsValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If IsNumeric(AgeTextBox.Text) = False Then
            valid = False
            AgeTextBox.Focus()
            message &= "Please enter a valid age." & vbNewLine
        End If

        If LastTextBox.Text = "" Then
            valid = False
            LastTextBox.Focus()
            message &= "Last name is required." & vbNewLine
        End If

        If FirstTextBox.Text = "" Then
            valid = False
            FirstTextBox.Focus()
            message &= "First name is require." & vbNewLine
        End If

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!!")
        End If

        Return valid
    End Function

    Function Scramble(thisString As String) As String
        Dim temp As String = ""
        Dim position As Integer
        Dim letters(Len(thisString) - 1) As String
        Dim count As Integer = 0

        If RandomCheckBox.Checked Then

            For i = 0 To UBound(letters)
                letters(i) = thisString(i)
            Next

            Do
                position = RandomNumberInRange(UBound(letters))
                If letters(position) <> "" Then
                    temp &= letters(position)
                    letters(position) = ""
                    count = count + 1
                End If
            Loop Until count >= Len(thisString)
        Else
            temp = thisString
        End If

        Return temp
    End Function

    Sub AddToList(thisString As String)
        DataListBox.Items.Add(thisString)
        DataComboBox.Items.Add(thisString)
    End Sub

    ''' <summary>
    ''' The default range is 0 - 10.
    ''' The maximum number must be greater than minimum number.
    ''' </summary>
    ''' <param name="max%"></param>
    ''' <param name="min%"></param>
    ''' <returns>Returns a random integer within a range defined by the max and min arguments.</returns>
    ''' <exception cref="System.ArgumentException">Thrown when <c>max > min</c></exception>
    Function RandomNumberInRange(Optional max% = 10%, Optional min% = 0%) As Integer
        Dim _max% = max - min
        If _max < 0 Then
            Throw New System.ArgumentException("Maximum number must be greater than minimum number")
        End If
        Randomize(DateTime.Now.Millisecond)
        Return CInt(System.Math.Floor(Rnd() * (_max + 1))) + min
    End Function

    'Event Handlers ***********************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Me.Text = "Forms Are Cool"
        If UserInputIsValid() Then
            FirstTextBox.Text = Scramble(FirstTextBox.Text)
            LastTextBox.Text = Scramble(LastTextBox.Text)
            SetCase()
            SetFormat()
            ReverseString()
            RemoveWhiteSpace()
            AddToList(Me.Text)
            SetDefaults()
        End If
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Me.Text = DataListBox.SelectedIndex.ToString
        If DataListBox.SelectedIndex = -1 Then
            RemoveButton.Enabled = False
        Else
            RemoveButton.Enabled = True
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        'Console.WriteLine($"The item at index {DataListBox.SelectedIndex} is {DataListBox.SelectedItem}!")
        DataListBox.Items.RemoveAt(DataListBox.SelectedIndex)
    End Sub

    Private Sub DataComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataComboBox.SelectedIndexChanged
        Me.Text = DataComboBox.SelectedIndex.ToString
    End Sub
End Class

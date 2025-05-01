Option Strict On
Option Explicit On
'header

Imports System.IO
Imports Microsoft.VisualBasic.Strings

Public Class SuperVideoStopForm

    Sub DisplayData()
        Dim _customers(,) As String = Customers()

        If _customers IsNot Nothing Then
            For i = 0 To _customers.GetUpperBound(0) 'UBound(_customers) 
                'DisplayListBox.Items.Add(_customers(i, 0))
                SelectComboBox.Items.Add($"{_customers(i, 1)}, {_customers(i, 0)}")


            Next

            SelectComboBox.Sorted = True
            SelectComboBox.SelectedIndex() = 0
        End If

    End Sub
    Sub DisplayFilterData()
        Dim _customers(,) As String = Customers()
        SelectComboBox.Items.Clear()
        'make sure the array has stuff
        If _customers IsNot Nothing Then
            'check every row
            For row = 0 To _customers.GetUpperBound(0)
                'check every column
                For column = 0 To _customers.GetUpperBound(1)
                    'search within string
                    If InStr(_customers(row, column), SearchTextBox.Text) > 0 Then

                        Select Case True
                            Case NameRadioButton.Checked
                                'don't add duplicates
                                If Not SelectComboBox.Items.Contains(_customers(row, 1)) Then
                                    SelectComboBox.Items.Add(_customers(row, 1))
                                End If
                            Case CityRadioButton.Checked
                                'don't add duplicates
                                If Not SelectComboBox.Items.Contains(_customers(row, 3)) Then
                                    SelectComboBox.Items.Add(_customers(row, 3))
                                End If
                            Case CustomerIDRadioButton.Checked
                                'don't add duplicates
                                If Not SelectComboBox.Items.Contains(_customers(row, 8)) Then
                                    SelectComboBox.Items.Add(_customers(row, 8))
                                End If
                        End Select

                    End If
                Next

                SelectComboBox.Sorted = True
                'if there are results select the first one
                If SelectComboBox.Items.Count >= 1 Then
                    SelectComboBox.SelectedIndex() = 0
                End If
            Next
        End If

    End Sub

    Sub FillListBox(searchColumn As Integer)
        Dim _customers(,) As String = Customers()
        DisplayListBox.Items.Clear()
        'make sure the array has stuff
        If _customers IsNot Nothing Then
            'check every row
            For row = 0 To _customers.GetUpperBound(0)
                If _customers(row, searchColumn) = SelectComboBox.SelectedItem.ToString() Then
                    DisplayListBox.Items.Add($"{(_customers(row, 1) & "," & _customers(row, 0)).PadRight(25)} {_customers(row, 3).PadRight(15)} ID#:{_customers(row, 8)} ")
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' Used to store the customer data array.
    ''' Update overwrites existing array.
    ''' </summary>
    ''' <param name="customerData"></param>
    ''' <returns>array of string</returns>
    Function Customers(Optional customerData(,) As String = Nothing) As String(,)
        Static _customers(,) As String

        If customerData IsNot Nothing Then
            _customers = customerData
        End If

        Return _customers
    End Function
    Sub ReadFromFile()
        Dim filePath As String = "..\..\UserData.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Dim temp() As String ' use for splitting customer data
        Dim currentID As Integer = 699
        Try
            FileOpen(fileNumber, filePath, OpenMode.Input)

            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord) ' read exactly one record

                If currentRecord <> "" Then 'ignore blank records
                    temp = Split(currentRecord, ",")

                    'DisplayListBox.Items.Add(currentRecord) 'add the record to the list box

                    If temp.Length = 4 Then ' ignore malformed records
                        temp(0) = Replace(temp(0), "$", "") 'clean first name
                DisplayListBox.Items.Add(temp(0))
                        WriteToFile(temp(0)) 'first name
                        WriteToFile(temp(1)) 'last name
                        WriteToFile("") 'place holder for street
                        WriteToFile(temp(2))  'City
                        WriteToFile("ID") 'state
                        WriteToFile("") 'zip
                        WriteToFile("") 'phone
                        WriteToFile(temp(3)) 'email
                        WriteToFile($"000631{currentID}", True) 'customer ID, add a new line at the last record for each customer
                        currentID += 1
                    End If


                End If
            Loop


            FileClose(fileNumber)
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)


        End Try

    End Sub

    Sub WriteToFile(newRecord As String, Optional insertNewLine As Boolean = False)
        Dim filePath As String = "..\..\CustomerData.txt"
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filePath, OpenMode.Append)
            Write(fileNumber, newRecord)
            If insertNewLine Then
                WriteLine(fileNumber)
            End If

            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox($"Error writing to {filePath}")
        End Try

    End Sub

    Sub LoadCustomerData()
        Dim filePath As String = "..\..\CustomerDataX.dat"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String
        Dim InvalidFileName As Boolean = True
        Dim _customers(NumberOfCustomers(filePath) - 1, 8) As String ' array for customer data
        Dim currentCustomer As Integer = 0

        Do
            Try
                FileOpen(fileNumber, filePath, OpenMode.Input)
                InvalidFileName = False
                Do Until EOF(fileNumber)
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 0) = currentRecord 'first name
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 1) = currentRecord 'last name
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 2) = currentRecord ' street
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 3) = currentRecord ' city    
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 4) = currentRecord ' state
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 5) = currentRecord ' zip
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 6) = currentRecord ' phone
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 7) = currentRecord ' email
                    Input(fileNumber, currentRecord)
                    _customers(currentCustomer, 8) = currentRecord ' customer ID
                    Input(fileNumber, currentRecord) 'empty, discard

                    currentCustomer += 1
                Loop
                FileClose(fileNumber)
                'MsgBox($"there are {NumberOfCustomers(filePath)} customers")
            Catch noFile As FileNotFoundException
                InvalidFileName = True
                OpenFileDialog.FileName = ""
                OpenFileDialog.InitialDirectory = "L:\github\VB.Net\SuperVideoStop\SuperVideoStop"
                OpenFileDialog.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*"
                OpenFileDialog.ShowDialog()
                filePath = OpenFileDialog.FileName
                MsgBox($"The current file is {filePath}")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Loop While InvalidFileName

        Customers(_customers) 'store in array function for later use
        FileNameStatusLabel.Text = filePath

    End Sub

    Function NumberOfCustomers(fileName As String) As Integer
        Dim count As Integer = 0
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                LineInput(fileNumber)
                count += 1
            Loop

            FileClose(fileNumber)
        Catch ex As Exception
            'pass
            'maybe set count to -1 to indicate error
        End Try

        Return count
    End Function

    Sub SetDefaults()
        NameRadioButton.Checked = True

    End Sub


    ' Event handlers below here ***********************************************

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'ReadFromFile()
        'DisplayData()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
        SetDefaults()
    End Sub

    Private Sub OpenTopMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTopMenuItem.Click
        LoadCustomerData()
    End Sub

    Private Sub SuperVideoStopForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCustomerData()
        DisplayData()
        SetDefaults()
    End Sub

    'TODO
    'treat combobox selection as filter
    'populate list box
    'listbox selection populate textboxes
    Private Sub SelectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectComboBox.SelectedIndexChanged
        Select Case True
            Case NameRadioButton.Checked
                FillListBox(1)
            Case CityRadioButton.Checked
                FillListBox(3)
            Case CustomerIDRadioButton.Checked
                FillListBox(8)
        End Select

    End Sub

    Sub FillTextBoxes()

        Dim temp() As String
        Dim _customers(,) As String = Customers()

        temp = Split(DisplayListBox.SelectedItem.ToString, "ID#:")

        temp(1) = temp(1).Trim() 'remove whitespace from both ends of string

        If _customers IsNot Nothing Then 'make sure the array has data
            For i = 0 To _customers.GetUpperBound(0) 'iterate through rows

                If temp(1) = _customers(i, 8) Then 'match id #
                    FirstNameTextBox.Text = _customers(i, 0)
                    LastNameTextBox.Text = _customers(i, 1)
                    StreetTextBox.Text = _customers(i, 2)
                    CityTextBox.Text = _customers(i, 3)
                    StateTextBox.Text = _customers(i, 4)
                    ZipTextBox.Text = _customers(i, 5)
                    PhoneTextBox.Text = _customers(i, 6)
                    EmailTextBox.Text = _customers(i, 7)
                    CustomerIDTextBox.Text = _customers(i, 8)



                End If

            Next
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DisplayFilterData()
    End Sub

    Private Sub FilterRadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles NameRadioButton.CheckedChanged, CityRadioButton.CheckedChanged, CustomerIDRadioButton.CheckedChanged
        DisplayFilterData()
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        FillTextBoxes()
    End Sub
End Class

'TODO 
'[ ] Add record
'[ ] Remove Record
'[ ] Update Record
Public Class InventoryControlForm

    Private inventoryItems As New List(Of String())
    Private fileName As String = "..\..\partsInventory.txt"

    Sub SetDefaults()
        RadioButton4.Checked = True
    End Sub

    Private Sub LoadInventoryFile()
        'Dim fileName As String = "..\..\partsInventory.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentField As String = ""
        Dim currentRecord() As String

        Try
            FileOpen(fileNumber, Me.fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                'For i = 0 To 6
                '    Input(fileNumber, currentField)
                '    currentRecord &= currentField & ","
                'Next
                'currentRecord = Split(LineInput(fileNumber), ",")

                currentRecord = Split(Replace(LineInput(fileNumber), Chr(34), ""), ",")
                'TODO eliminate last empty array element
                Me.inventoryItems.Add(currentRecord)
                'currentRecord = ""
            Loop
            FileClose(fileNumber)
        Catch ioException As IO.IOException
            With OpenFileDialog
                .Title = "Open File"
                .InitialDirectory = "..\..\"
                .FileName = ""
                .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                .FilterIndex = 1
                .RestoreDirectory = True
                .ShowDialog()
                'TODO check if user clicks OK or Cancel
                'then if OK update me.fileName
                Me.fileName = .FileName
            End With
        Catch ex As Exception



        End Try



    End Sub

    Private Function ValidateUserInput(Optional ByRef message As String = "") As Boolean
        Dim isValid As Boolean = True

        For Each _TextBox As TextBox In RecordInfoGroupBox.Controls.OfType(Of TextBox)()
            If isValid Then
                _TextBox.Focus()
            End If
            If _TextBox.Text = "" Then
                isValid = False
                message &= Replace($"{_TextBox.Name} is required{vbCrLf}", "TextBox", "")
            End If
        Next
        'MsgBox(message)
        Return isValid
    End Function

    Sub AppendRecordToFile(newRecord() As String, fileName As String) 'TODO pass record as array of strings, list could contain arrays or lists
        Dim fileNumber As Integer = FreeFile()
        'Dim temp() As String
        'temp = Split(newRecord, ",")

        Try
            FileOpen(fileNumber, fileName, OpenMode.Append)
            'iterate through the record array
            'append each field to the file
            'For Each field In temp
            '    Write(fileNumber, field)
            'Next
            WriteLine(fileNumber)
            Write(fileNumber, newRecord)
            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox("in file append, got: " & vbCrLf & ex.Message)
        End Try
    End Sub

    ' Event Handlers Below
    Private Sub InventoryControlForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
        LoadInventoryFile()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitTopMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click, UpdateTopMenuItem.Click, UpdateContextMenuItem.Click
        If ValidateUserInput() Then
            'inventoryItems.Add($"{"12345"},{DescriptionTextBox.Text},{PartNumberTextBox.Text},{LocationTextBox.Text},{VendorTextBox.Text},{ManufacturerTextBox.Text},{DataSheetTextBox.Text}")
            'TODO add record to file
            'back up file first use of the day
            'work with new file or temp file
            Dim temp() = {"54321", DescriptionTextBox.Text, PartNumberTextBox.Text, LocationTextBox.Text, VendorTextBox.Text, ManufacturerTextBox.Text, DataSheetTextBox.Text}
            Me.inventoryItems.Add(temp)
            AppendRecordToFile(inventoryItems.Last, "..\..\temp.txt")

        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearTopMenuItem.Click, ClearContextMenuItem.Click
        SetDefaults()
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub
End Class

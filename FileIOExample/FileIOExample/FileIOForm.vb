'see lecture notes pdf: https://elearn.isu.edu/moodle/pluginfile.php/2000753/mod_resource/content/0/Section%2010%20Topics.pdf
'see also https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/basics-of-net-framework-file-io-and-the-file-system
'https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/file-access
'FileOpen Depricated 
'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem?view=netframework-4.8#methods
'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.fileopen?view=netframework-4.8
'See current vb fileIO here:
'https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.fileio?view=netframework-4.8

Option Explicit On
Option Strict On
Option Compare Binary


'<Remarks>
'The FileOpen() functions allows for various file read/write options.
'FreeFile() returns the next available file number. It is used to refer to
'the to the file by the FileOpen function. File IO can throw a variety of 
'exceptions so Try/Catch Is used. Open file for input or read mode and 
'assigned a file number. Loop through all the records/lines until end of
'file or EOF().Input reads each record from File into currentRecord. The
'currentRecord is then added to the list box. Always close the file to
'avoid file In use IOException. Note: large files can be cumbersome when 
'the whole thing Is read into RAM. Options? Check target file size 
'attribute prior to read all and/or read one line at a time. Newer.NET
'file IO classes offer more efficient and elegant solutions.
'</Remarks>
Public Class FileIOForm

    Dim TempFileName As String = "TempFile.txt" '= My.Resources.TempFile_txt 'variable assignment not working at class level
    Dim TempArray() As String


    Private Sub WriteTestFile()
        'Dim myfile As My.Resources
        'Example from: https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.writeline?view=netframework-4.8
        ' Open file for output.
        FileOpen(1, "TestFile.txt", OpenMode.Output)
        ' Print text to the file. The quotation marks will be in the display.
        Write(1, "This is a test.")
        ' Go to the next line.
        WriteLine(1)
        ' Skip a line.
        WriteLine(1)
        ' Print in two print zones. You will see commas and quotation marks
        ' in the output file.
        WriteLine(1, "Zone 1", SPC(10), "Zone 2", "Zone 3", "Zone 4")
        ' Build a longer string before calling WriteLine.
        WriteLine(1, "Hello" & "  " & "World")
        ' Include five leading spaces.
        WriteLine(1, SPC(5), "Leading spaces")
        ' Print a word starting at column 10.
        WriteLine(1, TAB(10), "Hello")

        ' Assign Boolean and Date values.
        Dim aBool As Boolean
        Dim aDate As DateTime
        aBool = False
        aDate = DateTime.Parse("February 12, 1969")

        ' Dates and Booleans are translated using locale settings of 
        ' your system.
        WriteLine(1, aBool & " is a Boolean value.")
        WriteLine(1, aDate & " is a date.")
        ' Close the file.
        FileClose(1)

        ' Contents of TestFile.txt
        '"This is a test.",
        '
        '"Zone 1",          "Zone 2"
        '"Hello  World"
        '     "Leading spaces"
        '         ,"Hello"
        '"False is a Boolean value."
        '"2/12/1969 is a date."
    End Sub

    '<Remarks>
    'ReadFile() allows user to choose text file then reads file into TempArray
    '</Remarks>
    Private Sub ReadFile(ByVal fileName As String, ByRef recordData() As String)
        Dim currentRecord As String
        Dim fileData As String
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do While Not EOF(fileNumber)
                Input(fileNumber, currentRecord)
                'ListBox1.Items.Add(currentRecord)
                fileData &= currentRecord
            Loop
        Catch ex As Exception
            'TODO: user select file if it doesn't exist
            Console.WriteLine(ex.Message)
        Finally
            FileClose(fileNumber)
        End Try

        recordData = Split(fileData, "$$")

    End Sub

    Private Sub WriteFile(ByVal filename As String, newRecord As String)
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filename, OpenMode.Output)
            Write(fileNumber, newRecord)

        Catch ex As Exception
            'TODO: user select file if it doesn't exist
            'handle file in use exception
            'verify other possible exceptions           
        Finally
            FileClose(fileNumber)
        End Try

    End Sub

    Private Sub AppendFile(ByVal filename As String, newRecord As String)
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filename, OpenMode.Append)
            Write(fileNumber, newRecord)
            WriteLine(fileNumber)

        Catch ex As Exception
            'TODO: user select file if it doesn't exist
            'handle file in use exception
            'verify other possible exceptions           
        Finally
            FileClose(fileNumber)
        End Try

    End Sub

    '<Remarks>
    'Update display data in listbox from TempArray Class level array
    '</Remarks>
    Private Sub UpdateListBox(ByVal dataArray() As String)
        'TODO pass array as argument
        ListBox1.Items.Clear()

        For i = LBound(dataArray) To UBound(dataArray)
            ListBox1.Items.Add(dataArray(i))
        Next

    End Sub

    Private Sub LoadFile()




    End Sub

    Private Sub CreateTempFile()
        Kill(TempFileName)
        UpdateFile(TempFileName, TempArray)
    End Sub

    Private Sub UpdateFile(fileNameToBeUpdated As String, newData() As String)
        For currentRecord = LBound(newData) To UBound(newData)
            AppendFile(fileNameToBeUpdated, newData(currentRecord))
        Next
    End Sub

    Private Sub updateTextBoxes(index As Integer)
        Dim feildData() As String
        Try
            feildData = Split(TempArray(index), ",")
            FirstNameTextBox.Text = feildData(0)
            LastNameTextBox.Text = feildData(1)
            CityTextBox.Text = feildData(2)
            emailTextBox.Text = feildData(3)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub updateRecord(index As Integer)
        Try
            TempArray(index) = FirstNameTextBox.Text & "," & LastNameTextBox.Text & "," & CityTextBox.Text & "," & emailTextBox.Text
        Catch ex As Exception

        End Try

        CreateTempFile()
    End Sub

    'event handler subs below
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'MessageBox.Show("sender: " & sender.ToString & "e: " & Str(e))

        Me.Text = Str(ListBox1.SelectedIndex)

        'FirstNameTextBox.Text = TempArray(ListBox1.SelectedIndex)
        updateTextBoxes(ListBox1.SelectedIndex)
    End Sub

    Private Sub ReadFileButton_Click(sender As Object, e As EventArgs) Handles ReadFileButton.Click
        OpenFileDialog.ShowDialog()
        ReadFile(OpenFileDialog.FileName, TempArray)
        UpdateListBox(TempArray)
    End Sub

    Private Sub OverWriteButton_Click(sender As Object, e As EventArgs) Handles OverWriteButton.Click
        'WriteFile("TempFile.txt", "Start of file")
        'ListBoxTesting()
        ListBox1.Items.Insert(0, "Inserted Data")
    End Sub

    Private Sub AppendFileButton_Click(sender As Object, e As EventArgs) Handles AppendFileButton.Click
        'AppendFile("TestFile.txt", "Here is my extra data")
        'AppendFile("TempFile.txt", "$$" & FirstNameTextBox.Text & "," & LastNameTextBox.Text & "," & CityTextBox.Text & "," & StateTextBox.Text & "," & ZipTextBox.Text)
        ListBox1.Items.Add("added item" & DateTime.Now.ToString)
    End Sub

    Private Sub SaveFileButton_Click(sender As Object, e As EventArgs) Handles SaveFileButton.Click

        SaveFileDialog.DefaultExt = ".txt"
        SaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog.FileName = "MyFile " & DateTime.Now.Year & DateTime.Now.Month & DateTime.Now.Day
        'SaveFileDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) ' "%Downloads%"
        SaveFileDialog.ShowDialog()
        FileCopy(TempFileName, SaveFileDialog.FileName)

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        updateRecord(ListBox1.SelectedIndex)
        UpdateListBox(TempArray)
    End Sub

    Private Sub ExitProgram(sender As Object, e As EventArgs) Handles ExitButton.Click
        'WriteTestFile()
        'Me.Close()
        DataCrossWalk()
        'ShiftArray()
    End Sub


End Class


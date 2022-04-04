
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

    Private Sub WriteTestFile()

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

    Sub WriteFileExample()
        ' Open file for output.
        ' This will overwrite the contents of the file
        ' be careful....
        FileOpen(5, "TestFile.txt", OpenMode.Output)

        Write(5, "Hello, World!")
        Write(5, "Bob")
        Write(5, "Fred")
        Write(5, 7)
        Write(5, 43)
        Write(5, 3.14)

        FileClose(5)

    End Sub

    Sub AppendFileExample()
        ' Open file for append.
        ' This will add to the contents of the file
        FileOpen(5, "TestFile.txt", OpenMode.Append)

        Write(5, "Hello, World!")
        Write(5, "Bob")
        Write(5, "Fred")
        Write(5, 7)
        Write(5, 43)
        Write(5, 3.14)

        FileClose(5)

    End Sub

    Sub ReadFileExample()
        Dim currentRecord As String = "This will get written over ha ha ha..."

        Try
            FileOpen(3, "TestFile.txt", OpenMode.Input)
            Input(3, currentRecord)
            'currentRecord = LineInput(3)
            MsgBox(currentRecord)
            FileClose(3)
        Catch fileNotFound As IO.FileNotFoundException
            MsgBox("Sorry, that file doesn't exist")
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

    End Sub

    Sub ReadFile()
        Dim currentRecord As String

        Try
            FileOpen(3, "TestFile.txt", OpenMode.Input)

            Do Until EOF(3)
                Input(3, currentRecord)
                'MsgBox(currentRecord)
                ListBox1.Items.Add(currentRecord)
            Loop

            FileClose(3)

        Catch fileNotFound As IO.FileNotFoundException
            MsgBox("Sorry, that file doesn't exist")
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try

    End Sub

    Private Sub ExitProgram(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub OverWriteButton_Click(sender As Object, e As EventArgs) Handles OverWriteButton.Click
        'WriteTestFile()
        WriteFileExample()
        'AppendFileExample()
    End Sub

    Private Sub ReadFileButton_Click(sender As Object, e As EventArgs) Handles ReadFileButton.Click
        ReadFileExample()
        'ReadFile()
    End Sub
End Class

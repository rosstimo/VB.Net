Option Explicit On
Option Strict On
'header stuff
'File IO
'Spring 2025

Imports System.Runtime.Remoting.Channels

Module FileIO

    Sub Main()
        'WriteToFile()
        'AppendToFile()
        'ReadFromFile()
        DocExample()
        ReadAllRecords()
    End Sub

    Sub WriteToFile()
        'Openmode.Output
        'write to the file
        'if the file exists it overwrites existing data
        'if it does not exit it creates it
        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, "Wake Up Neo...")

        FileClose(1)

    End Sub

    Sub AppendToFile()
        'Openmode.Append
        'append to the end of file
        'if the file exists it keeps existing data
        'if it does not exit it creates it
        FileOpen(1, "MyCoolFile.txt", OpenMode.Append)

        For i = 1 To 10
            Write(1, "Follow The White Rabbit...")

        Next

        FileClose(1)
    End Sub

    Sub ReadFromFile()
        Dim currentRecord As String
        Dim fileName As String = "MyCoolFile.txt"
        'Try
        FileOpen(1, fileName, OpenMode.Input)

        'crashes if you read past end of file
        'For i = 1 To 12
        '    Input(1, currentRecord)
        '    Console.WriteLine(currentRecord)
        'Next

        Do Until EOF(1) 'EOF() returns True when there are no more records to read
            Input(1, currentRecord)
            Console.WriteLine(currentRecord)
        Loop

        FileClose(1)


        'Catch ex As Exception
        'MsgBox($"oops! looks like the file {fileName} does not exist...")
        ' End Try
    End Sub

    'see: https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.write?view=netframework-4.7.2&f1url=%3FappId%3DDev17IDEF1%26l%3DEN-US%26k%3Dk(Microsoft.VisualBasic.FileSystem.Write)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%253Dv4.7.2)%3Bk(DevLang-VB)%26rd%3Dtrue
    Sub DocExample()
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
        WriteLine(1, "Zone 1", SPC(10), "Zone 2")
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

    Sub ReadAllRecords()
        Dim currentRecord As String
        Dim count As Integer

        'Try
        FileOpen(1, "TestFile.txt", OpenMode.Input)
        Do Until EOF(1)
            count += 1
            Input(1, currentRecord)
            Console.WriteLine($"Record {CStr(count).PadLeft(3)} contains: {currentRecord}")
        Loop
        FileClose(1)
        'Catch ex As Exception

        ' End Try


    End Sub

End Module

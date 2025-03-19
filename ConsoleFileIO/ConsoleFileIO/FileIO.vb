'header stuff
'File IO
'Spring 2025

Option Explicit On
Option Strict On

Module FileIO

    Sub Main()
        'WriteToFile()
        'AppendToFile()
        ReadFromFile()
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

End Module

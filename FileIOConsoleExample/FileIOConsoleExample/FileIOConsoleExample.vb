Option Explicit On
Option Strict On
Imports System.IO

Module FileIOConsoleExample

    Sub Main()
        'WriteToFile()
        'For i = 0 To 10
        '    AppendToFile()
        'Next
        'AppendRecordsToFile()
        ' ImportCustomerData()
        'ReadRecordsFromFile("junk.txt")
        ReadRecordsFromFile("../../cleanfile.txt")
        Console.Read()
    End Sub

    'this sub will write to a file
    Sub WriteToFile()

        'open a file called test.txt then write "Follow the white rabbit..."
        FileOpen(1, "test.txt", OpenMode.Output)
        PrintLine(1, "Hello, Neo")
        FileClose(1)

    End Sub

    'append to the end of a file
    Sub AppendToFile()
        'open a file called test.txt then write "Follow the white rabbit..."
        FileOpen(1, "test.txt", OpenMode.Append)
        PrintLine(1, "Follow the white rabbit...")
        FileClose(1)
    End Sub

    Sub AppendRecordsToFile()

        FileOpen(1, "data.log", OpenMode.Append)
        Write(1, "this is a string")
        Write(1, 123)
        Write(1, True)
        Write(1, DateTime.Now)
        FileClose(1)
    End Sub

    'read all the records in and write to the console
    Sub ReadRecordsFromFile(fileName As String)
        Dim fileNumber As Integer = FreeFile()

        Dim currentRecord As String = ""
        Try
            FileOpen(fileNumber, fileName, OpenMode.Input)
            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord)
                Console.WriteLine(currentRecord)
            Loop
            FileClose(fileNumber)
        Catch notFound As System.IO.FileNotFoundException
            Console.WriteLine($"Sorry, the file {fileName} was not found")
        Catch ex As Exception
            fileNumber = FreeFile()
            FileOpen(fileNumber, "error.log", OpenMode.Append)
            Write(fileNumber, ex.GetBaseException)
            FileClose(fileNumber)
        End Try
    End Sub

    'read all the records in email.txt
    Sub ImportCustomerData()
        Dim fileName As String = "../../email.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Dim recordCount As Integer = 0
        Dim customerData() As String
        Dim cleanFileName As String = "../../" & DateTime.Now.ToString("yyyyMMddhhmmss") & ".txt"
        Dim badRecordCount As Integer = 0
        FileOpen(fileNumber, fileName, OpenMode.Input)
        Do Until EOF(fileNumber)
            'Input(fileNumber, currentRecord)
            currentRecord = LineInput(fileNumber)
            'clean extra double quotes
            currentRecord = Replace(currentRecord, Chr(34), "", 1, -1)
            'clean extra dollar signs
            currentRecord = Replace(currentRecord, "$", "", 1, -1)
            currentRecord = Replace(currentRecord, ChrW(&HA0), "", 1, -1)
            currentRecord = Replace(currentRecord, ChrW(&HC2), "", 1, -1)
            customerData = Split(currentRecord, ",")
            'TODO test array length before call to export
            If UBound(customerData) < 3 Then
                badRecordCount += 1
            Else
                ReDim Preserve customerData(3)
                If InStr(customerData(3), ChrW(&HA0)) > 0 Or InStr(customerData(3), ChrW(&HC2)) > 0 Then
                    Console.WriteLine($"customer {recordCount} may have bad data. See: {customerData(3)}")
                End If
                ExportCustomerData(customerData, cleanFileName)
            End If
            'Console.WriteLine(currentRecord)
            recordCount += 1
        Loop


        FileClose(fileNumber)
        Console.WriteLine("There are {0} records in {1}", recordCount, fileName)
        Console.Read()
    End Sub

    Sub ExportCustomerData(recordData() As String, fileName As String)
        Dim fileNumber As Integer = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Append)
        For i = LBound(recordData) To UBound(recordData)
            Write(fileNumber, recordData(i))
        Next
        WriteLine(fileNumber)
        FileClose(fileNumber)
    End Sub

End Module

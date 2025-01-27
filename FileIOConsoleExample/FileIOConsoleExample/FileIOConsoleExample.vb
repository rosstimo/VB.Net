Option Explicit On
Option Strict On
'see: https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualbasic.filesystem.writeline?view=netframework-4.8

Module FileIOConsoleExample

    Sub Main()
        Dim junk As String
        'WriteAsOutPut()
        'WriteAsOutPut()
        'WriteAsOutPut()
        'WriteAsOutPut()
        'AppendToExistingFile()
        'ReadOneRecordFromFile()
        'ReadAllRecordsFromFile()

        'For i = 0 To 254
        '    Console.WriteLine($"{i}: {ChrW(i)}")
        '    'junk &= $"{i}: {ChrW(i)}" & vbNewLine
        'Next
        'MsgBox(junk)
        ReadCustomerData()
        Console.Read()
    End Sub

    Sub WriteAsOutPut()
        'if file exists it gets overwritten... Destroyed!

        FileOpen(1, "S24Junk.txt", OpenMode.Output)
        For i = 1 To 10
            Write(1, "hello to my file")
        Next
        FileClose(1)

    End Sub

    Sub AppendToExistingFile()
        'append record to the end of an existing file
        'creates it if it does not exist
        FileOpen(1, "..\..\AppendMe.txt", OpenMode.Append)
        'Write(1, "Follow the white rabbit...")
        Write(1, False)
        Write(1, True)
        Write(1, DateTime.Now)
        Write(1, 42)
        Write(1, 0.12345)


        FileClose(1)

    End Sub

    Sub ReadOneRecordFromFile()
        Dim currentRecord As String
        Try

            FileOpen(1, "ShinyNewFile.txt", OpenMode.Input)
            Input(1, currentRecord)

            Console.WriteLine(currentRecord)
            FileClose(1)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    Sub ReadAllRecordsFromFile()
        Dim currentRecord As String
        Try

            FileOpen(1, "..\..\AppendMe.txt", OpenMode.Input) '"ShinyNewFile.txt"

            Do Until EOF(1)
                Input(1, currentRecord)
                Console.WriteLine(currentRecord)
            Loop

            FileClose(1)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    'TODO
    'write clean file
    'video stop customer data
    'add phone, street addr, customer ID number
    Sub ReadCustomerData()
        Dim currentRecord As String
        Dim firstName$, lastName$, city$, email$
        Dim temp() As String
        Dim customerID As Integer = 62000000

        Try
            FileOpen(1, "..\..\UserData.txt", OpenMode.Input)

            Do Until EOF(1)
                'Input(1, firstName)
                'Input(1, lastName)
                'Input(1, city)
                'Input(1, email)
                'Input(1, currentRecord)
                'Input(1, currentRecord)
                currentRecord = LineInput(1)
                'Console.Write($"Current Record: {currentRecord}")


                'read each line and parse fields manually
                temp = Split(currentRecord, ",")
                firstName = temp(0)
                lastName = temp(1)
                city = temp(2)
                email = temp(3)

                'clean name field
                temp = Split(firstName, "$$")
                firstName = temp(1)

                'clean lastName field
                lastName = Replace(lastName, Chr(34), "")
                lastName = Replace(lastName, Chr(160), "")
                lastName = Replace(lastName, Chr(194), "")

                'clean email field
                email = Replace(email, Chr(34), "")
                email = Replace(email, Chr(160), "")
                email = Replace(email, Chr(194), "")


                'If InStr(email, " ") > 0 Then
                '    MsgBox($"{email}, {Asc(" ")}")
                '    ' Asc(" ")
                'End If
                customerID += 1
                'first, last, street, city, state, zip, email, phone, customer ID#, current balance
                temp = {firstName, lastName, "", city, "", "", email, "", CStr(customerID), ""}
                AppendCustomerRecord("..\..\QuickStopDB.txt", temp)
                Console.WriteLine($"First Name: {firstName}")
                Console.WriteLine($"Last Name: {lastName}")
                Console.WriteLine($"City: {city}")
                Console.WriteLine($"Email: {email}")
                'Console.ReadLine()
            Loop

            FileClose(1)
        Catch ex As Exception

        End Try

    End Sub

    Sub AppendCustomerRecord(fileName As String, customerRecord() As String)
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, fileName, OpenMode.Append)
            For i = LBound(customerRecord) To UBound(customerRecord)
                Write(fileNumber, customerRecord(i))
            Next
            FileClose(fileNumber)
        Catch ex As Exception

        End Try

    End Sub

End Module

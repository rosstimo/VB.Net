Module OOPExampleF23

    Sub Main()

        Dim personOne As New Person("Billy", 45)
        Dim student As New Student("Sally", 21)

        Console.WriteLine(personOne.Name)

        Console.WriteLine(student.Name)
        Console.WriteLine(student.Age)
        Console.WriteLine(student.idNumber)


        Console.Read()
    End Sub

    Class Person
        Public Name As String
        Public Age As Integer
        Public Sub New(ByVal Name As String, ByVal Age As Integer)
            Me.Name = Name
            Me.Age = Age
        End Sub
    End Class

    Class Student
        Inherits Person
        Public idNumber As String

        Public Sub New(name As String, age As Integer)
            MyBase.New(name, age)
            Me.idNumber = "123456789"
        End Sub

    End Class


End Module

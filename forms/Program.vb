Imports System

Module Program
    Sub Main(args As String())
        Dim firstName As String
        Dim lastName As String
        Dim age As Integer
        Dim email As String

        Console.WriteLine("=== Student Registration Form ===")
        
        Console.Write("Enter First Name: ")
        firstName = Console.ReadLine()

        Console.Write("Enter Last Name: ")
        lastName = Console.ReadLine()

        Console.Write("Enter Age: ")
        age = Convert.ToInt32(Console.ReadLine())

        Console.Write("Enter Email: ")
        email = Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine("=== Registration Successful ===")
        Console.WriteLine("Name: " & firstName & " " & lastName)
        Console.WriteLine("Age: " & age)
        Console.WriteLine("Email: " & email)
    End Sub
End Module

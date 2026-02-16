Module Program
    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim sum As Integer

        Console.WriteLine("Enter num1: ")
        num1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter num2: ")
        num2 = Convert.ToInt32(Console.ReadLine())

        sum = num1 + num2
        Console.WriteLine("The sum of " & num1 & " and " & num2 & " is " & sum)
    End Sub
End Module

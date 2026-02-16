Module Program
Sub main()
Dim num1 as Integer
Dim num2 as Integer
Dim sum as Integer

num1 = 5
num2 = 5
sum = num1 + num2

    If sum > 10 Then
        Console.WriteLine("Sum is greater than 10")
    ElseIf sum < 10 Then
        Console.WriteLine("Sum is less than 10")
    Else
        Console.WriteLine("The sum of " & num1 & " and " & num2 & " is " & sum)
    End If
End Sub
End Module
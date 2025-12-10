Module Module1

    Sub Main()
        Dim firstNumber, secondNumber, thirdNumber As Double
        Console.WriteLine("SOFTWARE TO FIND HIGHEST OF THREE NUMBER")
        Console.WriteLine("----------------------------------")

        Console.WriteLine("ENTER FIRST NUMBER")
        firstNumber = Console.ReadLine()
        Console.WriteLine("----------------------------------")

        Console.WriteLine("ENTER SECOND NUMBER")
        secondNumber = Console.ReadLine()
        Console.WriteLine("----------------------------------")

        Console.WriteLine("ENTER THIRD NUMBER")
        thirdNumber = Console.ReadLine()
        Console.WriteLine("----------------------------------")

        If (firstNumber > secondNumber) And (firstNumber > thirdNumber) Then
            Console.WriteLine(firstNumber.ToString & " is the highest number")

        ElseIf (secondNumber > firstNumber) And (secondNumber > thirdNumber) Then
            Console.WriteLine(secondNumber.ToString & " is the highest number")

        ElseIf (thirdNumber > firstNumber) And (thirdNumber > secondNumber) Then
            Console.WriteLine(thirdNumber.ToString & " is the highest number")
        Else
            Console.WriteLine(" All Number are the same ")
        End If

        Console.ReadLine()
    End Sub

End Module

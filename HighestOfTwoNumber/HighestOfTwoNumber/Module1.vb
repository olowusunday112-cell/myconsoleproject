Module Module1

    Sub Main()
        Dim fristNumber, secondNumber As Double
        Console.WriteLine("SOFTWARE TO FIND HIGHEST TWO NUMBER")
        Console.WriteLine("ENTER  FIRST NUMBER ")
        fristNumber = Console.ReadLine()
        Console.WriteLine(" ENTER SECOND NUMBER ")
        secondNumber = Console.ReadLine()
        If (fristNumber > secondNumber) Then

            Console.WriteLine(fristNumber.ToString & " Is the Highest Number")
        Else
            Console.WriteLine(secondNumber.ToString & " Is the Highest Number")
        End If
        Console.ReadLine()
    End Sub

End Module

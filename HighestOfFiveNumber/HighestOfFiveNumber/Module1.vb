Module Module1

    Sub Main()
        Dim firstNumber, secondNumber, thirdNumber, fourthNUmber, fifthNumber As Double
        Console.WriteLine("SOFTWARE TO FIND HIGHEST OF FIVE NUMBER")
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

        Console.WriteLine("ENTER FOURTH NUMBER")
        fourthNUmber = Console.ReadLine()
        Console.WriteLine("----------------------------------")

        Console.WriteLine("ENTER FIFTH NUMBER")
        fifthNumber = Console.ReadLine()
        Console.WriteLine("----------------------------------")


        If (firstNumber > secondNumber) And (firstNumber > thirdNumber) And (firstNumber > fourthNUmber) And (firstNumber > fifthNumber) Then
            Console.WriteLine(firstNumber.ToString & " is the highest number")

        ElseIf (secondNumber > firstNumber) And (secondNumber > thirdNumber) And (secondNumber > fourthNUmber) And (secondNumber > fifthNumber) Then
            Console.WriteLine(secondNumber.ToString & " is the highest number")

        ElseIf (thirdNumber > firstNumber) And (thirdNumber > secondNumber) And (thirdNumber > fourthNUmber) And (thirdNumber > fifthNumber) Then
            Console.WriteLine(thirdNumber.ToString & " is the highest number")

        ElseIf (fourthNUmber > firstNumber) And (fourthNUmber > secondNumber) And (fourthNUmber > thirdNumber) And (fourthNUmber > fifthNumber) Then
            Console.WriteLine(fourthNUmber.ToString & " is the highest number")

        ElseIf (fifthNumber > firstNumber) And (fifthNumber > secondNumber) And (fifthNumber > thirdNumber) And (fifthNumber > fourthNUmber) Then
            Console.WriteLine(fifthNumber.ToString & " is the highest number")

        Else
            Console.WriteLine(" All Number are the same ")
        End If

        Console.ReadLine()
    End Sub

End Module

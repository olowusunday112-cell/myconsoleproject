Module Module1

    Sub Main()
        Dim firstNumber, secondNumber, answer As Double
        Dim op As Integer

        Console.WriteLine("SIMPLE CALCULATOR")
        Console.WriteLine("-------------------")

        Console.WriteLine("ENTER FIRST NUMBER")
        firstNumber = Console.ReadLine()
        Console.WriteLine("-------------------")

        Console.WriteLine("FOR ADDITION PRESS 1")
        Console.WriteLine("------------------------")
        Console.WriteLine("FOR MULTIPLICATION PRESS 2")
        Console.WriteLine("------------------------")
        Console.WriteLine("FOR SUBTRACTION PRESS 3")
        Console.WriteLine("------------------------")
        Console.WriteLine("FOR DIVISON PRESS 4")
        Console.WriteLine("------------------------")


        op = Console.ReadLine()
        Console.WriteLine("------------------------")

       
        Console.WriteLine("ENTER SECOND NUMBER")
        secondNumber = Console.ReadLine()
        Console.WriteLine("-------------------")

        answer = MyFunction.simplecal(firstNumber, op, secondNumber)

        If (answer = 0) Then
            Console.WriteLine("ERROR!, KINDLY FOLLOW THE INSTUCTION")
        Else

            Console.WriteLine("RESULT IS " & answer)
        End If
        If (secondNumber = 0) Then
            Console.WriteLine("CAN'T BE DIVIDED BY 0")
        End If

        Console.ReadLine()

    End Sub

End Module


Module Module1


    Sub Main()
        Dim firstNumber, secondNumber, sum, diffrence, product, division As Double
        Dim choice As Integer

        Console.WriteLine("SIMPLE CALCULATOR FOR TWO NUMBERS ")
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER YOUR FIRST NUMBER ")
        firstNumber = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER 1 TO CALCULATE SUM")
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER 2 TO CALCULATE DIFFRENCE ")
        Console.WriteLine("---------------------------------------")


        Console.WriteLine("ENTER 3 TO CALCULATE PRODUCT ")
        Console.WriteLine("---------------------------------------")


        Console.WriteLine("ENTER 4 TO CALCULATE DIVISION ")
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER YOUR CHOICE")
        choice = Console.ReadLine
        If (choice < 1) Or (choice > 4) Then
            Console.WriteLine("invalid choice:please enter 1,2,3,4 only ")
        Else
            Console.WriteLine("ENTER YOUR SECOND NUMBER")
            secondNumber = Console.ReadLine
            Console.WriteLine("---------------------------------------")


            If (choice = 1) Then
                sum = firstNumber + secondNumber
                Console.WriteLine("SUM IS " & sum.ToString)

            ElseIf (choice = 2) Then
                diffrence = firstNumber - secondNumber
                Console.WriteLine("DIFFRENCE IS " & diffrence.ToString)

            ElseIf (choice = 3) Then
                product = firstNumber * secondNumber
                Console.WriteLine("PRODUCT IS " & product.ToString)

            ElseIf (choice = 4) Then
                division = firstNumber / secondNumber

                If (secondNumber = 0) Then
                    Console.WriteLine("CAN'T BE DIVIDED BY 0")
                Else
                    Console.WriteLine("DIVISION IS " & division.ToString)
                End If
            Else
            End If
        End If


        Console.ReadLine()


    End Sub

End Module

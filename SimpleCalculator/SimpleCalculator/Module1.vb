Module Module1

    Sub Main()
        Dim firstNumber, secondNumber, sum, product, division, difference As Double
        Dim choice As String

        Console.WriteLine("SIMPLE CALCULATOR OF TWO NUMBER")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("ENTER YOUR FIRST NUMBER")
        firstNumber = Console.Read()
        Console.WriteLine("--------------------------------")

        Console.WriteLine("ENTER 1 TO CALCULATE SUM")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("ENTER 2 TO CALCULATE PRODUCT")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("ENTER 3 TO CALCULATE DIVISION")
        Console.WriteLine("--------------------------------")

        Console.WriteLine("ENTER 4 TO CALCULATE DIFFERENCE")
        Console.WriteLine("---------------------------------")

        Console.WriteLine("ENTER YOUR CHOICE")
        choice = Console.ReadLine()

        If (choice < 1) Or (choice > 4) Then
            Console.WriteLine("Invalid choice: please enter 1, 2, 3, 4, Only")
        Else
            Console.WriteLine("ENTER YOUR SECOND NUMBER")
            secondNumber = Console.ReadLine()
            Console.WriteLine("------------------------------")
            If (choice = 1) Then
                sum = firstNumber + secondNumber
                Console.WriteLine("SUM IS " & sum.ToString)

            ElseIf (choice = 2) Then
                product = firstNumber * secondNumber
                Console.WriteLine("PRODUCT IS " & product.ToString)

            ElseIf (choice = 3) Then
                division = firstNumber / secondNumber
                If (secondNumber = 0) Then
                    Console.WriteLine("CAN'T BE DIVIDED BY 0")
                Else
                    Console.WriteLine("DIVISION IS " & division.ToString)

                    elseif (choice = 4) then
                    difference = firstNumber - secondNumber
                    Console.WriteLine("DIFFERENCE IS " & difference.ToString)

                End If
            Else
            End If
        End If
        End


        Console.ReadLine()

    End Sub

End Module

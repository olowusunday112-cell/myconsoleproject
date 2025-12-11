Module Module1



        Sub Main()

        Dim loanAmount, loanDuration, fixedInterest As String
        Dim monthlyRepayment, monthlyInterest(6), monthlyTotal(6), totalInterest, totalRepayment, amount, duration As Double
        Dim again As String = "yes"
        While again.ToLower() = "yes"

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("LOAN APP CALCULATOR")
            Console.ResetColor()
            Console.WriteLine("------------------------")


            Console.WriteLine(" ENTER YOUR LOAN AMOUNT ")
            loanAmount = Console.ReadLine()
            amount = Val(loanAmount)
           
            If amount <= 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("ERROR!!! Loan amount must be greater than 0")
                Console.ResetColor()
                Continue While
            End If
            Console.WriteLine("------------------------")


            Console.WriteLine(" ENTER YOUR LOAN DURATION ")
            loanDuration = Console.ReadLine()
            duration = Val(loanDuration)
            If duration <= 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("ERROR!!! Duration must be greater than 0")
                Console.ResetColor()
                Continue While
            End If
            Console.WriteLine("----------------------")


            fixedInterest = 1.5


            monthlyRepayment = amount / duration
            Console.WriteLine("MONTHLY REPAYMENT (NO INTEREST): " & monthlyRepayment.ToString("N"))
            Console.WriteLine()

            Dim balance As Double = amount

            For i As Integer = 1 To 6
                monthlyInterest(i) = balance * fixedInterest / 100
                monthlyTotal(i) = monthlyRepayment + monthlyInterest(i)
                balance -= monthlyRepayment
            Next

            For i As Integer = 1 To 6
                Console.WriteLine("MONTH " & i & "INTEREST: " & monthlyInterest(i).ToString("N"))
            Next
            Console.WriteLine()

            For i As Integer = 1 To 6
                totalInterest += monthlyInterest(i)
            Next

            Console.WriteLine("TOTAL INTEREST (6 MONTHS): " & totalInterest.ToString("N"))
            Console.WriteLine()

            For i As Integer = 1 To 6
                totalRepayment += monthlyTotal(i)
            Next

            Console.WriteLine("TOTAL REPAYMENT (6 MONTHS): " & totalRepayment.ToString("N"))
            Console.ReadLine()

            Console.WriteLine("Do you want to calculate another loan? (y / n)")
            again = Console.ReadLine()
        End While
        Console.WriteLine("THANK YOU FOR USING 4REAL LOAN APP CALCULATOR.")
        Console.ReadLine()










    End Sub

    End Module




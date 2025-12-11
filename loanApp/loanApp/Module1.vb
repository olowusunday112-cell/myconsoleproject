Module Module1



    Sub Main()
        '------------------------------------------
        '           SECURITY PASSWORD
        '-------------------------------------------
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("----------------------------------------------------------------")
        Console.WriteLine("=         ENTER 4REAL SECURITY PASSWORD         =")
        Console.WriteLine("----------------------------------------------------------------")
        Console.ResetColor()

SecurityCheck:
        Console.Write("= PASSWORD: ")
        Dim pass As String = Console.ReadLine()

        If pass <> "1234" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("--------------------------------------------")

            Console.WriteLine("=        ACCESS DENIED – WRONG CODE       =")
            Console.WriteLine("-------------------------------------------")
            Console.ResetColor()
            Console.WriteLine()
            GoTo SecurityCheck
        End If

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("----------------------------------------------------------------")
        Console.WriteLine("     ACCESS GRANTED – WELCOME TO 4REAL LOAN APP      ")
        Console.WriteLine("-----------------------------------------------------------------")
        Console.ResetColor()
        Console.WriteLine()
        '===========================================
        Dim loanAmount, loanDuration, fixedInterest As String
        Dim monthlyRepayment, monthlyInterest(6), monthlyTotal(6), totalInterest, totalRepayment, amount, duration As Double
        Dim again As String = "y"
        While again.ToLower() = "y"


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


            Console.WriteLine(" ENTER YOUR LOAN DURATION (MONTHS) ")
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
            Console.WriteLine("MONTHLY REPAYMENT (NO INTEREST): " & monthlyRepayment.ToString("N2"))
            Console.WriteLine()

            Dim balance As Double = amount

            For i As Integer = 1 To duration

                monthlyInterest(i) = balance * fixedInterest / 100
                monthlyTotal(i) = monthlyRepayment + monthlyInterest(i)
                balance -= monthlyRepayment
            Next
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("{0, -10} {1, -20} {2, -20}{3, -20}", "Month", "Monthly Repayment", "Interest", "Total Payment")
            Console.WriteLine(New String("-", 70))
            Console.ResetColor()

            For i As Integer = 1 To duration
                Console.WriteLine("{0, -10}{1, -20:N2}{2, -20:N2}{3,-20:N2}", i, monthlyRepayment, monthlyInterest(i), monthlyTotal(i))
            Next
            Console.WriteLine(New String("-", 70))

            For i As Integer = 1 To duration
                totalInterest += monthlyInterest(i)
            Next

            Console.WriteLine("TOTAL INTEREST (6 MONTHS): " & totalInterest.ToString("N2"))
            Console.WriteLine()

            For i As Integer = 1 To duration
                totalRepayment += monthlyTotal(i)
            Next

            Console.WriteLine("TOTAL REPAYMENT ( " & duration & "MONTHS) : " & totalRepayment.ToString("N"))
            Console.WriteLine()

            Console.WriteLine("Do you want to calculate another loan? (y / n)")
            again = Console.ReadLine()
        End While
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("THANK YOU FOR USING 4REAL LOAN APP CALCULATOR.")
        Console.ResetColor()
        Console.ReadLine()










    End Sub

End Module




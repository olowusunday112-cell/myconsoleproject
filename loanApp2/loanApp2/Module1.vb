
Module module1
    Sub Main()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("----------------------------------------------------------------")
        Console.WriteLine("      WELCOME TO 4REAL GLOBAL LOAN APPLICATION      ")
        Console.WriteLine("-----------------------------------------------------------------")
        Console.ResetColor()
        Console.WriteLine()
        '===========================================
        Dim loanAmount, loanDuration, fixedInterest As Double
        Dim monthlyRepayment, monthlyInterest, monthlyTotal, totalInterest, totalRepayment, duration, balance As Double
        Dim again As String = "y"
        While again.ToLower() = "y"
            totalInterest = 0
            totalRepayment = 0

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("LOAN APP CALCULATOR")
            Console.ResetColor()
            Console.WriteLine("------------------------")


            Console.WriteLine("ENTER YOUR LOAN AMOUNT ")
            loanAmount = Console.ReadLine()
            If (loanAmount <= 0) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("ERROR!!! Loan amount must be greater than 0")
                Console.ResetColor()
                Console.WriteLine()
                Console.WriteLine("------------------------")
                Continue While
            End If
            Console.WriteLine("------------------------")


            Console.WriteLine("ENTER YOUR LOAN DURATION (MONTHS) ")
            loanDuration = Console.ReadLine()
            'duration = Val(loanDuration)
            If (loanDuration <= 0) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("ERROR!!! Duration must not be greater 0")
                Console.ResetColor()
                Continue While
            End If
            Console.WriteLine("----------------------")

            fixedInterest = 1.5
            monthlyRepayment = loanAmount / loanDuration
            balance = loanAmount

            Console.WriteLine()

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("{0, -15} {1, 20} {2, 20}{3, 25}", "Month", "Monthly Repayment", "Monthly Interest", "Total Monthly Payment")
            Console.ResetColor()
            Console.WriteLine(New String("-", 85))

            For months As Integer = 1 To loanDuration
                monthlyInterest = balance * (fixedInterest / 100)
                totalInterest += monthlyInterest
                monthlyTotal = monthlyRepayment + monthlyInterest
                totalRepayment += monthlyTotal
                balance -= monthlyRepayment

                Console.WriteLine("{0, -15}{1, 20:N2}{2, 20:N2}{3,25:N2}", months, monthlyRepayment, monthlyInterest, monthlyTotal)
            Next

            Console.WriteLine(New String("-", 85))
           
            Console.WriteLine("TOTAL LOAN " & loanAmount.ToString("N2"))
            Console.WriteLine()
            Console.WriteLine("TOTAL INTEREST :(" & duration & "MONTHS): " & totalInterest.ToString("N2"))
            Console.WriteLine()
            Console.WriteLine("TOTAL REPAYMENT (" & duration & "MONTHS) : " & totalRepayment.ToString("N"))
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





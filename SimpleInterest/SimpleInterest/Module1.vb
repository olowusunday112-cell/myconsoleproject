Module Module1

    Sub Main()
        Dim principal, rate, time, a, simpleInterest As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE SIMPLE INTEREST")
        Console.WriteLine("ENTER VALUE FOR PRINCIPAL(P)")
        principal = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR RATE(R)")
        Rate = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR TIME(T)")
        time = Console.ReadLine()
        a = principal * rate * time
        simpleInterest = a / 100
        Console.WriteLine("THE RESULT FOR SIMPLE INTEREST IS " + simpleInterest.ToString("N"))






        Console.ReadLine()

    End Sub

End Module

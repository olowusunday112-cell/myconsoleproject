Module Module1

    Sub Main()

        Dim P1, V1, P2, V2 As Double
        Dim missing As String

        Console.WriteLine("THIS SOFTWARE CALCULATES BOYLE'S LAW")
        Console.WriteLine("FORMULA: P1 * V1 = P2 * V2")
        Console.WriteLine()
        Console.WriteLine("Which value is missing? (P1, V1, P2, V2)")
        missing = Console.ReadLine().ToUpper()

        Console.WriteLine("Enter value for P1 (enter 0 if missing):")
        P1 = Console.ReadLine()

        Console.WriteLine("Enter value for V1 (enter 0 if missing):")
        V1 = Console.ReadLine()

        Console.WriteLine("Enter value for P2 (enter 0 if missing):")
        P2 = Console.ReadLine()

        Console.WriteLine("Enter value for V2 (enter 0 if missing):")
        V2 = Console.ReadLine()


        If missing = "P1" Then
            P1 = (P2 * V2) / V1
            Console.WriteLine("P1 = " & P1.ToString("N"))
        ElseIf missing = "V1" Then
            V1 = (P2 * V2) / P1
            Console.WriteLine("V1 = " & V1.ToString("N"))
        ElseIf missing = "P2" Then
            P2 = (P1 * V1) / V2
            Console.WriteLine("P2 = " & P2.ToString("N"))
        ElseIf missing = "V2" Then
            V2 = (P1 * V1) / P2
            Console.WriteLine("V2 = " & V2.ToString("N"))
        Else
            Console.WriteLine("Invalid input.")
        End If

        Console.ReadLine()
    End Sub

End Module

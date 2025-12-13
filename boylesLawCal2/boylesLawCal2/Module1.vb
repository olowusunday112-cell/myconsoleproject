Module Module1
    Sub Main()

        Dim P1, V1, P2, V2 As Double
        Dim again As String
        Dim missing As String

StartAgain:

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("===============================================================")
        Console.WriteLine("                 BOYLE'S LAW CALCULATOR                    ")
        Console.WriteLine("                  ( P1 * V1 = P2 * V2 )                  ")
        Console.WriteLine("===============================================================")
        Console.ResetColor()

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Enter the missing variable (P1, V1, P2, V2): ")
        missing = Console.ReadLine().ToUpper()
        Console.ResetColor()

        If missing <> "P1" And missing <> "V1" And missing <> "P2" And missing <> "V2" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("= ERROR: Invalid Option =")
            Console.ResetColor()
            GoTo StartAgain
        End If

        Console.WriteLine()
        Console.WriteLine("NOTE: Enter 0 for the unknown variable")

        Console.Write("Enter P1: ") : P1 = Val(Console.ReadLine())
        Console.Write("Enter V1: ") : V1 = Val(Console.ReadLine())
        Console.Write("Enter P2: ") : P2 = Val(Console.ReadLine())
        Console.Write("Enter V2: ") : V2 = Val(Console.ReadLine())

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("------------------- RESULT -------------------")
        Console.ResetColor()

        If missing = "P1" Then
            If V1 = 0 Then
                ErrorDisplay("V1 cannot be zero")
                GoTo StartAgain
            End If
            P1 = (P2 * V2) / V1
            Success("P1 = " & P1)
        ElseIf missing = "V1" Then
            If P1 = 0 Then
                ErrorDisplay("P1 cannot be zero")
                GoTo StartAgain
            End If
            V1 = (P2 * V2) / P1
            Success("V1 = " & V1)
        ElseIf missing = "P2" Then
            If V2 = 0 Then
                ErrorDisplay("V2 cannot be zero")
                GoTo StartAgain
            End If
            P2 = (P1 * V1) / V2
            Success("P2 = " & P2)
        ElseIf missing = "V2" Then
            If P2 = 0 Then
                ErrorDisplay("P2 cannot be zero")
                GoTo StartAgain
            End If
            V2 = (P1 * V1) / P2
            Success("V2 = " & V2)
        End If

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("Do you want to calculate again? (YES/NO): ")
        again = Console.ReadLine().ToUpper()
        Console.ResetColor()

        If again = "YES" Then
            GoTo StartAgain
        End If

    End Sub

    Sub Success(ByVal msg As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("= " & msg & " =")
        Console.ResetColor()
    End Sub

    Sub ErrorDisplay(ByVal msg As String)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("= ERROR: " & msg & " =")
        Console.ResetColor()
    End Sub

End Module
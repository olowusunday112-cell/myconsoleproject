Module Module1

    Sub Main()
        Dim femi, pella, sunday As Double
        Console.WriteLine("")
        Console.ReadLine()
        '===========================================
        '           SECURITY PASSWORD
        '===========================================
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("===========================================")
        Console.WriteLine("=         ENTER SECURITY PASSWORD         =")
        Console.WriteLine("===========================================")
        Console.ResetColor()

SecurityCheck:
        Console.Write("= PASSWORD: ")
        Dim pass As String = Console.ReadLine()

        If pass <> "1234" Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("===========================================")
            Console.WriteLine("=        ACCESS DENIED – WRONG CODE       =")
            Console.WriteLine("===========================================")
            Console.ResetColor()
            Console.WriteLine()
            GoTo SecurityCheck
        End If

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("===========================================")
        Console.WriteLine("=      ACCESS GRANTED – WELCOME USER      =")
        Console.WriteLine("===========================================")
        Console.ResetColor()
        Console.WriteLine()
        '===========================================
    End Sub

End Module

Module Module1
    Sub Main()

        Dim firstPressure, firstVolume, secondPressure, secondVolume As Double
        Dim choice As Integer
        Dim userInput As String = "yes"

        Do Until userInput.ToLower() = "no"

            Console.Clear()

            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("BOYLE'S LAW CALCULATOR")
            Console.WriteLine("--------------------------------------")
            Console.WriteLine("P1 × V1 = P2 × V2")
            Console.WriteLine("--------------------------------------")
            Console.ResetColor()

            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("SELECT WHAT YOU WANT TO CALCULATE")
            Console.WriteLine("1 - First Pressure (P1)")
            Console.WriteLine("2 - First Volume (V1)")
            Console.WriteLine("3 - Second Pressure (P2)")
            Console.WriteLine("4 - Second Volume (V2)")
            Console.WriteLine("--------------------------------------")
            Console.WriteLine("ENTER YOUR CHOICE: ")
            Console.ResetColor()

            choice = Val(Console.ReadLine())

            If choice < 1 Or choice > 4 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("INVALID CHOICE! PLEASE ENTER 1, 2, 3 OR 4.")
                Console.ResetColor()

            ElseIf choice = 1 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING FIRST PRESSURE (P1)")
                Console.WriteLine("ENTER SECOND PRESSURE (P2): ")
                Console.ResetColor()
                secondPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER SECOND VOLUME (V2): ")
                Console.ResetColor()
                secondVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FIRST VOLUME (V1): ")
                Console.ResetColor()
                firstVolume = Val(Console.ReadLine())

                If firstVolume = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! V1 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    firstPressure = (secondPressure * secondVolume) / firstVolume
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("P1 = " & Math.Round(firstPressure, 2) & " atm")
                    Console.ResetColor()
                End If

            ElseIf choice = 2 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING FIRST VOLUME (V1)")
                Console.Write("ENTER SECOND PRESSURE (P2): ")
                Console.ResetColor()
                secondPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.Write("ENTER SECOND VOLUME (V2): ")
                Console.ResetColor()
                secondVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FIRST PRESSURE (P1): ")
                Console.ResetColor()
                firstPressure = Val(Console.ReadLine())

                If firstPressure = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! P1 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    firstVolume = (secondPressure * secondVolume) / firstPressure
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("V1 = " & Math.Round(firstVolume, 2) & " cm³")
                    Console.ResetColor()
                End If

            ElseIf choice = 3 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING SECOND PRESSURE (P2)")
                Console.WriteLine("ENTER FIRST PRESSURE (P1): ")
                Console.ResetColor()
                firstPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FIRST VOLUME (V1): ")
                Console.ResetColor()
                firstVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER SECOND VOLUME (V2): ")
                Console.ResetColor()
                secondVolume = Val(Console.ReadLine())

                If secondVolume = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! V2 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    secondPressure = (firstPressure * firstVolume) / secondVolume
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("P2 = " & Math.Round(secondPressure, 2) & " atm")
                    Console.ResetColor()
                End If

            ElseIf choice = 4 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING SECOND VOLUME (V2)")
                Console.WriteLine("ENTER FIRST PRESSURE (P1): ")
                Console.ResetColor()
                firstPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FIRST VOLUME (V1): ")
                Console.ResetColor()
                firstVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER SECOND PRESSURE (P2): ")
                Console.ResetColor()
                secondPressure = Val(Console.ReadLine())

                If secondPressure = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! P2 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    secondVolume = (firstPressure * firstVolume) / secondPressure
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("V2 = " & Math.Round(secondVolume, 2) & " cm³")
                    Console.ResetColor()
                End If
            End If

            Console.WriteLine()
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.Write("DO YOU WANT TO CALCULATE AGAIN? (yes/no): ")
            Console.ResetColor()
            userInput = Console.ReadLine()

        Loop

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine()
        Console.WriteLine("THANK YOU FOR USING 4REAL GLOBAL BOYLE'S LAW")
        Console.ResetColor()

        Console.ReadLine()

    End Sub
End Module

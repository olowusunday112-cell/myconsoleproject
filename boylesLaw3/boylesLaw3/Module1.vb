Module Module1
    Sub Main()

        Dim initailPressure, initialVolume, finalPressure, finalVolume As Double
        Dim choice As Integer
        Dim userInput As String = "yes"

        Do Until userInput.ToLower() = "no"



            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("BOYLE'S LAW CALCULATOR")
            Console.WriteLine("--------------------------------------")
            Console.WriteLine("P1 × V1 = P2 × V2")
            Console.WriteLine("--------------------------------------")
            Console.ResetColor()

            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("SELECT WHAT YOU WANT TO CALCULATE")
            Console.WriteLine("1 - Initial Pressure (P1)")
            Console.WriteLine("2 - Initial Volume (V1)")
            Console.WriteLine("3 - Final Pressure (P2)")
            Console.WriteLine("4 - Final Volume (V2)")
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
                Console.WriteLine("ENTER FINAL PRESSURE (P2): ")
                Console.ResetColor()
                finalPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FINAL VOLUME (V2): ")
                Console.ResetColor()
                finalVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER INITAIL VOLUME (V1): ")
                Console.ResetColor()
                initialVolume = Val(Console.ReadLine())

                If initialVolume = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! V1 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    initailPressure = (finalPressure * finalVolume) / initialVolume
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("P1 = " & Math.Round(initailPressure, 2) & " atm")
                    Console.ResetColor()
                End If

            ElseIf choice = 2 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING FIRST VOLUME (V1)")
                Console.Write("ENTER FINAL PRESSURE (P2): ")
                Console.ResetColor()
                finalPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.Write("ENTER FINAL VOLUME (V2): ")
                Console.ResetColor()
                finalVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER INITAIL PRESSURE (P1): ")
                Console.ResetColor()
                initailPressure = Val(Console.ReadLine())

                If initailPressure = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! P1 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    initialVolume = (finalPressure * finalVolume) / initailPressure
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("V1 = " & Math.Round(initialVolume, 2) & " cm³")
                    Console.ResetColor()
                End If

            ElseIf choice = 3 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING SECOND PRESSURE (P2)")
                Console.WriteLine("ENTER INITAIL PRESSURE (P1): ")
                Console.ResetColor()
                initailPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER INITAIL VOLUME (V1): ")
                Console.ResetColor()
                initialVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FINAL VOLUME (V2): ")
                Console.ResetColor()
                finalVolume = Val(Console.ReadLine())

                If finalVolume = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! V2 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    finalPressure = (initailPressure * initialVolume) / finalVolume
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("P2 = " & Math.Round(finalPressure, 2) & " atm")
                    Console.ResetColor()
                End If

            ElseIf choice = 4 Then
                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine()
                Console.WriteLine("CALCULATING SECOND VOLUME (V2)")
                Console.WriteLine("ENTER INITAIL PRESSURE (P1): ")
                Console.ResetColor()
                initailPressure = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER INITAIL VOLUME (V1): ")
                Console.ResetColor()
                initialVolume = Val(Console.ReadLine())

                Console.ForegroundColor = ConsoleColor.Yellow
                Console.WriteLine("ENTER FINAL PRESSURE (P2): ")
                Console.ResetColor()
                finalPressure = Val(Console.ReadLine())

                If finalPressure = 0 Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("ERROR! P2 CANNOT BE ZERO.")
                    Console.ResetColor()
                Else
                    finalVolume = (initailPressure * initialVolume) / finalPressure
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("V2 = " & Math.Round(finalVolume, 2) & " cm³")
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

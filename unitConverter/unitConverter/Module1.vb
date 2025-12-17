Module Module1
    Sub Main()

        Dim category As Integer
        Dim choice As Integer
        Dim value As Double
        Dim result As Double
        Dim exitProgram As Integer = 0
        Dim input As String

        Do Until exitProgram = 1

            Console.Clear()
            Console.WriteLine("ADVANCED UNIT CONVERTER")
            Console.WriteLine("---------------------------------")
            Console.WriteLine("1. Mass / Weight")
            Console.WriteLine("2. Length (Linear)")
            Console.WriteLine("3. Area (Plane)")
            Console.WriteLine("4. Angle")
            Console.WriteLine("5. Temperature")
            Console.WriteLine("0. Exit")
            Console.WriteLine("Select category: ")

            input = Console.ReadLine()

            If Not IsNumeric(input) Then
                Console.WriteLine("Invalid input! Enter a number.")
                Console.ReadLine()
                Continue Do
            End If

            category = CInt(input)

            If category = 0 Then Exit Do

            If category < 1 Or category > 5 Then
                Console.WriteLine("Invalid menu choice!")
                Console.ReadLine()
                Continue Do
            End If

            Console.Write("Choose option: ")
            input = Console.ReadLine()

            If Not IsNumeric(input) Then
                Console.WriteLine("Invalid input! Enter a number.")
                Console.ReadLine()
                Continue Do
            End If

            choice = CInt(input)

            Console.Write("Enter value: ")
            input = Console.ReadLine()

            If Not IsNumeric(input) Then
                Console.WriteLine("Invalid value! Numbers only.")
                Console.ReadLine()
                Continue Do
            End If

            value = CDbl(input)

            Select Case category

                '---------------- MASS / WEIGHT ----------------
                Case 1
                    Select Case choice
                        Case 1 : result = value / 1000
                        Case 2 : result = value * 1000
                        Case 3 : result = value / 1000
                        Case 4 : result = value * 1000
                        Case Else
                            Console.WriteLine("Invalid option!")
                            Console.ReadLine()
                            Continue Do
                    End Select

                    '---------------- LENGTH ----------------
                Case 2
                    Select Case choice
                        Case 1 : result = value / 1000
                        Case 2 : result = value / 100
                        Case 3 : result = value / 1000
                        Case 4 : result = value * 1000
                        Case Else
                            Console.WriteLine("Invalid option!")
                            Console.ReadLine()
                            Continue Do
                    End Select

                    '---------------- AREA ----------------
                Case 3
                    Select Case choice
                        Case 1 : result = value / 1000000
                        Case 2 : result = value * 1000000
                        Case 3 : result = value / 10000
                        Case 4 : result = value * 10000
                        Case Else
                            Console.WriteLine("Invalid option!")
                            Console.ReadLine()
                            Continue Do
                    End Select

                    '---------------- ANGLE ----------------
                Case 4
                    Select Case choice
                        Case 1 : result = value * Math.PI / 180
                        Case 2 : result = value * 180 / Math.PI
                        Case 3 : result = value * 60
                        Case 4 : result = value / 60
                        Case Else
                            Console.WriteLine("Invalid option!")
                            Console.ReadLine()
                            Continue Do
                    End Select

                    '---------------- TEMPERATURE ----------------
                Case 5
                    Select Case choice
                        Case 1 : result = (value * 9 / 5) + 32
                        Case 2 : result = (value - 32) * 5 / 9
                        Case 3 : result = value + 273.15
                        Case 4 : result = value - 273.15
                        Case Else
                            Console.WriteLine("Invalid option!")
                            Console.ReadLine()
                            Continue Do
                    End Select

            End Select

            Console.WriteLine("Result: " & result)
            Console.WriteLine()
            Console.Write("Press 1 to Exit or any other key to Continue: ")

            input = Console.ReadLine()
            If IsNumeric(input) Then exitProgram = CInt(input)

        Loop

        Console.WriteLine("Thank you for using 4real global Unit Converter!")
        Console.ReadLine()

    End Sub
End Module
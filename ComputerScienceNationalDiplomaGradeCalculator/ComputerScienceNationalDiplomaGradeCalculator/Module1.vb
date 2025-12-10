Module Module1

    Sub Main()

        Dim com111, com112, com113, com114, com115, gns111, gns101, mth111, com121, com122, com123, com124, com125, com126, gns228, gns102, gns121, eed126 As Double
        Dim com211, com212, com213, com214, com215, com216, eed216, gns201, sws210, com221, com222, com223, com224, com225, com226, com229, gns202 As Double
        Dim gpofcom111, gpofcom112, gpofcom113, gpofcom114, gpofcom115, gpofgns101, gpofgns111, gpofmth111, gpofcom121, gpofcom122, gpofcom123, gpofcom124, gpofcom125, gpofcom126, gpofgns228, gpofgns102, gpofgns121, gpofeed126 As Double
        Dim gpofcom211, gpofcom212, gpofcom213, gpofcom214, gpofcom215, gpofcom216, gpofeed216, gpofgns201, gpofsws210, gpofcom221, gpofcom222, gpofcom223, gpofcom224, gpofcom225, gpofcom226, gpofcom229, gpofgns202 As Double
        Dim choice, selectedChoice, totalUnit, totalScorePoint, gradePoint As Double
        Dim grade As String


        Console.WriteLine("COMPUTER SCIENCE NATIONAL DIPLOMA CGPA CALCULATOR")
        Console.WriteLine("----------------------------------------------------------")
        Console.WriteLine("PRESS 1 TO CALCULATE ND1 GRADE")
        Console.WriteLine("PRESS 2 TO CALCULATE ND2 GRADE")
        Console.WriteLine("----------------------------------------------------------")
        choice = Console.ReadLine()

        If (choice = 1) Then
            Console.WriteLine("ND1 Selected")
            Console.WriteLine("PRESS 1 TO CALCULATE FIRST SEMESTER (ND1)")
            Console.WriteLine("PRESS 2 TO CALCULATE SECOND SEMESTER (ND1)")
            Console.WriteLine("----------------------------------------------------------")
            selectedChoice = Console.ReadLine()
        End If
        If (selectedChoice = 1) Then
            Console.WriteLine("ENTER SCORE FOR COM111 (3 - UNIT )")
            com111 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR COM112 (3 - UNIT)")
            com112 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR COM113 (3 - UNIT)")
            com113 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR COM114 (2 - UNIT)")
            com114 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR COM115 (3 - UNIT)")
            com115 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR GNS101 (2 - UNIT)")
            gns101 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR GNS111 (2 - UNIT)")
            gns111 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")

            Console.WriteLine("ENTER SCORE FOR MTH111 (2 - UNIT)")
            mth111 = Console.ReadLine()
            Console.WriteLine("----------------------------------------------------------")


            If ((com111 >= 75)) And ((com111 <= 100)) Then
                gpofcom111 = 4.0 * 3
                ElseIf (com111  >= 70)) And ((com111 <= 74.9)) Then
                gpofcom111 = 3.5 * 3
            ElseIf ((com111 >= 60)) And ((com111 <= 69.9)) Then
                gpofcom111 = 3.0 * 3
            ElseIf ((com111 >= 50)) And ((com111 <= 59.99)) Then
                gpofcom111 = 2.5 * 3
            ElseIf ((com111 >= 40)) And ((com111 <= 49.9)) Then
                gpofcom111 = 2.0 * 3
            Else
                gpofcom111 = 1.99 * 3
            End If

            If ((com112 >= 75)) And ((com112 <= 100)) Then
                gpofcom112 = 4.0 * 3
                ElseIf (com112  >= 70)) And ((com112 <= 74.9)) Then
                gpofcom112 = 3.5 * 3
            ElseIf ((com112 >= 60)) And ((com112 <= 69.9)) Then
                gpofcom112 = 3.0 * 3
            ElseIf ((com112 >= 50)) And ((com112 <= 59.99)) Then
                gpofcom112 = 2.5 * 3
            ElseIf ((com112 >= 40)) And ((com112 <= 49.9)) Then
                gpofcom112 = 2.0 * 3
            Else
                gpofcom112 = 1.99 * 3
            End If

            If ((com113 >= 75)) And ((com113 <= 100)) Then
                gpofcom113 = 4.0 * 3
                ElseIf (com113  >= 70)) And ((com113 <= 74.9)) Then
                gpofcom113 = 3.5 * 3
            ElseIf ((com113 >= 60)) And ((com113 <= 69.9)) Then
                gpofcom113 = 3.0 * 3
            ElseIf ((com113 >= 50)) And ((com113 <= 59.99)) Then
                gpofcom113 = 2.5 * 3
            ElseIf ((com113 >= 40)) And ((com113 <= 49.9)) Then
                gpofcom113 = 2.0 * 3
            Else
                gpofcom113 = 1.99 * 3
            End If

            If ((com114 >= 75)) And ((com114 <= 100)) Then
                gpofcom114 = 4.0 * 2
                ElseIf (com114  >= 70)) And ((com114 <= 74.9)) Then
                gpofcom114 = 3.5 * 2
            ElseIf ((com114 >= 60)) And ((com114 <= 69.9)) Then
                gpofcom114 = 3.0 * 2
            ElseIf ((com114 >= 50)) And ((com114 <= 59.99)) Then
                gpofcom114 = 2.5 * 2
            ElseIf ((com114 >= 40)) And ((com114 <= 49.9)) Then
                gpofcom114 = 2.0 * 2
            Else
                gpofcom114 = 1.99 * 2
            End If

            If ((com115 >= 75)) And ((com115 <= 100)) Then
                gpofcom115 = 4.0 * 3
                ElseIf (com115  >= 70)) And ((com115 <= 74.9)) Then
                gpofcom115 = 3.5 * 3
            ElseIf ((com115 >= 60)) And ((com115 <= 69.9)) Then
                gpofcom115 = 3.0 * 3
            ElseIf ((com115 >= 50)) And ((com115 <= 59.99)) Then
                gpofcom115 = 2.5 * 3
            ElseIf ((com115 >= 40)) And ((com115 <= 49.9)) Then
                gpofcom115 = 2.0 * 3
            Else
                gpofcom115 = 1.99 * 3
            End If


            If ((gns101 >= 75)) And ((gns101 <= 100)) Then
                gpofgns101 = 4.0 * 2
                ElseIf (gns101   >= 70)) And ((gns101 <= 74.9)) Then
                gpofgns101 = 3.5 * 2
            ElseIf ((gns101 >= 60)) And ((gns101 <= 69.9)) Then
                gpofgns101 = 3.0 * 2
            ElseIf ((gns101 >= 50)) And ((gns101 <= 59.99)) Then
                gpofgns101 = 2.5 * 2
            ElseIf ((gns101 >= 40)) And ((gns101 <= 49.9)) Then
                gpofgns101 = 2.0 * 2
            Else
                gpofgns101 = 1.99 * 2
            End If

            If ((gns111 >= 75)) And ((gns111 <= 100)) Then
                gpofgns111 = 4.0 * 2
                ElseIf (gns111   >= 70)) And ((gns111 <= 74.9)) Then
                gpofgns111 = 3.5 * 2
            ElseIf ((gns111 >= 60)) And ((gns111 <= 69.9)) Then
                gpofgns111 = 3.0 * 2
            ElseIf ((gns111 >= 50)) And ((gns111 <= 59.99)) Then
                gpofgns111 = 2.5 * 2
            ElseIf ((gns111 >= 40)) And ((gns111 <= 49.9)) Then
                gpofgns111 = 2.0 * 2
            Else
                gpofgns111 = 1.99 * 2
            End If


            If ((mth111 >= 75)) And ((mth111 <= 100)) Then
                gpofmth111 = 4.0 * 2
                ElseIf (mth111    >= 70)) And ((mth111 <= 74.9)) Then
                gpofmth111 = 3.5 * 2
            ElseIf ((mth111 >= 60)) And ((mth111 <= 69.9)) Then
                gpofmth111 = 3.0 * 2
            ElseIf ((mth111 >= 50)) And ((mth111 <= 59.99)) Then
                gpofmth111 = 2.5 * 2
            ElseIf ((mth111 >= 40)) And ((mth111 <= 49.9)) Then
                gpofmth111 = 2.0 * 2
            Else
                gpofmth111 = 1.99 * 2
            End If




















            Console.ReadLine()


    End Sub

End Module

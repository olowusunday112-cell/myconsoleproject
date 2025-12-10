Module Module1

    Sub Main()
        Dim com221, com222, com223, com224, com225, com226, com229, gns202 As Double
        Dim gpcom221, gpcom222, gpcom223, gpcom224, gpcom225, gpcom226, gpcom229, gpgns202 As Double
        Dim totalUnit, totalpoint, gradepoint As Double
        Dim grade As Integer

        Console.WriteLine("ND2 SECOND SEMESTER GRADE CALCULATOR")
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM221 (3 - UNIT)")
        com221 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM222 (2 - UNIT)")
        com222 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM223 (2 - UNIT)")
        com223 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM224 (2 - UNIT)")
        com224 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM225 (3 - UNIT)")
        com225 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM226 (2 - UNIT)")
        com226 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR COM229 (4 - UNIT)")
        com229 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER SCORE FOR GNS202 (2 - UNIT)")
        gns202 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        If ((com221 >= 75) And (com221 <= 100)) Then
            gpcom221 = 4 * 3
        ElseIf ((com221 >= 70) And (com221 <= 74.9)) Then
            gpcom221 = 3.5 * 3
        ElseIf ((com221 >= 60) And (com221 <= 69.9)) Then
            gpcom221 = 3.0 * 3
        ElseIf ((com221 >= 50) And (com221 <= 59.9)) Then
            gpcom221 = 2.5 * 3
        ElseIf ((com221 >= 40) And (com221 <= 49.9)) Then
            gpcom221 = 2.0 * 3
        Else
            gpcom221 = 1.99 * 3
        End If


        If ((com222 >= 75) And (com222 <= 100)) Then
            gpcom222 = 4 * 2
        ElseIf ((com222 >= 70) And (com222 <= 74.9)) Then
            gpcom222 = 3.5 * 2
        ElseIf ((com222 >= 60) And (com222 <= 69.9)) Then
            gpcom221 = 3.0 * 2
        ElseIf ((com222 >= 50) And (com222 <= 59.9)) Then
            gpcom222 = 2.5 * 2
        ElseIf ((com222 >= 40) And (com222 <= 49.9)) Then
            gpcom222 = 2.0 * 2
        Else
            gpcom222 = 1.99 * 2
        End If

        If ((com223 >= 75) And (com223 <= 100)) Then
            gpcom223 = 4 * 2
        ElseIf ((com223 >= 70) And (com223 <= 74.9)) Then
            gpcom223 = 3.5 * 2
        ElseIf ((com223 >= 60) And (com223 <= 69.9)) Then
            gpcom223 = 3.0 * 2
        ElseIf ((com223 >= 50) And (com223 <= 59.9)) Then
            gpcom223 = 2.5 * 2
        ElseIf ((com223 >= 40) And (com223 <= 49.9)) Then
            gpcom223 = 2.0 * 2
        Else
            gpcom223 = 1.99 * 2
        End If
        If ((com224 >= 75) And (com224 <= 100)) Then
            gpcom224 = 4 * 2
        ElseIf ((com224 >= 70) And (com224 <= 74.9)) Then
            gpcom221 = 3.5 * 2
        ElseIf ((com224 >= 60) And (com224 <= 69.9)) Then
            gpcom224 = 3.0 * 2
        ElseIf ((com224 >= 50) And (com224 <= 59.9)) Then
            gpcom224 = 2.5 * 2
        ElseIf ((com224 >= 40) And (com224 <= 49.9)) Then
            gpcom224 = 2.0 * 2
        Else
            gpcom224 = 1.99 * 2
        End If
        If ((com225 >= 75) And (com225 <= 100)) Then
            gpcom225 = 4 * 3
        ElseIf ((com225 >= 70) And (com225 <= 74.9)) Then
            gpcom225 = 3.5 * 3
        ElseIf ((com225 >= 60) And (com225 <= 69.9)) Then
            gpcom225 = 3.0 * 3
        ElseIf ((com225 >= 50) And (com225 <= 59.9)) Then
            gpcom225 = 2.5 * 3
        ElseIf ((com225 >= 40) And (com225 <= 49.9)) Then
            gpcom225 = 2.0 * 3
        Else
            gpcom225 = 1.99 * 3
        End If
        If ((com226 >= 75) And (com226 <= 100)) Then
            gpcom226 = 4 * 2
        ElseIf ((com226 >= 70) And (com226 <= 74.9)) Then
            gpcom226 = 3.5 * 2
        ElseIf ((com226 >= 60) And (com226 <= 69.9)) Then
            gpcom226 = 3.0 * 2
        ElseIf ((com226 >= 50) And (com226 <= 59.9)) Then
            gpcom226 = 2.5 * 2
        ElseIf ((com226 >= 40) And (com226 <= 49.9)) Then
            gpcom226 = 2.0 * 2
        Else
            gpcom226 = 1.99 * 2
        End If
        If ((com229 >= 75) And (com229 <= 100)) Then
            gpcom229 = 4 * 4
        ElseIf ((com229 >= 70) And (com229 <= 74.9)) Then
            gpcom229 = 3.5 * 4
        ElseIf ((com229 >= 60) And (com229 <= 69.9)) Then
            gpcom229 = 3.0 * 4
        ElseIf ((com229 >= 50) And (com229 <= 59.9)) Then
            gpcom229 = 2.5 * 4
        ElseIf ((com229 >= 40) And (com229 <= 49.9)) Then
            gpcom229 = 2.0 * 4
        Else
            gpcom229 = 1.99 * 4
        End If
        If ((gns202 >= 75) And (gns202 <= 100)) Then
            gpgns202 = 4 * 2
        ElseIf ((gns202 >= 70) And (gns202 <= 74.9)) Then
            gpgns202 = 3.5 * 2
        ElseIf ((gns202 >= 60) And (gns202 <= 69.9)) Then
            gpgns202 = 3.0 * 2
        ElseIf ((gns202 >= 50) And (gns202 <= 59.9)) Then
            gpgns202 = 2.5 * 2
        ElseIf ((gns202 >= 40) And (gns202 <= 49.9)) Then
            gpgns202 = 2.0 * 2
        Else
            gpgns202 = 1.99 * 2
        End If




        totalUnit = 20

        totalpoint = gpcom221 + gpcom222 + gpcom223 + gpcom224 + gpcom225 + gpcom226 + gpcom229 + gpgns202

        gradePoint = totalpoint / totalUnit


        If (gradepoint >= 3.5) And (gradepoint <= 4.0) Then
            grade = ("DISTINCTION")
        ElseIf (gradepoint >= 3.0) And (gradepoint <= 3.5) Then
            grade = ("UPPER CLASS")
        ElseIf (gradepoint >= 2.5) And (gradepoint <= 3.0) Then
            grade = "LOWER CLASS"
        ElseIf (gradepoint >= 2.0) And (gradepoint <= 2.5) Then
            grade = "PASS"
        Else
            grade = "FAIL"
        End If


        Console.WriteLine("YOUR TOTAL POINT IS " & totalpoint)
        Console.WriteLine("--------------------------------------")
        Console.WriteLine("YOUR TOTAL GRADE POINT IS " & Math.Round(gradepoint, 2))
        Console.WriteLine("--------------------------------------")
        Console.WriteLine(" GRADE  : " & grade)
        Console.WriteLine("--------------------------------------")
        Console.ReadLine()













        Console.ReadLine()
    End Sub

End Module

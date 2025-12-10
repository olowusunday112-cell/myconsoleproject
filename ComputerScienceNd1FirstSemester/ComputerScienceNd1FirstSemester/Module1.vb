Module Module1

    Sub Main()




        Dim com111, com112, com113, com114, com115, GNS101, GNS111, MTH11 As Double
        Dim gpcom111, gpcom112, gpcom113, gpcom114, gpcom115, gpgns101, gpgns111, gpmth111, totalpoint, totalUnit, gradePoint As Double
        Dim grade As String

        Console.WriteLine("COMPUTER SCIENCE ND1 FIRST SEMESTER CGPA CALCULATOR")
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER VALUE FOR INTRODUCTION TO COMPUTING (COM111 - 3UNITS )")
        com111 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")


        Console.WriteLine("ENTER VALUE FOR INTRODUCTION TO DIGITAL ELECTONICS  (COM112 - 3UNITS)")
        com112 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")


        Console.WriteLine("ENTER VALUE FOR INTRODUCTION TO PROGRAMMING (COM113  - 3UNITS)")
        com113 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")


        Console.WriteLine("ENTER VALUE FOR INTRODUCTION TO STATISTIC IN COMPUTING (COM114 - 2UNITS )")
        com114 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")


        Console.WriteLine("ENTER VALUE FOR INTRODUCTION TO COMPUTER APPLICATION PROCESS (COM115 - 3UNITS)")
        com115 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")

        Console.WriteLine("ENTER VALUE FOR USE OF ENGLISH LANGUAGE (GNS101 - 2UNITS)")
        GNS101 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")


        Console.WriteLine("ENTER VALUE FOR CITIZENSHIP EDUCATE  (GNS111 - 2UNITS)")
        GNS111 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")


        Console.WriteLine("ENTER VALUE FOR LOGICAL AND LENEAR ALGIBRAL (MTH11 - 2UNITS)")
        MTH11 = Console.ReadLine()
        Console.WriteLine("--------------------------------------")



        If ((com111 >= 75) And (com111 <= 100)) Then
            gpcom111 = 4 * 3
        ElseIf ((com111 >= 70) And (com111 <= 74.9)) Then
            gpcom111 = 3.5 * 3
        ElseIf ((com111 >= 60) And (com111 <= 69.9)) Then
            gpcom111 = 3.0 * 3
        ElseIf ((com111 >= 50) And (com111 <= 59.9)) Then
            gpcom111 = 2.5 * 3
        ElseIf ((com111 >= 40) And (com111 <= 49.9)) Then
            gpcom111 = 2.0 * 3
        Else
            gpcom111 = 1.99 * 3


        End If

        If ((com112 >= 75) And (com112 <= 100)) Then
            gpcom112 = 4 * 3
        ElseIf ((com112 >= 70) And (com112 <= 74.9)) Then
            gpcom112 = 3.5 * 3
        ElseIf ((com112 >= 60) And (com112 <= 69.9)) Then
            gpcom112 = 3.0 * 3
        ElseIf ((com112 >= 50) And (com112 <= 59.9)) Then
            gpcom112 = 2.5 * 3
        ElseIf ((com112 >= 40) And (com112 <= 49.9)) Then
            gpcom112 = 2.0 * 3
        Else
            gpcom112 = 1.99 * 3


        End If

        If ((com113 >= 75) And (com113 <= 100)) Then
            gpcom113 = 4 * 3
        ElseIf ((com113 >= 70) And (com113 <= 74.9)) Then
            gpcom113 = 3.5 * 3
        ElseIf ((com113 >= 60) And (com113 <= 69.9)) Then
            gpcom113 = 3.0 * 3
        ElseIf ((com113 >= 50) And (com113 <= 59.9)) Then
            gpcom113 = 2.5 * 3
        ElseIf ((com113 >= 40) And (com113 <= 49.9)) Then
            gpcom113 = 2.0 * 3
        Else
            gpcom113 = 1.99 * 3

        End If

        If ((com114 >= 75) And (com114 <= 100)) Then
            gpcom114 = 4 * 2
        ElseIf ((com114 >= 70) And (com114 <= 74.9)) Then
            gpcom114 = 3.5 * 2
        ElseIf ((com114 >= 60) And (com114 <= 69.9)) Then
            gpcom114 = 3.0 * 2
        ElseIf ((com114 >= 50) And (com114 <= 59.9)) Then
            gpcom114 = 2.5 * 2
        ElseIf ((com114 >= 40) And (com114 <= 49.9)) Then
            gpcom114 = 2.0 * 2
        Else
            gpcom114 = 1.99 * 2


        End If

        If ((com115 >= 75) And (com115 <= 100)) Then
            gpcom115 = 4 * 3
        ElseIf ((com115 >= 70) And (com115 <= 74.9)) Then
            gpcom115 = 3.5 * 3
        ElseIf ((com115 >= 60) And (com115 <= 69.9)) Then
            gpcom115 = 3.0 * 3
        ElseIf ((com115 >= 50) And (com115 <= 59.9)) Then
            gpcom115 = 2.5 * 3
        ElseIf ((com115 >= 40) And (com115 <= 49.9)) Then
            gpcom115 = 2.0 * 3
        Else
            gpcom115 = 1.99 * 3


        End If


        If ((GNS101 >= 75) And (GNS101 <= 100)) Then
            gpgns101 = 4 * 2
        ElseIf ((GNS101 >= 70) And (GNS101 <= 74.9)) Then
            gpgns101 = 3.5 * 2
        ElseIf ((GNS101 >= 60) And (GNS101 <= 69.9)) Then
            gpgns101 = 3.0 * 2
        ElseIf ((GNS101 >= 50) And (GNS101 <= 59.9)) Then
            gpgns101 = 2.5 * 2
        ElseIf ((GNS101 >= 40) And (GNS101 <= 49.9)) Then
            gpgns101 = 2.0 * 2
        Else
            gpgns101 = 1.99 * 2

        End If

        If ((GNS111 >= 75) And (GNS111 <= 100)) Then
            gpgns111 = 4 * 2
        ElseIf ((GNS111 >= 70) And (GNS111 <= 74.9)) Then
            gpgns111 = 3.5 * 2
        ElseIf ((GNS111 >= 60) And (GNS111 <= 69.9)) Then
            gpgns111 = 3.0 * 2
        ElseIf ((GNS111 >= 50) And (GNS111 <= 59.9)) Then
            gpgns111 = 2.5 * 2
        ElseIf ((GNS111 >= 40) And (GNS111 <= 49.9)) Then
            gpgns111 = 2.0 * 2
        Else
            gpgns111 = 1.99 * 2

        End If


        If ((MTH11 >= 75) And (MTH11 <= 100)) Then
            gpmth111 = 4 * 2
        ElseIf ((MTH11 >= 70) And (MTH11 <= 74.9)) Then
            gpmth111 = 3.5 * 2
        ElseIf ((MTH11 >= 60) And (MTH11 <= 69.9)) Then
            gpmth111 = 3.0 * 2
        ElseIf ((MTH11 >= 50) And (MTH11 <= 59.9)) Then
            gpmth111 = 2.5 * 2
        ElseIf ((MTH11 >= 40) And (MTH11 <= 49.9)) Then
            gpmth111 = 2.0 * 2
        Else
            gpmth111 = 1.99 * 2

        End If

        totalUnit = 20

        totalpoint = gpcom111 + gpcom112 + gpcom113 + gpcom114 + gpcom115 + gpgns111 + gpgns101 + gpmth111

        gradePoint = totalpoint / totalUnit


        If gradePoint >= 3.5 And gradePoint <= 4.0 Then
            grade = "DISTINCTION"
        ElseIf gradePoint >= 3.0 And gradePoint <= 3.5 Then
            grade = "UPPER CLASS"

        ElseIf gradePoint >= 2.5 And gradePoint <= 3.0 Then
            grade = "LOWER CLASS"

        ElseIf gradePoint >= 2.0 And gradePoint <= 2.5 Then
            grade = "PASS"

        Else
            grade = "PROBATION"
        End If



        Console.WriteLine("YOUR TOTAL POINT IS " & totalpoint)
        Console.WriteLine("--------------------------------------")
        Console.WriteLine("YOUR TOTAL GRADE POINT IS " & gradePoint)
        Console.WriteLine("--------------------------------------")
        Console.WriteLine(" GRADE  : " & grade)
        Console.WriteLine("--------------------------------------")
        Console.ReadLine()

    End Sub




End Module

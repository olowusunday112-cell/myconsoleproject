Module Module1


    Sub Main()
        Dim com111, com112, com113, com114, com115, gns111, gns101, mth111, com121, com122, com123, com124, com125, com126, gns228, gns102, gns121, eed126 As Double
        Dim com211, com212, com213, com214, com215, com216, eed216, gns201, sws210, com221, com222, com223, com224, com225, com226, com229, gns202 As Double
        Dim gpofcom111, gpofcom112, gpofcom113, gpofcom114, gpofcom115, gpofgns101, gpofgns111, gpofmth111, gpofcom121, gpofcom122, gpofcom123, gpofcom124, gpofcom125, gpofcom126, gpofgns228, gpofgns102, gpofgns121, gpofeed126 As Double
        Dim gpofcom211, gpofcom212, gpofcom213, gpofcom214, gpofcom215, gpofcom216, gpofeed216, gpofgns201, gpofsws210, gpofcom221, gpofcom222, gpofcom223, gpofcom224, gpofcom225, gpofcom226, gpofcom229, gpofgns202 As Double
        Dim choice, selectedChoice, totalUnit, totalScorePoint, gradePoint As Double
        Dim grade As String


        Console.WriteLine("MAPOLY COMPUTER SCIENCE NATIONAL DIPLOMA GRADE POINT CALCULATOR (CGPA)")
        Console.WriteLine("----------------------------------------------------------")
        Console.WriteLine("PRESS 1 TO CALCULATE ND 1 GRADE POINT")
        Console.WriteLine("PRESS 2 TO CALCULATE ND 2 GRADE POINT")
        Console.WriteLine("----------------------------------------------------------")
        choice = Console.ReadLine()

        If (choice = 1) Then
            Console.WriteLine("ND 1 SELECTED")
            Console.WriteLine("PRESS 1 TO CALCULATE FIRST SEMESTER GRADE POINT (ND 1)")
            Console.WriteLine("PRESS 2 TO CALCULATE SECOND SEMESTER POINT (ND 1)")
            Console.WriteLine("----------------------------------------------------------")
            selectedChoice = Console.ReadLine()

            If (selectedChoice = 1) Then

                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO COMPUTING COM111 (3 - UNIT )")
                com111 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO DIGITAL ELECTRONICS COM112 (3 - UNIT)")
                com112 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO PROGRAMMING COM113 (3 - UNIT)")
                com113 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR STATISTICS FOR COMPUTING I COM114 (2 - UNIT)")
                com114 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR COMPUTER APPLICATION PACKAGES I COM115 (3 - UNIT)")
                com115 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR USE OF ENGLISH I GNS101 (2 - UNIT)")
                gns101 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR CITIZENSHIP EDUCATION I GNS111 (2 - UNIT)")
                gns111 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR LOGIC AND LINEAR ALGEBRA MTH111 (2 - UNIT)")
                mth111 = Console.ReadLine()
                Console.WriteLine("----------------------------------------------------------")

                If ((com111 > 100) Or (com112 > 100) Or (com113 > 100) Or (com114 > 100) Or (com115 > 100) Or (gns101 > 100) Or (gns111 > 100) Or (mth111 > 100)) Then

                    Console.WriteLine("INVALID!!! SCORE MUST NOT EXCEED 100")

                Else
                    gpofcom111 = MyFunction.gradePoint(com111, 3)
                    gpofcom112 = MyFunction.gradePoint(com112, 3)
                    gpofcom113 = MyFunction.gradePoint(com113, 3)
                    gpofcom114 = MyFunction.gradePoint(com114, 2)
                    gpofcom115 = MyFunction.gradePoint(com115, 3)
                    gpofgns101 = MyFunction.gradePoint(gns101, 2)
                    gpofgns111 = MyFunction.gradePoint(gns111, 2)
                    gpofmth111 = MyFunction.gradePoint(mth111, 2)

                    totalUnit = 20
                    totalScorePoint = gpofcom111 + gpofcom112 + gpofcom113 + gpofcom114 + gpofcom115 + gpofgns101 + gpofgns111 + gpofmth111
                    gradePoint = totalScorePoint / totalUnit

                    grade = gradeTitle(gradePoint)

                    MyFunction.resultData(totalScorePoint, gradePoint, grade)
                End If

            ElseIf (selectedChoice = 2) Then

                Console.WriteLine("ENTER SCORE FOR PROGRAMMING USING C LANGUAGE COM121 (3 - UNIT)")
                com121 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR INTODUCTION TO INTERNET COM122 (3 - UNIT)")
                com122 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR PROGRAMMING USING JAVA I COM123 (3 - UNIT)")
                com123 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR DATA STRUCTURE AND ALGORITHMS COM124 (3 - UNIT)")
                com124 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR INTRODUCTION TO SYSTEMS ANALYSIS AND DESIGN COM125 (3 - UNIT)")
                com125 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR PC UPGRADE AND MAINTENANCE COM126 (3 - UNIT)")
                com126 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR RESEARCH METHODS GNS228 (2 - UNIT)")
                gns228 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR PRACTICAL OF ENTREPRENEURSHIP I EED126 (2 - UNIT)")
                eed126 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR COMMUNICATION IN ENGLISH GNS102 (2 - UNIT)")
                gns102 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR CITIZENSHIP EDUCATION II GNS121 (2 - UNIT)")
                gns121 = Console.ReadLine()
                Console.WriteLine("-----------------------------------------------")

                If ((com121 > 100) Or (com122 > 100) Or (com123 > 100) Or (com124 > 100) Or (com125 > 100) Or (com126 > 100) Or (gns228 > 100) Or (eed126 > 100) Or (gns102 > 100) Or (gns121 > 100)) Then

                    Console.WriteLine("INVALID!!! SCORE MUST NOT EXCEED 100")

                Else

                    gpofcom121 = MyFunction.gradePoint(com121, 3)
                    gpofcom122 = MyFunction.gradePoint(com122, 3)
                    gpofcom123 = MyFunction.gradePoint(com123, 2)
                    gpofcom124 = MyFunction.gradePoint(com124, 3)
                    gpofcom125 = MyFunction.gradePoint(com125, 3)
                    gpofcom126 = MyFunction.gradePoint(com126, 3)
                    gpofgns228 = MyFunction.gradePoint(gns228, 2)
                    gpofeed126 = MyFunction.gradePoint(eed126, 2)
                    gpofgns102 = MyFunction.gradePoint(gns102, 2)
                    gpofgns121 = MyFunction.gradePoint(gns121, 2)

                    totalUnit = 25
                    totalScorePoint = gpofcom121 + gpofcom122 + gpofcom123 + gpofcom124 + gpofcom125 + gpofcom126 + gpofgns228 + gpofeed126 + gpofgns102 + gpofgns121
                    gradePoint = totalScorePoint / totalUnit

                    grade = gradeTitle(gradePoint)

                   MyFunction.resultData(totalScorePoint, gradePoint, grade)
                End If

            Else
                Console.WriteLine("INVALID REQUEST!!! KINDLY FOLLOW INSTRUCTION ABOVE. TRY AGAIN...")
                Console.ReadLine()
            End If




        ElseIf (choice = 2) Then
            Console.WriteLine("ND 2 SELECTED")
            Console.WriteLine("PRESS 1 TO CALCULATE FIRST SEMESTER GRADE POINT (ND 2)")
            Console.WriteLine("PRESS 2 TO CALCULATE SECOND SEMESTER GRADE POINT (ND 2)")
            Console.WriteLine("---------------------------------------------")
            selectedChoice = Console.ReadLine()

            If (selectedChoice = 1) Then
                Console.WriteLine("ENTER SCORE FOR PROGRAMMING LANGUAGE USING JAVA II COM211 (3 - UNIT)")
                com211 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR INTODUCTION TO SYSTEMS PROGRAMMING COM212 (2 - UNIT)")
                com212 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR UNIFIED MODELLING LANGUAGE UML COM213 (3 - UNIT)")
                com213 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR COMPUTER SYSTEMS TROUBLESHOOTING COM214 (3 - UNIT)")
                com214 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR COMPUTER PACKAGES II COM215 (3 - UNIT)")
                com215 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR COM216 STATISTICS FOR COMPUTING II (2 - UNIT)")
                com216 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR EED216 PRATICE OF ENTREPRENEURSHIP (2 - UNIT)")
                eed216 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR USE OF ENGLISH II GNS201 (2 - UNIT)")
                gns201 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                Console.WriteLine("ENTER SCORE FOR SUPERVISED INDUSTRIAL WORK EXPERIENCE SWS210 (4 - UNIT)")
                sws210 = Console.ReadLine()
                Console.WriteLine("------------------------------------------")

                If ((com211 > 100) Or (com212 > 100) Or (com213 > 100) Or (com214 > 100) Or (com215 > 100) Or (com216 > 100) Or (eed216 > 100) Or (gns201 > 100) Or (sws210 > 100)) Then

                    Console.WriteLine("INVALID!!! SCORE MUST NOT EXCEED 100")

                Else
                    gpofcom211 = MyFunction.gradePoint(com211, 3)
                    gpofcom212 = MyFunction.gradePoint(com212, 2)
                    gpofcom213 = MyFunction.gradePoint(com213, 3)
                    gpofcom214 = MyFunction.gradePoint(com214, 3)
                    gpofcom215 = MyFunction.gradePoint(com215, 3)
                    gpofcom216 = MyFunction.gradePoint(com216, 2)
                    gpofeed216 = MyFunction.gradePoint(eed216, 2)
                    gpofgns201 = MyFunction.gradePoint(gns201, 2)
                    gpofsws210 = MyFunction.gradePoint(sws210, 4)

                    totalUnit = 24
                    totalScorePoint = gpofcom211 + gpofcom212 + gpofcom213 + gpofcom214 + gpofcom215 + gpofcom216 + gpofeed216 + gpofgns201 + gpofsws210
                    gradePoint = totalScorePoint / totalUnit
                    grade = gradeTitle(gradePoint)

                    MyFunction.resultData(totalScorePoint, gradePoint, grade)
                End If

            ElseIf (selectedChoice = 2) Then
                Console.WriteLine("ENTER SCORE FOR BASIC COMPUTER NETWORKING  COM221 (3 - UNIT)")
                com221 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR SEMINAR ON COMPUTER AND SOCIETY COM222 (2 - UNIT)")
                com222 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR BASIC HARDWARE MAINTENANCE COM223 (2 - UNIT)")
                com223 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR MANAGEMENT INFORMATION SYSTEM COM224 (2 - UNIT)")
                com224 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR WEB TECHNOLOGY COM225 (3 - UNIT)")
                com225 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR FILE ORGANISATION AND MANAGEMENT COM226 (2 - UNIT)")
                com226 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR PROJECT COM229 (4 - UNIT)")
                com229 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                Console.WriteLine("ENTER SCORE FOR COMMUNICATION IN ENGLISH II GNS202 (2 - UNIT)")
                gns202 = Console.ReadLine()
                Console.WriteLine("--------------------------------")

                If ((com221 > 100) Or (com222 > 100) Or (com223 > 100) Or (com224 > 100) Or (com225 > 100) Or (com226 > 100) Or (com229 > 100) Or (gns202 > 100)) Then

                    Console.WriteLine("INVALID!!! SCORE MUST NOT EXCEED 100")

                Else

                    gpofcom221 = MyFunction.gradePoint(com221, 3)
                    gpofcom222 = MyFunction.gradePoint(com222, 2)
                    gpofcom223 = MyFunction.gradePoint(com223, 2)
                    gpofcom224 = MyFunction.gradePoint(com224, 2)
                    gpofcom225 = MyFunction.gradePoint(com225, 3)
                    gpofcom226 = MyFunction.gradePoint(com226, 2)
                    gpofcom229 = MyFunction.gradePoint(com229, 4)
                    gpofgns202 = MyFunction.gradePoint(gns202, 2)

                    totalUnit = 20
                    totalScorePoint = gpofcom221 + gpofcom222 + gpofcom223 + gpofcom224 + gpofcom225 + gpofcom226 + gpofcom229 + gpofgns202
                    gradePoint = totalScorePoint / totalUnit

                    grade = gradeTitle(gradePoint)

                    MyFunction.resultData(totalScorePoint, gradePoint, grade)
                End If
            Else

                Console.WriteLine("INVALID REQUEST!!! KINDLY FOLLOW INSTRUCTION GIVEN ABOVE. TRY AGAIN...")
                Console.ReadLine()
            End If
        Else
            Console.WriteLine("INVALID REQUEST!!! KINDLY FOLLOW INSTUCTION GIVEN ABOVE. TRY AGAIN...")

        End If









        Console.ReadLine()




    End Sub

End Module

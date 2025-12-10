Module Module1

    Sub Main()

        Dim swd101, da102, nt103, wad104, mad105, uiux106, totalUnit, totalScorePoint, gradePOint As Double
        Dim gpofswd101, gpofda102, gpofnt103, gpofwad104, gpofmad105, gpofuiux106 As Double
        Dim grade As String


        Console.WriteLine("4REAL GLOBAL GRADE POINT CALCULATOR")
        Console.WriteLine("-----------------------------------")

        Console.WriteLine("ENTER SCORE FOR SOFTWARE DEVELOPMENT (SWD101 - 3UNIT)")
        swd101 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")


        Console.WriteLine("ENTER SCORE FOR DATA ANALYSIS (DA102 - 4UNIT)")
        da102 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR NETWORKING (NT103 - 3UNIT)")
        nt103 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR WEB APPLICATION DEVELOPMENT (WAD103 - 4UNIT)")
        wad104 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR MOBILE APPLICATION DEVELOPMENT (MAD105 - 4UNIT)")
        mad105 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR USER INTERFACE AND USER EXPERINCE (UIUX106 - 2UNIT)")
        uiux106 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        If ((swd101 > 100) Or (da102 > 100) Or (nt103 > 100) Or (wad104 > 100) Or (mad105 > 100) Or (uiux106 > 100)) Then

            Console.WriteLine("INVALID!!! SCORE MUST NOT EXCEED 100")

        Else
            gpofswd101 = MyFunction.gradepoint(swd101, 3)
            gpofda102 = MyFunction.gradepoint(da102, 4)
            gpofnt103 = MyFunction.gradepoint(nt103, 3)
            gpofwad104 = MyFunction.gradepoint(wad104, 4)
            gpofmad105 = MyFunction.gradepoint(mad105, 4)
            gpofuiux106 = MyFunction.gradepoint(uiux106, 2)


            totalUnit = 20

            totalScorePoint = gpofswd101 + gpofda102 + gpofnt103 + gpofwad104 + gpofmad105 + gpofuiux106
            gradePOint = totalScorePoint / totalUnit



            If ((gradePOint >= 3.5)) And ((gradePOint <= 4.0)) Then
                grade = "DISTINCTION"
            ElseIf ((gradePOint >= 3.0)) And ((gradePOint <= 3.5)) Then
                grade = "UPPER CLASS"
            ElseIf ((gradePOint >= 2.5)) And ((gradePOint <= 3.0)) Then
                grade = "LOWER CLASS"
            ElseIf ((gradePOint >= 2.0)) And ((gradePOint < 2.5)) Then
                grade = "PASS"
            Else
                grade = "FAIL"
            End If



            Console.WriteLine("TOTAL SCORE POINT IS " & totalScorePoint.ToString)
            Console.WriteLine("GRADE POINT IS " & Math.Round(gradePOint, 2).ToString)
            Console.WriteLine("YOUR GRADE IS " & grade.ToString)
        End If
        Console.ReadLine()

    End Sub

End Module

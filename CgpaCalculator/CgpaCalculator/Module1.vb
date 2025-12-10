Module Module1

    Sub Main()
        Dim softwareDevelopmentswd101, dataAnalysisda102, networkingnt103, webAppDevelopmentwad104, mobileAppDevelopmentmad105, userInterfaceuserExperinceuiux106 As Double
        Dim gpsoftwareDevelopment101, gpofdataAnalysis102, gpofnetworking103, gpofwebAppDevelopment104, gpofmobileAppDevelopment105, gpofuserInterfaceuserExperinceuiux106 As Double
        Dim totalUnit, totalScorePoint, gradePoint, score As Double
        Dim grade As String

        Console.WriteLine("4REAL GLOBAL GRADE POINT CALCULATOR ")
        Console.WriteLine("---------------------------------------")


        Console.WriteLine("ENTER SCORE FOR SOFTWARE DEVELOPMENT (SWD101 - 3UNIT)")
        softwareDevelopmentswd101 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")


        Console.WriteLine("ENTER SCORE FOR DATA ANALYSIS (DA102 - 4UNIT)")
        dataAnalysisda102 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR NETWORKING (NT103 - 3UNIT)")
        networkingnt103 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR WEB APPLICATION DEVELOPMENT (WAD103 - 4UNIT)")
        webAppDevelopmentwad104 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR MOBILE APPLICATION DEVELOPMENT (MAD105 - 4UNIT)")
        mobileAppDevelopmentmad105 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("ENTER SCORE FOR USER INTERFACE AND USER EXPERINCE (UIUX106 - 2UNIT)")
        userInterfaceuserExperinceuiux106 = Console.ReadLine()
        Console.WriteLine("---------------------------------------")
        If ((softwareDevelopmentswd101 > 100)) Or (dataAnalysisda102 > 100) Or (networkingnt103 > 100) Or (webAppDevelopmentwad104 > 100) Or (mobileAppDevelopmentmad105 > 100) Or ((userInterfaceuserExperinceuiux106 > 100)) Then

            Console.WriteLine("INVALID!!! SCORE MUST NOT EXCEED 100")

        Else

            If ((softwareDevelopmentswd101 >= 75)) And ((softwareDevelopmentswd101 <= 100)) Then
                gpsoftwareDevelopment101 = 4.0 * 3
            ElseIf ((softwareDevelopmentswd101 >= 70)) And ((softwareDevelopmentswd101 <= 74.9)) Then
                gpsoftwareDevelopment101 = 3.5 * 3
            ElseIf ((softwareDevelopmentswd101 >= 60)) And ((softwareDevelopmentswd101 <= 69.9)) Then
                gpsoftwareDevelopment101 = 3.0 * 3
            ElseIf ((softwareDevelopmentswd101 >= 50)) And ((softwareDevelopmentswd101 <= 59.99)) Then
                gpsoftwareDevelopment101 = 2.5 * 3
            ElseIf ((softwareDevelopmentswd101 >= 40)) And ((softwareDevelopmentswd101 <= 49.9)) Then
                gpsoftwareDevelopment101 = 2.0 * 3
            Else
                gpsoftwareDevelopment101 = 1.99 * 3

            End If

            If ((dataAnalysisda102 >= 75)) And ((dataAnalysisda102 <= 100)) Then
                gpofdataAnalysis102 = 4.0 * 4

            ElseIf ((dataAnalysisda102 >= 70)) And ((dataAnalysisda102 <= 74.9)) Then
                gpofdataAnalysis102 = 3.5 * 4

            ElseIf ((dataAnalysisda102 >= 60)) And ((dataAnalysisda102 <= 69.9)) Then
                gpofdataAnalysis102 = 3.0 * 4

            ElseIf ((dataAnalysisda102 >= 50)) And ((dataAnalysisda102 <= 59.9)) Then
                gpofdataAnalysis102 = 2.5 * 4

            ElseIf ((dataAnalysisda102 >= 40)) And ((dataAnalysisda102 <= 49.9)) Then
                gpofdataAnalysis102 = 2.0 * 4
            Else
                gpofdataAnalysis102 = 1.99 * 4

            End If

            If ((networkingnt103 >= 75)) And ((networkingnt103 <= 100)) Then
                gpofnetworking103 = 4.0 * 3

            ElseIf ((networkingnt103 >= 70)) And ((networkingnt103 <= 74.9)) Then
                gpofnetworking103 = 3.5 * 3

            ElseIf ((networkingnt103 >= 60)) And ((networkingnt103 <= 69.9)) Then
                gpofnetworking103 = 3.0 * 3

            ElseIf ((networkingnt103 >= 50)) And ((networkingnt103 <= 59.9)) Then
                gpofnetworking103 = 2.5 * 3

            ElseIf ((networkingnt103 >= 40)) And ((networkingnt103 <= 49.9)) Then
                gpofnetworking103 = 2.0 * 3

            Else
                gpofnetworking103 = 1.99 * 3

            End If

            If ((webAppDevelopmentwad104 >= 75)) And ((webAppDevelopmentwad104 <= 100)) Then
                gpofwebAppDevelopment104 = 4.0 * 4
            ElseIf ((webAppDevelopmentwad104 >= 70)) And ((webAppDevelopmentwad104 <= 74.9)) Then
                gpofwebAppDevelopment104 = 3.5 * 4
            ElseIf ((webAppDevelopmentwad104 >= 60)) And ((webAppDevelopmentwad104 <= 69.9)) Then
                gpofwebAppDevelopment104 = 3.0 * 4
            ElseIf ((webAppDevelopmentwad104 >= 50)) And ((webAppDevelopmentwad104 <= 59.9)) Then
                gpofwebAppDevelopment104 = 2.5 * 4
            ElseIf ((webAppDevelopmentwad104 >= 40)) And ((webAppDevelopmentwad104 <= 49.9)) Then
                gpofwebAppDevelopment104 = 2.0 * 4

            Else
                gpofwebAppDevelopment104 = 1.99 * 4
            End If

            If ((mobileAppDevelopmentmad105 >= 75)) And ((mobileAppDevelopmentmad105 <= 100)) Then
                gpofmobileAppDevelopment105 = 4.0 * 4
            ElseIf ((mobileAppDevelopmentmad105 >= 70)) And ((mobileAppDevelopmentmad105 <= 74.9)) Then
                gpofmobileAppDevelopment105 = 3.5 * 4
            ElseIf ((mobileAppDevelopmentmad105 >= 60)) And ((mobileAppDevelopmentmad105 <= 69.9)) Then
                gpofmobileAppDevelopment105 = 3.0 * 4
            ElseIf ((mobileAppDevelopmentmad105 >= 50)) And ((mobileAppDevelopmentmad105 <= 59.9)) Then
                gpofmobileAppDevelopment105 = 2.5 * 4
            ElseIf ((mobileAppDevelopmentmad105 >= 40)) And ((mobileAppDevelopmentmad105 <= 49.9)) Then
                gpofmobileAppDevelopment105 = 2.0 * 4

            Else
                gpofmobileAppDevelopment105 = 1.99 * 4
            End If

            If ((userInterfaceuserExperinceuiux106 >= 75)) And ((userInterfaceuserExperinceuiux106 <= 100)) Then
                gpofuserInterfaceuserExperinceuiux106 = 4.0 * 2

            ElseIf ((userInterfaceuserExperinceuiux106 >= 70)) And ((userInterfaceuserExperinceuiux106 <= 74.9)) Then
                gpofuserInterfaceuserExperinceuiux106 = 3.5 * 2


            ElseIf ((userInterfaceuserExperinceuiux106 >= 60)) And ((userInterfaceuserExperinceuiux106 <= 69.9)) Then
                gpofuserInterfaceuserExperinceuiux106 = 3.0 * 2

            ElseIf ((userInterfaceuserExperinceuiux106 >= 50)) And ((userInterfaceuserExperinceuiux106 <= 59.9)) Then
                gpofuserInterfaceuserExperinceuiux106 = 2.5 * 2
            ElseIf ((userInterfaceuserExperinceuiux106 >= 40)) And ((userInterfaceuserExperinceuiux106 <= 49.9)) Then
                gpofuserInterfaceuserExperinceuiux106 = 2.0 * 2

            Else
                gpofuserInterfaceuserExperinceuiux106 = 1.99 * 2
            End If


            totalUnit = 20

            totalScorePoint = gpsoftwareDevelopment101 + gpofdataAnalysis102 + gpofnetworking103 + gpofwebAppDevelopment104 + gpofmobileAppDevelopment105 + gpofuserInterfaceuserExperinceuiux106

            gradePoint = totalScorePoint / totalUnit

            If (gradePoint >= 3.5) And (gradePoint <= 4.0) Then
                grade = "DISTINCTION"

            ElseIf (gradePoint >= 3.0) And (gradePoint <= 3.5) Then
                grade = "UPPER CLASS"

            ElseIf (gradePoint >= 2.5) And (gradePoint <= 3.0) Then
                grade = "LOWER CLASS"

            ElseIf (gradePoint = 2.0) And (gradePoint <= 2.5) Then
                grade = "PASS"

            Else
                grade = "FAIL"
            End If

            Console.WriteLine("TOTAL SCORE POINT IS " & totalScorePoint.ToString)
            Console.WriteLine("GRADE POINT IS " & Math.Round(gradePoint, 2).ToString)
            Console.WriteLine("YOUR GRADE IS " & grade.ToString)


        End If










        Console.ReadLine()
    End Sub

End Module

Module MyFunction



    Function gradePoint(ByVal score As Double, ByVal courseUnit As Double)
        Dim gp As Double
        If ((score >= 75)) And ((score <= 100)) Then
            gp = 4.0 * courseUnit

        ElseIf ((score >= 70)) And ((score <= 74.9)) Then
            gp = 3.5 * courseUnit
        ElseIf ((score >= 60)) And ((score <= 69.9)) Then
            gp = 3.0 * courseUnit
        ElseIf ((score >= 50)) And ((score <= 59.9)) Then
            gp = 2.5 * courseUnit
        ElseIf ((score >= 40)) And ((score <= 49.9)) Then
            gp = 2.0 * courseUnit
        Else
            gp = 1.99 * courseUnit

        End If
        Return gp



    End Function

    Function gradeTitle(ByVal gradePoint As Double)
        Dim grade As String

        If ((gradePoint >= 3.5)) And ((gradePoint <= 4.0)) Then
            grade = "DISTINCTION"
        ElseIf ((gradePoint >= 3.0)) And ((gradePoint <= 3.5)) Then
            grade = "UPPER CLASS"
        ElseIf ((gradePoint >= 2.5)) And ((gradePoint <= 3.0)) Then
            grade = "LOWER CLASS"
        ElseIf ((gradePoint >= 2.0)) And ((gradePoint < 2.5)) Then
            grade = "PASS"
        Else
            grade = "FAIL"
        End If

        Return grade

    End Function

    Public Sub resultData(ByVal totalScorePoint As Double, ByVal gradePoint As Double, ByVal grade As String)
        Console.WriteLine("TOTAL SCORE IS " & totalScorePoint.ToString)
        Console.WriteLine("GRADE POINT IS " & Math.Round(gradePoint, 2).ToString("N"))
        Console.WriteLine("GRADE " & grade.ToString)
    End Sub

End Module

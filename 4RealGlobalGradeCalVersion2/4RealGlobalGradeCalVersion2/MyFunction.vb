Module MyFunction


    Function gradepoint(ByVal score As Double, ByVal courseUnit As Double)
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



End Module

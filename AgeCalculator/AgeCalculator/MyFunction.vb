Module MyFunction
    Function calculateAge(ByVal dob As Date) As String
        Dim today As Date = Date.Today
        Dim years As Integer = today.Year - dob.Year
        Dim months As Integer = today.Month - dob.Month
        Dim days As Integer = today.Day - dob.Day

        'Fix days
        If days < 0 Then
            months -= 1
            Dim prevMonth As Integer =
                If(today.Month = 1, 12, today.Month - 1)

            Dim prevYear As Integer =
                If(today.Month = 1, today.Year - 1, today.Year)

            days +=
            Date.DaysInMonth(prevYear, prevMonth)
        End If

        'Fix months
        If months < 0 Then
            years -= 1
            months += 12
        End If

        Return "Your Age is: " & years & "years, " & months & " months, " & days & " days"

    End Function

End Module

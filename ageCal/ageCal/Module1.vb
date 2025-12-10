Module Module1

    Sub main()
        Dim currentDay, currentMonth, currentYear As Integer
        Dim birthDay, birthMonth, birthYear As Integer
        Dim resultDay, resultMonth, resultYear As Integer

        Console.WriteLine("AGE CALCULATOR")
        Console.WriteLine("----------------------")

        currentDay = Date.Now.Day
        currentMonth = Date.Now.Month
        currentYear = Date.Now.Year

        Console.WriteLine("Today's date is " & currentDay & "/" & currentMonth & "/" & currentYear)

        Console.WriteLine("Enter Birth Day: ")
        birthDay = Console.ReadLine()
        Console.WriteLine("Enter Birth Month: ")
        birthMonth = Console.ReadLine()
        Console.WriteLine("Enter Birth Year: ")
        birthYear = Console.ReadLine()

        ' Calculate Years

        If ((birthMonth = currentMonth) And (birthDay < currentDay)) Then
            resultYear = currentYear - birthYear
        End If

        ' Calculate Months
        resultMonth = currentMonth - birthMonth
        If birthDay > currentDay Then
            resultMonth -= 1
        End If
        If resultMonth < 0 Then
            resultMonth += 12
        End If

        ' Calculate Days
        If currentDay >= birthDay Then
            resultDay = currentDay - birthDay
        Else
            Dim daysInPrevMonth As Integer = Date.DaysInMonth(If(currentMonth = 1, currentYear - 1, currentYear), If(currentMonth = 1, 12, currentMonth - 1))
            resultDay = currentDay + daysInPrevMonth - birthDay
        End If

        Console.WriteLine("AGE IS  : " & resultYear & "years" & resultMonth & "month" & resultDay & "day")

        Console.ReadLine()
    End Sub

End Module
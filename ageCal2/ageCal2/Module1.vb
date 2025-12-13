Module Module1


    Sub Main()
        Dim currentDay, currentMonth, currentYear As Integer
        Dim birthDay, birthMonth, birthYear As Integer
        Dim resultDay, resultMonth, resultYear As Integer

        Console.WriteLine("AGE CALCULATOR")
        Console.WriteLine("----------------------")

        ' Get today's date
        currentDay = Date.Now.Day
        currentMonth = Date.Now.Month
        currentYear = Date.Now.Year

        Console.WriteLine("Today's date is " & currentDay & "/" & currentMonth & "/" & currentYear)
        Console.WriteLine("-----------------------------------------------------------------------")

        ' Get user birth date
        Console.WriteLine("Enter Birth Day (dd): ")
        birthDay = Console.ReadLine()

        Console.WriteLine("Enter Birth Month (mm): ")
        birthMonth = Console.ReadLine()

        Console.WriteLine("Enter Birth Year (yyyy): ")
        birthYear = Console.ReadLine()
        If (birthYear.ToString().Length <> 4) Then
            Console.WriteLine("Invalid Year, Year must be in 4 digit format (yyyy) ")
        ElseIf (birthYear > currentYear) Then

            Console.WriteLine("Invalid Birth Year!!! Can't be exceed " & currentYear.ToString())
        Else

            ' Calculate Years
            resultYear = currentYear - birthYear
            If (birthMonth > currentMonth) Or (birthMonth = currentMonth And birthDay > currentDay) Then
                resultYear -= 1
            End If

            ' Calculate Months
            resultMonth = currentMonth - birthMonth
            If birthDay > currentDay Then
                resultMonth -= 1
            End If
            If resultMonth < 0 Then
                resultMonth += 12
            End If

            ' Calculate Days using DaysInMonth
            If currentDay >= birthDay Then
                resultDay = currentDay - birthDay
            Else
                Dim daysInPrevMonth As Integer = System.DateTime.DaysInMonth(If(currentMonth = 1, currentYear - 1, currentYear), If(currentMonth = 1, 12, currentMonth - 1))
                resultDay = currentDay + daysInPrevMonth - birthDay
            End If

            ' Display the result
            Console.WriteLine("AGE IS  : " & resultYear & " years, " & resultMonth & " months, " & resultDay & " days")
            Console.ReadLine()
        End If
        Console.ReadLine()
    End Sub

End Module


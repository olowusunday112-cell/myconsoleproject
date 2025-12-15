Module Module1

    Sub Main()
        Dim currentDay, currentMonth, currentYear As Integer
        Dim birthDay, birthMonth, birthYear As Integer
        Dim resultDay, resultMonth, resultYear As Integer
        Dim choice As String

        Do
            Console.Clear()
            Console.WriteLine("AGE CALCULATOR")
            Console.WriteLine("----------------------")

            ' Get today's date
            currentDay = Date.Now.Day
            currentMonth = Date.Now.Month
            currentYear = Date.Now.Year

            Console.WriteLine("Today's date is " & currentDay & "/" & currentMonth & "/" & currentYear)
            Console.WriteLine("-----------------------------------------------------------------------")

            ' ===== INPUT & VALIDATION =====
            Console.WriteLine("Enter Birth Day (1 - 31): ")
            birthDay = Console.ReadLine()

            If birthDay < 1 Or birthDay > 31 Then
                Console.WriteLine("Invalid Day! Day must be between 1 and 31.")
                GoTo ContinueOption
            End If

            Console.WriteLine("Enter Birth Month (1 - 12): ")
            birthMonth = Console.ReadLine()

            If birthMonth < 1 Or birthMonth > 12 Then
                Console.WriteLine("Invalid Month! Month must be between 1 and 12.")
                GoTo ContinueOption
            End If

            Console.WriteLine("Enter Birth Year (yyyy): ")
            birthYear = (Console.ReadLine())

            If birthYear.ToString.Length <> 4 Then
                Console.WriteLine("Invalid Year! Year must be 4 digits (yyyy).")
                GoTo ContinueOption
            ElseIf birthYear > currentYear Or birthYear < 1 Then
                Console.WriteLine("Invalid Birth Year!")
                GoTo ContinueOption
            End If


            resultYear = currentYear - birthYear
            If (birthMonth > currentMonth) Or (birthMonth = currentMonth And birthDay > currentDay) Then
                resultYear -= 1
            End If

            resultMonth = currentMonth - birthMonth
            If birthDay > currentDay Then
                resultMonth -= 1
            End If
            If resultMonth < 0 Then
                resultMonth += 12
            End If

            If currentDay >= birthDay Then
                resultDay = currentDay - birthDay
            Else
                Dim daysInPrevMonth As Integer
                daysInPrevMonth = System.DateTime.DaysInMonth( _
                    If(currentMonth = 1, currentYear - 1, currentYear), _
                    If(currentMonth = 1, 12, currentMonth - 1))
                resultDay = currentDay + daysInPrevMonth - birthDay
            End If


            Console.WriteLine("-----------------------------------------------------------------------")
            Console.WriteLine("AGE IS : " & resultYear & " years, " & resultMonth & " months, " & resultDay & " days")

ContinueOption:
            Console.WriteLine()
            Console.Writeline("Do you want to calculate another age? (Y/N): ")
            choice = Console.ReadLine().ToUpper()

        Loop While choice = "Y"

    End Sub

End Module
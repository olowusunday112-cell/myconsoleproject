Module Module1

    Sub Main()
        'Declaration of Variables
        Dim currentDay, currentMonth, currentYear As Double
        Dim birthDay, birthMonth, birthYear As Double
        Dim resultDay, resultMonth, resultYear As Double
        Dim todaysDate As String

        Console.WriteLine(" Age Calculator ")
        Console.WriteLine()

        todaysDate = Date.Now
        currentDay = Date.Now.Day
        currentMonth = Date.Now.Month
        currentYear = Date.Now.Year

        Console.WriteLine("Today's Date is " & todaysDate.ToString & currentDay.ToString & " / " & currentMonth.ToString & " / " & currentYear.ToString & " / ")
        Console.WriteLine()
        Console.WriteLine("Enter Birth Day")
        birthDay = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Enter Birth Month")
        birthMonth = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Enter Birth Year")
        birthYear = Console.ReadLine()

        'resultYear = currentYear - birthYear
        'resultDay = currentDay - birthDay
        'resultMonth = currentMonth - birthMonth

        If ((birthMonth = currentMonth) And (birthDay < currentDay)) Then
            resultYear = currentYear - birthYear - 1
        ElseIf ((birthDay = currentDay) And (birthMonth < currentMonth)) Then

        End If



        Console.ReadLine()

    End Sub

End Module

Module Module1

    Sub Main()
        'Declaration of Variable
        Dim currentDay, currentMonth, currentYear As Integer
        Dim birthDay, birthMonth, birthYear As Integer
        Dim resultDay, resultMonth, resultYear As Integer

        Console.WriteLine("AGE CALCULATOR")
        Console.WriteLine("----------------------")


        currentDay = Date.Now.Day
        currentMonth = Date.Now.Month
        currentYear = Date.Now.Year

        Console.WriteLine("Todays date is " & currentDay.ToString & "/" & currentMonth.ToString & "/" & currentYear.ToString)

        Console.WriteLine("Enter Birth Day")
        birthDay = Console.ReadLine()
        Console.WriteLine("----------------------")


        Console.WriteLine("Enter Birth Month")
        birthMonth = Console.ReadLine()
        Console.WriteLine("----------------------")


        Console.WriteLine("Enter Birth Year")
        birthYear = Console.ReadLine()
        Console.WriteLine("----------------------")


        'resultYear = currentYear - birthYear
        If ((birthMonth = currentMonth) And (birthDay < currentDay)) Then
            resultYear = currentYear - birthYear - 1

        End If

        Console.WriteLine("AGE IS : " & resultYear.ToString & " Years")



        Console.ReadLine()
    End Sub

End Module

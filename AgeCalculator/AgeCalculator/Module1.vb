Imports System.Globalization

Module Module1


    Sub Main()


        Console.WriteLine("AGE CALCULATOR (YEARS, MONTHS, DAYS)")
        Console.WriteLine("------------------------------------")

        Console.WriteLine("ENTER YOUR DAY OF BIRTH (DD):")
        Dim day As Integer
        Integer.Parse(Console.ReadLine())
        Console.WriteLine("------------------------------------")
        Console.WriteLine("ENTER YOUR MONTH OF BIRTH (MM):")
        Dim month As Integer
        Integer.Parse(Console.ReadLine())
        Console.WriteLine("------------------------------------")
        Console.WriteLine("ENTER YOUR YEAR OF BIRTH (YYYY):")
        Dim year As Integer
        Integer.Parse(Console.ReadLine())
        Console.WriteLine("------------------------------------")
        Dim dob As Date
       
        Dim dobInput As String =
            Console.ReadLine()


        'Validate the final combined date
        Try

            dob = New Date(year, month, day)
        Catch ex As Exception
            Console.WriteLine("Invalid Date Format! Please enter DD/MM/YYYY.")
            Console.ReadLine()
            Return
            End
        End Try

        If dob > Date.Today Then

            Console.WriteLine("Date of Birth cannot be in the future")
            Console.ReadLine()
            Return
        End If

        Dim result As String = calculateAge(dob)

        Console.WriteLine()
        Console.WriteLine(result)
        Console.WriteLine()

        Console.WriteLine("Press ENTER to exit...")
        Console.ReadLine()

    End Sub

End Module

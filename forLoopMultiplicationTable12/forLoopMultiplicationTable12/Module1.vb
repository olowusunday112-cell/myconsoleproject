Module Module1

    Sub Main()
        Dim increment As Integer, number As Integer

        Console.WriteLine("MULTIPLICATION TABLE")
        Console.WriteLine("-------------------")
        Console.WriteLine("ENTER NUMBER TO MULTIPLICATION")
        number = Console.ReadLine()
        Console.WriteLine("------------------------------")

        For increment = 1 To 24

            Console.WriteLine(number & " * " & increment & " = " & (number * increment))
        Next

        Console.ReadLine()
    End Sub

End Module


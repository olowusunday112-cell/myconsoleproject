Module Module1

    Sub Main()
        Dim increment As Integer, number As Integer
        Console.WriteLine("SIMPLE FOR LOOP")
        Console.WriteLine("----------------")
        Console.WriteLine("ENTER NUMBER TO COUNT")
        Console.WriteLine("---------------")
        number = Console.ReadLine()
        Console.WriteLine("---------------")
        For increment = 1 To number


            Console.WriteLine(increment)

        Next


        Console.ReadLine()
    End Sub

End Module

Module Module1

    Sub Main()

        Dim mass1, mass2, distance, gravitation, a, b, c, force As Double
        Console.WriteLine("THIS SOFRWARE CALCULATE THE NEWTON'S LAW OF GRAVITATION")
        Console.WriteLine("ENTER VALUE FOR FIRST MASS (KG)")
        mass1 = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR SECOND MASS (KG)")
        mass2 = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR DISTANCE (M)")
        distance = Console.ReadLine()
        a = mass1 * mass2
        b = distance * distance
        c = a / b
        gravitation = 6.674 * 10 ^ -11
        force = gravitation * c
        Console.WriteLine("THE GRAVITATIONAL FORCE IS " & force & " Newton ")
        Console.ReadLine()
    End Sub

End Module

Module Module1

    Sub Main()

        Dim mass, velocity, a, b, KineticEnergy As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE KINETIC ENERGY")
        Console.WriteLine("ENTER VALUE FOR MASS (KG)")
        mass = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR VELOCITY (M/S)")
        velocity = Console.ReadLine()
        a = velocity * velocity
        b = 1 / 2
        KineticEnergy = b * mass * a
        Console.WriteLine("KINETIC ENERGY IS " + KineticEnergy.ToString("N") + " Joules ")











        Console.ReadLine()
    End Sub

End Module

Module Module1

    Sub Main()


        Dim radius, height, pi, a, b, c, d, volume As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE VOLUME OF A CONE")
        Console.WriteLine("ENTER VALUE FOR RADIUS(cm)")
        radius = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR HEIGHT(cm)")
        height = Console.ReadLine()
        pi = 3.142
        a = 1 / 3
        b = radius * radius
        c = pi
        d = a * c * b * height
        volume = d
        Console.WriteLine("THE RESULT FOR VOLUME OF A CONE IS " + volume.ToString("N") + (" cm "))




        Console.ReadLine()

    End Sub

End Module

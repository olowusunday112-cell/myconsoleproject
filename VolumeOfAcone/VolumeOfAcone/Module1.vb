Module Module1

    Sub Main()
        Dim radius, height, pi, a, b, d, volume As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE VOLUME OF A CONE")
        Console.WriteLine("ENTER VALUE FOR RADIUS(CM)")
        radius = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR HEIGHT(CM)")
        height = Console.ReadLine()
        pi = 3.142
        a = 1 / 3
        b = radius * radius

        d = a * pi * b * height
        volume = d
        Console.WriteLine("VOLUME OF A CONE IS " + volume.ToString("N") + (" CM "))



        Console.ReadLine()
    End Sub

End Module

Module Module1

    Sub Main()
        Dim y2, y1, x2, x1, w, u, slope As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE SLOPE OF A GRAPH")
        Console.WriteLine("ENTER VALUE FOR SECOND Y (Y2)")
        y2 = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR FIRST Y (Y1)")
        y1 = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR SECOND X (X2)")
        x2 = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR FIRST X (X1)")
        x1 = Console.ReadLine()
        w = y2 - y1
        u = x2 - x1
        slope = w / u
        Console.WriteLine("THE RESULT FOR SLOPE IS " + slope.ToString)

        Console.ReadLine()
    End Sub

End Module

Module Module1

    Sub Main()
        Dim b, a, c, d, e, f, g, h, i, j, x1, x2 As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE QUADRATIC EQUACTION USING ALMIGHTY FORMULAE")
        Console.WriteLine("ENTER VALUE FOR B")
        b = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR A")
        a = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR C")
        c = Console.ReadLine()
        d = b * b
        e = 4 * a * c
        f = d - e
        g = Math.Sqrt(f)
        h = 2 * a
        i = -b + g
        j = -b - g
        x1 = i / h
        x2 = j / h
        Console.WriteLine("X1 is " + x1.ToString)
        Console.WriteLine("X2 IS " + x2.ToString)







        Console.ReadLine()

    End Sub

End Module

Module Module1

    Sub Main()
        Dim a, b, c, d, e, f, g, h, i, j, k, l, m, n, p, q, r, s, t, u, v, det As Double
        Console.WriteLine("THIS SOFTWARE CALCULATE MATRIX OF THREE BY THREE [3 X 3] ")
        Console.WriteLine("ENTER VALUE FOR A")
        a = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR B")
        b = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR C")
        c = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR D")
        d = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR E")
        e = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR F")
        f = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR G")
        g = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR H")
        h = Console.ReadLine()
        Console.WriteLine("ENTER VALUE FOR I")
        i = Console.ReadLine()
        j = e * i
        k = f * h
        l = j - k
        m = d * i
        n = f * g
        p = m - n
        q = d * h
        r = e * g
        s = q - r
        t = a * l
        u = b * p
        v = c * s
        det = t - u + v
        Console.WriteLine("THIS RESULT FOR DETERMINANT IS " + det.ToString)

        Console.ReadLine()
    End Sub

End Module

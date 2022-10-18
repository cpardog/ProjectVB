Module Program
    Private suma As Integer
    Private resta As Integer
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("Bebe hermoso")
        'sumar(80, 20)
        'restar(80, 20)
        Console.WriteLine("La suma con la función sumar es {0}", Fsumar(80, 20))
        Console.WriteLine("La suma con la función restar es {0}", Frestar(80, 20))
        Console.WriteLine("La función potencia nos da {0}", Fpotencia(2, 10))
        Console.ReadKey()
    End Sub
    Private Sub sumar(par1 As Integer, par2 As Integer)
        suma = par1 + par2
        Console.WriteLine("La suma  esperada de los operandos es {0}", suma)
    End Sub
    Private Sub restar(par1 As Integer, par2 As Integer)
        resta = par1 - par2
        Console.WriteLine("La resta esperada de los operandos es {0}", resta)
    End Sub
    Private Function Fsumar(par1 As Integer, par2 As Integer) As Integer
        Fsumar = par1 + par2
    End Function
    Private Function Frestar(par1 As Integer, par2 As Integer) As Integer
        Frestar = par1 - par2
    End Function

    Private Function Fpotencia(par1 As Integer, par2 As Integer) As Double
        Return Math.Pow(CDbl(par1), CDbl(par2))
    End Function

End Module

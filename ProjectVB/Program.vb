Imports System

Module Program
    Public suma As Integer
    Public resta As Integer
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("Bebe hermoso")
        'sumar(80, 20)
        'restar(80, 20)
        Console.WriteLine("La suma con la función sumar es {0}", fsumar(80, 20))
        Console.WriteLine("La suma con la función restar es {0}", frestar(80, 20))
        Console.ReadKey()

    End Sub
    Public Sub sumar(par1 As Integer, par2 As Integer)
        suma = par1 + par2
        Console.WriteLine("La suma  esperada de los operandos es {0}", suma)
    End Sub
    Public Sub restar(par1 As Integer, par2 As Integer)
        resta = par1 - par2
        Console.WriteLine("La resta esperada de los operandos es {0}", resta)
    End Sub
    Public Function Fsumar(par1 As Integer, par2 As Integer) As Integer
        Fsumar = par1 + par2
    End Function
    Public Function Frestar(par1 As Integer, par2 As Integer) As Integer
        Frestar = par1 - par2
    End Function
End Module

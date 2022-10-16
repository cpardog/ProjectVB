Imports System

Module Program
    Public suma As Integer
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("Bebe hermoso")
        sumar(30, 30)
        Console.ReadKey()

    End Sub
    Public Sub sumar(par1 As Integer, par2 As Integer)
        suma = par1 + par2
        Console.WriteLine("La suma  esperada de los operandos es {0}", suma)

    End Sub
End Module

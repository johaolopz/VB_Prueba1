Module Module1

    Sub Main()
        Console.WriteLine("Bienvenidos al Ejercicio ESTUDIANTES")
        Console.WriteLine("")
        Console.Write("Ingrese el total de ahorros que dispone en USD (ej. 120,50): ")
        Dim ahorro As Double = Console.ReadLine()
        If ahorro >= 600 Then
            Console.WriteLine("Felicitaciones!!!, Usted puede ir a la U")
        Else
            Console.WriteLine("Lo sentimos, ahorre un poco más para la U")
        End If

    End Sub

End Module

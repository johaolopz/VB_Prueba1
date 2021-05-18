Module Module1

    Sub Main()
        Console.WriteLine("Bienvenidos al Ejercicio BUCLE WHILE")
        Console.WriteLine("")
        Console.Write("Ingrese un numero entero (ej. 26754): ")
        Dim numero As Integer = Console.ReadLine()
        Console.WriteLine("")
        Dim sumaDigitos As Integer = 0

        While numero > 0
            sumaDigitos += numero Mod 10
            numero = numero \ 10
            'Én la división entera se puede usar   numero = Math.Truncate(numero / 10)
        End While
        Console.WriteLine("La suma de los digitos es: " & sumaDigitos)

    End Sub

End Module

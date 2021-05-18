Module Module1

    Sub Main()
        Console.WriteLine("Bienvenidos al Ejercicio MENU")
        Console.WriteLine("")
        Console.Write("Ingrese número entero A : ")
        Dim numA As Integer = Console.ReadLine()
        Console.Write("Ingrese número entero B : ")
        Dim numB As Integer = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("MENU")
        Console.WriteLine("1.- SUMA")
        Console.WriteLine("2.- RESTA")
        Console.WriteLine("3.- MULTIPLICACIÓN")
        Console.WriteLine("4.- DIVISIÓN")
        Console.WriteLine("5.- PORCENTAJE")
        Console.WriteLine("")
        Console.Write("Ingrese una opción: ")
        Dim opcion As String = Console.ReadLine()
        Dim Total As Double = 0
        Dim opera As String = ""
        Select Case opcion
            Case "1"
                Total = numA + numB
                opera = "A + B"
            Case "2"
                Total = numA - numB
                opera = "A - B"
            Case "3"
                Total = numA * numB
                opera = "A * B"
            Case "4"
                Total = numA / numB
                opera = "A / B"
            Case "5"
                Total = numA Mod numB
                opera = "A % B"
            Case Else
                Console.WriteLine("Opción es incorrecta, Adiós...")
        End Select
        Console.WriteLine("El resultado de " & opera & " es: " & Total)
        'La siguiente linea es para pausar el compilador y ver los resultados
        'Console.ReadKey(True)
    End Sub

End Module

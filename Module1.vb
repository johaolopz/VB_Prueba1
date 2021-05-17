Module Module1

    Sub Main()
        Dim numero As Integer
        numero = 12
        'otra forma es Dim numero As Integer = 12
        Const PI As Double = 3.1416

        Console.Write("Ingrese un radio: ")
        Dim radio As Double = Console.ReadLine()
        Dim area As Double = PI * radio * radio

        Console.WriteLine("El area es: " & area)
        'La linea acotinuacion es para pausar hasta presionar una tecla
        'Console.ReadKey(True)"

    End Sub

End Module

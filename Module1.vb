Module Module1

    Sub Main()
        Console.WriteLine("Bienvenidos al Ejercicio BUCLE ANIDADO Y METODO GetUpperBound")
        Console.WriteLine("")
        Console.WriteLine("La siguiente matriz es 2x3")
        Dim matriz(2, 3) As Integer

        matriz(0, 0) = 49
        matriz(0, 1) = 57
        matriz(0, 2) = 28
        matriz(1, 0) = 16
        matriz(1, 1) = 3
        matriz(1, 2) = 89

        'GetUpperBound capta el índice del último elemento de la fila de un array
        For i = 0 To matriz.GetUpperBound(0) - 1 Step 1

            For j = 0 To matriz.GetUpperBound(1) - 1 Step 1

                Console.Write(matriz(i, j) & " ")

            Next
            Console.WriteLine()
        Next

    End Sub

End Module

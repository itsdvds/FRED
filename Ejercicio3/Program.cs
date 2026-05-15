
        Console.Write("Ingresa un número de 3 dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        // Verificamos que tenga 3 dígitos
        if (numero >= 100 && numero <= 999)
        {
            int centena = numero / 100;
            int unidad = numero % 10;

            if (centena == unidad)
            {
                Console.WriteLine("Es capicua.");
            }
            else
            {
                Console.WriteLine("Gracias");
            }
        }
        else
        {
            Console.WriteLine("El número no tiene 3 dígitos.");
        }



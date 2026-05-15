class program
{
    static void Main()
    {
        string[] palabras = new string[6]; // colocamos el tamaño del arreglo para almacenar 6 palabras
        int contadormay = 0; // los contadores
        int contadorA = 0;

        for (int i = 0; i < palabras.Length; i++) // ciclo for para recorrer el arreglo que en este caso lo recorreria 6 veces
        {
            Console.Write("ingrese una palabra: "); // pedimos una palabra al usuario
            palabras[i] = Console.ReadLine();

            if (palabras[i].Length > 7) // validamos si la palabra ingresada es mayor a 7 caracteres
            {
                contadormay++; // si la palabra es mayor a 7 caracteres se incrementa el contador
            }
           
            if (palabras[i].ToLower()[0] == 'a') // validamos si la letra a se encuentra en la palabra ingresada
            {
               contadorA++; // si la letra a se encuentra en la palabra ingresada se incrementa el contador
            }
        }

        Console.WriteLine("la cantidad de palabras mayores a 7 caracteres es: " + contadormay); // enseñamos los resultados al usuario
        Console.WriteLine("la cantidad de palabras que comienzan con la letra a es: " + contadorA);
    }
}

//¿Cómo se almacenan las palabras dentro del arreglo? mediante pocisiones
//¿Cómo se utiliza .Length para contar letras?  se coloca el nombre de  la variable seguido de un punto y luego la palabra Length
//¿Cómo funciona el ciclo for en su programa? se le da la cantidad de veces que se va repetir al llegar a la cantidad maxima se detiene el ciclo
//¿Qué hace la condición if dentro del ciclo?  valida si la palabra ingresada es mayor a 7 caracteres y si contiene la letra a
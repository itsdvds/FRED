class program
{
    static void Main()
    { 
        int[] num = new int[8]; // se declara un arreglo de enteros con una capacidad de 8 elementos
        int contp = 0; // colocamos contadores
        int contn = 0;
        int sum = 0; // y una variable para acumular la suma de los numeros ingresados

        for (int i = 0; i < num.Length; i++) // se coloca un for para recorrer el arreglo y pedir al usuario que ingrese un numero en cada pocision del arreglo
        {
            Console.Write("coloque un numero:"); // se pide al usuario que ingrese un numero y
            num[i] = int.Parse(Console.ReadLine());

            if (num[i] > 0) // si el numero es mayor a 0 se suma al contador de positivos, si no se suma al contador de negativos
            {
                contp++;
            }
            else
            {
                contn++;
            }

            sum += num[i]; // se suman todos los numeros
        }

        Console.WriteLine("la cantidad de numeros positivos es: " + contp); // se dan los resultados al usuario
        Console.WriteLine("la cantidad de numeros negativos es: " + contn);
        Console.WriteLine("la suma de los numeros es: " + sum);

        //¿Cómo se almacenan los números en el arreglo? mediante pocisiones cada numero tiene una pocision asignada
        //  ¿Qué variable se utilizó para acumular la suma?   la variable sum se utilizo para acumular la suma de los numeros ingresados
        // ¿Cómo funciona el recorrido del arreglo?  empieza en la pocision 0 y va aumentando hasta llegar a la ultima pocision
        //¿Qué condiciones se usaron para clasificar los números?  si el numero es mayo a 0 es positivo si no es negativo
    }


}
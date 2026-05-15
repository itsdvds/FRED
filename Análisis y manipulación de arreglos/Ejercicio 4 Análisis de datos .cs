class program
{
    static void Main()
    {
        int[] num = new int[5];
        int sum = 0;
        int contmayp = 0;

        for (int i = 0; i < num.Length; i++)
        {
            Console.Write("coloque un numero:");
            num[i] = int.Parse(Console.ReadLine());

            sum += num[i];

        }

        double promedio = (double)sum / num.Length;

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > promedio)
            {
                contmayp++;
            }  
        }

        Console.WriteLine("el promedio es: " + promedio);
        Console.WriteLine("la cantidad de numeros mayores al promedio es: " + contmayp);

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("los numeros son: " + num[i]);
        }
    }

}
//¿Cómo se calculó el promedio?  con la suma de todos los numeros dividido por la cantidad de numeros que se ingresaron usando un .lenght
//¿Por qué el arreglo debe recorrerse más de una vez? para poder calcular todos los numeros que contiene el arreglo
//¿Cómo se determinó qué números son mayores al promedio? con una condicion que seria num[i] > promedio y se coloco un contador para saber cuales
//¿Qué ocurriría si el ciclo for no utilizara .Length? no tendriamos la cantidad exacta de numeros o si la supieramos la cantidadd y la colocariamos en numero el problema seria que si en un fuuro se quisiera cambiar seria mas dificil ya que abria que cambiar 1 por 1 dependiendo cuantos for hay
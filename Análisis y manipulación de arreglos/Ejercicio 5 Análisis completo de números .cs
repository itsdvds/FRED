class program
{
    static void Main()
    {
        int[] num = new int[10];

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("coloque el numero :");
            num[i] = int.Parse(Console.ReadLine());
        }
        
        int mayor = num[0];
        int menor = num[0];
        int contp = 0;
        int conti = 0;
        int sum = 0;
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] > mayor)
            {
                mayor = num[i];
            }
            else if (num[i] < menor)
            {
                menor = num[i];
            }

            if (num[i]%2 == 0)
            {
                contp++;
            }
            else
            {
                conti++;
            }

            sum += num[i];
        }



        Console.WriteLine("el numero mayor es : " + mayor);
        Console.WriteLine("el numero menor es : " + menor);
        Console.WriteLine("la cantidad de numeros pares es : " + contp);
        Console.WriteLine("la cantidad de numeros impares es : " + conti);
        Console.WriteLine("la suma total es de: " + sum);
    }
}
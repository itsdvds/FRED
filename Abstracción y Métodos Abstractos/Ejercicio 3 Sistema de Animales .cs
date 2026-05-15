abstract class Animal
{
    public abstract void Comer();
}
class León : Animal
{
    public override void Comer()
    {
        Console.WriteLine("El león come carne.");
    }
}
class Jirafa : Animal
{
    public override void Comer()
    {
        Console.WriteLine("La jirafa come hojas.");
    }
}
class Pingüino: Animal
{
    public override void Comer()
    {
        Console.WriteLine("El pingüino come pescado.");
    }
}
class Program
{
    static void Main()
    {
        Animal león = new León();
        Animal jirafa = new Jirafa();
        Animal pingüino = new Pingüino();
        león.Comer(); 
        jirafa.Comer(); 
        pingüino.Comer(); 
    }
}

//¿Qué define la abstracción en este caso? Define la clase abstracta "Animal" que establece un contrato para las clases derivadas, obligándolas a implementar el método "Comer". Esto permite que cada tipo de animal tenga su propia implementación específica de cómo come, mientras se mantiene una interfaz común para todos los animales.
//¿Por qué todas las hijas deben implementar Comer()?  porque si no no tendria sentido usar abstraccion 
//¿Qué diferencia hay entre clase abstracta y clase normal? aca simplificamos el codigo en una normal no 
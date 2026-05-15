abstract class Transporte
{
    public abstract void Mover();
}
class Bus : Transporte
{
    public override void Mover()
    {
        Console.WriteLine("El bus se mueve por la carretera.");
    }
}
class Metro : Transporte
{
    public override void Mover()
    {
        Console.WriteLine("El metro se mueve por las vías subterráneas.");
    }
}
class Taxi : Transporte
{
    public override void Mover()
    {
        Console.WriteLine("El taxi se mueve por la ciudad.");
    }
}
class Program
{
    static void Main()
    {
        Transporte bus = new Bus();
        Transporte metro = new Metro();
        Transporte taxi = new Taxi();
        bus.Mover();
        metro.Mover();
        taxi.Mover();
    }
}

//¿Qué representa la clase abstracta?  respuesta: La clase abstracta "Transporte" representa un concepto general de transporte, definiendo un método abstracto "Mover" que debe ser implementado por todas las clases derivadas. Esto permite que cada tipo de transporte (Bus, Metro, Taxi) tenga su propia implementación específica del método "Mover", mientras que comparten una interfaz común a través de la clase abstracta.
//¿Por qué no tendría sentido crear un “transporte genérico”? porque el concepto de "transporte genérico" no proporciona detalles específicos sobre cómo se mueve o qué características tiene. Cada tipo de transporte tiene sus propias características y formas de moverse
//¿Qué cambia en cada hija? la accion 
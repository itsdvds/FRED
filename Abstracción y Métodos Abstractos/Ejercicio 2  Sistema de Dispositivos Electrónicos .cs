abstract class Dispositivo
{
    public abstract void Encender();
}
class Televisor : Dispositivo
{
    public override void Encender()
    {
        Console.WriteLine("El televisor se ha encendido.");
    }
}
class Laptop : Dispositivo
{
    public override void Encender()
    {
        Console.WriteLine("La laptop se ha encendido.");
    }
}
class Consola : Dispositivo
{
    public override void Encender()
    {
        Console.WriteLine("La consola se ha encendido.");
    }
}
class Program
{
    static void Main()
    {
        Dispositivo televisor = new Televisor();
        Dispositivo laptop = new Laptop();
        Dispositivo consola = new Consola();
        televisor.Encender();
        laptop.Encender();
        consola.Encender();
    }
}

//¿Qué comportamiento comparten? Todos los dispositivos comparten el comportamiento de poder encenderse, definido por el método abstracto Encender() en la clase base Dispositivo.
// ¿Qué comportamiento cambia?  el comportamiento que cambia es la implementación específica del método Encender() en cada clase derivada (Televisor, Laptop, Consola). Cada dispositivo tiene su propia forma de encenderse, lo que se refleja en la implementación del método Encender() en cada clase.
//¿Qué ventaja tiene usar abstracción aquí? que ventajas tiene usar abstracción aquí? La ventaja de usar abstracción en este caso es que permite definir una interfaz común (el método Encender()) para todos los dispositivos, lo que facilita la gestión y el uso de diferentes tipos de dispositivos sin preocuparse por los detalles específicos de cada uno. Esto promueve la reutilización del código y mejora la mantenibilidad, ya que se puede agregar fácilmente nuevos tipos de dispositivos sin modificar el código existente.

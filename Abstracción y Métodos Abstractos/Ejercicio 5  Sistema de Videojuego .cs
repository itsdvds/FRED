abstract class Personaje
{
    public abstract void UsarHabilidad();
}
class Guerrero : Personaje
{
    public override void UsarHabilidad()
    {
        Console.WriteLine("El guerrero ataca con su espada.");
    }
}
class Mago : Personaje
{
    public override void UsarHabilidad()
    {
        Console.WriteLine("El mago lanza un hechizo de fuego.");
    }
}
class Arquero : Personaje
{
    public override void UsarHabilidad()
    {
        Console.WriteLine("El arquero dispara una flecha.");
    }
}
class Program
{
    static void Main()
    {
        Personaje guerrero = new Guerrero();
        Personaje mago = new Mago();
        Personaje arquero = new Arquero();

        guerrero.UsarHabilidad();
        mago.UsarHabilidad();
        arquero.UsarHabilidad();
    }
}
//¿Qué representa la abstracción en el juego? representa la capicidad de definir una clase base que estable el meteodo usarhabiliddad() 
//¿Por qué todas las clases deben tener UsarHabilidad()? porque es el que les hereda la clase base Personaje, y cada clase concreta (Guerrero, Mago, Arquero) debe proporcionar su propia implementación de ese método para definir su habilidad específica.
//¿Qué ventaja tendría esto en un videojuego grande? la ventaja seria que poermite tener una estructura clara y organizada para los personajes del juego
//¿Qué problema resuelve la abstracción? solociona el problema de tener que definir un comportamiento diferente para cada objeto 
//¿Qué diferencia hay entre herencia y abstracción?  la herencia es un mecanismo que permite a una clase derivada hederar propiedades y metos en cambio la abstraccion es un comcepto que permite definir un molde para cada clase
//¿Por qué los métodos abstractos no tienen implementación? porque su propósito es definir un contrato que las clases derivadas deben cumplir, y cada clase concreta debe proporcionar su propia implementación específica del método abstracto.
//¿Qué ventajas tiene obligar a las hijas a implementar métodos? que garantiza que todas las clases tiene ese comportamiento definido 
// ¿Dónde creen que se usa abstracción en sistemas reales? en sistemas donde hayq ue asignar una diferente accion a un metof¿do para diferentes objetos 
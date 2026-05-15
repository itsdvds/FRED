class Personaje
{
    public virtual void Atacar()
    {
        Console.WriteLine("Atacar....");
    }
}
class Guerrero : Personaje
{
    public override void Atacar()
    {
        Console.WriteLine("Espada");
    }
}
class Mago : Personaje
{
    public override void Atacar()
    {
        Console.WriteLine("Hechizo ");
    }
}
class Arquero : Personaje
{
    public override void Atacar()
    {
        Console.WriteLine("Flechas");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Guerrero g1 = new Guerrero();
        Mago m1 = new Mago();
        Arquero a1 = new Arquero();

        g1.Atacar();
        m1.Atacar();
        a1.Atacar();


    }
}

//¿Qué ventaja tiene usar un solo método? se puede reutilizar el codigo al solo modificarlo 
//¿Qué cambia entre objetos?   la accion
//¿Qué hace override? sobrescrive el metodo de la clase padre
class Empleado
{
    public virtual void Trabajar()
    {
        Console.WriteLine("Trabajando...");
    }
}
class Programador : Empleado
{
    public override void Trabajar()
    {
        Console.WriteLine("Desarrolla software");
    }
}
class Diseñador : Empleado
{
    public override void Trabajar()
    {
        Console.WriteLine("Crea interfaces ");
    }
}
class Contador: Empleado
{
    public override void Trabajar()
    {
        Console.WriteLine("Revisa finanzas ");
    }
}
class Program
{
    static void Main()
    {
        Programador p1 = new Programador();
        Diseñador d1 = new Diseñador();
        Contador c1 = new Contador();

        p1.Trabajar();
        d1.Trabajar();
        c1.Trabajar();
    }
}

//¿Qué comportamiento heredaron?  Trabajar
//¿Qué comportamiento sobrescribieron?  la accion de trabajar
// ¿Por qué el método tiene el mismo nombre?  porque es el mismo metodo que se hereda de la clase padre, pero cada clase hija lo implementa de manera diferente, por eso se llama igual pero hace cosas diferentes dependiendo de la clase.
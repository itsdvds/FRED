abstract class Usuario
{
    public abstract void AccederSistema();
}
class Administrador : Usuario
{
    public override void AccederSistema()
    {
        Console.WriteLine("Accediendo al sistema como Administrador...");
    }
}
class Cliente : Usuario
{
    public override void AccederSistema()
    {
        Console.WriteLine("Accediendo al sistema como Cliente...");
    }
}
class Empleado : Usuario
{
    public override void AccederSistema()
    {
        Console.WriteLine("Accediendo al sistema como Empleado...");
    }
}
class Program
{
    static void Main()
    {
        Usuario admin = new Administrador();
        Usuario cliente = new Cliente();
        Usuario empleado = new Empleado();
        admin.AccederSistema();
        cliente.AccederSistema();
        empleado.AccederSistema();
    }
}

// ¿Qué representa la clase Usuario? a la clase padre la clase abstracta
// ¿Qué acciones cambian según el tipo de usuario? la accion de acceder al sistema ccambia segun el tipo de usuario
//¿Por qué esto ayuda a organizar el sistema?  porque simplifica el codigo y se ve de una forma mas ordenada y clara 
class Notificacion
{
    public virtual void Enviar()
    {
        Console.WriteLine("Enviando notificación...");
    }
}
class Correo : Notificacion
{
    public override void Enviar()
    {
        Console.WriteLine("Enviar email");
    }
}
class SMS : Notificacion
{
    public override void Enviar()
    {
        Console.WriteLine("Enviar mensaje");
    }
}
class Push : Notificacion
{
    public override void Enviar()
    {
        Console.WriteLine("Enviar notificación móvil");
    }
}
class Program
{
    static void Main()
    {
        Correo c1 = new Correo();
        SMS s1 = new SMS();
        Push p1 = new Push();

        c1.Enviar();
        s1.Enviar();
        p1 = new Push(); 
    }
}

//¿Qué comportamiento comparten todas?  EL comportamiento enviar()
// ¿Qué cambia en cada hija?  La accion que se realiza al enviar la notificación, es decir, el mensaje que se muestra en consola.
//¿Por qué esto es polimorfismo? porque se modifican los datos es desir se sobrescribe el metodo enviar()
//¿Qué problema resuelve el polimorfismo? tener tanto codigo
// ¿Por qué no sería buena idea crear métodos totalmente distintos para todo?  porque usariamos muchas lineas de codigo y no seria reutilizable, ademas de que no se podria modificar el comportamiento de cada clase hija sin afectar a las demas.
//¿Qué ventaja tiene usar override?  poder sobrescribir en los metodos 
//¿Qué diferencia hay entre herencia y polimorfismo? que la herencia es igual en cambio el polimorfismo se pueden modificar las acciones heredaradas de la clase padre
//¿Dónde creen que se usa esto en programas reales? en programas de notificaciones, como por ejemplo en aplicaciones de mensajeria, donde se pueden enviar diferentes tipos de notificaciones (correo, sms, push) pero todas comparten el mismo comportamiento de enviar.
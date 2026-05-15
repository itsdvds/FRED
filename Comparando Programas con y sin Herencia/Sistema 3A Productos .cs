class Electronico
{
    public string nombre;
    public int precio;

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: " + precio);
        Console.WriteLine();
    }
}
class Alimenticio
{
    public string nombre;
    public int precio;

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: " + precio);
    }
}
class Program
{
    static void Main()
    {
        Electronico E1 = new Electronico();
        E1.nombre = "Refrigerador";
        E1.precio = 200;
        E1.MostrarDatos();

        Alimenticio A1 = new Alimenticio();
        A1.nombre = "Manzana";
        A1.precio = 10;
        A1.MostrarDatos();
    }
}
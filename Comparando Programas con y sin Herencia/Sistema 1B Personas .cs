class Persona
{
    public string Nombre;
    public int Edad;

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
    }
}
class Profesor : Persona
{
    public string curso;

    public void Curso()
    {
        Console.WriteLine("Curso: " + curso); 
    }
}
class Estudiante : Persona
{
    public string carrera;

    public void Carrera()
    {
        Console.WriteLine("Carrera: " + carrera);
    }
}
class Program
{
    static void Main()
    {
        Profesor p1 = new Profesor();
        p1.Nombre = "Pepe";
        p1.Edad = 29;
        p1.curso = "Matematicas";
        p1.MostrarDatos();
        p1.Curso();

        Estudiante E1 = new Estudiante();

        E1.Nombre = "Enrrique";
        E1.Edad = 19;
        E1.carrera = "Ingenieria";
        E1.MostrarDatos();
        E1.Carrera();
    }
}
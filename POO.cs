// 1. Encapsulación
public class Estudiante
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }
}

// 2. Herencia
public class EstudianteUniversitario : Estudiante
{
    private string universidad;

    public string Universidad
    {
        get { return universidad; }
        set { universidad = value; }
    }
}

// 3. Polimorfismo
public class EstudianteSecundaria : Estudiante
{
    private string escuelaSecundaria;

    public string EscuelaSecundaria
    {
        get { return escuelaSecundaria; }
        set { escuelaSecundaria = value; }
    }
}

// Capa de entidades
public class Entidades
{
    public Estudiante Estudiante { get; set; }
    public EstudianteUniversitario EstudianteUniversitario { get; set; }
    public EstudianteSecundaria EstudianteSecundaria { get; set; }
}

// Capa de presentación
public class Presentacion
{
    public void MostrarEstudiante(Estudiante estudiante)
    {
        Console.WriteLine("Nombre: " + estudiante.Nombre);
        Console.WriteLine("Edad: " + estudiante.Edad);
    }
}

using System;

class Persona
{
    protected int edad;

    public void Saludar()
    {
        Console.WriteLine("Hola");
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }
}

class Estudiante : Persona
{
    public void Estudiar()
    {
        Console.WriteLine("Estoy estudiando");
    }

    public void VerEdad()
    {
        Console.WriteLine("Mi edad es: " + edad + " años");
    }
}

class Profesor : Persona
{
    public void Explicar()
    {
        Console.WriteLine("Estoy explicando");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Saludar();

        Estudiante estudiante = new Estudiante();
        estudiante.SetEdad(16);
        estudiante.Saludar();
        estudiante.VerEdad();
        estudiante.Estudiar();

        Profesor profesor = new Profesor();
        profesor.SetEdad(40);
        profesor.Saludar();
        profesor.Explicar();

        Console.ReadKey();
    }
}



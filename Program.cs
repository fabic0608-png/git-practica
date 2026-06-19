using System;

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

class Cuenta
{
    protected Persona titular;
    protected double cantidad;

    public Cuenta(Persona titular, double cantidad)
    {
        this.titular = titular;
        this.cantidad = cantidad;
    }

    public virtual void Retirar(double monto)
    {
        cantidad -= monto;
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("Titular: " + titular.Nombre);
        Console.WriteLine("Cantidad: $" + cantidad);
    }
}

class CuentaJoven : Cuenta
{
    private double bonificacion;

    public CuentaJoven(Persona titular, double cantidad, double bonificacion)
        : base(titular, cantidad)
    {
        this.bonificacion = bonificacion;
    }

    public double Bonificacion
    {
        get { return bonificacion; }
        set { bonificacion = value; }
    }

    public bool EsTitularValido()
    {
        return titular.Edad >= 18 && titular.Edad < 25;
    }

    public override void Retirar(double monto)
    {
        if (EsTitularValido())
        {
            cantidad -= monto;
            Console.WriteLine("Retiro realizado.");
        }
        else
        {
            Console.WriteLine("No puede retirar dinero. Titular no válido.");
        }
    }

    public override void Mostrar()
    {
        Console.WriteLine("Cuenta Joven");
        Console.WriteLine("Titular: " + titular.Nombre);
        Console.WriteLine("Cantidad: $" + cantidad);
        Console.WriteLine("Bonificación: " + bonificacion + "%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Persona p = new Persona("Fabiana", 20);

        CuentaJoven cuenta = new CuentaJoven(p, 1000, 10);

        cuenta.Mostrar();

        cuenta.Retirar(200);

        cuenta.Mostrar();

        Console.ReadKey();
    }
}
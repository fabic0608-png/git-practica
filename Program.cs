using System;

class Dado
{
    private int valor;
    private static Random aleatorio = new Random();

    public Dado()
    {
        valor = 0;
    }

    public void Tirar()
    {
        valor = aleatorio.Next(1, 7);
    }

    public void Imprimir()
    {
        Console.WriteLine("Valor del dado: " + valor);
    }

    public int RetornarValor()
    {
        return valor;
    }
}

class JuegoDeDados
{
    private Dado dado1;
    private Dado dado2;
    private Dado dado3;

    public JuegoDeDados()
    {
        dado1 = new Dado();
        dado2 = new Dado();
        dado3 = new Dado();
    }

    public void Jugar()
    {
        dado1.Tirar();
        dado2.Tirar();
        dado3.Tirar();

        dado1.Imprimir();
        dado2.Imprimir();
        dado3.Imprimir();

        if (dado1.RetornarValor() == dado2.RetornarValor() &&
            dado2.RetornarValor() == dado3.RetornarValor())
        {
            Console.WriteLine("¡Ganó!");
        }
        else
        {
            Console.WriteLine("Perdió");
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        JuegoDeDados juego = new JuegoDeDados();
        juego.Jugar();

        Console.ReadKey();
    }
}


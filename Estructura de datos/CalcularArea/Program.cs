using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CÍRCULO ===");
        Circulo c = new Circulo(5);
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        Console.WriteLine("\n=== CUADRADO ===");
        Cuadrado q = new Cuadrado(4);
        Console.WriteLine("Área: " + q.CalcularArea());
        Console.WriteLine("Perímetro: " + q.CalcularPerimetro());
    }
}

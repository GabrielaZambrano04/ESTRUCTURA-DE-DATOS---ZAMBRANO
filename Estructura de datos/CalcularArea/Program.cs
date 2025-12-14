using System;

class Program
{
    static void Main()
    {
        Circulo c = new Circulo(5);
        Cuadrado q = new Cuadrado(4);

        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine($"Área: {c.CalcularArea()}");
        Console.WriteLine($"Perímetro: {c.CalcularPerimetro()}");

        Console.WriteLine("\n=== CUADRADO ===");
        Console.WriteLine($"Área: {q.CalcularArea()}");
        Console.WriteLine($"Perímetro: {q.CalcularPerimetro()}");
    }
}

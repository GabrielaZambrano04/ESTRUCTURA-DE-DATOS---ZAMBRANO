using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TRABAJO: USO DE PILAS EN C#");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Opción: ");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                BalanceoExpresion.Ejecutar();
                break;

            case "2":
                TorresDeHanoi.Ejecutar();
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.ReadKey();
    }
}


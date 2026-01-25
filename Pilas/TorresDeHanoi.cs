using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese el número de discos: ");
        int n = int.Parse(Console.ReadLine());

        Stack<int> A = new Stack<int>();
        Stack<int> B = new Stack<int>();
        Stack<int> C = new Stack<int>();

        for (int i = n; i >= 1; i--)
            A.Push(i);

        Console.WriteLine("\nMovimientos:\n");

        Resolver(n, A, B, C, 'A', 'B', 'C');
    }

    static void Resolver(int n, Stack<int> origen, Stack<int> auxiliar,
                          Stack<int> destino, char o, char a, char d)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {o} a {d}");
            return;
        }

        Resolver(n - 1, origen, destino, auxiliar, o, d, a);

        int actual = origen.Pop();
        destino.Push(actual);
        Console.WriteLine($"Mover disco {actual} de {o} a {d}");

        Resolver(n - 1, auxiliar, origen, destino, a, o, d);
    }
}

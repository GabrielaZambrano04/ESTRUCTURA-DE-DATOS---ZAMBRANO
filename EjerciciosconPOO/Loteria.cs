using System;
using System.Collections.Generic;

class Loteria
{
    List<int> numeros = new List<int>();

    public void GenerarNumeros()
    {
        Random random = new Random();

        while (numeros.Count < 6)
        {
            int numero = random.Next(1, 50); // números entre 1 y 49

            // evitar números repetidos
            if (!numeros.Contains(numero))
            {
                numeros.Add(numero);
            }
        }
    }

    public void MostrarOrdenados()
    {
        numeros.Sort();
        Console.WriteLine("Números ganadores ordenados:");

        foreach (int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}


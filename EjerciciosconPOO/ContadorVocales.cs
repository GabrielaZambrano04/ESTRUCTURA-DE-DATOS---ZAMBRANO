using System;
using System.Collections.Generic;

class ContadorVocales
{
    private string palabra;

    public ContadorVocales(string palabra)
    {
        this.palabra = palabra.ToLower();
    }

    public void MostrarConteo()
    {
        Dictionary<char, int> vocales = new Dictionary<char, int>()
        {
            {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}
        };

        foreach (char c in palabra)
        {
            if (vocales.ContainsKey(c))
                vocales[c]++;
        }

        foreach (var vocal in vocales)
        {
            Console.WriteLine($"La vocal {vocal.Key} aparece {vocal.Value} veces");
        }
    }
}

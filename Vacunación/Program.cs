using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // ===== 1. Crear universo de 500 ciudadanos =====
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano_{i}");
        }

        // ===== 2. Generar 75 vacunados con Pfizer =====
        HashSet<string> vacunadosPfizer = GenerarSubconjunto(ciudadanos, 75);

        // ===== 3. Generar 75 vacunados con AstraZeneca =====
        HashSet<string> vacunadosAstraZeneca = GenerarSubconjunto(ciudadanos, 75);

        // ===== 4. Operaciones de teoría de conjuntos =====

        // Unión: ciudadanos vacunados con al menos una dosis
        HashSet<string> vacunados = new HashSet<string>(vacunadosPfizer);
        vacunados.UnionWith(vacunadosAstraZeneca);

        // No vacunados
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunados);

        // Ambas dosis
        HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
        ambasDosis.IntersectWith(vacunadosAstraZeneca);

        // Solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Solo AstraZeneca
        HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // ===== 5. Mostrar resultados =====
        MostrarResultados("NO VACUNADOS", noVacunados);
        MostrarResultados("AMBAS DOSIS", ambasDosis);
        MostrarResultados("SOLO PFIZER", soloPfizer);
        MostrarResultados("SOLO ASTRAZENECA", soloAstraZeneca);
    }

    static HashSet<string> GenerarSubconjunto(HashSet<string> universo, int cantidad)
    {
        Random rnd = new Random();
        List<string> lista = universo.ToList();
        HashSet<string> subconjunto = new HashSet<string>();

        while (subconjunto.Count < cantidad)
        {
            int indice = rnd.Next(lista.Count);
            subconjunto.Add(lista[indice]);
        }

        return subconjunto;
    }

    static void MostrarResultados(string titulo, HashSet<string> conjunto)
    {
        Console.WriteLine($"\n=== {titulo} ===");
        Console.WriteLine($"Cantidad: {conjunto.Count}");

        foreach (var ciudadano in conjunto.Take(10)) // muestra solo 10 ejemplos
        {
            Console.WriteLine(ciudadano);
        }
    }
}

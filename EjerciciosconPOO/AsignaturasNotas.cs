using System;

class AsignaturasNotas
{
    string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    double[] notas = new double[5];

    public void GenerarNotas()
    {
        Random random = new Random();

        for (int i = 0; i < asignaturas.Length; i++)
        {
            notas[i] = random.Next(0, 11); // notas entre 0 y 10
        }
    }

    public void MostrarNotas()
    {
        for (int i = 0; i < asignaturas.Length; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}


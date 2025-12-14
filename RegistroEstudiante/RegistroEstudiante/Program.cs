using System;

Estudiante estudiante = new Estudiante();

Console.Write("Ingrese el ID: ");
estudiante.Id = int.Parse(Console.ReadLine());

Console.Write("Ingrese los nombres: ");
estudiante.Nombres = Console.ReadLine();

Console.Write("Ingrese los apellidos: ");
estudiante.Apellidos = Console.ReadLine();

Console.Write("Ingrese la dirección: ");
estudiante.Direccion = Console.ReadLine();

for (int i = 0; i < estudiante.Telefonos.Length; i++)
{
    Console.Write($"Ingrese el teléfono {i + 1}: ");
    estudiante.Telefonos[i] = Console.ReadLine();
}

Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
estudiante.MostrarDatos();



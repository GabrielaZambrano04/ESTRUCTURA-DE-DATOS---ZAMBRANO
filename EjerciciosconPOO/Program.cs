using System;

class Program
{
    static void Main()
    {
        // EJERCICIO 1 - ASIGNATURAS
        Console.WriteLine("EJERCICIO 1 - ASIGNATURAS");
        Asignaturas asignaturas = new Asignaturas();
        asignaturas.MostrarAsignaturas();

        // EJERCICIO 2 - ASIGNATURAS NOTAS
        Console.WriteLine("\nEJERCICIO 2 - ASIGNATURAS NOTAS");
        AsignaturasNotas asignaturasNotas = new AsignaturasNotas();
        asignaturasNotas.GenerarNotas();
        asignaturasNotas.MostrarNotas();


        // EJERCICIO 3 - CONTADOR DE VOCALES
        Console.WriteLine("\nEJERCICIO 3 - CONTADOR DE VOCALES");
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        ContadorVocales contador = new ContadorVocales(palabra);
        contador.MostrarConteo();

        // EJERCICIO 4 - LOTERÍA
       Console.WriteLine("\nEJERCICIO 4 - LOTERÍA");
       Loteria loteria = new Loteria();
       loteria.GenerarNumeros();
       loteria.MostrarOrdenados();


        // EJERCICIO 5 - PRECIOS
        Console.WriteLine("\nEJERCICIO 5 - PRECIOS");
        Precios precios = new Precios();
        precios.MostrarMinMax();

        Console.ReadKey();
    }
}








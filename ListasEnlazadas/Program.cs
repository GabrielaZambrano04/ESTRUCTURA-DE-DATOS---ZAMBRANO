using System;

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Insertar(10);
        lista.Insertar(20);
        lista.Insertar(30);
        lista.Insertar(40);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Ejercicio 1
        Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());

        // Ejercicio 2
        lista.InvertirLista();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();

        Console.ReadKey();
    }
}


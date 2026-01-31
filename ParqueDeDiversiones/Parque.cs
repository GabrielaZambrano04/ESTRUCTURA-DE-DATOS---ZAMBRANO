using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase Persona
    class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    // Clase Atraccion
    class Atraccion
    {
        private Queue<Persona> cola;
        private const int capacidadMaxima = 30;

        public Atraccion()
        {
            cola = new Queue<Persona>();
        }

        // Agregar persona a la cola
        public void AgregarPersona(Persona persona)
        {
            if (cola.Count < capacidadMaxima)
            {
                cola.Enqueue(persona);
                Console.WriteLine($"{persona.Nombre} entró a la cola.");
            }
            else
            {
                Console.WriteLine("Todos los asientos están vendidos.");
            }
        }

        // Subir personas a la atracción
        public void IniciarAtraccion()
        {
            Console.WriteLine("\n🎢 Iniciando la atracción...\n");

            while (cola.Count > 0)
            {
                Persona persona = cola.Dequeue();
                Console.WriteLine($"{persona.Nombre} sube a la atracción.");
            }

            Console.WriteLine("\nLa atracción ha comenzado. No hay más personas en la cola.");
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion();

            // Simulación de llegada de personas
            for (int i = 1; i <= 30; i++)
            {
                atraccion.AgregarPersona(new Persona($"Persona {i}"));
            }

            // Intento de agregar una persona extra
            atraccion.AgregarPersona(new Persona("Persona 31"));

            // Iniciar la atracción
            atraccion.IniciarAtraccion();

            Console.ReadKey();
        }
    }
}

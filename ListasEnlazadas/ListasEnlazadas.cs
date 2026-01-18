using System;

class ListaEnlazada
{
    private Nodo cabeza;

    // Insertar al final
    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
            cabeza = nuevo;
        else
        {
            Nodo aux = cabeza;
            while (aux.Siguiente != null)
                aux = aux.Siguiente;

            aux.Siguiente = nuevo;
        }
    }

    // ============================
    // EJERCICIO 1
    // Contar elementos
    // ============================
    public int ContarElementos()
    {
        int contador = 0;
        Nodo aux = cabeza;

        while (aux != null)
        {
            contador++;
            aux = aux.Siguiente;
        }

        return contador;
    }

    // ============================
    // EJERCICIO 2
    // Invertir lista
    // ============================
    public void InvertirLista()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        cabeza = anterior;
    }

    // Mostrar lista
    public void Mostrar()
    {
        Nodo aux = cabeza;

        while (aux != null)
        {
            Console.Write(aux.Dato + " -> ");
            aux = aux.Siguiente;
        }

        Console.WriteLine("null");
    }
}

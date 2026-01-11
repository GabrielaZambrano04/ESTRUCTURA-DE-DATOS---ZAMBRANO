using System;
using System.Collections.Generic;

class Asignaturas
{
    private List<string> lista = new List<string>
    {
        "Matemáticas",
        "Física",
        "Química",
        "Historia",
        "Lengua"
    };

    public void MostrarAsignaturas()
    {
        foreach (string a in lista)
        {
            Console.WriteLine(a);
        }
    }
}

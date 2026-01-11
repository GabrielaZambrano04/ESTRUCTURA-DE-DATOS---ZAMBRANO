using System;
using System.Collections.Generic;
using System.Linq;

class Precios
{
    private List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

    public void MostrarMinMax()
    {
        Console.WriteLine("Precio menor: " + precios.Min());
        Console.WriteLine("Precio mayor: " + precios.Max());
    }
}

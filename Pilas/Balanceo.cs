using System;
using System.Collections.Generic;

class BalanceoExpresion
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese la expresión: ");
        string expresion = Console.ReadLine();

        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0)
                {
                    Console.WriteLine("Fórmula no balanceada.");
                    return;
                }

                char tope = pila.Pop();

                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                {
                    Console.WriteLine("Fórmula no balanceada.");
                    return;
                }
            }
        }

        Console.WriteLine(
            pila.Count == 0
            ? "Fórmula balanceada."
            : "Fórmula no balanceada."
        );
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo8Ejercicio1
{
    class Program
    {
        //Hacer un programa que le pida al usuario una cadena y muestre cada una de las palabras de la cadena en una línea.

        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cadena: ");
            string cad = Console.ReadLine();
            Console.WriteLine("\nCadena por palabras: \n");
            foreach (char c in cad)
            {
                if (c.Equals(' '))
                    Console.WriteLine();
                else
                    Console.Write(c);
            }
            Console.ReadKey();
        }
    }
}

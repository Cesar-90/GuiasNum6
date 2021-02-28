using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Guia6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEnteros=0, negativo=0, positivo=0, multiplos=0, pares=0;
            Console.WriteLine("Ingrese 10 numeros enteros a evaluar: ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Ingrese el {i} numero");
                numEnteros = int.Parse(Console.ReadLine());

                if (numEnteros < 0)
                {
                    negativo++;
                }
                if (numEnteros>0) 
                {
                    positivo++;
                }
                if (numEnteros%15==0) 
                {
                    multiplos++;
                }
                if (numEnteros%2==0) 
                {
                    pares+=numEnteros;
                }
            }
            Console.WriteLine($"Hay: {negativo} numeros negativos");
            Console.WriteLine($"Hay: {positivo} numeros positivo");
            Console.WriteLine($"Hay: {multiplos} multiplos de 15");
            Console.WriteLine($"Hay: {pares} numeros pares");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese el numero deseado: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}*{num}={i * num}");
            }
            Console.ReadKey();
        }
    }
}

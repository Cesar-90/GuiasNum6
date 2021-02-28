using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Guia6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i=1;i<=30;i++) 
            {
                if (i!=25) 
                {
                    Console.WriteLine($"El numero es {i}");
                }
            }
            Console.ReadKey();
        }
    }
}

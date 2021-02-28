using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Guia6
{
    class Program
    {
        static void Main(string[] args)
        {
            int trianEquilatero = 0, trianIsosceles = 0, trianEscaleno = 0;
            int n;
            double lado1, lado2, lado3;
            Console.Write("Ingrese el numero de triangulos deseados: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ingresa el valor del lado 1 del triangulo :" + i);
                lado1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el valor del lado 2 del triangulo :" + i);
                lado2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el valor del lado 3 del triangulo :" + i);
                lado3 = double.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Los tres lados son iguales por lo tanto es un triangulo equilatero");
                    trianEquilatero++;
                }
                else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                {
                    Console.WriteLine("Dos lados son iguales por lo tanto es un triangulo isosceles");
                    trianIsosceles++;
                }
                else
                {
                    Console.WriteLine("Ningun lado es igual por lo tanto es un triangulo escaleno");
                    trianEscaleno++;
                }
            }
            if (trianEquilatero > trianIsosceles && trianIsosceles > trianEscaleno)
            {
                Console.WriteLine("Entonces triangulo escaleno posee el menor numero");
            }
            else if (trianIsosceles>trianEscaleno && trianEscaleno > trianEquilatero ) 
            {
                Console.WriteLine("Entonces el triangulo equilatero posee el menor numero");
            }
            else if (trianEscaleno>trianEquilatero && trianEquilatero>trianIsosceles) 
            {
                Console.WriteLine("Entonces el triangulo isosceles posee el menor numero");
            }
            Console.WriteLine($"Hay {trianEquilatero} triangulos equilateros, hay {trianIsosceles} triangulos isosceles, hay {trianEscaleno} triangulos escalenos");
            Console.ReadKey();


        }
    }
}

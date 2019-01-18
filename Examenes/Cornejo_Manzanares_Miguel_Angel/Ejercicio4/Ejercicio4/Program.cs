using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Cuadrado(int lado)
        {
            if(lado < 2 || lado > 10)
            {
                Console.WriteLine("Error");
            }

            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int lado;

            Console.Write("Dime el lado comprendido entre 2 y 10 : ");
            lado = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Cuadrado(3);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;


            Console.WriteLine("Dime el primer número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("El resultado es : " + (n1 - n2));
            }
            else
            {
                Console.WriteLine("El resultado es : " + (n2 - n1));
            }

            Console.ReadKey();
        }
    }
}

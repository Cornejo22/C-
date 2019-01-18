using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Dime el primer número : ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número : ");
            z = int.Parse(Console.ReadLine());

            if(x < y && x < z && y < z)
            {
                Console.WriteLine("Los números estan ordenados");
            }
            else
            {
                Console.WriteLine("Los números no estan ordenados");
            }

            Console.ReadKey();
        }
    }
}

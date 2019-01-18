using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
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

            if(y == x + 1 && z == y + 1)
            {
                Console.WriteLine("Los números son consecutivos");
            }
            else
            {
                Console.WriteLine("Los números no son consecutivos");
            }

            Console.ReadKey();
        }
    }
}

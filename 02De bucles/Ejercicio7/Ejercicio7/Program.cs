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
            int i;
            int n1;
            int n2;
            Console.WriteLine("Dime el primer número : " );
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            n2 = int.Parse(Console.ReadLine());

            while (n2 < n1)
            {
                Console.WriteLine("Dime el primer número : ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dime el segundo número : ");
                n2 = int.Parse(Console.ReadLine());
            }

            i = n1;
            while (i <= n2)
            {
                Console.Write(" " + i);
                i++;
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_RelacionFunciones
{
    class Program
    {
        static void TablaMultiplicar(int n1)
        {
            int i;

            for (i = 1; i <= 10; i++)
            {
                Console.Write(n1);
                Console.Write(" x ");
                Console.Write(i);
                Console.Write(" = ");
                Console.WriteLine(n1 * i);
            }
        }

        static void Main(string[] args)
        {
            int n1;

            Console.Write("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());

            TablaMultiplicar(n1);

            Console.ReadKey();
        }
    }
}

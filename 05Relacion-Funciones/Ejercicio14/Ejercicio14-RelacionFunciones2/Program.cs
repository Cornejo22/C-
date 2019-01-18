using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14_RelacionFunciones2
{
    class Program
    {
        static int LeeNatural(int n1)
        {
            int numero;

            while (n1 <= 0)
            {
                Console.WriteLine("Dime otro número : ");
                n1 = int.Parse(Console.ReadLine());
            }
            numero = n1;

            return numero;
        }
        static void Main(string[] args)
        {
            int n1 = 0;
            Console.WriteLine("Dime un número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu número : {0} " , LeeNatural(n1)); 

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio19_RelacionFunciones2
{
    class Program
    {
        static int Inc(ref int n1)
        {
            n1 = n1 + 1;
            return n1;
        }

        static int Dec(ref int n1)
        {
            n1 = n1 - 1;
            return n1;
        }

        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Dime un número : ");
            while(int.TryParse(Console.ReadLine(),out n1) == false)
            {
                Console.WriteLine("Esto no es un número, prueba de nuevo");
            }

            Console.WriteLine("Tu número es : " + Inc(ref n1));
            Console.WriteLine("Tu número es : " + Dec(ref n1));
            Console.ReadKey();
        }
    }
}

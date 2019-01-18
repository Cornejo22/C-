using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_RelacionFunciones
{
    class Program
    {
        static int Signo(int n1)
        {
            int es;

            if (n1 < 0)
            {
                es = -1;
            }
            else
            {
                if (n1 > 0)
                {
                    es = 1;
                }
                else
                {
                    es = 0;
                }
            }

            return es;
        }

        static void Main(string[] args)
        {
            int n1;

            Console.Write("Dime el número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write(Signo(n1));

            Console.ReadKey();
        }
    }
}

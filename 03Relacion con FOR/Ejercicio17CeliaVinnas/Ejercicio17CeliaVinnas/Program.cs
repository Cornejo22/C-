using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17CeliaVinnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteroN;
            int resultado = 1;

            Console.WriteLine("Dime el número : ");
            enteroN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= enteroN; i++)
            {
                resultado = resultado * i;
            }

            Console.Write(enteroN + "! = " + resultado);
            Console.ReadKey();
        }
    }
}

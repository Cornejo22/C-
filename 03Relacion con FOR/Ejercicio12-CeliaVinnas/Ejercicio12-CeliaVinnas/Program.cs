using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_CeliaVinnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 0; i <= 1000; i = i + 2)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es : " + suma);
            Console.ReadKey();
        }
    }
}

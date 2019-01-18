using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_RelacionFunciones
{
    class Program
    {
        static bool Bisiesto(int anno)
        {
            bool devuelve;

            devuelve = false;

            if (anno % 4 == 0 && anno % 100 != 0 || anno % 400 == 0)
            {
                devuelve = true;
            }

            return devuelve;
        }
        static void Main(string[] args)
        {
            int anno;
            Console.Write("Dime un año : ");
            anno = int.Parse(Console.ReadLine());

            Console.WriteLine(Bisiesto(anno));

            Console.ReadKey();
        }
    }
}

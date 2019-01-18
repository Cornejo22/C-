using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno;

            Console.WriteLine("Dime un año : ");
            anno = int.Parse(Console.ReadLine());

            if(anno % 4 == 0)
            {
                Console.WriteLine("Es un año bisiesto");
            }
            else
            {
                Console.WriteLine("No es un año bisiesto");
            }

            Console.ReadKey();
        }
    }
}

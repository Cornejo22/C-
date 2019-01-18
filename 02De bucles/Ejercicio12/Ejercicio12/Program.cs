using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 0; i <= 1000; i=i+2)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma es : " + suma);
            Console.ReadKey();
            
            //int suma = 0;
            //int i = 0; 
            //while(i <= 1000)
            //{
            //    suma = suma + i;
            //    i=i+2;
            // }
            //Console.WriteLine("La suma es : " + suma);
        }
    }
}

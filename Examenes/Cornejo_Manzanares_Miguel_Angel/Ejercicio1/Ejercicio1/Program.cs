using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {      
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Tus años bisiestos : ");
            Console.WriteLine("=======================");

            for (i = 2001; i <= 2100; i++)
            {
                if(i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(" " + i);
                }
            }

            Console.ReadKey();
        }
    }
}

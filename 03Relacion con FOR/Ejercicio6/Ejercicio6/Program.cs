using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i;

            Console.WriteLine("Dime el número");
            numero = int.Parse(Console.ReadLine());

            for (i = 0; i <= 10; i++)
            {
                Console.Write(numero);
                Console.Write(" x ");
                Console.Write(i);
                Console.Write(" = ");
                Console.WriteLine(numero * i);
            }

            Console.ReadKey();
        }
    }
}

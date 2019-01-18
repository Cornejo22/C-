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
            Console.WriteLine("Dime el número : ");
            numero = int.Parse(Console.ReadLine());

            int i = 0;
            while (i <= 10)
            {
                Console.Write(numero);
                Console.Write(" x ");
                Console.Write(i);
                Console.Write(" = ");
                Console.WriteLine(i * numero);
                i++;
            }

            Console.ReadKey();
        }
    }
}

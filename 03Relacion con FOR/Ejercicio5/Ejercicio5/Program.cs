using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int i;

            Console.WriteLine("Dime impares o pares");
            frase = Console.ReadLine();

            if(frase == "impares")
            {
                for (i = 1; i <= 10; i = i + 2)
                {
                    Console.Write(" " + i);
                }
            }
            else
            {
                if(frase == "pares")
                {
                    for (i = 0; i <= 10; i = i + 2)
                    {
                        Console.Write(" " + i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

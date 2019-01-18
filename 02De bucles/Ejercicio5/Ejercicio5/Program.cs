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

            Console.WriteLine("Dime pares o impares : ");
            frase = Console.ReadLine();

            if (frase == "pares")
            {
                int n1 = 0;
                while (n1 <= 10)
                {
                    Console.Write(" " + n1);
                    n1 = n1 + 2;
                }
            }
            else 
            {
                if (frase == "impares")
                {
                    int n1 = 1;
                    while (n1 <= 10)
                    {
                        Console.Write(" " + n1);
                        n1 = n1 + 2;
                    }
                }
                   
            }
            Console.ReadKey();
        }
    }
}

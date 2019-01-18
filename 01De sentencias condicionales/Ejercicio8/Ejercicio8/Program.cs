using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Dime el número : ");
            n1 = int.Parse(Console.ReadLine());

           if(n1 <= 9 && n1 >= -9)
            {
                Console.WriteLine("Es un número de 1 cifra");
            }
           else
            {
                if (n1 <= 99 && n1 >= -99)
                {
                    Console.WriteLine("Es un número de 2 cifra");
                }
                else
                {
                    if (n1 <= 999 && n1 >= -999)
                    {
                        Console.WriteLine("Es un número de 3 cifra");
                    }
                    else
                    {
                        if (n1 <= 9999 && n1 >= -9999)
                        {
                            Console.WriteLine("Es un número de 4 cifra");
                        }
                        else
                        {
                            if (n1 <= 99999 && n1 >= -99999)
                            {
                                Console.WriteLine("Es un número de 5 cifra");
                            }
                        }
                    }
                }
            }
           

            Console.ReadKey();
        }
    }
}

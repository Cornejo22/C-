using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            int i = 1;

            Console.WriteLine("El caracter 'a' para los multiplos de 11,el 'b' para los de 17 y el 'c' para los de 23");
            caracter = char.Parse(Console.ReadLine());

            if (caracter == 'a')
            {
                for (i = 1; i <= 100; i++)
                {
                    if (i % 11 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                if (caracter == 'b')
                {
                    for (i = 1; i <= 100; i++)
                    {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    if (caracter == 'c')
                    {
                        for (i = 1; i <= 100; i++)
                        {
                            if (i % 23 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Letra incorrecta");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

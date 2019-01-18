using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota;

            Console.WriteLine("Dime la nota del alumno : ");
            nota = double.Parse(Console.ReadLine());

            while (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota Incorrecta. Ingrese de nuevo una nota : ");
                nota = double.Parse(Console.ReadLine());
            }

            if (nota >= 0 && nota < 5)
            {
                Console.WriteLine("SUSPENSO");
            }
            else
            {
                if (nota >= 5 && nota < 6)
                {
                    Console.WriteLine("SUFICIENTE");
                }
                else
                {
                    if (nota >= 6 && nota < 7)
                    {
                        Console.WriteLine("BIEN");
                    }
                    else
                    {
                        if (nota >= 7 && nota < 9)
                        {
                            Console.WriteLine("NOTABLE");
                        }
                        else if (nota >= 9 && nota <= 10)
                        {
                            Console.WriteLine("SOBRESALIENTE");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

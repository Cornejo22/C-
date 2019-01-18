using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14CeliaVinnas
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            int aprobados = 0;
            int suspensos = 0;
            int contador;

            for(contador = 0; contador < 30; contador++)
            {
                Console.WriteLine("Dime la nota : ");
                nota = int.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    if (nota >= 0 && nota < 5)
                    {
                        suspensos++;
                    }
                    else
                    {
                        aprobados++;
                    }
                }
                else
                {
                    Console.WriteLine("Nota erronea");

                }
                               
            }

            Console.WriteLine("Los aprobados son " + aprobados);
            Console.WriteLine("Los suspensos son " + suspensos);
            Console.ReadKey();
        }
    }
}

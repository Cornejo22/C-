using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Romboide(int altura, int longitud)
        {
            int  j, l;
            int espacios;
            int asteriscos;

            espacios = altura - 1;
            for (j = altura; j > 0; j--)
            {                
                asteriscos = longitud;

                for (l = 0; l < espacios; l++)
                {
                    Console.Write(" ");
                }

                for (l = 0; l < asteriscos; l++)
                {
                    Console.Write("*");
                }
                espacios--;

                Console.WriteLine();
            }

        }
        
            static void Main(string[] args)
        {
            int altura;
            int longitud;

            Console.WriteLine("Dime la altura del romboide");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime la longitud");
            longitud = int.Parse(Console.ReadLine());

           
            Romboide(altura, longitud);


            Console.ReadKey();
        }
    }
}

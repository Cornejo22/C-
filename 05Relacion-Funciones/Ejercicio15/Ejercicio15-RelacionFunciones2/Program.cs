using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15_RelacionFunciones2
{
    class Program
    {
        static int LeeNumero(int a,int b)
        {
            int numero = 0;

            while(numero < a || numero > b)
            {
                Console.WriteLine("Número incorrecto, por favor vuelva a escribir otro número : ");
                numero = int.Parse(Console.ReadLine());
            }

            return numero;
        }
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Un número para 'a' ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Un número para 'b' ");
            b = int.Parse(Console.ReadLine());

            if(b < a)
            {
                int aux;
                aux = a;
                a = b;
                b = aux;
            }

            Console.WriteLine("Tu número : {0} ",LeeNumero(a,b));

            Console.ReadKey();
        }
    }
}

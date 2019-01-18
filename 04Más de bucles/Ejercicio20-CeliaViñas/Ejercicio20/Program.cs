using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int nRandom;
            int numeroIntentos = 1;
            int numero;

            Console.WriteLine("Dime un número : ");
            numero = int.Parse(Console.ReadLine());

            nRandom = r.Next(1,101);
            //Console.WriteLine(nRandom);

            while(numero != nRandom)
            {
                if (nRandom > numero)
                {
                    Console.WriteLine("Mi número es mayor");
                }
                if (nRandom < numero)
                {
                    Console.WriteLine("Mi número es menor");
                }

                numeroIntentos++;
                Console.WriteLine();
                Console.WriteLine("Sigue intentandolo. Dime otro número : ");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Felicidades!!. Tu números de intentos : {0}",numeroIntentos);
            Console.ReadKey();
        }
    }
}

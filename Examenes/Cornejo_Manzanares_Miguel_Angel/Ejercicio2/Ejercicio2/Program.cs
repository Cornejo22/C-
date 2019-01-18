using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            int i;

            Console.Write("Dime el primer número entre 1 y 100 : ");
            n1 = int.Parse(Console.ReadLine());

            while(n1 < 1 || n1 > 100)
            {
                Console.Write("Número inferior a 1 o superior a 100 : ");
                n1 = int.Parse(Console.ReadLine());
            }

            Console.Write("Dime el segundo número mayor que el primero (entre 1 y 100): ");
            n2 = int.Parse(Console.ReadLine());

            while (n2 < 1 || n2 > 100 || n2 < n1)
            {
                Console.Write("Número inferior al primero o superior a 100: ");
                n2 = int.Parse(Console.ReadLine());
            }

            Console.Write("Dime el tercer número mayor que el primero y menor que el segundo (entre 1 y 100): ");
            n3 = int.Parse(Console.ReadLine());

            while (n3 < 1 || n3 > 100 || n3 < n1 || n3 > n2)
            {
                Console.Write("Número inferior al primero o superior al segundo o a 100: ");
                n3 = int.Parse(Console.ReadLine());
            }

            i = n1;
            Console.WriteLine("Los números comprendidos entre n1 y n3: ");

            while(i <= n3)
            {
                Console.Write(i + " ");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Los números comprendidos entre n3 y n2: ");

            i = n3;
            while (i <= n2)
            {
                Console.Write(i + " ");
                i++;
            }

            Console.ReadKey();
        }
    }
}

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
            int i;
            int n1;
            int n2;

            Console.WriteLine("Dime el primer número : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {               
                for (i = n1; i <= n2;i++)
                {
                    Console.Write(" " + i);                    
                }
            }
            else
            {
                for(i = n1; i >= n2; i--)
                {
                    Console.Write(" " + i);
 
                }
            }

            Console.ReadKey();
        }
    }
}

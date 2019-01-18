using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio18_RelacionFunciones2
{
    class Program
    {
        static void Lee3(ref int a, ref int b, ref int c)
        {
            Console.WriteLine("Tu primer número : {0}, \ntu segundo número : {1}, \ntu tercer número : {2}.  ",a,b,c);
        }
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Dime el primer número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número : ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número : ");
            c = int.Parse(Console.ReadLine());

            Lee3(ref a,ref b,ref c);


            Console.ReadKey();
        }
    }
}

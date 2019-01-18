using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void TrianguloInvertido(int npisos)
        {
            int contador = 1;
            if(npisos >= 3 && npisos <= 20)
            {
                for (int i = npisos; i > 0; i--)
                {
                    if(i == npisos)
                    {
                        for (int j = 0; j < npisos+(npisos-1); j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        if (i > 0 || i < npisos)
                        {
                            int lmax = npisos + (npisos - 1);
                            for (int j = 0; j < lmax-1; j++)
                            {
                                if(j == contador || j == lmax-(contador+1))
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            contador++;

                            Console.WriteLine();
                        }
                        else
                        {
                            if(i == 0)
                            {
                                Console.Write(" * ");
                            }
                        }
                    }               
                }
            }
            else
            {
                Console.WriteLine("Numero de pisos inferior a 3 o superior a 20");
            }
            
        }
        static void Main(string[] args)
        {
            TrianguloInvertido(3);
            Console.WriteLine();
            Console.WriteLine();
            TrianguloInvertido(4);
            Console.WriteLine();
            Console.WriteLine();
            TrianguloInvertido(5);
            Console.WriteLine();
            Console.WriteLine();
            TrianguloInvertido(6);
            Console.WriteLine();
            Console.WriteLine();
            TrianguloInvertido(20);

            Console.ReadKey();
        }
    }
}

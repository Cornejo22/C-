using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13_RelacionFunciones2
{
    class Program
    {
        static string NotaEnTexto(double nota)
        {
            string aprobado = "";


            if (nota > 0 && nota < 5)
            {
                aprobado = "Insuficiente";
            }
            else
            {
                if (nota >= 5 && nota < 6)
                {
                    aprobado = "Suficiente";
                }
                else
                {
                    if (nota >= 6 && nota < 7)
                    {
                        aprobado = "Bien";
                    }
                    else
                    {
                        if (nota >= 7 && nota < 9)
                        {
                            aprobado = "Notable";
                        }
                        else
                        {
                            if (nota >= 9 && nota <= 10)
                            {
                                aprobado = "Sobresaliente";
                            }
                        }
                    }
                }
            }
            

            return aprobado;
        }
        static void Main(string[] args)
        {
            double nota;

            Console.Write("Dime la nota del alumno : ");
            nota = double.Parse(Console.ReadLine());

            Console.Write("Tu tienes un {0}", NotaEnTexto(nota));

            Console.ReadKey();
        }
    }
}

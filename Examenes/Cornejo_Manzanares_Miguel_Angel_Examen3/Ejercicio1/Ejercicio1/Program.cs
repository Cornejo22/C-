using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void EscribeLista(List<int> lista)
        {
            int i;

            if(lista.Count == 0)
            {
                Console.Write("No hay elementos en la lista");
            }
            else
            {
                Console.Write("[");
                for (i = 0; i < lista.Count - 1; i++)
                {
                    Console.Write(lista[i] + ",");
                }
                Console.Write(lista[i]);
                Console.WriteLine("]");
            }
            
        }

        static List<int> ElementosRepetidos(List<int> lista)
        {
            List<int> lDevuelta = new List<int>();
            int i;
            int contador = 0;
            int j;

            for (i = 0; i < lista.Count; i++)
            {
                for (i = 0; i < lista.Count; i++)
                {
                    contador = 0;
                    for (j = 0; j < lista.Count; j++)
                    {

                        if (lista[i] == lista[j])
                        {
                            contador++;
                        }
                    }

                    if (contador > 1 && lDevuelta.Contains(lista[i]) == false)
                    {
                        lDevuelta.Add(lista[i]);
                    }
                }
            }

            return lDevuelta;
        }

        static List<int> ElementosUnicos(List<int> lista)
        {
            List<int> lDevuelta = new List<int>();
            int i;
            int j;
            int contador = 0;

            for (i = 0; i < lista.Count; i++)
            {
                contador = 0;
                for (j = 0; j < lista.Count; j++)
                {                   
                    if(lista[i] == lista[j])
                    {
                        contador++;
                    }
                }

                if(contador == 1)
                {
                    lDevuelta.Add(lista[i]);
                }
            }

            return lDevuelta;
        }

        static void Main(string[] args)
        {
            List<int> lista = new List<int>() {1,1,2,3,99,1,99,5};
            EscribeLista(lista);
            Console.WriteLine();
            Console.Write("Los elementos unicos: ");
            EscribeLista(ElementosUnicos(lista));
            Console.WriteLine();
            Console.Write("Los elementos repetidos: ");
            EscribeLista(ElementosRepetidos(lista));

            Console.ReadKey();
        }
    }
}

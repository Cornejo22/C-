using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Rombo
{
    class Program
    {
        static void Triangulo(int lado)
        {
            int i;
            int j;

            for (i = 0; i < lado; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Rectangulo(int ancho, int alto)
        {
            int i;
            int j;

            for ( i = 0; i < alto; i++)
            {
                for (j = 0; j  < ancho; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        static void Rectangulo2(int ancho, int alto)
        {
            for (int i = 1; i <= alto; i++)
            {
                for (int j = 1; j <= ancho; j++)
                {
                    if (i == 1 || i == alto)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 1 || j == ancho)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine();
            }
        }

        static void Piramide(int lado)
        {
            int i;
            int j;
            int espacios;
            int asteriscos;

            for (i = 0; i < lado; i++)
            {
                asteriscos = i + 1;
                espacios = lado - asteriscos;

                for (j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }
                for (j = 0; j < asteriscos - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Rombo(int lado)
        {
            int i;
            int j;
            int espacios;
            int asteriscos;

            for (i = 0; i < lado; i++)
            {
                asteriscos = i + 1;
                espacios = lado - asteriscos;

                for (j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }
                for (j = 0; j < asteriscos - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (i = lado - 2; i >= 0; i--)
            {
                asteriscos = i + 1;
                espacios = lado - asteriscos;

                for (j = 0; j < espacios; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < asteriscos; j++)
                {
                    Console.Write("*");
                }
                for (j = 0; j < asteriscos - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void ArbolNavidad(int lado)
        {
            int t;
            int i;
            int j;
            int espacios;
            int asteriscos;
            int capa;
            int inicio;

            for (t = 0; t < 3; t++)
            {
                capa = 3 - t;
                if (t > 0)
                {
                    inicio = 1;
                }
                else
                {
                    inicio = 0;
                }
                for (i = inicio; i < lado - capa; i++)
                {
                    asteriscos = i + 1;
                    espacios = lado - asteriscos;

                    for (j = 0; j < espacios; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < asteriscos; j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < asteriscos - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            //for (i = 0; i < lado / 2; i++)
            //{
            //    for (j = 0; j < (lado / 2); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (j = 0; j < lado / 2; j++)
            //    {
            //        Console.Write("|");
            //    }
            //    Console.WriteLine();
            //}
        }

        static void Circulo(int lado)
        {
            double i, j;
            double x, y, h;

            for (i = -lado; i < lado; i += 1)
            {
                for (j = -lado; j < lado; j += 0.5)
                {
                    x = i;
                    x = x / lado;
                    y = j;
                    y = y / lado;
                    h = Math.Sqrt(x * x + y * y);

                    if (h <= 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Anillo(int lado)
        {
            double i, j;
            double x, y, h;

            for (i = -lado; i < lado; i += 1)
            {
                for (j = -lado; j < lado; j += 0.5)
                {
                    x = i;
                    x = x / lado;
                    y = j;
                    y = y / lado;
                    h = Math.Sqrt(x * x + y * y);

                    if (h <= 1 && h >= 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void EscribeArray(int[] array)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < array.Length-1 ; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(array[i]);
            Console.Write("]");
        }

        static int DistanciaArray(int[] array)
        {
            int acumulador = 0;
            int i, j, contadorI;

            for (i = 0; i < array.Length-1; i++)
            {
                contadorI = array[i];
                j = array[i + 1];              
                
                    while(contadorI < j)
                    {
                        acumulador = acumulador + 1;
                        contadorI++;
                    }
                    
                
                    while(contadorI > j)
                    {
                        acumulador = acumulador + 1;
                        contadorI--;
                    }
            }
            return acumulador;
        }

        static int DistanciaArray2(int[] a)
        {
            int i;
            int suma = 0;
            int temp = 0;

            for (i = 0; i < a.Length - 1; i++)
            {
                temp = (a[i] - a[i + 1]);

                if (temp < 0)
                {
                    temp = -temp;
                }
                suma = suma + temp;
            }
            return suma;
        }

        static void PermutaArray(int[] array, int ncambios)
        {
            int random;
            Random e = new Random();
            int contador = 0;
            int aux;

            while (contador < ncambios)
            {
                random = e.Next(0, array.Length);

                if (random == array.Length - 1)
                {
                    aux = array[0];
                    array[0] = array[array.Length - 1];
                    array[array.Length - 1] = aux;
                }
                else
                {
                    aux = array[random + 1];
                    array[random + 1] = array[random];
                    array[random] = aux;
                }
                contador++;
            }
        }

        static void Main(string[] args)
        {
            //Triangulo(6);
            //Console.WriteLine();
            //Piramide(6);
            //Console.WriteLine();
            //Rombo(6);
            //ArbolNavidad(7);
            //Circulo(15);
            //Anillo(15);

            //int tamanno;

            //Console.WriteLine("Dime el tamaño del array");
            //while (int.TryParse(Console.ReadLine(), out tamanno) == false)
            //{
            //    Console.WriteLine("No es un número.Intentelo de nuevo");
            //}

            //int i;
            //int ncambios;
            //int[] array = new int[tamanno];

            //for (i = 0; i < array.Length; i++)
            //{
            //    array[i] = i + 1;
            //}

            //Console.WriteLine("¿Cuántas permutuaciones quieres hacer?");
            //while (int.TryParse(Console.ReadLine(), out ncambios) == false)
            //{
            //    Console.WriteLine("No es un número.Intentelo de nuevo");
            //}

            //EscribeArray(array);
            //PermutaArray(array, ncambios);
            //EscribeArray(array);
            //Console.WriteLine("\nLa distancia : " + DistanciaArray(array));

            Rectangulo(10, 5);


            Console.ReadLine();
        }
    }
}
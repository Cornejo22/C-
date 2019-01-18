using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion_EjerciciosListas
{
    class Program
    {
        /// <summary>
        /// Va leyendo enteros desde el teclado y los va metiendo en una lista.
        /// La función ira leyendo valores hasta que escribamos un -1.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        static void LeeLista(List<int> lista)
        {
            int numero = 0;

            while (numero != -1)
            {
                Console.Write("Dime un numero : ");
                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("Dime un numero");
                }

                if (numero != -1)
                {
                    lista.Add(numero);
                }
            }
        }

        /// <summary>
        /// Lee desde el teclado el número de enteros que le digamos.
        /// La función ira añadiendo cada número hasta que completar la lista
        /// </summary>
        /// <param name="listaN">Lista de enteros</param>
        /// <param name="cantidad">Longitud de la lista</param>
        static void LeeListaN(List<int> listaN, int cantidad)
        {
            int numero = 0;
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Dime un número : ");
                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.Write("Error.Dime un número : ");
                }

                listaN.Add(numero);
            }
        }

        /// <summary>
        /// Le pasas una lista y te escribe su contenido por pantalla.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        static void EscribeLista(List<int> lista)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < lista.Count - 1; i++)
            {
                Console.Write(lista[i] + ",");
            }
            Console.Write(lista[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le pasas una lista y te escribe su contenido por pantalla.
        /// </summary>
        /// <param name="lista">Lista de strings</param>
        static void EscribeLista(List<string> lista)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < lista.Count - 1; i++)
            {
                Console.Write(lista[i] + ",");
            }
            Console.Write(lista[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le pasas una lista y te escribe su contenido por pantalla.
        /// </summary>
        /// <param name="lista">Lista de carácteres</param>
        static void EscribeLista(List<char> lista)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < lista.Count - 1; i++)
            {
                Console.Write(lista[i] + ",");
            }
            Console.Write(lista[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le pasas una lista y te escribe su contenido por pantalla.
        /// </summary>
        /// <param name="lista">Lista de carácteres</param>
        static void EscribeLista(List<double> lista)
        {
            int i;

            Console.Write("[");
            for (i = 0; i < lista.Count - 1; i++)
            {
                Console.Write(lista[i] + ",");
            }
            Console.Write(lista[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le paso un array y te escribe su contenido por pantalla.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        static void EscribeArray(int[] array)
        {
            int i;
            Console.Write("[");
            for (i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + ",");
            }
            Console.Write(array[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Inserte un elemento en la posición central de
        /// una lista.Para probarla coge una lista vacía, inserta en el medio los números del 1 al 10
        /// y muestra el resultado.
        /// </summary>
        /// <param name="lista">Lista de enteros vacia</param>
        /// <returns>Lista rellenada con 10 numeros enteros</returns>
        static List<int> InsertaEnMedio(List<int> lista)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            lista.InsertRange(lista.Count / 2, array);

            return lista;

        }//Repasar

        /// <summary>
        /// Elimina todos los números negativos de una lista de enteros.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        static void EliminaNegativos(List<int> lista)
        {
            int i;

            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i] < 0)
                {
                    lista.Remove(lista[i]);
                    i--;
                }
            }
        }

        /// <summary>
        /// Le pasas tres listas. La primera contiene un montón de números positivos y negativos.
        /// Habrá que copiar los positivos en la primera lista y los negativos en la segunda lista,
        /// después ordenar las dos listas.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <param name="listan">Lista de enteros negativos</param>
        /// <param name="listap">Lista de enteros positivos</param>
        static void ClasificaNumeros(List<int> lista, List<int> listan, List<int> listap)
        {
            int i;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i] < 0)
                {
                    listan.Add(lista[i]);
                }
                else
                {
                    listap.Add(lista[i]);
                }
            }

            listan.Sort();
            listap.Sort();
        }

        /// <summary>
        /// Le pasas una lista y te elimina los
        /// elementos repetidos, dejando sólo uno de cada(ej.: { 1,2,3,3} = {1,2,3}). 
        /// La forma más fácil es ir copiando de una lista a otra sólo los 
        /// elementos que no estén ya introducidos (p.ej., usando Contains).
        /// </summary>
        /// <param name="lista">Lista de enteros con números repetidos</param>
        /// <returns>Lista de enteros sin números repetidos</returns>
        static List<int> EliminaRepetidos(List<int> lista)
        {
            int i;
            List<int> lista2 = new List<int>();

            for (i = 0; i < lista.Count; i++)
            {
                if (lista2.Contains(lista[i]) == false)
                {
                    lista2.Add(lista[i]);
                }
            }

            lista.Clear();
            lista.AddRange(lista2);

            return lista;
        }

        /// <summary>
        /// Le pasas una lista de caracteres y te elimina los 
        /// espacios que existan al principio y al final.
        /// Con las funciones IndexOf, LastIndexOf es muy fácil.
        /// </summary>
        /// <param name="lista">Lista de carácteres</param>
        static void TrimLista(List<char> lista)
        {
            while (lista[0] == ' ')
            {
                lista.RemoveAt(0);
            }

            while (lista[lista.Count - 1] == ' ')
            {
                lista.RemoveAt(lista.Count - 1);
            }

        }

        /// <summary>
        ///Le pasas una lista de enteros
        ///desordenada y te lo ordena mediante el algoritmo de selección
        ///(no vale usar la función Sort). 
        ///Es mucho más fácil que con arrays, 
        ///ya que tienes las funciones Max, Min, IndexOf, Insert, RemoveAt, etc.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>Lista de enteros ordenada</returns>
        static List<int> OrdenaListaSeleccion(List<int> lista)
        {
            List<int> lista2 = new List<int>();
            int min;
            int i;


            for (i = 0; i < lista.Count; i++)
            {
                min = lista.Min();
                lista2.Add(min);
                lista.Remove(min);
                i--;
            }

            lista.AddRange(lista2);

            return lista;
        }

        /// <summary>
        /// Le pasas una lista de cadenas que contiene palabras y te las ordena alfabéticamente.
        /// </summary>
        /// <param name="lista">Lista de String</param>
        /// <returns>Lista de String</returns>
        static List<string> OrdenaListaPalabras(List<string> lista)
        {
            List<string> lista2 = new List<string>();
            int i;
            string min;

            for (i = 0; i < lista.Count; i++)
            {
                min = lista.Min();
                lista2.Add(min);
                lista.Remove(min);
                i--;
            }

            lista.AddRange(lista2);

            return lista2;
        }

        /// <summary>
        /// lLe pasas una lista de cadenas que contiene palabras y te las ordena por tamaño (la más pequeña el principio).
        /// </summary>
        /// <param name="lista">Lista de cadenas</param>
        /// <returns>Lista de cadenas</returns>
        static List<string> OrdenaListaPalabras2(List<string> lista)
        { 
            //l.Sort();
            List<string> lista2 = new List<string>();
            int menor_pos;
            string menor = "";

            int pos;
            while (lista.Count > 0)
            {
                //menor = l.Min();
                menor_pos = lista[0].Length;
                menor = lista[0];
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Length < menor_pos)
                    {
                        menor_pos = lista[i].Length;
                        menor = lista[i];
                    }
                }

                pos = lista.IndexOf(menor);
                lista2.Add(menor);
                lista.RemoveAt(pos);

            }
            //l1.Clear();
            lista.AddRange(lista2);
            return lista2;
        }

        /// <summary>
        ///  La función insertará en el primer array, a partir de la posición indicada, 
        ///  todo el contenido del segundo array, y nos devolverá otro array con el resultado
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="pos">Una posición </param>
        /// <param name="array2">Array de enteros</param>
        /// <returns>Array de enteros</returns>
        static int[] InsertaArrayEnArrayPro(int[] array, int pos, int[] array2)
        {
            List<int> l = new List<int>();

            l.AddRange(array);
            l.InsertRange(pos, array2);

            return l.ToArray();
        }

        /// <summary>
        /// Función que nos da los 6 números que van a tocar en el próximo sorteo.
        /// </summary>
        /// <param name="lista49">Lista de enteros</param>
        /// <returns>Lista de enteros</returns>
        static List<int> SorteoBonoloto(List<int> lista49)
        {
            List<int> sorteo = new List<int>();
            Random r = new Random();

            int i;
            int n;

            for (i = 0; i < 6; i++)
            {
                n = r.Next(0, lista49.Count - 1);

                sorteo.Add(n);
                lista49.Remove(n);
            }


            return sorteo;
        }

        /// <summary>
        /// Función donde le pasamos una lista de elementos repetidos
        /// y nos devuelve otro array en el que no estan los elementos 
        /// repetidos
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Array de enteros</returns>
        static int[] EliminaRepetidos(int[] array)
        {
            List<int> lSinRep = new List<int>();
            int i;

            for (i = 0; i < array.Length; i++)
            {
                if (lSinRep.Contains(array[i]) == false)
                {
                    lSinRep.Add(array[i]);
                }
            }

            return lSinRep.ToArray();
        }

        /// <summary>
        /// Le pasas dos listas (que representan conjuntos) y que te devuelve otra lista que representará la unión de ambos conjuntos.
        /// </summary>
        /// <param name="l1">Lista de cadenas</param>
        /// <param name="l2">Lista de cadenas</param>
        /// <returns>Lista de cadenas</returns>
        static List<int> UnionListas(List<int> l1, List<int> l2)
        {
            List<int> unionL = new List<int>();

            unionL.AddRange(l1);
            int i;

            for (i = 0; i < l2.Count; i++)
            {
                if (unionL.Contains(l2[i]) == false)
                {
                    unionL.Add(l2[i]);
                }
            }

            return unionL;
        }

        /// <summary>
        /// Pasas dos listas (que representan conjuntos) 
        /// y que te devuelve otra lista que representará 
        /// la intersección de ambos conjuntos
        /// </summary>
        /// <param name="l1">Lista de enteros</param>
        /// <param name="l2">Lista de enteros</param>
        /// <returns>Lista de enteros</returns>
        static List<int> IntersecciónListas(List<int> l1, List<int> l2)
        {
            List<int> intersecL = new List<int>();

            for (int i = 0; i < l1.Count; i++)
            {
                if (l2.Contains(l1[i]) == true)
                {
                    if (intersecL.Contains(l1[i]) == false)
                    {
                        intersecL.Add(l1[i]);
                    }
                }
            }

            return intersecL;
        }

        /// <summary>
        /// Le pasas una lista de enteros y te la desordena.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>Lista de enteros desordenada</returns>
        static List<int> DesordenaLista(List<int> lista)
        {
            List<int> lDesordenada = new List<int>();
            Random r = new Random();
            int n;

            while (lista.Count > 0)
            {
                n = r.Next(lista.Count);
                lDesordenada.Add(lista[n]);
                lista.RemoveAt(n);
            }
            lista.AddRange(lDesordenada);
            return lista;
        }    

        /// <summary>
        /// Función que nos devuelva la moda (el valor que más veces se repite) de una lista de enteros.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>El numero que mas veces se repite</returns>
        static int ModaLista(List<int> lista)
        {
            int moda = -1;
            int fmoda = 0;
            int aux = 1;
            List<int> listaV = new List<int>(lista.Count);
            int i;
            int j = 0;

            for (i = 0; i < lista.Count; i++)
            {
                for (j =i +1; j < lista.Count; j++)
                {
                    if(lista[i] == lista[j])
                    {
                        aux++;
                    }
                }

                if(aux > fmoda)
                {
                    fmoda = aux;
                    moda = lista[i];
                }
            }

            return moda;
        }

        /// <summary>
        /// Función que nos devuelva la moda (el valor que más veces se repite) de una lista de enteros.
        /// </summary>
        /// <param name="lista">Lista de enteros</param>
        /// <returns>El numero que mas veces se repite</returns>
        static int ModaLista2(List<int> lista)
        {
            int[] arrayaux = new int[lista.Count];

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[i] == lista[j])
                    {
                        arrayaux[i]++;
                    }
                }
            }

            int mayor = int.MinValue;
            int pos = 0;

            for (int i = 0; i < arrayaux.Length; i++)
            {
                if (arrayaux[i] > mayor)
                {
                    mayor = arrayaux[i];
                    pos = i;
                }
            }

            return lista[pos];
        }

        /// <summary>
        /// La función recibirá una lista con siete números reales que se corresponderán 
        /// a las notas obtenidas por un saltador de trampolín de 3 metros.
        /// </summary>
        /// <param name="lista">Lista de numeros reales</param>
        /// <returns>Lista de numeros reales</returns>
        static double PuntuacionesTrampolin(List<double> lista)
        {
            double notaReal = 0;
            double numM = 0;
            double numMenor = 0;
            List<double> listaux = new List<double>();

            listaux.AddRange(lista);

            if (listaux.Count != 7)
            {
                Console.WriteLine("Error");
            }
            else
            {
                while (listaux.Count > 3)
                {
                    numM = listaux.Max();
                    numMenor = listaux.Min();
                    listaux.Remove(numM);
                    listaux.Remove(numMenor);
                }
            }

            notaReal = listaux.Sum();

            return notaReal;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();

                Console.WriteLine("                             MENU");
                Console.WriteLine("====================================================================");
                Console.WriteLine(" 1º-LeeLista              2º-LeeListaN             3º-EscribeLista    ");
                Console.WriteLine(" 4º-InsertaEnMedio        5º-EliminaNegativos      6º-ClasificaNúmeros");
                Console.WriteLine(" 7º-EliminaRepetidos      8º-TrimLista             9º-OrdenaListaSelección ");
                Console.WriteLine("10º-OrdenaListaPalabras  11º-OrdenaListaPalabras2 12º-InsertaArrayEnArrayPro ");
                Console.WriteLine("13º-SorteoBonoloto       14º-EliminaRepetidos     15º-UnionListas");
                Console.WriteLine("16º-IntersecciónListas   17º-DesordenaLista       18º-ModaLista");
                Console.WriteLine("19º-PuntuaciónTrampolin");
                Console.Write("\nDime el ejercicio : ");
                opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        {
                            List<int> l = new List<int>();
                            LeeLista(l);
                            EscribeLista(l);
                        }
                        break;
                    case "2":
                        {
                            List<int> l = new List<int>();
                            LeeListaN(l, 10);
                            EscribeLista(l);
                        }
                        break;
                    case "3":
                        {
                            int cantidad;
                            List<int> l = new List<int>();

                            Console.Write("Dime la longitud de la lista : ");
                            while (int.TryParse(Console.ReadLine(), out cantidad) == false)
                            {
                                Console.Write("Error.Dime un número para la longitud de la lista : ");
                            }
                            LeeListaN(l, cantidad);
                            EscribeLista(l);

                        }
                        break;

                    case "4":
                        {
                            List<int> lista = new List<int>() { 1, 2, 3, 4, 5 };
                            InsertaEnMedio(lista);
                            EscribeLista(lista);

                        }
                        break;

                    case "5":
                        {
                            List<int> lista = new List<int>() { 1, 3, -5, 1, -2, -1, 5 };
                            EscribeLista(lista);
                            EliminaNegativos(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case "6":
                        {
                            List<int> lista = new List<int>() { 1, 2, 4, -2, 3, -1, 1, 0, -9, 1, 3 };
                            List<int> listan = new List<int>();
                            List<int> listap = new List<int>();
                            EscribeLista(lista);
                            ClasificaNumeros(lista, listan, listap);
                            Console.Write("\nTu lista de negativos : ");
                            EscribeLista(listan);
                            Console.Write("\nTu lista de positivos : ");
                            EscribeLista(listap);
                        }
                        break;

                    case "7":
                        {
                            List<int> lista = new List<int>() { 1, 2, 4, -2, 3, -1, 1, 0, -9, 1, 3 };
                            EscribeLista(lista);
                            EliminaRepetidos(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case "8":
                        {
                            List<char> lista = new List<char>() {' ' ,'c',' ' };
                            EscribeLista(lista);
                            TrimLista(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case "9":
                        {
                            List<int> lista = new List<int>() { 1, 4, 9, 0, 1, -2, 19, 22 };
                            EscribeLista(lista);
                            OrdenaListaSeleccion(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case "10":
                        {
                            List<string> lista = new List<string>() { "jamon", "patata", "apple", "ven" };
                            EscribeLista(lista);
                            OrdenaListaPalabras(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case "11":
                        {
                            List<string> lista = new List<string>() { "tio", "estar", "buenas", "hi" };
                            EscribeLista(lista);
                            OrdenaListaPalabras2(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case "12":
                        {
                            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
                            int[] array2 = new int[] { 7, 8, 9, 10 };
                            int pos = 3;
                            EscribeArray(array);
                            EscribeArray(array2);
                            EscribeArray(InsertaArrayEnArrayPro(array, pos, array2));

                        }
                        break;

                    case "13":
                        {
                            List<int> lista49 = new List<int>();
                            for (int i = 1; i <= 49; i++)
                            {
                                lista49.Add(i);
                            }

                            EscribeLista(SorteoBonoloto(lista49));

                        }
                        break;

                    case "14":
                        {
                            int[] array = new int[] { 1, 1, 2, 2, 3, 4, 5, 5, 6, 7, 6 };
                            EscribeArray(array);
                            EscribeArray(EliminaRepetidos(array));
                        }
                        break;

                    case "15":
                        {
                            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
                            List<int> l2 = new List<int>() { 8, 1, 9, 10, 11, 2, 3, 12 };

                            EscribeLista(UnionListas(l1, l2));
                        }
                        break;

                    case "16":
                        {
                            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
                            List<int> l2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12 };

                            EscribeLista(IntersecciónListas(l1, l2));
                        }
                        break;

                    case "17":
                        {
                            List<int> l1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 19, 12, 22, 11, 454, 55 };
                            EscribeLista(l1);
                            EscribeLista(DesordenaLista(l1));
                        }
                        break;

                    case "18":
                        {
                            List<int> l1 = new List<int>() { 1, 1, 2, 2, 3, 4, 5, 6, 6, 6, 7, 1, 1, 8, 10 };
                            Console.WriteLine("El número que mas veces se repite :  " + ModaLista(l1));
                            Console.WriteLine("El número que mas veces se repite :  " + ModaLista2(l1));
                        }
                        break;

                    case "19":
                        {
                            List<double> l1 = new List<double>() { 1.5, 3, 6, 6.5, 7, 20, 30 };
                            EscribeLista(l1);
                            Console.WriteLine("\nLa puntuación del saltador del trampolin es : " + PuntuacionesTrampolin(l1));
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Error");
                        }
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}

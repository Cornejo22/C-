using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMultidimensionales
{
    class Program
    {
        /// <summary>
        ///  Le pasas un array multidimensional de tamaño 3x3 
        ///  y te lo imprime por pantalla 
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        static void EscribeArray3x3(int[,] array)
        {
            int i;
            int j;
            for (i = 0; i < 3; i++)
            {              
                
                Console.Write("[");
                for (j = 0; j < 2; j++)
                {
                    Console.Write(array[i, j] + ",");
                }
                Console.Write(array[i, j]);
                Console.WriteLine("]");

            }
        }
    
        /// <summary>
        ///  Le pasas un array bidimensional de cualquier tamaño 
        ///  y te lo imprime por pantalla.
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        static void EscribeArrayBi(int[,] array)
        {
            int i, j;

            for (i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("[");
                for (j = 0; j < array.GetLength(1) - 1; j++)
                {
                    Console.Write(array[i, j] + ",");
                }
                Console.Write(array[i, j]);
                Console.WriteLine("]");
               
            }
        }

        /// <summary>
        /// Función al cual le paso un array
        /// y el usuario indica el tamaño y sus valores
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        /// <returns>Array bidimensional</returns>
        static int[,] LeeArrayBi(int[,] array)
        {
            int i;
            int j;

            for (i = 0; i < array.GetLength(0); i++)
            {
                
                for (j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Dime un número para asignar en la fila {0} columna {1}  ", i,j);
                    while (int.TryParse(Console.ReadLine(), out array[i,j]) == false)
                    {
                        Console.WriteLine("No es un número");
                    }
                }
            }

            return array;
        }

        /// <summary>
        ///  Le pasas una array multidimensional de 3x3 
        ///  y te lo rellena con los números del 1 al 9.
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <returns>Array multidimensional</returns>
        static int[,] Rellena3x3(int[,] array)
        {
            int i, j;
            int contador = 1 ;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i, j] = contador;
                    contador++;
                }
            }

            return array;
        }

        /// <summary>
        ///  Le pasas un array multidimensional de tamaño 3x3 
        ///  y te lo rellena con números aleatorios. 
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <returns></returns>
        static int[,] RellenaAleatorio3x3(int[,] array)
        {
            int i,j;
            int nr;
            Random r = new Random();
           

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    nr = r.Next(1,100+1);
                    array[i, j] = nr;
                }
            }

            return array;
        }

        /// <summary>
        ///  Le pasas un array bidimensional de cualquier tamaño 
        ///  y te lo rellena con números aleatorios
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        /// <returns>Array bidimensional</returns>
        static int[,] RellenaAleatorioBi(int[,] array)
        {
            int i, j;
            int nr;
            Random r = new Random();


            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    nr = r.Next(1, 100 + 1);
                    array[i, j] = nr;
                }
            }

            return array;
        }

        /// <summary>
        /// Le pasas un array bidimensional de
        /// cualquier tamaño y te lo rellena 
        /// con los números a partir del 1 en orden
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        /// <returns>Array bidimensional</returns>
        static int[,] RellenaEnOrdenBi(int[,] array)
        {
            int i, j;
            int contador = 1;

            for ( i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = contador;
                    contador++;
                }
            }

            return array;
        }

        /// <summary>
        /// Le pasas un array de 3x3 y te suma todos
        /// los números.
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <returns>Te devuelve un entero con el resultado</returns>
        static int SumaArray3x3(int[,] array)
        {
            int i, j;
            int resultado = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    resultado = resultado + array[i, j];
                }
            }

            return resultado;
        }

        /// <summary>
        /// Le pasas un array bidimensional y te suma todos
        /// los números.
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        /// <returns>Te devuelve un entero con el resultado.</returns>
        static int SumaArrayBi(int[,] array)
        {
            int resultado = 0;
            int i, j;

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    resultado = resultado + array[i, j];
                }
            }


            return resultado;
        }

        /// <summary>
        /// Le pasas un array multidimensional cuadrado 3x3
        /// y te lo invierte.
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        static void InvierteArray3x3(ref int[,] array)
        {
            int i, j;
            int[,] arrayb = new int[3,3];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arrayb[i, j] = array[j, i];
                }
            }

            CopiaArrayBi(arrayb, array);
        }

        /// <summary>
        /// Le pasas un array bidimensional cuadrado (es
        /// decir, igual de alto que de ancho) 
        /// y te lo invierte.
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        static void InvierteBi(ref int[,] array)
        {
            int i, j;
            int[,] arrayb = new int[array.GetLength(0),array.GetLength(1)];

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    arrayb[i, j] = array[j, i];
                }
            }

            CopiaArrayBi(arrayb, array);
        }

        /// <summary>
        ///  Le pasas tres arrays de tamaño 3x3 y 
        ///  te suma el primero y el segundo y 
        ///  te pone el resultado en el tercero
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <param name="array2">Array multidimensional</param>
        /// <param name="array3">Array multidimensional</param>
        static void SumaArrays3x3(int[,] array,int[,] array2, int[,] array3)
        {
            int i, j;

            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array3[i, j] = array[i, j];
                }
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array3[i, j] = array[i,j] + array2[i, j];
                }
            }

        }

        /// <summary>
        ///  Le pasas tres arrays de tamaño bidimensional y 
        ///  te suma el primero y el segundo y 
        ///  te pone el resultado en el tercero
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        /// <param name="array2">Array bidimensional</param>
        /// <param name="array3">Array bidimensional</param>
        static void SumaArraysBi(int[,] array, int[,] array2, int[,] array3)
        {
            int i, j;

            if(array.GetLength(0) != array2.GetLength(0) || array.GetLength(1) != array2.GetLength(1)||
               array.GetLength(0) != array3.GetLength(0) || array.GetLength(1) != array3.GetLength(1))
            {
                Console.WriteLine("Error");
            }
            else
            {
                for (i = 0; i < array.GetLength(0); i++)
                {
                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        array3[i, j] = array[i, j];
                    }
                }

                for (i = 0; i < array2.GetLength(0); i++)
                {
                    for (j = 0; j < array2.GetLength(1); j++)
                    {
                        array3[i, j] = array[i, j] + array2[i, j];
                    }
                }
            }
        }

        /// <summary>
        ///  Le pasas dos arrays, uno con datos 
        ///  y otro vacío, y te copia el contenido 
        ///  del primero al segundo
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <param name="arrayb">Array multidimensional</param>
        static void CopiaArrayBi(int[,] array, int[,] arrayb)
        {
            int i, j;

            if (arrayb.GetLength(0) != array.GetLength(0) || arrayb.GetLength(0) != array.GetLength(1))
            {
                Console.Write("Error");
            }
            else
            {
                for (i = 0; i < array.GetLength(0); i++)
                {
                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        arrayb[i, j] = array[i, j];
                    }
                }
            }
        }

        /// <summary>
        /// 
        ///  Le pasas dos arrays, uno con datos 
        ///  y otro vacío, y te copia el contenido 
        ///  del primero al segundo
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <returns>Array multidimensional</returns>
        static int[,] CopiaArrayBiPro(int[,] array)
        {
            int i, j;
            int[,] arrayb = new int[array.GetLength(0), array.GetLength(1)];

            if (arrayb.GetLength(0) != array.GetLength(0) || arrayb.GetLength(0) != array.GetLength(1))
            {
                Console.Write("Error");
            }
            else
            {
                for (i = 0; i < array.GetLength(0); i++)
                {
                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        arrayb[i, j] = array[i, j];
                    }
                }
            }

            return arrayb;
        }

        /// <summary>
        /// Te rellena un array de 8x8 con la forma
        /// de un tablero de ajedrez, usando el 
        /// valor 1 para las casillas blancas y 
        /// 0 para las negras
        /// </summary>
        /// <param name="array"></param>
        static void RellenaArrayAjedrez(int[,] array)
        {
            int i, j;

            for (i = 0; i < array.GetLength(0); i++)
            {
                if(i % 2 == 0)
                {
                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        if (j % 2 == 0)
                        {
                            array[i, j] = 1;
                        }
                        else
                        {
                            array[i, j] = 0;
                        }

                    }
                }
                else
                {
                    for (j = 0; j < array.GetLength(1); j++)
                    {
                        if (j % 2 != 0)
                        {
                            array[i, j] = 1;
                        }
                        else
                        {
                            array[i, j] = 0;
                        }

                    }
                }
                
            }
        }

        /// <summary>
        /// te rellena un array cuadrado con el número
        /// ‘1’ en la diagonal principal, el número 
        /// ‘2’ en el triángulo que queda por encima y el ‘3’
        /// en el triángulo que queda por debajo.
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        static void RellenaDiagonal(int[,] array)
        {
            int i, j;          

            for ( i = 0; i < array.GetLength(0); i++)
            {
                for ( j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        if (i > j)
                        {
                            array[i, j] = 3;
                        }
                        else
                        {
                            array[i, j] = 2;
                        }
                    }                  
                }
            }
        }

        /// <summary>
        /// Te rellena un array cuadrado con el número ‘1’ 
        /// en las dos diagonales y el ‘2’ en el resto.
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        static void RellenaX(int[,] array)
        {
            int i,j;		
            
            for(i = 0; i < array.GetLength(0);i++)
            {
               for(j = 0;j<array.GetLength(1);j++)
               {
                   if(i==j)
                   {
                    array[i,j] = 1;    
                   }
                   
				   else
                   {
                      if(i+j == array.GetLength(1)-1)
                      {
                          array[i,j] = 1;
                          
                      }
                      else
                      {
                          array[i,j] = 2;
                      }
                   }
               }
		
			}
        }

        /// <summary>
        /// Te rellena un array cuadrado de lado par (o
        /// sea, 2x2, 4x4, 6x6, etc.) en cuatro cuadros.
        /// El cuadro superior izquierdo lo rellena con
        /// ‘1’, el superior derecho, con ‘2’, 
        /// el inferior izquierdo con ‘3’ y 
        /// el inferior derecho con ‘4’.
        /// </summary>
        /// <param name="array"></param>
        static void RellenaCuadros(int[,] array)
        {
            int i, j;

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if(i < array.GetLength(0)/2 && j<array.GetLength(1)/2)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 2;
                    }
                }
            }

            for (i = (array.GetLength(0)+1)/2 ; i < array.GetLength(0); i++)
            {
                for ( j = 0; j < array.GetLength(1); j++)
                {
                    if (i >= array.GetLength(0) / 2 && j >= (array.GetLength(1)+1) / 2)
                    {
                        array[i, j] = 4;
                    }
                    else
                    {
                        array[i, j] = 3;
                    }
                }
            }
        }

        /// <summary>
        /// Te calcule el valor de un determinante
        /// de 3x3 y te lo devuelva.
        /// Si no sabéis cómo se calcula un determinante de 3x3
        /// </summary>
        /// <param name="array">Array multidimensional</param>
        /// <returns>Valor int</returns>
        static int CalculaDeterminante(int[,] array)
        {
            int resultado = 0;

            if (array.GetLength(0) == 1 && array.GetLength(1) == 1)
            {
                resultado = array[0, 0];
            }
            else
            {
                if (array.GetLength(0) == 2 && array.GetLength(1) == 2)
                {
                    resultado = (array[0, 0] * array[1, 1]) - (array[0, 1] * array[1, 0]);
                }
                else
                {
                    if (array.GetLength(0) == 3 && array.GetLength(1) == 3)
                    {
                        resultado = (array[0, 0] * array[1, 1] * array[2, 2]) +
                        (array[0, 1] * array[1, 2] * array[2, 0]) +
                        (array[0, 2] * array[1, 0] * array[2, 1]) -
                        (array[0, 2] * array[1, 1] * array[2, 0]) -
                        (array[0, 1] * array[1, 0] * array[2, 2]) -
                        (array[0, 0] * array[1, 2] * array[2, 1]);
                    }
                    else
                    {
                        Console.WriteLine("No se puede calcular el determinante del array");
                    }
                }
            }

            return resultado;
        }

        /// <summary>
        /// Le pasas un array de 3x3 y te dice si es
        /// un cuadrado mágico o no.Un cuadrado mágico es un array bidimensional cuadrado en
        /// el cual la suma de cada una de las filas y de cada una de las columnas y de las dos
        /// diagonales principales es igual.
        /// </summary>
        /// <param name="array">Array bidimensional</param>
        static void CuadradoMagico(int[,] array)
        {
            int[] arraysuma = new int[8];
            int i,j,contador;
            //arraysuma[0] = array[0, 0] + array[0, 1] + array[0, 2];
            //arraysuma[1] = array[1, 0] + array[1, 1] + array[1, 2];
            //arraysuma[2] = array[2, 0] + array[2, 1] + array[2, 2];

            contador = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arraysuma[contador] = arraysuma[contador] + array[i, j];
                }
                contador++;
            }

            //arraysuma[3] = array[0, 0] + array[1, 0] + array[2, 0];
            //arraysuma[4] = array[0, 1] + array[1, 1] + array[2, 1];
            //arraysuma[5] = array[0, 2] + array[1, 2] + array[2, 2];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arraysuma[contador] = arraysuma[contador] + array[j, i];      
                }
                contador++;
            }
            
            arraysuma[6] = array[0, 0] + array[1, 1] + array[2, 2];
            arraysuma[7] = array[0, 2] + array[1, 1] + array[2, 0];

            Array.Sort(arraysuma);

            if (arraysuma[0] == arraysuma[7])
            {
                Console.WriteLine("Es un cuadrado mágico");
            }
            else
            {
                Console.WriteLine("No es un cuadrado mágico");
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("                                 MENU");
                Console.WriteLine("=========================================================================");
                Console.WriteLine(" 1º- EscribeArray3x3      2º- EscribeArrayBi      3º- Rellena3x3");
                Console.WriteLine(" 4º- RellenaAleatorio3x3  5º- RellenaAleatorioBi  6º- RellenaEnOrdenBi");
                Console.WriteLine(" 7º- SumaArray3x3         8º- SumaArrayBi         9º- InvierteArray3x3");
                Console.WriteLine("10º- InvierteArrayBi     11º- SumaArrays3x3      12º- SumaArraysBi");
                Console.WriteLine("13º- CopiaArrayBi        14º- CopiaArrayBiPro    15º- RellenaAjedrez");
                Console.WriteLine("16º- RellenaDiagonal     17º- RellenaX           18º- RellenaCuadros");
                Console.WriteLine("19º- CalculaDeterminante 20º- CuadradoMagico     ");
                Console.WriteLine();
                Console.WriteLine("Dime el ejercicio : ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        {
                            int[,] array3d = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            EscribeArray3x3(array3d);
                        }
                        break;

                    case "2":
                        {
                            int ncolumnas, nfilas;
                            Console.WriteLine("Dime el número de filas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            Console.WriteLine("Dime el número de columnas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            int[,] arrayD = new int[nfilas, ncolumnas];
                            LeeArrayBi(arrayD);
                            EscribeArrayBi(arrayD);
                        }
                        break;

                    case "3":
                        {
                            int[,] array3D = new int[3, 3];
                            Rellena3x3(array3D);
                            EscribeArray3x3(array3D);
                        }
                        break;

                    case "4":
                        {
                            int[,] arrayD = new int[3, 3];
                            RellenaAleatorio3x3(arrayD);
                            Console.WriteLine("Tu array aleatorio de 3x3");
                            EscribeArray3x3(arrayD);
                        }
                        break;

                    case "5":
                        {
                            int ncolumnas, nfilas;
                            Console.WriteLine("Dime el número de filas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            Console.WriteLine("Dime el número de columnas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            int[,] arrayD = new int[nfilas, ncolumnas];
                            RellenaAleatorioBi(arrayD);
                            EscribeArrayBi(arrayD);
                        }
                        break;

                    case "6":
                        {
                            int ncolumnas, nfilas;
                            Console.WriteLine("Dime el número de filas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            Console.WriteLine("Dime el número de columnas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            int[,] arrayD = new int[nfilas, ncolumnas];
                            RellenaEnOrdenBi(arrayD);
                            EscribeArrayBi(arrayD);
                        }
                        break;

                    case "7":
                        {
                            int[,] array3d = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            EscribeArray3x3(array3d);
                            Console.WriteLine("\nTu suma es : " + SumaArray3x3(array3d));
                        }
                        break;

                    case "8":
                        {
                            int ncolumnas, nfilas;
                            Console.WriteLine("Dime el número de filas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            Console.WriteLine("Dime el número de columnas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            int[,] arrayD = new int[nfilas, ncolumnas];
                            LeeArrayBi(arrayD);
                            EscribeArrayBi(arrayD);
                            Console.WriteLine("\nTu suma es : " + SumaArrayBi(arrayD));
                        }
                        break;

                    case "9":
                        {
                            int[,] array3d = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            EscribeArray3x3(array3d);
                            InvierteArray3x3(ref array3d);
                            Console.WriteLine();
                            Console.WriteLine("\nEl array invertido : ");
                            EscribeArray3x3(array3d);
                        }
                        break;

                    case "10":
                        {
                            //int ncolumnas, nfilas;
                            //Console.WriteLine("Dime el número de filas de tu array : ");
                            //while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            //{
                            //    Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            //}
                            //Console.WriteLine("Dime el número de columnas de tu array : ");
                            //while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            //{
                            //    Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            //}
                            //int[,] arrayD = new int[nfilas, ncolumnas];
                            int[,] arrayD = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
                            //LeeArrayBi(arrayD);
                            EscribeArrayBi(arrayD);
                            InvierteBi(ref arrayD);
                            Console.WriteLine();
                            EscribeArrayBi(arrayD);
                        }
                        break;

                    case "11":
                        {
                            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            int[,] array2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            int[,] array3 = new int[3, 3] { { 0,0,0 }, { 0,0,0 }, { 0,0,0 } };
                            EscribeArrayBi(array1);
                            Console.WriteLine();
                            EscribeArrayBi(array2);
                            Console.WriteLine();
                            SumaArrays3x3(array1,array2,array3);
                            EscribeArrayBi(array3);
                        }
                        break;

                    case "12":
                        {
                            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 0, 0, 0 } };
                            int[,] array2 = new int[3, 3] { { 0, 0, 0 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            int[,] array3 = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                            EscribeArrayBi(array1);
                            Console.WriteLine();
                            EscribeArrayBi(array2);
                            Console.WriteLine();
                            SumaArraysBi(array1, array2, array3);
                            EscribeArrayBi(array3);
                        }
                        break;

                    case "13":
                        {
                            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                            int[,] array2 = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
                            EscribeArrayBi(array1);
                            Console.WriteLine();
                            EscribeArrayBi(array2);
                            Console.WriteLine();
                            CopiaArrayBi(array1, array2);
                            EscribeArrayBi(array2);
                        }
                        break;

                    case "14":
                        {
                            int[,] array1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 0, 0, 0 } };
                            EscribeArrayBi(array1);
                            Console.WriteLine();
                            EscribeArrayBi(CopiaArrayBiPro(array1));
                        }
                        break;

                    case "15":
                        {
                            int[,] arrayAjedrez = new int[8, 8];
                            RellenaArrayAjedrez(arrayAjedrez);
                            EscribeArrayBi(arrayAjedrez);
                        }
                        break;

                    case "16":
                        {
                            int[,] arrayd = new int[4, 4];
                            RellenaDiagonal(arrayd);
                            EscribeArrayBi(arrayd);
                        }
                        break;

                    case "17":
                        {
                            int[,] arrayd = new int[4,4];
                            RellenaX(arrayd);
                            EscribeArrayBi(arrayd);
                        }
                        break;

                    case "18":
                        {
                            int[,] arrayd = new int[8,8];
                            RellenaCuadros(arrayd);
                            EscribeArrayBi(arrayd);
                        }
                        break;

                    case "19":
                        {
                            int ncolumnas, nfilas;
                            Console.WriteLine("Dime el número de filas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            Console.WriteLine("Dime el número de columnas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            int[,] arrayd = new int[nfilas, ncolumnas];
                            LeeArrayBi(arrayd);
                            EscribeArrayBi(arrayd);
                            Console.WriteLine();
                            Console.WriteLine("El determinante es : " + CalculaDeterminante(arrayd));
                            
                        }
                        break;

                    case "20":
                        {
                            int ncolumnas, nfilas;
                            Console.WriteLine("Dime el número de filas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out nfilas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            Console.WriteLine("Dime el número de columnas de tu array : ");
                            while (int.TryParse(Console.ReadLine(), out ncolumnas) == false)
                            {
                                Console.WriteLine("No es un número. Intento de nuevo y escriba un número");
                            }
                            int[,] arrayd = new int[nfilas, ncolumnas];
                            LeeArrayBi(arrayd);
                            EscribeArrayBi(arrayd);
                            CuadradoMagico(arrayd);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}

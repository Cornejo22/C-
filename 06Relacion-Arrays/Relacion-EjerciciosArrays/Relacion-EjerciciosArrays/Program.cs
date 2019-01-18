using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion_EjerciciosArrays
{
    class Program
    {
        /// <summary>
        /// Le pasamos un array de tipo entero de cinco elementos y lo escribe por pantalla
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        static void EscribeArray5(int[] arraya)
        {
            int i;
            Console.Write("[");

            for (i = 0; i < 4; i++)
            {
                    Console.Write(arraya[i] + ",");

            }
            Console.Write(arraya[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le pasamos un array de enteros del tamaño que sea y lo escribe por pantalla
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        static void EscribeArray(int[] arraya)
        {
            int i;
            Console.Write("[");

            for (i = 0; i < arraya.Length - 1; i++)
            {
                Console.Write(arraya[i] + ",");
            }
            Console.Write(arraya[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le pasamos un array de doubles del tamaño que sea y lo escribe por pantalla
        /// </summary>
        /// <param name="arraya">Array de doubles</param>
        static void EscribeArray(double[] arraya)
        {
            int i;
            Console.Write("[");

            for (i = 0; i < arraya.Length - 1; i++)
            {
                Console.Write(arraya[i] + ",");
            }
            Console.Write(arraya[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Le pasamos un array de booleanos del tamaño que sea y lo escribe por pantalla
        /// </summary>
        /// <param name="arraya">Array de booleanos</param>
        static void EscribeArray(bool[] arraya)
        {
            int i;
            Console.Write("[");

            for (i = 0; i < arraya.Length - 1; i++)
            {
                Console.Write(arraya[i] + ",");
            }
            Console.Write(arraya[i]);
            Console.Write("]");
        }

        /// <summary>
        /// Lee un array de enteros de 5 elementos
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>Un array relleno de enteros leidos por pantalla</returns>
        static int[] LeeArray5(int[] arraya)
        {
            int i;
            arraya = new int[5];
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Dime un número para asignar a {0} ", i);
                while (int.TryParse(Console.ReadLine(), out arraya[i]) == false)
                {
                    Console.WriteLine("No es un número");
                }
            }

            return arraya;
        }

        /// <summary>
        /// Lee un array de enteros del tamaño que sea
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>Un array de enteros leidos por pantalla</returns>
        static int[] LeeArray(int[] arraya)
        {
            int i;

            for (i = 0; i < arraya.Length; i++)
            {
                Console.WriteLine("Dime un número para asignar a {0} ", i);
                while (int.TryParse(Console.ReadLine(), out arraya[i]) == false)
                {
                    Console.WriteLine("No es un número");
                }
            }

            return arraya;
        }

        /// <summary>
        /// Modifica el contenido de un array de enteros de cinco elementos y ponga en todas las posiciones un 0.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>Un array donde todo el contenido es 0</returns>
        static int[] PonCeros5(int[] arraya)
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                arraya[i] = 0;
            }

            return arraya;
        }

        /// <summary>
        /// Modifical el contenido de un array de enteros del tamaño que sea y ponga en todas las posiciones un 0.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>Un array donde todo el contenido es 0</returns>
        static int[] PonCeros(int[] arraya)
        {
            int i;

            for (i = 0; i < arraya.Length; i++)
            {
                arraya[i] = 0;
            }

            return arraya;
        }

        /// <summary>
        /// Suma todas las posiciones de un array de enteros de cinco elementos.
        /// <param name="arraya">Un array de enteros</param>
        /// <returns>El resultado de la suma de sus elementos</returns>
        static int SumaArray5(int[] arraya)
        {
            int suma = 0, i;

            for (i = 0; i < 5; i++)
            {
                suma = suma + arraya[i];
            }

            return suma;
        }

        /// <summary>
        /// Suma todas las posiciones de un array de enteros del tamaño que sea.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>El resultado de la suma de sus elementos</returns>
        static int SumaArray(int[] arraya)
        {
            int suma = 0, i;

            for (i = 0; i < arraya.Length; i++)
            {
                suma = suma + arraya[i];
            }

            return suma;
        }

        /// <summary>
        /// Calcular el valor medio de los elementos de un array de enteros de tamaño 5.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>El valor medio</returns>
        static int MediaArray5(int[] arraya)
        {
            int suma, i, contador, media;
            suma = 0;
            contador = 0;

            for (i = 0; i < 5; i++)
            {
                suma = suma + arraya[i];
                contador++;
            }

            media = suma / contador;

            return media;
        }

        /// <summary>
        /// Calcular el valor medio de los elementos de un array de enteros de tamaño que sea.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <returns>El valor medio</returns>
        static int MediaArray(int[] arraya)
        {
            int media, suma, i, contador;
            suma = 0;
            contador = 0;

            for (i = 0; i < arraya.Length; i++)
            {
                suma = suma + arraya[i];
                contador++;
            }

            media = suma / contador;

            return media;
        }

        /// <summary>
        /// Rellena un array de enteros con los números desde el 1 en adelante(hasta el tamaño del array).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        static void RellenaEnOrden(int[] array)
        {
            int i;

            for (i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

        }

        /// <summary>
        /// Rellena un array de enteros con los números en orden descendente, es decir, desde tamaño del array hasta 1
        /// </summary>
        /// <param name="array">Array de enteros</param>
        static void RellenaEnOrdenDesc(int[] array)
        {
            int[] b = new int[array.Length];
            int i;

            RellenaEnOrden(b);

            for (i = 0; i < array.Length; i++)
            {
                array[i] = b[b.Length - i - 1];
            }
        }

        /// <summary>
        /// Rellena un array de enteros con numeros aleatorios entre el 1 y el 10.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        static void RellenaAleatorio(int[] array)
        {
            int i, n;
            Random r = new Random();

            for (i = 0; i < array.Length; i++)
            {
                n = r.Next(1, 10 + 1);
                array[i] = n;
            }
        }

        /// <summary>
        /// Le pasas un array de enteros y te devuelve un booleano que será verdadero si los elementos del array se encuentran en orden ascendente.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>True o false</returns>
        static bool EstaOrdenado(int[] array)
        {
            bool devuelve = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    if (array[i] > array[i + 1])
                    {
                        devuelve = false;
                        break;
                    }
                }
            }

            return devuelve;
        }

        /// <summary>
        /// Le pasas un array de enteros y te devuelve un entero que corresponde a la cantidad de números impares que tenemos en el array.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Cantidad de números impares</returns>
        static int NumerosImpares(int[] array)
        {
            int contadorimp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    contadorimp++;
                }
            }

            return contadorimp;
        }

        /// <summary>
        /// Le pasas un array de enteros y te devuelve el elemento mas pequeño del array
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Elemento más pequeño</returns>
        static int MinArray(int[] array)
        {
            int min, i;
            min = array[0];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Le pasas un array de enteros y te devuelve el elementos más grande del array 
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Elemento más grande del array</returns>
        static int MaxArray(int[] array)
        {
            int max, i;
            max = array[0];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Le pasas un array de enteros y, suponiendo que son notas, nos devuelve el número de aprobados ( valores entre 5 y 10).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Número de aprobados</returns>
        static int NumeroAprobados(int[] array)
        {
            int naprobados = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 5 && array[i] <= 10)
                {
                    naprobados++;
                }
            }

            return naprobados;
        }

        /// <summary>
        /// Le pasamos un valor “limite” y nos devuelve cuántos elementos del array son iguales o mayores que ese límite. 
        /// Por ejemplo, le pasamos el valor 10 y nos dice cuántos elementos son mayores que 10.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="vlimite">Valor que nos indica el límite</param>
        /// <returns>Cantidad de números mayores que el límite</returns>
        static int PorEncimaDe(int[] array, int vlimite)
        {
            int cantidad = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= vlimite)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        /// <summary>
        /// Le pasamos un array y nos devuelve un entero que nos dice cuántos elementos tienen el valor 0.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Cantidad de 0</returns>
        static int CuantosCeros(int[] array)
        {
            int cantidad = 0, i;

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    cantidad++;
                }
            }

            return cantidad;
        }

        /// <summary>
        /// Le pasas dos arrays por parámetro (array1 y array2, por ejemplo) del mismo tamaño (se debería comprobar dentro de la función). 
        /// La función copiara el contenido del primer array al segundo array.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        static void CopiaArray(int[] array, int[] arrayb)
        {
            int i;

            if (arrayb.Length != array.Length)
            {
                Console.Write("Error");
            }
            else
            {
                for (i = 0; i < array.Length; i++)
                {
                    arrayb[i] = array[i];
                }
            }
        }

        /// <summary>
        /// Le pasas dos arrays por parámetro y te copia el contenido del primer array 
        /// al segundo array pero en orden inverso (Ej.: si el primero es [5,6,7,8,9], en el segundo se copiará [9,8,7,6,5]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        static void CopiaArrayInvertido(int[] array, int[] arrayb)
        {
            int i;

            if (arrayb.Length != array.Length)
            {
                CopiaArray(array, arrayb);
            }
            else
            {
                CopiaArray(array, arrayb);
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = arrayb[arrayb.Length - i - 1];
                }
            }
        }

        /// <summary>
        /// 2v. Le pasas dos arrays por parámetro y te copia el contenido del primer array 
        /// al segundo array pero en orden inverso (Ej.: si el primero es [5,6,7,8,9], en el segundo se copiará [9,8,7,6,5]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        static void CopiaArrayInvertido2(int[] array, int[] arrayb)
        {
            int i;
            int contador = -1;

            if (arrayb.Length != array.Length)
            {
                Console.Write("Error");
            }
            else
            {
                for (i = array.Length - 1; i >= 0; i--)
                {
                    contador++;
                    arrayb[contador] = array[i];
                }
            }

        }

        /// <summary>
        /// Le pasamos tres arrays. Los dos primeros contendrán los datos que hay que sumar 
        /// y en el tercero guardaremos el resultado (Ej.: [1,2,3] + [8, 6, 8] = [9, 8, 11]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <param name="arrayc">Array de enteros</param>
        static void SumaArray(int[] array, int[] arrayb, int[] arrayc)
        {
            int i;          

            for (i = 0; i < array.Length; i++)
            {
                arrayc[i] = array[i];
            }

            for (i = 0; i < arrayb.Length; i++)
            {
                arrayc[i] = arrayc[i] + arrayb[i];
            }
        }

        /// <summary>
        /// Le pasamos tres arrays. Los dos primeros contendrán los datos que hay que restar 
        /// y en el tercero guardaremos el resultado (Ej.: [1,2,3] + [8, 6, 8] = [9, 8, 11]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <param name="arrayc">Array de enteros</param>
        static void RestaArray(int[] array, int[] arrayb, int[] arrayc)
        {
            int i;    

            for (i = 0; i < array.Length; i++)
            {
                arrayc[i] = array[i];
            }

            for (i = 0; i < arrayb.Length; i++)
            {
                arrayc[i] = arrayc[i] - arrayb[i];
            }
        }

        /// <summary>
        /// Le pasamos tres arrays. Los dos primeros contendrán los datos que hay que multiplicar 
        /// y en el tercero guardaremos el resultado (Ej.: [1,2,3] + [8, 6, 8] = [9, 8, 11]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <param name="arrayc">Array de enteros</param>
        static void MultiplicaArray(int[] array, int[] arrayb, int[] arrayc)
        {
            int i;           

            for (i = 0; i < array.Length; i++)
            {
                arrayc[i] = array[i];
            }

            for (i = 0; i < arrayb.Length; i++)
            {
                arrayc[i] = arrayc[i] * arrayb[i];
            }
        }

        /// <summary>
        /// Le pasamos tres arrays. Los dos primeros contendrán los datos que hay que dividir
        /// y en el tercero guardaremos el resultado (Ej.: [1,2,3] + [8, 6, 8] = [9, 8, 11]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <param name="arrayc">Array de enteros</param>
        static void DivideArray(int[] array, int[] arrayb, int[] arrayc)
        {
            int i;         

            for (i = 0; i < array.Length; i++)
            {
                arrayc[i] = array[i];
            }

            for (i = 0; i < arrayb.Length; i++)
            {
                arrayc[i] = arrayc[i] / arrayb[i];
            }
        }
       
        /// <summary>
        /// Le pasamos un array de enteros y modifica su contenido invirtiendo la posición de sus elementos (Ej.: [1,2,3] -> [3,2,1]).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        static void InvierteArray(ref int[] array)
        {
            int i;
            int j = 0;
            int[] arrayb = new int[array.Length];

            for (i = array.Length - 1; i >= 0; i--)
            {
                arrayb[j] = array[i];
                j++;
            }

            CopiaArray(arrayb, array);
        }

        /// <summary>
        /// Le pasamos dos arrays y nos devuelve un boolean que será verdadero si los dos arrays 
        /// tienen el mismo tamaño y contienen los mismos datos.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <returns>True o False</returns>
        static bool ComparaArrays(int[] array, int[] arrayb)
        {
            bool igual = false;
            int i;

            if (array.Length == arrayb.Length)
            {
                for (i = 0; i < array.Length; i++)
                {
                    if (array[i] == arrayb[i])
                    {
                        igual = true;
                    }
                    else
                    {
                        igual = false;
                        break;
                    }
                }
            }

            return igual;
        }

        /// <summary>
        /// Le pasamos dos arrays del mismo tamaño. 
        /// El primero será un array de reales (double) y contendrá las notas de los alumnos. 
        /// El segundo será un array de booleanos en el que deberemos escribir en cada posición “true” 
        /// si la nota es mayor o igual que 5 (aprobado) y “false” en caso contrario.
        /// </summary>
        /// <param name="arraynotas">Array de doubles</param>
        /// <param name="arrayaprobados">Array de booleanos</param>
        static void PonNotasArray(double[] arraynotas, bool[] arrayaprobados)
        {
            int i;

            for (i = 0; i < arraynotas.Length; i++)
            {
                if (arraynotas[i] >= 0 && arraynotas[i] <= 10)
                {
                    if (arraynotas[i] >= 5 && arraynotas[i] <= 10)
                    {
                        arrayaprobados[i] = true;
                    }
                    else
                    {
                        arrayaprobados[i] = false;
                    }
                }
                else
                {
                    arrayaprobados[i] = false;
                }
            }
        }

        /// <summary>
        /// Le pasamos tres arrays de enteros. 
        /// Los dos primeros tendrán un tamaño de 5 y contendrán los datos que hay que copiar.
        /// El tercero tendrá un tamaño de 10 y en él copiaremos los datos del primer array 
        /// y después los datos del segundo (Ej.: [4,5,6,7,8] & [1,1,2,2,3] = [4,5,6,7,8,1,1,2,2,3]).
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <param name="arrayc">Array de enteros</param>
        static void ConcatenaArrays55(int[] arraya, int[] arrayb, int[] arrayc)
        {
            int i, j;

            Array.Resize<int>(ref arrayc, 10);

            for (i = 0; i < arraya.Length; i++)
            {
                arrayc[i] = arraya[i];
            }

            for (j = 0; j < arrayb.Length; j++)
            {
                arrayc[i + j] = arrayb[j];
            }
        }

        /// <summary>
        /// Le pasamos tres arrays con la condición de que el tamaño del tercero sea igual a la suma del tamaño de los dos primeros.
        /// Hará lo mismo que la función anterior.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <param name="arrayc">Array de enteros</param>
        static void ConcatenaArrays(int[] arraya, int[] arrayb, int[] arrayc)
        {
            int i, j;

            Array.Resize<int>(ref arrayc, arraya.Length + arrayb.Length);

            for (i = 0; i < arraya.Length; i++)
            {
                arrayc[i] = arraya[i];
            }

            for (j = 0; j < arrayb.Length; j++)
            {
                arrayc[i + j] = arrayb[j];
            }
        }

        /// <summary>
        /// Le pasamos un array y un valor entero. 
        /// La función nos devolverá “true” si el array contiene el número y “false” si no lo contiene.
        /// </summary>
        /// <param name="arraya">Array de enteros</param>
        /// <param name="valor">Un valor entero</param>
        /// <returns>True o False</returns>
        static bool Contiene(int[] arraya, int valor)
        {
            bool devuelve = false;
            int i;

            for (i = 0; i < arraya.Length; i++)
            {
                if (arraya[i] == valor)
                {
                    devuelve = true;
                }
            }

            return devuelve;
        }

        /// <summary>
        /// Le pasas dos arrays de enteros y te devuelve un array cuyo tamaño es la suma del tamaño de ambos 
        /// y que contiene todos los elementos del primero y a continuación los del segundo. 
        /// Esta función devolverá un array de enteros (int[]) el cuál se creará dentro de la propia función.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="arrayb">Array de enteros</param>
        /// <returns>Un array de enteros</returns>
        static int[] ConcatenaArraysPro(int[] array, int[] arrayb)
        {
            int[] arrayc = new int[array.Length + arrayb.Length];
            int i, j;

            for (i = 0; i < array.Length; i++)
            {
                arrayc[i] = array[i];
            }

            for (j = 0; j < arrayb.Length; j++)
            {
                arrayc[i + j] = arrayb[j];
            }

            return arrayc;
        }

        /// <summary>
        /// Le pasas un array y te devuelve un array del mismo tamaño y con los mismos datos.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Un array de enteros</returns>
        static int[] CopiaArrayPro(int[] array)
        {
            int[] arrayb = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayb[i] = array[i];
            }

            return arrayb;
        }

        /// <summary>
        /// Le pasas tres parámetros: un array de enteros, un valor entero y una posición. 
        /// La función insertará el valor en la posición indicada, desplazando el resto de valores para hacerle hueco. 
        /// Ej.: Si tenemos el array [1,2,3,4,5] y queremos insertar el valor “26” en la posición “2”, el resultado será: [1,2,26,3,4,5].
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="entero">Un valor entero</param>
        /// <param name="posicion">Un valor entero</param>
        static void InsertaEnArray(ref int[] array, int entero, int posicion)
        {
            int aux = 0;
            int i;
            Array.Resize(ref array, array.Length + 1);

            for (i = array.Length - 1; i >= posicion; i--)
            {
                if (i == 0)
                {
                    array[i] = array[i];
                }
                else
                {
                    array[i] = array[i - 1];
                }

            }

            aux = array[posicion];
            array[posicion] = entero;
        }

        /// <summary>
        /// Le pasas dos parámetros: un array de enteros y una posición.
        /// La función eliminará el elemento colocado en la posición indicada. 
        /// Ej.: Si tenemos el array [5,7,2,8,1] y queremos eliminar la posición 1, el resultado será: [5,2,8,1].
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="posicion">Un valor entero</param>
        static void BorraDeArray(ref int[] array, int posicion)
        {
            int i;

            //array[posicion] = 0;

            for (i = posicion; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, array.Length - 1);
        }

        /// <summary>
        /// Le pasas dos parámetros: un array de enteros y un valor entero. 
        /// La función eliminará del array el valor entero independientemente de la posición en la que se encuentre.
        /// Si el valor se repite, se eliminará sólo la primera vez que aparece el valor.
        /// </summary>
        /// <param name="array">Array de enteros </param>
        /// <param name="numero">Un valor entero</param>
        static void Elimina1ElementoArray(ref int[] array, int numero)
        {
            int i;

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] == numero)
                {
                    BorraDeArray(ref array, i);
                    i = array.Length;
                }

            }

        }

        /// <summary>
        /// Le pasas dos parámetros: un array de enteros y un valor entero. 
        /// La función eliminará del array el valor entero independientemente de la posición en la que se encuentre. 
        /// Si el valor se repite, se eliminarán todas las veces que se repite.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="numero">Un valor entero</param>
        static void EliminaElementosArray(ref int[] array, int numero)
        {
            int i;

            for (i = 0; i < array.Length; i++)
            {
                Elimina1ElementoArray(ref array, numero);
                
            }
        }

        /// <summary>
        /// Le pasas tres parámetros: un array de enteros, una posición de ese array, y otro array de enteros. 
        /// La función insertará en el primer array, a partir de la posición indicada, todo el contenido del segundo array.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="posicion">Un valor entero</param>
        /// <param name="arrayb">Array de enteros</param>
        static void InsertaArrayEnArray(ref int[] array, int posicion, int[] arrayb)
        {
            int i;

            for (i = 0; i < arrayb.Length; i++)
            {
                InsertaEnArray(ref array, arrayb[i], posicion);
                posicion++;
            }
        }

        /// <summary>
        /// Le pasas un array y dos posiciones. La función te devuelve otro array 
        /// que contiene los datos comprendidos entre ambas posiciones (incluidas ambas dos). 
        /// Ej.: [3, 6, 2, 8, 9], posiciones, 1 y 3, resultado = [6, 2, 8].
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="posicion">Un valor entero</param>
        /// <param name="posicion2">Un valor entero</param>
        /// <returns>Array de enteros</returns>
        static int[] SubArray(int[] array, int posicion, int posicion2)
        {
            int[] arrayb = new int[array.Length];
            Array.Resize(ref arrayb, ((posicion2 + 1) - (posicion + 1)) + 1);
            int i;
            int j = 0;

            for (i = posicion; i <= posicion2; i++)
            {
                arrayb[j] = array[i];
                j++;
            }

            return arrayb;
        }

        /// <summary>
        /// Le pasas un array y dos posiciones. La función modificará el array inicial 
        /// quedándose sólo con lo contenido entre ambas posiciones 
        /// (como el ejercicio anterior pero en vez de devolver un array diferente modifica el array que le pasas).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="posicion">Un valor entero</param>
        /// <param name="posicion2">Un valor entero</param>
        static void RecortaArray(ref int[] array, int posicion, int posicion2)
        {
            int i;
            int[] arrayb = CopiaArrayPro(array);
            Array.Resize(ref array, ((posicion2 + 1) - (posicion + 1)) + 1);
            int j = 0;

            for (i = posicion; i <= posicion2; i++)
            {
                array[j] = arrayb[i];
                j++;
            }

        }

        /// <summary>
        /// Realiza la ordenación de un array mediante el algoritmo de selección. 
        /// El algoritmo funciona de la siguiente forma: cogemos el array que queremos ordenar y un array vacío; 
        /// quitamos del primer array el elemento más pequeño y lo insertamos en el segundo array; 
        /// repetimos el proceso hasta que el primer array esté vacío y
        /// el segundo contenga todos los elementos ordenados de menor a mayor.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Un array de enteros</returns>
        static int[] OrdenaSeleccion(int[] array)
        {
            int[] arrayb = new int[0];
            int i;
            int posm;
            for (i = 0; i < array.Length; i++)
            {
                posm = PosMinArray(array);
                InsertaAlFinal(ref arrayb, array[posm]);
                BorraDeArray(ref array, posm);
                i--;
            }

            return arrayb;
        }

        /// <summary>
        /// Te inserta un elemento al final de un array (incrementando su tamaño).
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <param name="entero">Un valor entero</param>
        /// <returns>Un array de enteros</returns>
        static int[] InsertaAlFinal(ref int[] array, int entero)
        {
            int aux = entero;
            int posicion = 0;
            Array.Resize(ref array, array.Length + 1);
            posicion = array.Length - 1;

            aux = array[posicion];
            array[posicion] = entero;

            return array;

        }

        /// <summary>
        /// Te devuelve la posición donde se encuentra el elemento más pequeño del array.
        /// </summary>
        /// <param name="array">Array de enteros</param>
        /// <returns>Elemento más pequeño del array</returns>
        static int PosMinArray(int[] array)
        {
            int posmin = 0;
            int i;
            int entero = array[0];

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < entero)
                {
                    posmin = i;
                    entero = array[i];
                }
            }

            return posmin;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();

                Console.WriteLine("                                                 MENU");
                Console.WriteLine("===========================================================================================================");
                Console.WriteLine("1º-  EscribeArray5          2º- EscribeArray           3º-  LeeArray5             4º- LeeArray");
                Console.WriteLine("5º-  PonCeros5              6º- PonCeros               7º-  SumaArray5            8º- SumaArray");
                Console.WriteLine("9º-  MediaArray5           10º- MediaArray            11º- RellenaEnOrden        12º- RellenaEnOrdenDesc");
                Console.WriteLine("13º- RellenaAleatorio      14º- EstaOrdenado          15º- NúmeroImpares         16º- MinArray");
                Console.WriteLine("17º- MaxArray              18º- NúmeroAprobados       19º- PorEncimaDe           20º- CuantosCeros");
                Console.WriteLine("21º- CopiaArray            22º- CopiaArrayInvertido   23º- SumaArray             24º- RestaArray");
                Console.WriteLine("25º- MultiplicaArray       26º- DivideArray           27º- InvierteArray         28º- ComparaArray");
                Console.WriteLine("29º- PonNotasArray         30º- ConcatenaArrays55     31º- ConcatenaArray        32º- Contiene");
                Console.WriteLine("33º- ConcatenaArraysPro    34º- CopiaArraysPro        35º- InsertaEnArray        36º- BorraDeArray");
                Console.WriteLine("37º- Elimina1ElementoArray 38º-EliminaElementosArray  39º- InsertaArrayEnArray   40º- SubArray");
                Console.WriteLine("41º- RecortaArray          42º- OrdenaSelección");
                Console.WriteLine();
                Console.WriteLine("Dime el ejercicio : ");
                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        {
                            int[] arraya = new int[5] { 23, 43, 1, -3, 6 };
                            EscribeArray5(arraya);
                        }
                        break;
                    case "2":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int i;
                            int[] arraya = new int[longitud];
                            for (i = 0; i < arraya.Length; i++)
                            {
                                Console.WriteLine("Dime un número para asignar a {0} ", i);
                                while (int.TryParse(Console.ReadLine(), out arraya[i]) == false)
                                {
                                    Console.WriteLine("No es un número");
                                }
                            }
                            EscribeArray(arraya);
                        }
                        break;
                    case "3":
                        {
                            int[] arraya = new int[5];
                            EscribeArray5(LeeArray5(arraya));
                        }
                        break;
                    case "4":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] arraya = new int[longitud];
                            EscribeArray(LeeArray(arraya));
                        }
                        break;
                    case "5":
                        {
                            int[] array = new int[5];
                            int[] escrito = LeeArray5(array);
                            EscribeArray5(escrito);
                            PonCeros5(escrito);
                            EscribeArray5(escrito);
                        }
                        break;
                    case "6":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            PonCeros(escrito);
                            EscribeArray(escrito);
                        }
                        break;
                    case "7":
                        {
                            int[] array = new int[5];
                            int[] escrito = LeeArray5(array);
                            EscribeArray5(escrito);
                            Console.WriteLine("\nTu suma es : {0} ", SumaArray5(escrito));
                        }
                        break;
                    case "8":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nTu suma es : {0} ", SumaArray(escrito));
                        }
                        break;
                    case "9":
                        {
                            int[] array = new int[5];
                            int[] escrito = LeeArray5(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nTu media es : {0} ", MediaArray5(escrito));
                        }
                        break;
                    case "10":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nTu media es : {0} ", MediaArray(escrito));
                        }
                        break;
                    case "11":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            EscribeArray(array);
                            RellenaEnOrden(array);
                            EscribeArray(array);
                        }
                        break;
                    case "12":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            EscribeArray(array);
                            RellenaEnOrdenDesc(array);
                            EscribeArray(array);
                        }
                        break;

                    case "13":
                        {
                            int[] array = new int[10];
                            EscribeArray(array);
                            RellenaAleatorio(array);
                            EscribeArray(array);
                        }
                        break;

                    case "14":
                        {
                            int[] array = new int[6] { 1, 3, 11, 8, 10, 11 };
                            EscribeArray(array);
                            Console.WriteLine("\n" + EstaOrdenado(array));
                        }
                        break;
                    case "15":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nTu cantidad de impares es : {0} ", NumerosImpares(escrito));
                        }
                        break;
                    case "16":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nEl elemento más pequeño del array es : {0} ", MinArray(escrito));
                        }
                        break;
                    case "17":
                        {
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nEl elemento más grande del array es : {0} ", MaxArray(escrito));
                        }
                        break;

                    case "18":
                        {
                            int[] array = new int[6] { 1, 3, 5, 8, 10, 11 };
                            EscribeArray(array);
                            Console.WriteLine("\nEl número de aprobado es : {0} ", NumeroAprobados(array));
                        }
                        break;
                    case "19":
                        {
                            int vlimite;
                            Console.WriteLine("Dime un valor límite : ");
                            while (int.TryParse(Console.ReadLine(), out vlimite) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[6] { 1, 3, 5, 8, 10, 11 };
                            EscribeArray(array);
                            Console.WriteLine("\nLa cantidad de números que son iguales o que sobrepasan a {0} es {1} ", vlimite, PorEncimaDe(array, vlimite));
                        }
                        break;

                    case "20":
                        {
                            int[] array = new int[6] { 1, 3, 5, 0, 10, 11 };
                            EscribeArray(array);
                            Console.WriteLine("\nEl número de 0 es : {0} ", CuantosCeros(array));
                        }
                        break;
                    case "21":
                        {
                            int[] array = new int[4] { 4, 5, 6, 7 };
                            int[] arrayb = new int[4];

                            EscribeArray(array);
                            Console.WriteLine();
                            Console.WriteLine();
                            CopiaArray(array, arrayb);
                            EscribeArray(arrayb);
                        }
                        break;

                    case "22":
                        {
                            int[] array = new int[4] { 4, 5, 6, 7 };
                            int[] arrayb = new int[4];

                            EscribeArray(array);
                            Console.WriteLine();
                            Console.WriteLine();
                            CopiaArrayInvertido(array, arrayb);
                            CopiaArrayInvertido2(array, arrayb);
                            EscribeArray(arrayb);
                        }
                        break;
                    case "23":
                        {
                            int[] array = new int[3] { 1, 2, 3 };
                            int[] arrayb = new int[3] { 8, 6, 8 };
                            int[] arrayc = new int[array.Length];

                            EscribeArray(array);
                            Console.WriteLine();
                            EscribeArray(arrayb);
                            Console.WriteLine();
                            SumaArray(array, arrayb, arrayc);
                            EscribeArray(arrayc);
                        }
                        break;

                    case "24":
                        {
                            int[] array = new int[3] { 1, 2, 3 };
                            int[] arrayb = new int[3] { 8, 6, 8 };
                            int[] arrayc = new int[array.Length];

                            EscribeArray(array);
                            Console.WriteLine();
                            EscribeArray(arrayb);
                            Console.WriteLine();
                            RestaArray(array, arrayb, arrayc);
                            EscribeArray(arrayc);
                        }
                        break;

                    case "25":
                        {
                            int[] array = new int[3] { 1, 2, 3 };
                            int[] arrayb = new int[3] { 8, 6, 8 };
                            int[] arrayc = new int[array.Length];

                            EscribeArray(array);
                            Console.WriteLine();
                            EscribeArray(arrayb);
                            Console.WriteLine();
                            MultiplicaArray(array, arrayb, arrayc);
                            EscribeArray(arrayc);
                        }
                        break;

                    case "26":
                        {
                            int[] array = new int[3] { 16, 12, 24 };
                            int[] arrayb = new int[3] { 8, 6, 8 };
                            int[] arrayc = new int[array.Length];

                            EscribeArray(array);
                            Console.WriteLine();
                            EscribeArray(arrayb);
                            Console.WriteLine();
                            DivideArray(array, arrayb, arrayc);
                            EscribeArray(arrayc);
                        }
                        break;

                    case "27":
                        {
                            int[] array = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
                            EscribeArray(array);
                            InvierteArray(ref array);
                            EscribeArray(array);
                        }
                        break;

                    case "28":
                        {
                            int[] array = new int[3] { 1, 2, 3 };
                            int[] arrayb = new int[3] { 1, 3, 5 };
                            EscribeArray(array);
                            Console.Write(" = ");
                            EscribeArray(arrayb);
                            Console.WriteLine("\nEs : {0} ", ComparaArrays(array, arrayb));
                        }
                        break;

                    case "29":
                        {
                            double[] arraynotas = new double[5] { -5, 6, 4, 3, 10 };
                            bool[] arrayaprobados = new bool[arraynotas.Length];

                            EscribeArray(arraynotas);
                            PonNotasArray(arraynotas, arrayaprobados);
                            EscribeArray(arrayaprobados);
                        }
                        break;

                    case "30":
                        {
                            int[] array = new int[5] { 4, 5, 6, 7, 8 };
                            int[] arrayb = new int[5] { 1, 1, 2, 2, 3 };
                            int[] arrayc = new int[10];

                            EscribeArray(array);
                            EscribeArray(arrayb);
                            ConcatenaArrays55(array, arrayb, arrayc);
                            EscribeArray(arrayc);
                        }
                        break;

                    case "31":
                        {
                            int[] array = new int[6] { 4, 5, 6, 7, 8, 3 };
                            int[] arrayb = new int[5] { 1, 1, 2, 2, 3 };
                            int[] arrayc = new int[array.Length + arrayb.Length];

                            EscribeArray(array);
                            EscribeArray(arrayb);
                            ConcatenaArrays(array, arrayb, arrayc);
                            EscribeArray(arrayc);
                        }
                        break;

                    case "32":
                        {
                            int numero;
                            Console.WriteLine("Dime un número : ");
                            while (int.TryParse(Console.ReadLine(), out numero) == false)
                            {
                                Console.WriteLine("No es un número. Prueba de nuevo");
                            }
                            int longitud;
                            Console.WriteLine("¿De que tamaño quieres el array?");
                            while (int.TryParse(Console.ReadLine(), out longitud) == false)
                            {
                                Console.WriteLine("No es un número.Intentelo de nuevo");
                            }
                            int[] array = new int[longitud];
                            int[] escrito = LeeArray(array);
                            EscribeArray(escrito);
                            Console.WriteLine("\nTu número {0} es {1}", numero, Contiene(array, numero));

                        }
                        break;

                    case "33":
                        {
                            int[] array = new int[6] { 4, 5, 6, 7, 8, 3 };
                            int[] arrayb = new int[5] { 1, 1, 2, 2, 3 };
                            int[] arrayc = new int[0];

                            EscribeArray(array);
                            Console.Write(" y ");
                            EscribeArray(arrayb);
                            Console.Write(" = ");
                            EscribeArray(ConcatenaArraysPro(array, arrayb));
                        }
                        break;
                    case "34":
                        {
                            int[] array = new int[3] { 5, 2, 3 };
                            int[] arrayb;
                            EscribeArray(array);
                            arrayb = CopiaArrayPro(array);
                            EscribeArray(arrayb);
                        }
                        break;

                    case "35":
                        {
                            int[] array = new int[5] { 1, 2, 3, 4, 5 };
                            int entero = 26;
                            int posicion = 0;
                            EscribeArray(array);
                            InsertaEnArray(ref array, entero, posicion);
                            EscribeArray(array);
                        }
                        break;

                    case "36":
                        {
                            int[] array = new int[5] { 5, 7, 2, 8, 1 };
                            int posicion = 4;
                            EscribeArray(array);
                            BorraDeArray(ref array, posicion);
                            EscribeArray(array);
                        }
                        break;
                    case "37":
                        {
                            int[] array = new int[8] { 1, 2, 3, 3, 2, 2, 3, 4 };
                            int numero = 1;
                            EscribeArray(array);
                            Elimina1ElementoArray(ref array, numero);
                            EscribeArray(array);
                        }
                        break;
                    case "38":
                        {
                            int[] array = new int[9] { 1, 2, 2, 3, 3, 2, 2, 3, 4 };
                            int numero = 2;
                            EscribeArray(array);
                            EliminaElementosArray(ref array, numero);
                            EscribeArray(array);
                        }
                        break;

                    case "39":
                        {
                            int[] array = new int[4] { 6, 2, 1, 3 };
                            int[] arrayb = new int[3] { 12, 13, 15 };
                            int posicion = 0;

                            EscribeArray(array);
                            InsertaArrayEnArray(ref array, posicion, arrayb);
                            EscribeArray(array);
                        }
                        break;

                    case "40":
                        {
                            int[] array = new int[8] { 3, 6, 2, 8, 9, 3, 4, 5 };
                            int posicion = 5;
                            int posicion2 = 7;

                            EscribeArray(array);
                            EscribeArray(SubArray(array, posicion, posicion2));

                        }
                        break;

                    case "41":
                        {
                            int[] array = new int[8] { 3, 6, 2, 8, 9, 2, 1, 0 };
                            int posicion = 0;
                            int posicion2 = 3;
                            EscribeArray(array);
                            RecortaArray(ref array, posicion, posicion2);
                            EscribeArray(array);
                        }
                        break;
                    case "42":
                        {
                            int[] array = new int[6] { 4, 1, 3, 2, 5, 6 };
                            EscribeArray(array);
                            EscribeArray(OrdenaSeleccion(array));
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacion_EjerciciosCadenas
{
    class Program
    {
        /// <summary>
        /// Le pasamos una cadena y nos devuelve la cantidad de espacios de la cadena.
        /// </summary>
        /// <param name="cadena">Tipo String</param>
        /// <returns>Variable int</returns>
        static int NumeroEspacios(string cadena)
        {
            int cuenta = 0;
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ' ')
                {
                    cuenta++;
                }
            }

            return cuenta;
        }
        
        /// <summary>
        /// Le pasamos una cadena y nos devuelve la cantidad de vocales de la cadena.
        /// </summary>
        /// <param name="cadena">Tipo String</param>
        /// <returns>Variable int</returns>
        static int NumeroVocales(string cadena)
        {
            char[] arrayV = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int cantidadV = 0;
            int i;
            int j;

            for (i = 0; i < cadena.Length; i++)
            {
                for (j = 0;  j < arrayV.Length; j++)
                {
                    if (arrayV[j] == cadena[i])
                    {
                        cantidadV++;
                        j = arrayV.Length;
                    }
                }
            }

            return cantidadV;
        }

        /// <summary>
        /// Le pasamos una cadena y nos dice si la cadena es un palíndromo
        /// </summary>
        /// <param name="cadena">Variable String</param>
        /// <returns>Variable booleana</returns>
        static bool EsPalindromo(string cadena)
        {
            string cadena2 = cadena.ToLower();
            string cadena3 = cadena2;
            bool verdad = true;
            int i;
            int j = cadena2.Length - 1;

            for (i = 0; i < cadena2.Length - 1; i++)
            {               
                if (cadena2[i] != cadena3[j])
                {
                    verdad = false;
                }
                j--;
            }

            return verdad;
        }

        /// <summary>
        /// Nos centra una cadena en la pantalla
        /// </summary>
        /// <param name="cadena">Variable String</param>
        /// <returns>Variable String</returns>
        static string Centra80(string cadena)
        {
            string caD;
            caD = RepiteCaracter(' ', (80 - cadena.Length) / 2) + cadena;
            return caD;

        }

        /// <summary>
        /// Función que nos dirá si un carácter aparece en una cadena o no.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <param name="caracter">Variable tipo Char</param>
        /// <returns>Variable booleana</returns>
        static bool Contiene(string cadena,char caracter)
        {
            int i;
            bool verdad = false;
            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == caracter)
                {
                    verdad = true;
                    i = cadena.Length;
                }               
            }

            return verdad;
        }

        /// <summary>
        /// La función nos devolverá una cadena que contendrá un carácter
        /// repetido tantas veces como nos indique un entero.
        /// </summary>
        /// <param name="caracter">Variable tipo char</param>
        /// <param name="entero">Variable int</param>
        /// <returns>Variable tipo string</returns>
        static string RepiteCaracter(char caracter,int entero)
        {
            string devolverC = "";
            int i;

            for (i = 0; i < entero; i++)
            {
                devolverC = devolverC + caracter;
            }

            return devolverC;
        }

        /// <summary>
        /// Función que nos quitára los espacios que estén al principio y final de la cadena.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string QuitaEspacios(string cadena)
        {
            //Usar dos for
            int i;
            int posi;
            string caD = cadena;
            for (i = 0; i < caD.Length; i++)
            {
                if (caD[i] != ' ')
                {
                    posi = i;
                    break;
                }
            }
            caD = caD.Remove(0, i);

            for (i = caD.Length - 1; i > 0; i--)
            {
                if (caD[i] != ' ')
                {
                    posi = i;
                    break;
                }
            }
            caD = caD.Remove(i + 1);

            return caD;
        } 

        /// <summary>
        /// Esta función nos sustituirá un carácter contenida en la cadena por 
        /// otro carácter que le pasemos por parámetro.
        /// </summary>
        /// <param name="cadena">Variable tipo string</param>
        /// <param name="a">Variable char</param>
        /// <param name="b">Variable char</param>
        /// <returns>Variable string </returns>
        static string SustituyeCaracter(string cadena,char a,char b)
        {
            string caD = "";
            int i;
            string cadena2 = cadena.ToLower();

            for (i = 0; i < cadena2.Length; i++)
            {
                if(cadena2[i] == a)
                {
                    //caD = cadena2.Replace(a, b); 
                    caD = caD + b;
                }
                else
                {
                    caD = caD + cadena2[i];
                }
            }

            return caD;
        }

        /// <summary>
        /// La función nos contará el número de palabras que contiene la cadena.
        /// </summary>
        /// <param name="cadena">Variable String</param>
        /// <returns>Variable int</returns>
        static int CuentaPalabras(string cadena)
        {
            int nV = 0;
            string[] trozos = cadena.Split(' ');
            nV = trozos.Length;

            return nV;
        }

        /// <summary>
        /// Función que nos dirá si una cadena está compuesta enteramente de numeros o no.
        /// </summary>
        /// <param name="cadena">Variable String</param>
        /// <returns>Variable booleana</returns>
        static bool EsNumero(string cadena)
        {
            bool devuelve = true;
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if (char.IsLetter(cadena[i]) == true)
                {
                    devuelve = false;
                }
            }

            return devuelve;
        }

        /// <summary>
        /// Función que nos quitará todos los espacios de la cadena.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string QuitaEspaciosPro(string cadena)
        {
            string caD = "";
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] != ' ')
                {
                    caD = caD + cadena[i];
                }
            }

            return caD;
        }

        /// <summary>
        /// Función a la cual le pasamos una cadena y un carácter y nos
        /// devuelve la cadena pero con todas las ocurrencias 
        /// de ese carácter quitadas.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <param name="caracter">Variable Char</param>
        /// <returns>Variable tipo String</returns>
        static string QuitaCaracter(string cadena, char caracter)
        {
            string caD = "";
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] != caracter)
                {
                    caD = caD + cadena[i];
                }
            }

            return caD;
        }

        /// <summary>
        /// Le pasas una cadena y te duvuelve una cadena con la primera
        /// letra de cada palabra puesta en mayuscula.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string MayusculaPrimera(string cadena)
        {
            string caD = "";

            int i;

            for (i = 1; i < cadena.Length; i++)
            {
                if(cadena[i-1] == ' ' && char.IsLetter(cadena[i]))
                {
                    caD = caD + char.ToUpper(cadena[i]);
                }
                else
                {
                    caD = caD + cadena[i];
                }
            }

            return caD;
        }

        /// <summary>
        /// Función, donde le pasamos una cadena con carácteres acentuados
        /// y te devuelve una cadena con los acentos quitados.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string QuitaAcentos(string cadena)
        {
            string cadena2 = cadena;
            string caD = "";
            string j;
            string i;

            string consignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜÑçÇ";
            string sinsignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUNcC";
            for (int v = 0; v < sinsignos.Length; v++)
            {
                i = consignos.Substring(v, 1);
                j = sinsignos.Substring(v, 1);
                cadena2 = cadena2.Replace(i, j);
            }
            caD = cadena2;
            return caD;
        }

        /// <summary>
        /// Le pasamos un cadena y nos la devuelve invertida(de detrás para delante, vamos).
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string InvierteCadena(string cadena)
        {
            string caD = "";
            int i;

            for (i = cadena.Length-1; i >= 0; i--)
            {
                caD = caD + cadena[i];
            }

            return caD;
        }

        /// <summary>
        /// Le pasamos una cadena y un carácter y nos
        /// dice cuántas veces se repite ese carácter.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <param name="letra">Variable tipo Char</param>
        /// <returns>Variable int</returns>
        static int VecesCaracter(string cadena,char letra)
        {
            int cV = 0;
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == letra)
                {
                    cV++;
                }
            }

            return cV;
        }

        /// <summary>
        /// Función,donde le pasamos una cadena y una palabra y nos dice cuantas
        /// veces se repite esa palabra en la cadena.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <param name="cad">Variable tipo String</param>
        /// <returns>Variable int</returns>
        static int VecesPalabra(string cadena,string cad)
        {
            int nV = 0;
            string[] trozos = cadena.ToLower().Split(' ');
            int i;

            for (i = 0; i < trozos.Length; i++)
            {
                if(trozos[i] == cad)
                {
                    nV++;
                }
            }

            return nV;
        }

        /// <summary>
        /// Función, donde le pasamos una cadena y dos palabras y
        /// nos devuelve otra cadena en la que haya que 
        /// sustituir la primera por la segunda.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <param name="palabra1">Variable tipo String</param>
        /// <param name="palabra2">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string SustituyePalabra(string cadena, string palabra1, string palabra2)
        {
            string caD = "";
            int i;
            string[] trozos = cadena.Split(' ');

            for (i = 0; i < trozos.Length; i++)
            {
                if (trozos[i] == palabra1)
                {
                    caD = caD + " " + palabra2;
                }
                else
                {
                    caD = caD + " " + trozos[i];
                }
            }

            return caD;
        }

        /// <summary>
        /// Funcion,donde le pasamos dos cadenas y nos busca
        /// la segunda cadena dentro de la primera.Nos devolverá otra cadena igual que la
        /// primera pero en la que se cambiará la primera letra de cada vez que aparece la
        /// subcadena por un asterisco.
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <param name="cad2">Variable tipo String</param>
        /// <returns>Variable tipo String</returns>
        static string MarcaSubCadena(string cadena, string cad2)
        {
            string caD = "";
            int i;
            int j;

            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena.Substring(i, cad2.Length) == cad2)
                {
                    for (j = 0; j < cad2.Length; j++)
                    {
                        if (j == 0)
                        {
                            caD = caD + "*";
                        }
                        else
                        {
                            caD = caD + cad2[j];
                            i++;
                        }
                    }

                }
                else
                {
                    caD = caD + cadena[i];
                }

            }
            return caD;
        }

        /// <summary>
        /// Función,donde le pasamos una cadena y nos devuelve
        /// otra en la que están invertidas todas las palabras(no la cadena entera, sino cada
        /// palabra independientemente).
        /// </summary>
        /// <param name="cadena">Variable tipo String</param>
        /// <returns>Variable tipo String </returns>
        static string InviertePalabras(string cadena)
        {
            string caD = "";
            int i;
            int j;
            string[] trozos = cadena.Split(' ');

            for (i = 0; i < trozos.Length; i++)
            {
                caD = caD + InvierteCadena(trozos[i]) + " ";
            }

            return caD;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();

                Console.WriteLine("                             MENU");
                Console.WriteLine("====================================================================");
                Console.WriteLine(" 1º-NumeroEspacios     2º-NumeroVocales     3º-EsPalindromo");
                Console.WriteLine(" 4º-Centra80           5º-Contiene          6º-RepiteCaracter");
                Console.WriteLine(" 7º-QuitaEspacios      8º-SustituyeCaracter 9º-CuentaPalabras");
                Console.WriteLine("10º-EsNumero          11º-QuitaEspaciosPro 12º-QuitaCaracter");
                Console.WriteLine("13º-MayusculaPrimera  14º-QuitaAcentos     15º-InvierteCadena");
                Console.WriteLine("16º-VecesCaracter     17º-VecesPalabra     18º-SustituyePalabra");
                Console.WriteLine("19º-MarcaSubCadena    20º-InviertePalabras");
                Console.Write("\nDime el ejercicio : ");
                opcion = Console.ReadLine();

                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        {
                            string cadena = " Mi perro se llama San Bernando ";
                            Console.WriteLine(cadena);
                            Console.Write("El número de espacios es : " + NumeroEspacios(cadena));
                        }
                        break;
                    case "2":
                        {
                            string cadena = "SupercaliFragilisticoEspialidoso";
                            Console.WriteLine(cadena);
                            Console.Write("El número de vocales es : " + NumeroVocales(cadena));
                        }
                        break;
                    case "3":
                        {
                            string palindromo = "Ana";
                            Console.WriteLine(palindromo);
                            Console.WriteLine("Es : " + EsPalindromo(palindromo));
                        }
                        break;
                    case "4":
                        {
                            string cadena = "Hola";
                            Console.WriteLine(cadena);
                            Console.WriteLine(Centra80(cadena)); 
                        }
                        break;
                    case "5":
                        {
                            string cadena = "el compañero de mi padre es mi amigo";
                            char letra = 'E';
                            Console.WriteLine("La frase es : " + cadena + " y la letra es : " + letra);
                            Console.WriteLine("Es : " + Contiene(cadena,letra));

                        }
                        break;

                    case "6":
                        {
                            char letra = 'E';
                            int entero = 9;
                            Console.WriteLine("La cadena : " + RepiteCaracter(letra,entero));
                        }
                        break;

                    case "7":
                        {
                            string cadena = "    Hola ,buenos dias    ";
                            Console.WriteLine(">" + cadena + "<");
                            Console.WriteLine(">"+ QuitaEspacios(cadena) + "<");
                        }
                        break;

                    case "8":
                        {
                            string cadena = "Buenos dias, don Antonio";
                            char a = 'a';
                            char b = '2';
                            Console.WriteLine(cadena);
                            Console.WriteLine(SustituyeCaracter(cadena,a,b));
                        }
                        break;

                    case "9":
                        {
                            string cadena = "Hola me llamo Don Benito";
                            Console.WriteLine(cadena);
                            Console.WriteLine(CuentaPalabras(cadena));
                        }
                        break;

                    case "10":
                        {
                            string cadena = "3231";
                            Console.WriteLine(cadena);
                            Console.WriteLine("Es : " + EsNumero(cadena));
                        }
                        break;

                    case "11":
                        {
                            string cadena = " Bienvenidos al sur ";
                            Console.WriteLine(cadena);
                            Console.WriteLine(QuitaEspaciosPro(cadena));
                        }
                        break;

                    case "12":
                        {
                            string cadena = "No soy gallego";
                            char caracter = 'o';
                            Console.WriteLine(cadena);
                            Console.WriteLine(QuitaCaracter(cadena,caracter));
                        }
                        break;

                    case "13":
                        {
                            string cadena = " la televisión es muy grande";
                            Console.WriteLine(cadena);
                            Console.WriteLine(MayusculaPrimera(cadena));

                        }
                        break;

                    case "14":
                        {
                            string cadena = "áéíóúÁÉÍÓÚ.";
                            Console.WriteLine(cadena);
                            Console.WriteLine(QuitaAcentos(cadena));
                        }
                        break;

                    case "15":
                        {
                            string cadena = "buenas estoy aqui ";
                            Console.WriteLine(cadena);
                            Console.WriteLine(InvierteCadena(cadena));
                        }
                        break;

                    case "16":
                        {
                            string cadena = "Hola, buenas estoy buscando alojamiento";
                            char letra = '5';
                            Console.WriteLine(cadena);
                            Console.WriteLine(letra);
                            Console.WriteLine("Aparece : " + VecesCaracter(cadena,letra));
                            Console.WriteLine();
                        }
                        break;

                    case "17":
                        {
                            string cadena = " Mi mama mi mima mucho ";
                            string cad2 = "mi";
                            Console.WriteLine("La frase es : " + cadena);
                            Console.WriteLine("Tu palabra es : " + cad2);
                            Console.WriteLine("Aparece : " + VecesPalabra(cadena,cad2));
                        }
                        break;

                    case "18":
                        {
                            string cadena = "Mi mama me mima mucho ";
                            string palabra1 = "mucho";
                            string palabra2 = "poco";
                            Console.WriteLine("La frase es : " + cadena);
                            Console.WriteLine("La frase devuelta es : " + SustituyePalabra(cadena,palabra1,palabra2));
                        }
                        break;

                    case "19":
                        {
                            string cad = "Mi mama me mima, yo mimo a mi mama";
                            string cad2 = "ma";
                            Console.WriteLine(cad);
                            Console.WriteLine(MarcaSubCadena(cad,cad2));
                          
                        }
                        break;

                    case "20":
                        {
                            string cad = "Mi mima me mucho";
                            Console.WriteLine(cad);
                            Console.WriteLine(InviertePalabras(cad));
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

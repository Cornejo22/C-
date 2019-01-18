using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionCObjeto_Fracciones
{
    class Fraccion
    {
        //Atributos
        private int numerador;
        private int denominador;

        //Constructores
        /// <summary>
        /// Creamos una fracción comprobando que el denominador no sea 0.
        /// </summary>
        /// <param name="numerador">Entero</param>
        /// <param name="denominador">Entero</param>
        public Fraccion(int numerador,int denominador)
        {
            if(denominador <= 0)
            {
                throw new Exception("Error");
            }
            else
            {
                this.numerador = numerador;
                this.denominador = denominador; 
            }
        }

        /// <summary>
        /// Creamos una fracción donde el denominador será 1.
        /// </summary>
        /// <param name="numero">Entero</param>
        public Fraccion(int numero)
        {
            this.numerador = numero;
            this.denominador = 1;
        }

        /// <summary>
        /// Creamos una fracción pasandole un double y nos la representaremos como tal.
        /// </summary>
        /// <param name="numero">Entero</param>
        public Fraccion(double numero)
        {
            double temporal = numero;
            this.denominador = 1;
            while (temporal != Math.Truncate(temporal))
            {
                temporal = temporal * 10;
                denominador = denominador * 10;
            }

            this.numerador = Convert.ToInt32(temporal);

            //string temporal = numero.ToString();
            //double tmp2 = numero;
            //int i;
            //int pos;
            //int contador = 0;
            //if (temporal.Contains(','))
            //{
            //    contador = temporal.Length - temporal.IndexOf(',') - 1;

            //    pos = temporal.IndexOf(',');
            //    for (i = pos+1; i < temporal.Length; i++)
            //    {
            //        contador++;
            //    }
            //}
            //i = 0;
            //while (i<=contador)
            //{
            //    tmp2 = tmp2 * 10;
            //    denominador = denominador * 10;
            //    i++;
            //}

            //this.numerador = Convert.ToInt32(tmp2);

            //denominador = 1;
            //while(numero.ToString().Contains(','))
            //{
            //    numero = numero * 10;
            //    denominador = denominador * 10;
            //}
            //numerador = Convert.ToInt32(numero);
        }

        //Métodos Privados
        /// <summary>
        /// Devolveremos el máximo común divisor de dos números que le pasamos por parámetro.
        /// </summary>
        /// <param name="num1">Entero</param>
        /// <param name="num2">Entero</param>
        /// <returns>Entero</returns>
        private static int MCD(int num1, int num2)
        {
            int mcd, i;
            i = num1;
            mcd = 0;

            while (i >= 1)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    mcd = i;
                    break;
                }
                i--;
            }

            return mcd;
        }

        /// <summary>
        /// Devolveremos el mínimo común múltiplo de dos números que le pasamos por parámetro.
        /// </summary>
        /// <param name="num1">Entero</param>
        /// <param name="num2">Entero</param>
        /// <returns>Entero</returns>
        private static int MCM(int num1, int num2)
        {
            int i, min;
            int mcd = 1;
            int mcm = 0;

            min = num1;

            for (i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    mcd = i;
                    mcm = (num1 * num2) / mcd;
                }
            }

            return mcm;        
        }

        //Métodos
        /// <summary>
        /// Simplificaremos una fraccíon lo máximo posible.
        /// </summary>
        public void Simplificar()
        {
            int mcd = MCD(numerador,denominador);
            this.numerador = numerador / mcd;
            this.denominador = denominador / mcd;
        }

        /// <summary>
        /// Nos mostrará la fracción por pantalla (3 / 4) mediante una cadena.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return this.numerador + " / " + this.denominador; 
        }

        //Propiedades
        /// <summary>
        /// Nos devolverá un double correspondiente al valor de la fracción, de solo lectura.
        /// </summary>
        public double ValorDouble
        {
            get
            {
                double numerador1 = this.numerador;
                double denominador1 = this.denominador;

                return numerador1 / denominador1;
            }
        }

        /// <summary>
        /// Nos permitirá ver y modificar el numerador de la fracción.
        /// </summary>
        public int Numerador
        {
            get
            {
                return numerador;
            }
            set
            {
                numerador = value;
            }
        }

        /// <summary>
        /// Nos permitirá ver y modificar el denominador de la fracción.
        /// </summary>
        public int Denominador
        {
            get
            {
                return denominador;
            }
            set
            {
                denominador = value;
            }
        }

        //Operadores
        /// <summary>
        /// Nos devolverá la suma de dos fracciones.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>Objeto</returns>
        public static Fraccion operator+(Fraccion f1,Fraccion f2)
        {

            if (f1.denominador == f2.denominador)
            {
                Fraccion f3 = new Fraccion(f1.numerador + f2.numerador, f1.denominador);
                return f3;               
            }
            else
            {
                Fraccion f3 = new Fraccion(1, 1);
               
                f3.denominador = MCM(f1.denominador, f2.denominador);
                f3.numerador = ((f3.denominador / f1.denominador) * f1.numerador) + ((f3.denominador / f2.denominador) * f2.numerador);

                return f3;                 
            }
        }

        /// <summary>
        /// Nos devolverá la resta de dos fracciones.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>Objeto</returns>
        public static Fraccion operator -(Fraccion f1, Fraccion f2)
        {

            if (f1.denominador == f2.denominador)
            {
                Fraccion f3 = new Fraccion(f1.numerador - f2.numerador, f1.denominador);
                return f3;
            }
            else
            {
                Fraccion f3 = new Fraccion(1, 1);

                f3.denominador = MCM(f1.denominador, f2.denominador);
                f3.numerador = ((f3.denominador / f1.denominador) * f1.numerador) - ((f3.denominador / f2.denominador) * f2.numerador);

                return f3;
            }
        }

        /// <summary>
        /// Nos devolverá la multiplicación de dos fracciones.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>Objeto</returns>
        public static Fraccion operator *(Fraccion f1, Fraccion f2)
        {

            Fraccion f3 = new Fraccion(f1.numerador * f2.numerador, f1.denominador * f2.denominador);
            return f3;
        }

        /// <summary>
        /// Nos devolverá la división de dos fracciones.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>Objeto</returns>
        public static Fraccion operator /(Fraccion f1,Fraccion f2)
        {
            Fraccion f3 = new Fraccion(f1.numerador * f2.denominador, f1.denominador * f2.numerador);
            return f3;
        }

        /// <summary>
        /// Nos devolverá un booleano que nos dirá si dos fracciones son iguales o no.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>True o false</returns>
        public static bool operator ==(Fraccion f1,Fraccion f2)
        {
            
            if(f1.ValorDouble  == f2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Nos devolverá un booleano que nos dirá si dos fracciones son iguales o no.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>True o false</returns>
        public static bool operator !=(Fraccion f1, Fraccion f2)
        {
            if (f1.ValorDouble != f2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Nos devolverá un booleano que nos dirá si una de las dos fracciones es menor que la otra.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>True o false</returns>
        public static bool operator <(Fraccion f1,Fraccion f2)
        {
            if (f1.ValorDouble < f2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Nos devolverá un booleano que nos dirá si una de las dos fracciones es mayor que la otra.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>True o false</returns>
        public static bool operator >(Fraccion f1, Fraccion f2)
        {
            if (f1.ValorDouble > f2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Nos devolverá un booleano que nos dirá si una de las dos fracciones es menor o igual que la otra.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>True o false</returns>
        public static bool operator <=(Fraccion f1, Fraccion f2)
        {
            if (f1.ValorDouble <= f2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Nos devolverá un booleano que nos dirá si una de las dos fracciones es mayor o igual que la otra.
        /// </summary>
        /// <param name="f1">Objeto</param>
        /// <param name="f2">Objeto</param>
        /// <returns>True o false</returns>
        public static bool operator >=(Fraccion f1, Fraccion f2)
        {
            if (f1.ValorDouble >= f2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Operador Implicito
        /// <summary>
        /// Nos convertirá un entero en fraccion
        /// </summary>
        /// <param name="entero">Entero</param>
        public static implicit operator Fraccion(int entero)
        {
            Fraccion f3 = new Fraccion(entero, 1);
            return f3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numerador, denominador;
            double numerod;
            List<Fraccion> ListaF = new List<Fraccion>();

            int contadorF;
            Console.Write("¿Cuantás fracciones quieres? : ");
            contadorF = int.Parse(Console.ReadLine());

            #region "NumeroDeFracciones"
            for (int i = 1; i <= contadorF; i++)
            {
                string opcion;
                Console.WriteLine("Sera una fracción completa(1),fracción siendo el valor unico el numerador(2) o un valor decimal(3)");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        {
                            Console.Write("Dime el numerador de la " + i + "ª fracción : ");
                            numerador = int.Parse(Console.ReadLine());

                            Console.Write("Dime el denominador  de la " + i + "ª fracción : ");
                            denominador = int.Parse(Console.ReadLine());

                            ListaF.Add(new Fraccion(numerador, denominador));
                        }                        
                        break;

                    case "2":
                        {
                            Console.Write("Dime el numerador de la " + i + "ª fracción : ");
                            numerador = int.Parse(Console.ReadLine());
                            ListaF.Add(new Fraccion(numerador));
                        }
                        break;

                    case "3":
                        {
                            Console.Write("Dime el valor decimal de la " + i + "ª fracción : ");
                            numerod = double.Parse(Console.ReadLine());
                            ListaF.Add(new Fraccion(numerod));
                        }
                        break;
                }
                Console.WriteLine();
            }
            #endregion

            #region "Menu"

            int opcion2 = 0;

            while (opcion2 != 6)
            {
                Console.WriteLine("1º Sumar las fracciones          2º Restar las fracciones");
                Console.WriteLine("3º Multiplicar las fracciones    4º Dividir las fracciones");
                Console.WriteLine("5º Igualar dos fracciones        6º Salir");
                opcion2 = int.Parse(Console.ReadLine());

                switch (opcion2)
                {
                    case 1:
                        {
                            int contador = ListaF.Count-1;
                            Fraccion f3 = ListaF[contador];
                            contador--;
                            while (contador >-1)
                            {
                                f3 = f3 + ListaF[contador];
                                contador--;
                            }
                            Console.WriteLine("La fracción sin simplificar : " + f3);
                            f3.Simplificar();    
                            Console.WriteLine("La fracción simplificada : " + f3);
                        }
                        break;

                    case 2:
                        {
                            int contador = ListaF.Count - 1;
                            Fraccion f3 = ListaF[contador];
                            contador--;
                            while (contador > -1)
                            {
                                f3 = f3 - ListaF[contador];
                                contador--;
                            }
                            Console.WriteLine("La fracción sin simplificar : " + f3);
                            f3.Simplificar();
                            Console.WriteLine("La fracción simplificada : " + f3);
                        }
                        break;

                    case 3:
                        {
                            int contador = ListaF.Count - 1;
                            Fraccion f3 = ListaF[contador];
                            contador--;
                            while (contador > -1)
                            {
                                f3 = f3 * ListaF[contador];
                                contador--;
                            }
                            Console.WriteLine("La fracción sin simplificar : " + f3);
                            f3.Simplificar();
                            Console.WriteLine("La fracción simplificada : " + f3);
                        }
                        break;

                    case 4:
                        {
                            int contador = ListaF.Count - 1;
                            Fraccion f3 = ListaF[contador];
                            contador--;
                            while (contador > -1)
                            {
                                f3 = f3 / ListaF[contador];
                                contador--;
                            }
                            Console.WriteLine("La fracción sin simplificar : " + f3);
                            f3.Simplificar();
                            Console.WriteLine("La fracción simplificada : " + f3);
                        }
                        break;

                    case 5:
                        {
                            int numero, numero2;
                            Console.Write("Elige tu fracción : ");
                            numero = int.Parse(Console.ReadLine());

                            Console.Write("Elige otra fracción : ");
                            numero2 = int.Parse(Console.ReadLine());

                            Console.WriteLine();

                            if(ListaF[numero-1] > ListaF[numero2 - 1])
                            {
                                Console.WriteLine("Tu primera fracción es mayor que la segunda");
                            }
                            else
                            {
                                Console.WriteLine("Tu segunda fracción es mayor que la primera");
                            }

                            if(ListaF[numero-1] == ListaF[numero2 - 1])
                            {
                                Console.WriteLine("Tus dos fracciones son iguales");
                            }
                            else
                            {
                                Console.WriteLine("Tus dos fracciones son distintas");
                            }

                            if(ListaF[numero-1] < ListaF[numero2 - 1])
                            {
                                Console.WriteLine("Tu primera fracción es menor que la segunda");
                            }
                            else
                            {
                                Console.WriteLine("Tu segunda fracción es menor que la primera");
                            }
                                                              
                        }
                        break;

                    case 6:
                        {
                            opcion2 = 6;
                        }
                        break;

                    default:
                        break;
                }

                Console.WriteLine();
                
            }

            #endregion
            Console.Clear();
            Console.ReadKey();
        }
    }
}

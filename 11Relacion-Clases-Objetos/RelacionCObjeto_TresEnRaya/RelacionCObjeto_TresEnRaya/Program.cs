using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionCObjeto_TresEnRaya
{
    class TresEnRaya
    {
        //Atributos
        private int[] tablero;

        //Constructor
        /// <summary>
        /// Inicializará un array poniendolo todo a 0
        /// </summary>
        public TresEnRaya()
        {
            tablero = new int[9];
        }

        //Metodos
        /// <summary>
        /// Le pasamos por parámetro una posición 
        /// que representa la casilla del tablero en la cuál
        /// pondremos una X.
        /// </summary>
        /// <param name="pos">Entero</param>
        public void MueveJugador1(int pos)
        {
            if (MovimientoValido(pos))
            {
                tablero[pos - 1] = 1;
            }
            else
            {
                throw new Exception("Posición Ocupada");
            }
        }

        /// <summary>
        /// Le pasamos por parámetro una posición
        /// que representa la casilla del tablero en la cuál
        /// pondremos un O.
        /// </summary>
        /// <param name="pos"></param>
        public void MueveJugador2(int pos)
        {

            if (MovimientoValido(pos))
            {
                tablero[pos - 1] = 2;
            }
            else
            {
                throw new Exception("Posición Ocupada");
            }
        }

        /// <summary>
        /// Le pasamos por parámetro una posción del
        /// tablero y devolverá un booleano que nos dirá 
        /// si la casilla está ocupada o no.
        /// </summary>
        /// <param name="pos">Entero</param>
        /// <returns>True o false</returns>
        public bool MovimientoValido(int pos)
        {
            bool devuelve = false;
            if(pos < 0 || pos > 9)
            {
                throw new Exception("Movimiento No Válido");
            }
            else
            {
                if (tablero[pos - 1] == 0)
                {
                    devuelve = true;
                }
            }

            return devuelve;
        }

        /// <summary>
        /// El ordenador pondrá una X aleatoriamente en una 
        /// posición del tablero
        /// </summary>
        public void MueveOrdenador1()
        {
            Random r = new Random();

            int posA = r.Next(1, 9);

            if (QuedanMovimientos() == false)
            {
                throw new Exception("Error");
            }
            else
            {
                while (MovimientoValido(posA) != true)
                {
                    posA = r.Next(1, 10);
                }
                if (MovimientoValido(posA))
                {
                    tablero[posA - 1] = 1;
                }
            }

        }

        /// <summary>
        /// El ordenador pondrá un O aletoriamente en una posición del
        /// tablero
        /// </summary>
        public void MueveOrdenador2()
        {
            Random r = new Random();

            int posA = r.Next(1, 9);

            if (QuedanMovimientos() == false)
            {
                throw new Exception("Error");
            }
            else
            {
                while(MovimientoValido(posA) != true)
                {
                    posA = r.Next(1, 10);
                }
                if(MovimientoValido(posA))
                {
                    tablero[posA - 1] = 2;
                }               
            }
        }

        /// <summary>
        /// Limpiará el tablero para volver a jugar.
        /// </summary>
        public void Iniciar()
        {
            //for (int i = 0; i < tablero.Length; i++)
            //{
            //    if(tablero[i] == 1 || tablero[i] == 2)
            //    {
            //        tablero[i] = 0;
            //    }
            //}

            for (int i = 0; i < tablero.Length; i++)
            {
                //tablero.SetValue(0, i);
                tablero[i] = 0;
            }

            
        }

        /// <summary>
        /// Nos devolverá un booleano que dirá si quedan casillas libres o no.
        /// </summary>
        /// <returns>True o false</returns>
        public bool QuedanMovimientos()
        {
            //return (array.Where(p => p == 0).Count() > 0);
            bool devuelve = false;

            if (tablero.Contains(0))
            {
                devuelve = true;
            }

            return devuelve;
        }

        /// <summary>
        /// Nos devolverá un booleano, si hay tres X en linea será true.
        /// </summary>
        /// <returns>True o false</returns>
        public bool GanaJugador1()
        {
            bool devuelve = false;

            for (int i = 0; i <= 6; i = i+3)
            {
                if (tablero[i] == 1 && tablero[i + 1] == 1 && tablero[i + 2] == 1)
                {
                    devuelve = true;
                }
            }

            for (int i = 0; i <= 2; i++)
            {
                if(tablero[i] == 1 && tablero[i+3] == 1 && tablero[i+6] == 1)
                {
                    devuelve = true;
                }
            }


            if (tablero[0] == 1 && tablero[4] == 1 && tablero[8] == 1)
            {
                devuelve = true;
            }


            if (tablero[2] == 1 && tablero[4] == 1 && tablero[6] == 1)
            {
                devuelve = true;
            }


            return devuelve;
        }

        /// <summary>
        /// Nos devolverá un booleano, si hay tres O en linea será true.
        /// </summary>
        /// <returns>True o false</returns>
        public bool GanaJugador2()
        {
            bool devuelve = false;

            for (int i = 0; i <= 6; i = i + 3)
            {
                if (tablero[i] == 2 && tablero[i + 1] == 2 && tablero[i + 2] == 2)
                {
                    devuelve = true;
                }
            }

            for (int i = 0; i <= 2; i++)
            {
                if (tablero[i] == 2 && tablero[i + 3] == 2 && tablero[i + 6] == 2)
                {
                    devuelve = true;
                }
            }


            if (tablero[0] == 2 && tablero[4] == 2 && tablero[8] == 2)
            {
                devuelve = true;
            }


            if (tablero[2] == 2 && tablero[4] == 2 && tablero[6] == 2)
            {
                devuelve = true;
            }


            return devuelve;
        }

        /// <summary>
        /// Nos mostrará por pantalla el tablero.
        /// </summary>
        public void DibujaTablero()
        {
            for (int i = 0; i < tablero.Length; i++)
            {
                if(tablero[i] == 0)
                {
                    Console.Write(" . ".PadRight(5));
                }
                else
                {
                    if(tablero[i] == 1)
                    {
                        Console.Write(" X ".PadRight(5));
                    }
                    else
                    {
                        if(tablero[i] == 2)
                        {
                            Console.Write(" O ".PadRight(5));
                        }
                    }
                }
                if (i % 3 == 2)
                {
                    Console.WriteLine();
                }
            }
        }         
    }

    class Program
    {      
        static void Main(string[] args)
        {
            TresEnRaya TableroM = new TresEnRaya();
            int opcion = -1;
            int opcion2;

            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Tres En Raya : ");
                Console.WriteLine("Si desea salir del juego pulse 0");
                Console.WriteLine("Si desea empezar una nueva partida(1vs1) pulse 1");
                Console.WriteLine("Si desea empezar una nueva partida(1vsIA) pulse 2");
                Console.WriteLine("Si desea empezar una nueva partida(IA 1 vs IA 2) pulse 3");
                while (int.TryParse(Console.ReadLine(), out opcion2) == false)
                {
                    Console.WriteLine("Porfavor pulse 0,1,2,3");
                }

                switch (opcion2)
                {
                    case 0:
                        Console.WriteLine("Gracias,hasta pronto");
                        opcion = 0;
                        break;
                    case 1:
                        {
                            Console.Clear();
                            int movJ1;
                            int movJ2;
                            int turno = 1;
                            while (TableroM.QuedanMovimientos() && !TableroM.GanaJugador1() && !TableroM.GanaJugador2())
                            {
                                if (turno == 1)
                                {
                                    Console.WriteLine("J1. Escriba una posición");
                                    movJ1 = int.Parse(Console.ReadLine());
                                    TableroM.MueveJugador1(movJ1);
                                    TableroM.DibujaTablero();
                                    turno = 2;
                                }
                                else
                                {
                                    Console.WriteLine("J2. Escriba una posición");
                                    movJ2 = int.Parse(Console.ReadLine());
                                    TableroM.MueveJugador2(movJ2);
                                    TableroM.DibujaTablero();
                                    turno = 1;
                                }
                            }

                            if (TableroM.GanaJugador1())
                            {
                                Console.WriteLine("Gana el jugador 1");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (TableroM.GanaJugador1() == false && TableroM.GanaJugador2() == false)
                                {
                                    Console.WriteLine("El juego acabo en tablas");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Gana el jugador 2");
                                    Console.ReadKey();
                                }
                            }      
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            int movJ1;
                            int turno = 1;
                            while (TableroM.QuedanMovimientos() && !TableroM.GanaJugador1() && !TableroM.GanaJugador2())
                            {
                                if (turno == 1)
                                {
                                    Console.WriteLine("J1. Escriba una posición");
                                    movJ1 = int.Parse(Console.ReadLine());
                                    TableroM.MueveJugador1(movJ1);
                                    TableroM.DibujaTablero();
                                    turno = 2;
                                }
                                else
                                {
                                    Console.WriteLine("La consola hizo su movimiento");
                                    TableroM.MueveOrdenador2();
                                    TableroM.DibujaTablero();
                                    turno = 1;
                                }
                            }

                            if (TableroM.GanaJugador1())
                            {
                                Console.WriteLine("Gana el jugador 1");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (TableroM.GanaJugador1() == false && TableroM.GanaJugador2() == false)
                                {
                                    Console.WriteLine("El juego acabo en tablas");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Gana la consola");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            int turno = 1;
                            while (TableroM.QuedanMovimientos() && !TableroM.GanaJugador1() && !TableroM.GanaJugador2())
                            {
                                if (turno == 1)
                                {
                                    Console.WriteLine("La consola nº1 hizo su movimiento");
                                    TableroM.MueveOrdenador1();
                                    TableroM.DibujaTablero();
                                    turno = 2;
                                }
                                else
                                {
                                    Console.WriteLine("La consola nº2 hizo su movimiento");
                                    TableroM.MueveOrdenador2();
                                    TableroM.DibujaTablero();
                                    turno = 1;
                                }
                            }

                            if (TableroM.GanaJugador1())
                            {
                                Console.WriteLine("Gana la consola nº1");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (TableroM.GanaJugador1() == false && TableroM.GanaJugador2() == false)
                                {
                                    Console.WriteLine("El juego acabo en tablas");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Gana la consola nº2");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                }
                
                TableroM.Iniciar();
            }

            Console.ReadKey();
        }
    }
}

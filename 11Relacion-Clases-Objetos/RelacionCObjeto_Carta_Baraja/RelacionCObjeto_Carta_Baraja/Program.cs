using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionCObjeto_Carta_Baraja
{
    class Carta
    {
        //Atributos
        private int numero;
        private int palo;

        //Constructores
        /// <summary>
        /// Crea una carta pasandole un número y palo
        /// </summary>
        /// <param name="numero">Entero</param>
        /// <param name="palo">Entero</param>
        public Carta(int numero, int palo)
        {
            if (palo >= 0 && palo <= 3 && numero >= 1 && numero <= 10)
            {
                this.numero = numero;
                this.palo = palo;
            }
            else
            {
                throw new Exception("Número o palo de la carta incorrecto");
            }

        }

        /// <summary>
        /// Crearemos una carta pasandole un numero entre el 1 y 40,siendo el 1 as de oros y 40 rey de bastos.
        /// </summary>
        /// <param name="id">Entero</param>
        public Carta(int id)
        {
            if (id >= 1 && id <= 10)
            {
                this.numero = id;
                palo = 0;
            }
            else
            {
                if (id >= 11 && id <= 20)
                {
                    this.numero = id - 10;
                    palo = 1;
                }
                else
                {
                    if (id >= 21 && id <= 30)
                    {
                        this.numero = id - 20;
                        palo = 2;
                    }
                    else
                    {
                        if (id >= 31 && id <= 40)
                        {
                            this.numero = id - 30;
                            palo = 3;
                        }
                        else
                        {
                            throw new Exception("El id es incorrecto");
                        }
                    }
                }
            }
        }

        //Propiedades
        /// <summary>
        /// Nos devuelve el número.De solo lectura.
        /// </summary>
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Nos devuelve el palo.De solo lectura.
        /// </summary>
        public int Palo
        {
            get
            {
                return this.palo;
            }
        }

        /// <summary>
        /// Nos devuelve el numero de la carta como un string y con letras. De solo lectura.
        /// </summary>
        public string NombreNumero
        {
            get
            {
                string cartaNombreN = "";

                switch (numero)
                {
                    case 1:
                        cartaNombreN = "as";
                        break;
                    case 2:
                        cartaNombreN = "dos";
                        break;
                    case 3:
                        cartaNombreN = "tres";
                        break;
                    case 4:
                        cartaNombreN = "cuatro";
                        break;
                    case 5:
                        cartaNombreN = "cinco";
                        break;
                    case 6:
                        cartaNombreN = "seis";
                        break;
                    case 7:
                        cartaNombreN = "siete";
                        break;
                    case 8:
                        cartaNombreN = "sota";
                        break;
                    case 9:
                        cartaNombreN = "caballo";
                        break;
                    case 10:
                        cartaNombreN = "rey";
                        break;
                }

                return cartaNombreN;
            }
        }

        /// <summary>
        /// Nos devuelve el palo de la carta, en letras.De solo lectura.
        /// </summary>
        public string NombrePalo
        {
            get
            {
                string cartaNombreP = "";

                switch (palo)
                {
                    case 0:
                        cartaNombreP = "oros";
                        break;
                    case 1:
                        cartaNombreP = "copas";
                        break;
                    case 2:
                        cartaNombreP = "espadas";
                        break;
                    case 3:
                        cartaNombreP = "bastos";
                        break;
                }

                return cartaNombreP;
            }
        }

        /// <summary>
        /// Nos devuelve el nombre completo de la carta. De solo lectura.
        /// </summary>
        public string NombreCarta
        {
            get
            {
                string nombrecompleto = NombreNumero + " de " + NombrePalo;
                return nombrecompleto;
            }
        }

        /// <summary>
        /// Nos devuelve el valor de la carta en el juego del tute. De solo lectura.
        /// </summary>
        public int ValorTute
        {
            get
            {
                switch (numero)
                {
                    case 1:
                        return 11;
                    case 3:
                        return 10;
                    case 8:
                        return 2;
                    case 9:
                        return 3;
                    case 10:
                        return 4;
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Nos devuelve el valor de la carta en el juego del mus. De solo lectura.
        /// </summary>
        public int ValorMus
        {
            get
            {
                switch (numero)
                {
                    case 1:
                    case 2:
                        return 1;
                    case 8:
                    case 9:
                    case 10:
                        return 10;
                    default:
                        return numero;
                }
            }
        }

        /// <summary>
        /// Nos devuelve el valor de la carta en el juego de la 7 y media. De solo lectura.
        /// </summary>
        public double Valor7yMedia
        {
            get
            {
                switch (numero)
                {
                    case 8:
                    case 9:
                    case 10:
                        return 0.5;
                    default:
                        return numero;
                }
            }
        }
    }

    class Baraja
    {
        //Atributos
        private List<Carta> listaCartas;

        //Constructores
        /// <summary>
        /// Creamos una baraja vacía.
        /// </summary>
        public Baraja()
        {
            listaCartas = new List<Carta>();
        }

        /// <summary>
        /// Creamos una baraja,pasandole un entero, del tipo 1 (40 cartas) o tipo 2(80 cartas).
        /// </summary>
        /// <param name="tipoBaraja">Entero</param>
        public Baraja(int tipoBaraja)
        {
            listaCartas = new List<Carta>();
            switch (tipoBaraja)
            {
                case 1:
                    {
                        for (int i = 1; i <= 40; i++)
                        {
                            Carta c = new Carta(i);
                            listaCartas.Add(c);
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 1; i <= 40; i++)
                        {
                            Carta c = new Carta(i);
                            listaCartas.Add(c);
                        }
                        for (int i = 1; i <= 40; i++)
                        {
                            Carta c = new Carta(i);
                            listaCartas.Add(c);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Creamos una baraja,pasandole un entero, del tipo 1(40 cartas) o tipo 2(80 cartas)y un booleano para 
        /// barajarla o no.
        /// </summary>
        /// <param name="tipoBaraja"></param>
        /// <param name="barajar"></param>
        public Baraja(int tipoBaraja, bool barajar)
        {
            listaCartas = new List<Carta>();
            switch (tipoBaraja)
            {
                case 1:
                    {
                        for (int i = 1; i <= 40; i++)
                        {
                            Carta c = new Carta(i);
                            listaCartas.Add(c);
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 1; i <= 40; i++)
                        {
                            Carta c = new Carta(i);
                            listaCartas.Add(c);
                        }
                        for (int i = 1; i <= 40; i++)
                        {
                            Carta c = new Carta(i);
                            listaCartas.Add(c);
                        }
                    }
                    break;
                default:
                    break;
            }

            if (barajar)
            {
                Barajar();
            }
        }

        //Métodos
        /// <summary>
        /// Mezclaremos aleatoriamente las cartas de la baraja.
        /// </summary>
        public void Barajar()
        {
            List<Carta> listaTemporal = new List<Carta>();
            Random r = new Random();
            int numero;
            while (listaCartas.Count > 0)
            {
                numero = r.Next(listaCartas.Count);
                listaTemporal.Add(listaCartas[numero]);
                listaCartas.RemoveAt(numero);
            }

            listaCartas.AddRange(listaTemporal);
        }

        /// <summary>
        /// Cortaremos la baraja a partir de la posición que le digamos por parámetro.
        /// </summary>
        /// <param name="pos">Entero</param>
        public void Cortar(int pos)
        {
            List<Carta> listaTemporal = new List<Carta>();

            if (pos > listaCartas.Count)
            {
                throw new Exception("La posición insertada es erronea");
            }
            else
            {
                for (int i = 0; i < pos; i++)
                {
                    listaTemporal.Add(listaCartas[0]);
                    listaCartas.RemoveAt(0);
                }
            }

            listaCartas.AddRange(listaTemporal);
        }

        /// <summary>
        /// Robaremos una carta de la baraja.
        /// </summary>
        /// <returns>Devolveremos un objeto que será el primer elemento de la lista</returns>
        public Carta Robar()
        {
            Carta cRobada = new Carta(listaCartas[0].Numero, listaCartas[0].Palo);
            listaCartas.RemoveAt(0);

            return cRobada;
        }

        /// <summary>
        /// Insertaremos una carta,pasandole un entero, al final de la baraja.
        /// </summary>
        /// <param name="id_carta">Entero</param>
        public void InsertaCartaFinal(int id_carta)
        {
            Carta insertarCarta = new Carta(id_carta);
            listaCartas.Add(insertarCarta);
        }

        /// <summary>
        /// Insertaremos una carta,pasandole un entero,al principio de la baraja.
        /// </summary>
        /// <param name="id_carta">Entero</param>
        public void InsertaCartaAlPrincipio(int id_carta)
        {
            Carta InsertaCartaAlPrincipio = new Carta(id_carta);
            listaCartas.Insert(0, InsertaCartaAlPrincipio);
        }

        /// <summary>
        /// Insertaremos una carta,pasandole un objeto,al final de la baraja.
        /// </summary>
        /// <param name="carta">Objeto de tipo Carta</param>
        public void InsertaCartaFinal(Carta carta)
        {
            listaCartas.Add(carta);
        }

        /// <summary>
        /// Insertaremos una carta, pasandole un objeto, al principio de la baraja.
        /// </summary>
        /// <param name="carta"></param>
        public void InsertaCartaAlPrincipio(Carta carta)
        {
            listaCartas.Insert(0, carta);
        }

        //Propiedades
        /// <summary>
        /// Nos dice cuantas cartas quedan en la baraja,de solo lectura.
        /// </summary>
        public int NumeroCartas
        {
            get
            {
                return listaCartas.Count;
            }
        }

        /// <summary>
        /// Nos dice si la baraja esta vacía o no,de solo lectura.
        /// </summary>
        public bool Vacia
        {
            get
            {
                bool devuelve = false;
                if (listaCartas.Count > 0)
                {
                    devuelve = true;
                }
                return devuelve;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            string respuesta;
            double puntuacion = 0;
            Carta jugador;
            Baraja BJugador;
            int tipoB;           
            Console.WriteLine("Tipo de baraja 1(40 cartas) o tipo de baraja 2(80 cartas)");
            tipoB = int.Parse(Console.ReadLine());
            BJugador = new Baraja(tipoB, true);

            jugador = BJugador.Robar();
            puntuacion = jugador.Valor7yMedia + puntuacion;

            Console.WriteLine(jugador.Numero + jugador.Palo + " Puntuación " + jugador.Valor7yMedia);

            Console.WriteLine("¿Quieres otra carta ? (s/n)");
            respuesta = Console.ReadLine();

            while (respuesta == "s")
            {
                jugador = BJugador.Robar();
                puntuacion = jugador.Valor7yMedia + puntuacion;

                Console.WriteLine(jugador.Numero + jugador.Palo + " Puntuación " + jugador.Valor7yMedia);
                Console.WriteLine("Puntuación Total : " + puntuacion);
                Console.WriteLine("¿Quieres otra carta ? (s/n)");
                respuesta = Console.ReadLine();
            }

            if (puntuacion > 7.5)
            {
                Console.WriteLine(puntuacion + " Has perdido");
            }
            else if (puntuacion == 7.5)
            {
                Console.WriteLine(puntuacion + " Has ganado");
            }
            else
            {
                Console.WriteLine(puntuacion + " Menor que 7.5, aun puedes ganar ");
            }


            Console.ReadKey();
        }
    }
}

    


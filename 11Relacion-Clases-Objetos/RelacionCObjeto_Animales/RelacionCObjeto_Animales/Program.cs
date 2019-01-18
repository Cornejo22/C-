using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionCObjeto_Animales
{
    /// <summary>
    /// Enumerados de la clase perro
    /// </summary>
    enum RazaPerro
    {
        PastorAleman, Husky, FoxTerrier, Dalmata, SanBernando
    }

    /// <summary>
    /// Enumerados de la clase gato
    /// </summary>
    enum RazaGato
    {
        Comun,Siames,Persa,Angora,ScottishFold
    }

    /// <summary>
    /// Enumerados de la clase pájaro
    /// </summary>
    enum EspeciePajaro
    {
        Canario,Periquito,Agapornis
    }

    /// <summary>
    /// Enumerados de la clase Reptil
    /// </summary>
    enum EspecieReptil
    {
        Tortuga,Iguana,DragonDeComodo
    }

    abstract class Animal
    {
        //Atributos
        protected string nombre;
        protected DateTime fechaNacimiento;
        protected double peso;
        protected string comentarios;

        //Propiedades
        /// <summary>
        /// Devuelve el nombre del perro. De solo léctura.
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        /// <summary>
        /// Devuelve la fecha de nacimiento del perro. De solo léctura.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
        }

        /// <summary>
        /// Devuelve el peso del perro verificando que no sea nulo.
        /// </summary>
        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                if(value > 0)
                {
                    peso = value;
                }
                else
                {
                    throw new Exception("Peso nulo");
                }
            }
        }

        /// <summary>
        /// Devuelve el comentario del perro verificando que no este vacío.
        /// </summary>
        public string Comentarios
        {
            get
            {
                return comentarios;
            }
            set
            {
                if(value == " ")
                {
                    throw new Exception("Los comentarios están vacios");
                }
                else
                {
                    comentarios = value;
                }
            }
        }

        //Metodo Abstracto
        /// <summary>
        /// Nos escribirá por pantalla la ficha de cada tipo de animal.
        /// </summary>
        /// <returns>string</returns>
        public override abstract string ToString();
    }

    class Perro : Animal
    {
        //Atributos Adicionales        
        private RazaPerro raza;
        private string microchip;

        //Propiedades
        /// <summary>
        /// Nos devuelve la raza del perro. De solo léctura.
        /// </summary>
        public RazaPerro Raza
        {
            get
            {
                return raza;
            }
        }

        /// <summary>
        /// Nos devuelve un microchip. De solo léctura.
        /// </summary>
        public string Microchip
        {
            get
            {
                return microchip;
            }
        }

        //Constructores
        /// <summary>
        /// Nos asigna el nombre,fecha de nacimiento,peso,raza,microchip y comentarios a una variable de clase perro.
        /// </summary>
        /// <param name="nombre">string</param>
        /// <param name="fechaNacimiento">Datetime</param>
        /// <param name="peso">double</param>
        /// <param name="raza">enum</param>
        /// <param name="microchip">string</param>
        /// <param name="comentarios">string</param>
        public Perro(string nombre,DateTime fechaNacimiento,double peso, RazaPerro raza,string microchip,string comentarios)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.raza = raza;
            this.microchip = microchip;
            this.comentarios = comentarios;
        }

        //Métodos
        /// <summary>
        /// Nos devuelve una cadena que contendrá la ficha del perro y nos la mostrará por pantalla.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string cadena;

            cadena = "Ficha del Perro\nNombre: " + nombre + "\nRaza: " + raza + "\nFecha de Nacimiento: " + fechaNacimiento +
                "\nPeso: " + peso + " kg\nMicrochip: " + microchip + "\nComentarios: " + comentarios + "\n";

            return cadena;
        }
    }

    class Gato : Animal
    {
        //Atributos Adicionales
        private RazaGato raza;
        private string microchip;

        //Propiedades
        /// <summary>
        /// Nos devuelve la raza del gato. De solo léctura.
        /// </summary>
        public RazaGato Raza
        {
            get
            {
                return raza;
            }
        }

        /// <summary>
        /// Nos devuelve una cadena. De solo léctura.
        /// </summary>
        public string Microchip
        {
            get
            {
                return microchip;
            }
        }

        //Constructores
        /// <summary>
        /// Nos asigna el nombre, fecha de nacimiento,peso,raza y microchip a una clase de tipo gato.
        /// </summary>
        /// <param name="nombre">string</param>
        /// <param name="fechaNacimiento">DateTime</param>
        /// <param name="peso">double</param>
        /// <param name="raza">enum</param>
        /// <param name="microchip">string</param>
        public Gato(string nombre, DateTime fechaNacimiento, double peso, RazaGato raza, string microchip,string comentarios)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.raza = raza;
            this.microchip = microchip;
            this.comentarios = comentarios;
        }

        //Métodos
        /// <summary>
        /// Nos devuelve una cadena que contrendrá la ficha del gato y nos la mostrará por pantalla.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string cadena;

            cadena = "Ficha del Gato\nNombre: " + nombre + "\nRaza: " + raza + "\nFecha de Nacimiento: " + fechaNacimiento +
                "\nPeso: " + peso + " kg\nMicrochip: " + microchip + "\nComentarios: " + comentarios + "\n";

            return cadena;
        }
    }

    class Pajaro : Animal
    {
        private EspeciePajaro especie;
        private bool cantor;

        //Propiedades
        /// <summary>
        /// Nos devuelve la especie del pájaro.De solo léctura.
        /// </summary>
        public EspeciePajaro Especie
        {
            get
            {
                return especie;
            }
        }

        /// <summary>
        /// Nos devuelve un booleano que nos dice si el pájaro canta o no. De solo léctura.
        /// </summary>
        public bool Cantor
        {
            get
            {
                return cantor;
            }
        }

        //Constructores
        /// <summary>
        /// Nos asigna nombre,fecha de nacimiento,peso,especie y cantor a una clase de tipo pájaro.
        /// </summary>
        /// <param name="nombre">string</param>
        /// <param name="fechaNacimiento">DateTime</param>
        /// <param name="peso">double</param>
        /// <param name="especie">enum</param>
        /// <param name="cantor">bool</param>
        public Pajaro(string nombre, DateTime fechaNacimiento, double peso, EspeciePajaro especie, bool cantor,string comentarios)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.especie = especie;
            this.cantor = cantor;
            this.comentarios = comentarios;
        }

        //Métodos
        /// <summary>
        /// Nos devuelve una cadena que contendrá la ficha del pájaro y nos la mostrará por pantalla.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cadena;
            string cadena2;

            if (cantor == true)
            {
                cadena2 = "Es cantor";

            }
            else
            {
                cadena2 = "No es cantor";
            }

            cadena = "Ficha del Pajaro\nNombre: " + nombre + "\nEspecie: " + especie + "\nFecha de Nacimiento: " + fechaNacimiento +
                "\nPeso: " + peso + " kg\nCantor: " + cadena2 + "\nComentarios: " + comentarios + "\n";

            return cadena;
        }
    }

    class Reptil : Animal
    {
        private EspecieReptil especie;
        private bool venenoso;

        //Propiedades
        /// <summary>
        /// Nos devuelve la especie del reptil.De solo léctura.
        /// </summary>
        public EspecieReptil Especie
        {
            get
            {
                return especie;
            }
        }

        /// <summary>
        /// Nos devuelve un booleano que nos dice si el reptil es venenoso o no.De solo léctura.
        /// </summary>
        public bool Venenoso
        {
            get
            {
                return venenoso;
            }
        }

        //Constructores
        /// <summary>
        /// Nos asigna nombre,fecha de nacimiento,peso,especie y si es venenoso a una clase de tipo reptil.
        /// </summary>
        /// <param name="nombre">string</param>
        /// <param name="fechaNacimiento">DateTime</param>
        /// <param name="peso">double</param>
        /// <param name="especie">enum</param>
        /// <param name="venenoso">bool</param>
        public Reptil(string nombre, DateTime fechaNacimiento, double peso, EspecieReptil especie, bool venenoso,string comentarios)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.especie = especie;
            this.venenoso = venenoso;
            this.comentarios = comentarios;
        }

        //Métodos
        /// <summary>
        /// Nos devuelve una cadena que contendrá la ficha del reptil y nos la mostrará por pantalla.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cadena;
            string cadena2;

            if (venenoso == true)
            {
                cadena2 = "Es venenoso";

            }
            else
            {
                cadena2 = "No es cantor";
            }

            cadena = "Ficha del Reptil\nNombre: " + nombre + "\nEspecie: " + especie + "\nFecha de Nacimiento: " + fechaNacimiento +
                "\nPeso: " + peso + " kg\nVenenoso: " + cadena2 + "\nComentarios: " + comentarios + "\n";

            return cadena;
        }
    }

    class ClinicaVeterinaria
    {
        //Atributos
        private List<Animal> listaAnimales;
        
        //Constructores
        /// <summary>
        /// Nos inicializa una lista vacia de animales.
        /// </summary>
        public ClinicaVeterinaria()
        {
            listaAnimales = new List<Animal>();
        }

        //Métodos
        /// <summary>
        /// Nos inserta un animal en la lista de animales.
        /// </summary>
        /// <param name="animal">clase de tipo animal</param>
        public void InsertaAnimal(Animal animal)
        {
            listaAnimales.Add(animal);
        }

        /// <summary>
        /// Nos busca un animal en la lista de animales
        /// </summary>
        /// <param name="animal">clase de tipo animal</param>
        /// <returns>clase de tipo animal</returns>
        public Animal BuscaAnimal(string nombre)
        {
            Animal devuelto = listaAnimales[0];

            for (int i = 0; i < listaAnimales.Count;  i++)
            {
                if(listaAnimales[i].Nombre == nombre)
                {
                    devuelto = listaAnimales[i];
                }
            }

            return devuelto;
        }

        /// <summary>
        /// Nos modifica el comentario del animal que le pasemos por parámetro
        /// </summary>
        /// <param name="animal">clase de tipo animal</param>
        /// <param name="comentario">string</param>
        public void ModificaComentarioAnimal(string nombre, string comentario)
        {
            for (int i = 0; i < listaAnimales.Count; i++)
            {
                if (listaAnimales[i].Nombre == nombre)
                {
                    listaAnimales[i].Comentarios = comentario;
                }
            }
        }

        /// <summary>
        /// Nos devuelve una cadena donde nos mostrará la lista de animales de la clase clinica veterinaria.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < listaAnimales.Count; i++)
            {
               cadena = cadena + listaAnimales[i].ToString() + "\n";
            }
            return cadena;
        }          
    }

    class Program
    {
        /// <summary>
        /// Centra la cadena en la pantalla
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <returns>Cadena centrada</returns>
        static string Centra80(string cadena)
        {

            string cadena1 = cadena;
            cadena1 = cadena1.PadLeft(Console.WindowWidth / 2 + cadena.Length / 2);
            return cadena1;

        }

        static void Main(string[] args)
        {
            ClinicaVeterinaria cl = new ClinicaVeterinaria();
            string nombre;
            string fechaNa;
            DateTime dt;
            double peso;
            string comentario;
            int opcion = -1;
            while(opcion!= 5)
            {
                Console.WriteLine("Clinica Veterinaria Cornejo");                
                Console.WriteLine("1º Insertar un animal. 2º Buscar un animal. 3º Modificar un comentario. 4º Monstrar todos los animales 5º Salir.");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            #region "menu para insertar animales nuevos"
                            int opcion2 = -1;
                            Console.WriteLine("¿Que animal se va a insertar? ".PadLeft(67));
                            Console.WriteLine("1º Perro 2º Gato 3º Pájaro 4º Reptil".PadLeft(70));
                            while (int.TryParse(Console.ReadLine(),out opcion2) == false)
                            {
                                Console.WriteLine("No es un número. Inserte un número");
                            }
                            while (opcion2 != 1 && opcion2 != 2 && opcion2 != 3 && opcion2 != 4)
                            {
                                Console.WriteLine("La opción insertada no es válida. Inserta una opción válida.");
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            #endregion

                            #region "los 4 casos de animales"
                            switch (opcion2)
                            {
                                case 1:
                                    {
                                        RazaPerro razaP;
                                        string microchip;

                                        Console.Write("Inserte el nombre del perro : ");
                                        nombre = Console.ReadLine();
                                        Console.Write("Inserta la fecha de nacimiento del perro(ejemplo : año/mes/dia o dia/mes/año) : ");
                                        fechaNa = Console.ReadLine();
                                        dt = Convert.ToDateTime(fechaNa);
                                        Console.Write("Inserta el peso del perro : ");
                                        peso = double.Parse(Console.ReadLine());
                                        Console.WriteLine("La raza del perro es : 1 PastorAleman, 2 Husky, 3 FoxTerrier, 4 Dalmata, 5 SanBernando");
                                        razaP = (RazaPerro)(int.Parse(Console.ReadLine()) - 1);
                                        Console.Write("Inserte el microchip del perro : ");
                                        microchip = Console.ReadLine();
                                        Console.Write("Inserta algún comentario sobre el perro : ");
                                        comentario = Console.ReadLine();
                                        Perro p1 = new Perro(nombre, dt, peso, razaP, microchip, comentario);
                                        cl.InsertaAnimal(p1);
                                    }
                                    break;
                                case 2:
                                    {
                                        RazaGato razaG;
                                        string microchip;

                                        Console.Write("Inserte el nombre del gato : ");
                                        nombre = Console.ReadLine();
                                        Console.Write("Inserta la fecha de nacimiento del gato(ejemplo : año/mes/dia o dia/mes/año) : ");
                                        fechaNa = Console.ReadLine();
                                        dt = Convert.ToDateTime(fechaNa);
                                        Console.Write("Inserta el peso del gato : ");
                                        peso = double.Parse(Console.ReadLine());
                                        Console.WriteLine("La raza del perro es : 1 Comun, 2 Siames, 3 Persa, 4 Angora, 5 ScottishFold");
                                        razaG = (RazaGato)(int.Parse(Console.ReadLine()) - 1);
                                        Console.Write("Inserte el microchip del gato : ");
                                        microchip = Console.ReadLine();
                                        Console.Write("Inserta algún comentario sobre el gato : ");
                                        comentario = Console.ReadLine();
                                        Gato g1 = new Gato(nombre, dt, peso, razaG, microchip,comentario);
                                        cl.InsertaAnimal(g1);
                                    }
                                    break;
                                case 3:
                                    {
                                        EspeciePajaro especieP;
                                        char s;
                                        bool cantor;

                                        Console.Write("Inserte el nombre del pájaro : ");
                                        nombre = Console.ReadLine();
                                        Console.Write("Inserta la fecha de nacimiento del pájaro(ejemplo : año/mes/dia o dia/mes/año) : ");
                                        fechaNa = Console.ReadLine();
                                        dt = Convert.ToDateTime(fechaNa);
                                        Console.Write("Inserta el peso del pájaro : ");
                                        peso = double.Parse(Console.ReadLine());
                                        Console.WriteLine("La raza del pájaro es : 1 Canario, 2 Periquito, 3 Agapornis");
                                        especieP = (EspeciePajaro)(int.Parse(Console.ReadLine()) - 1);
                                        Console.Write("El pájaro canta(s) o no canta(n) : ");
                                        s = char.Parse(Console.ReadLine());
                                        if(s == 's')
                                        {
                                            cantor = true;
                                        }
                                        else
                                        {
                                            cantor = false;
                                        }
                                        Console.Write("Inserta algún comentario sobre el pájaro : ");
                                        comentario = Console.ReadLine();
                                        Pajaro pa1 = new Pajaro(nombre,dt,peso,especieP,cantor,comentario);
                                        cl.InsertaAnimal(pa1);
                                    }
                                    break;

                                case 4:
                                    {
                                        EspecieReptil especieR;
                                        char s;
                                        bool venenoso;

                                        Console.Write("Inserte el nombre del reptil : ");
                                        nombre = Console.ReadLine();
                                        Console.Write("Inserta la fecha de nacimiento del reptil(ejemplo : año/mes/dia o dia/mes/año) : ");
                                        fechaNa = Console.ReadLine();
                                        dt = Convert.ToDateTime(fechaNa);
                                        Console.Write("Inserta el peso del reptil : ");
                                        peso = double.Parse(Console.ReadLine());
                                        Console.WriteLine("La raza del reptil es : 1 Tortuga, 2 Iguana, 3 DragonDeComodo");
                                        especieR = (EspecieReptil)(int.Parse(Console.ReadLine()) - 1);
                                        Console.Write("El reptil es venenoso(s) o no(n) : ");
                                        s = char.Parse(Console.ReadLine());
                                        if (s == 's')
                                        {
                                            venenoso = true;
                                        }
                                        else
                                        {
                                            venenoso = false;
                                        }
                                        Console.Write("Inserta algún comentario sobre el reptil : ");
                                        comentario = Console.ReadLine();
                                        Reptil r1 = new Reptil(nombre, dt, peso, especieR, venenoso,comentario);
                                        cl.InsertaAnimal(r1);
                                    }
                                    break;
                            }

                            #endregion
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Dime el nombre del animal : ");
                            nombre = Console.ReadLine();

                            Console.WriteLine(cl.BuscaAnimal(nombre));
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Dime el nombre del animal : ");
                            nombre = Console.ReadLine();

                            Console.Write("Dime el nuevo comentario del animal : ");
                            comentario = Console.ReadLine();

                            cl.ModificaComentarioAnimal(nombre, comentario);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine(cl);
                        }
                        break;
                    case 5:
                        {
                            opcion = 5;
                        }
                        break;
                    default:
                        break;                     
                }
                Console.ReadKey();
                Console.Clear();
            }            
        }      
    }
}

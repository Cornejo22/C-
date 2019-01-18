using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace RelacionCObjeto_Moneda_Dinero
{
    enum TipoMoneda
    {
         Euro,Dolar,Libra,Yen
    }

    class Moneda
    {
        //Atributos
        private TipoMoneda tmoneda;
        private int decimales;
        private string simbolo;
        private decimal cambioEuro;
        private string codigo;

        //Constructores
        /// <summary>
        /// Nos servirá para guardar la información sobre cada moneda.
        /// </summary>
        /// <param name="tmoneda">tipo de moneda</param>
        /// <param name="decimales">entero</param>
        /// <param name="simbolo">string</param>
        /// <param name="cambioEuro">decimal</param>
        /// <param name="codigo">string</param>
        public Moneda(TipoMoneda tmoneda,int decimales,string simbolo,decimal cambioEuro,string codigo)
        {
            if(decimales < 0 && decimales > 4 || simbolo == "" || cambioEuro < 0)
            {
                throw new Exception("Datos incorrectos");
            }
            else
            {
                this.tmoneda = tmoneda;
                this.decimales = decimales;
                this.simbolo = simbolo;
                this.cambioEuro = cambioEuro;
                this.codigo = codigo;
            }
        }

        //Propiedades
        /// <summary>
        /// Propiedad de solo lectura.
        /// </summary>
        public TipoMoneda TMoneda
        {
            get
            {
                return this.tmoneda;
            }            
        }

        /// <summary>
        /// Propiedad de solo lectura.
        /// </summary>
        public int Decimales
        {
            get
            {
                return this.decimales;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura.
        /// </summary>
        public string Simbolo
        {
            get
            {
                return this.simbolo;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura.
        /// </summary>
        public decimal CambioEuro
        {
            get
            {
                return cambioEuro;
            }
            set
            {
                if(value > 0)
                {
                    cambioEuro = value;
                }
                else
                {
                    throw new Exception("Cambio Negativo");
                }
            }
        }

        /// <summary>
        /// Propiedad de solo lectura.
        /// </summary>
        public string Codigo
        {
            get
            {
                return codigo;
            }
        }

    
}

    class Dinero
    {
        #region parteEstatica
        //Atributo Estatico 
        private static List<Moneda> listaMoneda;

        //Constructor Estatico
        /// <summary>
        /// Nos rellenará una lista de datos con cada tipo de moneda.
        /// </summary>
        static Dinero()
        {
            listaMoneda = new List<Moneda>();
            Moneda euro = new Moneda(TipoMoneda.Euro, 2, "euros", 1,"EUR");
            Moneda dolares = new Moneda(TipoMoneda.Dolar, 2, "$", 1.137635m,"USD");
            Moneda yenes = new Moneda(TipoMoneda.Yen, 0, "¥", 123.723219m,"JPY");
            Moneda libras = new Moneda(TipoMoneda.Libra, 2, "£", 0.807810153m,"GBP");
            listaMoneda.Add(euro);
            listaMoneda.Add(dolares);
            listaMoneda.Add(yenes);
            listaMoneda.Add(libras);
        }

        //Metodos Estatico
        /// <summary>
        /// Nos actualizará los valores de cada moneda.
        /// </summary>
        /// <param name="moneda">Tipo de moneda. Enumerado.</param>
        /// <param name="cambioEuros">Decimal</param>
        static public void ActualizaCambio(TipoMoneda moneda,decimal cambioEuros)
        {
            for (int i = 0; i < listaMoneda.Count; i++)
            {
                if(listaMoneda[i].TMoneda == moneda)
                {
                    listaMoneda[i].CambioEuro = cambioEuros;
                }
            }
        }
       
        /// <summary>
        /// Nos buscará un tipo de moneda.
        /// </summary>
        /// <param name="tipo">Tipo de moneda. Enumerado.</param>
        /// <returns>Nos devolverá el tipo de moneda.</returns>
        static private Moneda BuscaMoneda(TipoMoneda tipo)
        {
            Moneda m = null;

            for (int i = 0; i < listaMoneda.Count; i++)
            {
                if(tipo == listaMoneda[i].TMoneda)
                {
                    m = listaMoneda[i];
                }
            }

            return m;
        }
        
        #endregion

        //Atributos
        private decimal cantidad;
        TipoMoneda moneda;

        //Constructores
        /// <summary>
        /// Nos inicializará un tipo de moneda y una cantidad decimal.
        /// </summary>
        /// <param name="cantidad">decimal</param>
        /// <param name="moneda">Tipo de moneda. Enumerado</param>
        public Dinero(decimal cantidad,TipoMoneda moneda)
        {
            this.cantidad = cantidad;
            this.moneda = moneda;
        }

        /// <summary>
        /// Nos inicializará un tipo de moneda y una cantidad entera.
        /// </summary>
        /// <param name="cantidad">entero</param>
        /// <param name="moneda">Tipo de moneda. Enumerado</param>
        public Dinero(int cantidad, TipoMoneda moneda)
        {
            this.cantidad = Convert.ToDecimal(cantidad);
            this.moneda = moneda;
        }

        /// <summary>
        /// Nos inicializará un tipo de moneda y una cantidad double.
        /// </summary>
        /// <param name="cantidad">Double</param>
        /// <param name="moneda">Tipo de moneda. Enumerado</param>
        public Dinero(double cantidad, TipoMoneda moneda)
        {
            this.cantidad = Convert.ToDecimal(cantidad);
            this.moneda = moneda;
        }

        //Propiedades
        /// <summary>
        /// La cantidad de lectura y escritura para guardar los datos.
        /// </summary>
        public decimal Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }

        /// <summary>
        /// El tipo de enumerado será de lectura y escritura para guardar el dato.
        /// </summary>
        public TipoMoneda Moneda
        {
            get
            {
                return moneda;
            }
            set
            {
                moneda = value;
            }
        }

        //Métodos
        /// <summary>
        /// Nos mostrará los resultados por pantalla.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {            
            int cdecimales;
            decimal redondeo;
            Moneda m;
            m = BuscaMoneda(this.moneda);

            cdecimales = m.Decimales;

            redondeo = Math.Round(this.cantidad, cdecimales);

            return redondeo.ToString() + " " + m.Simbolo;
        }

        /// <summary>
        /// Convertirá una cantidad de moneda en otro tipo de cantidad.
        /// </summary>
        /// <param name="tmoneda">Tipo de moneda. Enumerado</param>
        /// <returns>Devolverá un decimal.</returns>
        public decimal ValorEn(TipoMoneda tmoneda)
        {
            decimal monedaR;

            Moneda m1 = BuscaMoneda(this.moneda);
            decimal c1 = m1.CambioEuro;

            decimal valorEuros = this.cantidad / c1;

            Moneda m2 = BuscaMoneda(tmoneda);
            decimal c2 = m2.CambioEuro;

            monedaR = c2 * valorEuros;

            return monedaR;
        }

        /// <summary>
        /// Nos devolverá un objeto de tipo Dinero correspondiente 
        /// al valor del dinero.
        /// </summary>
        /// <param name="tmoneda">Tipo de moneda. Enumerado</param>
        /// <returns>Un objeto de tipo Dinero</returns>
        public Dinero ConvierteEn(TipoMoneda tmoneda)
        {
            Dinero devuelto;

            decimal nuevoV = this.ValorEn(tmoneda);
            devuelto = new Dinero(nuevoV, tmoneda);

            return devuelto;
        }

        //Mas Propiedades
        /// <summary>
        /// Nos devolverá una cantidad como Double.
        /// </summary>
        public double ADouble
        {
            get
            {
                return Convert.ToDouble(cantidad);
            }
        }

        /// <summary>
        /// Nos devolverá una cantidad como Entero.
        /// </summary>
        public int AEntero
        {
            get
            {
                return Convert.ToInt32(cantidad);
            }
        }

        //Operadores
        /// <summary>
        /// Nos sumará los dos parámetros de dinero
        /// </summary>
        /// <param name="d1">Objeto tipo dinero</param>
        /// <param name="d2">Objeto tipo dinero</param>
        /// <returns>Objeto tipo dinero con el resultado</returns>
        public static Dinero operator +(Dinero d1,Dinero d2)
        {
            
            if(d1.moneda == d2.moneda)
            {
                 Dinero d3 = new Dinero(d1.cantidad + d2.cantidad,d1.moneda);
                 return d3;
            }
            else
            {
                Dinero d4 = d2.ConvierteEn(d1.moneda);
                Dinero d3 = new Dinero(d1.cantidad + d4.cantidad, d1.moneda);
                return d3;
            }
        }

        /// <summary>
        /// Nos restará los dos parámetros de dinero
        /// </summary>
        /// <param name="d1">Objeto tipo dinero</param>
        /// <param name="d2">Objeto tipo dinero</param>
        /// <returns>Objeto tipo dinero con el resultado</returns>
        public static Dinero operator -(Dinero d1, Dinero d2)
        {
            if (d1.moneda == d2.moneda)
            {
                Dinero d3 = new Dinero(d1.cantidad - d2.cantidad, d1.moneda);
                return d3;
            }
            else
            {
                Dinero d4 = d2.ConvierteEn(d1.moneda);
                Dinero d3 = new Dinero(d1.cantidad - d4.cantidad, d1.moneda);
                return d3;
            }
        }

        /// <summary>
        /// Nos dividirá los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto tipo dinero</param>
        /// <param name="valor">Decimal</param>
        /// <returns>Objeto tipo dinero</returns>
        public static Dinero operator /(Dinero d1, decimal valor)
        {
            Dinero d2 = new Dinero(d1.cantidad / valor, d1.moneda);

            return d2;
        }

        /// <summary>
        /// Nos multiplicará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto tipo dinero</param>
        /// <param name="valor">Decimal</param>
        /// <returns>Objeto tipo dinero</returns>
        public static Dinero operator *(Dinero d1, decimal valor)
        {
            Dinero d2 = new Dinero(d1.cantidad * valor, d1.moneda);
            return d2;
        }

        /// <summary>
        /// Igualará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto de tipo dinero</param>
        /// <param name="d2">Obejto de tipo dinero</param>
        /// <returns>Booleano</returns>
        public static bool operator ==(Dinero d1, Dinero d2)
        {
            bool iguales = false;

            Dinero d3 = d2.ConvierteEn(d1.moneda);

            if(d1.cantidad == d3.cantidad)
            {
                iguales = true;
            }

            return iguales;
        }

        /// <summary>
        /// Igualará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto de tipo dinero</param>
        /// <param name="d2">Obejto de tipo dinero</param>
        /// <returns>Booleano</returns>
        public static bool operator !=(Dinero d1, Dinero d2)
        {
            bool iguales = false;

            Dinero d3 = d2.ConvierteEn(d1.moneda);

            if (d1.cantidad != d3.cantidad)
            {
                iguales = true;
            }

            return iguales;
        }

        /// <summary>
        /// Igualará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto de tipo dinero</param>
        /// <param name="d2">Obejto de tipo dinero</param>
        /// <returns>Booleano</returns>
        public static bool operator >(Dinero d1, Dinero d2)
        {
            bool esMayor = false;

            Dinero d3 = d2.ConvierteEn(d1.moneda);

            if (d1.cantidad > d3.cantidad)
            {
                esMayor = true;
            }

            return esMayor;
        }

        /// <summary>
        /// Igualará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto de tipo dinero</param>
        /// <param name="d2">Obejto de tipo dinero</param>
        /// <returns>Booleano</returns>
        public static bool operator <(Dinero d1, Dinero d2)
        {
            bool esMenor = false;

            Dinero d3 = d2.ConvierteEn(d1.moneda);

            if (d1.cantidad < d3.cantidad)
            {
                esMenor = true;
            }

            return esMenor;
        }

        /// <summary>
        /// Igualará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto de tipo dinero</param>
        /// <param name="d2">Obejto de tipo dinero</param>
        /// <returns>Booleano</returns>
        public static bool operator >=(Dinero d1, Dinero d2)
        {
            bool esMayor = false;

            Dinero d3 = d2.ConvierteEn(d1.moneda);

            if (d1.cantidad >= d3.cantidad)
            {
                esMayor = true;
            }

            return esMayor;
        }

        /// <summary>
        /// Igualará los dos parámetros.
        /// </summary>
        /// <param name="d1">Objeto de tipo dinero</param>
        /// <param name="d2">Obejto de tipo dinero</param>
        /// <returns>Booleano</returns>
        public static bool operator <=(Dinero d1, Dinero d2)
        {
            bool esMenor = false;

            Dinero d3 = d2.ConvierteEn(d1.moneda);

            if (d1.cantidad <= d3.cantidad)
            {
                esMenor = true;
            }

            return esMenor;
        }

        /// <summary>
        /// Nos actualizará los valores mediante una página de internet.
        /// </summary>
        public static void ActualizarListaInternet()
        {
            Console.WriteLine("Espere mientras se actualiza las conversiones via internet ...");
            for (int i = 0; i < listaMoneda.Count; i++)
            {
                Console.WriteLine(listaMoneda[i].Simbolo + " actualizando ...");

                WebClient wc = new WebClient();

                string pagina = wc.DownloadString(@"http://www.x-rates.com/calculator/?from=EUR&to=" + listaMoneda[i].Codigo);//

                int pos1 = pagina.IndexOf("ccOutputRslt");
                int pos2 = pagina.IndexOf(">", pos1) + 1;
                int pos3 = pagina.IndexOf("<", pos2) - 1;

                string cambio = pagina.Substring(pos2, pos3 - pos2 + 1);

                pos1 = pagina.IndexOf("ccOutputTrail");
                pos2 = pagina.IndexOf(">", pos1) + 1;
                pos3 = pagina.IndexOf("<", pos2) - 1;

                cambio = cambio + pagina.Substring(pos2, pos3 - pos2 + 1);

                listaMoneda[i].CambioEuro = Convert.ToDecimal(cambio);
                Console.WriteLine(listaMoneda[i].Simbolo + " actualizado");
                //Console.WriteLine("");
            }
            Console.WriteLine("Actualización completada");
        }

        public static Dinero CrearDinero (double cantidad,string tipo)
        {
            Dinero d1 = new Dinero(0, 0);
            if (tipo == "euros")
            {
                d1 = new Dinero(cantidad, TipoMoneda.Euro);
            }
            if (tipo == "dolares")
            {
                d1 = new Dinero(cantidad, TipoMoneda.Dolar);
            }
            if (tipo == "libras")
            {
                d1 = new Dinero(cantidad, TipoMoneda.Libra);
            }
            if (tipo == "yenes")
            {
                d1 = new Dinero(cantidad, TipoMoneda.Yen);
            }
            return d1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // CREAR MENU
            Dinero d1 = new Dinero(0,0);
            double cantidad;
            int opcion = -1;
            while (opcion!= 0)
            {
                string opcion2 = "";
                Console.WriteLine("¿Quieres actualizar? Si o No");
                opcion2 = Console.ReadLine();
                if(opcion2 == "si")
                {
                    Dinero.ActualizarListaInternet();
                }
                Console.Clear();
                string tim;
                Console.Write("Tipo de moneda : euros , dolares , libras o yenes : ");
                tim = Console.ReadLine();
                tim = tim.ToLower();
                Console.Write("Cantidad de dinero : ");
                cantidad = double.Parse(Console.ReadLine());

                d1 = Dinero.CrearDinero(cantidad, tim);

                Console.WriteLine("1º Sumar   2º Restar ");
                Console.WriteLine("3º Dividir 4º Multiplicar");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    
                    case 1:
                        {
                            double cantidad2;
                            Console.WriteLine("Cantidad para sumar a la otra cantidad : ");
                            cantidad2 = double.Parse(Console.ReadLine());

                            Dinero d2 = new Dinero(0, 0);
                            d2 = Dinero.CrearDinero(cantidad2,tim);
                            Console.WriteLine("Resultado de {0} + {1} : {2}",d1,d2,(d1+d2));
                        }
                        break;
                    case 2:
                        {
                            double cantidad2;
                            Console.WriteLine("Cantidad para restar a la otra cantidad : ");
                            cantidad2 = double.Parse(Console.ReadLine());

                            Dinero d2 = new Dinero(0, 0);
                            d2 = Dinero.CrearDinero(cantidad2, tim);
                            Console.WriteLine("Resultado de {0} + {1} : {2}", d1, d2, (d1 - d2));
                        }
                        break;

                    case 3:
                        {
                            decimal cantidad2;
                            Console.WriteLine("Cantidad para dividir a la otra cantidad : ");
                            cantidad2 = decimal.Parse(Console.ReadLine());
                          
                            Console.WriteLine("Resultado de {0} / {1} : {2}", d1, cantidad2, (d1 / cantidad2));
                        }
                        break;

                    case 4:
                        {
                            decimal cantidad2;
                            Console.WriteLine("Cantidad para dividir a la otra cantidad : ");
                            cantidad2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Resultado de {0} * {1} : {2}", d1, cantidad2, (d1 * cantidad2));
                        }
                        break;

                    default:
                        break;
                }

                Console.WriteLine("¿Seguir? Si(-1) o No(0)");
                opcion = int.Parse(Console.ReadLine());
            }
            

            Console.ReadKey();
            
        }
    }
}

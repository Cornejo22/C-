using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Relacion_Structs_Banco
{
    class Program
    {
        struct cuenta_corriente
        {
            public string numero_cc;
            public string cliente;
            public decimal saldo;
        }

        /// <summary>
        ///  Nos permite crear una nueva cuenta. 
        ///  Nos preguntará el número de la cuenta, 
        ///  el nombre del propietario y el saldo inicial e 
        ///  insertará una nueva cuenta corriente en la lista.
        /// </summary>
        /// <param name="banco">Struct</param>
        static void NuevaCuentaBanco(List<cuenta_corriente> banco)
        {
            cuenta_corriente cuenta;

            Console.WriteLine("Dime el numero de cuenta");
            cuenta.numero_cc = Console.ReadLine();

            while (BuscaNumeroCuenta(banco, cuenta.numero_cc) == true)
            {
                Console.WriteLine("Número de cuenta existente");
                Console.WriteLine("Ingrese un nuevo número de cuenta");
                cuenta.numero_cc = Console.ReadLine();
            }

            Console.WriteLine("Dime el propietario de la cuenta");
            cuenta.cliente = Console.ReadLine();
            Console.WriteLine("Dime el saldo de la cuenta");
            cuenta.saldo = decimal.Parse(Console.ReadLine());
            banco.Add(cuenta);

        }

        /// <summary>
        /// Nos pedirá el número de la cuenta. Eliminará la cuenta que queramos de la lista. 
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="numero_cc">Numero de cuenta del banco(string)</param>
        static void EliminarCuentaBanco(List<cuenta_corriente> banco, string numero_cc)
        { 
            int i;

            for (i = 0; i < banco.Count; i++)
            {
                if(numero_cc == banco[i].numero_cc)
                {
                    banco.RemoveAt(i);
                }
            }
        }

        /// <summary>
        ///  Nos permitirá modificar el saldo de una lista. 
        ///  Nos pedirá el número de lista y 
        ///  el dinero que deseamos añadir o retirar de la cuenta.
        ///  Si ponemos un número positivo, 
        ///  se añadirá el dinero al saldo y 
        ///  si ponemos un número negativo, 
        ///  se le restará saldo a la cuenta.
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="numero_cc">Numero de cuenta del banco(string)</param>
        /// <param name="saldo">Saldo a añadir o restar de la cuenta(decimal)</param>
        static void ActualizarSaldoBanco(List<cuenta_corriente> banco, string numero_cc,decimal saldo)
        {
            int i;
            for ( i = 0; i < banco.Count; i++)
            {
                cuenta_corriente cuenta;
                cuenta = banco[i];
                
                if (numero_cc == banco[i].numero_cc)
                {
                    if(saldo >= 0)
                    {
                        cuenta.saldo = cuenta.saldo + saldo;
                    }
                    else
                    {
                        cuenta.saldo = cuenta.saldo + saldo;
                    }

                    banco[i] = cuenta;
                }              
            }
        }

        /// <summary>
        /// Te muestra por pantalla un listado de todas las cuentas, incluyendo todos los datos. 
        /// </summary>
        /// <param name="banco">Struct</param>
        static void ImprimirCuentasBanco(List<cuenta_corriente> banco)
        {
            int i;
            int contador = 1;
            for (i = 0; i < banco.Count; i++)
            {
                Console.WriteLine("Cuenta de banco " + contador);
                Console.WriteLine("NBC : " + banco[i].numero_cc);
                Console.WriteLine("Nombre del propientario : " + banco[i].cliente);
                Console.WriteLine("Saldo de la cuenta : " + banco[i].saldo);
                Console.WriteLine();
                contador++;
            }
        }

        /// <summary>
        /// Guardará las cuentas corrientes en el fichero. 
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="fichero">Fichero tipo binario(variable string) </param>
        static void GuardarFicheroBanco(List<cuenta_corriente> banco,string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            int i;

            bw.Write(banco.Count);

            for (i = 0; i < banco.Count; i++)
            {
                bw.Write(banco[i].numero_cc);
                bw.Write(banco[i].cliente);
                bw.Write(banco[i].saldo);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        ///  Leerá las cuentas desde el fichero. 
        ///  Borraremos lo que tengamos en nuestra lista antes de leer.
        ///  El fichero del banco tendrá un nombre fijo: “banco.cc”. 
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="fichero">Fichero tipo binario(variable string)</param>
        static void LeerFicheroBanco(List<cuenta_corriente> banco, string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            banco.Clear();
            br.ReadInt32();

            while (fs.Position < fs.Length)
            {
                cuenta_corriente cuenta;

                cuenta.numero_cc = br.ReadString();
                cuenta.cliente = br.ReadString();
                cuenta.saldo = br.ReadDecimal();

                banco.Add(cuenta);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        ///  hace lo mismo que la función GuardarFicheroBanco 
        ///  que hicimos anteriormente pero con ficheros de texto.
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="fichero">Fichero tipo TXT(variable string)</param>
        static void GuardarFicheroBancoTXT(List<cuenta_corriente> banco,string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);
            int i;
            sw.Write(banco.Count);

            for (i = 0; i < banco.Count; i++)
            {
                sw.WriteLine(banco[i].numero_cc);
                sw.WriteLine(banco[i].cliente);
                sw.WriteLine(banco[i].saldo);

            }
            sw.Close();
        }

        /// <summary>
        /// Hace lo mismo que la función LeerFicheroBanco pero con ficheros de texto. 
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="fichero">Fichero tipo TXT(variable string)</param>
        static void LeerFicheroBancoTXT(List<cuenta_corriente> banco, string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            banco.Clear();

            while (!sr.EndOfStream)
            {
                cuenta_corriente cuenta;

                cuenta.numero_cc = sr.ReadLine();
                cuenta.cliente = sr.ReadLine();
                cuenta.saldo = decimal.Parse(sr.ReadLine());

                banco.Add(cuenta);
            }

            sr.Close();
        }

        /// <summary>
        /// Guarda los datos del banco en un fichero CSV
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="fichero">Fichero tipo CSV(variable string)</param>
        static void GuardarFicheroBancoCSV(List<cuenta_corriente> banco,string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero);

            int i;
            for (i = 0; i < banco.Count; i++)
            {
                sw.Write(banco[i].numero_cc + ";");
                sw.Write(banco[i].cliente + ";");
                sw.WriteLine(banco[i].saldo);
            }

            sw.Close();
        }

        /// <summary>
        /// Lee los datos del banco del fichero CSV
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="fichero">Fichero tipo CSV(variable string)</param>
        static void LeerFicheroBancoCSV(List<cuenta_corriente> banco, string fichero)
        {
            StreamReader sr = new StreamReader(fichero);
            string linea;
            string[] cad;

            while (!sr.EndOfStream)
            {
                cuenta_corriente cuenta;
                linea = sr.ReadLine();
                cad = linea.Split(';');
                cuenta.numero_cc = cad[0];
                cuenta.cliente = cad[1];
                cuenta.saldo = decimal.Parse(cad[2]);

                banco.Add(cuenta);
            }

            sr.Close();
        }

        /// <summary>
        /// Función que nos devuelve true
        /// si el numero de cuenta existe 
        /// en nuestro struct o false en caso contrario.
        /// </summary>
        /// <param name="banco">Struct</param>
        /// <param name="numeroCuenta">Variable de tipo string</param>
        /// <returns>Booleano</returns>
        static bool BuscaNumeroCuenta(List<cuenta_corriente> banco,string numeroCuenta)
        {
            bool existe = false;
            int i;

            for (i = 0; i < banco.Count; i++)
            {
                if(numeroCuenta == banco[i].numero_cc)
                {
                    existe = true;
                }
            }

            return existe;
        }

        static void Main(string[] args)
        {
            List<cuenta_corriente> banco = new List<cuenta_corriente>();

            string opcion = "-1";

            while (opcion != "0")
            {
                Console.Clear();
                Console.WriteLine("                         MENÚ");
                Console.WriteLine("=======================================================");
                Console.WriteLine("1º-NuevaCuentaBanco          2º-EliminarCuentaBanco");
                Console.WriteLine("3º-ActualizarSaldoBanco      4º-ImprimirCuentasBanco");
                Console.WriteLine("5º-GuardarFicheroBanco       6º-LeeFicheroBanco");
                Console.WriteLine("7º-GuardarFicheroBancoTXT    8º-LeeFicheroBancoTXT");
                Console.WriteLine("9º-GuardarFicheroBancoCSV   10º-LeerFicheroBancoCSV");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        {
                            NuevaCuentaBanco(banco);
                            
                        }
                        break;

                    case "2":
                        {
                            string numero_cc;
                            Console.WriteLine("Dime el numero de la cuenta a eliminar : ");
                            numero_cc = Console.ReadLine();
                            EliminarCuentaBanco(banco, numero_cc);
                        }
                        break;

                    case "3":
                        {
                            string numero_cc;
                            Console.WriteLine("Dime el numero de la cuenta : ");
                            numero_cc = Console.ReadLine();
                            while (BuscaNumeroCuenta(banco, numero_cc) == false)
                            {
                                Console.WriteLine("El numero de cuenta no existe,ingreselo de nuevo");
                                numero_cc = Console.ReadLine();
                            }
                            decimal saldo;
                            Console.WriteLine("Dime el saldo : ");
                            saldo = decimal.Parse(Console.ReadLine());

                            ActualizarSaldoBanco(banco, numero_cc, saldo);
                        }
                        break;

                    case "4":
                        {
                            ImprimirCuentasBanco(banco);
                        }
                        break;

                    case "5":
                        {
                            GuardarFicheroBanco(banco, "banco.cc");
                        }
                        break;


                    case "6":
                        {
                            LeerFicheroBanco(banco, "banco.cc");
                        }
                        break;

                    case "7":
                        {
                            GuardarFicheroBancoTXT(banco, "banco.txt");
                        }
                        break;

                    case "8":
                        {
                            LeerFicheroBancoTXT(banco, "banco.txt");
                        }
                        break;

                    case "9":
                        {
                            GuardarFicheroBancoCSV(banco, "banco.csv");
                        }
                        break;

                    case "10":
                        {
                            LeerFicheroBancoCSV(banco, "banco.csv");
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

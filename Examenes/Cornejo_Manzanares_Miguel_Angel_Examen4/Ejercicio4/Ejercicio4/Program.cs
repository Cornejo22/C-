using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio4
{
    class Program
    {
        struct InfoPartido
        {
            public string nombreEquipoL;
            public string nombreEquipoV;
            public int golesEquipoL;
            public int golesEquipoV;
        }

        static void ImprimeJornada(string fichero)
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            InfoPartido partido;
            string linea = "";

            while(fs.Position < fs.Length)
            {
                partido.nombreEquipoL = br.ReadString();
                partido.nombreEquipoV = br.ReadString();
                partido.golesEquipoL = br.ReadInt32();
                partido.golesEquipoV = br.ReadInt32();

                linea = partido.nombreEquipoL.PadRight(14) + " " + partido.golesEquipoL + " - " + partido.golesEquipoV + " " + partido.nombreEquipoV.PadLeft(14);
                Console.WriteLine(linea);
            }

            br.Close();
            fs.Close();
        }

        static void Main(string[] args)
        {
            ImprimeJornada("jornada3");
            Console.ReadKey();
        }
    }
}

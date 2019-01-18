using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRelacionFunciones3
{
    class Program
    {
        static bool Bisiesto(int anno)
        {
            bool devuelve;

            devuelve = false;

            if (anno % 4 == 0 && anno % 100 != 0 || anno % 400 == 0)
            {
                devuelve = true;
            }

            return devuelve;
        }

        static int DiasMes(int mes)
        {
            int dias = 0;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 2:
                    dias = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
            }

            return dias;
        }

        static int DiasMes2(int mes, int anno)
        {
            int dias = 0;

            if (Bisiesto(anno) == true)
            {
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        dias = 31;
                        break;
                    case 2:
                        dias = 29;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        dias = 30;
                        break;
                }
            }
            else
            {
                dias = DiasMes(mes);
            }

            return dias;
        }

        static int DiasTranscurridos(int dia, int mes, int anno)
        {
            int diastranscurridos = 0;
            int i;

            for (i = 1; i < mes; i++)
            {
                diastranscurridos = diastranscurridos + DiasMes2(i, anno);
            }

            diastranscurridos = diastranscurridos + dia;
            return diastranscurridos;
        }

        static int DiasTranscurridos1980(int dia, int mes, int anno)
        {
            int diastranscurridos = 0;
            int annostotales = 0;
            int i;

            for (i = 1980; i < anno; i++)
            {
                diastranscurridos = DiasTranscurridos(31, 12, i);
                annostotales = annostotales + diastranscurridos;
            }
            annostotales = annostotales + DiasTranscurridos(dia, mes, anno);

            return annostotales;
        }

        static int DiasEntreFechas(int dia, int mes, int anno, int dia2, int mes2, int anno2)
        {
            int diastranscurridos;
            int annostotales = 0;
            int i;

            for (i = anno; i < anno2; i++)
            {
                diastranscurridos = DiasTranscurridos(31, 12, i);
                annostotales = annostotales + diastranscurridos;
            }
            annostotales = annostotales + DiasTranscurridos(dia2, mes2, anno2);

            return annostotales;
        }

        static int DiaSemanaFecha(int dia, int mes, int anno)
        {
            int diastransc;
            int diasemana;

            diastransc = (DiasTranscurridos1980(dia, mes, anno));
            diasemana = diastransc % 7;
            diasemana = diasemana + 1;

            return diasemana;
        }

        static string DiaEnTexto(int ndia)
        {
            string dia = "";

            switch (ndia)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                
            }

            return dia;
        }

        static int HoraASegundos(int hora, int minutos, int segundos)
        {
            int segundostotales;

            segundostotales = (hora * 3600) + (minutos * 60) + segundos;

            return segundostotales;
        }

        static void EscribeHoraBonito(int hora, int minutos, int segundos)
        {
            if(hora > 24 || minutos > 60)
            {
                Console.WriteLine("Hora no válida");
            }
            else
            {
                if (hora >= 0 && hora <= 9)
                {
                    Console.Write("0{0}", hora);
                }
                else
                {
                    Console.Write("{0}", hora);
                }

                if (minutos >= 0 && minutos <= 9)
                {
                    Console.Write(":0{0}", minutos);
                }
                else
                {
                    Console.Write(":{0}", minutos);
                }

                if (segundos >= 0 && segundos <= 9)
                {
                    Console.Write(":0{0}", segundos);
                }
                else
                {
                    Console.Write(":{0}", segundos);
                }
            }
        
        }

        static void EscribeSegundosBonito(int segundos)
        {
            int hora = 0;
            int segundos2 = 0;
            int minutos = 0;
            int minutos2 = 0;

            if (segundos > 59)
            {
                segundos2 = segundos % 60;
                minutos = segundos / 60;
                
            }
            if (minutos > 59)
            {
                minutos2 = minutos % 60;
                hora = minutos / 60;
               
            }

            EscribeHoraBonito(hora, minutos2, segundos2);

        } 

        static int SegundosTranscurridos(int hora, int minutos, int segundos, int hora2, int minutos2, int segundos2)
        {
            int diferencia;
            int segundostotales1;
            int segundostotales2;

            segundostotales1 = HoraASegundos(hora, minutos, segundos);
            segundostotales2 = HoraASegundos(hora2, minutos2, segundos2);

            if(segundostotales1 > segundostotales2)
            {
                diferencia = segundostotales1 - segundostotales2;
            }
            else
            {
                diferencia = segundostotales2 - segundostotales1;
            }


            return diferencia;           
        }

        static int SegundosTranscurridos1980(int dias, int mes, int anno, int hora, int minutos, int segundos)
        {
            int segundostranscurridos1980;
            int segundostranscurridos;
            int resultado;

            segundostranscurridos1980 = DiasTranscurridos1980(dias, mes, anno)*86400;
            segundostranscurridos = HoraASegundos(hora, minutos, segundos);

            resultado = segundostranscurridos1980 + segundostranscurridos;

            return resultado;
        }

        static void Main(string[] args)
        {
            int dias, mes, anno;
            Console.WriteLine("Dime un dia : ");
            dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un mes : ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un año : ");
            anno = int.Parse(Console.ReadLine());

            //int dias2, mes2, anno2;
            //Console.WriteLine("Dime un mes : ");
            //mes2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dime un año : ");
            //anno2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dime un dia : ");
            //dias2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(DiasMes2(mes,anno));
            //Console.WriteLine(DiasTranscurridos1980(dias,mes,anno));
            //Console.WriteLine(DiasEntreFechas(dias,mes,anno,dias2,mes2,anno2));

            //int texto = DiaSemanaFecha(dias, mes, anno);

            //Console.WriteLine(DiaEnTexto(texto));

            //int hora;
            //int minutos;
            //int segundos;
            //Console.WriteLine("Dime hora : ");
            //hora = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dime minutos : ");
            //minutos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dime segundos : ");
            //segundos = int.Parse(Console.ReadLine());
            int hora2;
            int minutos2;
            int segundos2;
            Console.WriteLine("Dime hora : ");
            hora2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime minutos : ");
            minutos2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime segundos : ");
            segundos2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(HoraASegundos(hora,minutos,segundos));
            //EscribeHoraBonito(hora2, minutos2, segundos2);

            //EscribeSegundosBonito(segundos2);

            //Console.WriteLine(SegundosTranscurridos(hora,minutos,segundos,hora2,minutos2,segundos2)); 
            //Console.WriteLine(SegundosTranscurridos1980(dias,mes,anno,hora2,minutos2,segundos2)); 

            Console.ReadKey();
        }
    }
}

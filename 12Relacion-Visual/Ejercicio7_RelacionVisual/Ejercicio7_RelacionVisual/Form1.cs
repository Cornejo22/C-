using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio7_RelacionVisual
{
    public partial class Form1 : Form
    {
        DateTime fecha = System.DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBDia.Text = fecha.Day.ToString();
            TBMes.Text = fecha.Month.ToString();
            TBAnno.Text = fecha.Year.ToString();

            string[] fichero = Directory.GetFiles(".", "*txt");

            for (int i = 0; i < fichero.Length; i++)
            {
                string nombre = Path.GetFileNameWithoutExtension(fichero[i]);

                if (nombre == TBDia.Text + TBMes.Text + TBAnno.Text)
                {
                    StreamReader sr = new StreamReader(fichero[i]);
                    string linea = sr.ReadToEnd();
                    TBDiario.Text = linea;
                }
            }
        }

        private void TBDiario_TextChanged(object sender, EventArgs e)
        {
            string[] fichero = Directory.GetFiles(".","*txt");

            for (int i = 0; i < fichero.Length; i++)
            {
                string nombre = Path.GetFileNameWithoutExtension(fichero[i]);

                if(nombre == TBDia.Text+TBMes.Text+TBAnno.Text)
                {
                    StreamReader sr = new StreamReader(fichero[i]);
                    string linea = sr.ReadToEnd();
                    TBDiario.Text = linea;
                }
            }
        }

        private void BTSig_Click(object sender, EventArgs e)
        {
            fecha = fecha.AddDays(+1);
            TBDia.Text = fecha.Day.ToString();
            TBMes.Text = fecha.Month.ToString();
            TBAnno.Text = fecha.Year.ToString();

            if (File.Exists(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt"))
            {
                StreamReader sr = new StreamReader(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt");
                TBDiario.Text = sr.ReadLine();

                sr.Close();
            }
            else
            {
                TBDiario.Clear();
            }


        }

        private void BTAtras_Click(object sender, EventArgs e)
        {
            fecha = fecha.AddDays(-1);
            TBDia.Text = fecha.Day.ToString();
            TBMes.Text = fecha.Month.ToString();
            TBAnno.Text = fecha.Year.ToString();

            if (File.Exists(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt"))
            {
                StreamReader sr = new StreamReader(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt");
                TBDiario.Text = sr.ReadLine();

                sr.Close();
            }
            else
            {
                TBDiario.Clear();
            }
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(fecha.Day.ToString().PadLeft(2, '0') + fecha.Month.ToString().PadLeft(2, '0') + fecha.Year.ToString() + ".txt");
            sw.Write(TBDiario.Text);
            MessageBox.Show("Guardado","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
            sw.Close();
        }
    }
}

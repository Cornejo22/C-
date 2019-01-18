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

namespace Ejercicio2_EntornoVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TextoMulti.Clear();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("bloc.txt");

            sw.Write(TextoMulti.Text);

            sw.Close();
        }

        private void BotonAbrir_Click(object sender, EventArgs e)
        {                    
            StreamReader sr = new StreamReader("bloc.txt");           
            TextoMulti.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void BTInstrucciones_Click(object sender, EventArgs e)
        {
            int contador = 1;

            while (contador != -1)
            {
                switch (contador)
                {
                    case 1:
                        {
                            LBInstrucciones.Text = "Limpiar = Limpiará la caja de texto";
                            
                            
                        }
                        break;
                    case 2:
                        {
                            LBInstrucciones.Text = "Guardar = Guardará el contenido en un fichero de texto llamado bloc.txt";
                            contador++;
                        }
                        break;
                    case 3:
                        {
                            LBInstrucciones.Text = "Abrir = Abrirá el contenido del fichero llamado bloc.txt";
                            contador++;
                        }
                        break;
                    case 4:
                        {
                            contador = -1;
                        }
                        break;
                }
            }
        }
    }
}

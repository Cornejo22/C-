using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9_RelacionVisual
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TBTextoPalabras_TextChanged(object sender, EventArgs e)
        {
            int[] arrayN = new int[5];
            Array.Clear(arrayN, 0, arrayN.Length);
            string linea = TBTextoPalabras.Text;
            int i;
            for (i = 0; i < linea.Length; i++)
            {
                if(linea[i] == ' ')
                {
                    arrayN[2]++;
                }
            }

            string[] separadores = { " ", "\r\n" };
            string[] trozos = linea.Split(separadores, StringSplitOptions.None);
            for (i = 0; i < trozos.Length; i++)
            {
                if (trozos[i].Length > 0)
                {
                    arrayN[1]++;
                }
            }

            for (i = 0; i < linea.Length; i++)
            {
                if(char.IsLetter(linea[i]) == true)
                {
                    arrayN[0]++;

                    if (linea[i] == 'a' || linea[i] == 'e' || linea[i] == 'i' || linea[i] == 'o' || linea[i] == 'u' ||
                        linea[i] == 'A' || linea[i] == 'E' || linea[i] == 'I' || linea[i] == 'O' || linea[i] == 'U')
                    {
                        arrayN[3]++;
                    }
                    else
                    {
                        arrayN[4]++;
                    }
                    
                }
            }

            TBLetras.Text = arrayN[0].ToString();
            TBPalabras.Text = arrayN[1].ToString();
            TBEspacios.Text = arrayN[2].ToString();
            TBVocales.Text = arrayN[3].ToString();
            TBConsonantes.Text = arrayN[4].ToString();

        }
    }
}

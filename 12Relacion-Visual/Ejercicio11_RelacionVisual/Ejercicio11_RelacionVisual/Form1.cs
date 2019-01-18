using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11_RelacionVisual
{
    public partial class Form1 : Form
    {
        int resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BTTirar_Click(object sender, EventArgs e)
        {
            LBTiradas.Items.Clear();
            List<int> tiradas = new List<int>();
            Random r = new Random();
            int tirada = 0;
            int contador;
            for (contador = 1; contador <= NUDNumDados.Value; contador++)
            {
                tirada = r.Next(1, int.Parse(NUDNumCaras.Value.ToString()) + 1);
                tiradas.Add(tirada);
            }

            for (int i = 0; i < tiradas.Count; i++)
            {
                LBTiradas.Items.Add("El dado nº" + (i+1) + ". Puntuación : " + tiradas[i]);
                resultado = resultado + tiradas[i];
            }
            
            TBSuma.Text = resultado.ToString();
        }
    }
}

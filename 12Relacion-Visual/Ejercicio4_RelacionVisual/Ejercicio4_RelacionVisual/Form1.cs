using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_RelacionVisual
{
    public partial class Form1 : Form
    {
        int min, max, numero, intentos;

        private void BTMenor_Click(object sender, EventArgs e)
        {
            max = numero - 1;
            numero = (max + min) / 2;
            labelNumero.Text = "El número adivinado : " + numero.ToString();
            intentos++;
           
        }

        private void BTReiniciar_Click(object sender, EventArgs e)
        {
            min = 1;
            max = 100;
            numero = 50;
            intentos = 0;
            labelNumero.Text = "El número adivinado : " + numero.ToString();
            LBIntentos.Text = "Numero de intentos : ";
        }

        private void BTMayor_Click(object sender, EventArgs e)
        {
            min = numero + 1;
            numero = (max + min) / 2;
            labelNumero.Text = "El número adivinado : " + numero.ToString();
            intentos++;
        }

        public Form1()
        {
            min = 1;
            max = 100;
            numero = 50;
            intentos = 0;
            InitializeComponent();
        }

        private void BTAcertado_Click(object sender, EventArgs e)
        {          
            labelNumero.Text = "El número es : " + numero.ToString();
            LBIntentos.Text = "Número de intentos : " + intentos.ToString();          
        }
    }
}

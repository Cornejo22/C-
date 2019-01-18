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

namespace Ejercicio16_RelacionVisual
{
    public partial class Form1 : Form
    {
        Button[] brT;
        TextBox[] partes;
        public Form1()
        {
            InitializeComponent();
            brT = new Button[] { BTAnnadir, BTBorrar, BTModificar, BTNuevo, BTGuardar,BTGL };
            partes = new TextBox[6] {  TBNombreG, TBColorG,
                TBRazaG, TBPesoG, TBTamannoG, TBColorOG };
        }

        public void Desactivar()
        {
            for (int i = 0; i < brT.Length; i++)
            {
                brT[i].Enabled = false;
            }
        }

        public bool Devuelve(string cadena)
        {
           bool activar;
           return activar = !string.IsNullOrEmpty(cadena);
        }

        public DialogResult Error(string cadena)
        {
            DialogResult dr = MessageBox.Show("Error, los datos están vacios", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            return dr;
        } 
    
        private void BTAnnadir_Click(object sender, EventArgs e)
        {
            string[] partes = new string[6] {  TBNombreG.Text, TBColorG.Text,
                TBRazaG.Text, TBPesoG.Text, TBTamannoG.Text, TBColorOG.Text };

            LVDatosG.Items.Add(new ListViewItem(partes));
       
        }

        private void BTNuevo_Click(object sender, EventArgs e)
        {
        
            for (int i = 0; i < partes.Length; i++)
            {
                partes[i].Clear();
            }         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Desactivar();
        }

        #region "TextChangeds"

        private void TBNombreG_TextChanged(object sender, EventArgs e)
        {
            if(Devuelve(TBNombreG.Text) && Devuelve(TBColorG.Text) && Devuelve(TBRazaG.Text) &&
                Devuelve(TBRazaG.Text) && Devuelve(TBPesoG.Text) && Devuelve(TBTamannoG.Text) && Devuelve(TBColorOG.Text))
            {
                BTAnnadir.Enabled = true;
                BTNuevo.Enabled = true;
            }
            else
            {
                Desactivar();
            }
        }

        private void TBColorG_TextChanged(object sender, EventArgs e)
        {
            if (Devuelve(TBNombreG.Text) && Devuelve(TBColorG.Text) && Devuelve(TBRazaG.Text) &&
                Devuelve(TBRazaG.Text) && Devuelve(TBPesoG.Text) && Devuelve(TBTamannoG.Text) && Devuelve(TBColorOG.Text))
            {
                BTAnnadir.Enabled = true;
                BTNuevo.Enabled = true;
            } 
        }

        private void TBRazaG_TextChanged(object sender, EventArgs e)
        {
            if (Devuelve(TBNombreG.Text) && Devuelve(TBColorG.Text) && Devuelve(TBRazaG.Text) &&
                Devuelve(TBRazaG.Text) && Devuelve(TBPesoG.Text) && Devuelve(TBTamannoG.Text) && Devuelve(TBColorOG.Text))
            {
                BTAnnadir.Enabled = true;
                BTNuevo.Enabled = true;
            }
        }

        private void TBPesoG_TextChanged(object sender, EventArgs e)
        {
            if (Devuelve(TBNombreG.Text) && Devuelve(TBColorG.Text) && Devuelve(TBRazaG.Text) &&
                Devuelve(TBRazaG.Text) && Devuelve(TBPesoG.Text) && Devuelve(TBTamannoG.Text) && Devuelve(TBColorOG.Text))
            {
                BTAnnadir.Enabled = true;
                BTNuevo.Enabled = true;
            }
        }

        private void TBTamannoG_TextChanged(object sender, EventArgs e)
        {
            if (Devuelve(TBNombreG.Text) && Devuelve(TBColorG.Text) && Devuelve(TBRazaG.Text) &&
                Devuelve(TBRazaG.Text) && Devuelve(TBPesoG.Text) && Devuelve(TBTamannoG.Text) && Devuelve(TBColorOG.Text))
            {
                BTAnnadir.Enabled = true;
                BTNuevo.Enabled = true;
            }
        }

        private void TBColorOG_TextChanged(object sender, EventArgs e)
        {
            if (Devuelve(TBNombreG.Text) && Devuelve(TBColorG.Text) && Devuelve(TBRazaG.Text) &&
                Devuelve(TBRazaG.Text) && Devuelve(TBPesoG.Text) && Devuelve(TBTamannoG.Text) && Devuelve(TBColorOG.Text))
            {
                BTAnnadir.Enabled = true;
                BTNuevo.Enabled = true;
            }
        }

        #endregion

        private void BTModificar_Click(object sender, EventArgs e)
        {
            int pos = -1;
            
            if (LVDatosG.SelectedIndices.Count == 1)
            {
                if(LVDatosG.SelectedIndices.Count > 1)
                {
                    DialogResult dr = MessageBox.Show("Va a modificar varios elementos.\n¿Está seguro?", "Cuidado", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                    pos = LVDatosG.SelectedIndices[0];
                    int j = LVDatosG.Items[pos].SubItems.Count;
                    List<string> lista = new List<string>();
                    //lista.Add(LVDatosG.Items[0].Text);
                    for (int i = 0; i < j; i++)
                    {
                        lista.Add(LVDatosG.Items[pos].SubItems[i].Text);
                    }

                    for (int i = 0; i < partes.Length; i++)
                    {
                        partes[i].Text = lista[i];
                    }
                }
            }
            BTGL.Enabled = true;
            BTAnnadir.Enabled = false;
            BTNuevo.Enabled = false;
        }

        private void LVDatosG_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTModificar.Enabled = true;
           
        }

        private void BTGL_Click(object sender, EventArgs e)
        {
           int pos = LVDatosG.SelectedIndices[0];
            string[] partes = new string[6] {  TBNombreG.Text, TBColorG.Text,
                TBRazaG.Text, TBPesoG.Text, TBTamannoG.Text, TBColorOG.Text };

            for (int i = 0; i < LVDatosG.Items[pos].SubItems.Count; i++)
            {
                LVDatosG.Items[pos].SubItems[i].Text = partes[i];
            }
            BTGL.Enabled = false;
            BTNuevo.PerformClick();
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            int i, j;
            string linea = "";
            string fichero = "gatitos.txt";

            StreamWriter sw = new StreamWriter(fichero, true, Encoding.Default);

            sw.WriteLine("Nombre,Color,Raza,Peso,Tamaño,Ojos");

            for (i = 0; i < LVDatosG.Items.Count; i++)
            {
                for (j = 0; j < LVDatosG.Items[i].SubItems.Count - 1; j++)
                {
                    linea = linea + LVDatosG.Items[i].SubItems[j].Text + ",";
                }
                linea = linea + LVDatosG.Items[i].SubItems[j].Text;
                sw.WriteLine(linea);
                linea = "";
            }

            sw.Close();

        }

        private void LVDatosG_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (LVDatosG.Items.Count > 0)
            {
                BTGuardar.Enabled = true;
            }
        }

        private void LVDatosG_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (LVDatosG.Items.Count > 0)
            {
                BTGuardar.Enabled = true;
            }
        }
    }
}

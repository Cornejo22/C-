using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        
        TextBox[] partes;
        public Form1()
        {
            InitializeComponent();
          
            partes  = new TextBox[4] {  TBNombreU, TBContrasenna,TBEdad, TBCorreo };
        }

        public bool Devuelve(string cadena)
        {
            bool activar;
            return activar = !string.IsNullOrEmpty(cadena);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTAnnadirL.Enabled = false;
        }

        private bool ValidarU(string linea)
        {
            bool devuelve = false;

            for (int i = 0; i < linea.Length; i++)
            {
                if (char.IsLetter(linea[i]))
                {
                    devuelve = true;
                }
                else
                {
                    devuelve = false;
                }
            }

            return devuelve;
        }

        private bool Existe(ListView aux,string nombre)
        {
            bool existe = false;

            for (int i = 0; i < aux.Items.Count; i++)
            {
                string nombre2 = aux.Items[i].Text;
                if (nombre2 == nombre)
                {
                    existe = true;
                }
            }


            return existe;
        }

        private void BTValidarNU_Click(object sender, EventArgs e)
        {
            string linea = TBNombreU.Text;

            if(linea != "" || linea.Length >= 4 && linea.Length <= 20)
            {
                if (ValidarU(linea))
                {
                    if (!Existe(LVDatos, linea))
                    {
                        BTAnnadirL.Enabled = true;
                        MessageBox.Show("Validado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, nombre de usuario existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BTAnnadirL.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Error, el nombre de usuario contiene números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BTAnnadirL.Enabled = false;
                }            
            }
            else
            {
                MessageBox.Show("Error, campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void BTValidarC_Click(object sender, EventArgs e)
        {
            string linea = TBContrasenna.Text;

            if(linea.Length >= 8 && linea.Length <= 16 && linea == TBContrasenna2.Text)
            {                              
                MessageBox.Show("Validado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTAnnadirL.Enabled = true;
            }
            else
            {
                if (linea == "")
                {
                    MessageBox.Show("Error, campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BTAnnadirL.Enabled = false;
                }
                else
                {
                    if (linea.Length < 8)
                    {
                        MessageBox.Show("Error, contraseña corta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BTAnnadirL.Enabled = false;
                    }
                    else
                    {
                        if ((linea.Length > 16))
                        {
                            MessageBox.Show("Error, contraseña larga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BTAnnadirL.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error, las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BTAnnadirL.Enabled = false;
                        }
                    }

                }
            }
                
            
        }

        private void BTValidarEdad_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TBEdad.Text);
            if (int.Parse(TBEdad.Text) >= 18 && int.Parse(TBEdad.Text) <= 100)
            {
                MessageBox.Show("Validado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTAnnadirL.Enabled = true;
            }
            else
            {

                if (int.Parse(TBEdad.Text) < 18)
                {
                    MessageBox.Show("Error, edad inferior a 18", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BTAnnadirL.Enabled = false;
                }
                else
                {
                    if (int.Parse(TBEdad.Text) > 100)
                    {
                        MessageBox.Show("Error, error superior a 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BTAnnadirL.Enabled = false;
                    }
                }
            }
            
        }

        private void BTValidarCorreo_Click(object sender, EventArgs e)
        {
            string linea = TBCorreo.Text;
            string linea2 = TBCorreo2.Text;
            int contadorArrobas = 0;
            int contadorArrobas2 = 0;
            int contadorErrores = 0;
            int contadorErrores2 = 0;

            for (int i = 0; i < linea.Length; i++)
            {
                if(linea[i] == '@')
                {
                    contadorArrobas++;
                }
            }

            for (int i = 0; i < linea2.Length; i++)
            {
                if (linea2[i] == '@')
                {
                    contadorArrobas2++;
                }
            }

            for (int i = 0; i < linea.Length; i++)
            {
                if (!char.IsLetterOrDigit(linea[i]))
                {
                   if(linea[i] != '.' && linea[i] != '@')
                    {
                        contadorErrores++;
                    }
                }                
            }

            int pos = linea2.IndexOf(',');

            for (int i = 0; i < linea2.Length; i++)
            {
                if (!char.IsLetterOrDigit(linea2[i]))
                {
                    if (linea2[i] != '.' && linea2[i] != '@')
                    {
                        contadorErrores2++;
                    }
                }
            }

            if (contadorArrobas == 1 && contadorArrobas2 == 1)
            {

                if (contadorErrores > 0 || contadorErrores2 > 0)
                {
                    MessageBox.Show("Error, hay carácteres raros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BTAnnadirL.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Validado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BTAnnadirL.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Error, hay más de un @ o no es un correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BTAnnadirL.Enabled = false;
            }            
                         
        }

        private void BTAnnadirL_Click(object sender, EventArgs e)
        {
            string[] partes = new string[4] { TBNombreU.Text, TBContrasenna.Text, TBEdad.Text, TBCorreo.Text };

            LVDatos.Items.Add(new ListViewItem(partes));
                       
        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            TBNombreU.Clear();
            TBContrasenna.Clear();
            TBContrasenna2.Clear();
            TBCorreo.Clear();
            TBCorreo2.Clear();
            TBEdad.Clear();
            BTAnnadirL.Enabled = false;
        }

        
    }
}

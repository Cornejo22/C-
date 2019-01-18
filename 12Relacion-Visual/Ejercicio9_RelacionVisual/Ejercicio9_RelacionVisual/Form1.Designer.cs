namespace Ejercicio9_RelacionVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBTextoPalabras = new System.Windows.Forms.TextBox();
            this.LBNLetras = new System.Windows.Forms.Label();
            this.LBNPalabras = new System.Windows.Forms.Label();
            this.LBNEspacios = new System.Windows.Forms.Label();
            this.LBNVocales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBLetras = new System.Windows.Forms.TextBox();
            this.TBPalabras = new System.Windows.Forms.TextBox();
            this.TBEspacios = new System.Windows.Forms.TextBox();
            this.TBVocales = new System.Windows.Forms.TextBox();
            this.TBConsonantes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBTextoPalabras
            // 
            this.TBTextoPalabras.Location = new System.Drawing.Point(12, 12);
            this.TBTextoPalabras.Multiline = true;
            this.TBTextoPalabras.Name = "TBTextoPalabras";
            this.TBTextoPalabras.Size = new System.Drawing.Size(132, 237);
            this.TBTextoPalabras.TabIndex = 0;
            this.TBTextoPalabras.TextChanged += new System.EventHandler(this.TBTextoPalabras_TextChanged);
            // 
            // LBNLetras
            // 
            this.LBNLetras.AutoSize = true;
            this.LBNLetras.Location = new System.Drawing.Point(150, 45);
            this.LBNLetras.Name = "LBNLetras";
            this.LBNLetras.Size = new System.Drawing.Size(66, 13);
            this.LBNLetras.TabIndex = 1;
            this.LBNLetras.Text = "Nº de Letras";
            // 
            // LBNPalabras
            // 
            this.LBNPalabras.AutoSize = true;
            this.LBNPalabras.Location = new System.Drawing.Point(150, 80);
            this.LBNPalabras.Name = "LBNPalabras";
            this.LBNPalabras.Size = new System.Drawing.Size(78, 13);
            this.LBNPalabras.TabIndex = 2;
            this.LBNPalabras.Text = "Nº de Palabras";
            // 
            // LBNEspacios
            // 
            this.LBNEspacios.AutoSize = true;
            this.LBNEspacios.Location = new System.Drawing.Point(150, 119);
            this.LBNEspacios.Name = "LBNEspacios";
            this.LBNEspacios.Size = new System.Drawing.Size(80, 13);
            this.LBNEspacios.TabIndex = 3;
            this.LBNEspacios.Text = "Nº de Espacios";
            // 
            // LBNVocales
            // 
            this.LBNVocales.AutoSize = true;
            this.LBNVocales.Location = new System.Drawing.Point(150, 161);
            this.LBNVocales.Name = "LBNVocales";
            this.LBNVocales.Size = new System.Drawing.Size(75, 13);
            this.LBNVocales.TabIndex = 4;
            this.LBNVocales.Text = "Nº de Vocales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nº de Consonates";
            // 
            // TBLetras
            // 
            this.TBLetras.ForeColor = System.Drawing.Color.Blue;
            this.TBLetras.Location = new System.Drawing.Point(249, 42);
            this.TBLetras.Name = "TBLetras";
            this.TBLetras.Size = new System.Drawing.Size(45, 20);
            this.TBLetras.TabIndex = 7;
            this.TBLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBPalabras
            // 
            this.TBPalabras.ForeColor = System.Drawing.Color.Green;
            this.TBPalabras.Location = new System.Drawing.Point(249, 77);
            this.TBPalabras.Name = "TBPalabras";
            this.TBPalabras.Size = new System.Drawing.Size(45, 20);
            this.TBPalabras.TabIndex = 8;
            this.TBPalabras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBEspacios
            // 
            this.TBEspacios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TBEspacios.Location = new System.Drawing.Point(249, 116);
            this.TBEspacios.Name = "TBEspacios";
            this.TBEspacios.Size = new System.Drawing.Size(45, 20);
            this.TBEspacios.TabIndex = 9;
            this.TBEspacios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBVocales
            // 
            this.TBVocales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TBVocales.Location = new System.Drawing.Point(249, 158);
            this.TBVocales.Name = "TBVocales";
            this.TBVocales.Size = new System.Drawing.Size(45, 20);
            this.TBVocales.TabIndex = 10;
            this.TBVocales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBConsonantes
            // 
            this.TBConsonantes.Location = new System.Drawing.Point(249, 193);
            this.TBConsonantes.Name = "TBConsonantes";
            this.TBConsonantes.Size = new System.Drawing.Size(45, 20);
            this.TBConsonantes.TabIndex = 11;
            this.TBConsonantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estadisticas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBConsonantes);
            this.Controls.Add(this.TBVocales);
            this.Controls.Add(this.TBEspacios);
            this.Controls.Add(this.TBPalabras);
            this.Controls.Add(this.TBLetras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBNVocales);
            this.Controls.Add(this.LBNEspacios);
            this.Controls.Add(this.LBNPalabras);
            this.Controls.Add(this.LBNLetras);
            this.Controls.Add(this.TBTextoPalabras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBTextoPalabras;
        private System.Windows.Forms.Label LBNLetras;
        private System.Windows.Forms.Label LBNPalabras;
        private System.Windows.Forms.Label LBNEspacios;
        private System.Windows.Forms.Label LBNVocales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBLetras;
        private System.Windows.Forms.TextBox TBPalabras;
        private System.Windows.Forms.TextBox TBEspacios;
        private System.Windows.Forms.TextBox TBVocales;
        private System.Windows.Forms.TextBox TBConsonantes;
        private System.Windows.Forms.Label label1;
    }
}


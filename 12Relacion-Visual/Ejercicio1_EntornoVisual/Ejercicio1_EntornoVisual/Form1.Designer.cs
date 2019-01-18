namespace Ejercicio1_EntornoVisual
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
            this.Etiqueta = new System.Windows.Forms.Label();
            this.BotonP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Etiqueta
            // 
            this.Etiqueta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Etiqueta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Etiqueta.Location = new System.Drawing.Point(101, 91);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(78, 29);
            this.Etiqueta.TabIndex = 0;
            this.Etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Etiqueta.UseMnemonic = false;
            // 
            // BotonP
            // 
            this.BotonP.Location = new System.Drawing.Point(104, 159);
            this.BotonP.Name = "BotonP";
            this.BotonP.Size = new System.Drawing.Size(75, 23);
            this.BotonP.TabIndex = 1;
            this.BotonP.Text = "Pulse aqui";
            this.BotonP.UseVisualStyleBackColor = true;
            this.BotonP.Click += new System.EventHandler(this.BotonP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BotonP);
            this.Controls.Add(this.Etiqueta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta;
        private System.Windows.Forms.Button BotonP;
    }
}


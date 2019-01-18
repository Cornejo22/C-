namespace Ejercicio2_EntornoVisual
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
            this.TextoMulti = new System.Windows.Forms.TextBox();
            this.BotonLimpiar = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonAbrir = new System.Windows.Forms.Button();
            this.LBInstrucciones = new System.Windows.Forms.Label();
            this.BTInstrucciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoMulti
            // 
            this.TextoMulti.Location = new System.Drawing.Point(44, 76);
            this.TextoMulti.Multiline = true;
            this.TextoMulti.Name = "TextoMulti";
            this.TextoMulti.Size = new System.Drawing.Size(195, 87);
            this.TextoMulti.TabIndex = 0;
            // 
            // BotonLimpiar
            // 
            this.BotonLimpiar.Location = new System.Drawing.Point(44, 187);
            this.BotonLimpiar.Name = "BotonLimpiar";
            this.BotonLimpiar.Size = new System.Drawing.Size(82, 23);
            this.BotonLimpiar.TabIndex = 1;
            this.BotonLimpiar.Text = "Limpiar";
            this.BotonLimpiar.UseVisualStyleBackColor = true;
            this.BotonLimpiar.Click += new System.EventHandler(this.BotonLimpiar_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(156, 187);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(83, 23);
            this.BotonGuardar.TabIndex = 2;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonAbrir
            // 
            this.BotonAbrir.Location = new System.Drawing.Point(44, 216);
            this.BotonAbrir.Name = "BotonAbrir";
            this.BotonAbrir.Size = new System.Drawing.Size(82, 23);
            this.BotonAbrir.TabIndex = 3;
            this.BotonAbrir.Text = "Abrir";
            this.BotonAbrir.UseVisualStyleBackColor = true;
            this.BotonAbrir.Click += new System.EventHandler(this.BotonAbrir_Click);
            // 
            // LBInstrucciones
            // 
            this.LBInstrucciones.AutoSize = true;
            this.LBInstrucciones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBInstrucciones.Location = new System.Drawing.Point(41, 27);
            this.LBInstrucciones.Name = "LBInstrucciones";
            this.LBInstrucciones.Size = new System.Drawing.Size(0, 13);
            this.LBInstrucciones.TabIndex = 4;
            // 
            // BTInstrucciones
            // 
            this.BTInstrucciones.Location = new System.Drawing.Point(156, 216);
            this.BTInstrucciones.Name = "BTInstrucciones";
            this.BTInstrucciones.Size = new System.Drawing.Size(83, 23);
            this.BTInstrucciones.TabIndex = 5;
            this.BTInstrucciones.Text = "Instrucciones";
            this.BTInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTInstrucciones.UseVisualStyleBackColor = true;
            this.BTInstrucciones.Click += new System.EventHandler(this.BTInstrucciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTInstrucciones);
            this.Controls.Add(this.LBInstrucciones);
            this.Controls.Add(this.BotonAbrir);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.BotonLimpiar);
            this.Controls.Add(this.TextoMulti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoMulti;
        private System.Windows.Forms.Button BotonLimpiar;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonAbrir;
        private System.Windows.Forms.Label LBInstrucciones;
        private System.Windows.Forms.Button BTInstrucciones;
    }
}


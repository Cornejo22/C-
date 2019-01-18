namespace Ejercicio10_RelacionVisual
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBPalabras = new System.Windows.Forms.ListBox();
            this.TBEspannol = new System.Windows.Forms.TextBox();
            this.TBIngles = new System.Windows.Forms.TextBox();
            this.BTAnnadir = new System.Windows.Forms.Button();
            this.BTBorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diccionario de palabras";
            // 
            // LBPalabras
            // 
            this.LBPalabras.FormattingEnabled = true;
            this.LBPalabras.Location = new System.Drawing.Point(12, 46);
            this.LBPalabras.Name = "LBPalabras";
            this.LBPalabras.Size = new System.Drawing.Size(173, 186);
            this.LBPalabras.TabIndex = 1;
            this.LBPalabras.SelectedIndexChanged += new System.EventHandler(this.LBPalabras_SelectedIndexChanged);
            // 
            // TBEspannol
            // 
            this.TBEspannol.Location = new System.Drawing.Point(261, 61);
            this.TBEspannol.Name = "TBEspannol";
            this.TBEspannol.Size = new System.Drawing.Size(100, 20);
            this.TBEspannol.TabIndex = 2;
            this.TBEspannol.TextChanged += new System.EventHandler(this.TBEspannol_TextChanged);
            // 
            // TBIngles
            // 
            this.TBIngles.Location = new System.Drawing.Point(261, 129);
            this.TBIngles.Name = "TBIngles";
            this.TBIngles.Size = new System.Drawing.Size(100, 20);
            this.TBIngles.TabIndex = 3;
            this.TBIngles.TextChanged += new System.EventHandler(this.TBIngles_TextChanged);
            // 
            // BTAnnadir
            // 
            this.BTAnnadir.Location = new System.Drawing.Point(194, 192);
            this.BTAnnadir.Name = "BTAnnadir";
            this.BTAnnadir.Size = new System.Drawing.Size(75, 23);
            this.BTAnnadir.TabIndex = 4;
            this.BTAnnadir.Text = "Añadir";
            this.BTAnnadir.UseVisualStyleBackColor = true;
            this.BTAnnadir.Click += new System.EventHandler(this.BTAnnadir_Click);
            // 
            // BTBorrar
            // 
            this.BTBorrar.Location = new System.Drawing.Point(286, 192);
            this.BTBorrar.Name = "BTBorrar";
            this.BTBorrar.Size = new System.Drawing.Size(75, 23);
            this.BTBorrar.TabIndex = 5;
            this.BTBorrar.Text = "Borrar";
            this.BTBorrar.UseVisualStyleBackColor = true;
            this.BTBorrar.Click += new System.EventHandler(this.BTBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Español";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTBorrar);
            this.Controls.Add(this.BTAnnadir);
            this.Controls.Add(this.TBIngles);
            this.Controls.Add(this.TBEspannol);
            this.Controls.Add(this.LBPalabras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBPalabras;
        private System.Windows.Forms.TextBox TBEspannol;
        private System.Windows.Forms.TextBox TBIngles;
        private System.Windows.Forms.Button BTAnnadir;
        private System.Windows.Forms.Button BTBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


namespace Ejercicio1
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
            this.LBFichero = new System.Windows.Forms.Label();
            this.TBLeer = new System.Windows.Forms.TextBox();
            this.BTCargar = new System.Windows.Forms.Button();
            this.LBoxPalabras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LBFichero
            // 
            this.LBFichero.AutoSize = true;
            this.LBFichero.Location = new System.Drawing.Point(13, 13);
            this.LBFichero.Name = "LBFichero";
            this.LBFichero.Size = new System.Drawing.Size(45, 13);
            this.LBFichero.TabIndex = 0;
            this.LBFichero.Text = "Fichero:";
            // 
            // TBLeer
            // 
            this.TBLeer.Location = new System.Drawing.Point(16, 30);
            this.TBLeer.Name = "TBLeer";
            this.TBLeer.Size = new System.Drawing.Size(154, 20);
            this.TBLeer.TabIndex = 1;
            this.TBLeer.TextChanged += new System.EventHandler(this.TBLeer_TextChanged);
            // 
            // BTCargar
            // 
            this.BTCargar.Location = new System.Drawing.Point(176, 29);
            this.BTCargar.Name = "BTCargar";
            this.BTCargar.Size = new System.Drawing.Size(75, 21);
            this.BTCargar.TabIndex = 2;
            this.BTCargar.Text = "Cargar";
            this.BTCargar.UseVisualStyleBackColor = true;
            this.BTCargar.Click += new System.EventHandler(this.BTCargar_Click);
            // 
            // LBoxPalabras
            // 
            this.LBoxPalabras.FormattingEnabled = true;
            this.LBoxPalabras.Location = new System.Drawing.Point(16, 58);
            this.LBoxPalabras.Name = "LBoxPalabras";
            this.LBoxPalabras.Size = new System.Drawing.Size(235, 186);
            this.LBoxPalabras.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 261);
            this.Controls.Add(this.LBoxPalabras);
            this.Controls.Add(this.BTCargar);
            this.Controls.Add(this.TBLeer);
            this.Controls.Add(this.LBFichero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBFichero;
        private System.Windows.Forms.TextBox TBLeer;
        private System.Windows.Forms.Button BTCargar;
        private System.Windows.Forms.ListBox LBoxPalabras;
    }
}


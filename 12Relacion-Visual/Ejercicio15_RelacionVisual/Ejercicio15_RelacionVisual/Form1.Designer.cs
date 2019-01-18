namespace Ejercicio15_RelacionVisual
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
            this.LVDatos = new System.Windows.Forms.ListView();
            this.BTCargar = new System.Windows.Forms.Button();
            this.BTBorrar = new System.Windows.Forms.Button();
            this.BTInsertar = new System.Windows.Forms.Button();
            this.TBInsertar = new System.Windows.Forms.TextBox();
            this.LBEjemplo = new System.Windows.Forms.Label();
            this.TBCargar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LVDatos
            // 
            this.LVDatos.FullRowSelect = true;
            this.LVDatos.GridLines = true;
            this.LVDatos.Location = new System.Drawing.Point(12, 12);
            this.LVDatos.Name = "LVDatos";
            this.LVDatos.Size = new System.Drawing.Size(328, 147);
            this.LVDatos.TabIndex = 0;
            this.LVDatos.UseCompatibleStateImageBehavior = false;
            this.LVDatos.View = System.Windows.Forms.View.Details;
            this.LVDatos.SelectedIndexChanged += new System.EventHandler(this.LVDatos_SelectedIndexChanged);
            // 
            // BTCargar
            // 
            this.BTCargar.Location = new System.Drawing.Point(93, 249);
            this.BTCargar.Name = "BTCargar";
            this.BTCargar.Size = new System.Drawing.Size(75, 20);
            this.BTCargar.TabIndex = 1;
            this.BTCargar.Text = "Cargar";
            this.BTCargar.UseVisualStyleBackColor = true;
            this.BTCargar.Click += new System.EventHandler(this.BTCargar_Click);
            // 
            // BTBorrar
            // 
            this.BTBorrar.Location = new System.Drawing.Point(12, 249);
            this.BTBorrar.Name = "BTBorrar";
            this.BTBorrar.Size = new System.Drawing.Size(75, 20);
            this.BTBorrar.TabIndex = 2;
            this.BTBorrar.Text = "Borrar";
            this.BTBorrar.UseVisualStyleBackColor = true;
            this.BTBorrar.Click += new System.EventHandler(this.BTBorrar_Click);
            // 
            // BTInsertar
            // 
            this.BTInsertar.Location = new System.Drawing.Point(12, 196);
            this.BTInsertar.Name = "BTInsertar";
            this.BTInsertar.Size = new System.Drawing.Size(75, 20);
            this.BTInsertar.TabIndex = 3;
            this.BTInsertar.Text = "Insertar";
            this.BTInsertar.UseVisualStyleBackColor = true;
            this.BTInsertar.Click += new System.EventHandler(this.BTInsertar_Click);
            // 
            // TBInsertar
            // 
            this.TBInsertar.Location = new System.Drawing.Point(93, 196);
            this.TBInsertar.Name = "TBInsertar";
            this.TBInsertar.Size = new System.Drawing.Size(247, 20);
            this.TBInsertar.TabIndex = 4;
            this.TBInsertar.TextChanged += new System.EventHandler(this.TBInsertar_TextChanged);
            // 
            // LBEjemplo
            // 
            this.LBEjemplo.AutoSize = true;
            this.LBEjemplo.Location = new System.Drawing.Point(12, 180);
            this.LBEjemplo.Name = "LBEjemplo";
            this.LBEjemplo.Size = new System.Drawing.Size(333, 13);
            this.LBEjemplo.TabIndex = 5;
            this.LBEjemplo.Text = "Ejemplo de insercción : nombre,nota,calificacion(aprobado,suspenso)";
            // 
            // TBCargar
            // 
            this.TBCargar.Location = new System.Drawing.Point(171, 249);
            this.TBCargar.Name = "TBCargar";
            this.TBCargar.Size = new System.Drawing.Size(169, 20);
            this.TBCargar.TabIndex = 6;
            this.TBCargar.TextChanged += new System.EventHandler(this.TBCargar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Escribir el archivo csv(sin incluir extensión)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCargar);
            this.Controls.Add(this.LBEjemplo);
            this.Controls.Add(this.TBInsertar);
            this.Controls.Add(this.BTInsertar);
            this.Controls.Add(this.BTBorrar);
            this.Controls.Add(this.BTCargar);
            this.Controls.Add(this.LVDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVDatos;
        private System.Windows.Forms.Button BTCargar;
        private System.Windows.Forms.Button BTBorrar;
        private System.Windows.Forms.Button BTInsertar;
        private System.Windows.Forms.TextBox TBInsertar;
        private System.Windows.Forms.Label LBEjemplo;
        private System.Windows.Forms.TextBox TBCargar;
        private System.Windows.Forms.Label label1;
    }
}


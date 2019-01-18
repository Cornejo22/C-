namespace Ejercicio3
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
            this.TBNombreU = new System.Windows.Forms.TextBox();
            this.TBContrasenna = new System.Windows.Forms.TextBox();
            this.TBContrasenna2 = new System.Windows.Forms.TextBox();
            this.TBEdad = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.TBCorreo2 = new System.Windows.Forms.TextBox();
            this.BTValidarNU = new System.Windows.Forms.Button();
            this.BTValidarC = new System.Windows.Forms.Button();
            this.BTValidarEdad = new System.Windows.Forms.Button();
            this.BTValidarCorreo = new System.Windows.Forms.Button();
            this.BTAnnadirL = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.LVDatos = new System.Windows.Forms.ListView();
            this.CHUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHContrasenna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBNombreU
            // 
            this.TBNombreU.Location = new System.Drawing.Point(29, 25);
            this.TBNombreU.Name = "TBNombreU";
            this.TBNombreU.Size = new System.Drawing.Size(177, 20);
            this.TBNombreU.TabIndex = 0;
            // 
            // TBContrasenna
            // 
            this.TBContrasenna.Location = new System.Drawing.Point(29, 71);
            this.TBContrasenna.Name = "TBContrasenna";
            this.TBContrasenna.PasswordChar = '*';
            this.TBContrasenna.Size = new System.Drawing.Size(177, 20);
            this.TBContrasenna.TabIndex = 1;
            // 
            // TBContrasenna2
            // 
            this.TBContrasenna2.Location = new System.Drawing.Point(29, 120);
            this.TBContrasenna2.Name = "TBContrasenna2";
            this.TBContrasenna2.PasswordChar = '*';
            this.TBContrasenna2.Size = new System.Drawing.Size(177, 20);
            this.TBContrasenna2.TabIndex = 2;
            // 
            // TBEdad
            // 
            this.TBEdad.Location = new System.Drawing.Point(320, 24);
            this.TBEdad.Name = "TBEdad";
            this.TBEdad.Size = new System.Drawing.Size(161, 20);
            this.TBEdad.TabIndex = 3;
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(320, 67);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(161, 20);
            this.TBCorreo.TabIndex = 4;
            // 
            // TBCorreo2
            // 
            this.TBCorreo2.Location = new System.Drawing.Point(320, 120);
            this.TBCorreo2.Name = "TBCorreo2";
            this.TBCorreo2.Size = new System.Drawing.Size(161, 20);
            this.TBCorreo2.TabIndex = 5;
            // 
            // BTValidarNU
            // 
            this.BTValidarNU.Location = new System.Drawing.Point(212, 22);
            this.BTValidarNU.Name = "BTValidarNU";
            this.BTValidarNU.Size = new System.Drawing.Size(75, 23);
            this.BTValidarNU.TabIndex = 6;
            this.BTValidarNU.Text = "Validar";
            this.BTValidarNU.UseVisualStyleBackColor = true;
            this.BTValidarNU.Click += new System.EventHandler(this.BTValidarNU_Click);
            // 
            // BTValidarC
            // 
            this.BTValidarC.Location = new System.Drawing.Point(212, 69);
            this.BTValidarC.Name = "BTValidarC";
            this.BTValidarC.Size = new System.Drawing.Size(75, 71);
            this.BTValidarC.TabIndex = 7;
            this.BTValidarC.Text = "Validar";
            this.BTValidarC.UseVisualStyleBackColor = true;
            this.BTValidarC.Click += new System.EventHandler(this.BTValidarC_Click);
            // 
            // BTValidarEdad
            // 
            this.BTValidarEdad.Location = new System.Drawing.Point(503, 22);
            this.BTValidarEdad.Name = "BTValidarEdad";
            this.BTValidarEdad.Size = new System.Drawing.Size(75, 23);
            this.BTValidarEdad.TabIndex = 8;
            this.BTValidarEdad.Text = "Validar";
            this.BTValidarEdad.UseVisualStyleBackColor = true;
            this.BTValidarEdad.Click += new System.EventHandler(this.BTValidarEdad_Click);
            // 
            // BTValidarCorreo
            // 
            this.BTValidarCorreo.Location = new System.Drawing.Point(503, 67);
            this.BTValidarCorreo.Name = "BTValidarCorreo";
            this.BTValidarCorreo.Size = new System.Drawing.Size(75, 73);
            this.BTValidarCorreo.TabIndex = 9;
            this.BTValidarCorreo.Text = "Validar";
            this.BTValidarCorreo.UseVisualStyleBackColor = true;
            this.BTValidarCorreo.Click += new System.EventHandler(this.BTValidarCorreo_Click);
            // 
            // BTAnnadirL
            // 
            this.BTAnnadirL.Location = new System.Drawing.Point(195, 146);
            this.BTAnnadirL.Name = "BTAnnadirL";
            this.BTAnnadirL.Size = new System.Drawing.Size(118, 23);
            this.BTAnnadirL.TabIndex = 10;
            this.BTAnnadirL.Text = "Añadir a la lista";
            this.BTAnnadirL.UseVisualStyleBackColor = true;
            this.BTAnnadirL.Click += new System.EventHandler(this.BTAnnadirL_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(330, 146);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTCancelar.TabIndex = 11;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // LVDatos
            // 
            this.LVDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHUsuario,
            this.CHContrasenna,
            this.CHEdad,
            this.CHCorreo});
            this.LVDatos.FullRowSelect = true;
            this.LVDatos.GridLines = true;
            this.LVDatos.Location = new System.Drawing.Point(29, 175);
            this.LVDatos.Name = "LVDatos";
            this.LVDatos.Size = new System.Drawing.Size(549, 177);
            this.LVDatos.TabIndex = 12;
            this.LVDatos.UseCompatibleStateImageBehavior = false;
            this.LVDatos.View = System.Windows.Forms.View.Details;
            // 
            // CHUsuario
            // 
            this.CHUsuario.Tag = "";
            this.CHUsuario.Text = "Usuario";
            this.CHUsuario.Width = 85;
            // 
            // CHContrasenna
            // 
            this.CHContrasenna.Text = "Contraseña";
            this.CHContrasenna.Width = 117;
            // 
            // CHEdad
            // 
            this.CHEdad.Text = "Edad";
            this.CHEdad.Width = 100;
            // 
            // CHCorreo
            // 
            this.CHCorreo.Text = "Correo Electrónico";
            this.CHCorreo.Width = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Repetir Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Correo Electrónico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Repetir Correo Electrónico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 364);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVDatos);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.BTAnnadirL);
            this.Controls.Add(this.BTValidarCorreo);
            this.Controls.Add(this.BTValidarEdad);
            this.Controls.Add(this.BTValidarC);
            this.Controls.Add(this.BTValidarNU);
            this.Controls.Add(this.TBCorreo2);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBEdad);
            this.Controls.Add(this.TBContrasenna2);
            this.Controls.Add(this.TBContrasenna);
            this.Controls.Add(this.TBNombreU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNombreU;
        private System.Windows.Forms.TextBox TBContrasenna;
        private System.Windows.Forms.TextBox TBContrasenna2;
        private System.Windows.Forms.TextBox TBEdad;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.TextBox TBCorreo2;
        private System.Windows.Forms.Button BTValidarNU;
        private System.Windows.Forms.Button BTValidarC;
        private System.Windows.Forms.Button BTValidarEdad;
        private System.Windows.Forms.Button BTValidarCorreo;
        private System.Windows.Forms.Button BTAnnadirL;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.ListView LVDatos;
        private System.Windows.Forms.ColumnHeader CHUsuario;
        private System.Windows.Forms.ColumnHeader CHContrasenna;
        private System.Windows.Forms.ColumnHeader CHEdad;
        private System.Windows.Forms.ColumnHeader CHCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


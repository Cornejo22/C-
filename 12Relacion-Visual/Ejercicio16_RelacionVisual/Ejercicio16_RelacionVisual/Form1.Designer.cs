namespace Ejercicio16_RelacionVisual
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
            this.BTAnnadir = new System.Windows.Forms.Button();
            this.BTModificar = new System.Windows.Forms.Button();
            this.BTBorrar = new System.Windows.Forms.Button();
            this.LVDatosG = new System.Windows.Forms.ListView();
            this.CHNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHColorPelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHRaza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTamannoGato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHColorOGato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBColorOG = new System.Windows.Forms.TextBox();
            this.TBRazaG = new System.Windows.Forms.TextBox();
            this.TBPesoG = new System.Windows.Forms.TextBox();
            this.TBTamannoG = new System.Windows.Forms.TextBox();
            this.TBNombreG = new System.Windows.Forms.TextBox();
            this.TBColorG = new System.Windows.Forms.TextBox();
            this.LBNombreG = new System.Windows.Forms.Label();
            this.LBColorPeloG = new System.Windows.Forms.Label();
            this.LBRazaGato = new System.Windows.Forms.Label();
            this.LBPesoG = new System.Windows.Forms.Label();
            this.LBTamanno = new System.Windows.Forms.Label();
            this.LBColorOG = new System.Windows.Forms.Label();
            this.BTNuevo = new System.Windows.Forms.Button();
            this.BTGuardar = new System.Windows.Forms.Button();
            this.BTGL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTAnnadir
            // 
            this.BTAnnadir.Location = new System.Drawing.Point(45, 282);
            this.BTAnnadir.Name = "BTAnnadir";
            this.BTAnnadir.Size = new System.Drawing.Size(75, 23);
            this.BTAnnadir.TabIndex = 0;
            this.BTAnnadir.Text = "Añadir";
            this.BTAnnadir.UseVisualStyleBackColor = true;
            this.BTAnnadir.Click += new System.EventHandler(this.BTAnnadir_Click);
            // 
            // BTModificar
            // 
            this.BTModificar.Location = new System.Drawing.Point(243, 282);
            this.BTModificar.Name = "BTModificar";
            this.BTModificar.Size = new System.Drawing.Size(75, 23);
            this.BTModificar.TabIndex = 1;
            this.BTModificar.Text = "Modificar";
            this.BTModificar.UseVisualStyleBackColor = true;
            this.BTModificar.Click += new System.EventHandler(this.BTModificar_Click);
            // 
            // BTBorrar
            // 
            this.BTBorrar.Location = new System.Drawing.Point(143, 282);
            this.BTBorrar.Name = "BTBorrar";
            this.BTBorrar.Size = new System.Drawing.Size(75, 23);
            this.BTBorrar.TabIndex = 2;
            this.BTBorrar.Text = "Borrar";
            this.BTBorrar.UseVisualStyleBackColor = true;
            // 
            // LVDatosG
            // 
            this.LVDatosG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHNombre,
            this.CHColorPelo,
            this.CHRaza,
            this.CHPeso,
            this.CHTamannoGato,
            this.CHColorOGato});
            this.LVDatosG.FullRowSelect = true;
            this.LVDatosG.GridLines = true;
            this.LVDatosG.Location = new System.Drawing.Point(12, 12);
            this.LVDatosG.Name = "LVDatosG";
            this.LVDatosG.Size = new System.Drawing.Size(459, 175);
            this.LVDatosG.TabIndex = 3;
            this.LVDatosG.UseCompatibleStateImageBehavior = false;
            this.LVDatosG.View = System.Windows.Forms.View.Details;
            this.LVDatosG.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LVDatosG_ItemCheck);
            this.LVDatosG.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LVDatosG_ItemChecked);
            this.LVDatosG.SelectedIndexChanged += new System.EventHandler(this.LVDatosG_SelectedIndexChanged);
            // 
            // CHNombre
            // 
            this.CHNombre.Text = "Nombre";
            // 
            // CHColorPelo
            // 
            this.CHColorPelo.Text = "Color de Pelo";
            this.CHColorPelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHColorPelo.Width = 97;
            // 
            // CHRaza
            // 
            this.CHRaza.Text = "Raza";
            this.CHRaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CHPeso
            // 
            this.CHPeso.Text = "Peso";
            this.CHPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CHTamannoGato
            // 
            this.CHTamannoGato.Text = "Tamaño";
            this.CHTamannoGato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHTamannoGato.Width = 57;
            // 
            // CHColorOGato
            // 
            this.CHColorOGato.Text = "Color de ojos";
            this.CHColorOGato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHColorOGato.Width = 118;
            // 
            // TBColorOG
            // 
            this.TBColorOG.Location = new System.Drawing.Point(279, 245);
            this.TBColorOG.Name = "TBColorOG";
            this.TBColorOG.Size = new System.Drawing.Size(100, 20);
            this.TBColorOG.TabIndex = 4;
            this.TBColorOG.TextChanged += new System.EventHandler(this.TBColorOG_TextChanged);
            // 
            // TBRazaG
            // 
            this.TBRazaG.Location = new System.Drawing.Point(87, 245);
            this.TBRazaG.Name = "TBRazaG";
            this.TBRazaG.Size = new System.Drawing.Size(100, 20);
            this.TBRazaG.TabIndex = 5;
            this.TBRazaG.TextChanged += new System.EventHandler(this.TBRazaG_TextChanged);
            // 
            // TBPesoG
            // 
            this.TBPesoG.Location = new System.Drawing.Point(279, 193);
            this.TBPesoG.Name = "TBPesoG";
            this.TBPesoG.Size = new System.Drawing.Size(100, 20);
            this.TBPesoG.TabIndex = 6;
            this.TBPesoG.TextChanged += new System.EventHandler(this.TBPesoG_TextChanged);
            // 
            // TBTamannoG
            // 
            this.TBTamannoG.Location = new System.Drawing.Point(279, 219);
            this.TBTamannoG.Name = "TBTamannoG";
            this.TBTamannoG.Size = new System.Drawing.Size(100, 20);
            this.TBTamannoG.TabIndex = 7;
            this.TBTamannoG.TextChanged += new System.EventHandler(this.TBTamannoG_TextChanged);
            // 
            // TBNombreG
            // 
            this.TBNombreG.Location = new System.Drawing.Point(87, 193);
            this.TBNombreG.Name = "TBNombreG";
            this.TBNombreG.Size = new System.Drawing.Size(100, 20);
            this.TBNombreG.TabIndex = 8;
            this.TBNombreG.TextChanged += new System.EventHandler(this.TBNombreG_TextChanged);
            // 
            // TBColorG
            // 
            this.TBColorG.Location = new System.Drawing.Point(87, 219);
            this.TBColorG.Name = "TBColorG";
            this.TBColorG.Size = new System.Drawing.Size(100, 20);
            this.TBColorG.TabIndex = 9;
            this.TBColorG.TextChanged += new System.EventHandler(this.TBColorG_TextChanged);
            // 
            // LBNombreG
            // 
            this.LBNombreG.AutoSize = true;
            this.LBNombreG.Location = new System.Drawing.Point(12, 196);
            this.LBNombreG.Name = "LBNombreG";
            this.LBNombreG.Size = new System.Drawing.Size(44, 13);
            this.LBNombreG.TabIndex = 10;
            this.LBNombreG.Text = "Nombre";
            // 
            // LBColorPeloG
            // 
            this.LBColorPeloG.AutoSize = true;
            this.LBColorPeloG.Location = new System.Drawing.Point(12, 222);
            this.LBColorPeloG.Name = "LBColorPeloG";
            this.LBColorPeloG.Size = new System.Drawing.Size(69, 13);
            this.LBColorPeloG.TabIndex = 11;
            this.LBColorPeloG.Text = "Color de pelo";
            // 
            // LBRazaGato
            // 
            this.LBRazaGato.AutoSize = true;
            this.LBRazaGato.Location = new System.Drawing.Point(12, 248);
            this.LBRazaGato.Name = "LBRazaGato";
            this.LBRazaGato.Size = new System.Drawing.Size(32, 13);
            this.LBRazaGato.TabIndex = 12;
            this.LBRazaGato.Text = "Raza";
            // 
            // LBPesoG
            // 
            this.LBPesoG.AutoSize = true;
            this.LBPesoG.Location = new System.Drawing.Point(205, 196);
            this.LBPesoG.Name = "LBPesoG";
            this.LBPesoG.Size = new System.Drawing.Size(31, 13);
            this.LBPesoG.TabIndex = 13;
            this.LBPesoG.Text = "Peso";
            // 
            // LBTamanno
            // 
            this.LBTamanno.AutoSize = true;
            this.LBTamanno.Location = new System.Drawing.Point(205, 222);
            this.LBTamanno.Name = "LBTamanno";
            this.LBTamanno.Size = new System.Drawing.Size(46, 13);
            this.LBTamanno.TabIndex = 14;
            this.LBTamanno.Text = "Tamaño";
            // 
            // LBColorOG
            // 
            this.LBColorOG.AutoSize = true;
            this.LBColorOG.Location = new System.Drawing.Point(205, 248);
            this.LBColorOG.Name = "LBColorOG";
            this.LBColorOG.Size = new System.Drawing.Size(68, 13);
            this.LBColorOG.TabIndex = 15;
            this.LBColorOG.Text = "Color de ojos";
            // 
            // BTNuevo
            // 
            this.BTNuevo.Location = new System.Drawing.Point(343, 282);
            this.BTNuevo.Name = "BTNuevo";
            this.BTNuevo.Size = new System.Drawing.Size(75, 23);
            this.BTNuevo.TabIndex = 16;
            this.BTNuevo.Text = "Nuevo";
            this.BTNuevo.UseVisualStyleBackColor = true;
            this.BTNuevo.Click += new System.EventHandler(this.BTNuevo_Click);
            // 
            // BTGuardar
            // 
            this.BTGuardar.Location = new System.Drawing.Point(396, 196);
            this.BTGuardar.Name = "BTGuardar";
            this.BTGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTGuardar.TabIndex = 17;
            this.BTGuardar.Text = "Guardar";
            this.BTGuardar.UseVisualStyleBackColor = true;
            this.BTGuardar.Click += new System.EventHandler(this.BTGuardar_Click);
            // 
            // BTGL
            // 
            this.BTGL.Location = new System.Drawing.Point(396, 227);
            this.BTGL.Name = "BTGL";
            this.BTGL.Size = new System.Drawing.Size(75, 38);
            this.BTGL.TabIndex = 18;
            this.BTGL.Text = "Guardar en Lista";
            this.BTGL.UseVisualStyleBackColor = true;
            this.BTGL.Click += new System.EventHandler(this.BTGL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 317);
            this.Controls.Add(this.BTGL);
            this.Controls.Add(this.BTGuardar);
            this.Controls.Add(this.BTNuevo);
            this.Controls.Add(this.LBColorOG);
            this.Controls.Add(this.LBTamanno);
            this.Controls.Add(this.LBPesoG);
            this.Controls.Add(this.LBRazaGato);
            this.Controls.Add(this.LBColorPeloG);
            this.Controls.Add(this.LBNombreG);
            this.Controls.Add(this.TBColorG);
            this.Controls.Add(this.TBNombreG);
            this.Controls.Add(this.TBTamannoG);
            this.Controls.Add(this.TBPesoG);
            this.Controls.Add(this.TBRazaG);
            this.Controls.Add(this.TBColorOG);
            this.Controls.Add(this.LVDatosG);
            this.Controls.Add(this.BTBorrar);
            this.Controls.Add(this.BTModificar);
            this.Controls.Add(this.BTAnnadir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTAnnadir;
        private System.Windows.Forms.Button BTModificar;
        private System.Windows.Forms.Button BTBorrar;
        private System.Windows.Forms.ListView LVDatosG;
        private System.Windows.Forms.ColumnHeader CHNombre;
        private System.Windows.Forms.ColumnHeader CHColorPelo;
        private System.Windows.Forms.ColumnHeader CHRaza;
        private System.Windows.Forms.ColumnHeader CHPeso;
        private System.Windows.Forms.ColumnHeader CHTamannoGato;
        private System.Windows.Forms.ColumnHeader CHColorOGato;
        private System.Windows.Forms.TextBox TBColorOG;
        private System.Windows.Forms.TextBox TBRazaG;
        private System.Windows.Forms.TextBox TBPesoG;
        private System.Windows.Forms.TextBox TBTamannoG;
        private System.Windows.Forms.TextBox TBNombreG;
        private System.Windows.Forms.TextBox TBColorG;
        private System.Windows.Forms.Label LBNombreG;
        private System.Windows.Forms.Label LBColorPeloG;
        private System.Windows.Forms.Label LBRazaGato;
        private System.Windows.Forms.Label LBPesoG;
        private System.Windows.Forms.Label LBTamanno;
        private System.Windows.Forms.Label LBColorOG;
        private System.Windows.Forms.Button BTNuevo;
        private System.Windows.Forms.Button BTGuardar;
        private System.Windows.Forms.Button BTGL;
    }
}


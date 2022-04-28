namespace Actividad8._6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsttamatexto = new System.Windows.Forms.ToolStripMenuItem();
            this.tama12 = new System.Windows.Forms.ToolStripMenuItem();
            this.tama14 = new System.Windows.Forms.ToolStripMenuItem();
            this.tama16 = new System.Windows.Forms.ToolStripMenuItem();
            this.tama18 = new System.Windows.Forms.ToolStripMenuItem();
            this.tama20 = new System.Windows.Forms.ToolStripMenuItem();
            this.estiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subrayadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arial = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRoman = new System.Windows.Forms.ToolStripMenuItem();
            this.courierNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Negrita = new System.Windows.Forms.ToolStripButton();
            this.Cursiva = new System.Windows.Forms.ToolStripButton();
            this.Subrayado = new System.Windows.Forms.ToolStripButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tamatexto = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(379, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lsttamatexto,
            this.estiloToolStripMenuItem,
            this.letraToolStripMenuItem});
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // lsttamatexto
            // 
            this.lsttamatexto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tama12,
            this.tama14,
            this.tama16,
            this.tama18,
            this.tama20});
            this.lsttamatexto.Name = "lsttamatexto";
            this.lsttamatexto.Size = new System.Drawing.Size(152, 22);
            this.lsttamatexto.Text = "Tamaño";
            // 
            // tama12
            // 
            this.tama12.Name = "tama12";
            this.tama12.Size = new System.Drawing.Size(152, 22);
            this.tama12.Text = "12";
            this.tama12.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tama14
            // 
            this.tama14.Name = "tama14";
            this.tama14.Size = new System.Drawing.Size(152, 22);
            this.tama14.Text = "14";
            this.tama14.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tama16
            // 
            this.tama16.Name = "tama16";
            this.tama16.Size = new System.Drawing.Size(152, 22);
            this.tama16.Text = "16";
            this.tama16.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // tama18
            // 
            this.tama18.Name = "tama18";
            this.tama18.Size = new System.Drawing.Size(152, 22);
            this.tama18.Text = "18";
            this.tama18.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // tama20
            // 
            this.tama20.Name = "tama20";
            this.tama20.Size = new System.Drawing.Size(152, 22);
            this.tama20.Text = "20";
            this.tama20.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // estiloToolStripMenuItem
            // 
            this.estiloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritaToolStripMenuItem,
            this.cursivaToolStripMenuItem,
            this.subrayadoToolStripMenuItem});
            this.estiloToolStripMenuItem.Name = "estiloToolStripMenuItem";
            this.estiloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estiloToolStripMenuItem.Text = "Estilo";
            // 
            // negritaToolStripMenuItem
            // 
            this.negritaToolStripMenuItem.Name = "negritaToolStripMenuItem";
            this.negritaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negritaToolStripMenuItem.Text = "Negrita";
            this.negritaToolStripMenuItem.Click += new System.EventHandler(this.negritaToolStripMenuItem_Click);
            // 
            // cursivaToolStripMenuItem
            // 
            this.cursivaToolStripMenuItem.Name = "cursivaToolStripMenuItem";
            this.cursivaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursivaToolStripMenuItem.Text = "Cursiva";
            this.cursivaToolStripMenuItem.Click += new System.EventHandler(this.cursivaToolStripMenuItem_Click);
            // 
            // subrayadoToolStripMenuItem
            // 
            this.subrayadoToolStripMenuItem.Name = "subrayadoToolStripMenuItem";
            this.subrayadoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subrayadoToolStripMenuItem.Text = "Subrayado";
            this.subrayadoToolStripMenuItem.Click += new System.EventHandler(this.subrayadoToolStripMenuItem_Click);
            // 
            // letraToolStripMenuItem
            // 
            this.letraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arial,
            this.timesNewRoman,
            this.courierNew});
            this.letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            this.letraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.letraToolStripMenuItem.Text = "Letra";
            // 
            // arial
            // 
            this.arial.Name = "arial";
            this.arial.Size = new System.Drawing.Size(174, 22);
            this.arial.Text = "Arial";
            this.arial.Click += new System.EventHandler(this.arial_Click);
            // 
            // timesNewRoman
            // 
            this.timesNewRoman.Name = "timesNewRoman";
            this.timesNewRoman.Size = new System.Drawing.Size(174, 22);
            this.timesNewRoman.Text = "Times New Roman";
            this.timesNewRoman.Click += new System.EventHandler(this.timesNewRoman_Click);
            // 
            // courierNew
            // 
            this.courierNew.Name = "courierNew";
            this.courierNew.Size = new System.Drawing.Size(174, 22);
            this.courierNew.Text = "Courier New";
            this.courierNew.Click += new System.EventHandler(this.courierNew_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Negrita,
            this.Cursiva,
            this.Subrayado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Negrita
            // 
            this.Negrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Negrita.Image = ((System.Drawing.Image)(resources.GetObject("Negrita.Image")));
            this.Negrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Negrita.Name = "Negrita";
            this.Negrita.Size = new System.Drawing.Size(23, 22);
            this.Negrita.Text = "N";
            this.Negrita.Click += new System.EventHandler(this.Negrita_Click);
            // 
            // Cursiva
            // 
            this.Cursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cursiva.Image = ((System.Drawing.Image)(resources.GetObject("Cursiva.Image")));
            this.Cursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cursiva.Name = "Cursiva";
            this.Cursiva.Size = new System.Drawing.Size(23, 22);
            this.Cursiva.Text = "C";
            this.Cursiva.Click += new System.EventHandler(this.Cursiva_Click);
            // 
            // Subrayado
            // 
            this.Subrayado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Subrayado.Image = ((System.Drawing.Image)(resources.GetObject("Subrayado.Image")));
            this.Subrayado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Subrayado.Name = "Subrayado";
            this.Subrayado.Size = new System.Drawing.Size(23, 22);
            this.Subrayado.Text = "S";
            this.Subrayado.Click += new System.EventHandler(this.Subrayado_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Bradley Hand ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(153, 140);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(63, 19);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Etiqueta";
            // 
            // tamatexto
            // 
            this.tamatexto.FormattingEnabled = true;
            this.tamatexto.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.tamatexto.Location = new System.Drawing.Point(236, 90);
            this.tamatexto.Name = "tamatexto";
            this.tamatexto.Size = new System.Drawing.Size(108, 25);
            this.tamatexto.TabIndex = 3;
            this.tamatexto.Text = "Tamaño";
            this.tamatexto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(379, 343);
            this.Controls.Add(this.tamatexto);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lsttamatexto;
        private System.Windows.Forms.ToolStripMenuItem tama12;
        private System.Windows.Forms.ToolStripMenuItem tama14;
        private System.Windows.Forms.ToolStripMenuItem tama16;
        private System.Windows.Forms.ToolStripMenuItem tama18;
        private System.Windows.Forms.ToolStripMenuItem tama20;
        private System.Windows.Forms.ToolStripMenuItem estiloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subrayadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arial;
        private System.Windows.Forms.ToolStripMenuItem timesNewRoman;
        private System.Windows.Forms.ToolStripMenuItem courierNew;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Negrita;
        private System.Windows.Forms.ToolStripButton Cursiva;
        private System.Windows.Forms.ToolStripButton Subrayado;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox tamatexto;
    }
}


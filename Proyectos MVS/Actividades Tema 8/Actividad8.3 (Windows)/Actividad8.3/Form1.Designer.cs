namespace Actividad8._3
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
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnReducir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTamaTexto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRojoTexto = new System.Windows.Forms.Button();
            this.btnVerdeTexto = new System.Windows.Forms.Button();
            this.btnAzulTexto = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnOcularTexto = new System.Windows.Forms.Button();
            this.btnVerTexto = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.vNegrita = new System.Windows.Forms.CheckBox();
            this.vCursiva = new System.Windows.Forms.CheckBox();
            this.vSubrayado = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(31, 36);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(90, 24);
            this.btnAumentar.TabIndex = 0;
            this.btnAumentar.Text = "Aumentar";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnReducir
            // 
            this.btnReducir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReducir.Location = new System.Drawing.Point(31, 80);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(90, 23);
            this.btnReducir.TabIndex = 1;
            this.btnReducir.Text = "Reducir";
            this.btnReducir.UseVisualStyleBackColor = true;
            this.btnReducir.Click += new System.EventHandler(this.btnReducir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tamaño del texo";
            // 
            // lstTamaTexto
            // 
            this.lstTamaTexto.FormattingEnabled = true;
            this.lstTamaTexto.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26"});
            this.lstTamaTexto.Location = new System.Drawing.Point(31, 192);
            this.lstTamaTexto.Name = "lstTamaTexto";
            this.lstTamaTexto.Size = new System.Drawing.Size(121, 21);
            this.lstTamaTexto.TabIndex = 3;
            this.lstTamaTexto.TabStop = false;
            this.lstTamaTexto.SelectedIndexChanged += new System.EventHandler(this.lstTamaTexto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color del Texto";
            // 
            // btnRojoTexto
            // 
            this.btnRojoTexto.BackColor = System.Drawing.Color.Red;
            this.btnRojoTexto.Location = new System.Drawing.Point(31, 280);
            this.btnRojoTexto.Name = "btnRojoTexto";
            this.btnRojoTexto.Size = new System.Drawing.Size(35, 23);
            this.btnRojoTexto.TabIndex = 5;
            this.btnRojoTexto.UseVisualStyleBackColor = false;
            this.btnRojoTexto.Click += new System.EventHandler(this.btnRojoTexto_Click);
            // 
            // btnVerdeTexto
            // 
            this.btnVerdeTexto.BackColor = System.Drawing.Color.Lime;
            this.btnVerdeTexto.Location = new System.Drawing.Point(72, 279);
            this.btnVerdeTexto.Name = "btnVerdeTexto";
            this.btnVerdeTexto.Size = new System.Drawing.Size(34, 23);
            this.btnVerdeTexto.TabIndex = 6;
            this.btnVerdeTexto.UseVisualStyleBackColor = false;
            this.btnVerdeTexto.Click += new System.EventHandler(this.btnVerdeTexto_Click);
            // 
            // btnAzulTexto
            // 
            this.btnAzulTexto.BackColor = System.Drawing.Color.Blue;
            this.btnAzulTexto.Location = new System.Drawing.Point(112, 279);
            this.btnAzulTexto.Name = "btnAzulTexto";
            this.btnAzulTexto.Size = new System.Drawing.Size(35, 23);
            this.btnAzulTexto.TabIndex = 7;
            this.btnAzulTexto.UseVisualStyleBackColor = false;
            this.btnAzulTexto.Click += new System.EventHandler(this.btnAzulTexto_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.ForeColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(36, 127);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(30, 23);
            this.btnRojo.TabIndex = 8;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Lime;
            this.btnVerde.Location = new System.Drawing.Point(72, 127);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(34, 23);
            this.btnVerde.TabIndex = 9;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(112, 127);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(35, 23);
            this.btnAzul.TabIndex = 10;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnOcularTexto
            // 
            this.btnOcularTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcularTexto.Location = new System.Drawing.Point(31, 349);
            this.btnOcularTexto.Name = "btnOcularTexto";
            this.btnOcularTexto.Size = new System.Drawing.Size(121, 24);
            this.btnOcularTexto.TabIndex = 11;
            this.btnOcularTexto.Text = "Ocultar texto";
            this.btnOcularTexto.UseVisualStyleBackColor = true;
            this.btnOcularTexto.Click += new System.EventHandler(this.btnOcularTexto_Click);
            // 
            // btnVerTexto
            // 
            this.btnVerTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTexto.Location = new System.Drawing.Point(31, 393);
            this.btnVerTexto.Name = "btnVerTexto";
            this.btnVerTexto.Size = new System.Drawing.Size(121, 27);
            this.btnVerTexto.TabIndex = 12;
            this.btnVerTexto.Text = "Ver texto";
            this.btnVerTexto.UseVisualStyleBackColor = true;
            this.btnVerTexto.Click += new System.EventHandler(this.btnVerTexto_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(449, 102);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(43, 13);
            this.lblTexto.TabIndex = 13;
            this.lblTexto.Text = "TEXTO";
            // 
            // vNegrita
            // 
            this.vNegrita.AutoSize = true;
            this.vNegrita.Location = new System.Drawing.Point(387, 310);
            this.vNegrita.Name = "vNegrita";
            this.vNegrita.Size = new System.Drawing.Size(60, 17);
            this.vNegrita.TabIndex = 14;
            this.vNegrita.Text = "Negrita";
            this.vNegrita.UseVisualStyleBackColor = true;
            this.vNegrita.CheckedChanged += new System.EventHandler(this.vNegrita_CheckedChanged);
            // 
            // vCursiva
            // 
            this.vCursiva.AutoSize = true;
            this.vCursiva.Location = new System.Drawing.Point(387, 349);
            this.vCursiva.Name = "vCursiva";
            this.vCursiva.Size = new System.Drawing.Size(61, 17);
            this.vCursiva.TabIndex = 15;
            this.vCursiva.Text = "Cursiva";
            this.vCursiva.UseVisualStyleBackColor = true;
            this.vCursiva.CheckedChanged += new System.EventHandler(this.vCursiva_CheckedChanged);
            // 
            // vSubrayado
            // 
            this.vSubrayado.AutoSize = true;
            this.vSubrayado.Location = new System.Drawing.Point(387, 384);
            this.vSubrayado.Name = "vSubrayado";
            this.vSubrayado.Size = new System.Drawing.Size(77, 17);
            this.vSubrayado.TabIndex = 16;
            this.vSubrayado.Text = "Subrayado";
            this.vSubrayado.UseVisualStyleBackColor = true;
            this.vSubrayado.CheckedChanged += new System.EventHandler(this.vSubrayado_CheckedChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(700, 384);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(869, 446);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.vSubrayado);
            this.Controls.Add(this.vCursiva);
            this.Controls.Add(this.vNegrita);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnVerTexto);
            this.Controls.Add(this.btnOcularTexto);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnAzulTexto);
            this.Controls.Add(this.btnVerdeTexto);
            this.Controls.Add(this.btnRojoTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTamaTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReducir);
            this.Controls.Add(this.btnAumentar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnReducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstTamaTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRojoTexto;
        private System.Windows.Forms.Button btnVerdeTexto;
        private System.Windows.Forms.Button btnAzulTexto;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnOcularTexto;
        private System.Windows.Forms.Button btnVerTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.CheckBox vNegrita;
        private System.Windows.Forms.CheckBox vCursiva;
        private System.Windows.Forms.CheckBox vSubrayado;
        private System.Windows.Forms.Button btnCerrar;
    }
}


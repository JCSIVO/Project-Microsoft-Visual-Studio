namespace Actividad10._7
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
            this.btnleer = new System.Windows.Forms.Button();
            this.btnescribir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtfichero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(518, 117);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 0;
            this.btnleer.Text = "LEER";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btnescribir
            // 
            this.btnescribir.Location = new System.Drawing.Point(518, 160);
            this.btnescribir.Name = "btnescribir";
            this.btnescribir.Size = new System.Drawing.Size(75, 23);
            this.btnescribir.TabIndex = 1;
            this.btnescribir.Text = "ESCRIVBIR";
            this.btnescribir.UseVisualStyleBackColor = true;
            this.btnescribir.Click += new System.EventHandler(this.btnescribir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtfichero
            // 
            this.txtfichero.Location = new System.Drawing.Point(118, 160);
            this.txtfichero.Multiline = true;
            this.txtfichero.Name = "txtfichero";
            this.txtfichero.Size = new System.Drawing.Size(283, 172);
            this.txtfichero.TabIndex = 3;
            this.txtfichero.TextChanged += new System.EventHandler(this.txtfichero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfichero);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnescribir);
            this.Controls.Add(this.btnleer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btnescribir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtfichero;
        private System.Windows.Forms.Label label1;
    }
}


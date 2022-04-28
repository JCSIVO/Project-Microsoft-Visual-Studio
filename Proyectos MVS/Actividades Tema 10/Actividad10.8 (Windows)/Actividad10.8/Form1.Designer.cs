namespace Actividad10._8
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
            this.cajatexto = new System.Windows.Forms.TextBox();
            this.txtfichero = new System.Windows.Forms.TextBox();
            this.btnleer = new System.Windows.Forms.Button();
            this.btnescribir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajatexto
            // 
            this.cajatexto.Location = new System.Drawing.Point(20, 86);
            this.cajatexto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cajatexto.Name = "cajatexto";
            this.cajatexto.Size = new System.Drawing.Size(164, 26);
            this.cajatexto.TabIndex = 0;
            this.cajatexto.TextChanged += new System.EventHandler(this.cajatexto_TextChanged);
            // 
            // txtfichero
            // 
            this.txtfichero.Location = new System.Drawing.Point(20, 145);
            this.txtfichero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtfichero.Multiline = true;
            this.txtfichero.Name = "txtfichero";
            this.txtfichero.Size = new System.Drawing.Size(179, 127);
            this.txtfichero.TabIndex = 1;
            this.txtfichero.TextChanged += new System.EventHandler(this.txtfichero_TextChanged);
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(312, 80);
            this.btnleer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(125, 32);
            this.btnleer.TabIndex = 2;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btnescribir
            // 
            this.btnescribir.Location = new System.Drawing.Point(312, 122);
            this.btnescribir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnescribir.Name = "btnescribir";
            this.btnescribir.Size = new System.Drawing.Size(125, 32);
            this.btnescribir.TabIndex = 3;
            this.btnescribir.Text = "Escribir";
            this.btnescribir.UseVisualStyleBackColor = true;
            this.btnescribir.Click += new System.EventHandler(this.btnescribir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caracteres;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "letra A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnescribir);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.txtfichero);
            this.Controls.Add(this.cajatexto);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajatexto;
        private System.Windows.Forms.TextBox txtfichero;
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btnescribir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


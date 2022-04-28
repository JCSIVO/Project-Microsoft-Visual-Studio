namespace Actividad10._6
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
            this.txtfichero = new System.Windows.Forms.TextBox();
            this.txtboxfichero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(309, 32);
            this.btnleer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(125, 32);
            this.btnleer.TabIndex = 0;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btnescribir
            // 
            this.btnescribir.Location = new System.Drawing.Point(309, 72);
            this.btnescribir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnescribir.Name = "btnescribir";
            this.btnescribir.Size = new System.Drawing.Size(125, 32);
            this.btnescribir.TabIndex = 1;
            this.btnescribir.Text = "Escribir";
            this.btnescribir.UseVisualStyleBackColor = true;
            this.btnescribir.Click += new System.EventHandler(this.btnescribir_Click);
            // 
            // txtfichero
            // 
            this.txtfichero.Location = new System.Drawing.Point(12, 136);
            this.txtfichero.Multiline = true;
            this.txtfichero.Name = "txtfichero";
            this.txtfichero.Size = new System.Drawing.Size(308, 215);
            this.txtfichero.TabIndex = 2;
            this.txtfichero.TextChanged += new System.EventHandler(this.txtfichero_TextChanged);
            // 
            // txtboxfichero
            // 
            this.txtboxfichero.Location = new System.Drawing.Point(110, 32);
            this.txtboxfichero.Name = "txtboxfichero";
            this.txtboxfichero.Size = new System.Drawing.Size(100, 26);
            this.txtboxfichero.TabIndex = 3;
            this.txtboxfichero.TextChanged += new System.EventHandler(this.txtboxfichero_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.txtboxfichero);
            this.Controls.Add(this.txtfichero);
            this.Controls.Add(this.btnescribir);
            this.Controls.Add(this.btnleer);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.Button btnescribir;
        private System.Windows.Forms.TextBox txtfichero;
        private System.Windows.Forms.TextBox txtboxfichero;
    }
}


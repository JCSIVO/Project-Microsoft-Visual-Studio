namespace Actividad10._4
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
            this.txtbnombrefichero = new System.Windows.Forms.TextBox();
            this.txtcuadrofichero = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Fichero";
            // 
            // txtbnombrefichero
            // 
            this.txtbnombrefichero.Location = new System.Drawing.Point(240, 48);
            this.txtbnombrefichero.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbnombrefichero.Name = "txtbnombrefichero";
            this.txtbnombrefichero.Size = new System.Drawing.Size(164, 26);
            this.txtbnombrefichero.TabIndex = 1;
            this.txtbnombrefichero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcuadrofichero
            // 
            this.txtcuadrofichero.Location = new System.Drawing.Point(25, 121);
            this.txtcuadrofichero.Multiline = true;
            this.txtcuadrofichero.Name = "txtcuadrofichero";
            this.txtcuadrofichero.Size = new System.Drawing.Size(279, 208);
            this.txtcuadrofichero.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(319, 121);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(110, 39);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(319, 185);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(110, 43);
            this.btncerrar.TabIndex = 5;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 363);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcuadrofichero);
            this.Controls.Add(this.txtbnombrefichero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbnombrefichero;
        private System.Windows.Forms.TextBox txtcuadrofichero;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncerrar;
    }
}


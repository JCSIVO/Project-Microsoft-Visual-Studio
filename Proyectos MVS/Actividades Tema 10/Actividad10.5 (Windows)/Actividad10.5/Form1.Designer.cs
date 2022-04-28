namespace Actividad10._5
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
            this.cmbOS = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOS
            // 
            this.cmbOS.FormattingEnabled = true;
            this.cmbOS.Items.AddRange(new object[] {
            "IOS",
            "Windows",
            "CentOS",
            "Linux",
            "Android",
            "MacOS"});
            this.cmbOS.Location = new System.Drawing.Point(210, 53);
            this.cmbOS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbOS.Name = "cmbOS";
            this.cmbOS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOS.Size = new System.Drawing.Size(199, 26);
            this.cmbOS.TabIndex = 0;
            this.cmbOS.Text = "Seleccione un OS";
            this.cmbOS.SelectedIndexChanged += new System.EventHandler(this.cmbOS_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(22, 53);
            this.lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(160, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Sistema Operativo:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(135, 121);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(166, 54);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 209);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmbOS);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOS;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnguardar;
    }
}


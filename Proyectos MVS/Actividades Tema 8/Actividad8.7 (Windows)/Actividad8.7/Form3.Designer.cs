namespace Actividad8._7
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.lblmostrar = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.listaPersona = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrar.Location = new System.Drawing.Point(13, 41);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(440, 55);
            this.lblmostrar.TabIndex = 0;
            this.lblmostrar.Text = "Mostrar Personas";
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(324, 121);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(84, 33);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(324, 160);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(84, 31);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(324, 333);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(79, 29);
            this.btncerrar.TabIndex = 4;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // listaPersona
            // 
            this.listaPersona.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listaPersona.Location = new System.Drawing.Point(23, 99);
            this.listaPersona.Name = "listaPersona";
            this.listaPersona.Size = new System.Drawing.Size(229, 250);
            this.listaPersona.TabIndex = 6;
            this.listaPersona.UseCompatibleStateImageBehavior = false;
            this.listaPersona.View = System.Windows.Forms.View.List;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 385);
            this.Controls.Add(this.listaPersona);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblmostrar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmostrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.ListView listaPersona;
    }
}
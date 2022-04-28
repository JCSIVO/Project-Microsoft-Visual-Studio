namespace Actividad8._8
{
    partial class Form2
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
            this.lblletra = new System.Windows.Forms.Label();
            this.lbltamano = new System.Windows.Forms.Label();
            this.lblestilo = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.tipoletra = new System.Windows.Forms.CheckedListBox();
            this.tamano = new System.Windows.Forms.CheckedListBox();
            this.estilo = new System.Windows.Forms.CheckedListBox();
            this.color = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblletra
            // 
            this.lblletra.AutoSize = true;
            this.lblletra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblletra.Location = new System.Drawing.Point(20, 60);
            this.lblletra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblletra.Name = "lblletra";
            this.lblletra.Size = new System.Drawing.Size(106, 17);
            this.lblletra.TabIndex = 0;
            this.lblletra.Text = "Tipo De Letra";
            // 
            // lbltamano
            // 
            this.lbltamano.AutoSize = true;
            this.lbltamano.Location = new System.Drawing.Point(264, 60);
            this.lbltamano.Name = "lbltamano";
            this.lbltamano.Size = new System.Drawing.Size(66, 17);
            this.lbltamano.TabIndex = 2;
            this.lbltamano.Text = "Tamaño";
            // 
            // lblestilo
            // 
            this.lblestilo.AutoSize = true;
            this.lblestilo.Location = new System.Drawing.Point(23, 197);
            this.lblestilo.Name = "lblestilo";
            this.lblestilo.Size = new System.Drawing.Size(48, 17);
            this.lblestilo.TabIndex = 5;
            this.lblestilo.Text = "Estilo";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(265, 197);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(120, 17);
            this.lblcolor.TabIndex = 6;
            this.lblcolor.Text = "Color Del Texto";
            // 
            // tipoletra
            // 
            this.tipoletra.FormattingEnabled = true;
            this.tipoletra.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Courier New"});
            this.tipoletra.Location = new System.Drawing.Point(26, 80);
            this.tipoletra.Name = "tipoletra";
            this.tipoletra.Size = new System.Drawing.Size(120, 84);
            this.tipoletra.TabIndex = 8;
            this.tipoletra.SelectedIndexChanged += new System.EventHandler(this.tipoletra_SelectedIndexChanged);
            // 
            // tamano
            // 
            this.tamano.FormattingEnabled = true;
            this.tamano.Items.AddRange(new object[] {
            "9       ",
            "11     ",
            "12     ",
            "14"});
            this.tamano.Location = new System.Drawing.Point(267, 91);
            this.tamano.Name = "tamano";
            this.tamano.Size = new System.Drawing.Size(118, 84);
            this.tamano.TabIndex = 9;
            this.tamano.SelectedIndexChanged += new System.EventHandler(this.tamano_SelectedIndexChanged);
            // 
            // estilo
            // 
            this.estilo.FormattingEnabled = true;
            this.estilo.Items.AddRange(new object[] {
            "Negrita",
            "Cursiva",
            "Subrayado"});
            this.estilo.Location = new System.Drawing.Point(26, 223);
            this.estilo.Name = "estilo";
            this.estilo.Size = new System.Drawing.Size(120, 84);
            this.estilo.TabIndex = 10;
            this.estilo.SelectedIndexChanged += new System.EventHandler(this.estilo_SelectedIndexChanged);
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul"});
            this.color.Location = new System.Drawing.Point(268, 223);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(120, 84);
            this.color.TabIndex = 11;
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 343);
            this.Controls.Add(this.color);
            this.Controls.Add(this.estilo);
            this.Controls.Add(this.tamano);
            this.Controls.Add(this.tipoletra);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblestilo);
            this.Controls.Add(this.lbltamano);
            this.Controls.Add(this.lblletra);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblletra;
        private System.Windows.Forms.Label lbltamano;
        private System.Windows.Forms.Label lblestilo;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.CheckedListBox tipoletra;
        private System.Windows.Forms.CheckedListBox tamano;
        private System.Windows.Forms.CheckedListBox estilo;
        private System.Windows.Forms.CheckedListBox color;
    }
}
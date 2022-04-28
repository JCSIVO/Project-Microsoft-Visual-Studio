using System;

namespace Actividad8._4
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
            this.lblOperando1 = new System.Windows.Forms.Label();
            this.lblOperando2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txtb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOperando1
            // 
            this.lblOperando1.AutoSize = true;
            this.lblOperando1.Location = new System.Drawing.Point(13, 24);
            this.lblOperando1.Name = "lblOperando1";
            this.lblOperando1.Size = new System.Drawing.Size(82, 15);
            this.lblOperando1.TabIndex = 0;
            this.lblOperando1.Text = "Operando 1";
            // 
            // lblOperando2
            // 
            this.lblOperando2.AutoSize = true;
            this.lblOperando2.Location = new System.Drawing.Point(13, 58);
            this.lblOperando2.Name = "lblOperando2";
            this.lblOperando2.Size = new System.Drawing.Size(79, 15);
            this.lblOperando2.TabIndex = 1;
            this.lblOperando2.Text = "Operando2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 93);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(16, 129);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(229, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 158);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(41, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(63, 158);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(41, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(110, 158);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(41, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(157, 158);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(41, 23);
            this.btnSuma.TabIndex = 10;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(204, 158);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(41, 23);
            this.btnRestar.TabIndex = 11;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 188);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(41, 23);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(63, 187);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(41, 23);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(110, 188);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(41, 23);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(157, 187);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(41, 23);
            this.btnMultiplicar.TabIndex = 15;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(204, 188);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(41, 23);
            this.btnDividir.TabIndex = 16;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 217);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(41, 23);
            this.btn1.TabIndex = 17;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(63, 216);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(41, 23);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(110, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(41, 23);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(157, 216);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(88, 54);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 247);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(135, 23);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(120, 21);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(100, 23);
            this.txtb1.TabIndex = 25;
            this.txtb1.TextChanged += new System.EventHandler(this.txtb1_TextChanged);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(120, 58);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(100, 23);
            this.txtb2.TabIndex = 26;
            this.txtb2.TextChanged += new System.EventHandler(this.txtb2_TextChanged);
            // 
            // txtb3
            // 
            this.txtb3.Location = new System.Drawing.Point(120, 93);
            this.txtb3.Name = "txtb3";
            this.txtb3.Size = new System.Drawing.Size(100, 23);
            this.txtb3.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 281);
            this.Controls.Add(this.txtb3);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperando2);
            this.Controls.Add(this.lblOperando1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private System.Windows.Forms.Label lblOperando1;
        private System.Windows.Forms.Label lblOperando2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txtb3;
    }
}


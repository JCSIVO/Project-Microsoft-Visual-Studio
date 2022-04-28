using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 50;
        }

        private void btnReducir_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 50;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void lstTamaTexto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTexto.Font = new Font(lblTexto.Font.FontFamily,lstTamaTexto.SelectedIndex+ 'F');
        }

        private void btnRojoTexto_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Red;
        }

        private void btnVerdeTexto_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Green;
        }

        private void btnAzulTexto_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = Color.Blue;
        }

        private void btnOcularTexto_Click(object sender, EventArgs e)
        {
            lblTexto.Visible = false;
        }

        private void btnVerTexto_Click(object sender, EventArgs e)
        {
            lblTexto.Visible = true;
        }

        private void vNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if (vNegrita.Checked)
            {
                lblTexto.Font = new Font(lblTexto.Font, lblTexto.Font.Style | FontStyle.Bold);
            }
            else
            {
                lblTexto.Font = new Font(lblTexto.Font, lblTexto.Font.Style ^ FontStyle.Bold);
            }
        }

        private void vCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (vCursiva.Checked)
            {
                lblTexto.Font = new Font(lblTexto.Font, lblTexto.Font.Style | FontStyle.Italic);
            }
            else
            {
                lblTexto.Font = new Font(lblTexto.Font, lblTexto.Font.Style ^ FontStyle.Italic);
            }
        }

        private void vSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (vSubrayado.Checked)
            {
                lblTexto.Font = new Font(lblTexto.Font, lblTexto.Font.Style | FontStyle.Underline);
            }
            else
            {
                lblTexto.Font = new Font(lblTexto.Font, lblTexto.Font.Style ^ FontStyle.Underline);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

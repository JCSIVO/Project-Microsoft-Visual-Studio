using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Negrita_Click(object sender, EventArgs e)
        {
            if (Negrita.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style | FontStyle.Bold);
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style ^ FontStyle.Bold);
            }
        }

        private void Cursiva_Click(object sender, EventArgs e)
        {
            if (Cursiva.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style | FontStyle.Italic);
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style ^ FontStyle.Italic);
            }
        }

        private void Subrayado_Click(object sender, EventArgs e)
        {
            if (Subrayado.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style | FontStyle.Underline);
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style ^ FontStyle.Underline);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex+ 'F');
        }
    

        private void negritaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Negrita.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style | FontStyle.Bold);
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style ^ FontStyle.Bold);
            }
        }

        private void cursivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cursiva.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style | FontStyle.Italic);
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style ^ FontStyle.Italic);
            }
        }

        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Subrayado.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style | FontStyle.Underline);
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font, lbl1.Font.Style ^ FontStyle.Underline);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tama12.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F');
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F'); ;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (tama14.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F');
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F'); ;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (tama16.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F');
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F'); ;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (tama18.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F');
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F'); ;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (tama20.CheckOnClick)
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F');
            }
            else
            {
                lbl1.Font = new Font(lbl1.Font.FontFamily, tamatexto.SelectedIndex + 'F'); 
            }
        }

        private void arial_Click(object sender, EventArgs e)
        {
            if (arial.CheckOnClick)
            {
                lbl1.Font = new Font("arial",15);
            }
            else
            {
                lbl1.Font = new Font("arial", 15);
            }
        }

        private void timesNewRoman_Click(object sender, EventArgs e)
        {
            if (arial.CheckOnClick)
            {
                lbl1.Font = new Font("Times", 15);
            }
            else
            {
                lbl1.Font = new Font("Times", 15);
            }

        }

        private void courierNew_Click(object sender, EventArgs e)
        {
            if (arial.CheckOnClick)
            {
                lbl1.Font = new Font("Courier", 15);
            }
            else
            {
                lbl1.Font = new Font("Courier", 15);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8._8
{
    public partial class editor : Form
    {
        string archivo;
        editor Formnueva = null;
        public editor()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
                    }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnfuente_Click(object sender, EventArgs e)
        {
            Form2 fuente = new Form2();
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Has echo click en Fuene");
            }
            else
            {
                MessageBox.Show("No has pulasdo nada");
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    if(MessageBox.Show("donde lo quires copiar", "copiar ejemplo", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                    }
                    richTextBox1.Paste();
                }
            }
        }

        private void toolStripButton1nuevo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripButton1Fuente_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1tamano_Click(object sender, EventArgs e)
        {

        }
    }
}

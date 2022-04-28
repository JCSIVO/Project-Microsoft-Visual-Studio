using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEuros.Text.CompareTo("") == 0 && txtDolares.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error, tanto el cuadro de texto como el de Dolares esta vacio", "Error cuadros vacios", MessageBoxButtons.OK);

            }
            else if (txtEuros.Text.CompareTo("") > 0 && txtDolares.Text.CompareTo("") == 0)
            {
                txtDolares.Text = (int.Parse(txtEuros.Text) * 1.3194).ToString();
            }
            else if (txtEuros.Text.CompareTo("") == 0 && txtDolares.Text.CompareTo("") > 0)
            {
                txtEuros.Text = (int.Parse(txtDolares.Text) / 1.3194).ToString();
            }
            
        }
    }
}

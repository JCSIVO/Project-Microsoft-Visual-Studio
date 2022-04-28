using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Actividad10._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string os = null;
            os = Convert.ToString(cmbOS.Text);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string os = null;
            os = Convert.ToString(cmbOS.Text);
            string path = @"C:\Users\JOSE CONEJERO\Documents\Visual Studio 2015\Actividad10.5 (Windows)\items.txt";
            File.WriteAllText(path, cmbOS.Text);
            MessageBox.Show("Seleccion correcta");
            this.Close();
        }
    }
}

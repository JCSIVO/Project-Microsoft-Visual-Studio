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

namespace Actividad10._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = null;
            string fichero = null;
            fichero = Convert.ToString(txtbnombrefichero.Text);
            texto = Convert.ToString(txtcuadrofichero.Text);
        }

       public void btnguardar_Click(object sender, EventArgs e)
        {
            string texto = null;
            string fichero = null ;
            fichero = Convert.ToString(txtbnombrefichero.Text);
            texto = Convert.ToString(txtcuadrofichero.Text);
            string path = @"C:\Users\JOSE CONEJERO\Documents\Visual Studio 2015\Actividad10.4 (Windows)\Actividad10.4"+fichero+".txt";
            File.WriteAllText(path, txtcuadrofichero.Text);
            this.Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace Actividad10._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            string FileContent = File.ReadAllText(@"C:\Users\JOSE CONEJERO\Documents\Visual Studio 2015\Actividad10.6 (Windows)\ejemplo.txt");
            txtfichero.Text = FileContent;
        }

        private void btnescribir_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\JOSE CONEJERO\Documents\Visual Studio 2015\Actividad10.6 (Windows)\ejemplo.txt", "Buenos dias");
        }

        private void txtfichero_TextChanged(object sender, EventArgs e)
        {
            //string FileContent = File.ReadAllText(@"C:\Users\JOSE CONEJERO\Documents\Visual Studio 2015\Actividad10.6 (Windows)\ejemplo.txt");
            //txtboxfichero.Text = FileContent;
            for (int i = 0; i <= txtfichero.TextLength; i++)
            {
                label1.Text = i.ToString();
            }
        }
    
    }
}

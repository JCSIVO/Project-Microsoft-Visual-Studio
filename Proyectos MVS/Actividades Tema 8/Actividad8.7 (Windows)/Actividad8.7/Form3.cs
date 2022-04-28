using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8._7
{
    public partial class Form3 : Form
    {
        Form1 padre = null;
        Form2 FormNueva = null;
        public Form3()
        {
            InitializeComponent();
        }
        public void FormPadre (Form1 padre)
        {
            this.padre = padre;
            int i = 0;
            Persona aux;
            while((aux = padre[i]) != null)
            {
                listaPersona.Items.Add(padre[i].ToString());
                i++;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            listaPersona.Items.RemoveAt(0);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (FormNueva == null)
            {
                FormNueva = new Form2();
            }
            FormNueva.Show();
            btnmodificar.Enabled = true;
        }
    }
}

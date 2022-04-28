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
    public partial class Form2 : Form
    {
        Form1 padre;
        public Form2()
        {
            InitializeComponent();
        }
        public void FormPadre (Form1 padre)
        {
            this.padre = padre;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*Persona Nueva = new Persona(txtNombre.Text, txtApellidos.Text, txtTelefono.Text);
            padre[padre.NumeroPersonas()] = Nueva;
            this.Hide();*/
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Persona nueva = new Persona(txtNombre.Text, txtApellidos.Text, txtTelefono.Text);
            padre[padre.NumeroPersonas()] = nueva;
            this.Hide();
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            //btnmodificar.Visible = false;
        }
    }
}

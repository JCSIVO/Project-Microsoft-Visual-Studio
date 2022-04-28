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
    public partial class Form1 : Form
    {
        Form2 FormNueva = null;
        Form3 FormMostrar = null;
        
        Persona[] personas;
        const int MAX = 100;
        int numPersonas;
        public Form1()
        {
            personas = new Persona[MAX];
            numPersonas = 0;
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormNueva == null)
            {
                FormNueva = new Form2();
            }
            FormNueva.Show();
            FormNueva.FormPadre(this);
        }

        private void mostrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrar = new Form3();
            FormMostrar.Show(this);
            FormMostrar.FormPadre(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int TotalPersonas()
        {
            return personas.Length;
        }
        public int NumeroPersonas()
        {
            return numPersonas;
        }
        public Persona this [int pos]
        {
            set
            {
                if (pos < MAX)
                {
                    personas[pos] = value;
                    numPersonas++;
                }
                else
                {
                    MessageBox.Show("Error,Imposible agregar mas personas", "Error en inserccion", MessageBoxButtons.OK);
                }
            }
            get
            {
                if (pos < personas.Length)
                {
                    return personas[pos];
                }
                else
                {
                    return null;
                }

            }
 
           
        }
    }
}

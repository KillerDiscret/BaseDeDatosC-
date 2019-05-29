using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        nPersona persona = new nPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text!=""&&txtEdad.Text!=""&&txtNombre.Text!="")
            {
                int pedad = Convert.ToInt32(txtEdad.Text);
                MessageBox.Show(persona.RegistrarPersona(txtCodigo.Text,txtNombre.Text,pedad));
                txtCodigo.Clear();
                txtEdad.Clear();
                txtNombre.Clear();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

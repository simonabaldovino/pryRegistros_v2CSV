using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRegistros_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmCargarClientes();
            formulario.MdiParent = this;
            formulario.Show();

        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoClientes(); 
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void listadoDeClienetsDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmClientesDeudores();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ClientesOrdenados();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por Simona Baldovino", "Acerca de");
        }
    }
}

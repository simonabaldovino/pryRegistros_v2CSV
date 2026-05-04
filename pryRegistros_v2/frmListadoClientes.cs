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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsArchivoClientes x = new clsArchivoClientes();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvConsultaDatos);
            lblCantClientes.Text = x.CantidadClientes().ToString();
            lblTotDeuda.Text = x.DeudaClientes().ToString();
            lblPromDeuda.Text = x.PromedioDeuda().ToString();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente.");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivos();
            MessageBox.Show("Se ordenó el archivo");
            x.Listar(dgvConsultaDatos);
        }
    }
}

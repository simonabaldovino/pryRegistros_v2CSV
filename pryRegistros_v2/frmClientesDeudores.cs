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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
       
        clsArchivoClientes x = new clsArchivoClientes();

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            x.Listar(dgvConsultaDatos);
           // lblCantClientes2.Text = x.CantidadClientes2().ToString();
            lblTotDeuda.Text = x.DeudaClientes2().ToString();
            lblPromDeuda.Text = x.PromedioDeuda2().ToString();



        }
    }
}

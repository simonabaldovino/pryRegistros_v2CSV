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
    public partial class ClientesOrdenados : Form
    {
        public ClientesOrdenados()
        {
            InitializeComponent();
        }

        clsArchivoClientes x = new clsArchivoClientes();

        private void btnListar_Click(object sender, EventArgs e)
        {
            // validacion q se haya seleccionado algo 

            if (cboCampo.Text != "")
            {
                if (cboModo.Text != "")
                {
                    x.CargarDesdeArchivo(); 
                    x.OrdenarClientes(cboCampo.Text, cboModo.Text);

                    dgvClientes.Rows.Clear();

                    for (int i = 0; i < x.CantidadClientes; i++)
                    {
                        dgvClientes.Rows.Add(
                            x.VectorClientes[i].Codigo,
                            x.VectorClientes[i].Nombre,
                            x.VectorClientes[i].Deuda,
                            x.VectorClientes[i].Limite
                        );
                    }
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAlquilerVehiculos
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        ACds ds = new ACds();
        ACdsTableAdapters.QTA procedimientos = new ACdsTableAdapters.QTA();
        ACdsTableAdapters.ClienteTableAdapter tcliente = new ACdsTableAdapters.ClienteTableAdapter();


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            procedimientos.Cliente_Insert(txtCI.Text, txtNombre.Text, txtTelefono.Text, cmbGarantia.Text);
            tcliente.Fill(ds.Cliente);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tcliente.Fill(ds.Cliente);
            dgvLista.DataSource = ds.Cliente;

      
        }
    }
}

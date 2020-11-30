using System;
using System.Windows.Forms;

namespace PryAlquilerVehiculos
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }
        ACds ds = new ACds();
        ACdsTableAdapters.ClienteTableAdapter tcliente = new ACdsTableAdapters.ClienteTableAdapter();
        ACdsTableAdapters.AutomovilTableAdapter tautomovil = new ACdsTableAdapters.AutomovilTableAdapter();
        ACdsTableAdapters.ChoferTableAdapter tchofer = new ACdsTableAdapters.ChoferTableAdapter();
        ACdsTableAdapters.PrestamoTableAdapter tprestamo = new ACdsTableAdapters.PrestamoTableAdapter();
        ACdsTableAdapters.DetallePrestamoTableAdapter tdprestamo = new ACdsTableAdapters.DetallePrestamoTableAdapter();
        ACdsTableAdapters.QTA sp = new ACdsTableAdapters.QTA();
        
        int ultimo;

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            

            tcliente.Fill(ds.Cliente);
            ClienteCmb.DataSource = ds.Cliente;
            ClienteCmb.DisplayMember = "NombreCompleto";
            ClienteCmb.ValueMember = "idCliente";

            tautomovil.Fill(ds.Automovil);
            AutomovilComboBox.DataSource = ds.Automovil;
            AutomovilComboBox.DisplayMember = "Placa";
            AutomovilComboBox.ValueMember = "idAutomovil";
            //MessageBox.Show(ds.Tables["Automovil"].Rows[0].ItemArray[2].ToString());
            //MessageBox.Show(ds.Automovil.Rows[0].ItemArray[2].ToString());
            //MessageBox.Show(ds.Tables["Automovil"].Rows[0]["Modelo"].ToString());
            MessageBox.Show(ds.Automovil.Rows[0]["Modelo"].ToString());
            tchofer.Fill(ds.Chofer);
            ChoferComboBox.DataSource = ds.Chofer;
            ChoferComboBox.DisplayMember = "NombreCompleto";
            ChoferComboBox.ValueMember = "idChofer";

            dgvDetalle.Columns.Add("idauto", "idAuto");
            dgvDetalle.Columns.Add("placa", "Placa-Auto");
            dgvDetalle.Columns["idauto"].Visible = false;

            //dgvDetalle.Columns.Add("idPrestamo", "Prestamo");
            dgvDetalle.Columns.Add("dias", "Dias");
            dgvDetalle.Columns.Add("sub", "SubTot");
            dgvDetalle.Columns.Add("idChofer", "IdChofer");
            dgvDetalle.Columns["idChofer"].Visible = false;
            dgvDetalle.Columns.Add("chofernombre", "Chofer");

            limpiard(PrestamoPanel);
            limpiard(DetallePanel);
            
            //tprestamo.Fill(ds.Prestamo);
            //ultimo = Convert.ToInt32(ds.Prestamo.Rows[ds.Prestamo.Rows.Count-1].ItemArray[0])+1;
            //IdLabel.Text = ultimo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Datos(PrestamoPanel) | Datos(DetallePanel))
            {
                sp.Prestamo_Insert(FechaDataTimer.Value, CiudadCmb.Text, Convert.ToInt32(TotalTexbox.Text), Convert.ToInt32(ClienteCmb.SelectedValue), true); ;
                tprestamo.Fill(ds.Prestamo);
                ultimo = Convert.ToInt32(ds.Prestamo.Rows[ds.Prestamo.Rows.Count - 1].ItemArray[0]);
                IdLabel.Text = ultimo.ToString();
                for (int i = 0; i < dgvDetalle.Rows.Count; i++)
                {
                    sp.DetallePrestamo_Insert(Convert.ToInt32(dgvDetalle.Rows[i].Cells[0].Value),
                                              ultimo,
                                              Convert.ToInt32(dgvDetalle.Rows[i].Cells[2].Value),
                                              dgvDetalle.Rows[i].Cells[3].Value.ToString(),
                                              Convert.ToInt32(dgvDetalle.Rows[i].Cells[4].Value));
                }
            }
            else MessageBox.Show("Fantan datos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Datos(DetallePanel))
            {
                dgvDetalle.Rows.Add(AutomovilComboBox.SelectedValue, AutomovilComboBox.Text, DiasPNumericUpDown.Value, SubTotalTextBox.Text, ChoferComboBox.SelectedValue, ChoferComboBox.Text);
                limpiard(DetallePanel);
            }
            else MessageBox.Show("Faltan datos");
        }

        private void limpiard(Control mycontrol)
        {
            foreach (Control cComprobar in mycontrol.Controls)
            {
                cComprobar.Text = "";
            }
        }

        private bool Datos(Control mycontrol)
        {
            bool condato = false;
            foreach (Control cComprobar in mycontrol.Controls)
            {
                if (cComprobar.Text == String.Empty)
                {
                    condato = false;
                    break;
                }
                else
                    condato = true;
            }
            return condato;
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            frmCliente fcliente = new frmCliente();
            fcliente.ShowDialog();
        }

        private void AutoButton_Click(object sender, EventArgs e)
        {
            frmAutomovil fauto = new frmAutomovil();
            fauto.ShowDialog();
        }

        private void ChoferButton_Click(object sender, EventArgs e)
        {
            frmChofer fchofer = new frmChofer();
            fchofer.ShowDialog();
        }
    }
}

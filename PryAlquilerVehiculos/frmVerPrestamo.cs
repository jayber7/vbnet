using System;
using System.Windows.Forms;

namespace PryAlquilerVehiculos
{
    public partial class frmVerPrestamo : Form
    {
        public frmVerPrestamo()
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
        ACdsTableAdapters.DetallePrestamo_SelectTableAdapter pds = new ACdsTableAdapters.DetallePrestamo_SelectTableAdapter();
        int ultimo;

        private void frmVerPrestamo_Load(object sender, EventArgs e)
        {
            tcliente.Fill(ds.Cliente);
            
            ClienteCmb.DataSource = ds.Cliente;
            ClienteCmb.DisplayMember = "NombreCompleto";
            ClienteCmb.ValueMember = "idCliente";

            tautomovil.Fill(ds.Automovil);
            AutomovilComboBox.DataSource = ds.Automovil;
            AutomovilComboBox.DisplayMember = "Placa";
            AutomovilComboBox.ValueMember = "idAutomovil";

            tchofer.Fill(ds.Chofer);
            ChoferComboBox.DataSource = ds.Chofer;
            ChoferComboBox.DisplayMember = "NombreCompleto";
            ChoferComboBox.ValueMember = "idChofer";

            limpiard(PrestamoPanel);
            limpiard(DetallePanel);
            
            tprestamo.Fill(ds.Prestamo);
            PrestamoDataGridView.DataSource = ds.Prestamo;
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

        private void PrestamoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ACds.Tables.Add(d);
            FechaDataTimer.Value = Convert.ToDateTime(PrestamoDataGridView.SelectedRows[0].Cells[1].Value.ToString());
            CiudadCmb.Text = PrestamoDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ClienteCmb.SelectedValue = Convert.ToInt32(PrestamoDataGridView.SelectedRows[0].Cells[4].Value.ToString());
            TotalTexbox.Text = PrestamoDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            
            pds.Fill(ds.DetallePrestamo_Select,null, Convert.ToInt32(PrestamoDataGridView.SelectedRows[0].Cells[0].Value.ToString()), null,null,null);
            dgvDetalle.DataSource = ds.DetallePrestamo_Select;
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AutomovilComboBox.Text= BdAlquilerCochesDataSet.DetallePrestamo_SelectDataTable;
            //MessageBox.Show(e.RowIndex.ToString());
            AutomovilComboBox.SelectedValue = Convert.ToInt32(dgvDetalle.SelectedRows[0].Cells["IDAutomovil"].Value);
            ChoferComboBox.SelectedValue= Convert.ToInt32(dgvDetalle.SelectedRows[0].Cells["IdChofer"].Value);
            DiasPNumericUpDown.Value= Convert.ToInt32(dgvDetalle.SelectedRows[0].Cells["DiasPrestamo"].Value);
            SubTotalTextBox.Text = dgvDetalle.SelectedRows[0].Cells["SubtotalPrestamo"].Value.ToString();
            //IDAutomovil IdPrestamo DiasPrestamo SubtotalPrestamo IdChofer
        }
    }
}

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
    public partial class frmAutomovil : Form
    {
        public frmAutomovil()
        {
            InitializeComponent();
        }
        ACds ds = new ACds();
        ACdsTableAdapters.AutomovilTableAdapter TAutomovil = new ACdsTableAdapters.AutomovilTableAdapter();
        ACdsTableAdapters.QTA spAutoInsert = new ACdsTableAdapters.QTA();


        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            var fotoMS = new System.IO.MemoryStream();
            string mensaje = "";
            FotoPictureBox.Image.Save(fotoMS, System.Drawing.Imaging.ImageFormat.Jpeg);
            spAutoInsert.Automovil_Insert(PlacaTextBox.Text, ModeloComboBox.Text, 
                                        Convert.ToInt32(CapacidadNumericUpDown.Value), 
                                        ColorComboBox.Text, 
                                        TCombustibleomboBox.Text, 
                                        "activado", 
                                        fotoMS.GetBuffer(), 
                                        Convert.ToInt32(MontoNumericUpDown.Value),
                                        ref mensaje);
            TAutomovil.Fill(ds.Automovil);
            Limpiar();
        }

        private void frmAutomovil_Load(object sender, EventArgs e)
        {
            TAutomovil.Fill(ds.Automovil);
            //DataRow drow = ds.Automovil.Where(row => row.Field<int>("IdAutomovil") == 4).FirstOrDefault();
            
            dgvListaAutomovil.DataSource = ds.Automovil;
            //dgvListaAutomovil.DataSource = drow;
            Limpiar();
        }

        private void Limpiar()
        {
            foreach (Control cComprobar in this.panel1.Controls)
            {
                cComprobar.Text = "";
            }
        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //FotoPictureBox.Image= new Bitmap (openFileDialog1.FileName);
                //FotoPictureBox.ImageLocation = openFileDialog1.FileName;
                FotoPictureBox.Image= System.Drawing.Image.FromFile(openFileDialog1.FileName);

            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            dv = ds.Automovil.DefaultView;
            dv.RowFilter = string.Format("CONVERT(IdAutomovil, System.String) LIKE '%{0}%'", FiltroTextBox.Text);
            dv.RowFilter = "Modelo like '" + FiltroTextBox.Text + "%'";
            if (dv.Count != 0)
            {
                dgvListaAutomovil.DataSource = dv;

            }
            else
                dgvListaAutomovil.DataSource = null;

        }
    }
}

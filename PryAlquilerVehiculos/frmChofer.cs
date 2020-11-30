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
    public partial class frmChofer : Form
    {

        public frmChofer()
        {
            InitializeComponent();
        }

        ACds ds = new ACds();
        ACdsTableAdapters.QTA spchofer = new ACdsTableAdapters.QTA();
        ACdsTableAdapters.ChoferTableAdapter tchofer = new ACdsTableAdapters.ChoferTableAdapter();
        private void FotoPictureBox_Click(object sender, EventArgs e)
        {
            var df = new OpenFileDialog();
            df.Filter = "|*.jpg";
            if (df.ShowDialog() == DialogResult.OK)
            {
                FotoPictureBox.Image = System.Drawing.Image.FromFile(df.FileName);

            }
        }

        private void frmChofer_Load(object sender, EventArgs e)
        {
            tchofer.Fill(ds.Chofer);
            dgvListaChofer.DataSource = ds.Chofer;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fotoms = new System.IO.MemoryStream();
            FotoPictureBox.Image.Save(fotoms, System.Drawing.Imaging.ImageFormat.Jpeg);
            spchofer.Chofer_Insert(NLicenciaTextBox.Text, NombreTextBox.Text, TelefonoTextBox.Text, fotoms.GetBuffer(), true);
            tchofer.Fill(ds.Chofer);
        }
    }
}

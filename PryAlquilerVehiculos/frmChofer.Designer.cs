namespace PryAlquilerVehiculos
{
    partial class frmChofer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NLicenciaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListaChofer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOFER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº Licencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre Completo";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(10, 150);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(235, 26);
            this.NombreTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefono";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(13, 214);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(133, 26);
            this.TelefonoTextBox.TabIndex = 3;
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoPictureBox.Location = new System.Drawing.Point(7, 301);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(217, 153);
            this.FotoPictureBox.TabIndex = 8;
            this.FotoPictureBox.TabStop = false;
            this.FotoPictureBox.Click += new System.EventHandler(this.FotoPictureBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Foto: clic en el cuadro";
            // 
            // NLicenciaTextBox
            // 
            this.NLicenciaTextBox.Location = new System.Drawing.Point(10, 79);
            this.NLicenciaTextBox.Name = "NLicenciaTextBox";
            this.NLicenciaTextBox.Size = new System.Drawing.Size(133, 26);
            this.NLicenciaTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar Chofer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvListaChofer
            // 
            this.dgvListaChofer.AllowUserToAddRows = false;
            this.dgvListaChofer.AllowUserToDeleteRows = false;
            this.dgvListaChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaChofer.Location = new System.Drawing.Point(304, 79);
            this.dgvListaChofer.Name = "dgvListaChofer";
            this.dgvListaChofer.ReadOnly = true;
            this.dgvListaChofer.RowTemplate.Height = 28;
            this.dgvListaChofer.Size = new System.Drawing.Size(558, 409);
            this.dgvListaChofer.TabIndex = 10;
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 641);
            this.Controls.Add(this.dgvListaChofer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FotoPictureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NLicenciaTextBox);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmChofer";
            this.Text = "frmChofer";
            this.Load += new System.EventHandler(this.frmChofer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NLicenciaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListaChofer;
    }
}
namespace PryAlquilerVehiculos
{
    partial class frmAutomovil
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
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ModeloComboBox = new System.Windows.Forms.ComboBox();
            this.CapacidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.TCombustibleomboBox = new System.Windows.Forms.ComboBox();
            this.MontoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.PlacaTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvListaAutomovil = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CapacidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAutomovil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(566, 382);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(173, 32);
            this.RegistrarButton.TabIndex = 0;
            this.RegistrarButton.Text = "Registra Vehiculo";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automovil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Capacidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipo Combustible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Foto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "PrecioAlquiler";
            // 
            // ModeloComboBox
            // 
            this.ModeloComboBox.FormattingEnabled = true;
            this.ModeloComboBox.Items.AddRange(new object[] {
            "Toyota",
            "Mitzubishi",
            "Ford",
            "Suziki"});
            this.ModeloComboBox.Location = new System.Drawing.Point(3, 35);
            this.ModeloComboBox.Name = "ModeloComboBox";
            this.ModeloComboBox.Size = new System.Drawing.Size(121, 28);
            this.ModeloComboBox.TabIndex = 2;
            this.ModeloComboBox.Text = "Toyota";
            // 
            // CapacidadNumericUpDown
            // 
            this.CapacidadNumericUpDown.Location = new System.Drawing.Point(3, 69);
            this.CapacidadNumericUpDown.Name = "CapacidadNumericUpDown";
            this.CapacidadNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.CapacidadNumericUpDown.TabIndex = 3;
            this.CapacidadNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Rojo",
            "Amarillo",
            "Negro",
            "Azul",
            "Verde"});
            this.ColorComboBox.Location = new System.Drawing.Point(3, 105);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 28);
            this.ColorComboBox.TabIndex = 4;
            this.ColorComboBox.Text = "Negro";
            // 
            // TCombustibleomboBox
            // 
            this.TCombustibleomboBox.FormattingEnabled = true;
            this.TCombustibleomboBox.Items.AddRange(new object[] {
            "Gazolina",
            "Gaz",
            "Diezel",
            "Electrico"});
            this.TCombustibleomboBox.Location = new System.Drawing.Point(3, 139);
            this.TCombustibleomboBox.Name = "TCombustibleomboBox";
            this.TCombustibleomboBox.Size = new System.Drawing.Size(121, 28);
            this.TCombustibleomboBox.TabIndex = 5;
            this.TCombustibleomboBox.Text = "Gaz";
            // 
            // MontoNumericUpDown
            // 
            this.MontoNumericUpDown.Location = new System.Drawing.Point(3, 173);
            this.MontoNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.MontoNumericUpDown.TabIndex = 6;
            this.MontoNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoPictureBox.Location = new System.Drawing.Point(3, 205);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(217, 153);
            this.FotoPictureBox.TabIndex = 6;
            this.FotoPictureBox.TabStop = false;
            this.FotoPictureBox.Click += new System.EventHandler(this.FotoPictureBox_Click);
            // 
            // PlacaTextBox
            // 
            this.PlacaTextBox.Location = new System.Drawing.Point(3, 3);
            this.PlacaTextBox.Name = "PlacaTextBox";
            this.PlacaTextBox.Size = new System.Drawing.Size(100, 26);
            this.PlacaTextBox.TabIndex = 1;
            this.PlacaTextBox.Text = "123LNK";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgvListaAutomovil
            // 
            this.dgvListaAutomovil.AllowUserToAddRows = false;
            this.dgvListaAutomovil.AllowUserToDeleteRows = false;
            this.dgvListaAutomovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAutomovil.Location = new System.Drawing.Point(378, 51);
            this.dgvListaAutomovil.Name = "dgvListaAutomovil";
            this.dgvListaAutomovil.ReadOnly = true;
            this.dgvListaAutomovil.RowTemplate.Height = 28;
            this.dgvListaAutomovil.Size = new System.Drawing.Size(635, 325);
            this.dgvListaAutomovil.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlacaTextBox);
            this.panel1.Controls.Add(this.ModeloComboBox);
            this.panel1.Controls.Add(this.FotoPictureBox);
            this.panel1.Controls.Add(this.CapacidadNumericUpDown);
            this.panel1.Controls.Add(this.MontoNumericUpDown);
            this.panel1.Controls.Add(this.ColorComboBox);
            this.panel1.Controls.Add(this.TCombustibleomboBox);
            this.panel1.Location = new System.Drawing.Point(141, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 380);
            this.panel1.TabIndex = 8;
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Location = new System.Drawing.Point(465, 13);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(338, 26);
            this.FiltroTextBox.TabIndex = 9;
            this.FiltroTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Filtrar";
            // 
            // frmAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 433);
            this.Controls.Add(this.FiltroTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvListaAutomovil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrarButton);
            this.Name = "frmAutomovil";
            this.Text = "frmAutomovil";
            this.Load += new System.EventHandler(this.frmAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CapacidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAutomovil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ModeloComboBox;
        private System.Windows.Forms.NumericUpDown CapacidadNumericUpDown;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.ComboBox TCombustibleomboBox;
        private System.Windows.Forms.NumericUpDown MontoNumericUpDown;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.TextBox PlacaTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvListaAutomovil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FiltroTextBox;
        private System.Windows.Forms.Label label10;
    }
}
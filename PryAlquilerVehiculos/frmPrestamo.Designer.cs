namespace PryAlquilerVehiculos
{
    partial class frmPrestamo
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaDataTimer = new System.Windows.Forms.DateTimePicker();
            this.TotalTexbox = new System.Windows.Forms.TextBox();
            this.CiudadCmb = new System.Windows.Forms.ComboBox();
            this.ClienteCmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.AutomovilComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChoferComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.DiasPNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.DetallePanel = new System.Windows.Forms.Panel();
            this.PrestamoPanel = new System.Windows.Forms.Panel();
            this.ClienteButton = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.ChoferButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasPNumericUpDown)).BeginInit();
            this.DetallePanel.SuspendLayout();
            this.PrestamoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRESTAMOS";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(155, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 20);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Precio Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cliente";
            // 
            // FechaDataTimer
            // 
            this.FechaDataTimer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDataTimer.Location = new System.Drawing.Point(-1, 4);
            this.FechaDataTimer.Name = "FechaDataTimer";
            this.FechaDataTimer.Size = new System.Drawing.Size(200, 26);
            this.FechaDataTimer.TabIndex = 2;
            // 
            // TotalTexbox
            // 
            this.TotalTexbox.Location = new System.Drawing.Point(728, 4);
            this.TotalTexbox.Name = "TotalTexbox";
            this.TotalTexbox.Size = new System.Drawing.Size(100, 26);
            this.TotalTexbox.TabIndex = 3;
            // 
            // CiudadCmb
            // 
            this.CiudadCmb.FormattingEnabled = true;
            this.CiudadCmb.Items.AddRange(new object[] {
            "Oruro",
            "La Paz",
            "Cochabamba",
            "Santa Cruz"});
            this.CiudadCmb.Location = new System.Drawing.Point(205, 3);
            this.CiudadCmb.Name = "CiudadCmb";
            this.CiudadCmb.Size = new System.Drawing.Size(191, 28);
            this.CiudadCmb.TabIndex = 4;
            // 
            // ClienteCmb
            // 
            this.ClienteCmb.FormattingEnabled = true;
            this.ClienteCmb.Location = new System.Drawing.Point(445, 3);
            this.ClienteCmb.Name = "ClienteCmb";
            this.ClienteCmb.Size = new System.Drawing.Size(191, 28);
            this.ClienteCmb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guarda en Base de Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(16, 173);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowTemplate.Height = 28;
            this.dgvDetalle.Size = new System.Drawing.Size(967, 437);
            this.dgvDetalle.TabIndex = 7;
            // 
            // AutomovilComboBox
            // 
            this.AutomovilComboBox.FormattingEnabled = true;
            this.AutomovilComboBox.Location = new System.Drawing.Point(8, 7);
            this.AutomovilComboBox.Name = "AutomovilComboBox";
            this.AutomovilComboBox.Size = new System.Drawing.Size(191, 28);
            this.AutomovilComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Automovil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chofer";
            // 
            // ChoferComboBox
            // 
            this.ChoferComboBox.FormattingEnabled = true;
            this.ChoferComboBox.Location = new System.Drawing.Point(245, 7);
            this.ChoferComboBox.Name = "ChoferComboBox";
            this.ChoferComboBox.Size = new System.Drawing.Size(191, 28);
            this.ChoferComboBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dias Prestamo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "SubTotal";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(680, 7);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.SubTotalTextBox.TabIndex = 3;
            // 
            // DiasPNumericUpDown
            // 
            this.DiasPNumericUpDown.Location = new System.Drawing.Point(497, 7);
            this.DiasPNumericUpDown.Name = "DiasPNumericUpDown";
            this.DiasPNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.DiasPNumericUpDown.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Insertar en detalle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DetallePanel
            // 
            this.DetallePanel.Controls.Add(this.AutomovilComboBox);
            this.DetallePanel.Controls.Add(this.DiasPNumericUpDown);
            this.DetallePanel.Controls.Add(this.SubTotalTextBox);
            this.DetallePanel.Controls.Add(this.ChoferComboBox);
            this.DetallePanel.Location = new System.Drawing.Point(7, 128);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.Size = new System.Drawing.Size(790, 39);
            this.DetallePanel.TabIndex = 9;
            // 
            // PrestamoPanel
            // 
            this.PrestamoPanel.Controls.Add(this.CiudadCmb);
            this.PrestamoPanel.Controls.Add(this.FechaDataTimer);
            this.PrestamoPanel.Controls.Add(this.TotalTexbox);
            this.PrestamoPanel.Controls.Add(this.ClienteCmb);
            this.PrestamoPanel.Location = new System.Drawing.Point(16, 56);
            this.PrestamoPanel.Name = "PrestamoPanel";
            this.PrestamoPanel.Size = new System.Drawing.Size(837, 35);
            this.PrestamoPanel.TabIndex = 10;
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(518, 25);
            this.ClienteButton.Margin = new System.Windows.Forms.Padding(0);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(33, 31);
            this.ClienteButton.TabIndex = 11;
            this.ClienteButton.Text = "...";
            this.ClienteButton.UseVisualStyleBackColor = true;
            this.ClienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(93, 94);
            this.AutoButton.Margin = new System.Windows.Forms.Padding(0);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(33, 31);
            this.AutoButton.TabIndex = 11;
            this.AutoButton.Text = "...";
            this.AutoButton.UseVisualStyleBackColor = true;
            this.AutoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // ChoferButton
            // 
            this.ChoferButton.Location = new System.Drawing.Point(315, 94);
            this.ChoferButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChoferButton.Name = "ChoferButton";
            this.ChoferButton.Size = new System.Drawing.Size(33, 31);
            this.ChoferButton.TabIndex = 11;
            this.ChoferButton.Text = "...";
            this.ChoferButton.UseVisualStyleBackColor = true;
            this.ChoferButton.Click += new System.EventHandler(this.ChoferButton_Click);
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 687);
            this.Controls.Add(this.ChoferButton);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.ClienteButton);
            this.Controls.Add(this.PrestamoPanel);
            this.Controls.Add(this.DetallePanel);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.label1);
            this.Name = "frmPrestamo";
            this.Text = "frmPrestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasPNumericUpDown)).EndInit();
            this.DetallePanel.ResumeLayout(false);
            this.DetallePanel.PerformLayout();
            this.PrestamoPanel.ResumeLayout(false);
            this.PrestamoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechaDataTimer;
        private System.Windows.Forms.TextBox TotalTexbox;
        private System.Windows.Forms.ComboBox CiudadCmb;
        private System.Windows.Forms.ComboBox ClienteCmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.ComboBox AutomovilComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ChoferComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.NumericUpDown DiasPNumericUpDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel DetallePanel;
        private System.Windows.Forms.Panel PrestamoPanel;
        private System.Windows.Forms.Button ClienteButton;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.Button ChoferButton;
    }
}
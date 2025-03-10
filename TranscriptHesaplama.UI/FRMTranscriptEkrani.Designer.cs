namespace TranscriptHesaplama.UI
{
    partial class FRMTranscriptEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnHesapla = new Button();
            cmbFinal = new ComboBox();
            cmbAraSinav = new ComboBox();
            lblGNO = new Label();
            label4 = new Label();
            label3 = new Label();
            lblSecilen = new Label();
            dgvDersler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesapla);
            groupBox1.Controls.Add(cmbFinal);
            groupBox1.Controls.Add(cmbAraSinav);
            groupBox1.Controls.Add(lblGNO);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblSecilen);
            groupBox1.Controls.Add(dgvDersler);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(887, 477);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(698, 212);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(122, 80);
            btnHesapla.TabIndex = 3;
            btnHesapla.Text = "Transcript Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // cmbFinal
            // 
            cmbFinal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFinal.FormattingEnabled = true;
            cmbFinal.Location = new Point(719, 152);
            cmbFinal.Name = "cmbFinal";
            cmbFinal.Size = new Size(151, 28);
            cmbFinal.TabIndex = 2;
            cmbFinal.SelectedIndexChanged += cmbFinal_SelectedIndexChanged;
            // 
            // cmbAraSinav
            // 
            cmbAraSinav.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAraSinav.FormattingEnabled = true;
            cmbAraSinav.Location = new Point(719, 116);
            cmbAraSinav.Name = "cmbAraSinav";
            cmbAraSinav.Size = new Size(151, 28);
            cmbAraSinav.TabIndex = 2;
            cmbAraSinav.SelectedIndexChanged += cmbAraSinav_SelectedIndexChanged;
            // 
            // lblGNO
            // 
            lblGNO.BorderStyle = BorderStyle.FixedSingle;
            lblGNO.Location = new Point(6, 402);
            lblGNO.Name = "lblGNO";
            lblGNO.Size = new Size(598, 56);
            lblGNO.TabIndex = 1;
            lblGNO.Text = "Genel Not Ortalaması:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 152);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 1;
            label4.Text = "Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 116);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 1;
            label3.Text = "Ara Sınav:";
            // 
            // lblSecilen
            // 
            lblSecilen.BorderStyle = BorderStyle.FixedSingle;
            lblSecilen.Location = new Point(6, 23);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(598, 60);
            lblSecilen.TabIndex = 1;
            lblSecilen.Text = "Seçilen Ders:";
            // 
            // dgvDersler
            // 
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(6, 86);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.RowHeadersWidth = 51;
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(598, 304);
            dgvDersler.TabIndex = 0;
            dgvDersler.CellClick += dgvDersler_CellClick;
            // 
            // FRMTranscriptEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 501);
            Controls.Add(groupBox1);
            Name = "FRMTranscriptEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transcript Hesaplama";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHesapla;
        private ComboBox cmbFinal;
        private ComboBox cmbAraSinav;
        private Label lblGNO;
        private Label label4;
        private Label label3;
        private Label lblSecilen;
        private DataGridView dgvDersler;
    }
}

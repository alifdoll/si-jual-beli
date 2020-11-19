namespace Muhammad_SistemJualBeli
{
    partial class FormDaftarNotaBeli
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
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewNotaBeli = new System.Windows.Forms.DataGridView();
            this.nonota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodesupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatsupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodepeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodebarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaBeli)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(295, 404);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(135, 47);
            this.buttonHapus.TabIndex = 27;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Navy;
            this.buttonUbah.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.Location = new System.Drawing.Point(154, 404);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(135, 47);
            this.buttonUbah.TabIndex = 26;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(3, 404);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(145, 47);
            this.buttonTambah.TabIndex = 25;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.textBoxCari);
            this.panel1.Controls.Add(this.comboBoxCari);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 63);
            this.panel1.TabIndex = 22;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(391, 13);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(315, 32);
            this.textBoxCari.TabIndex = 2;
            this.textBoxCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCari_KeyDown);
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "No Nota",
            "Tanggal",
            "Kode Supplier",
            "Nama Supplier",
            "Alamat Supplier",
            "Kode Pegawai",
            "Nama Pegawai"});
            this.comboBoxCari.Location = new System.Drawing.Point(191, 13);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(184, 32);
            this.comboBoxCari.TabIndex = 1;
            this.comboBoxCari.SelectedIndexChanged += new System.EventHandler(this.comboBoxCari_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Berdasarkan:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 63);
            this.label1.TabIndex = 21;
            this.label1.Text = "Daftar Nota Beli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(667, 404);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 47);
            this.buttonKeluar.TabIndex = 24;
            this.buttonKeluar.Text = "Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewNotaBeli
            // 
            this.dataGridViewNotaBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotaBeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nonota,
            this.tanggal,
            this.kodesupp,
            this.namasupp,
            this.alamatsupp,
            this.kodepeg,
            this.namapeg,
            this.kodebarang,
            this.namabarang,
            this.harga,
            this.jumlah});
            this.dataGridViewNotaBeli.Location = new System.Drawing.Point(4, 144);
            this.dataGridViewNotaBeli.Name = "dataGridViewNotaBeli";
            this.dataGridViewNotaBeli.RowHeadersWidth = 51;
            this.dataGridViewNotaBeli.RowTemplate.Height = 24;
            this.dataGridViewNotaBeli.Size = new System.Drawing.Size(798, 254);
            this.dataGridViewNotaBeli.TabIndex = 28;
            // 
            // nonota
            // 
            this.nonota.HeaderText = "No Nota";
            this.nonota.MinimumWidth = 6;
            this.nonota.Name = "nonota";
            this.nonota.Width = 125;
            // 
            // tanggal
            // 
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.MinimumWidth = 6;
            this.tanggal.Name = "tanggal";
            this.tanggal.Width = 125;
            // 
            // kodesupp
            // 
            this.kodesupp.HeaderText = "Kode Supplier";
            this.kodesupp.MinimumWidth = 6;
            this.kodesupp.Name = "kodesupp";
            this.kodesupp.Width = 125;
            // 
            // namasupp
            // 
            this.namasupp.HeaderText = "Nama Supplier";
            this.namasupp.MinimumWidth = 6;
            this.namasupp.Name = "namasupp";
            this.namasupp.Width = 125;
            // 
            // alamatsupp
            // 
            this.alamatsupp.HeaderText = "Alamat Supplier";
            this.alamatsupp.MinimumWidth = 6;
            this.alamatsupp.Name = "alamatsupp";
            this.alamatsupp.Width = 125;
            // 
            // kodepeg
            // 
            this.kodepeg.HeaderText = "Kode Pegawai";
            this.kodepeg.MinimumWidth = 6;
            this.kodepeg.Name = "kodepeg";
            this.kodepeg.Width = 125;
            // 
            // namapeg
            // 
            this.namapeg.HeaderText = "Nama Pegawai";
            this.namapeg.MinimumWidth = 6;
            this.namapeg.Name = "namapeg";
            this.namapeg.Width = 125;
            // 
            // kodebarang
            // 
            this.kodebarang.HeaderText = "Kode Barang";
            this.kodebarang.MinimumWidth = 6;
            this.kodebarang.Name = "kodebarang";
            this.kodebarang.Width = 125;
            // 
            // namabarang
            // 
            this.namabarang.HeaderText = "Nama Barang";
            this.namabarang.MinimumWidth = 6;
            this.namabarang.Name = "namabarang";
            this.namabarang.Width = 125;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.Width = 125;
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Navy;
            this.buttonCetak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(436, 404);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(135, 47);
            this.buttonCetak.TabIndex = 45;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // FormDaftarNotaBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.dataGridViewNotaBeli);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormDaftarNotaBeli";
            this.Text = "FormDaftarNotaBeli";
            this.Load += new System.EventHandler(this.FormDaftarNotaBeli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotaBeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewNotaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonota;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodesupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatsupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodepeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodebarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.Button buttonCetak;
    }
}
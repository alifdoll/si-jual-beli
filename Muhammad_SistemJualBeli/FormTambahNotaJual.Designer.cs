namespace Muhammad_SistemJualBeli
{
    partial class FormTambahNotaJual
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
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.labelKode = new System.Windows.Forms.Label();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.labelPegawai = new System.Windows.Forms.Label();
            this.labelPelanggan = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.textBoxNoNota = new System.Windows.Forms.TextBox();
            this.comboBoxDaftarPelanggan = new System.Windows.Forms.ComboBox();
            this.labelNoNota = new System.Windows.Forms.Label();
            this.dataGridViewTambahNotaJual = new System.Windows.Forms.DataGridView();
            this.labelFormTambahNotaJual = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelHargaDua = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.labelNamaBarangDua = new System.Windows.Forms.Label();
            this.labelKodeDua = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.panelDaftarBarang = new System.Windows.Forms.Panel();
            this.labelKodePegawai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTambahNotaJual)).BeginInit();
            this.panelDaftarBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(254, 618);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(135, 37);
            this.buttonSimpan.TabIndex = 42;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // labelKode
            // 
            this.labelKode.AutoSize = true;
            this.labelKode.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKode.Location = new System.Drawing.Point(139, 181);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(44, 17);
            this.labelKode.TabIndex = 37;
            this.labelKode.Text = "Kode";
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaPegawai.Location = new System.Drawing.Point(202, 127);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(48, 17);
            this.labelNamaPegawai.TabIndex = 36;
            this.labelNamaPegawai.Text = "Nama";
            // 
            // labelPegawai
            // 
            this.labelPegawai.AutoSize = true;
            this.labelPegawai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPegawai.Location = new System.Drawing.Point(32, 127);
            this.labelPegawai.Name = "labelPegawai";
            this.labelPegawai.Size = new System.Drawing.Size(74, 17);
            this.labelPegawai.TabIndex = 35;
            this.labelPegawai.Text = "Pegawai :";
            // 
            // labelPelanggan
            // 
            this.labelPelanggan.AutoSize = true;
            this.labelPelanggan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelanggan.Location = new System.Drawing.Point(384, 20);
            this.labelPelanggan.Name = "labelPelanggan";
            this.labelPelanggan.Size = new System.Drawing.Size(89, 17);
            this.labelPelanggan.TabIndex = 34;
            this.labelPelanggan.Text = "Pelanggan :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(408, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 17);
            this.label.TabIndex = 33;
            this.label.Text = "Alamat :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(32, 57);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(72, 17);
            this.labelTanggal.TabIndex = 32;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(126, 52);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTanggal.TabIndex = 31;
            // 
            // textBoxNoNota
            // 
            this.textBoxNoNota.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoNota.Location = new System.Drawing.Point(126, 15);
            this.textBoxNoNota.Name = "textBoxNoNota";
            this.textBoxNoNota.Size = new System.Drawing.Size(200, 26);
            this.textBoxNoNota.TabIndex = 3;
            // 
            // comboBoxDaftarPelanggan
            // 
            this.comboBoxDaftarPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDaftarPelanggan.FormattingEnabled = true;
            this.comboBoxDaftarPelanggan.Items.AddRange(new object[] {
            "Kode Kategori",
            "Nama Kategori"});
            this.comboBoxDaftarPelanggan.Location = new System.Drawing.Point(505, 17);
            this.comboBoxDaftarPelanggan.Name = "comboBoxDaftarPelanggan";
            this.comboBoxDaftarPelanggan.Size = new System.Drawing.Size(244, 24);
            this.comboBoxDaftarPelanggan.TabIndex = 2;
            this.comboBoxDaftarPelanggan.SelectedIndexChanged += new System.EventHandler(this.comboBoxDaftarPelanggan_SelectedIndexChanged);
            // 
            // labelNoNota
            // 
            this.labelNoNota.AutoSize = true;
            this.labelNoNota.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNota.Location = new System.Drawing.Point(32, 20);
            this.labelNoNota.Name = "labelNoNota";
            this.labelNoNota.Size = new System.Drawing.Size(79, 17);
            this.labelNoNota.TabIndex = 0;
            this.labelNoNota.Text = "No. Nota :";
            // 
            // dataGridViewTambahNotaJual
            // 
            this.dataGridViewTambahNotaJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTambahNotaJual.Location = new System.Drawing.Point(19, 246);
            this.dataGridViewTambahNotaJual.Name = "dataGridViewTambahNotaJual";
            this.dataGridViewTambahNotaJual.RowHeadersWidth = 51;
            this.dataGridViewTambahNotaJual.RowTemplate.Height = 24;
            this.dataGridViewTambahNotaJual.Size = new System.Drawing.Size(780, 272);
            this.dataGridViewTambahNotaJual.TabIndex = 30;
            // 
            // labelFormTambahNotaJual
            // 
            this.labelFormTambahNotaJual.BackColor = System.Drawing.Color.Navy;
            this.labelFormTambahNotaJual.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTambahNotaJual.ForeColor = System.Drawing.Color.White;
            this.labelFormTambahNotaJual.Location = new System.Drawing.Point(12, 9);
            this.labelFormTambahNotaJual.Name = "labelFormTambahNotaJual";
            this.labelFormTambahNotaJual.Size = new System.Drawing.Size(819, 47);
            this.labelFormTambahNotaJual.TabIndex = 40;
            this.labelFormTambahNotaJual.Text = "TAMBAH NOTA JUAL";
            this.labelFormTambahNotaJual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(358, 181);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(102, 17);
            this.labelNamaBarang.TabIndex = 39;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(696, 618);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 37);
            this.buttonKeluar.TabIndex = 44;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // labelAlamat
            // 
            this.labelAlamat.BackColor = System.Drawing.Color.Transparent;
            this.labelAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlamat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(505, 52);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(244, 50);
            this.labelAlamat.TabIndex = 48;
            this.labelAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHargaDua
            // 
            this.labelHargaDua.BackColor = System.Drawing.Color.Transparent;
            this.labelHargaDua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHargaDua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaDua.Location = new System.Drawing.Point(616, 204);
            this.labelHargaDua.Name = "labelHargaDua";
            this.labelHargaDua.Size = new System.Drawing.Size(113, 26);
            this.labelHargaDua.TabIndex = 47;
            this.labelHargaDua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumlah.Location = new System.Drawing.Point(728, 204);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(71, 26);
            this.textBoxJumlah.TabIndex = 46;
            // 
            // labelNamaBarangDua
            // 
            this.labelNamaBarangDua.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaBarangDua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNamaBarangDua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarangDua.Location = new System.Drawing.Point(195, 204);
            this.labelNamaBarangDua.Name = "labelNamaBarangDua";
            this.labelNamaBarangDua.Size = new System.Drawing.Size(421, 26);
            this.labelNamaBarangDua.TabIndex = 45;
            this.labelNamaBarangDua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKodeDua
            // 
            this.labelKodeDua.BackColor = System.Drawing.Color.Transparent;
            this.labelKodeDua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKodeDua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeDua.Location = new System.Drawing.Point(127, 204);
            this.labelKodeDua.Name = "labelKodeDua";
            this.labelKodeDua.Size = new System.Drawing.Size(68, 26);
            this.labelKodeDua.TabIndex = 44;
            this.labelKodeDua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(19, 204);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(111, 26);
            this.textBoxBarcode.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(437, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(312, 57);
            this.label11.TabIndex = 42;
            this.label11.Text = "0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(734, 181);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(57, 17);
            this.labelJumlah.TabIndex = 41;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(648, 181);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(50, 17);
            this.labelHarga.TabIndex = 40;
            this.labelHarga.Text = "Harga";
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Navy;
            this.buttonCetak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(395, 618);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(135, 37);
            this.buttonCetak.TabIndex = 43;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(32, 181);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(65, 17);
            this.labelBarcode.TabIndex = 38;
            this.labelBarcode.Text = "Barcode";
            // 
            // panelDaftarBarang
            // 
            this.panelDaftarBarang.BackColor = System.Drawing.Color.Lavender;
            this.panelDaftarBarang.Controls.Add(this.labelKodePegawai);
            this.panelDaftarBarang.Controls.Add(this.labelAlamat);
            this.panelDaftarBarang.Controls.Add(this.labelHargaDua);
            this.panelDaftarBarang.Controls.Add(this.textBoxJumlah);
            this.panelDaftarBarang.Controls.Add(this.labelNamaBarangDua);
            this.panelDaftarBarang.Controls.Add(this.labelKodeDua);
            this.panelDaftarBarang.Controls.Add(this.textBoxBarcode);
            this.panelDaftarBarang.Controls.Add(this.label11);
            this.panelDaftarBarang.Controls.Add(this.labelJumlah);
            this.panelDaftarBarang.Controls.Add(this.labelHarga);
            this.panelDaftarBarang.Controls.Add(this.labelNamaBarang);
            this.panelDaftarBarang.Controls.Add(this.labelBarcode);
            this.panelDaftarBarang.Controls.Add(this.labelKode);
            this.panelDaftarBarang.Controls.Add(this.labelNamaPegawai);
            this.panelDaftarBarang.Controls.Add(this.labelPegawai);
            this.panelDaftarBarang.Controls.Add(this.labelPelanggan);
            this.panelDaftarBarang.Controls.Add(this.label);
            this.panelDaftarBarang.Controls.Add(this.labelTanggal);
            this.panelDaftarBarang.Controls.Add(this.dateTimePickerTanggal);
            this.panelDaftarBarang.Controls.Add(this.textBoxNoNota);
            this.panelDaftarBarang.Controls.Add(this.comboBoxDaftarPelanggan);
            this.panelDaftarBarang.Controls.Add(this.labelNoNota);
            this.panelDaftarBarang.Controls.Add(this.dataGridViewTambahNotaJual);
            this.panelDaftarBarang.Location = new System.Drawing.Point(12, 71);
            this.panelDaftarBarang.Name = "panelDaftarBarang";
            this.panelDaftarBarang.Size = new System.Drawing.Size(819, 541);
            this.panelDaftarBarang.TabIndex = 41;
            // 
            // labelKodePegawai
            // 
            this.labelKodePegawai.AutoSize = true;
            this.labelKodePegawai.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodePegawai.Location = new System.Drawing.Point(139, 127);
            this.labelKodePegawai.Name = "labelKodePegawai";
            this.labelKodePegawai.Size = new System.Drawing.Size(44, 17);
            this.labelKodePegawai.TabIndex = 49;
            this.labelKodePegawai.Text = "Kode";
            // 
            // FormTambahNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(853, 667);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.labelFormTambahNotaJual);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panelDaftarBarang);
            this.Name = "FormTambahNotaJual";
            this.Text = "FormTambahNotaJual";
            this.Load += new System.EventHandler(this.FormTambahNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTambahNotaJual)).EndInit();
            this.panelDaftarBarang.ResumeLayout(false);
            this.panelDaftarBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.Label labelPegawai;
        private System.Windows.Forms.Label labelPelanggan;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.TextBox textBoxNoNota;
        private System.Windows.Forms.ComboBox comboBoxDaftarPelanggan;
        private System.Windows.Forms.Label labelNoNota;
        private System.Windows.Forms.DataGridView dataGridViewTambahNotaJual;
        private System.Windows.Forms.Label labelFormTambahNotaJual;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelHargaDua;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label labelNamaBarangDua;
        private System.Windows.Forms.Label labelKodeDua;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Panel panelDaftarBarang;
        private System.Windows.Forms.Label labelKodePegawai;
    }
}
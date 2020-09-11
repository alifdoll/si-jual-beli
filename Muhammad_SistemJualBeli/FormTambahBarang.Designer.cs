namespace Muhammad_SistemJualBeli
{
    partial class FormTambahBarang
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
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelHJargaJual = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelStok = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.labelKategoriBarang = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelHapusBarang = new System.Windows.Forms.Label();
            this.panelHapusBarang = new System.Windows.Forms.Panel();
            this.panelHapusBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(141, 403);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(135, 50);
            this.buttonSimpan.TabIndex = 2;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(190, 32);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(296, 24);
            this.comboBoxKategori.TabIndex = 1;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(190, 144);
            this.textBoxNamaBarang.MaxLength = 45;
            this.textBoxNamaBarang.Multiline = true;
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNamaBarang.Size = new System.Drawing.Size(384, 74);
            this.textBoxNamaBarang.TabIndex = 7;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaJual.Location = new System.Drawing.Point(190, 228);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(180, 26);
            this.textBoxHargaJual.TabIndex = 9;
            this.textBoxHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(190, 107);
            this.textBoxBarcode.MaxLength = 13;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(180, 26);
            this.textBoxBarcode.TabIndex = 5;
            // 
            // labelHJargaJual
            // 
            this.labelHJargaJual.AutoSize = true;
            this.labelHJargaJual.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHJargaJual.Location = new System.Drawing.Point(85, 233);
            this.labelHJargaJual.Name = "labelHJargaJual";
            this.labelHJargaJual.Size = new System.Drawing.Size(90, 17);
            this.labelHJargaJual.TabIndex = 8;
            this.labelHJargaJual.Text = "Harga Jual :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(487, 404);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 49);
            this.buttonKeluar.TabIndex = 4;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Navy;
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(282, 403);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(135, 49);
            this.buttonKosongi.TabIndex = 3;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStok.Location = new System.Drawing.Point(126, 269);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(49, 17);
            this.labelStok.TabIndex = 10;
            this.labelStok.Text = "Stok :";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(64, 147);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(111, 17);
            this.labelNamaBarang.TabIndex = 6;
            this.labelNamaBarang.Text = "Nama Barang :";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(101, 112);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(74, 17);
            this.labelBarcode.TabIndex = 4;
            this.labelBarcode.Text = "Barcode :";
            // 
            // labelKategoriBarang
            // 
            this.labelKategoriBarang.AutoSize = true;
            this.labelKategoriBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategoriBarang.Location = new System.Drawing.Point(45, 35);
            this.labelKategoriBarang.Name = "labelKategoriBarang";
            this.labelKategoriBarang.Size = new System.Drawing.Size(130, 17);
            this.labelKategoriBarang.TabIndex = 0;
            this.labelKategoriBarang.Text = "Kategori Barang :";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Enabled = false;
            this.textBoxKodeBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeBarang.Location = new System.Drawing.Point(190, 68);
            this.textBoxKodeBarang.MaxLength = 5;
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(109, 26);
            this.textBoxKodeBarang.TabIndex = 3;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStok.Location = new System.Drawing.Point(190, 264);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(58, 26);
            this.textBoxStok.TabIndex = 11;
            this.textBoxStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeBarang.Location = new System.Drawing.Point(68, 73);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(107, 17);
            this.labelKodeBarang.TabIndex = 2;
            this.labelKodeBarang.Text = "Kode Barang :";
            // 
            // labelHapusBarang
            // 
            this.labelHapusBarang.BackColor = System.Drawing.Color.Navy;
            this.labelHapusBarang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHapusBarang.ForeColor = System.Drawing.Color.White;
            this.labelHapusBarang.Location = new System.Drawing.Point(3, 2);
            this.labelHapusBarang.Name = "labelHapusBarang";
            this.labelHapusBarang.Size = new System.Drawing.Size(619, 47);
            this.labelHapusBarang.TabIndex = 0;
            this.labelHapusBarang.Text = "TAMBAH BARANG";
            this.labelHapusBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHapusBarang
            // 
            this.panelHapusBarang.BackColor = System.Drawing.Color.Lavender;
            this.panelHapusBarang.Controls.Add(this.comboBoxKategori);
            this.panelHapusBarang.Controls.Add(this.textBoxNamaBarang);
            this.panelHapusBarang.Controls.Add(this.textBoxHargaJual);
            this.panelHapusBarang.Controls.Add(this.textBoxBarcode);
            this.panelHapusBarang.Controls.Add(this.labelHJargaJual);
            this.panelHapusBarang.Controls.Add(this.labelStok);
            this.panelHapusBarang.Controls.Add(this.labelNamaBarang);
            this.panelHapusBarang.Controls.Add(this.labelBarcode);
            this.panelHapusBarang.Controls.Add(this.labelKategoriBarang);
            this.panelHapusBarang.Controls.Add(this.textBoxKodeBarang);
            this.panelHapusBarang.Controls.Add(this.textBoxStok);
            this.panelHapusBarang.Controls.Add(this.labelKodeBarang);
            this.panelHapusBarang.Location = new System.Drawing.Point(3, 64);
            this.panelHapusBarang.Name = "panelHapusBarang";
            this.panelHapusBarang.Size = new System.Drawing.Size(619, 321);
            this.panelHapusBarang.TabIndex = 1;
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 454);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.labelHapusBarang);
            this.Controls.Add(this.panelHapusBarang);
            this.Name = "FormTambahBarang";
            this.Text = "FormTambahBarang";
            this.Load += new System.EventHandler(this.FormTambahBarang_Load);
            this.panelHapusBarang.ResumeLayout(false);
            this.panelHapusBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelHJargaJual;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelKategoriBarang;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Label labelHapusBarang;
        private System.Windows.Forms.Panel panelHapusBarang;
    }
}
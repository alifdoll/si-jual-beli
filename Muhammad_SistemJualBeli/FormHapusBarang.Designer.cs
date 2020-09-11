namespace Muhammad_SistemJualBeli
{
    partial class FormHapusBarang
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
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.labelKategoriBarang = new System.Windows.Forms.Label();
            this.textBoxKategoriBarang = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelHapusBarang = new System.Windows.Forms.Label();
            this.labelStok = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelHJargaJual = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.panelHapusBarang = new System.Windows.Forms.Panel();
            this.panelHapusBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Navy;
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(282, 401);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(135, 49);
            this.buttonKosongi.TabIndex = 43;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(101, 112);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(74, 17);
            this.labelBarcode.TabIndex = 20;
            this.labelBarcode.Text = "Barcode :";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeBarang.Location = new System.Drawing.Point(190, 30);
            this.textBoxKodeBarang.MaxLength = 5;
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(151, 26);
            this.textBoxKodeBarang.TabIndex = 19;
            this.textBoxKodeBarang.TextChanged += new System.EventHandler(this.textBoxKodeBarang_TextChanged);
            // 
            // labelKategoriBarang
            // 
            this.labelKategoriBarang.AutoSize = true;
            this.labelKategoriBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategoriBarang.Location = new System.Drawing.Point(45, 73);
            this.labelKategoriBarang.Name = "labelKategoriBarang";
            this.labelKategoriBarang.Size = new System.Drawing.Size(130, 17);
            this.labelKategoriBarang.TabIndex = 18;
            this.labelKategoriBarang.Text = "Kategori Barang :";
            // 
            // textBoxKategoriBarang
            // 
            this.textBoxKategoriBarang.Enabled = false;
            this.textBoxKategoriBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKategoriBarang.Location = new System.Drawing.Point(190, 68);
            this.textBoxKategoriBarang.Name = "textBoxKategoriBarang";
            this.textBoxKategoriBarang.Size = new System.Drawing.Size(311, 26);
            this.textBoxKategoriBarang.TabIndex = 17;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Enabled = false;
            this.textBoxStok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStok.Location = new System.Drawing.Point(190, 264);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(58, 26);
            this.textBoxStok.TabIndex = 16;
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeBarang.Location = new System.Drawing.Point(68, 35);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(107, 17);
            this.labelKodeBarang.TabIndex = 15;
            this.labelKodeBarang.Text = "Kode Barang :";
            // 
            // labelHapusBarang
            // 
            this.labelHapusBarang.BackColor = System.Drawing.Color.Navy;
            this.labelHapusBarang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHapusBarang.ForeColor = System.Drawing.Color.White;
            this.labelHapusBarang.Location = new System.Drawing.Point(3, 0);
            this.labelHapusBarang.Name = "labelHapusBarang";
            this.labelHapusBarang.Size = new System.Drawing.Size(619, 47);
            this.labelHapusBarang.TabIndex = 41;
            this.labelHapusBarang.Text = "HAPUS BARANG";
            this.labelHapusBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStok.Location = new System.Drawing.Point(126, 269);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(49, 17);
            this.labelStok.TabIndex = 22;
            this.labelStok.Text = "Stok :";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(487, 402);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 49);
            this.buttonKeluar.TabIndex = 45;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Enabled = false;
            this.textBoxNamaBarang.Location = new System.Drawing.Point(190, 144);
            this.textBoxNamaBarang.Multiline = true;
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNamaBarang.Size = new System.Drawing.Size(384, 74);
            this.textBoxNamaBarang.TabIndex = 26;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Enabled = false;
            this.textBoxHargaJual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHargaJual.Location = new System.Drawing.Point(190, 228);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(151, 26);
            this.textBoxHargaJual.TabIndex = 25;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Enabled = false;
            this.textBoxBarcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarcode.Location = new System.Drawing.Point(190, 107);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(151, 26);
            this.textBoxBarcode.TabIndex = 24;
            // 
            // labelHJargaJual
            // 
            this.labelHJargaJual.AutoSize = true;
            this.labelHJargaJual.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHJargaJual.Location = new System.Drawing.Point(85, 233);
            this.labelHJargaJual.Name = "labelHJargaJual";
            this.labelHJargaJual.Size = new System.Drawing.Size(90, 17);
            this.labelHJargaJual.TabIndex = 23;
            this.labelHJargaJual.Text = "Harga Jual :";
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(141, 401);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(135, 50);
            this.buttonHapus.TabIndex = 44;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(64, 147);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(111, 17);
            this.labelNamaBarang.TabIndex = 21;
            this.labelNamaBarang.Text = "Nama Barang :";
            // 
            // panelHapusBarang
            // 
            this.panelHapusBarang.BackColor = System.Drawing.Color.Lavender;
            this.panelHapusBarang.Controls.Add(this.textBoxNamaBarang);
            this.panelHapusBarang.Controls.Add(this.textBoxHargaJual);
            this.panelHapusBarang.Controls.Add(this.textBoxBarcode);
            this.panelHapusBarang.Controls.Add(this.labelHJargaJual);
            this.panelHapusBarang.Controls.Add(this.labelStok);
            this.panelHapusBarang.Controls.Add(this.labelNamaBarang);
            this.panelHapusBarang.Controls.Add(this.labelBarcode);
            this.panelHapusBarang.Controls.Add(this.textBoxKodeBarang);
            this.panelHapusBarang.Controls.Add(this.labelKategoriBarang);
            this.panelHapusBarang.Controls.Add(this.textBoxKategoriBarang);
            this.panelHapusBarang.Controls.Add(this.textBoxStok);
            this.panelHapusBarang.Controls.Add(this.labelKodeBarang);
            this.panelHapusBarang.Location = new System.Drawing.Point(3, 62);
            this.panelHapusBarang.Name = "panelHapusBarang";
            this.panelHapusBarang.Size = new System.Drawing.Size(619, 321);
            this.panelHapusBarang.TabIndex = 42;
            // 
            // FormHapusBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(623, 449);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.labelHapusBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.panelHapusBarang);
            this.Name = "FormHapusBarang";
            this.Text = "FormHapusBarang";
            this.Load += new System.EventHandler(this.FormHapusBarang_Load);
            this.panelHapusBarang.ResumeLayout(false);
            this.panelHapusBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.Label labelKategoriBarang;
        private System.Windows.Forms.TextBox textBoxKategoriBarang;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Label labelHapusBarang;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelHJargaJual;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Panel panelHapusBarang;
    }
}
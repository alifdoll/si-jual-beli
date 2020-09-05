namespace Muhammad_SistemJualBeli
{
    partial class FormTambahKategori
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelNamaKategori = new System.Windows.Forms.Label();
            this.textBoxNamaKategori = new System.Windows.Forms.TextBox();
            this.textBoxKodeKategori = new System.Windows.Forms.TextBox();
            this.labelKodeKategori = new System.Windows.Forms.Label();
            this.panelTambahKategori = new System.Windows.Forms.Panel();
            this.labelTambahKategori = new System.Windows.Forms.Label();
            this.panelTambahKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(480, 242);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 49);
            this.buttonKeluar.TabIndex = 32;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(133, 242);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(135, 50);
            this.buttonSimpan.TabIndex = 31;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Navy;
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(274, 242);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(135, 49);
            this.buttonKosongi.TabIndex = 30;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelNamaKategori
            // 
            this.labelNamaKategori.AutoSize = true;
            this.labelNamaKategori.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaKategori.Location = new System.Drawing.Point(51, 89);
            this.labelNamaKategori.Name = "labelNamaKategori";
            this.labelNamaKategori.Size = new System.Drawing.Size(120, 17);
            this.labelNamaKategori.TabIndex = 5;
            this.labelNamaKategori.Text = "Nama Kategori :";
            // 
            // textBoxNamaKategori
            // 
            this.textBoxNamaKategori.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaKategori.Location = new System.Drawing.Point(187, 84);
            this.textBoxNamaKategori.Name = "textBoxNamaKategori";
            this.textBoxNamaKategori.Size = new System.Drawing.Size(414, 26);
            this.textBoxNamaKategori.TabIndex = 4;
            // 
            // textBoxKodeKategori
            // 
            this.textBoxKodeKategori.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeKategori.Location = new System.Drawing.Point(187, 41);
            this.textBoxKodeKategori.Name = "textBoxKodeKategori";
            this.textBoxKodeKategori.Size = new System.Drawing.Size(58, 26);
            this.textBoxKodeKategori.TabIndex = 3;
            // 
            // labelKodeKategori
            // 
            this.labelKodeKategori.AutoSize = true;
            this.labelKodeKategori.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeKategori.Location = new System.Drawing.Point(51, 46);
            this.labelKodeKategori.Name = "labelKodeKategori";
            this.labelKodeKategori.Size = new System.Drawing.Size(116, 17);
            this.labelKodeKategori.TabIndex = 0;
            this.labelKodeKategori.Text = "Kode Kategori :";
            // 
            // panelTambahKategori
            // 
            this.panelTambahKategori.BackColor = System.Drawing.Color.Lavender;
            this.panelTambahKategori.Controls.Add(this.labelNamaKategori);
            this.panelTambahKategori.Controls.Add(this.textBoxNamaKategori);
            this.panelTambahKategori.Controls.Add(this.textBoxKodeKategori);
            this.panelTambahKategori.Controls.Add(this.labelKodeKategori);
            this.panelTambahKategori.Location = new System.Drawing.Point(-4, 70);
            this.panelTambahKategori.Name = "panelTambahKategori";
            this.panelTambahKategori.Size = new System.Drawing.Size(619, 160);
            this.panelTambahKategori.TabIndex = 34;
            // 
            // labelTambahKategori
            // 
            this.labelTambahKategori.BackColor = System.Drawing.Color.Navy;
            this.labelTambahKategori.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahKategori.ForeColor = System.Drawing.Color.White;
            this.labelTambahKategori.Location = new System.Drawing.Point(-4, 8);
            this.labelTambahKategori.Name = "labelTambahKategori";
            this.labelTambahKategori.Size = new System.Drawing.Size(619, 47);
            this.labelTambahKategori.TabIndex = 33;
            this.labelTambahKategori.Text = "TAMBAH KATEGORI";
            this.labelTambahKategori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTambahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(619, 289);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.panelTambahKategori);
            this.Controls.Add(this.labelTambahKategori);
            this.Name = "FormTambahKategori";
            this.Text = "FormTambahKategori";
            this.Load += new System.EventHandler(this.FormTambahKategori_Load);
            this.panelTambahKategori.ResumeLayout(false);
            this.panelTambahKategori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelNamaKategori;
        private System.Windows.Forms.TextBox textBoxNamaKategori;
        private System.Windows.Forms.TextBox textBoxKodeKategori;
        private System.Windows.Forms.Label labelKodeKategori;
        private System.Windows.Forms.Panel panelTambahKategori;
        private System.Windows.Forms.Label labelTambahKategori;
    }
}
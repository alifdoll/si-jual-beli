﻿namespace Muhammad_SistemJualBeli
{
    partial class FormHapusSupplier
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
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.labelNamaKategori = new System.Windows.Forms.Label();
            this.textBoxNamaSupplier = new System.Windows.Forms.TextBox();
            this.textBoxKodeSupplier = new System.Windows.Forms.TextBox();
            this.labelKodeKategori = new System.Windows.Forms.Label();
            this.panelTambahKategori = new System.Windows.Forms.Panel();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTambahKategori = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.panelTambahKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(485, 316);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(135, 49);
            this.buttonKeluar.TabIndex = 42;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.Navy;
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(279, 316);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(135, 49);
            this.buttonKosongi.TabIndex = 40;
            this.buttonKosongi.Text = "KOSONGI";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // labelNamaKategori
            // 
            this.labelNamaKategori.AutoSize = true;
            this.labelNamaKategori.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaKategori.Location = new System.Drawing.Point(38, 89);
            this.labelNamaKategori.Name = "labelNamaKategori";
            this.labelNamaKategori.Size = new System.Drawing.Size(117, 17);
            this.labelNamaKategori.TabIndex = 5;
            this.labelNamaKategori.Text = "Nama Supplier :";
            // 
            // textBoxNamaSupplier
            // 
            this.textBoxNamaSupplier.Enabled = false;
            this.textBoxNamaSupplier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaSupplier.Location = new System.Drawing.Point(187, 84);
            this.textBoxNamaSupplier.Name = "textBoxNamaSupplier";
            this.textBoxNamaSupplier.Size = new System.Drawing.Size(414, 26);
            this.textBoxNamaSupplier.TabIndex = 4;
            // 
            // textBoxKodeSupplier
            // 
            this.textBoxKodeSupplier.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeSupplier.Location = new System.Drawing.Point(187, 41);
            this.textBoxKodeSupplier.MaxLength = 2;
            this.textBoxKodeSupplier.Name = "textBoxKodeSupplier";
            this.textBoxKodeSupplier.Size = new System.Drawing.Size(58, 26);
            this.textBoxKodeSupplier.TabIndex = 3;
            this.textBoxKodeSupplier.TextChanged += new System.EventHandler(this.textBoxKodeSupplier_TextChanged);
            // 
            // labelKodeKategori
            // 
            this.labelKodeKategori.AutoSize = true;
            this.labelKodeKategori.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeKategori.Location = new System.Drawing.Point(42, 46);
            this.labelKodeKategori.Name = "labelKodeKategori";
            this.labelKodeKategori.Size = new System.Drawing.Size(113, 17);
            this.labelKodeKategori.TabIndex = 0;
            this.labelKodeKategori.Text = "Kode Supplier :";
            // 
            // panelTambahKategori
            // 
            this.panelTambahKategori.BackColor = System.Drawing.Color.Lavender;
            this.panelTambahKategori.Controls.Add(this.textBoxAlamat);
            this.panelTambahKategori.Controls.Add(this.label1);
            this.panelTambahKategori.Controls.Add(this.labelNamaKategori);
            this.panelTambahKategori.Controls.Add(this.textBoxNamaSupplier);
            this.panelTambahKategori.Controls.Add(this.textBoxKodeSupplier);
            this.panelTambahKategori.Controls.Add(this.labelKodeKategori);
            this.panelTambahKategori.Location = new System.Drawing.Point(1, 64);
            this.panelTambahKategori.Name = "panelTambahKategori";
            this.panelTambahKategori.Size = new System.Drawing.Size(619, 224);
            this.panelTambahKategori.TabIndex = 44;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Enabled = false;
            this.textBoxAlamat.Location = new System.Drawing.Point(187, 127);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(413, 57);
            this.textBoxAlamat.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alamat :";
            // 
            // labelTambahKategori
            // 
            this.labelTambahKategori.BackColor = System.Drawing.Color.Navy;
            this.labelTambahKategori.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambahKategori.ForeColor = System.Drawing.Color.White;
            this.labelTambahKategori.Location = new System.Drawing.Point(1, 2);
            this.labelTambahKategori.Name = "labelTambahKategori";
            this.labelTambahKategori.Size = new System.Drawing.Size(619, 47);
            this.labelTambahKategori.TabIndex = 43;
            this.labelTambahKategori.Text = "HAPUS SUPPLIER";
            this.labelTambahKategori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.White;
            this.buttonHapus.Location = new System.Drawing.Point(125, 316);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(135, 50);
            this.buttonHapus.TabIndex = 45;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // FormHapusSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(627, 377);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.panelTambahKategori);
            this.Controls.Add(this.labelTambahKategori);
            this.Name = "FormHapusSupplier";
            this.Text = "FormHapusSupplier";
            this.panelTambahKategori.ResumeLayout(false);
            this.panelTambahKategori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Label labelNamaKategori;
        private System.Windows.Forms.TextBox textBoxNamaSupplier;
        private System.Windows.Forms.TextBox textBoxKodeSupplier;
        private System.Windows.Forms.Label labelKodeKategori;
        private System.Windows.Forms.Panel panelTambahKategori;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTambahKategori;
        private System.Windows.Forms.Button buttonHapus;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhammad_SistemJualBeli
{
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            Enabled = false;

            FormLogin form = new FormLogin();
            form.Owner = this;
            form.Show();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarKategori kategori = new FormDaftarKategori();
            Form form = Application.OpenForms[kategori.Name];
            SingleForm(form, kategori);
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarBarang barang = new FormDaftarBarang();
            Form form = Application.OpenForms[barang.Name];
            SingleForm(form, barang);
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarPegawai pegawaiForm = new FormDaftarPegawai();
            Form forms = Application.OpenForms[pegawaiForm.Name];

            SingleForm(forms, pegawaiForm);
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarPelanggan pelangganForm = new FormDaftarPelanggan();
            Form forms = Application.OpenForms[pelangganForm.Name];

            SingleForm(forms, pelangganForm);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarSupplier supplier = new FormDaftarSupplier();
            Form forms = Application.OpenForms[supplier.Name];
            SingleForm(forms, supplier);
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarNotaJual notaJual = new FormDaftarNotaJual();
            Form form = Application.OpenForms[notaJual.Name];
            SingleForm(form, notaJual);
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarNotaBeli notaBeli = new FormDaftarNotaBeli();
            Form form = Application.OpenForms[notaBeli.Name];
            SingleForm(form, notaBeli);
        }

        private void SingleForm(Form forms, Form mdiParent)
        {
            if (forms == null)
            {
                mdiParent.MdiParent = this;
                mdiParent.Show();

            }

            else
            {
                forms.Show();
                forms.BringToFront();
            }
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

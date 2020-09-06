using JualBeli_LIB;
using System;
using System.Collections;
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
    public partial class FormDaftarPelanggan : Form
    {
        ArrayList listPelanggan = new ArrayList();
        Pelanggan pelanggan = new Pelanggan();

        public FormDaftarPelanggan()
        {
            InitializeComponent();
        }

        public void FormDaftarPelanggan_Load(object sender, EventArgs e)
        {
            listPelanggan = pelanggan.QueryData(pelanggan);

            if(listPelanggan.Count > 0)
            {
                dataGridViewPelanggan.DataSource = listPelanggan;
            }
            else
            {
                dataGridViewPelanggan.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan form = new FormTambahPelanggan
            {
                Owner = this
            };
            form.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPelanggan form = new FormUbahPelanggan { Owner = this };
            form.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPelanggan form = new FormHapusPelanggan { Owner = this };
            form.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxKode.Text == "Kode Pelanggan")
            {
                listPelanggan = pelanggan.QueryData(pelanggan, "kodepelanggan", textBoxCari.Text);
            }
            else
            {
                listPelanggan = pelanggan.QueryData(pelanggan, "Nama", textBoxCari.Text);
            }

            if(listPelanggan.Count > 0)
            {
                dataGridViewPelanggan.DataSource = listPelanggan;
            }
            else
            {
                dataGridViewPelanggan.DataSource = null;
            }
        }
    }
}

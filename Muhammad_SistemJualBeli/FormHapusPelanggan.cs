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
    public partial class FormHapusPelanggan : Form
    {
        ArrayList listPelanggan = new ArrayList();
        Pelanggan pelanggan = new Pelanggan();

        public FormHapusPelanggan()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Data Pelanggan Akan Dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                Pelanggan pelanggan = new Pelanggan(
                    textBoxKodePelanggan.Text,
                    textBoxNamaPelanggan.Text,
                    textBoxAlamat.Text,
                    textBoxTelepon.Text);

                string hapus = pelanggan.Delete();

                if(hapus == "1")
                {
                    MessageBox.Show("Data Pelanggan Telah Dihapus", "Info");
                    FormDaftarPelanggan frm = (FormDaftarPelanggan)Owner;
                    frm.FormDaftarPelanggan_Load(buttonHapus, e);

                    buttonKosongi_Click(buttonHapus, e);
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Data Pelanggan, Error : " + hapus);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodePelanggan.Text = "";
            textBoxNamaPelanggan.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelepon.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxKodePelanggan_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodePelanggan.Text.Length == textBoxKodePelanggan.MaxLength)
            {
                listPelanggan = pelanggan.QueryData(pelanggan, "KodePelanggan", textBoxKodePelanggan.Text);

                if(listPelanggan.Count > 0)
                {
                    textBoxNamaPelanggan.Focus();
                    textBoxNamaPelanggan.Text = ((Pelanggan)listPelanggan[0]).Nama;
                    textBoxAlamat.Text = ((Pelanggan)listPelanggan[0]).Alamat;
                    textBoxTelepon.Text = ((Pelanggan)listPelanggan[0]).Telepon;
                    buttonHapus.Focus();
                }
                else
                {
                    MessageBox.Show("Kode Pelanggan Tidak Ditemukan.", "Warning");
                    textBoxKodePelanggan.Text = "";
                }
            }
        }
    }
}

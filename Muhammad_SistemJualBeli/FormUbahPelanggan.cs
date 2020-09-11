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
    public partial class FormUbahPelanggan : Form
    {
        ArrayList listPelanggan = new ArrayList();
        Pelanggan pelanggan = new Pelanggan();

        public FormUbahPelanggan()
        {
            InitializeComponent();
        }

        private void FormUbahPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void textBoxKodePelanggan_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodePelanggan.Text.Length <= textBoxKodePelanggan.MaxLength)
            {
                listPelanggan = pelanggan.QueryData("KodePelanggan", textBoxKodePelanggan.Text);
                if(listPelanggan.Count > 0)
                {
                    textBoxNamaPelanggan.Text = ((Pelanggan)listPelanggan[0]).Nama;
                    textBoxAlamat.Text = ((Pelanggan)listPelanggan[0]).Alamat;
                    textBoxTelepon.Text = ((Pelanggan)listPelanggan[0]).Telepon;
                    textBoxNamaPelanggan.Focus();
                }
                else
                {
                    MessageBox.Show("Kode Pelanggan Tidak Ditemukan", "Warning");
                    textBoxKodePelanggan.Text = "";
                }
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Pelanggan pelanggan = new Pelanggan(
                    textBoxKodePelanggan.Text,
                    textBoxNamaPelanggan.Text,
                    textBoxAlamat.Text,
                    textBoxTelepon.Text);

                pelanggan.Update();

                FormDaftarPelanggan frm = (FormDaftarPelanggan)Owner;
                frm.FormDaftarPelanggan_Load(buttonUbah, e);

                MessageBox.Show("Data Pelanggan Telah Diubah", "Info");

                buttonKosongi_Click(buttonUbah, e);
            }
            catch(Exception error)
            {
                MessageBox.Show("Gagal Mengubah Data Pelanggan, Error : " + error.Message, "Info");
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
    }
}

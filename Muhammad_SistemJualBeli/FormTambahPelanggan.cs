using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JualBeli_LIB;

namespace Muhammad_SistemJualBeli
{
    public partial class FormTambahPelanggan : Form
    {
        FormDaftarPelanggan frm;
        Pelanggan pelanggan = new Pelanggan();
        public FormTambahPelanggan()
        {
            InitializeComponent();
        }

        private void FormTambahPelanggan_Load(object sender, EventArgs e)
        {
            string newId = pelanggan.GeneratePrimaryKey();

            textBoxKodePelanggan.Text = newId;
            textBoxNamaPelanggan.Focus();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Pelanggan pelangganNew = new Pelanggan(
                    textBoxKodePelanggan.Text, 
                    textBoxNamaPelanggan.Text, 
                    textBoxAlamat.Text, 
                    textBoxTelepon.Text);

                pelangganNew.Insert();

                frm = (FormDaftarPelanggan)Owner;
                frm.FormDaftarPelanggan_Load(buttonTambah, e);

                MessageBox.Show("Data Pelanggan Telah Tersimpan", "Info");

                textBoxKodePelanggan.Text = pelanggan.GeneratePrimaryKey();
                buttonKosongi_Click(buttonTambah, e);
            }
            catch(Exception error)
            {
                MessageBox.Show("Penyimpanan gagal, Error : " + error.Message, "Info");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
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

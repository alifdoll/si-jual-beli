using JualBeli_LIB;
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
    public partial class FormHapusKategori : Form
    {
        List<Kategori> listKategori = new List<Kategori>();
        public FormHapusKategori()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Data Kategori akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Kategori kategori = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);

                string hasilTambah = kategori.Delete();

                if (hasilTambah == "1")
                {
                    MessageBox.Show("Data Kategori Berhasl Dihapus", "Info");

                    FormDaftarKategori frm = (FormDaftarKategori)Owner;
                    frm.FormDaftarKategori_Load(buttonHapus, e);

                    textBoxKodeKategori.Text = "";
                    textBoxNamaKategori.Text = "";
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Kategor, Error : " + hasilTambah);
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeKategori.Text.Length == textBoxKodeKategori.MaxLength)
            {
                listKategori = Kategori.ReadData("KodeKategori", textBoxKodeKategori.Text);

                if(listKategori.Count > 0)
                {
                    textBoxNamaKategori.Text = listKategori[0].Nama;
                    buttonHapus.Focus();
                }
                else
                {
                    MessageBox.Show("Kode Kategori Tidak Ditemukan.", "Warning");
                    textBoxNamaKategori.Text = "";
                }
            }
        }
    }
}

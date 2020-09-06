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
    public partial class FormHapusKategori : Form
    {
        ArrayList listKategori = new ArrayList();
        Kategori kategori = new Kategori();
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

                string hapus = kategori.Delete();

                if (hapus == "1")
                {
                    MessageBox.Show("Data Kategori Berhasl Dihapus", "Info");

                    FormDaftarKategori frm = (FormDaftarKategori)Owner;
                    frm.FormDaftarKategori_Load(buttonHapus, e);

                    textBoxKodeKategori.Text = "";
                    textBoxNamaKategori.Text = "";
                    textBoxKodeKategori.Focus();
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Kategori, Error : " + hapus);
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
                listKategori = kategori.QueryData(kategori,"KodeKategori", textBoxKodeKategori.Text);

                if(listKategori.Count > 0)
                {
                    textBoxNamaKategori.Focus();
                    textBoxNamaKategori.Text = ((Kategori)listKategori[0]).Nama;
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

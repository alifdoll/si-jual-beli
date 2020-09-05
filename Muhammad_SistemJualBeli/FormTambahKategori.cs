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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);
                kategori.Insert();

                MessageBox.Show("Data Kategori Telah Tersimpan", "Info");

                textBoxKodeKategori.Text = "";
                textBoxNamaKategori.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Penyimpanan gagal, Error : " + error.Message, "Info");
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
    }
}

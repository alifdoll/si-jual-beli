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
    public partial class FormDaftarKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        public void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.ReadData("", "");

            if(listKategori.Count > 0)
            {
                dataGridViewKategori.DataSource = listKategori;
            }
            else
            {
                dataGridViewKategori.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori formTambah = new FormTambahKategori();
            formTambah.Owner = this;
            formTambah.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategori formUbah = new FormUbahKategori();
            formUbah.Owner = this;
            formUbah.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategori form = new FormHapusKategori();
            form.Owner = this;
            form.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxKode.Text == "Kode Kategori")
            {
                listKategori = Kategori.ReadData("KodeKategori", textBoxCari.Text);
            }
            else
            {
                listKategori = Kategori.ReadData("Nama", textBoxCari.Text);
            }

            if(listKategori.Count > 0)
            {
                dataGridViewKategori.DataSource = listKategori;
            }
            else
            {
                dataGridViewKategori.DataSource = null;
            }
        }
    }
}

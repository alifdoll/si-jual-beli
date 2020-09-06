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
    public partial class FormDaftarKategori : Form
    {
        ArrayList listKategori = new ArrayList();
        Kategori kategori = new Kategori();
        

        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        public void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            listKategori = kategori.QueryData(kategori);

            if(listKategori.Count > 0)
            {
                dataGridViewKategori.DataSource = listKategori;
            }
            else
            {
                MessageBox.Show("No Data");
                dataGridViewKategori.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori formTambah = new FormTambahKategori
            {
                Owner = this
            };
            formTambah.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategori formUbah = new FormUbahKategori
            {
                Owner = this
            };
            formUbah.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategori form = new FormHapusKategori
            {
                Owner = this
            };
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
                listKategori = kategori.QueryData(kategori, "KodeKategori", textBoxCari.Text);
            }
            else
            {
                listKategori = kategori.QueryData(kategori, "Nama", textBoxCari.Text);
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

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Text = "";
        }
    }
}

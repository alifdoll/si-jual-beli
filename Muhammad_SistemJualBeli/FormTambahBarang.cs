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
    public partial class FormTambahBarang : Form
    {
        ArrayList listKategori = new ArrayList();
        Kategori kategori = new Kategori();


        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            listKategori = kategori.QueryData();
            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategoriBarang = (Kategori)comboBoxKategori.SelectedItem;
                
                Barang barang = new Barang(
                    textBoxKodeBarang.Text,
                    textBoxBarcode.Text,
                    textBoxNamaBarang.Text,
                    double.Parse(textBoxHargaJual.Text),
                    int.Parse(textBoxStok.Text),
                    kategoriBarang);

                barang.Insert();

                string newCode = Barang.GenerateItemCode(kategoriBarang);

                textBoxKodeBarang.Text = newCode;

                MessageBox.Show("Data Barang Berhasil Ditambahkan", "Info");

                buttonKosongi_Click(buttonSimpan, e);

                FormDaftarBarang frm = (FormDaftarBarang)Owner;
                frm.FormDaftarBarang_Load(buttonSimpan, e);
            }
            catch(Exception error)
            {
                MessageBox.Show("Data Barang Gagal Ditambahkan, Error : " + error.Message, "Warning");
            }
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKategori.SelectedIndex != -1)
            {
                Kategori select = (Kategori)comboBoxKategori.SelectedItem;

                string newCode = Barang.GenerateItemCode(select);

                textBoxKodeBarang.Text = newCode;

                textBoxBarcode.Focus();
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaBarang.Text = "";
            textBoxBarcode.Text = "";
            textBoxHargaJual.Text = "";
            textBoxStok.Text = "";
        }
    }
}

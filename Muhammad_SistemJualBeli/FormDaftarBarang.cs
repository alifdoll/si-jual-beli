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
    public partial class FormDaftarBarang : Form
    {
        ArrayList listBarang = new ArrayList();
        Barang barang = new Barang();

        public FormDaftarBarang()
        {
            InitializeComponent();
        }

        public void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            
            listBarang = barang.QueryData();
            CustomDataGrid();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string criteria;
            switch (comboBoxCari.Text)
            {
                case "Kode Barang":
                    criteria = "kodebarang";
                    break;

                case "Nama Barang":
                    criteria = "barang.nama";
                    break;

                case "Barcode":
                    criteria = "barcode";
                    break;

                case "Harga Jual":
                    criteria = "hargajual";
                    break;

                case "Stok":
                    criteria = "stok";
                    break;

                case "Kode Kategori":
                    criteria = "barang.kodekategori";
                    break;

                default:
                    criteria = "kategori.nama";
                    break;
            }

            listBarang = barang.QueryData(criteria, textBoxCari.Text);

            if (listBarang.Count > 0)
            {
                CustomDataGrid();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan", "Warning");
                dataGridViewBarang.DataSource = null;
            }
        }

        private void CustomDataGrid()
        {
            if (listBarang.Count > 0)
            {
                dataGridViewBarang.Rows.Clear();
                foreach (Barang item in listBarang)
                {
                    dataGridViewBarang.Rows.Add(
                    item.KodeBarang,
                    item.Barcode,
                    item.Nama,
                    item.HargaJual,
                    item.Stok,
                    item.Kategori.KodeKategori,
                    item.Kategori.Nama);
                }
            }
            else
            {
                MessageBox.Show("No Data Available", "Warning");
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang form = new FormTambahBarang { Owner = this };
            form.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahBarang form = new FormUbahBarang { Owner = this };
            form.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusBarang form = new FormHapusBarang { Owner = this };
            form.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Text = "";
        }
    }
}

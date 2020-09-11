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
    public partial class FormHapusBarang : Form
    {
        ArrayList listBarang = new ArrayList();
        Barang barang = new Barang();

        public FormHapusBarang()
        {
            InitializeComponent();
        }

        private void FormHapusBarang_Load(object sender, EventArgs e)
        {

        }

        private void textBoxKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeBarang.Text.Length == textBoxKodeBarang.MaxLength)
            {
                listBarang = barang.QueryData("kodebarang", textBoxKodeBarang.Text);

                if(listBarang.Count > 0)
                {
                    Barang bar = (Barang)listBarang[0];
                    textBoxBarcode.Text = bar.Barcode;
                    textBoxNamaBarang.Text = bar.Nama;
                    textBoxHargaJual.Text = bar.HargaJual.ToString();
                    textBoxStok.Text = bar.Stok.ToString();
                    textBoxKategoriBarang.Text = bar.Kategori.Nama;
                }
                else
                {
                    MessageBox.Show("Data Barang Tidak Ditemukan", "Warning");
                    buttonKosongi_Click(textBoxKodeBarang, e);
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Data Barang akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                if(listBarang.Count > 0)
                {
                    Barang bar = (Barang)listBarang[0];
                    string hapus = bar.Delete();

                    if(hapus == "1")
                    {
                        MessageBox.Show("Data Barang Berhasil Dihapus", "Warning");

                        buttonKosongi_Click(buttonHapus, e);

                        FormDaftarBarang frm = (FormDaftarBarang)Owner;
                        frm.FormDaftarBarang_Load(buttonHapus, e);
                    }
                    else
                    {
                        MessageBox.Show("Data Barang Gagal Dihapus" + hapus, "Warning");
                    }
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaBarang.Text = "";
            textBoxBarcode.Text = "";
            textBoxHargaJual.Text = "";
            textBoxStok.Text = "";
            textBoxKodeBarang.Text = "";
            textBoxKategoriBarang.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

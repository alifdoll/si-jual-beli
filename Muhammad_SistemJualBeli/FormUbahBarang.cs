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
    public partial class FormUbahBarang : Form
    {
        ArrayList listBarang = new ArrayList();
        Barang barang = new Barang();

        public FormUbahBarang()
        {
            InitializeComponent();
        }

        private void textBoxKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeBarang.Text.Length == textBoxKodeBarang.MaxLength)
            {
                listBarang = barang.QueryData("kodebarang", textBoxKodeBarang.Text);

                if(listBarang.Count > 0)
                {
                    Barang bar = (Barang)listBarang[0];
                    textBoxNamaBarang.Text = bar.Nama;
                    textBoxBarcode.Text = bar.Barcode;
                    textBoxHargaJual.Text = bar.HargaJual.ToString();
                    textBoxStok.Text = bar.Stok.ToString();
                    textBoxKodeBarang.Text = bar.KodeBarang;
                    textBoxKategoriBarang.Text = bar.Kategori.Nama;
                }
                else
                {
                    MessageBox.Show("Data Barang Tidak Ditemukan", "Warning");
                    buttonKosongi_Click(textBoxKodeBarang, e);
                }
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
            textBoxKodeBarang.Text = "";
            textBoxKategoriBarang.Text = "";
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBarang.Count > 0)
                {
                   Kategori kategori = new Kategori(((Barang)listBarang[0]).Kategori.KodeKategori, ((Barang)listBarang[0]).Kategori.Nama);
                   Barang barang = new Barang(
                   textBoxKodeBarang.Text,
                   textBoxBarcode.Text,
                   textBoxNamaBarang.Text,
                   double.Parse(textBoxHargaJual.Text),
                   int.Parse(textBoxStok.Text),
                   kategori);

                   barang.Update();

                    MessageBox.Show("Barang Berhasil Diubah", "Info");
                    FormDaftarBarang frm = (FormDaftarBarang)Owner;
                    frm.FormDaftarBarang_Load(buttonUbah, e);
                }
               
            }
            catch(Exception error)
            {
                MessageBox.Show("Gagal Mengupdate Data, Error : " + error.Message, "Warning");
            }
        }
    }
}

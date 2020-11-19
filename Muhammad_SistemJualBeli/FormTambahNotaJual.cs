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
    public partial class FormTambahNotaJual : Form
    {
        Pelanggan pelanggan = new Pelanggan();
        ArrayList listPelanggan = new ArrayList();
        FormMaster form;
        ArrayList listBarang = new ArrayList();
        Barang bar = new Barang();
        NotaJual nota = new NotaJual();
        
        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            listPelanggan = pelanggan.QueryData();
            comboBoxDaftarPelanggan.DataSource = listPelanggan;
            comboBoxDaftarPelanggan.DisplayMember = "Nama";

            form = (FormMaster)Owner.MdiParent;
            labelKodePegawai.Text = form.pegawaiLogin.KodePegawai;
            labelNamaPegawai.Text = form.pegawaiLogin.Nama;

            textBoxNoNota.Text = nota.GeneratePrimaryKey();

            dateTimePickerTanggal.Value = DateTime.Now;

            if(comboBoxDaftarPelanggan.SelectedIndex != -1)
            {
                labelAlamat.Text = ((Pelanggan)comboBoxDaftarPelanggan.SelectedItem).Alamat;
            }
            
        }

        private void comboBoxDaftarPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pelanggan pelanggan = (Pelanggan)comboBoxDaftarPelanggan.SelectedItem;
            labelAlamat.Text = pelanggan.Alamat;

            textBoxBarcode.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            
            Barang barang = new Barang();
            if(textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
            {
                listBarang = barang.QueryData("Barcode", textBoxBarcode.Text);

                if(listBarang.Count > 0)
                {
                    labelKode.Text = ((Barang)listBarang[0]).KodeBarang;
                    labelNamaBarang.Text = ((Barang)listBarang[0]).Nama;
                    labelHarga.Text = ((Barang)listBarang[0]).HargaJual.ToString();
                    textBoxJumlah.Text = "1";
                    textBoxJumlah.Focus();
                }
                else
                {
                    MessageBox.Show("Barang tidak ada");
                    textBoxBarcode.Text = "";
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if(dataGridViewTambahNotaJual.Rows.Count >= 1)
            {
               
                try
                {
                    Pelanggan pelanggan = (Pelanggan)comboBoxDaftarPelanggan.SelectedItem;
                    nota = new NotaJual(
                        textBoxNoNota.Text,
                        dateTimePickerTanggal.Value,
                        pelanggan,
                        form.pegawaiLogin);

                    for (int i = 0; i < dataGridViewTambahNotaJual.Rows.Count - 1; i++)
                    {
                        string kode = dataGridViewTambahNotaJual.Rows[i].Cells[0].Value.ToString();

                        listBarang = bar.QueryData("Barang.KodeBarang", kode);

                        int harga = int.Parse(dataGridViewTambahNotaJual.Rows[i].Cells[2].Value.ToString());
                        int jumlah = int.Parse(dataGridViewTambahNotaJual.Rows[i].Cells[3].Value.ToString());

                        nota.TambahNotaJualDetil((Barang)listBarang[0], harga, jumlah);
                    }

                    nota.Insert();
                    MessageBox.Show("Data Berhasil Disimpan", "Info");
                    ClearFocus();
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Gagal Menyimpan Nota, Error : {error.Message}", "Error");
                }
            }
            
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int subtotal = int.Parse(labelHarga.Text) * int.Parse(textBoxJumlah.Text);

                dataGridViewTambahNotaJual.Rows.Add(
                    labelKode.Text,
                    labelNamaBarang.Text,
                    labelHarga.Text,
                    textBoxJumlah.Text,
                    subtotal);

                labelTotal.Text = GrandTotal().ToString("#,##");
                ClearFocus();

            }
        }

        private void ClearFocus()
        {
            textBoxBarcode.Text = "";
            textBoxBarcode.Focus();
            textBoxJumlah.Text = "";
            labelKode.Text = "";
            labelNamaBarang.Text = "";
            labelHarga.Text = "";
        }

        private int GrandTotal()
        {
            int total = 0;

            for (int i = 0; i < dataGridViewTambahNotaJual.Rows.Count - 1; i++)
            {
                int subtotal = int.Parse(dataGridViewTambahNotaJual.Rows[i].Cells[4].Value.ToString());
                total += subtotal;
            }

            return total;
            
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaJual.CetakNota("NoNota", textBoxNoNota.Text, "nota_jual.txt", new Font("Courier New", 12));
                MessageBox.Show("Nota Jual berhasil dicetak");
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Mencetak data, Error : {error.Message}");
            }
        }
    }
}

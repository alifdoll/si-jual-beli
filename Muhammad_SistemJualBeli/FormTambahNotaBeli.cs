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
    public partial class FormTambahNotaBeli : Form
    {
        FormMaster form;
        NotaBeli nota = new NotaBeli();

        Supplier supplier = new Supplier();
        ArrayList listSupplier = new ArrayList();

        Barang barang = new Barang();
        ArrayList listBarang = new ArrayList();
        public FormTambahNotaBeli()
        {
            InitializeComponent();
        }

        private void TambahNotaBeli_Load(object sender, EventArgs e)
        {
            listSupplier = supplier.QueryData();
            comboBoxDaftarSupplier.DataSource = listSupplier;
            comboBoxDaftarSupplier.DisplayMember = "Nama";

            form = (FormMaster)Owner.MdiParent;
            labelKodePegawai.Text = form.pegawaiLogin.KodePegawai;
            labelNamaPegawai.Text = form.pegawaiLogin.Nama;

            textBoxNoNota.Text = nota.GeneratePrimaryKey();

            dateTimePickerTanggal.Value = DateTime.Now;

            if (comboBoxDaftarSupplier.SelectedIndex != -1)
            {
                labelAlamat.Text = ((Supplier)comboBoxDaftarSupplier.SelectedItem).Alamat;
            }

        }

        private void comboBoxDaftarSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = (Supplier)comboBoxDaftarSupplier.SelectedItem;
            labelAlamat.Text = supplier.Alamat;

            textBoxBarcode.Focus();
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
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
                    MessageBox.Show("Barang Tidak Ditemukan", "Error");
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (dataGridViewTambahNotaBeli.Rows.Count >= 1)
            {

                try
                {
                    Supplier supplier = (Supplier)comboBoxDaftarSupplier.SelectedItem;
                    nota = new NotaBeli(
                        textBoxNoNota.Text,
                        dateTimePickerTanggal.Value,
                        supplier,
                        form.pegawaiLogin);

                    for (int i = 0; i < dataGridViewTambahNotaBeli.Rows.Count - 1; i++)
                    {
                        string kode = dataGridViewTambahNotaBeli.Rows[i].Cells[0].Value.ToString();

                        listBarang = barang.QueryData("Barang.KodeBarang", kode);

                        int harga = int.Parse(dataGridViewTambahNotaBeli.Rows[i].Cells[2].Value.ToString());
                        int jumlah = int.Parse(dataGridViewTambahNotaBeli.Rows[i].Cells[3].Value.ToString());

                        nota.TambahNotaBeliDetil((Barang)listBarang[0], harga, jumlah);
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

                dataGridViewTambahNotaBeli.Rows.Add(
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

            for (int i = 0; i < dataGridViewTambahNotaBeli.Rows.Count - 1; i++)
            {
                int subtotal = int.Parse(dataGridViewTambahNotaBeli.Rows[i].Cells[4].Value.ToString());
                total += subtotal;
            }

            return total;
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaBeli.CetakNota("nonota", textBoxNoNota.Text, "nota_beli.txt", new Font("Courier New", 12));
                MessageBox.Show("Nota Beli berhasil dicetak");
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Mencetak data, Error : {error.Message}");
            }
        }
    }
}

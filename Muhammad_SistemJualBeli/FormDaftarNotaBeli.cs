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
    public partial class FormDaftarNotaBeli : Form
    {
        NotaBeli notaBeli = new NotaBeli();
        ArrayList listNota;
        public FormDaftarNotaBeli()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaBeli form = new FormTambahNotaBeli { Owner = this };
            form.Show();
        }

        private void FormDaftarNotaBeli_Load(object sender, EventArgs e)
        {
            listNota = notaBeli.QueryData();
            AssignData(listNota);
        }

        private void AssignData(ArrayList listNota)
        {
            if(listNota.Count > 0)
            {
                dataGridViewNotaBeli.Rows.Clear();
                foreach (NotaBeli nota in listNota)
                {
                    foreach (NotaBeliDetil notaBeliDetil in nota.ListNotaBeliDetil)
                    {
                        dataGridViewNotaBeli.Rows.Add(
                            nota.NoNota,
                            nota.Tanggal,
                            nota.Supplier.KodeSupplier,
                            nota.Supplier.Nama,
                            nota.Supplier.Alamat,
                            nota.Pegawai.KodePegawai,
                            nota.Pegawai.Nama,
                            notaBeliDetil.Barang.KodeBarang,
                            notaBeliDetil.Barang.Nama,
                            notaBeliDetil.Harga,
                            notaBeliDetil.Jumlah);
                    }
                }
            }
            else
            {
                dataGridViewNotaBeli.DataSource = null;
            }

           
        }
        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Clear();
        }

        private void textBoxCari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string criteria;
                switch (comboBoxCari.Text)
                {
                    case "Tanggal":
                        criteria = "tanggal";
                        break;

                    case "Kode Supplier":
                        criteria = "supplier.kodesupplier";
                        break;

                    case "Nama Supplier":
                        criteria = "supplier.nama";
                        break;

                    case "Alamat Supplier":
                        criteria = "supplier.alamat";
                        break;

                    case "Kode Pegawai":
                        criteria = "pegawai.kodepegawai";
                        break;

                    case "Nama Pegawai":
                        criteria = "pegawai.nama";
                        break;

                    default:
                        criteria = "nonota";
                        break;
                }
                
                if(textBoxCari.Text == "")
                {
                    AssignData(listNota);
                }
                else
                {
                    ArrayList listCari = notaBeli.QueryData(criteria, textBoxCari.Text);
                    AssignData(listCari);
                }
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string criteria;
            switch (comboBoxCari.Text)
            {
                case "Tanggal":
                    criteria = "tanggal";
                    break;

                case "Kode Supplier":
                    criteria = "supplier.kodesupplier";
                    break;

                case "Nama Supplier":
                    criteria = "supplier.nama";
                    break;

                case "Alamat Supplier":
                    criteria = "supplier.alamat";
                    break;

                case "Kode Pegawai":
                    criteria = "pegawai.kodepegawai";
                    break;

                case "Nama Pegawai":
                    criteria = "pegawai.nama";
                    break;

                default:
                    criteria = "nonota";
                    break;
            }
            try
            {
                if(textBoxCari.Text != "")
                {
                    NotaBeli.CetakNota(criteria, textBoxCari.Text, $"nota_beli_{comboBoxCari.Text}_{textBoxCari.Text}.txt", new Font("Courier New", 12));
                    MessageBox.Show("Nota Beli berhasil dicetak");
                }
                else
                {
                    NotaBeli.CetakNota("", textBoxCari.Text, "nota_beli_all.txt", new Font("Courier New", 12));
                    MessageBox.Show("Nota Beli berhasil dicetak");
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Mencetak data, Error : {error.Message}");
            }
        }
    }
}

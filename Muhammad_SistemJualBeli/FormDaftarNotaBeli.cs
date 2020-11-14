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
            AssignData();
        }
        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string criteria;
            switch (comboBoxCari.Text)
            {
                default:
                    criteria = "nonota";
                    break;

                case "Tanggal":
                    criteria = "tanggal";
                    break;

                case "Kode Supplier":
                    criteria = "kodesupplier";
                    break;

                case "Nama Supplier":
                    criteria = "supplier.nama";
                    break;

                case "Alamat Supplier":
                    criteria = "supplier.alamat";
                    break;

                case "Kode Pegawai":
                    criteria = "kodepegawai";
                    break;

                case "Nama Pegawai":
                    criteria = "pegawai.nama";
                    break;

            }

            listNota = notaBeli.QueryData(criteria, textBoxCari.Text);

            if (listNota.Count > 0)
            {
                AssignData();
            }
        }
        private void AssignData()
        {
            listNota = notaBeli.QueryData();

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
        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Clear();
        }
    }
}

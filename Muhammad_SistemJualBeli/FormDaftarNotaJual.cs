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
    public partial class FormDaftarNotaJual : Form
    {
        ArrayList listNota;
        NotaJual notaJual = new NotaJual();
        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual form = new FormTambahNotaJual { Owner = this };
            form.Show();
        }

        private void FormDaftarNotaJual_Load(object sender, EventArgs e)
        {
            listNota = notaJual.QueryData();
            AssignData();
        }

       

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Clear();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            /*
             No Nota
Tanggal
Kode Pelanggan
Nama Pelanggan
Alamat Pelanggan
Kode Pegawai
Nama Pegawai
Kode Barang
Nama Barang
Harga
Jumlah*/
            string criteria;
            switch (comboBoxCari.Text)
            {
                default:
                    criteria = "nonota";
                    break;

                case "Tanggal":
                    criteria = "tanggal";
                    break;

                case "Kode Pelanggan":
                    criteria = "kodepelanggan";
                    break;

                case "Nama Pelanggan":
                    criteria = "pelanggan.nama";
                    break;

                case "Alamat Pelanggan":
                    criteria = "pelanggan.alamat";
                    break;

                case "Kode Pegawai":
                    criteria = "kodepegawai";
                    break;

                case "Nama Pegawai":
                    criteria = "pegawai.nama";
                    break;

            }

            listNota = notaJual.QueryData(criteria, textBoxCari.Text);

            if(listNota.Count > 0)
            {
                AssignData();
            }
        }

        private void AssignData()
        {
            foreach (NotaJual nota in listNota)
            {
                foreach (NotaJualDetil notaJualDetil in nota.ListNotaJualDetil)
                {
                    dataGridViewNotaJual.Rows.Add(
                        nota.NoNota,
                        nota.Tanggal,
                        nota.Pelanggan.KodePelanggan,
                        nota.Pelanggan.Nama,
                        nota.Pelanggan.Alamat,
                        nota.Pegawai.KodePegawai,
                        nota.Pegawai.Nama,
                        notaJualDetil.Barang.KodeBarang,
                        notaJualDetil.Barang.Nama,
                        notaJualDetil.Harga,
                        notaJualDetil.Jumlah);
                }
            }
        }
    }
}

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
            AssignData(listNota);
        }

       

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Clear();
        }

        private void AssignData(ArrayList list)
        {
            if(list.Count > 0)
            {
                dataGridViewNotaJual.Rows.Clear(); 
                foreach (NotaJual nota in list)
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
            else
            {
                dataGridViewNotaJual.DataSource = null;
            }
           
        }

        private void textBoxCari_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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

                    case "Kode Pelanggan":
                        criteria = "pelanggan.kodepelanggan";
                        break;

                    case "Nama Pelanggan":
                        criteria = "pelanggan.nama";
                        break;

                    case "Alamat Pelanggan":
                        criteria = "pelanggan.alamat";
                        break;

                    case "Kode Pegawai":
                        criteria = "pegawai.kodepegawai";
                        break;

                    case "Nama Pegawai":
                        criteria = "pegawai.nama";
                        break;

                }
                if (textBoxCari.Text == "")
                {
                    AssignData(listNota);
                }
                else
                {
                    ArrayList listCari = notaJual.QueryData(criteria, textBoxCari.Text);
                    AssignData(listCari);
                }

                
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
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

                case "Kode Pelanggan":
                    criteria = "pelanggan.kodepelanggan";
                    break;

                case "Nama Pelanggan":
                    criteria = "pelanggan.nama";
                    break;

                case "Alamat Pelanggan":
                    criteria = "pelanggan.alamat";
                    break;

                case "Kode Pegawai":
                    criteria = "pegawai.kodepegawai";
                    break;

                case "Nama Pegawai":
                    criteria = "pegawai.nama";
                    break;

            }

            try
            {
                if(textBoxCari.Text != "")
                {
                    NotaJual.CetakNota(criteria, textBoxCari.Text, $"nota_jual_{comboBoxCari.Text}_{textBoxCari.Text}.txt", new Font("Courier New", 12));
                    MessageBox.Show("Nota Jual berhasil dicetak");
                }
                else
                {
                    NotaJual.CetakNota("", textBoxCari.Text, "nota_jual_all.txt", new Font("Courier New", 12));
                    MessageBox.Show("Nota Jual berhasil dicetak");
                }
               
            }
            catch (Exception error)
            {
                MessageBox.Show($"Gagal Mencetak data, Error : {error.Message}");
            }
        }
    }
}

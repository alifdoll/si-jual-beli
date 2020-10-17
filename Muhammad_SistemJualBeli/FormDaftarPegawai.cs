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
    public partial class FormDaftarPegawai : Form
    {
        ArrayList listPegawai = new ArrayList();
        Pegawai pegawai = new Pegawai();
        public FormDaftarPegawai()
        {
            InitializeComponent();
        }

        public void FormDaftarPegawai_Load(object sender, EventArgs e)
        {
            listPegawai = pegawai.QueryData();
            CustomDataGrid();
        }

        private void CustomDataGrid()
        {
            if (listPegawai.Count > 0)
            {
                dataGridViewPegawai.Rows.Clear();
                foreach (Pegawai pegawai in listPegawai)
                {
                    dataGridViewPegawai.Rows.Add(
                        pegawai.KodePegawai,
                        pegawai.Nama,
                        pegawai.Lahir,
                        pegawai.Alamat,
                        pegawai.Gaji,
                        pegawai.Username,
                        pegawai.Jabatan.IdJabatan,
                        pegawai.Jabatan.Nama);
                }
            }
            else
            {
                dataGridViewPegawai.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai form = new FormTambahPegawai { Owner = this };
            form.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string criteria;
            switch (comboBoxCari.Text)
            {
                case "Kode Pegawai":
                    criteria = "kodepegawai";
                    break;

                case "Nama Pegawai":
                    criteria = "pegawai.nama";
                    break;

                case "Lahir":
                    criteria = "tgllahir";
                    break;

                case "Alamat":
                    criteria = "alamat";
                    break;

                case "Gaji":
                    criteria = "gaji";
                    break;

                case "Username":
                    criteria = "username";
                    break;

                default:
                    criteria = "jabatan.nama";
                    break;
            }

            listPegawai = pegawai.QueryData(criteria, textBoxCari.Text);

            if(listPegawai.Count > 0)
            {
                CustomDataGrid();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan", "Warning");
                dataGridViewPegawai.DataSource = null;
            }
        }

        private void comboBoxCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Text = "";
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPegawai form = new FormUbahPegawai { Owner = this };
            form.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPegawai form = new FormHapusPegawai { Owner = this };
            form.Show();
        }
    }
}

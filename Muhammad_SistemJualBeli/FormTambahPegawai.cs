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
    public partial class FormTambahPegawai : Form
    {
        ArrayList listJabatan = new ArrayList();
        Jabatan jabatan = new Jabatan();
        Pegawai pegawai = new Pegawai();
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            string newCode = pegawai.GeneratePrimaryKey();

            textBoxKodePegawai.Text = newCode;

            listJabatan = jabatan.QueryData();
            comboBoxJabatan.DataSource = listJabatan;
            comboBoxJabatan.DisplayMember = "Nama";
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxPassword.Text == textBoxUlangPassword.Text)
                {
                    Jabatan jabat = (Jabatan)comboBoxJabatan.SelectedItem;
                    Pegawai pegawai = new Pegawai(
                        textBoxKodePegawai.Text,
                        textBoxNamaPegawai.Text,
                        dateTimePickerTanggalLahir.Value,
                        textBoxAlamat.Text,
                        int.Parse(textBoxGaji.Text),
                        textBoxUsername.Text,
                        textBoxPassword.Text,
                        jabat);

                    pegawai.Insert();

                    MessageBox.Show("Data Pegawai Berhasil Ditambahkan", "Info");

                    textBoxKodePegawai.Text = pegawai.GeneratePrimaryKey();
                    buttonKosongi_Click(buttonSimpan, e);

                    FormDaftarPegawai frm = (FormDaftarPegawai)Owner;
                    frm.FormDaftarPegawai_Load(buttonSimpan, e);
                }
                else
                {
                    MessageBox.Show("Mohon Ulangi Password");
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Gagal Menambahkan Data, Error = " + error.Message, "Warning");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaPegawai.Text = "";
            textBoxAlamat.Text = "";
            textBoxGaji.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxUlangPassword.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Now;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

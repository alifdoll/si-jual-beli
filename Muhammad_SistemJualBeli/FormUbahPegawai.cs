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
    public partial class FormUbahPegawai : Form
    {
        ArrayList list = new ArrayList();
        
        Pegawai pegawai = new Pegawai();
        

        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            Jabatan jabatan = new Jabatan();
            ArrayList listjabat = jabatan.QueryData();
            comboBoxJabatan.DataSource = listjabat;
            comboBoxJabatan.DisplayMember = "Nama";

        }

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {

            if (textBoxKodePegawai.Text.Length <= textBoxKodePegawai.MaxLength)
            {
                list = pegawai.QueryData("kodepegawai", textBoxKodePegawai.Text);

                Pegawai peg = (Pegawai)list[0];
                textBoxNamaPegawai.Text = peg.Nama;
                dateTimePickerTanggalLahir.Value = peg.Lahir;
                textBoxAlamat.Text = peg.Alamat;
                textBoxGaji.Text = peg.Gaji.ToString();
                textBoxUsername.Text = peg.Username;
                textBoxPassword.Text = peg.Password;
                comboBoxJabatan.Text = peg.Jabatan.Nama;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Jabatan jabat = (Jabatan)comboBoxJabatan.SelectedItem;

                Pegawai pegUbah = new Pegawai(
                    textBoxKodePegawai.Text,
                    textBoxNamaPegawai.Text,
                    dateTimePickerTanggalLahir.Value,
                    textBoxAlamat.Text,
                    int.Parse(textBoxGaji.Text),
                    textBoxUsername.Text,
                    textBoxPassword.Text,
                    jabat);

                pegUbah.Update();

                
                MessageBox.Show("Data Berhasil Diubah" + pegUbah.Password, "Info");


                buttonKosongi_Click(buttonUbah, e);
                FormDaftarPegawai frm = (FormDaftarPegawai)Owner;
                frm.FormDaftarPegawai_Load(buttonUbah, e);

            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Mengubah Data, Error : {error.Message}", "Info");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaPegawai.Text = "";
            dateTimePickerTanggalLahir.Value = DateTime.Now;
            textBoxAlamat.Text = "";
            textBoxGaji.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            comboBoxJabatan.SelectedIndex = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

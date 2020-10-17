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
    public partial class FormHapusPegawai : Form
    {
        ArrayList list = new ArrayList();
        Pegawai pegawai = new Pegawai();
        public FormHapusPegawai()
        {
            InitializeComponent();
        }

        private void FormHapusPegawai_Load(object sender, EventArgs e)
        {
            Jabatan jabatan = new Jabatan();
            ArrayList listjabat = jabatan.QueryData();
            comboBoxJabatan.DataSource = listjabat;
            comboBoxJabatan.DisplayMember = "Nama";
        }

        private void textBoxKodePegawai_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch(Exception error)
            {
                MessageBox.Show($"Gagal, Error : {error.Message}", "Error");
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

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxKodePegawai.Text != "")
                {
                    DialogResult confirm = MessageBox.Show("Data akan dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        Pegawai pegDel = new Pegawai(textBoxKodePegawai.Text);
                        string del = pegDel.Delete();

                        if(del == "1")
                        {
                            MessageBox.Show("Data Berhasil Dihapus", "Info");
                            buttonKosongi_Click(buttonHapus, e);
                            FormDaftarPegawai frm = (FormDaftarPegawai)Owner;
                            frm.FormDaftarPegawai_Load(buttonHapus, e);
                        }
                        else
                        {
                            MessageBox.Show($"Gagal Menghapus Data, Error : {del}", "Error");
                        }

                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Gagal Menghapus Data, Error : {error.Message}", "Error");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

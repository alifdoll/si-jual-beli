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
using JualBeli_LIB;

namespace Muhammad_SistemJualBeli
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Height = 50 + panelLogin.Height;
            textBoxServer.Text = "127.0.0.1";
            textBoxDatabase.Text = "si_jual_beli";
            textBoxUsername.Text = "andrew";
            textBoxPassword.Text = "1234";
        }

        private void linkLabelPengaturan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Height = 50 + panelLogin.Height + panelPengaturan.Height;
        }

       

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxServer.Text != "" && textBoxDatabase.Text != "")
            {
                Height = 50 + panelLogin.Height;
            }
            else
            {
                MessageBox.Show("Nama server dan database tidak boleh kososng", "Kesalahan");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList list = new ArrayList();
                Pegawai pegawai = new Pegawai();

                if (textBoxUsername.Text != "")
                {
                    Koneksi koneksi = new Koneksi(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

                    MessageBox.Show("Koneksi Berhasil", "Sukses");

                    Owner.Enabled = true;

                    list = pegawai.QueryData("username", textBoxUsername.Text);

                    if(list.Count > 0)
                    {
                        FormMaster form = (FormMaster)Owner;
                        form.labelKodePegawai.Text = ((Pegawai)list[0]).KodePegawai.ToString();
                        form.labelNamaPegawai.Text = ((Pegawai)list[0]).Nama;
                        form.labelJabatan.Text = ((Pegawai)list[0]).Jabatan.IdJabatan;

                        form.HakAkses(((Pegawai)list[0]).Jabatan);
                        form.pegawaiLogin = ((Pegawai)list[0]);
                    }

                    Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }
    }
}

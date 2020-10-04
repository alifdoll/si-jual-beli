using System;
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
            textBoxUsername.Text = "root";
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
                if (textBoxUsername.Text != "")
                {
                    Koneksi koneksi = new Koneksi(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

                    MessageBox.Show("Koneksi Berhasil", "Sukses");

                    Owner.Enabled = true;

                    Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }
    }
}

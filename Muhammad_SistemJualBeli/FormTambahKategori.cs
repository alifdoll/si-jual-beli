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
    public partial class FormTambahKategori : Form
    {
        FormDaftarKategori frm ;
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void FormTambahKategori_Load(object sender, EventArgs e)
        {
            string newCode = Database.GenerateID("Kategori", "KodeKategori",2);

            textBoxKodeKategori.Text = newCode;
            textBoxNamaKategori.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);
                kategori.Insert();

                frm = (FormDaftarKategori)Owner;
                frm.FormDaftarKategori_Load(buttonSimpan, e);

                MessageBox.Show("Data Kategori Telah Tersimpan", "Info");

                textBoxKodeKategori.Text = Database.GenerateID("Kategori", "KodeKategori",2);
                textBoxNamaKategori.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Penyimpanan gagal, Error : " + error.Message, "Info");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

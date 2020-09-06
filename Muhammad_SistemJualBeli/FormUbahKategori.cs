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
    public partial class FormUbahKategori : Form
    {
        ArrayList listKategori = new ArrayList();
        Kategori kategori = new Kategori();

        public FormUbahKategori()
        {
            InitializeComponent();
        }

        private void FormUbahKategori_Load(object sender, EventArgs e)
        {

        }

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeKategori.Text.Length == textBoxKodeKategori.MaxLength)
            {
                listKategori = kategori.QueryData(kategori,"KodeKategori", textBoxKodeKategori.Text);
                if(listKategori.Count > 0)
                {
                    textBoxNamaKategori.Text = ((Kategori)listKategori[0]).Nama;
                    textBoxNamaKategori.Focus();
                   
                }
                else
                {
                    MessageBox.Show("Kode Kategori Tidak Ditemukan.", "Warning");
                    textBoxKodeKategori.Text = "";
                }
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);

                kategori.Update();

                FormDaftarKategori frm = (FormDaftarKategori)Owner;
                frm.FormDaftarKategori_Load(buttonSimpan, e);

                MessageBox.Show("Data Kategori Telah Diubah", "Info");


                textBoxKodeKategori.Text = "";
                textBoxNamaKategori.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Gagal mengubah data, Error : " + error.Message, "Info");
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

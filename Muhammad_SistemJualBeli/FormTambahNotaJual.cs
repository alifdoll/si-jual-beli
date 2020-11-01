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
    public partial class FormTambahNotaJual : Form
    {
        Pelanggan pelanggan = new Pelanggan();
        ArrayList listPelanggan = new ArrayList();

        NotaJual nota = new NotaJual();
        
        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            listPelanggan = pelanggan.QueryData();
            comboBoxDaftarPelanggan.DataSource = listPelanggan;
            comboBoxDaftarPelanggan.DisplayMember = "Nama";

            FormMaster form = (FormMaster)Owner.MdiParent;
            labelKodePegawai.Text = form.pegawaiLogin.KodePegawai;
            labelNamaPegawai.Text = form.pegawaiLogin.Nama;

            textBoxNoNota.Text = nota.GeneratePrimaryKey();
        }

        private void comboBoxDaftarPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pelanggan pelanggan = (Pelanggan)comboBoxDaftarPelanggan.SelectedItem;
            labelAlamat.Text = pelanggan.Alamat;

            textBoxBarcode.Focus();
        }
    }
}

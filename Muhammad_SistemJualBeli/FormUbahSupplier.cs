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
    public partial class FormUbahSupplier : Form
    {
        ArrayList listSupplier = new ArrayList();
        Supplier supplier = new Supplier();
        public FormUbahSupplier()
        {
            InitializeComponent();
        }

        private void textBoxKodeSupplier_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeSupplier.Text.Length <= textBoxKodeSupplier.MaxLength)
            {
                listSupplier = supplier.QueryData(supplier, "KodeSupplier", textBoxKodeSupplier.Text);

                if(listSupplier.Count > 0)
                {
                    textBoxNamaSupplier.Focus();
                    textBoxNamaSupplier.Text = ((Supplier)listSupplier[0]).Nama;
                    textBoxAlamat.Text = ((Supplier)listSupplier[0]).Alamat;
                }
                else
                {
                    MessageBox.Show("Kode Supplier Tidak Ditemukan", "Warning");
                }
            }

        }
       
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier(textBoxKodeSupplier.Text, textBoxNamaSupplier.Text, textBoxAlamat.Text);

                supplier.Update();

                MessageBox.Show("Data Supplier Berhasil Diubah", "Info");

                FormDaftarSupplier frm = (FormDaftarSupplier)Owner;
                frm.FormDaftarSupplier_Load(buttonSimpan, e);

                buttonKosongi_Click(buttonSimpan, e);
                textBoxKodeSupplier.Focus();
            }
            catch(Exception error)
            {
                MessageBox.Show("Data Gagal Disimpan, Error : " + error.Message, "Warning");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamat.Text = "";
            textBoxKodeSupplier.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

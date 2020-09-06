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
    public partial class FormHapusSupplier : Form
    {
        ArrayList listSupplier = new ArrayList();
        Supplier supplier = new Supplier();
        public FormHapusSupplier()
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
                    textBoxKodeSupplier.Text = "";
                    textBoxNamaSupplier.Text = "";
                    textBoxAlamat.Text = "";
                }
            }
        }


        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Data Supplier Akan Dihapus. Anda Yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                Supplier supplier = new Supplier(textBoxKodeSupplier.Text, textBoxNamaSupplier.Text, textBoxAlamat.Text);
                string hapus = supplier.Delete();

                if(hapus == "1")
                {
                    MessageBox.Show("Data Supplier Berhasil Dihapus", "Info");
                    FormDaftarSupplier frm = (FormDaftarSupplier)Owner;
                    frm.FormDaftarSupplier_Load(buttonHapus, e);
                    buttonKosongi_Click(buttonHapus, e);
                }
                else
                {
                    MessageBox.Show("Data Supplier Gagal Dihapus, Error : " + hapus, "Warning");
                }
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKodeSupplier.Text = "";
            textBoxNamaSupplier.Text = "";
            textBoxAlamat.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

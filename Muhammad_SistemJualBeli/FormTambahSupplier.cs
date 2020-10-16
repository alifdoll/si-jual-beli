using JualBeli_LIB;
using System;
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
    public partial class FormTambahSupplier : Form
    {
        Supplier supplier = new Supplier();

        public FormTambahSupplier()
        {
            InitializeComponent();
        }

        private void FormTambahSupplier_Load(object sender, EventArgs e)
        {
            string newId = supplier.GeneratePrimaryKey();

            textBoxKodeSupplier.Text = newId;
            textBoxNamaSupplier.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier(textBoxKodeSupplier.Text, textBoxNamaSupplier.Text, textBoxAlamat.Text);
                supplier.Insert();

                MessageBox.Show("Data Supplier Berhasil Ditambahkan", "Info");

                FormDaftarSupplier frm = (FormDaftarSupplier)Owner;
                frm.FormDaftarSupplier_Load(buttonSimpan, e);

                textBoxKodeSupplier.Text = supplier.GeneratePrimaryKey();

                buttonKosongi_Click(buttonSimpan, e);
            }
            catch(Exception error)
            {
                MessageBox.Show("Gagal Menambahkan Data Supplier, Error : " + error.Message, "Warning");
            }
            
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaSupplier.Text = "";
            textBoxAlamat.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

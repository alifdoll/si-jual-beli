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
    public partial class FormDaftarSupplier : Form
    {
        ArrayList listSupplier = new ArrayList();
        Supplier supplier = new Supplier();

        public FormDaftarSupplier()
        {
            InitializeComponent();
        }

        public void FormDaftarSupplier_Load(object sender, EventArgs e)
        {
            listSupplier = supplier.QueryData(supplier);
            if(listSupplier.Count > 0)
            {
                dataGridViewSupplier.DataSource = listSupplier;
            }
            else
            {
                dataGridViewSupplier.DataSource = null;
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxKode.Text == "Kode")
            {
                listSupplier = supplier.QueryData(supplier, "KodeSupplier", textBoxCari.Text);
            }
            else
            {
                listSupplier = supplier.QueryData(supplier, "Nama", textBoxCari.Text);
            }

            if(listSupplier.Count > 0)
            {
                dataGridViewSupplier.DataSource = listSupplier;
            }
            else
            {
                dataGridViewSupplier.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahSupplier form = new FormTambahSupplier { Owner = this };
            form.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahSupplier form = new FormUbahSupplier { Owner = this };
            form.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusSupplier form = new FormHapusSupplier { Owner = this };
            form.Show(); 
        }

        private void comboBoxKode_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxCari.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

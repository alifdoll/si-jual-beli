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
    public partial class FormDaftarKategori : Form
    {
        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori formTambah = new FormTambahKategori();
            formTambah.Owner = this;
            formTambah.Show();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategori formUbah = new FormUbahKategori();
            formUbah.Owner = this;
            formUbah.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategori form = new FormHapusKategori();
            form.Owner = this;
            form.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

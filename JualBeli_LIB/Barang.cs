using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Barang : Database
    {
        #region members
        private string kodeBarang;
        private string barcode;
        private string nama;
        private double hargaJual;
        private int stok;
        private Kategori kategori;
        #endregion


        public Barang(string kode, string barcode, string nama, double harga, int stok, Kategori kategori)
        {
            KodeBarang = kode;
            Barcode = barcode;
            Nama = nama;
            hargaJual = harga;
            Stok = stok;
            Kategori = kategori;
        }

        #region properties
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Nama { get => nama; set => nama = value; }
        public double HargaJual { get => hargaJual; set => hargaJual = value; }
        public int Stok { get => stok; set => stok = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        #endregion
        

        public override void Insert()
        {

            string sql = "insert into barang(kodebarang, barcode, nama, hargajual, stok, kodekategori) values ('" +
                KodeBarang + "','" +
                Barcode + "','" +
                Nama.Replace("'", "\\") + "','" +
                HargaJual + "','" +
                Stok + "','" +
                Kategori.KodeKategori + "')";

            Koneksi.ExecuteDML(sql);
        }

        public override void Update()
        {
            string sql = "update barang set barcode='" + Barcode +
                "',nama='" + Nama +
                "',hargajual='" + HargaJual +
                "',stok='" + Stok +
                "',kodekategori='" + Kategori.KodeKategori +
                "' where kodeBarang='" + KodeBarang + "'";

            Koneksi.ExecuteDML(sql);
        }

        public override string Delete()
        {
            string sql = "DELETE FROM barang WHERE kodebarang = '" + KodeBarang + "'";

            try
            {
                Koneksi.ExecuteDML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", Perintah sql : " + sql;
            }
        }

        public override ArrayList QueryData(Database database, string criteria = "", string value = "")
        {
            throw new NotImplementedException();
        }


    }
}

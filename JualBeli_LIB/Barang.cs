using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Barang : IDatabase
    {
        #region members
        private string kodeBarang;
        private string barcode;
        private string nama;
        private double hargaJual;
        private int stok;
        private Kategori category;
        #endregion

        #region properties
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Nama { get => nama; set => nama = value; }
        public double HargaJual { get => hargaJual; set => hargaJual = value; }
        public int Stok { get => stok; set => stok = value; }
        public Kategori Kategori { get => category; set => category = value; }
        #endregion

        public Barang()
        {
            KodeBarang = "";
            Barcode = "";
            Nama = "";
            hargaJual = 0;
            Stok = 0;
            Kategori = new Kategori();
        }

        public Barang(string kode, string barcode, string nama, double harga, int stok, Kategori kategori)
        {
            KodeBarang = kode;
            Barcode = barcode;
            Nama = nama;
            hargaJual = harga;
            Stok = stok;
            Kategori = kategori;
        }

        public void Insert()
        {
            string sql ="insert into barang(kodebarang, barcode, nama, hargajual, stok, kodekategori) values ('" +
                        KodeBarang + "','" +
                        Barcode + "','" +
                        Nama.Replace("'", "\\") + "','" +
                        HargaJual + "','" +
                        Stok + "','" +
                        Kategori.KodeKategori + "')";

            Execute.DML(sql);
        }

        //asumsikan bahwa kategori, stok, dan kode barang tidak dapat diubah
        //apabila kategori diubah maka kode barang ikut berubah, diberi asumsi tidak dapat diubah
        public void Update()
        {
            string sql = "update barang set barcode='" + Barcode +
                        "',nama='" + Nama +
                        "',hargajual='" + HargaJual +
                        "' where kodeBarang='" + KodeBarang + "'";

            Execute.DML(sql);
        }

        public string Delete()
        {
            string sql = "DELETE FROM barang WHERE kodebarang = '" + KodeBarang + "'";

            try
            {
                Execute.DML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", Perintah sql : " + sql;
            }
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql;
            if (criteria == "")
            {
                sql = "select barang.kodebarang, barang.barcode, barang.nama, barang.hargajual, barang.stok, barang.kodekategori ,kategori.nama as NamaKategori " +
                    "from Barang inner join Kategori on barang.kodekategori = kategori.kodekategori";
            }
            else
            {
                sql = "select barang.kodebarang, barang.barcode, barang.nama, barang.hargajual, barang.stok, barang.kodekategori ,kategori.nama as NamaKategori " +
                    "from Barang inner join Kategori on barang.kodekategori = kategori.kodekategori" +
                    " where " + criteria + " LIKE '%" + value + "%'";
            }

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);

            ArrayList listItem = new ArrayList();

            while (result.Read() == true)
            {
                Kategori kat = new Kategori(result.GetValue(5).ToString(), result.GetValue(6).ToString());
                Barang barang = new Barang(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(),
                    result.GetDouble(3),
                    result.GetInt32(4),
                    kat);

                listItem.Add(barang);
            }

            return listItem;
        }

        public string GeneratePrimaryKey()
        {
            string sql = "select max(right(kodebarang,3)) from barang where kodekategori = '" + Kategori.KodeKategori + "'";

            string code = "";

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);
            if (result.Read() == true)
            {
                if (result.GetValue(0).ToString() != "")
                {
                    int newCode = result.GetInt32(0) + 1;

                    code = Kategori.KodeKategori + newCode.ToString().PadLeft(3, '0');

                }
                else
                {
                    code = Kategori.KodeKategori + "001";
                }

            }

            return code;
        }

        public string GeneratePrimaryKey(Kategori kategori)
        {
            Kategori = kategori;
            return GeneratePrimaryKey();
        }


        public static void UpdateStok(string jenisTransaksi, string kodeBarang, int jumlah)
        {
            string sql;
            if(jenisTransaksi == "penjualan")
            {
                sql = $"UPDATE Barang Set Stok = Stok - {jumlah} WHERE KodeBarang = '{kodeBarang}'";
            }
            else
            {
                sql = $"UPDATE Barang Set Stok = Stok + {jumlah} WHERE KodeBarang = '{kodeBarang}'";
            }
            Execute.DML(sql);
        }

        public static void KurangiStok(string kodeBarang, int jumlah)
        {
            string sql = $"UPDATE BARANG SET Stok = Stok + {jumlah} WHERE KodeBarang = '{kodeBarang}'";
            Execute.DML(sql);
        }

    }
}

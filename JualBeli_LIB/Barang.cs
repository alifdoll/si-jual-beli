using MySql.Data.MySqlClient;
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
        private Kategori category;
        #endregion

        public Barang()
        {
            KodeBarang = "";
            Barcode = "";
            Nama = "";
            hargaJual = 0;
            Stok = 0;
            Kategori = new Kategori("1","Kategori");
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

        #region properties
        public string KodeBarang { get => kodeBarang; set => kodeBarang = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public string Nama { get => nama; set => nama = value; }
        public double HargaJual { get => hargaJual; set => hargaJual = value; }
        public int Stok { get => stok; set => stok = value; }
        public Kategori Kategori { get => category; set => category = value; }
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

        protected override string QueryCommand(string database = "", string criteria = "", string value = "")
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

            return sql;
        }

        public override ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql = QueryCommand(criteria: criteria, value: value);

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

        public static string GenerateItemCode(Kategori kategori)
        {
            string sql = "select max(right(kodebarang,3)) from barang where kodekategori = '" + kategori.KodeKategori + "'";

            string code = "";

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);
            if (result.Read() == true)
            {
                if(result.GetValue(0).ToString() != "")
                {
                    int newCode = result.GetInt32(0) + 1;

                    code = kategori.KodeKategori + newCode.ToString().PadLeft(3, '0');

                }
                else
                {
                    code = kategori.KodeKategori + "001";
                }

            }
            

            return code;
        }
    }
}

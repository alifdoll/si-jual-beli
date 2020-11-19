using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace JualBeli_LIB
{
    public class NotaBeli : IDatabase
    {

        #region members
        private string noNota;
        private DateTime tanggal;
        private Supplier supplier;
        private Pegawai pegawai;
        private List<NotaBeliDetil> listNotaBeliDetil;
        #endregion

        #region properties
        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public List<NotaBeliDetil> ListNotaBeliDetil { get => listNotaBeliDetil; set => listNotaBeliDetil = value; }
        #endregion

        #region constructors
        public NotaBeli(string noNota, DateTime tanggal, Supplier supplier, Pegawai pegawai)
        {
            NoNota = noNota;
            Tanggal = tanggal;
            Supplier = supplier;
            Pegawai = pegawai;
            ListNotaBeliDetil = new List<NotaBeliDetil>();
        }

        public NotaBeli()
        {
            NoNota = "";
            Tanggal = DateTime.Now;
            Supplier = new Supplier();
            Pegawai = new Pegawai();
            ListNotaBeliDetil = new List<NotaBeliDetil>();
        }
        #endregion

        #region methods
        public void Insert()
        {
            

            using(TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    string sql1 = $"INSERT INTO NotaBeli(NoNota, Tanggal, KodeSupplier, KodePegawai) VALUES ('{NoNota}', '{Tanggal:yyy-MM-dd hh:mm:ss}'," +
                                  $" '{Supplier.KodeSupplier}', '{Pegawai.KodePegawai}')";

                    Execute.DML(sql1);

                    foreach (NotaBeliDetil nota in ListNotaBeliDetil)
                    {
                        string sql2 = $"INSERT INTO NotaBeliDetil(NoNota, KodeBarang, Harga, Jumlah) VALUES ('{NoNota}', '{nota.Barang.KodeBarang}', '{nota.Harga}', '{nota.Jumlah}')";

                        Execute.DML(sql2);

                        Barang.UpdateStok("pembelian", nota.Barang.KodeBarang, nota.Jumlah);
                        //Barang.KurangiStok(nota.Barang.KodeBarang, nota.Jumlah);
                    }

                    transaction.Complete();
                }
                catch(Exception error)
                {
                    transaction.Dispose();
                    throw new Exception(error.Message);
                }
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql;
            if(criteria == "")
            {
                sql = $"SELECT notabeli.nonota, notabeli.tanggal, notabeli.kodesupplier, supplier.nama as NamaSupplier, supplier.alamat as AlamatSupplier, " +
                    $"notabeli.kodepegawai, pegawai.nama as NamaPegawai " +
                    $"FROM notabeli " +
                    $"INNER JOIN supplier ON notabeli.kodesupplier = supplier.kodesupplier " +
                    $"INNER JOIN pegawai on notabeli.kodepegawai = pegawai.kodepegawai " +
                    $"ORDER BY notabeli.nonota DESC";
                 
            }
            else
            {
                sql = $"SELECT notabeli.nonota, notabeli.tanggal, notabeli.kodesupplier, supplier.nama as NamaSupplier, supplier.alamat as AlamatSupplier, " +
                    $"notabeli.kodepegawai, pegawai.nama as NamaPegawai " +
                    $"FROM notabeli " +
                    $"INNER JOIN supplier ON notabeli.kodesupplier = supplier.kodesupplier " +
                    $"INNER JOIN pegawai on notabeli.kodepegawai = pegawai.kodepegawai " +
                    $"WHERE {criteria} LIKE '%{value}%' " +
                    $"ORDER BY notabeli.nonota DESC";
            }

            MySqlDataReader result = Execute.Query(sql);
            ArrayList listNota = new ArrayList();

            while (result.Read())
            {
                string noNota = result.GetValue(0).ToString();

                DateTime tanggal = result.GetDateTime(1);

                ArrayList listSupplier = Supplier.QueryData("KodeSupplier", result.GetValue(2).ToString());

                ArrayList listPegawai = Pegawai.QueryData("KodePegawai", result.GetValue(5).ToString());

                NotaBeli nota = new NotaBeli(noNota, tanggal, (Supplier)listSupplier[0], (Pegawai)listPegawai[0]);

                string sqlDetil = $"SELECT notabelidetil.kodebarang, barang.nama, notabelidetil.harga, notabelidetil.jumlah " +
                    $"FROM notabeli " +
                    $"INNER JOIN notabelidetil on notabeli.nonota = notabelidetil.nonota " +
                    $"INNER JOIN barang on notabelidetil.kodebarang = barang.kodebarang " +
                    $"WHERE notabeli.nonota = '{noNota}'";

                MySqlDataReader detil = Execute.Query(sqlDetil);

                while (detil.Read())
                {
                    Barang barang = new Barang();

                    ArrayList listBarang = barang.QueryData("Barang.KodeBarang", detil.GetValue(0).ToString());

                    int harga = detil.GetInt32(2);
                    int jumlah = detil.GetInt32(3);

                    nota.TambahNotaBeliDetil((Barang)listBarang[0], harga, jumlah);

                }

                listNota.Add(nota);
            }

            return listNota;
        }

        public string GeneratePrimaryKey()
        {
            string sql = $"SELECT RIGHT(NoNota,3) as NoUrutTransaksi FROM notabeli WHERE Date(Tanggal) = Date(CURRENT_DATE) ORDER BY Tanggal DESC limit 1";

            MySqlDataReader result = Execute.Query(sql);
            string hasilNota = "";

            if (result.Read())
            {
                if (result.GetValue(0).ToString() != "")
                {
                    int noUrut = result.GetInt32(0) + 1;
                    hasilNota = DateTime.Now.Year +
                                DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                noUrut.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                hasilNota = DateTime.Now.Year +
                            DateTime.Now.Month.ToString().PadLeft(2, '0') +
                            DateTime.Now.Day.ToString().PadLeft(2, '0') +
                            "001";

            }

            return hasilNota.ToString();
        }

        public void TambahNotaBeliDetil(Barang barang, int harga, int jumlah)
        {
            NotaBeliDetil nota = new NotaBeliDetil(barang, harga, jumlah);

            ListNotaBeliDetil.Add(nota);
        }

        public static void CetakNota(string criteria, string value, string namaFile, Font font)
        {
            NotaBeli nota = new NotaBeli();
            ArrayList listNota = new ArrayList();

            listNota = nota.QueryData(criteria, value);

            StreamWriter file = new StreamWriter(namaFile);

            foreach (NotaBeli notaBeli in listNota)
            {
                file.WriteLine("");
                file.WriteLine("TOKO ALIP");
                file.WriteLine("Jl. menuju surga");
                file.WriteLine("Telp. (031)- 123445");
                file.WriteLine("=".PadRight(50, '='));

                file.WriteLine("No. Nota : " + notaBeli.NoNota);
                file.WriteLine("Tanggal : " + notaBeli.Tanggal);
                file.WriteLine("");
                file.WriteLine("Pegawai : " + notaBeli.Supplier.Nama);
                file.WriteLine("Alamat : " + notaBeli.Supplier.Alamat);
                file.WriteLine("");
                file.WriteLine("Kasir : " + notaBeli.Pegawai.Nama);
                file.WriteLine("=".PadRight(50, '='));

                int grandTotal = 0;

                foreach (NotaBeliDetil notaBeliDetil in notaBeli.ListNotaBeliDetil)
                {
                    string nama = notaBeliDetil.Barang.Nama;

                    if (nama.Length > 30)
                    {
                        nama = nama.Substring(0, 30);
                    }

                    int jumlah = notaBeliDetil.Jumlah;
                    int harga = notaBeliDetil.Harga;
                    int subTotal = jumlah * harga;

                    file.Write(nama.PadRight(30, ' '));
                    file.Write(jumlah.ToString().PadRight(3, ' '));
                    file.Write(harga.ToString("#,##").PadRight(7, ' '));
                    file.Write(subTotal.ToString("#,##").PadRight(10, ' '));
                    file.WriteLine("");
                    grandTotal += subTotal;
                }

                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine($"TOTAL : {grandTotal:#,##}");
                file.WriteLine("=".PadRight(50, '='));
                file.WriteLine();
            }

            file.Close();

            Cetak c = new Cetak(namaFile, font, 20, 10, 10, 10);
            c.CetakKePrinter("text");
        }
        #endregion









    }
}

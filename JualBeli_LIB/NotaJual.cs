using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace JualBeli_LIB
{
    public class NotaJual : IDatabase
    {
        #region members
        private string noNota;
        private DateTime tanggal;
        private Pelanggan pelanggan;
        private Pegawai pegawai;
        private List<NotaJualDetil> listNotaJualDetil;
        #endregion

        #region properties
        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public List<NotaJualDetil> ListNotaJualDetil { get => listNotaJualDetil; private set => listNotaJualDetil = value; }
        #endregion

        #region constructors
        public NotaJual(string noNota, DateTime tanggal, Pelanggan pelanggan, Pegawai pegawai)
        {
            NoNota = noNota;
            Tanggal = tanggal;
            Pelanggan = pelanggan;
            Pegawai = pegawai;
            ListNotaJualDetil = new List<NotaJualDetil>();
        }

        public NotaJual()
        {
            NoNota = "";
            Tanggal = DateTime.Now;
            Pelanggan = new Pelanggan();
            Pegawai = new Pegawai();
            ListNotaJualDetil = new List<NotaJualDetil>();
        }
        #endregion

        #region methods
        public void Insert()
        {
            using(TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    string sql = $"INSERT INTO NotaJual(NoNota, Tanggal, KodePelanggan, KodePegawai) VALUES ('{NoNota}', '{Tanggal:yyy-MM-dd hh:mm:ss}'," +
                                $" '{Pelanggan.KodePelanggan}', '{Pegawai.KodePegawai}')";
                    
                    Execute.DML(sql);

                    foreach (NotaJualDetil nota in ListNotaJualDetil)
                    {
                        string sqlNota = $"INSERT INTO NotaJualDetil(NoNota, KodeBarang, Harga, Jumlah) VALUES ('{NoNota}', '{nota.Barang.KodeBarang}', '{nota.Harga}', '{nota.Jumlah}')";

                        Execute.DML(sqlNota);

                        Barang.UpdateStok("penjualan", nota.Barang.KodeBarang, nota.Jumlah);
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
            if (criteria == "")
            {
                sql =$"SELECT notajual.nonota, notajual.tanggal, notajual.kodepelanggan, pelanggan.nama as NamaPelanggan, pelanggan.alamat as AlamatPelanggan, " +
                    $"notajual.kodepegawai, pegawai.nama as NamaPegawai " +
                    $"FROM notajual " +
                    $"INNER JOIN pelanggan ON notajual.kodepelanggan = pelanggan.kodepelanggan " +
                    $"INNER JOIN pegawai on notajual.kodepegawai = pegawai.kodepegawai " +
                    $"ORDER BY notajual.nonota DESC"; 
            }
            else
            {
                sql = $"SELECT notajual.nonota, notajual.tanggal, notajual.kodepelanggan, pelanggan.nama as NamaPelanggan, pelanggan.alamat as AlamatPelanggan, " +
                    $"notajual.kodepegawai, pegawai.nama as NamaPegawai " +
                    $"FROM notajual " +
                    $"INNER JOIN pelanggan ON notajual.kodepelanggan = pelanggan.kodepelanggan " +
                    $"INNER JOIN pegawai on notajual.kodepegawai = pegawai.kodepegawai " +
                    $"WHERE {criteria} LIKE '%{value}%' " +
                    $"ORDER BY notajual.nonota DESC";
            }

            MySqlDataReader result = Execute.Query(sql);
            ArrayList listNota = new ArrayList();

            while (result.Read())
            {
                string noNota = result.GetValue(0).ToString();

                DateTime tanggal = result.GetDateTime(1);

                ArrayList listPelanggan = Pelanggan.QueryData("KodePelanggan", result.GetValue(2).ToString());

                ArrayList listPegawai = Pegawai.QueryData("Pegawai.KodePegawai", result.GetValue(5).ToString());

                NotaJual nota = new NotaJual(noNota, tanggal, (Pelanggan)listPelanggan[0], (Pegawai)listPegawai[0]);

                string sqlDetil = $"SELECT notajualdetil.kodebarang, barang.nama, notajualdetil.harga, notajualdetil.jumlah " +
                    $"FROM notajual " +
                    $"INNER JOIN notajualdetil on notajual.nonota = notajualdetil.nonota " +
                    $"INNER JOIN barang on notajualdetil.kodebarang = barang.kodebarang " +
                    $"WHERE notajual.nonota = '{noNota}'";

                MySqlDataReader detil = Execute.Query(sqlDetil);

                while (detil.Read())
                {
                    Barang barang = new Barang();
                    ArrayList listBarang = barang.QueryData("barang.kodebarang", detil.GetValue(0).ToString());

                    int harga = detil.GetInt32(2);
                    int jumlah = detil.GetInt32(3);

                    nota.TambahNotaJualDetil((Barang)listBarang[0], harga, jumlah);
                }

                listNota.Add(nota);
            }
            return listNota;
        }

        public string GeneratePrimaryKey()
        {
            string sql = $"SELECT RIGHT(NoNota,3) as NoUrutTransaksi FROM notajual WHERE Date(Tanggal) = Date(CURRENT_DATE) ORDER BY Tanggal DESC limit 1";

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

        public void TambahNotaJualDetil(Barang barang, int harga, int jumlah)
        {
            NotaJualDetil nota = new NotaJualDetil(barang, harga, jumlah);

            ListNotaJualDetil.Add(nota);
        }
        #endregion








    }
}

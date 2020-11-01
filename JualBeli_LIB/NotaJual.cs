using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class NotaJual : IDatabase
    {
        private string noNota;
        private DateTime tanggal;
        private Pelanggan pelanggan;
        private Pegawai pegawai;
        private List<NotaJualDetil> listNotaJualDetil;

        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public List<NotaJualDetil> ListNotaJualDetil { get => listNotaJualDetil; private set => listNotaJualDetil = value; }


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

        public void Insert()
        {
            string sql1 = $"INSERT INTO NotaJual(NoNota, Tanggal, KodePelanggan, KodePegawai) VALUES ('{NoNota}', '{Tanggal:yyy-MM-dd hh:mm:ss}'," +
                $" '{Pelanggan.KodePelanggan}', '{Pegawai.KodePegawai}'";

            Execute.DML(sql1);

            foreach(NotaJualDetil nota in ListNotaJualDetil)
            {
                string sql2 = $"INSERT INTO NotaJualDetil(NoNota, KodeBarang, Harga, Jumlah) VALUES ('{NoNota}', '{nota.Barang.KodeBarang}', '{nota.Harga}', '{nota.Jumlah}')";

                Execute.DML(sql2);

                Barang.UpdateStok("penjualan", nota.Barang.KodeBarang, nota.Jumlah);
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
            throw new NotImplementedException();
        }

        public string GeneratePrimaryKey()
        {
            string sql = $"SELECT RIGHT(NoNota,3) as NoUrutTransaksi FROM notajual WHERE Date(Tanggal) = Date(CURRENT_DATE) ORDER BY Tanggal DESC limit 1";

            MySqlDataReader result = Execute.Query(sql);
            string hasilNota = "";

            if (result.Read())
            {
                if(result.GetValue(0).ToString() != "")
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
    }
}

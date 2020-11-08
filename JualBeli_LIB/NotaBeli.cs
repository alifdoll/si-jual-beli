using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class NotaBeli : IDatabase
    {
        private string noNota;
        private DateTime tanggal;
        private Supplier supplier;
        private Pegawai pegawai;
        private List<NotaBeliDetil> listNotaBeliDetil;


        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public List<NotaBeliDetil> ListNotaBeliDetil { get => listNotaBeliDetil; set => listNotaBeliDetil = value; }

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

        public void Insert()
        {
            string sql1 = $"INSERT INTO NotaBeli(NoNota, Tanggal, KodeSupplier, KodePegawai) VALUES ('{NoNota}', '{Tanggal:yyy-MM-dd hh:mm:ss}'," +
               $" '{Supplier.KodeSupplier}', '{Pegawai.KodePegawai}')";

            Execute.DML(sql1);

            foreach(NotaBeliDetil nota in ListNotaBeliDetil)
            {
                string sql2 = $"INSERT INTO NotaBeliDetil(NoNota, KodeBarang, Harga, Jumlah) VALUES ('{NoNota}', '{nota.Barang.KodeBarang}', '{nota.Harga}', '{nota.Jumlah}')";

                Execute.DML(sql2);

                Barang.UpdateStok("pembelian", nota.Barang.KodeBarang, nota.Jumlah);
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

        public void TambahNotBeliDetil(Barang barang, int harga, int jumlah)
        {
            NotaBeliDetil nota = new NotaBeliDetil(barang, harga, jumlah);

            ListNotaBeliDetil.Add(nota);
        }
    }
}

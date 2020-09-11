using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeli_LIB
{
    public class Kategori : Database
    {
        private string kodeKategori;
        private string nama;

        public Kategori()
        {
            KodeKategori = "";
            Nama = "";
        }

        public Kategori(string kode, string nama)
        {
            KodeKategori = kode;
            Nama = nama;
        }


        public string KodeKategori { get => kodeKategori; set => kodeKategori = value; }
        public string Nama { get => nama; set => nama = value; }
        

        public override void Insert()
        {
            string sql = "insert into kategori(KodeKategori, Nama) values ('" + kodeKategori +
               "','" + Nama.Replace("'", "\\") + "')";

            Koneksi.ExecuteDML(sql);
        }

        public override void Update()
        {
            string sql = "update kategori set Nama='" + Nama.Replace("'", "\\") + "' where KodeKategori='" +
               KodeKategori + "'";

            Koneksi.ExecuteDML(sql);
        }

        public override string Delete()
        {
            string sql = "DELETE FROM kategori WHERE KodeKategori = '" + KodeKategori + "'";

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

        public override ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql = QueryCommand("Kategori", criteria, value);

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);

            ArrayList listItem = new ArrayList();

            while (result.Read() == true)
            {
                Kategori kategori = new Kategori(result.GetValue(0).ToString(), result.GetValue(1).ToString());
                listItem.Add(kategori);
            }

            return listItem;
        }

        
    }
}
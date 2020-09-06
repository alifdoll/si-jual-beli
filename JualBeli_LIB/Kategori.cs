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
       
        public static string GenerateCode()
        {
            string sql = "select max(KodeKategori) from kategori";

            string code = "";

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);
            if(result.Read() == true)
            {
                int newCode = int.Parse(result.GetValue(0).ToString()) + 1;

                code = newCode.ToString().PadLeft(2, '0');
            }
            else
            {
                code = "01";
            }

            return code;
        }
    }
}
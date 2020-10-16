using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeli_LIB
{
    public class Kategori : IDatabase
    {
        private string kodeKategori;
        private string nama;

        public string KodeKategori { get => kodeKategori; set => kodeKategori = value; }
        public string Nama { get => nama; set => nama = value; }


        public Kategori(string kode = "", string nama = "")
        {
            KodeKategori = kode;
            Nama = nama;
        }

        public void Insert()
        {
            string sql = "insert into kategori(KodeKategori, Nama) values ('" + kodeKategori +
                "','" + Nama.Replace("'", "\\") + "')";

            Execute.DML(sql);
        }

        public void Update()
        {
            string sql = "update kategori set Nama='" + Nama.Replace("'", "\\") + "' where KodeKategori='" +
               KodeKategori + "'";

            Execute.DML(sql);
        }

        public string Delete()
        {
            string sql = "DELETE FROM kategori WHERE KodeKategori = '" + KodeKategori + "'";

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
                sql = "select * from Kategori"; 
            }
            else
            {
                sql = $"SELECT * FROM KATEGORI WHERE {criteria} LIKE '%{value}%'";
                
            }

            MySqlDataReader result = Execute.Query(sql);

            ArrayList list = new ArrayList();

            while (result.Read())
            {
                Kategori kategori = new Kategori(result.GetValue(0).ToString(), result.GetValue(1).ToString());
                list.Add(kategori);
            }
            return list;
        }

        public string GeneratePrimaryKey()
        {
            string command = "SELECT MAX(KodeKategori) FROM KATEGORI";
            int pKey;
            string code;
            MySqlDataReader result = Execute.Query(command);

            if (result.Read())
            {
                pKey = int.Parse(result.GetString(0)) + 1;
                code = pKey.ToString().PadLeft(2, '0');
                return code;
            }
            else
            {
                code = "01";
                return code;
            }


        }



    }
}
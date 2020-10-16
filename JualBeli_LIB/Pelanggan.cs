using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Pelanggan : IDatabase
    {
        private string kodePelanggan;
        private string nama;
        private string alamat;
        private string telepon;

        public string KodePelanggan { get => kodePelanggan; set => kodePelanggan = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Telepon { get => telepon; set => telepon = value; }


        public Pelanggan()
        {
            Nama = "";
            KodePelanggan = "";
            Alamat = "";
            Telepon = "";
        }

        public Pelanggan(string kode, string nama, string alamat = "-", string telp = "-")
        {
            KodePelanggan = kode;
            Nama = nama;
            Alamat = alamat;
            Telepon = telp;
        }


        public void Insert()
        {
            string sql = "insert into pelanggan(KodePelanggan, Nama, Alamat, Telepon) values ('" +
                KodePelanggan + "','" + Nama.Replace("'", "\\") + "','" +
                Alamat + "','" + Telepon + "')";

            Execute.DML(sql);
        }

        public void Update()
        {
            string sql = "update pelanggan set Nama='" + Nama.Replace("'", "\\") + "', Alamat='" +
                 Alamat + "',Telepon='" + Telepon + "' where KodePelanggan='" + KodePelanggan + "'";

            Execute.DML(sql);
        }

        public string Delete()
        {
            string sql = "DELETE FROM pelanggan WHERE KodePelanggan ='" + KodePelanggan + "'";

            try
            {
                Execute.DML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", sql : " + sql;
            }
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql = "";
            if (criteria == "")
            {
                sql = "select * from Pelanggan";
            }
            else
            {
                sql = "select * from Pelanggan where " + criteria + " like '%" + value + "%'";
            }

            MySqlDataReader result = Execute.Query(sql);

            ArrayList list = new ArrayList();

            while (result.Read())
            {
                Pelanggan pelanggan = new Pelanggan(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(),
                    result.GetValue(3).ToString());

                list.Add(pelanggan);
            }

            return list;
        }

        public string GeneratePrimaryKey()
        {
            string sql = $"SELECT Max(KodePelanggan) From Pelanggan";

            int pKey;

            MySqlDataReader result = Execute.Query(sql);

            if (result.Read())
            {
                pKey = result.GetInt32(0) + 1;
            }
            else
            {
                pKey = 1;
            }
            return pKey.ToString();
        }
    }
}

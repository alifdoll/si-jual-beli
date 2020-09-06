using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Pelanggan : Database
    {
        private string kodePelanggan;
        private string nama;
        private string alamat;
        private string telepon;
        
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


        public string KodePelanggan { get => kodePelanggan; set => kodePelanggan = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Telepon { get => telepon; set => telepon = value; }


        public override void Insert()
        {
            string sql = "insert into pelanggan(KodePelanggan, Nama, Alamat, Telepon) values ('" +
                KodePelanggan + "','" + Nama.Replace("'", "\\") + "','" +
                Alamat + "','" + Telepon + "')";

            Koneksi.ExecuteDML(sql);
        }

        public override void Update()
        {
            string sql = "update pelanggan set Nama='" + Nama.Replace("'", "\\") + "', Alamat='" +
                Alamat + "',Telepon='" + Telepon + "' where KodePelanggan='" + KodePelanggan + "'";

            Koneksi.ExecuteDML(sql);
        }

        public override string Delete()
        {
            string sql = "DELETE FROM pelanggan WHERE KodePelanggan ='" + KodePelanggan + "'";

            try
            {
                Koneksi.ExecuteDML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", sql : " + sql;
            }
        }

        public override ArrayList QueryData(Database database, string criteria = "", string value = "")
        {
            string sql = QueryCommand("Pelanggan", criteria, value);

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);

            ArrayList listItem = new ArrayList();

            while (result.Read() == true)
            {
                Database pelanggan = new Pelanggan(
                    result.GetValue(0).ToString(), 
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString(), 
                    result.GetValue(3).ToString());
                listItem.Add(pelanggan);
            }

            return listItem;
        }
    }
}

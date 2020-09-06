using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Pegawai : Database
    {
        #region members
        private string kodePegawai;
        private string nama;
        private DateTime lahir;
        private string alamat;
        private string gaji;
        private string username;
        private string password;
        private string id_jabatan;
        #endregion

        public Pegawai()
        {
            KodePegawai = "";
            Nama = "";
            Lahir = DateTime.Now;
            Alamat = "";
            Gaji = "";
            Username = "";
            Password = "";
            Id_jabatan = "";
        }

        public Pegawai(string kode, string nama, DateTime lahir, string alamat, string gaji, string username, string password, string jabatan)
        {
            KodePegawai = kode;
            Nama = nama;
            Lahir = lahir;
            Alamat = alamat;
            Gaji = gaji;
            Username = username;
            Password = password;
            Id_jabatan = jabatan;
        }

        #region properties
        public string KodePegawai { get => kodePegawai; set => kodePegawai = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Lahir { get => lahir; set => lahir = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Gaji { get => gaji; set => gaji = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Id_jabatan { get => id_jabatan; set => id_jabatan = value; }
        #endregion

        public override void Insert()
        {
            string sql = "insert into pegawai(Kodepegawai, Nama, tgllahir, alamat, gaji, username, password, idjabatan) values ('" +
                 KodePegawai + "','" +
                 Nama.Replace("'", "\\") + "','" +
                 Lahir + "','" +
                 Alamat + "'," +
                 Gaji + "','" +
                 Username + "','" +
                 Password + "','" +
                 Id_jabatan + "')";

            Koneksi.ExecuteDML(sql);
        }
        public override void Update()
        {
            string sql = "update pegawai set Nama='" + Nama.Replace("'", "\\") + 
                "', tgllahir='" + Lahir + 
                "',alamat='" + Alamat +
                "',gaji='" + Gaji +
                "',username='" + Username +
                "',password='" + Password +
                "',idjabatan='" + Id_jabatan + 
                "' where KodePegawai='" + KodePegawai + "'";


            Koneksi.ExecuteDML(sql);
        }
        public override string Delete()
        {
            string sql = "DELETE FROM pelanggan WHERE KodePegawai ='" + KodePegawai + "'";

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
            string sql = QueryCommand("Pegawai", criteria, value);

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);

            ArrayList listItem = new ArrayList();

            while (result.Read() == true)
            {
                Database pegawai = new Pegawai(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetDateTime(2),
                    result.GetValue(3).ToString(),
                    result.GetValue(4).ToString(),
                    result.GetValue(5).ToString(),
                    result.GetValue(6).ToString(),
                    result.GetValue(7).ToString());
            }

            return listItem;
        }

        



    }
}

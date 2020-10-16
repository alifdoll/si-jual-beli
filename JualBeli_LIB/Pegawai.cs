using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Pegawai : IDatabase
    {
        #region members
        private string kodePegawai;
        private string nama;
        private DateTime lahir;
        private string alamat;
        private int gaji;
        private string username;
        private string password;
        private Jabatan jabatan;
        #endregion

        #region properties
        public string KodePegawai { get => kodePegawai; set => kodePegawai = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime Lahir { get => lahir; set => lahir = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public int Gaji { get => gaji; set => gaji = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Jabatan Jabatan { get => jabatan; set => jabatan = value; }
        #endregion

        #region constructors
        public Pegawai()
        {
            KodePegawai = "";
            Nama = "";
            Lahir = DateTime.Now;
            Alamat = "";
            Gaji = 0;
            Username = "";
            Password = "";
            Jabatan = new Jabatan();
        }

        public Pegawai(string kode, string nama, DateTime lahir, string alamat, int gaji, string username, string password, Jabatan jabatan)
        {
            KodePegawai = kode;
            Nama = nama;
            Lahir = lahir;
            Alamat = alamat;
            Gaji = gaji;
            Username = username;
            Password = password;
            Jabatan = jabatan;
        }
        #endregion


        public void Insert()
        {
            string sql = "insert into pegawai(Kodepegawai, nama, tgllahir, alamat, gaji, username, password, idjabatan) values ('" +
                 KodePegawai + "','" +
                 Nama.Replace("'", "\\") + "','" +
                 Lahir.ToString("yyyy-MM-dd") + "','" +
                 Alamat + "','" +
                 Gaji + "','" +
                 Username + "','" +
                 Password + "','" +
                 Jabatan.IdJabatan + "')";

            Execute.DML(sql);
        }

        public void Update()
        {
            string sql = "update pegawai set Nama='" + Nama.Replace("'", "\\") +
               "', tgllahir='" + Lahir.ToString("yyyy-MM-dd") +
               "',alamat='" + Alamat +
               "',gaji='" + Gaji +
               "',username='" + Username +
               "',password='" + Password +
               "',idjabatan='" + Jabatan +
               "' where KodePegawai='" + KodePegawai + "'";


            Execute.DML(sql);
        }

        public string Delete()
        {
            string sql = "DELETE FROM pegawai WHERE KodePegawai ='" + KodePegawai + "'";

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

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql;

            if (criteria == "")
            {
                sql = "SELECT pegawai.kodepegawai, pegawai.Nama, pegawai.TglLahir, pegawai.Alamat, pegawai.Gaji ,pegawai.Username, pegawai.Password, pegawai.IdJabatan, jabatan.Nama as namaJabatan " +
                    "FROM pegawai INNER JOIN jabatan on pegawai.IdJabatan = jabatan.IdJabatan";
            }
            else
            {
                sql = "SELECT pegawai.kodepegawai, pegawai.Nama, pegawai.TglLahir, pegawai.Alamat, pegawai.Gaji ,pegawai.Username, pegawai.Password, pegawai.IdJabatan, jabatan.Nama as namaJabatan " +
                    "FROM pegawai INNER JOIN jabatan on pegawai.IdJabatan = jabatan.IdJabatan " +
                    " where " + criteria + " LIKE '%" + value + "%'";
            }

            MySqlDataReader result = Execute.Query(sql);

            ArrayList list = new ArrayList();

            while (result.Read())
            {
                Jabatan jabatan = new Jabatan(
                    result.GetString(7),
                    result.GetString(8));

                Pegawai pegawai = new Pegawai(
                    result.GetString(0),
                    result.GetString(1),
                    result.GetDateTime(2),
                    result.GetString(3),
                    result.GetInt32(4),
                    result.GetString(5),
                    result.GetString(6),
                    jabatan);

                list.Add(pegawai);
            }

            return list;
        }

        public string GeneratePrimaryKey()
        {
            string sql = "SELECT MAX(kodepegawai) FROM Pegawai";
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

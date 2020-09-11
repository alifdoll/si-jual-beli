using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Jabatan : Database
    {
        private string idJabatan;
        private string nama;

        public Jabatan()
        {
            IdJabatan = "";
            Nama = "";
        }

        public Jabatan(string idJabatan, string nama)
        {
            IdJabatan = idJabatan;
            Nama = nama;
        }

        public string IdJabatan { get => idJabatan; set => idJabatan = value; }
        public string Nama { get => nama; set => nama = value; }

        public override void Insert()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
        
        public override string Delete()
        {
            throw new NotImplementedException();
        }

        public override ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql = QueryCommand("jabatan", criteria, value);

            ArrayList listItem = new ArrayList();

            MySqlDataReader result = Koneksi.ExecuteQuery(sql);

            while(result.Read() == true)
            {
                Jabatan jabatan = new Jabatan(result.GetString(0), result.GetString(1));
                listItem.Add(jabatan);
            }

            return listItem;
        }

    }
}

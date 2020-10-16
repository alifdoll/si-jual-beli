using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Jabatan : IDatabase
    {
        private string idJabatan;
        private string nama;

        public string IdJabatan { get => idJabatan; set => idJabatan = value; }
        public string Nama { get => nama; set => nama = value; }

        public Jabatan(string idJabatan = "", string nama = "")
        {
            IdJabatan = idJabatan;
            Nama = nama;
        }

        public void Insert()
        {
            string sql = $"INSERT INTO Jabatan(IdJabatan, Nama) Values('{IdJabatan}', '{Nama}')";
            Execute.DML(sql);
        }

        public void Update()
        {
            string sql = $"UPDATE Jabatan set Nama='{Nama}' WHERE IdJabatan='{IdJabatan}'";
            Execute.DML(sql);
        }

        public string Delete()
        {
            string command = $"DELETE FROM Jabatan WHERE IdJabatan='{IdJabatan}'";
            try
            {
                Execute.DML(command);
                return "1";
            }
            catch(Exception error)
            {
                return $"{error.Message}, Command : {command}";
            }
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql;
            if(criteria == "")
            {
                sql = $"SELECT * FROM Jabatan";
            }
            else
            {
                sql = $"SELECT IdJabatan, Nama FROM Jabatan WHERE {criteria} LIKE '%{value}%'";
            }

            MySqlDataReader result = Execute.Query(sql);

            ArrayList list = new ArrayList();

            while (result.Read())
            {
                Jabatan jabatan = new Jabatan(
                    result.GetValue(0).ToString(),
                    result.GetValue(1).ToString());

                list.Add(jabatan);
            }
            return list;
        }

        public string GeneratePrimaryKey()
        {
            string sql = $"SELECT MAX(RIGHT(IdJabatan,1)) FROM jabatan";

            string pKey;

            MySqlDataReader result = Execute.Query(sql);

            if (result.Read())
            {
                int code = result.GetInt32(0) + 1;
                pKey = $"J{code}";
            }
            else
            {
                pKey = "J1";
            }
            return pKey;
        }



    }
}

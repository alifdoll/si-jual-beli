using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JualBeli_LIB
{
    public abstract class Database
    {
        public abstract void Insert();

        public abstract void Update();

        public abstract string Delete();

        public static ArrayList ReadData(string database, string criteria = "", string value = "")
        {
            string sql = "";
            if (criteria == "")
            {
                sql = "select * from " + database;
            }
            else
            {
                sql = "select * from " + database + " where " + criteria + " like '%" + value + "%'";
            }

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

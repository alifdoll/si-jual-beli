using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JualBeli_LIB
{
    public class Execute
    {
        public static void DML(string sql)
        {
            Koneksi koneksi = new Koneksi();

            koneksi.ConnectToDb();

            MySqlCommand command = new MySqlCommand(sql, koneksi.KoneksiDB);

            command.ExecuteNonQuery();

        }

        public static MySqlDataReader Query(string sql)
        {
            Koneksi koneksi = new Koneksi();

            MySqlCommand command = new MySqlCommand(sql, koneksi.KoneksiDB);

            MySqlDataReader result = command.ExecuteReader();

            return result;
        }
    }
}

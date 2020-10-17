using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace JualBeli_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }

        public Koneksi()
        {
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            ConnectToDb();
        }

        public Koneksi(string pServer, string pDatabase, string username, string password)
        {
            string connection;
            if (password != "")
            {
                connection = "Server=" + pServer + ";Database=" + pDatabase + ";Uid=" + username + ";Pwd=" + password + ";";
            }
            else
            {
                connection = "Server=" + pServer + ";Database=" + pDatabase + ";Uid=" + username + ";";
            }
            KoneksiDB = new MySqlConnection
            {
                ConnectionString = connection
            };

            ConnectToDb();
            UpdateAppConfig(connection);
        }

        public void ConnectToDb()
        {
            if(KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }

            KoneksiDB.Open();
        }

        public void CloseConnection()
        {
            KoneksiDB.Close();
        }

        public void UpdateAppConfig(string connection)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = connection;

            config.Save(ConfigurationSaveMode.Modified, true);

            ConfigurationManager.RefreshSection("connectionStrings");
        }



        public static void ExecuteDML(string sql)
        {
            Koneksi koneksi = new Koneksi();

            koneksi.ConnectToDb();

            MySqlCommand command = new MySqlCommand(sql, koneksi.KoneksiDB);

            command.ExecuteNonQuery();
        }

        public static MySqlDataReader ExecuteQuery(string sql)
        {
            Koneksi koneksi = new Koneksi();

            MySqlCommand command = new MySqlCommand(sql, koneksi.KoneksiDB);

            MySqlDataReader result = command.ExecuteReader();

            return result;
        }

        public static string GetServerName()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return connection.DataSource;
        }

        public static string GetDatabaseName()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString;

            return connection.Database;
        }
    }
}

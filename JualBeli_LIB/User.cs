using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class User
    {
        public static void CreateNewUser(string username, string password, string server = "localhost")
        {
            string sql = $"create user '{username}'@'{server}' identified by '{password}'";
            Execute.DML(sql);
            GrantPrivilege(username, password);
        }

        public static void GrantPrivilege(string username, string password, string server = "localhost")
        {
            string database = Koneksi.GetDatabaseName();
            string sql = $"grant all privileges on {database}.* to '{username}'@'{server}' identified by '{password}'";
            Execute.DML(sql);
        }

        public static void DeleteUser(string username)
        {
            string sql = $"DROP USER '{username}'@'localhost'";
            Execute.DML(sql);
        }

        public static void Management(string username, string password)
        {
            string server = Koneksi.GetServerName();

            CreateNewUser(username, password);
        }

        public static void ChangeUserPassword(string username, string newPass)
        {
            string server = Koneksi.GetServerName();
            string sql = $"SET PASSWORD FOR '{username}'@'localhost'=PASSWORD('{newPass}')";
            Execute.DML(sql);

        }

    }
}

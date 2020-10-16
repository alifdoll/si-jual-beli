using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class Supplier : IDatabase
    {
        private string kodeSupplier;
        private string nama;
        private string alamat;

        public string KodeSupplier { get => kodeSupplier; set => kodeSupplier = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }

        public Supplier(string kode = "", string nama = "", string alamat = "")
        {
            KodeSupplier = kode;
            Nama = nama;
            Alamat = alamat;
        }

        public void Insert()
        {
            string sql = "insert into Supplier(KodeSupplier, Nama, Alamat) values ('" + KodeSupplier +
               "','" + Nama.Replace("'", "\\") + "','" + Alamat + "')";

            Execute.DML(sql);
        }

        public void Update()
        {
            string sql = "update supplier set Nama='" + Nama.Replace("'", "\\") + "', Alamat='" + Alamat + "' where KodeSupplier='" +
                 KodeSupplier + "'";

            Execute.DML(sql);
        }

        public string Delete()
        {
            string sql = "DELETE FROM supplier WHERE KodeSupplier = '" + KodeSupplier + "'";

            try
            {
                Execute.DML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", Perintah sql : " + sql;
            }
        }

        public ArrayList QueryData(string criteria = "", string value = "")
        {
            string sql;
            if (criteria == "")
            {
                sql = "select * from supplier";
            }
            else
            {
                sql = $"SELECT * FROM SUPPLIER WHERE {criteria} LIKE '%{value}%'";

            }

            MySqlDataReader result = Execute.Query(sql);

            ArrayList list = new ArrayList();

            while (result.Read())
            {
                Supplier supplier = new Supplier(result.GetValue(0).ToString(),
                    result.GetValue(1).ToString(),
                    result.GetValue(2).ToString());

                list.Add(supplier);
            }
            return list;
        }

        public string GeneratePrimaryKey()
        {
            string command = "SELECT MAX(KodeKategori) FROM KATEGORI";
            int pKey;
            MySqlDataReader result = Execute.Query(command);

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

        /* public override void Insert()
         {
             
         }

         public override void Update()
         {
             
         }

         public override string Delete()
         {
             
         }

         public override ArrayList QueryData(string criteria = "", string value = "")
         {
             string sql = QueryCommand("Supplier", criteria, value);

             MySqlDataReader result = Koneksi.ExecuteQuery(sql);

             ArrayList listItem = new ArrayList();

             while (result.Read() == true)
             {
                 Supplier Supplier = new Supplier(
                     result.GetValue(0).ToString(),
                     result.GetValue(1).ToString(),
                     result.GetValue(2).ToString());
                 listItem.Add(Supplier);
             }

             return listItem;
         } */



    }
}

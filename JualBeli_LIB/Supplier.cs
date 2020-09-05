using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    class Supplier : Database
    {
        private string kodeSupplier;
        private string nama;
        private string alamat;

        public Supplier()
        {
            KodeSupplier = "";
            Nama = "";
            Alamat = "";
        }

        public Supplier(string kode, string nama, string alamat)
        {
            KodeSupplier = kode;
            Nama = nama;
            Alamat = alamat;
        }

        public string KodeSupplier { get => kodeSupplier; set => kodeSupplier = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }


        public static void AddData(Supplier supplier)
        {
            string sql = "insert into Supplier(KodeSupplier, Nama, Alamat) values ('" + supplier.KodeSupplier +
               "','" + supplier.Nama.Replace("'", "\\")  + "','" + supplier.Alamat + "')";

            Koneksi.ExecuteDML(sql);
        }

        public static void UpdateData(Supplier supplier)
        {
            string sql = "update supplier set Nama='" + supplier.Nama.Replace("'", "\\") + "', Alamat='" + supplier.Alamat + "' where KodeSupplier='" +
                supplier.KodeSupplier + "'";

            Koneksi.ExecuteDML(sql);
        }

        public static string DeleteData(Supplier supplier)
        {
            string sql = "DELETE FROM supplier WHERE KodeSupplier = '" + supplier.KodeSupplier + "'";

            try
            {
                Koneksi.ExecuteDML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", Perintah sql : " + sql;
            }
        }

        public override void Insert()
        {
            string sql = "insert into Supplier(KodeSupplier, Nama, Alamat) values ('" + KodeSupplier +
              "','" + Nama.Replace("'", "\\") + "','" + Alamat + "')";

            Koneksi.ExecuteDML(sql);
        }

        public override void Update()
        {
            string sql = "update supplier set Nama='" + Nama.Replace("'", "\\") + "', Alamat='" + Alamat + "' where KodeSupplier='" +
                KodeSupplier + "'";

            Koneksi.ExecuteDML(sql);
        }

        public override string Delete()
        {
            string sql = "DELETE FROM supplier WHERE KodeSupplier = '" + KodeSupplier + "'";

            try
            {
                Koneksi.ExecuteDML(sql);
                return "1";
            }
            catch (Exception error)
            {
                return error.Message + ", Perintah sql : " + sql;
            }
        }
    }
}

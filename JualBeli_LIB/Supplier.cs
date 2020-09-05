﻿using System;
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

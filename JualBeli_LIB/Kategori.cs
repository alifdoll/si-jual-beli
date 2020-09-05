﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeli_LIB
{
    public class Kategori : Database
    {
        private string kodeKategori;
        private string nama;

        public Kategori()
        {
            KodeKategori = "";
            Nama = "";
        }

        public Kategori(string kode, string nama)
        {
            KodeKategori = kode;
            Nama = nama;
        }


        public string KodeKategori { get => kodeKategori; set => kodeKategori = value; }
        public string Nama { get => nama; set => nama = value; }
        
        public static void AddData(Kategori kategori)
        {
            string sql = "insert into kategori(KodeKategori, Nama) values ('" + kategori.kodeKategori +
                "','" + kategori.Nama.Replace("'", "\\") + "')";

            Koneksi.ExecuteDML(sql);
        }
        
        public static void UpdateData(Kategori kategori)
        {
            string sql = "update kategori set Nama='" + kategori.Nama.Replace("'", "\\") + "' where KodeKategori='" +
               kategori.KodeKategori + "'";

            Koneksi.ExecuteDML(sql);
        }

        public static string DeleteData(Kategori kategori)
        {
            string sql = "DELETE FROM kategori WHERE KodeKategori = '" + kategori.KodeKategori + "'";

            try
            {
                Koneksi.ExecuteDML(sql);
                return "1";
            }
            catch(Exception error)
            {
                return error.Message + ", Perintah sql : " + sql;
            }
        }

        public override void Insert()
        {
            string sql = "insert into kategori(KodeKategori, Nama) values ('" + kodeKategori +
               "','" + Nama.Replace("'", "\\") + "')";

            Koneksi.ExecuteDML(sql);
        }

        public override void Update()
        {
            string sql = "update kategori set Nama='" + Nama.Replace("'", "\\") + "' where KodeKategori='" +
               KodeKategori + "'";

            Koneksi.ExecuteDML(sql);
        }

        public override string Delete()
        {
            string sql = "DELETE FROM kategori WHERE KodeKategori = '" + KodeKategori + "'";

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
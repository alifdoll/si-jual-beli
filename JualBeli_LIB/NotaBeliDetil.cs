using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class NotaBeliDetil
    {
        private Barang barang;
        private int harga;
        private int jumlah;


        public Barang Barang { get => barang; set => barang = value; }
        public int Harga { get => harga; set => harga = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }


        public NotaBeliDetil(Barang barang, int harga, int jumlah)
        {
            Barang = barang;
            Harga = harga;
            Jumlah = jumlah;
        }
    }
}

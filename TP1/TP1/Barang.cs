using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Barang
    {
        public string nama { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }

        public Barang(string nama, int harga, string jenis)
        {
            this.nama = nama;
            this.harga = harga;
            this.jenis = jenis;
        }
        

    }
}

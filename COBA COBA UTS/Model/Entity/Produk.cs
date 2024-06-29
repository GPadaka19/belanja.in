using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace COBA_COBA_UTS.Model.Entity
{
    public class Produk
    {
        public int Id_produk { get; set; }
        public string Nama { get; set; }
        public string Stock { get; set; }
        public string Harga { get; set; }
        public byte[] FotoData { get; set; } // Menggunakan byte[] untuk menampung data BLOB dari gambar

    }

}

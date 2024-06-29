using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace COBA_COBA_UTS.Model.Entity
{
    public class Cart
    {
        public string Id_Keranjang { get; set; }
        public decimal Jumlah { get; set; }
        public string Id_produk { get; set; }
        public string Nama { get; set; }
        public string Harga { get; set; }
        public decimal SubPrice { get; set; }
        public byte[] FotoData { get; set; }
        public string Username { get; set; }

        public List<Produk> Products { get; set; }

        public Cart()
        {
            Products = new List<Produk>();
        }

    }
}

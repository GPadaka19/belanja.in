using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBA_COBA_UTS.Model.Entity
{
    public class Payment
    {
        public string Id_Payment { get; set; }
        public string Id_Keranjang { get; set; }
        public string Jumlah { get; set; }
        public string Id_produk { get; set; }
        public string Nama { get; set; }
        public string Harga { get; set; }
        public byte[] FotoData { get; set; }
        public string Total { get; set; }
        public decimal SubPrice {  get; set; }
        public string Username { get; set; }
        public DateTime tanggal { get; set; }
        public string Id_promo { get; set; }
        public string Id_ekspedisi { get; set; }

        public List<Cart> carts { get; set; }

        public Payment()
        {
           carts = new List<Cart>();
        }
    }
}

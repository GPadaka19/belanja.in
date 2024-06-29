using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBA_COBA_UTS.Model.Entity
{
    public class History
    {
        public string Id_produk { get; set; }
        public string Nama { get; set; }
        public string Harga { get; set; }
        public byte[] FotoData { get; set; }
        public string Id_Keranjang { get; set; }
        public string Jumlah { get; set; }
        public string Total { get; set; }
        public decimal SubPrice { get; set; }
        public DateTime tanggal { get; set; }

        public List<Payment> payments{ get; set; }

        public History()
        {
            payments = new List<Payment>();
        }
    }
}

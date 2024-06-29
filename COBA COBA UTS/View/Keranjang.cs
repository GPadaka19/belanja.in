using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace COBA_COBA_UTS
{
    public partial class Keranjang : Form
    {
        private BelanjaController belanjaController;
        private Homepage homepage;

        public Keranjang(Homepage homepage)
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            LoadProducts();
            this.homepage = homepage;

        }
        private void LoadProducts()
        {
            List<Cart> cartItems = belanjaController.GetAllProductsInCart();

            foreach (Cart cartItem in cartItems)
            {
                // Mendapatkan informasi produk berdasarkan Id_produk dari belanjaController
                Produk product = belanjaController.GetProductById(cartItem.Id_produk);

                if (product != null)
                {
                    // Membuat instance UserControl2 baru dengan informasi dari CartItem dan Produk
                    UserControl2 newProductControl = new UserControl2(homepage, cartItem);

                    // Menetapkan informasi produk ke instance UserControl2
                    newProductControl.ProductImage = belanjaController.GetImageFromBlob(product.FotoData);
                    newProductControl.ProductNames = product.Nama;
                    newProductControl.ProductJumlah = cartItem.Jumlah.ToString();
                    newProductControl.ProductPrice = cartItem.SubPrice.ToString();

                    // Menambahkan newProductControl ke flowLayoutPanel1
                    flowLayoutPanel1.Controls.Add(newProductControl);
                }
            }
        }


        private void AddToPaymentButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

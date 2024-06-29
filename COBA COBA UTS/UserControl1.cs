using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.Model.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace COBA_COBA_UTS
{
    // UserControl1 class

    public partial class UserControl1 : UserControl
    {
        private BelanjaController belanjaController;
        private Homepage homepage;
        public UserControl1(Homepage homepage)
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            this.homepage = homepage; // This will assign 'null' to 'homepage'
        }

        // Define properties or methods to set product information
        public Image ProductImage
        {
            get => Foto.Image;
            set => Foto.Image = value;
        }

        public string ProductNames
        {
            get => Nama.Text;
            set => Nama.Text = value;
        }

        public string ProductStock
        {
            get => Stok.Text;
            set => Stok.Text = value;
        }

        public string ProductPrice
        {
            get => Harga.Text;
            set => Harga.Text = "Rp " + value;
        }


        // Di dalam UserControl1
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Produk produk = new Produk
            {
                Nama = ProductNames,
                Stock = ProductStock,
                Harga = ProductPrice,
            };

            if (homepage.GetIconButton2Text() != "Login")
            {
                Cart cart = new Cart(); // Membuat instance Cart baru
                cart.Products.Add(produk); // Menambahkan produk ke dalam Cart

                int result = belanjaController.AddToCart(produk);

                if (result > 0)
                {
                    MessageBox.Show("Product added to cart successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to add product to cart.");
                }
            }
            else
            {
                MessageBox.Show("Silahkan login terlebih dahulu!");
            }


        }

    }

}


